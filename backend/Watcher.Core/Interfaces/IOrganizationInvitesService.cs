
namespace Watcher.Core.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    public interface IOrganizationInvitesService
    {

        Task<OrganizationInviteDto> GetEntityByLinkAsync(string link);

        Task<IEnumerable<OrganizationInviteDto>> GetEntitiesByUserIdAsync(string userId);

        Task<OrganizationInviteDto> CreateEntityAsync(OrganizationInviteRequest request);

        Task<bool> UpdateEntityByIdAsync(OrganizationInviteRequest request, int id);


    }
}
