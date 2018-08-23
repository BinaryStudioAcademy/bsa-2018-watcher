using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Entities;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    using MongoDB.Bson;

    public interface IDataAccumulatorRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<CollectedData>> GetAllEntities();

        Task<CollectedData> GetEntity(Guid id);

        Task<CollectedData> GetEntity(ObjectId id);

        // query after multiple parameters
        Task<IEnumerable<CollectedData>> GetEntities(DateTime timeFrom, DateTime timeTo);

        // add new entity
        Task AddEntity(CollectedData item);

        // update single entity
        Task<bool> UpdateEntity(CollectedData collectedData);

        // remove a single entity
        Task<bool> RemoveEntity(Guid id);

        Task<bool> RemoveAllEntities();

        // creates index
        Task<string> CreateIndex();

        // check if entity exists
        Task<bool> EntityExistsAsync(Guid id);

        Task<List<CollectedData>> GetPercentageInfoByEntityIdAsync(Guid id, int count);
    }
}
