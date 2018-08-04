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

            modelBuilder.Entity<UserOrganization>()
                .HasKey(uo => new {uo.UserId, uo.OrganizationId});

            modelBuilder.Entity<Response>()
                .HasOne<Feedback>(r => r.Feedback)
                .WithOne(f => f.Response)
                .HasForeignKey<Response>(r => r.FeedbackId);
        }

        public DbSet<Sample> Samples { get; set; }
    }
}
