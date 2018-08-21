using System.Threading.Tasks;

namespace DataAccumulator.Interfaces
{
    public interface IServiceBusProvider
    {
        Task SendMessageToServiceBus(string message);
    }
}
