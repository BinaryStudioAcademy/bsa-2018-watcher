using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.Entities;
using DataAccumulator.Models;

namespace DataAccumulator.Interfaces
{
    public interface IDataAccumulatorRepository
    {
        Task<IEnumerable<CollectedData>> GetAllEntities();

        Task<CollectedData> GetEntity(string id);

        // query after multiple parameters
        Task<IEnumerable<CollectedData>> GetEntity(DateTime time);

        // add new entity
        Task AddEntity(CollectedData item);

        // update single entity
        Task<bool> UpdateEntity(string id, CollectedDataDto collectedData);

        // remove a single entity
        Task<bool> RemoveEntity(string id);

        Task<bool> RemoveAllEntities();

        // creates index
        Task<string> CreateIndex();
    }
}
