namespace Watcher.Core.Providers
{
    using System;
    using System.Collections.Generic;
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
    using ServiceBus.Shared.Enums;
    using ServiceBus.Shared.Messages;
    using ServiceBus.Shared.Queue;

    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;
    using Watcher.Common.Requests;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Interfaces;

    public class ServiceBusProvider : IServiceBusProvider, IDisposable
    {
        private readonly ILogger<ServiceBusProvider> _logger;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHubContext<DashboardsHub> _dashboardsHubContext;
        private readonly IOptions<AzureQueueSettings> _queueOptions;
        private readonly IAzureQueueReceiver _azureQueueReceiver;
        private readonly IAzureQueueSender _azureQueueSender;

        private readonly QueueClient _instanceDataQueueClient;
        private readonly QueueClient _instanceErrorQueueClient;
        private readonly QueueClient _instanceSettingsQueueClient;
        private readonly QueueClient _instanceNotifyQueueClient;
        private readonly QueueClient _instanceAnomalyReportQueueClient;

        public ServiceBusProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IHubContext<DashboardsHub> dashboardsHubContext,
            IOptions<AzureQueueSettings> queueOptions,
            IAzureQueueReceiver azureQueueReceiver,
            IAzureQueueSender azureQueueSender)
        {
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>() ?? throw new ArgumentNullException(nameof(loggerFactory));
            _scopeFactory = scopeFactory;
            _dashboardsHubContext = dashboardsHubContext;
            _queueOptions = queueOptions;
            _instanceDataQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.DataQueueName);
            _instanceErrorQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.ErrorQueueName);
            _instanceSettingsQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.SettingsQueueName);
            _instanceNotifyQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.NotifyQueueName);
            _instanceAnomalyReportQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.AnomalyReportQueueName);

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

            _azureQueueReceiver.Receive<InstanceNotificationMessage>(
                _instanceNotifyQueueClient,
                OnNotifyProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);

            _azureQueueReceiver.Receive<InstanceAnomalyReportMessage>(
                _instanceAnomalyReportQueueClient,
                OnAnomalyReportProcessAsync,
                ExceptionReceivedHandler,
                ExceptionWhileProcessingHandler,
                OnWait);

            _azureQueueSender = azureQueueSender;
        }

        private async Task<MessageProcessResponse> OnAnomalyReportProcessAsync(InstanceAnomalyReportMessage arg, CancellationToken stoppingToken)
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


            using (var scope = _scopeFactory.CreateScope())
            {
                var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
                var reportsService = scope.ServiceProvider.GetRequiredService<IInstanceAnomalyReportsService>();
                var report = await reportsService.GetReportByIdAsync(arg.AnomalyReportId);
                var notificationRequest = new NotificationRequest
                                              {
                                                  CreatedAt = report.Date,
                                                  InstanceId = report.ClientId,
                                                  Type = NotificationType.Info
                                              };

                var htmlFileUrl = await notificationService.CreateAnomalyReportNotificationAsync(notificationRequest, report);

                if (!string.IsNullOrWhiteSpace(htmlFileUrl))
                {
                    await reportsService.UpdateReportAsync(report.Id, htmlFileUrl);
                    // return MessageProcessResponse.Abandon;
                }
            }

            _logger.LogInformation("Instance Notification Message was created.");

            return MessageProcessResponse.Complete;
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

        private async Task<MessageProcessResponse> OnNotifyProcessAsync(InstanceNotificationMessage arg, CancellationToken stoppingToken)
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

            using (var scope = _scopeFactory.CreateScope())
            {
                var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                var notificationRequest = new NotificationRequest
                {
                    Text = arg.Text,
                    CreatedAt = arg.CreatedAt,
                    InstanceId = arg.InstanceId
                };

                switch (arg.Type)
                {
                    case InstanceNotifyType.Critical:
                        notificationRequest.Type = NotificationType.Error;
                        break;
                    case InstanceNotifyType.Error:
                        notificationRequest.Type = NotificationType.Warning;
                        break;
                    default:
                        notificationRequest.Type = NotificationType.Info;
                        break;
                }

                var result = await notificationService.CreateEntityAsync(notificationRequest);

                if (result == null)
                {
                    return MessageProcessResponse.Abandon;
                }
            }

            _logger.LogInformation("Instance Notification Message was created.");

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

            CollectedDataDto collectedDataDto = null;
            InstanceCheckedDto instanceCheckedDto = null;
            using (var scope = _scopeFactory.CreateScope())
            {
                var repo = scope.ServiceProvider.GetRequiredService<IDataAccumulatorRepository<CollectedData>>();
                var uow = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
                var data = await repo.GetEntityIdAsync(arg.CollectedDataId);

                if (data != null)
                {
                    var result = await uow.InstanceRepository.UpateLastCheckedAsync(arg.InstanceId, data.Time);
                    if (result != null)
                    {
                        await uow.SaveAsync();
                        instanceCheckedDto = new InstanceCheckedDto
                        {
                            InstanceGuidId = result.GuidId,
                            OrganizationId = result.OrganizationId,
                            StatusCheckedAt = result.StatusCheckedAt
                        };
                    }

                    collectedDataDto = mapper.Map<CollectedData, CollectedDataDto>(data);
                }
                else
                {
                    return MessageProcessResponse.Abandon; // No such entity
                }
            }

            var tasks = new List<Task>(2);
            if (collectedDataDto != null)
            {
                tasks.Add(_dashboardsHubContext.Clients.Group(collectedDataDto.ClientId.ToString()).SendAsync("InstanceDataTick", collectedDataDto));
                _logger.LogInformation("Information Message with instanceData to Dashboards hub clients was sent.");
            }

            if (instanceCheckedDto != null)
            {
                tasks.Add(_dashboardsHubContext.Clients.Group(instanceCheckedDto.OrganizationId.ToString()).SendAsync("InstanceStatusCheck", instanceCheckedDto));
                _logger.LogInformation("Information Message with instance check tome to Dashboards hub clients was sent.");
            }

            await Task.WhenAll(tasks);

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

        private void OnWait()
        {
            Debug.WriteLine("*******************WAITING***********************");
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