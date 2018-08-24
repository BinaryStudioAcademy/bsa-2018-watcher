namespace ServiceBus.Shared.Queue
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAzureQueueSender<T>
    {
        Task SendAsync(T item);

        Task SendAsync(T item, Dictionary<string, object> properties);
    }
}
