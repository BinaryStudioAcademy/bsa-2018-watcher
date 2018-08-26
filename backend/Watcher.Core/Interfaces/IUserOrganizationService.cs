using Watcher.DataAccess.Entities;

namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;

    public interface IUserOrganizationService
    {
        Task<IEnumerable<UserOrganizationDto>> GetAllEntitiesAsync();

        Task<UserOrganizationDto> CreateEntityAsync(UserOrganizationRequest request);

        Task<bool> DeleteEntityAsync(int companyId, string userId);
    }
}