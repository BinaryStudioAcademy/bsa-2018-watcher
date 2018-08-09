namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class NotificationSettingsRepository : Repository<NotificationSetting, int>, INotificationSettingsRepository
    {
        public NotificationSettingsRepository(WatcherDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
