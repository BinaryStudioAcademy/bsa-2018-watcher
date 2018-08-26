using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccumulator.DataAccessLayer.Repositories
{
    public class DataAccumulatorRepository : IDataAccumulatorRepository<CollectedData>
    {
        private readonly DataAccumulatorContext _context = null;

        public DataAccumulatorRepository(string ConnectionString, string Database)
        {
            _context = new DataAccumulatorContext(ConnectionString, Database);
        }

        public async Task<IEnumerable<CollectedData>> GetAllEntities()
        {
            try
            {
                return await _context.Datasets.Find(_ => true).ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task<List<CollectedData>> GetPercentageInfoByInstanceIdAsync(Guid clientId, int count)
        {
            try
            {
                return _context.Datasets.Find(data => data.ClientId == clientId)
                    .SortByDescending(cd => cd.Time)
                    .Limit(count)
                    .ToListAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CollectedData> GetEntityByInstanceIdAsync(Guid clientId)
        {
            try
            {
                var internalId = GetInternalId(clientId);

                var data = await _context.Datasets
                               .Find(d => d.ClientId == clientId || d.InternalId == internalId)
                               .FirstOrDefaultAsync();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CollectedData> GetEntityIdAsync(Guid id)
        {
            try
            {
                var filter = Builders<CollectedData>.Filter.Eq(i => i.Id, id);

                return await _context.Datasets.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CollectedData> GetEntityByInternalIdAsync(ObjectId id)
        {
            try
            {
                var filter = Builders<CollectedData>.Filter.Eq(i => i.InternalId, id);

                return await _context.Datasets.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // Query by time
        public async Task<IEnumerable<CollectedData>> GetEntities(DateTime timeFrom, DateTime timeTo)
        {
            try
            {
                var query = _context.Datasets
                    .Find(data => data.Time >= timeFrom && data.Time <= timeTo);

                return await query.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task AddEntity(CollectedData collectedData)
        {
            try
            {
                await _context.Datasets.InsertOneAsync(collectedData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> UpdateEntity(CollectedData collectedData)
        {
            try
            {
                ReplaceOneResult actionResult = await _context.Datasets
                    .ReplaceOneAsync(data => data.Id.Equals(collectedData.Id), collectedData, new UpdateOptions { IsUpsert = true });

                return actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> RemoveEntity(Guid id)
        {
            try
            {
                DeleteResult actionResult =
                    await _context.Datasets
                        .DeleteOneAsync(Builders<CollectedData>.Filter.Eq("Id", id));

                return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> RemoveAllEntities()
        {
            try
            {
                DeleteResult actionResult = await _context.Datasets
                    .DeleteManyAsync(new BsonDocument());

                return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task<bool> EntityExistsAsync(Guid id)
        {
            return _context.Datasets.Find(entity => entity.Id == id).AnyAsync();
        }

        // It creates a sample compound index 
        // MongoDb automatically detects if the index already exists - in this case it just returns the index details
        public async Task<string> CreateIndex()
        {
            try
            {
                IndexKeysDefinition<CollectedData> keys = Builders<CollectedData>
                    .IndexKeys
                    .Ascending(item => item.ProcessesCount)
                    .Ascending(item => item.Time);

                return await _context.Datasets
                    .Indexes
                    .CreateOneAsync(new CreateIndexModel<CollectedData>(keys));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // Try to convert the Id to a BSonId value
        private ObjectId GetInternalId(Guid id)
        {
            if (!ObjectId.TryParse(id.ToString(), out ObjectId internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }
    }
}
