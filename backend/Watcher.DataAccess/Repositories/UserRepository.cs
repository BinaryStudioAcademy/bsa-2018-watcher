namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class UserRepository : Repository<User, int>, IUserRepository
    {
        public UserRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }
    }
}
