namespace Watcher.DataAccess
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Transactions;
    using AutoMapper;

    using Microsoft.EntityFrameworkCore;

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

        private INotificationSettingsRepository _notificationSettingsRepository;
        private IInstanceRepository _instanceRepository;
        private IChartRepository _chartRepository;

        private IOrganizationInvitesRepository _organizationInvitesRepository;

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


        public ISamplesRepository SamplesRepository
        {
            get
            {
                if (_samplesRepository == null)
                {
                    _samplesRepository = new SamplesRepository(_context, _mapper);
                }

                return _samplesRepository;
            }
        }

        public IUsersRepository UsersRepository => _usersRepository ?? (_usersRepository = new UsersRepository(_context, _mapper));

        public IDashboardsRepository DashboardsRepository
        {
            get
            {
                if (_dashboardsRepository == null)
                {
                    _dashboardsRepository = new DashboardsRepository(_context, _mapper);
                }

                return _dashboardsRepository;
            }

        }

        public IOrganizationRepository OrganizationRepository
        {
            get
            {
                if (_organizationRepository == null)
                {
                    _organizationRepository = new OrganizationRepository(_context, _mapper);
                }

                return _organizationRepository;
            }
        }

        public IFeedbackRepository FeedbackRepository
        {
            get
            {
                if (_feedbackRepository == null)
                {
                    _feedbackRepository = new FeedbackRepository(_context, _mapper);
                }

                return _feedbackRepository;
            }
        }

        public INotificationSettingsRepository NotificationSettingsRepository
        {
            get
            {
                if (_notificationSettingsRepository == null)
                {
                    _notificationSettingsRepository = new NotificationSettingsRepository(_context, _mapper);
                }

                return _notificationSettingsRepository;
            }
        }

        public IInstanceRepository InstanceRepository
        {
            get
            {
                if (_instanceRepository == null)
                {
                    _instanceRepository = new InstanceRepository(_context, _mapper);
                }

                return _instanceRepository;
            }
        }

        public IChartRepository ChartRepository
        {
            get
            {
                if(_chartRepository == null)
                {
                    _chartRepository = new ChartsRepository(_context, _mapper);
                }
                return _chartRepository;
            }
        }

        public IOrganizationInvitesRepository OrganizationInvitesRepository
        {
            get
            {
                if (_organizationInvitesRepository == null)
                {
                    _organizationInvitesRepository = new OrganizationInvitesRepository(_context, _mapper);
                }
                return _organizationInvitesRepository;
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
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
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
