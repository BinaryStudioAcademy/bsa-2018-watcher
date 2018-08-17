﻿using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DataAccumulator.DataAccessLayer.Data
{
    public class DataAccumulatorContext
    {
        private readonly IMongoDatabase _database = null;

        public DataAccumulatorContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }

        public IMongoCollection<CollectedData> Datasets
        {
            get { return _database.GetCollection<CollectedData>("CollectedData"); }
        }
    }
}