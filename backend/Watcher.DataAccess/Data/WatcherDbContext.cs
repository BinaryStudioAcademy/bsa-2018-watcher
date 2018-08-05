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
                .HasKey(uo => new { uo.UserId, uo.OrganizationId });

            modelBuilder.Entity<Response>()
                .HasOne(r => r.Feedback)
                .WithOne(f => f.Response)
                .HasForeignKey<Response>(r => r.FeedbackId);

            modelBuilder.Entity<Response>()
                .HasOne(r => r.User)
                .WithMany(u => u.Responses)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.CreatedBy)
                .WithMany(u => u.CreatedChats)
                .HasForeignKey(c => c.CreatedById);

            modelBuilder.Entity<User>()
                .HasMany(u => u.CreatedChats)
                .WithOne(c => c.CreatedBy);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Organization)
                .WithOne(o => o.Chat);
        }

        public DbSet<Sample> Samples { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<UserOrganization> UserOrganizations { get; set; }
        
        public DbSet<Instance> Instances { get; set; }

        public DbSet<Dashboard> Dashboards { get; set; }

        public DbSet<Chart> Charts { get; set; }
        
        public DbSet<Message> Messages { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NotificationSetting> NotificationSettings { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Response> Responses { get; set; }

        public DbSet<Theme> Themes { get; set; }
    }
}
