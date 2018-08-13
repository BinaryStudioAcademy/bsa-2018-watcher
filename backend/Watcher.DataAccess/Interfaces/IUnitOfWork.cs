namespace Watcher.DataAccess.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Interfaces.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        ISamplesRepository SamplesRepository { get; }
        
        IUsersRepository UsersRepository { get; }

        IDashboardsRepository DashboardsRepository { get; }

        IOrganizationRepository OrganizationRepository { get; }

        INotificationSettingsRepository NotificationSettingsRepository { get; }

        IChatsRepository ChatsRepository { get; }

        IMessagesRepository MessagesRepository { get; }

        Task<bool> SaveAsync();
    }
}