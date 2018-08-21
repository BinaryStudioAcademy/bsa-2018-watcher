namespace Watcher.Core.Interfaces
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    public interface IServiceBusProvider
    {
        ConcurrentBag<Guid> SubscribedInstancesGuidIds { get; }
        void RegisterOnMessageHandlerAndReceiveMessages();
        Task SendMessageToServiceBus(string message);
        Task CloseClient();
    }
}
