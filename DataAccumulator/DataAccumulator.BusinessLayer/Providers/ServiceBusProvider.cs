namespace DataAccumulator.BusinessLayer.Providers
{
    using System;
    using System.Threading.Tasks;

    using DataAccumulator.BusinessLayer.Interfaces;

    using Microsoft.Azure.ServiceBus;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using ServiceBus.Shared.Messages;
    using ServiceBus.Shared.Queue;

    public class ServiceBusProvider : IServiceBusProvider, IDisposable
    {
        private readonly ILogger<ServiceBusProvider> _logger;
        private readonly IOptions<AzureQueueSettings> _queueOptions;
        private readonly IAzureQueueSender _azureQueueSender;

        private readonly QueueClient _instanceDataQueueClient;
        private readonly QueueClient _instanceErrorQueueClient;

        public ServiceBusProvider(ILoggerFactory loggerFactory,
                                  IOptions<AzureQueueSettings> queueOptions,
                                  IAzureQueueSender azureQueueSender)
        {
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>() ?? throw new ArgumentNullException(nameof(loggerFactory));
            _azureQueueSender = azureQueueSender;
            _queueOptions = queueOptions;
            _instanceDataQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.DataQueueName);
            _instanceErrorQueueClient = new QueueClient(_queueOptions.Value.ConnectionString, _queueOptions.Value.ErrorQueueName);
        }

        public Task SendDataMessage(InstanceCollectedDataMessage message)
        {
            return _azureQueueSender.SendAsync(_instanceDataQueueClient, message);
        }

        public Task SendDataMessage(InstanceValidatorMessage message)
        {
            return _azureQueueSender.SendAsync(_instanceDataQueueClient, message);
        }

        public Task SendDataMessage(Guid instanceId, Guid dataId)
        {
            var message = new InstanceCollectedDataMessage { InstanceId = instanceId, CollectedDataId = dataId };
            return _azureQueueSender.SendAsync(_instanceDataQueueClient, message);
        }

        public Task SendErrorMessage(InstanceErrorMessage message)
        {
            _logger.LogInformation($"Error message was of {message.InstanceId} instance was send to service bus: {message.ErrorMessage}");
            return _azureQueueSender.SendAsync(_instanceErrorQueueClient, message);
        }

        public Task SendErrorMessage(Guid instanceId, string errorMessage)
        {
            _logger.LogInformation($"Error message was of {instanceId} instance was send to service bus: {errorMessage}");
            var message = new InstanceErrorMessage { InstanceId = instanceId, ErrorMessage = errorMessage };
            return _azureQueueSender.SendAsync(_instanceErrorQueueClient, message);
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
