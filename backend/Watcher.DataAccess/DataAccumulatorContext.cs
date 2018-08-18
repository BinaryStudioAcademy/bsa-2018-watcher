using MongoDB.Driver;
using Watcher.DataAccess.Entities;

namespace Watcher.DataAccess
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
    }
}
