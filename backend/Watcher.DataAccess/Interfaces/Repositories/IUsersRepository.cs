namespace Watcher.DataAccess.Interfaces.Repositories
{
    using System.Threading.Tasks;
    using Watcher.DataAccess.Entities;

    public interface IUsersRepository : IRepository<User, string>
    {
        Task<User> UpdateProfileAsync(User entity);
    }
}
