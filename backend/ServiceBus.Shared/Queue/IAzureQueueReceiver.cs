namespace ServiceBus.Shared.Queue
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using ServiceBus.Shared.Common;

    public interface IAzureQueueReceiver<T>
    {
        void Receive(
            Func<T, Task<MessageProcessResponse>> onProcess,
            Action<ExceptionReceivedEventArgs> onError,
            Action<Exception> onProccessingError,
            Action onWait);
    }
}
