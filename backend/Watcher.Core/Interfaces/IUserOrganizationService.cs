namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IUserOrganizationService
    {
        Task<IEnumerable<UserOrganizationDto>> GetAllEntitiesAsync();
        Task<OrganizationRoleDto> GetUserOrganizationRoleAsync(string userId, int organizationId);
        Task<UserOrganizationDto> CreateEntityAsync(UserOrganizationRequest request);

        Task<bool> DeleteEntityAsync(int companyId, string userId);
        Task<UserOrganizationDto> UpdateEntityAsync(UserOrganizationRequest request);
        Task<IEnumerable<UserOrganizationDto>> GetEntitiesByOrganizationId(int organizationId);

    }
}