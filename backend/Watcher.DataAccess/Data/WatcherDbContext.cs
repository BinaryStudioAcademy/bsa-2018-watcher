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

            modelBuilder.Entity<UserChat>()
                .HasKey(uc => new { uc.UserId, uc.ChatId });

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Response)
                .WithOne(r => r.Feedback)
                .HasForeignKey<Feedback>(r => r.ResponseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NotificationSetting>()
                .HasMany(ns => ns.Notifications)
                .WithOne(n => n.NotificationSetting);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.CreatedBy)
                .WithMany(u => u.CreatedChats)
                .HasForeignKey(c => c.CreatedById)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<NotificationSetting>()
                .HasOne(ns => ns.User)
                .WithMany(u => u.NotificationSettings)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Messages)
                .WithOne(m => m.User)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<User>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Responses)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Feedbacks)
                .WithOne(f => f.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Organization)
                .WithOne(o => o.Chat);

            modelBuilder.Entity<Organization>()
                .HasOne(u => u.CreatedByUser)
                .WithMany(o => o.CreatedOrganizations)
                .HasForeignKey(x => x.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Seed();
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
