using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;

namespace Watcher.Core.Interfaces
{
    public interface IInstanceService
    {
        Task<IEnumerable<InstanceDto>> GetAllEntitiesAsync();

        Task<InstanceDto> GetEntityByIdAsync(int id);

        Task<IEnumerable<InstanceDto>> GetEntitiesByOrganizationIdAsync(int id);

        Task<InstanceDto> CreateEntityAsync(InstanceRequest request);

        Task<bool> UpdateEntityByIdAsync(InstanceRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
