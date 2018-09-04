using DataAccumulator.Shared.Enums;
using System;

namespace DataAccumulator.DataAccessLayer.Entities
{
    public class ActionLog
    {
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
