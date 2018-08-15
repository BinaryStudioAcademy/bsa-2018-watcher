namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class InstanceRepository : Repository<Instance, int>, IInstanceRepository
    {
        public InstanceRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
