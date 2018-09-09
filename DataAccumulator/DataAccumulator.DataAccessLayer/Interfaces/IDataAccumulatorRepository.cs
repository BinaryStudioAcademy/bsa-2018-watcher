using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Entities;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    using DataAccumulator.Shared.Models;

    using MongoDB.Bson;

    public interface IDataAccumulatorRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<CollectedData>> GetAllEntities();

        Task<CollectedData> GetEntityByInstanceIdAsync(Guid id);

        Task<CollectedData> GetEntityIdAsync(Guid id);

        Task<CollectedData> GetEntityByInternalIdAsync(ObjectId id);

        Task<IEnumerable<CollectedData>> GetCollectedDataByInstanceIdAsync(Guid instanceId, int count);


        Task<IEnumerable<CollectedData>> GetCollectedDataByInstanceIdAsync(
            Guid instanceId,
            DateTime timeFrom,
            DateTime timeTo);

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

        Task<List<CollectedData>> GetPercentageInfoByInstanceIdAsync(Guid id, int count);

        Task<List<CollectedData>> GetCollectedDataByInstanceIdAsync(Guid instanceId, CollectedDataType dataType);
    }
}
