namespace Watcher.DataAccess.Repositories
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class InstanceRepository : Repository<Instance, int>, IInstanceRepository
    {
        public InstanceRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<Instance> UpateLastCheckedAsync(Guid instanceId, DateTime time)
        {
            var entity = await GetFirstOrDefaultAsync(i => i.GuidId == instanceId);
            if (entity == null) return null;
            // entity.
            entity.StatusCheckedAt = time;
            return entity;
        }
    }
}
