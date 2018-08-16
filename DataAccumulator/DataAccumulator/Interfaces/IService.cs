using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccumulator.Interfaces
{
    public interface IService<TEntity> where TEntity : ICollectedDataDto
    {
        Task<IEnumerable<TEntity>> GetEntitiesAsync();
        Task<TEntity> GetEntityAsync(Guid id);
        Task<TEntity> AddEntityAsync(TEntity entity);
        Task<TEntity> UpdateEntityAsync(TEntity entity);
        Task<bool> DeleteEntityAsync(Guid id);
    }
}
