namespace Watcher.DataAccess.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using Watcher.DataAccess.Interfaces.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        ISamplesRepository SamplesRepository { get; }

        IOrganizationRepository OrganizationRepository { get; }

        INotificationSettingsRepository NotificationSettingsRepository { get; }

        Task<bool> SaveAsync();
    }
}