namespace Watcher.Core.Providers
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.Shared.Models;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Azure.ServiceBus;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Serilog.Context;

    using ServiceBus.Shared.Common;
    using ServiceBus.Shared.Messages;
    using ServiceBus.Shared.Queue;

    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;

    public class ServiceBusProvider : IServiceBusProvider, IDisposable
    {
        private readonly ILogger<ServiceBusProvider> _logger;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<DashboardsHub> _dashboardsHubContext;
        private readonly IHubContext<NotificationsHub> _notificationsHubContext;
        private readonly IOptions<AzureQueueSettings> _queueOptions;
        private readonly IAzureQueueReceiver _azureQueueReceiver;
        private readonly IAzureQueueSender _azureQueueSender;

        private readonly QueueClient _instanceDataQueueClient;
        private readonly QueueClient _instanceErrorQueueClient;
        private readonly QueueClient _instanceSettingsQueueClient;
        private readonly QueueClient _instanceNotifyQueueClient;

        public ServiceBusProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IHubContext<DashboardsHub> dashboardsHubContext,
            IHubContext<NotificationsHub> notificationsHubContext,
            IOptions<AzureQueueSettings> queueOptions,
            IAzureQueueReceiver azureQueueReceiver,
            IAzureQueueSender azureQueueSender)
        {
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>() ?? throw new ArgumentNullException(nameof(loggerFactory));
            _scopeFactory = scopeFactory;
            _dashboardsHubContext = dashboardsHubContext;
            _notificationsHubContext = notificationsHubContext;
            _queueOptions = queueOptions;
            _instanceDataQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.DataQueueName);
            _instanceErrorQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.ErrorQueueName);
            _instanceSettingsQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.SettingsQueueName);
            _instanceNotifyQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.NotifyQueueName);

            _azureQueueReceiver = azureQueueReceiver;
            _azureQueueReceiver.Receive<InstanceCollectedDataMessage>(
                _instanceDataQueueClient,
                OnProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);
            
            _azureQueueReceiver.Receive<InstanceErrorMessage>(
                _instanceErrorQueueClient,
                OnErrorProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);

            _azureQueueReceiver.Receive<InstanceValidatorMessage>(
                _instanceErrorQueueClient,
                OnNotifyProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);

            _azureQueueSender = azureQueueSender;
        }

        private void OnWait()
        {
            Debug.WriteLine("*******************WAITING***********************");
        }

        public Task SendInstanceSettingsAsync(InstanceSettingsMessage message)
        {
            return _azureQueueSender.SendAsync(_instanceSettingsQueueClient, message);
        }

        private async Task<MessageProcessResponse> OnErrorProcessAsync(InstanceErrorMessage arg, CancellationToken stoppingToken)
        {
            if (stoppingToken.IsCancellationRequested)
            {
                using (LogContext.PushProperty("ClassName", this.GetType().FullName))
                using (LogContext.PushProperty("Source", this.GetType().Name))
                {
                    _logger.LogError("Cancellation was requested, stopping token.");
                }

                return MessageProcessResponse.Abandon;
            }

            await _dashboardsHubContext.Clients.Group(arg.InstanceId.ToString()).SendAsync("Send", arg.ErrorMessage);
            _logger.LogInformation("Error Message with to Dashboards hub clients was sent.");
            return MessageProcessResponse.Complete;
        }

        private async Task<MessageProcessResponse> OnNotifyProcessAsync(InstanceValidatorMessage arg, CancellationToken stoppingToken)
        {
            if (stoppingToken.IsCancellationRequested)
            {
                using (LogContext.PushProperty("ClassName", this.GetType().FullName))
                using (LogContext.PushProperty("Source", this.GetType().Name))
                {
                    _logger.LogError("Cancellation was requested, stopping token.");
                }

                return MessageProcessResponse.Abandon;
            }

            await _notificationsHubContext.Clients.Group(arg.InstanceId.ToString()).SendAsync("Send", arg.ValidatorMessage);
            _logger.LogInformation("Validator Message with to Dashboards hub clients was sent.");
            return MessageProcessResponse.Complete;
        }

        private async Task<MessageProcessResponse> OnProcessAsync(InstanceCollectedDataMessage arg, CancellationToken stoppingToken)
        {
            if (stoppingToken.IsCancellationRequested)
            {
                using (LogContext.PushProperty("ClassName", this.GetType().FullName))
                using (LogContext.PushProperty("Source", this.GetType().Name))
                {
                    _logger.LogError("Cancellation was requested, stopping token.");
                }

                return MessageProcessResponse.Abandon;
            }

            CollectedDataDto dto = null;
            using (var scope = _scopeFactory.CreateScope())
            {
                var repo = scope.ServiceProvider.GetRequiredService<IDataAccumulatorRepository<CollectedData>>();
                var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

                var data = await repo.GetEntityIdAsync(arg.CollectedDataId);

                if (data != null)
                {
                    dto = mapper.Map<CollectedData, CollectedDataDto>(data);
                }
                else
                {
                    return MessageProcessResponse.Abandon; // No such entity
                }
            }

            await _dashboardsHubContext.Clients.Group(dto.ClientId.ToString()).SendAsync("InstanceDataTick", dto);
            _logger.LogInformation("Information Message with instanceData to Dashboards hub clients was sent.");
            return MessageProcessResponse.Complete;
        }

        private void ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            _logger.LogError($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            _logger.LogError("Exception context for troubleshooting:");
            _logger.LogError($"- Endpoint: {context.Endpoint}");
            _logger.LogError($"- Entity Path: {context.EntityPath}");
            _logger.LogError($"- Executing Action: {context.Action}");
        }

        private void ExceptionWhileProcessingHandler(Exception ex)
        {
            _logger.LogError($"Message handler encountered an exception {ex.Message}.");
        }

        #region Disposable Support

        // To detect redundant calls
        private bool disposedValue;

        public async Task CloseClient()
        {
            if (!disposedValue)
            {
                await _instanceDataQueueClient.CloseAsync();
                await _instanceErrorQueueClient.CloseAsync();
                await _instanceSettingsQueueClient.CloseAsync();
                await _instanceNotifyQueueClient.CloseAsync();

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            CloseClient().GetAwaiter().GetResult();
        }

        #endregion
    }
}