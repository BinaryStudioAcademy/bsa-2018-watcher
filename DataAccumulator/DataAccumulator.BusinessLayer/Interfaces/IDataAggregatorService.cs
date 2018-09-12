using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.BusinessLayer.Services;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.Shared.Interfaces;
using DataAccumulator.Shared.Models;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IDataAggregatorService<TDto> where TDto : ICollectedDataDto
    {
        Task<IEnumerable<TDto>> GetEntitiesAsync();
        Task<IEnumerable<TDto>> GetEntitiesByTypeAsync(CollectedDataType collectedDataType);
        Task<TDto> GetEntityAsync(Guid id);
        Task<TDto> AddEntityAsync(TDto entity);
        Task<TDto> UpdateEntityAsync(TDto entity);
        Task<bool> DeleteEntityAsync(Guid id);
    }
}
