namespace ServiceBus.Shared.Queue
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using ServiceBus.Shared.Common;
    using ServiceBus.Shared.Messages;

    public interface IAzureQueueReceiver
    {
        void Receive<T>(
            QueueClient queueClient,
            Func<T, CancellationToken, Task<MessageProcessResponse>> onProcess,
            Action<ExceptionReceivedEventArgs> onError,
            Action<Exception> onProccessingError,
            Action onWait) 
            where T : InstanceMessage;
    }
}
