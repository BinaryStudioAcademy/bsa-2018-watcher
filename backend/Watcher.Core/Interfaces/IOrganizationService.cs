namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IOrganizationService
    {
        Task<IEnumerable<OrganizationDto>> GetAllEntitiesAsync();

        Task<OrganizationDto> GetEntityByIdAsync(int id);

        Task<OrganizationDto> CreateEntityAsync(OrganizationRequest request);

        Task<bool> UpdateEntityByIdAsync(OrganizationRequest request, int id);

        Task<bool> DeleteEntityByIdAsync(int id);
    }
}