namespace Watcher.Core.Interfaces
{
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    public interface IServiceBusProvider
    {
        ConcurrentBag<int> SubscribedIncstancesIds { get; }
        void RegisterOnMessageHandlerAndReceiveMessages();
        Task SendMessageToServiceBus(string message);
        Task CloseClient();
    }
}
