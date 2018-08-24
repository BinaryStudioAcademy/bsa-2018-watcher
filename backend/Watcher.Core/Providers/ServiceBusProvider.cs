namespace Watcher.Core.Providers
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Azure.ServiceBus;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using ServiceBus.Shared.Common;
    using ServiceBus.Shared.Messages;
    using ServiceBus.Shared.Queue;

    using Watcher.Common.Dtos.Plots;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;

    public class ServiceBusProvider : IServiceBusProvider
    {
        private readonly ILogger<ServiceBusProvider> _logger;

        private readonly IHubContext<DashboardsHub> _dashboardsHubContext;
        private readonly IAzureQueueReceiver<InstanceCollectedDataMessage> _azureQueueReceiver;

        private readonly IServiceScopeFactory _scopeFactory;

        public ServiceBusProvider(
            ILoggerFactory loggerFactory,
            IServiceScopeFactory scopeFactory,
            IHubContext<DashboardsHub> dashboardsHubContext,
            IAzureQueueReceiver<InstanceCollectedDataMessage> azureQueueReceiver)
        {
            _dashboardsHubContext = dashboardsHubContext;
            _scopeFactory = scopeFactory;
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>()
                      ?? throw new ArgumentNullException(nameof(loggerFactory));
            _azureQueueReceiver = azureQueueReceiver;
            _azureQueueReceiver.Receive(OnProcessAsync, ExceptionReceivedHandler, ExceptionWhileProcessingHandler, OnWait);
        }

        private void OnWait()
        {
            Debug.WriteLine("*******************WAITING***********************");
        }

        private async Task<MessageProcessResponse> OnProcessAsync(InstanceCollectedDataMessage arg)
        {
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
                    return MessageProcessResponse.Dead; // No such entity
                }
            }

            await _dashboardsHubContext.Clients.Group(dto.ClientId.ToString()).SendAsync("InstanceDataTick", dto);
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
    }
}