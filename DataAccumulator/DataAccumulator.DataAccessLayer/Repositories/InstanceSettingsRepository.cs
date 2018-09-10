using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Data;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccumulator.DataAccessLayer.Repositories
{
    public class InstanceSettingsRepository : IInstanceSettingsRepository<InstanceSettings>
    {
        private readonly DataAccumulatorContext _context;

        public InstanceSettingsRepository(string ConnectionString, string Database)
        {
            _context = new DataAccumulatorContext(ConnectionString, Database);
        }

        public async Task<IEnumerable<InstanceSettings>> GetAllEntitiesAsync()
        {
            try
            {
                return await _context.InstanceValidatorCollection
                    .Find(_ => true)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<InstanceSettings> GetEntityAsync(Guid id)
        {
            try
            {
                var data = await _context.InstanceValidatorCollection
                    .Find(i => i.ClientId == id)
                    .FirstOrDefaultAsync();

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<InstanceSettings> GetEntityByInstanceIdAsync(Guid clientId)
        {
            try
            {
                var data = await _context.InstanceValidatorCollection
                    .Find(i => i.ClientId == clientId)
                    .FirstOrDefaultAsync();

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task AddEntityAsync(InstanceSettings item)
        {
            try
            {
                await _context.InstanceValidatorCollection
                    .InsertOneAsync(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> UpdateEntityAsync(InstanceSettings item)
        {
            try
            {
                ReplaceOneResult actionResult = await _context.InstanceValidatorCollection
                    .ReplaceOneAsync(data => data.Id.Equals(item.Id), item, new UpdateOptions { IsUpsert = true });

                return actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> RemoveEntityAsync(Guid id)
        {
            try
            {
                DeleteResult actionResult =
                    await _context.InstanceValidatorCollection
                        .DeleteOneAsync(Builders<InstanceSettings>.Filter.Eq("Id", id));

                return actionResult.IsAcknowledged && actionResult.DeletedCount > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> RemoveAllEntitiesAsync()
        {
            try
            {
                DeleteResult actionResult = await _context.InstanceValidatorCollection
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
            return _context.InstanceValidatorCollection.Find(entity => entity.Id == id).AnyAsync();
        }
    }
}
