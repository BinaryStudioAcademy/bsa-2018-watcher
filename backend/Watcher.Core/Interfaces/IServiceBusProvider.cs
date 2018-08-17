using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IServiceBusProvider
    {
        void RegisterOnMessageHandlerAndReceiveMessages();
        Task CloseClient();
    }
}
