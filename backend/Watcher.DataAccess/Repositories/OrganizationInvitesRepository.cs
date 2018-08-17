
namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;
    class OrganizationInvitesRepository : Repository<OrganizationInvite, int>, IOrganizationInvitesRepository
    {
        public OrganizationInvitesRepository(WatcherDbContext context, IMapper mapper) 
            : base(context, mapper)
        {

        }
    }
}
