namespace DataAccumulator.DataAccessLayer.Entities
{
    using System;
    using System.Collections.Generic;

    using DataAccumulator.DataAccessLayer.Interfaces;
    using DataAccumulator.Shared.Models;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class InstanceAnomalyReport : IEntity
    {
        [BsonId]
        public Guid Id { get; set; }

        // ClientId - Instance identification number
        [BsonRepresentation(BsonType.String)]
        public Guid ClientId { get; set; }

        [BsonDateTimeOptions]
        public DateTime Date { get; set; }

        public string HtmlDocUrl { get; set; }

        public CollectedDataType CollectedDataTypeOfReport { get; set; }

        public List<AzureMLAnomalyGroup> AnomalyGroups { get; set; }
    }
}
