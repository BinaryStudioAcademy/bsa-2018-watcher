using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    public interface IDataAggregatorRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<CollectedData>> GetAllEntities();
        Task<IEnumerable<CollectedData>> GetAllEntitiesByType(CollectedDataType collectedDataType);

        Task<CollectedData> GetEntity(Guid id);

        // query after multiple parameters
        Task<IEnumerable<CollectedData>> GetEntitiesInTime(DateTime timeFrom, DateTime timeTo);
        Task<IEnumerable<CollectedData>> GetEntitiesByTypeInTime(CollectedDataType collectedDataType, DateTime timeFrom, DateTime timeTo);
        Task<IEnumerable<CollectedData>> GetEntitiesByInstanceIdAndTypeInTime(Guid id, CollectedDataType collectedDataType, DateTime timeFrom, DateTime timeTo);

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
    }
}
