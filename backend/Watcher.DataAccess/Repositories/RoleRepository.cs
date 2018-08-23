namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class RoleRepository : Repository<Role, int>, IRoleRepository
    {
        public RoleRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
