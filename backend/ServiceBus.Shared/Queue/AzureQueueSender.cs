namespace ServiceBus.Shared.Queue
{
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using Newtonsoft.Json;

    using ServiceBus.Shared.Messages;

    public class AzureQueueSender : IAzureQueueSender
    {
        public AzureQueueSender() { }
        
        public Task SendAsync<T>(QueueClient client, T item) where T : InstanceMessage
        {
            return SendAsync(client, item, null);
        }

        public Task SendAsync<T>(QueueClient client, T item, Dictionary<string, object> properties) where T : InstanceMessage
        {
            var json = JsonConvert.SerializeObject(item);
            var message = new Message(Encoding.UTF8.GetBytes(json));

            if (properties == null)
            {
                return client.SendAsync(message);
            }

            foreach (var prop in properties)
            {
                message.UserProperties.Add(prop.Key, prop.Value);
            }

            return client.SendAsync(message);
        }
    }
}
