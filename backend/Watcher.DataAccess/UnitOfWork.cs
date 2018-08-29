namespace Watcher.DataAccess
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    using Watcher.DataAccess.Data;
    using Watcher.DataAccess.Interfaces;
    using Watcher.DataAccess.Interfaces.Repositories;

    using Watcher.DataAccess.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly WatcherDbContext _context;
        private readonly IMapper _mapper;

        private ISamplesRepository _samplesRepository;
        private IUsersRepository _usersRepository;
        private IDashboardsRepository _dashboardsRepository;
        private IOrganizationRepository _organizationRepository;
        private IFeedbackRepository _feedbackRepository;
        private IUserOrganizationRepository _userOrganizationRepository;

        private IResponseRepository _responseRepository;

        private IRoleRepository _roleRepository;

        private INotificationSettingsRepository _notificationSettingsRepository;

        private IInstanceRepository _instanceRepository;
        private IChartsRepository chartsRepository;

        private IChatsRepository _chatsRepository;

        private IMessagesRepository _messagesRepository;

        private IOrganizationInvitesRepository _organizationInvitesRepository;

        private INotificationsRepository _notificationsRepository;

        public UnitOfWork(WatcherDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task BeginTransaction()
        {
            await _context.Database.BeginTransactionAsync();

            //return new TransactionScope(
            //    TransactionScopeOption.Required,
            //    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted });
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public ISamplesRepository SamplesRepository => _samplesRepository ?? (_samplesRepository = new SamplesRepository(_context, _mapper));

        public IUsersRepository UsersRepository => _usersRepository ?? (_usersRepository = new UsersRepository(_context, _mapper));

        public IDashboardsRepository DashboardsRepository => _dashboardsRepository ?? (_dashboardsRepository = new DashboardsRepository(_context, _mapper));

        public IOrganizationRepository OrganizationRepository => _organizationRepository ?? (_organizationRepository = new OrganizationRepository(_context, _mapper));

        public IUserOrganizationRepository UserOrganizationRepository => _userOrganizationRepository ?? (_userOrganizationRepository = new UserOrganizationRepository(_context, _mapper));

        public IFeedbackRepository FeedbackRepository => _feedbackRepository ?? (_feedbackRepository = new FeedbackRepository(_context, _mapper));

        public INotificationSettingsRepository NotificationSettingsRepository => _notificationSettingsRepository ?? (_notificationSettingsRepository = new NotificationSettingsRepository(_context, _mapper));

        public IInstanceRepository InstanceRepository => _instanceRepository ?? (_instanceRepository = new InstanceRepository(_context, _mapper));

        public IChartsRepository ChartsRepository => chartsRepository ?? (chartsRepository = new ChartsRepository(_context, _mapper));

        public IResponseRepository ResponseRepository => _responseRepository ?? (_responseRepository = new ResponseRepository(_context, _mapper));

        public IRoleRepository RoleRepository => _roleRepository ?? (_roleRepository = new RoleRepository(_context, _mapper));

        public IChatsRepository ChatsRepository => _chatsRepository ?? (_chatsRepository = new ChatsRepository(_context, _mapper));

        public IMessagesRepository MessagesRepository => _messagesRepository ?? (_messagesRepository = new MessagesRepository(_context, _mapper));

        public IOrganizationInvitesRepository OrganizationInvitesRepository =>
            _organizationInvitesRepository
            ?? (_organizationInvitesRepository = new OrganizationInvitesRepository(_context, _mapper));

        public INotificationsRepository NotificationsRepository
        {
            get
            {
                if (_notificationsRepository == null)
                {
                    _notificationsRepository = new NotificationRepository(_context, _mapper);
                }
                return _notificationsRepository;
            }
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                var changes = _context.ChangeTracker.Entries().Count(
                    p => p.State == EntityState.Modified || p.State == EntityState.Deleted
                                                         || p.State == EntityState.Added);
                if (changes == 0) return true;
                OnBeforeSaving();
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }


        private void OnBeforeSaving()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["IsDeleted"] = false;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        break;
                }
            }
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // DbSet?.Local?.Clear();
                    _context?.Dispose();
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.


                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AbstractRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
