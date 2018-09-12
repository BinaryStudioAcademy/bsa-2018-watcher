using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IInstanceSettingsService<TDto> where TDto : ICollectedDataDto
    {
        Task<IEnumerable<TDto>> GetEntitiesAsync();
        Task<TDto> GetEntityAsync(Guid id);
        Task<TDto> GetEntityByInstanceIdAsync(Guid clientId);
        Task<TDto> GetLastEntityByInstanceIdAsync(Guid clientId);
        Task<TDto> AddEntityAsync(TDto dataDto);
        Task<TDto> UpdateEntityAsync(TDto dataDto);
        Task<bool> DeleteEntityAsync(Guid id);
    }
}
