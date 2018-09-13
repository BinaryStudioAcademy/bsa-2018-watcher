namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;
    class CollectorAppVersionRepository : Repository<CollectorAppVersion, int>, ICollectorAppVersionRepository
    {
        public CollectorAppVersionRepository(WatcherDbContext context, IMapper mapper)
           : base(context, mapper)
        {

        }
    }
}
