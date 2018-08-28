using DataAccumulator.DataAccessLayer.Entities;
using MongoDB.Driver;

namespace DataAccumulator.DataAccessLayer.Data
{
    public class DataAccumulatorContext
    {
        private readonly IMongoDatabase _database = null;

        public DataAccumulatorContext(string ConnectionString, string Database)
        {
            var client = new MongoClient(ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(Database);
            }
        }

        public IMongoCollection<CollectedData> Datasets
        {
            get { return _database.GetCollection<CollectedData>("CollectedData"); }
        }

        public IMongoCollection<CollectedData> AggregatedCollectedData
        {
            get { return _database.GetCollection<CollectedData>("AggregatedCollectedData"); }
        }
    }
}
