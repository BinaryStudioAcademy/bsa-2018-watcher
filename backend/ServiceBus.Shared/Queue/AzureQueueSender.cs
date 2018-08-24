namespace ServiceBus.Shared.Queue
{
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.Azure.ServiceBus;

    using Newtonsoft.Json;

    public class AzureQueueSender<T> : IAzureQueueSender<T> where T : class
    {
        private AzureQueueSettings _settings;
        private QueueClient _client;

        public AzureQueueSender(AzureQueueSettings settings)
        {
            _settings = settings;
            Init();
        }
        
        public Task SendAsync(T item)
        {
            return SendAsync(item, null);
        }

        public Task SendAsync(T item, Dictionary<string, object> properties)
        {
            var json = JsonConvert.SerializeObject(item);
            var message = new Message(Encoding.UTF8.GetBytes(json));

            if (properties == null)
            {
                return _client.SendAsync(message);
            }

            foreach (var prop in properties)
            {
                message.UserProperties.Add(prop.Key, prop.Value);
            }

            return _client.SendAsync(message);
        }

        private void Init()
        {
            _client = new QueueClient(_settings.ConnectionString, _settings.QueueName);
        }
    }
}
