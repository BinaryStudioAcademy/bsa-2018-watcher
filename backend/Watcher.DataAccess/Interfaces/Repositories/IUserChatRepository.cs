namespace Watcher.DataAccess.Interfaces.Repositories
{

    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Entities;

    public interface IUserChatRepository
    {
        Task<UserChat> CreateAsync(UserChat entity);

        void Delete(string userId, int chatId);

        Task<List<User>> GetUsersByChatId(int id);

        Task<List<Chat>> GetChatsByUserId(string id);
    }
}
