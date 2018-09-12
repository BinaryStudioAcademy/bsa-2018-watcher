namespace ServiceBus.Shared.Queue
{
    public class AzureQueueSettings
    {
        public AzureQueueSettings() { }

        public AzureQueueSettings(string connectionString, 
                                  string dataQueueName, 
                                  string errorQueueName,
                                  string settingsQueueName, 
                                  string notifyQueueName)
        {
            ConnectionString = connectionString;
            DataQueueName = dataQueueName;
            ErrorQueueName = errorQueueName;
            SettingsQueueName = settingsQueueName;
            NotifyQueueName = notifyQueueName;
        }

        public string ConnectionString { get; set; }

        public string DataQueueName { get; set; }

        public string ErrorQueueName { get; set; }

        public string SettingsQueueName { get; set; }
        public string NotifyQueueName { get; set; }
    }
}
