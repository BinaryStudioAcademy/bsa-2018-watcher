namespace Watcher.DataAccess.Repositories
{
    using AutoMapper;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class FeedbackRepository : Repository<Feedback, int>, IFeedbackRepository
    {
        public FeedbackRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
