namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class NotificationRepository : Repository<Notification, int>, INotificationsRepository
    {
        public NotificationRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }
    }
}
