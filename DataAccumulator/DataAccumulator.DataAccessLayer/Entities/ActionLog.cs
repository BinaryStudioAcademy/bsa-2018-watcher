using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataAccumulator.DataAccessLayer.Entities
{
    public class ActionLog : IEntity
    {
        // Id - Action log number
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }

        // ClientId - Client identification number
        [BsonRepresentation(BsonType.String)]
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
