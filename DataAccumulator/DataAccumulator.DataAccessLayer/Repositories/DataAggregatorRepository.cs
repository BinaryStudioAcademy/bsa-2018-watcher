using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccumulator.DataAccessLayer.Repositories
{
    public class DataAggregatorRepository : IDataAggregatorRepository<CollectedData>
    {
        private readonly DataAccumulatorContext _context = null;
        private readonly CollectedDataType _collectedDataType;

        public DataAggregatorRepository(string ConnectionString, string Database, CollectedDataType collectedDataType)
        {
            _context = new DataAccumulatorContext(ConnectionString, Database);
            _collectedDataType = collectedDataType;
        }

        public async Task<IEnumerable<CollectedData>> GetAllEntities()
        {
            try
            {
                return await _context.Datasets
                    .Find(data => data.CollectedDataType == _collectedDataType)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<CollectedData> GetEntity(Guid id)
        {
            try
            {
                var data = await _context.Datasets
                    .Find(d => d.CollectedDataType == _collectedDataType && d.Id == id)
                    .FirstOrDefaultAsync();

                return data;
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
                    .Find(d => d.CollectedDataType == _collectedDataType && d.Time >= timeFrom && d.Time <= timeTo);

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
                collectedData.CollectedDataType = _collectedDataType;
                await _context.Datasets
                    .InsertOneAsync(collectedData);
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
                collectedData.CollectedDataType = _collectedDataType;
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
            return _context.Datasets
                .Find(entity => entity.Id == id).AnyAsync();
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
