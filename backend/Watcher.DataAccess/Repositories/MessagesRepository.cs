namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class MessagesRepository : Repository<Message, int>, IMessagesRepository
    {
        public MessagesRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }
    }
}
