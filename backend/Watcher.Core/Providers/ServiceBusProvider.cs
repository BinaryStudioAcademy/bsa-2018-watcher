namespace Watcher.Core.Providers
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Azure.ServiceBus;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using ServiceBus.Shared.Common;
    using ServiceBus.Shared.Messages;
    using ServiceBus.Shared.Queue;

    using Watcher.Common.Dtos.Plots;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;

    public class ServiceBusProvider : IServiceBusProvider, IDisposable
    {
        private readonly ILogger<ServiceBusProvider> _logger;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<DashboardsHub> _dashboardsHubContext;
        private readonly IOptions<AzureQueueSettings> _queueOptions;
        private readonly IAzureQueueReceiver _azureQueueReceiver;

        private readonly QueueClient _instanceDataQueueClient;
        private readonly QueueClient _instanceErrorQueueClient;

        public ServiceBusProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IHubContext<DashboardsHub> dashboardsHubContext,
            IOptions<AzureQueueSettings> queueOptions,
            IAzureQueueReceiver azureQueueReceiver)
        {
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>() ?? throw new ArgumentNullException(nameof(loggerFactory));
            _scopeFactory = scopeFactory;
            _dashboardsHubContext = dashboardsHubContext;
            _queueOptions = queueOptions;
            _instanceDataQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.DataQueueName);
            _instanceErrorQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.ErrorQueueName);

            _azureQueueReceiver = azureQueueReceiver;
            _azureQueueReceiver.Receive<InstanceCollectedDataMessage>(
                _instanceDataQueueClient,
                OnProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);

            // TODO: Check if I can use this method for other queue with diff MessageType
            _azureQueueReceiver.Receive<InstanceErrorMessage>(
                _instanceErrorQueueClient,
                OnErrorProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);
        }

        private void OnWait()
        {
            Debug.WriteLine("*******************WAITING***********************");
        }

        private async Task<MessageProcessResponse> OnErrorProcessAsync(InstanceErrorMessage arg, CancellationToken stoppingToken)
        {
            if (stoppingToken.IsCancellationRequested)
            {
                _logger.LogError("Cancellation was requested, stopping token.");
                return MessageProcessResponse.Abandon;
            }

            await _dashboardsHubContext.Clients.Group(arg.InstanceId.ToString()).SendAsync("Send", arg.ErrorMessage);
            _logger.LogError("ERROR Message to hub clients was sent.");
            return MessageProcessResponse.Complete;
        }

        private async Task<MessageProcessResponse> OnProcessAsync(InstanceCollectedDataMessage arg, CancellationToken stoppingToken)
        {
            if (stoppingToken.IsCancellationRequested)
            {
                _logger.LogError("Cancellation was requested, stopping token.");
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
            _logger.LogError("DATA Message to hub clients was sent.");
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

        // To detect redundant calls
        private bool disposedValue;

        public async Task CloseClient()
        {
            if (!disposedValue)
            {
                await _instanceDataQueueClient.CloseAsync();

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            CloseClient().GetAwaiter().GetResult();
        }
    }
}