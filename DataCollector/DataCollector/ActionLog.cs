using System;

namespace DataCollector
{
    internal class ActionLog
    {
        // Id - Action log number
        public Guid Id { get; set; }

        // ClientId - Client identification number
        public Guid ClientId { get; set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }

        public LogLevel LogLevel { get; set; }

        public ActionLog(string message, DateTime timestamp, LogLevel logLevel)
        {
            Message = message;
            Timestamp = timestamp;
            LogLevel = logLevel;
        }
    }
}
