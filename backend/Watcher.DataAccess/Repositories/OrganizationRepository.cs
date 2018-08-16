namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class OrganizationRepository : Repository<Organization, int>, IOrganizationRepository
    {
        public OrganizationRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
