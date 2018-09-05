namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class OrganizationRoleRepository : Repository<OrganizationRole, int>, IOrganizationRoleRepository
    {
        public OrganizationRoleRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
