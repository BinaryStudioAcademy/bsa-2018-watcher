namespace Watcher.DataAccess.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Interfaces.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransaction();

        void CommitTransaction();

        ISamplesRepository SamplesRepository { get; }

        IUsersRepository UsersRepository { get; }

        IDashboardsRepository DashboardsRepository { get; }

        IOrganizationRepository OrganizationRepository { get; }

        IUserOrganizationRepository UserOrganizationRepository { get; }

        IUserChatRepository UserChatRepository { get; }

        IFeedbackRepository FeedbackRepository { get; }

        IResponseRepository ResponseRepository { get; }

        IRoleRepository RoleRepository { get; }
        
        IOrganizationRoleRepository OrganizationRoleRepository { get; }

        INotificationSettingsRepository NotificationSettingsRepository { get; }

        IChatsRepository ChatsRepository { get; }

        IMessagesRepository MessagesRepository { get; }

        IInstanceRepository InstanceRepository { get; }

        IOrganizationInvitesRepository OrganizationInvitesRepository { get; }

        INotificationsRepository NotificationsRepository { get; }

        IChartsRepository ChartsRepository { get;  }

        ICollectorAppVersionRepository CollectorAppVersionRepository { get; }

        IThemeRepository ThemeRepository { get; }

        Task<bool> SaveAsync();
    }
}