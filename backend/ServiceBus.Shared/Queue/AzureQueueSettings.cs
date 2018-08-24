namespace ServiceBus.Shared.Queue
{
    public class AzureQueueSettings
    {
        public AzureQueueSettings() { }

        public AzureQueueSettings(string connectionString, string dataQueueName, string errorQueueName)
        {
            ConnectionString = connectionString;
            DataQueueName = dataQueueName;
            ErrorQueueName = errorQueueName;
        }

        public string ConnectionString { get; set; }

        public string DataQueueName { get; set; }

        public string ErrorQueueName { get; set; }
    }
}
