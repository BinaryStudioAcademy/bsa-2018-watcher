namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class SamplesRepository : Repository<Sample, int>, ISamplesRepository
    {
        public SamplesRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
