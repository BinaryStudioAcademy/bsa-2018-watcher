namespace Watcher.Core.Interfaces
{
    using ServiceBus.Shared.Messages;
    using System.Threading.Tasks;

    public interface IServiceBusProvider
    {
        //ConcurrentBag<Guid> SubscribedInstancesGuidIds { get; }
        //void RegisterOnMessageHandlerAndReceiveMessages();
        //Task SendMessageToServiceBus(string message);
        //Task CloseClient();'
        Task SendInstanceSettingsAsync(InstanceSettingsMessage message);
    }
}
