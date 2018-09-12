using AutoMapper;

using Watcher.DataAccess.Data;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces.Repositories;

namespace Watcher.DataAccess.Repositories
{
    public class ThemeRepository : Repository<Theme, int>, IThemeRepository
    {
        public ThemeRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
