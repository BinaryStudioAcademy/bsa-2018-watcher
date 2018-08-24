namespace Watcher.Core.Providers
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.AspNetCore.SignalR;
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
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>()
                      ?? throw new ArgumentNullException(nameof(loggerFactory));
            _azureQueueReceiver = azureQueueReceiver;
            _azureQueueReceiver.Receive(OnProcessAsync, OnError, OnWait);
        }

        private void OnWait()
        {
            throw new NotImplementedException();
        }

        private void OnError(Exception obj)
        {
            throw new NotImplementedException();
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

            await _dashboardsHubContext.Clients.Group(dto.Id.ToString()).SendAsync("InstanceDataTick", dto);
            return MessageProcessResponse.Complete;
        }
    }
    //#region Subscribe

    //public void RegisterOnMessageHandlerAndReceiveMessages()
    //{
    //    // Configure the MessageHandler Options in terms of exception handling, number of concurrent messages to deliver etc.
    //    var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
    //    {
    //        // Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
    //        // Set it according to how many messages the application wants to process in parallel.
    //        MaxConcurrentCalls = 1,

    //        // Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
    //        // False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
    //        AutoComplete = false
    //    };

    //    // Register the function that will process messages
    //    _queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
    //}

    //private async Task<string> ProcessMessagesAsync(Message message, CancellationToken token)
    //{
    //    // Process the message
    //    var m = Encoding.UTF8.GetString(message.Body);

    //    if (Guid.TryParse(m, out var instanceGuidId))
    //    {
    //        var any = SubscribedInstancesGuidIds.Any(i => i == instanceGuidId);
    //        if (!any)
    //        {
    //            SubscribedInstancesGuidIds.Add(instanceGuidId);
    //        }
    //    }

    //    // Handle Message From Service Bus
    //    // Complete the message so that it is not received again.
    //    // This can be done only if the queueClient is created in ReceiveMode.PeekLock mode (which is default).
    //    await _queueClient.CompleteAsync(message.SystemProperties.LockToken);

    //    await _dashboardsHubContext.Clients.All.SendAsync("Send", "Instance Id to subscribe" + m, token);

    //    Debug.WriteLine($"********************{m}***********************");

    //    return m;
    //}

    //#endregion

    //#region Publish
    //public async Task SendMessageToServiceBus(string message)
    //{
    //    try
    //    {
    //        var messageBody = new Message(Encoding.UTF8.GetBytes(message));
    //        await _queueClient.SendAsync(messageBody);
    //    }
    //    catch(Exception ex)
    //    {
    //        throw ex;
    //    }
    //}
    //#endregion

    //private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
    //{
    //    _logger.LogError($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
    //    var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
    //    _logger.LogError("Exception context for troubleshooting:");
    //    _logger.LogError($"- Endpoint: {context.Endpoint}");
    //    _logger.LogError($"- Entity Path: {context.EntityPath}");
    //    _logger.LogError($"- Executing Action: {context.Action}");
    //    return Task.CompletedTask;
    //}

    //#region IDisposable Support
    //// To detect redundant calls
    //private bool disposedValue; 

    //public async Task CloseClient()
    //{
    //    if (!disposedValue)
    //    {
    //        await _queueClient.CloseAsync();

    //        disposedValue = true;
    //    }
    //}

    //public void Dispose() => CloseClient().GetAwaiter().GetResult();
    //#endregion        
}