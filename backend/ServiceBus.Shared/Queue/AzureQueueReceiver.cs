namespace ServiceBus.Shared.Queue
{
    using System;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using Newtonsoft.Json;

    using ServiceBus.Shared.Common;

    public class AzureQueueReceiver<TMessage> : IAzureQueueReceiver<TMessage> where TMessage : class
    {
        private QueueClient _client;

        public AzureQueueReceiver(AzureQueueSettings settings)
        {
            _client = new QueueClient(settings.ConnectionString, settings.QueueName);
        }

        public void Receive(Func<TMessage, Task<MessageProcessResponse>> onProcess, Action<Exception> onError, Action onWait)
        {
            var options = new MessageHandlerOptions(e => 
            {
                onError(e.Exception);
                return Task.CompletedTask;
            })
            {
                AutoComplete = false,
                MaxAutoRenewDuration = TimeSpan.FromMinutes(1)
            };

            _client.RegisterMessageHandler(
                async (message, token) =>
                {
                    try
                    {
                        // Get message
                        var data = Encoding.UTF8.GetString(message.Body);
                        TMessage item = JsonConvert.DeserializeObject<TMessage>(data);

                        // Process message
                        var result = await onProcess(item);

                        if (result == MessageProcessResponse.Complete)
                            await _client.CompleteAsync(message.SystemProperties.LockToken);
                        else if (result == MessageProcessResponse.Abandon)
                            await _client.AbandonAsync(message.SystemProperties.LockToken);
                        else if (result == MessageProcessResponse.Dead)
                            await _client.DeadLetterAsync(message.SystemProperties.LockToken);

                        // Wait for next message
                        onWait();
                    }
                    catch (Exception ex)
                    {
                        await _client.DeadLetterAsync(message.SystemProperties.LockToken);
                        onError(ex);
                    }
                }, options);
        }
    }
}
