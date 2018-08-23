using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.DataAggregator.Interfaces
{
    public interface IAggregatorService<TEntity> where TEntity : ICollectedDataDto
    {
        Task<IEnumerable<TEntity>> GetAccumulatorEntitiesAsync(DateTime timeFrom, DateTime timeTo);
        Task<bool> DeleteAccumulatorEntityAsync(Guid id);
        Task<TEntity> AddAggregatorEntityAsync(TEntity entity);
    }
}
