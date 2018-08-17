namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class ResponseRepository : Repository<Response, int>, IResponseRepository
    {
        public ResponseRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}