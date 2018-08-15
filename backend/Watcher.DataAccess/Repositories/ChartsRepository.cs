using AutoMapper;

using Watcher.DataAccess.Data;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces.Repositories;

namespace Watcher.DataAccess.Repositories
{
    public class ChartsRepository : Repository<Chart, int>, IChartsRepository
    {
        public ChartsRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper) { }
    }
}
