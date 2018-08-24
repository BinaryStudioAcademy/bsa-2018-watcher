namespace ServiceBus.Shared.Queue
{
    using System;
    using System.Threading.Tasks;

    using ServiceBus.Shared.Common;

    public interface IAzureQueueReceiver<T>
    {
        void Receive(
            Func<T, Task<MessageProcessResponse>> onProcess,
            Action<Exception> onError,
            Action onWait);
    }
}
