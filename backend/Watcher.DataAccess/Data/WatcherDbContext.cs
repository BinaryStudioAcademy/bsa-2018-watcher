namespace Watcher.DataAccess.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;
    using System.Linq;
    using Watcher.Common.Interfaces.Entities;
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

            //foreach (var entity in modelBuilder.Model.GetEntityTypes().Where(e => e is ISoftDeletable))
            //{
            //    var type = entity;
                
            //    modelBuilder.Entity(entity.ClrType).HasQueryFilter(q => )

            //    entity.GetOrAddProperty("IsDeleted", typeof(bool));               



            //    var parameter = Expression.Parameter(entity.ClrType);

            //    var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(bool));
            //    var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("IsDeleted"));

            //    BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));

            //    var lambda = Expression.Lambda(compareExpression, parameter);

            //    //modelBuilder.Entity(entity.ClrType).HasQueryFilter(lambda);
            //}

            modelBuilder.Entity<UserOrganization>()
                .HasKey(uo => new { uo.UserId, uo.OrganizationId });

            modelBuilder.Entity<UserChat>()
                .HasKey(uc => new { uc.UserId, uc.ChatId });

            modelBuilder.Entity<Feedback>()
                .HasQueryFilter(f => EF.Property<bool>(f, "IsDeleted") == false)
                .HasOne(f => f.Response)
                .WithOne(r => r.Feedback)
                .HasForeignKey<Feedback>(r => r.ResponseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NotificationSetting>()
                .HasQueryFilter(f => EF.Property<bool>(f, "IsDeleted") == false)
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

            modelBuilder.Entity<User>()
                .HasMany(u => u.OrganizationInvites)
                .WithOne(f => f.CreatedByUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Organization)
                .WithOne(o => o.Chat);

            modelBuilder.Entity<OrganizationInvite>()
                .HasOne(u => u.Organization)
                .WithMany(o => o.OrganizationInvites)
                .HasForeignKey(x => x.OrganizationId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<OrganizationInvite>()
                .HasOne(u => u.CreatedByUser)
                .WithMany(o => o.OrganizationInvites)
                .HasForeignKey(x => x.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Organization>()
                .HasOne(u => u.CreatedByUser)
                .WithMany(o => o.CreatedOrganizations)
                .HasForeignKey(x => x.CreatedByUserId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Organization>()
               .HasMany(u => u.OrganizationInvites)
               .WithOne(f => f.Organization)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Instance>()
                .HasQueryFilter(instance => EF.Property<bool>(instance, "IsDeleted") == false);

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

        public DbSet<UserChat> UserChat { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NotificationSetting> NotificationSettings { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Response> Responses { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<OrganizationInvite> OrganizationInvites { get; set; }
    }
}
