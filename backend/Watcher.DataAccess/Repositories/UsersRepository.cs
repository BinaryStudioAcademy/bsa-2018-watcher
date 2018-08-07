namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class UsersRepository : Repository<User, int>, IUsersRepository
    {
        public UsersRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }
    }
}
