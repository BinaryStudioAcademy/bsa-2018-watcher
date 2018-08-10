using AutoMapper;
using Watcher.DataAccess.Data;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces.Repositories;

namespace Watcher.DataAccess.Repositories
{
    public class DashboardsRepository: Repository<Dashboard, int>, IDashboardsRepository
    {
        public DashboardsRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
