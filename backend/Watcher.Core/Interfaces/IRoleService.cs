using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;

namespace Watcher.Core.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllEntitiesAsync();

        Task<RoleDto> GetEntityByIdAsync(int id);

        Task<RoleDto> CreateEntityAsync(RoleRequest request);

        Task<bool> UpdateEntityByIdAsync(RoleDto request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}
