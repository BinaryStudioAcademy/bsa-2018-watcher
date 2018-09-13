using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAggregatorService<TEntity> where TEntity : ICollectedDataDto
    {
        Task<IEnumerable<CollectedDataDto>> GetSourceEntitiesAsync(CollectedDataType sourceType, 
            DateTime timeFrom, DateTime timeTo);
        Task<bool> DeleteAggregatedEntityAsync(Guid id);
        Task<TEntity> AddAggregatorEntityAsync(TEntity entity);
        Task AddAggregatorEntitiesAsync(IEnumerable<TEntity> entities);

        Task<IEnumerable<InstanceSettingsDto>> GetInstanceSettingsEntitiesAsync();

        Task DeleteManyAggregatedEntitiesAsync(IEnumerable<Guid> idsToDelete);
    }
}
