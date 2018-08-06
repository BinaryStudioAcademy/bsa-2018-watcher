namespace Watcher.DataAccess
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

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
        private IDashboardsRepository _dashboardsRepository;

        public UnitOfWork(WatcherDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
