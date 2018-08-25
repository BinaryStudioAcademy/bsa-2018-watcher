using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IDataAccumulatorService<TDto> where TDto : ICollectedDataDto
    {
        Task<IEnumerable<TDto>> GetEntitiesAsync();
        Task<TDto> GetEntityAsync(Guid id);
        Task<TDto> AddEntityAsync(TDto entity);
        Task<TDto> AddEntityAsync();

        Task<TDto> UpdateEntityAsync(TDto entity);
        Task<bool> DeleteEntityAsync(Guid id);
    }
}
