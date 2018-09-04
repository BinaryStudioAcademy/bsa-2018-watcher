using System;
using DataAccumulator.Shared.Enums;

namespace DataAccumulator.Shared.Models
{
    public class ActionLogDto
    {
        public string Message { get; set; }

        public DateTime Timestamp { get; set; }

        public LogLevel LogLevel { get; set; }

        public ActionLogDto(string message, DateTime timestamp, LogLevel logLevel)
        {
            Message = message;
            Timestamp = timestamp;
            LogLevel = logLevel;
        }
    }
}
