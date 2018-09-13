namespace Watcher.DataAccess.Repositories
{
    using System.Net;
    using System.Threading.Tasks;
    using AutoMapper;
    using Watcher.Common.Errors;
    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces.Repositories;

    public class UsersRepository : Repository<User, string>, IUsersRepository
    {
        public UsersRepository(WatcherDbContext context, IMapper automapper) : base(context, automapper)
        {
        }

        public async Task<User> UpdateProfileAsync(User entity)
        {
            var findEntity = await DbSet.FindAsync(entity.Id);

            if (findEntity == null)
            {
                throw new HttpStatusCodeException(HttpStatusCode.NotFound, $"Entity {entity.GetType().Name} with id: {entity.Id} not found");
            }

            if (entity.Role != null)
            {
                findEntity.RoleId = entity.Role.Id;
            }

            findEntity.Bio = entity.Bio;
            findEntity.FirstName = entity.FirstName;
            findEntity.LastName = entity.LastName;
            findEntity.DisplayName = entity.DisplayName;
            findEntity.Email = entity.Email;
            findEntity.EmailForNotifications = entity.EmailForNotifications;
            findEntity.PhotoURL = entity.PhotoURL;

            return findEntity;
        }
    }
}