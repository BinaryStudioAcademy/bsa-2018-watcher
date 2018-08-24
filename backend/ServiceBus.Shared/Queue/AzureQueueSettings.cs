namespace ServiceBus.Shared.Queue
{
    public class AzureQueueSettings
    {
        public AzureQueueSettings() { }

        public AzureQueueSettings(string connectionString, string queueName)
        {
            ConnectionString = connectionString;
            QueueName = queueName;
        }

        public string ConnectionString { get; set; }

        public string QueueName { get; set; }
    }
}
