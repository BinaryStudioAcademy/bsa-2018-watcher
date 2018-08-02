namespace Watcher.DataAccess.Data
{

    using Microsoft.EntityFrameworkCore;

    using Watcher.DataAccess.Entities;

    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class WatcherDbContext : DbContext
    {
        public WatcherDbContext(DbContextOptions<WatcherDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Make your configs here...
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Sample> Samples { get; set; }
    }
}
