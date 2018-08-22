using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    //interface IDataAccumulatorService
    //{
    //}

    public interface IDataAccumulatorService<TEntity> where TEntity : ICollectedDataDto
    {
        Task<IEnumerable<TEntity>> GetEntitiesAsync();
        Task<TEntity> GetEntityAsync(Guid id);
        Task<TEntity> AddEntityAsync(TEntity entity);
        Task<TEntity> UpdateEntityAsync(TEntity entity);
        Task<bool> DeleteEntityAsync(Guid id);
    }
}
