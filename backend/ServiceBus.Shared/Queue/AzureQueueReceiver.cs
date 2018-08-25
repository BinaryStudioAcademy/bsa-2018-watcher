namespace ServiceBus.Shared.Queue
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using Newtonsoft.Json;

    using ServiceBus.Shared.Common;
    using ServiceBus.Shared.Messages;

    public class AzureQueueReceiver : IAzureQueueReceiver
    {
        public AzureQueueReceiver() { }

        public void Receive<T>(
            QueueClient client,
            Func<T, CancellationToken, Task<MessageProcessResponse>> onProcess,
            Action<ExceptionReceivedEventArgs> onError,
            Action<Exception> onProcessingError,
            Action onWait) 
            where T : InstanceMessage
        {
            var options = new MessageHandlerOptions(e => 
            {
                onError(e);
                return Task.CompletedTask;
            })
            {
                // Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
                // Set it according to how many messages the application wants to process in parallel.
                MaxConcurrentCalls = 1,
                
                // Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
                // False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
                AutoComplete = false,
                 
                MaxAutoRenewDuration = TimeSpan.FromMinutes(1)
            };

            client.RegisterMessageHandler(
                async (message, token) =>
                {
                    try
                    {
                        // Get message
                        var data = Encoding.UTF8.GetString(message.Body);
                        T item = JsonConvert.DeserializeObject<T>(data);

                        // Process message
                        var result = await onProcess(item, token);

                        if (result == MessageProcessResponse.Complete)
                            await client.CompleteAsync(message.SystemProperties.LockToken);
                        else if (result == MessageProcessResponse.Abandon)
                            await client.AbandonAsync(message.SystemProperties.LockToken);
                        else if (result == MessageProcessResponse.Dead)
                            await client.DeadLetterAsync(message.SystemProperties.LockToken);

                        // Wait for next message
                        onWait();
                    }
                    catch (Exception ex)
                    {
                        await client.DeadLetterAsync(message.SystemProperties.LockToken);
                        onProcessingError(ex);
                    }
                }, options);
        }
    }
}