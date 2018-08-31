namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class ChatsRepository : Repository<Chat, int>, IChatsRepository
    {
        public ChatsRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper) { }
    }
}
