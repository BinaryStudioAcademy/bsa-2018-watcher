namespace Watcher.DataAccess.Data
{
    using System;
    using System.Linq;

    using Bogus;

    using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Enums;
    using Watcher.DataAccess.Entities;

    public static class WatcherDbInitializer
    {
        /// <summary>
        /// Seed data for DbContext through ModelBilder 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="amount">Amount of generated pairs user-organization</param>
        public static void Seed(this ModelBuilder modelBuilder, int amount = 10)
        {
            Faker.GlobalUniqueIndex = 0;

            var roles = new Role[] {
                new Role { Id = 1, Name = "Admin", IsDeleted = false},
                new Role { Id = 2, Name = "User", IsDeleted = false}
            };

            var organizationRoles = new OrganizationRole[]
            {
                new OrganizationRole {Id = 1, Name = "Manager", IsDeleted = false},
                new OrganizationRole {Id = 2, Name = "Member", IsDeleted = false}
            };

            var themes = new Theme[] {
                new Theme { Id = 1, Name="Default", BodyColor = "#F8FAFC !global", ThemePrimaryColor = "none", ThemeSecondaryColor = "none", ControlsHeight = "33px", ButtonFontSize = "14px !global", IsDeleted = false },
                new Theme { Id = 2, Name="Pink", BodyColor = "#F8FAFC !global", ThemePrimaryColor = "#ff5a5f", ThemeSecondaryColor = "#ffffff", ControlsHeight = "38px", ButtonFontSize = "16px !global", IsDeleted = false },
                new Theme { Id = 3, Name = "Darkness", BodyColor = "#F8FAFC", ThemePrimaryColor = "#f58400", ThemeSecondaryColor = "#ffffff", ControlsHeight = "33px", ButtonFontSize = "14px", IsDeleted = false}
            };

            var userFaker = new Faker<User>()
                .RuleFor(o => o.Id, f => Guid.NewGuid().ToString())
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.LastName, f => f.Name.LastName())
                .RuleFor(o => o.DisplayName, f => f.Name.FirstName())
                .RuleFor(o => o.Email, f => f.Internet.Email())
                .RuleFor(o => o.PhotoURL, f => f.Internet.Avatar())
                .RuleFor(o => o.IsActive, true)
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.RoleId, f => f.PickRandom(roles).Id)
                .RuleFor(o => o.IsDeleted, false);

            var users = userFaker.Generate(amount).ToArray();

            var notificationSettingFaker = new Faker<NotificationSetting>()
             .RuleFor(o => o.Id, f => f.UniqueIndex)
             .RuleFor(o => o.IsDisable, f => f.PickRandom(true, false))
             .RuleFor(o => o.IsMute, f => f.PickRandom(true, false))
             .RuleFor(o => o.IsEmailable, f => f.PickRandom(true, false))
             .RuleFor(o => o.UserId, f => f.PickRandom(users).Id)
             .RuleFor(o => o.Type, f => f.Random.Enum<NotificationType>())
             .RuleFor(o => o.IsDeleted, false);

            var notificationSettings = notificationSettingFaker.Generate(amount).ToArray();

            var userChatFaker = new Faker<Chat>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Name, f => f.Lorem.Word())
                .RuleFor(o => o.Type, f => ChatType.BetweenUsers)
                .RuleFor(o => o.CreatedById, f => f.PickRandom(users).Id)
                .RuleFor(o => o.IsDeleted, false);

            var userChats = userChatFaker.Generate(amount).ToArray();

            var messageFaker = new Faker<Message>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.WasRead, f => f.PickRandom(true, false))
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.ChatId, f => f.PickRandom(userChats).Id)
                .RuleFor(o => o.UserId, f => f.PickRandom(users).Id)
                .RuleFor(o => o.IsDeleted, false);

            var messages = messageFaker.Generate(amount).ToArray();

            var feedbackFaker = new Faker<Feedback>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.UserId, f => f.PickRandom(users).Id)
                .RuleFor(o => o.IsDeleted, false);

            var feedbacks = feedbackFaker.Generate(amount).ToArray();

            var responceFaker = new Faker<Response>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.UserId, f => f.PickRandom(users).Id)
                .RuleFor(o => o.FeedbackId, f => f.PickRandom(feedbacks).Id)
                .RuleFor(o => o.IsDeleted, false);

            var responces = responceFaker.Generate(amount).ToArray();

            var organizationFaker = new Faker<Organization>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.IsActive, true)
                .RuleFor(o => o.Name, f => f.PickRandom("Company" + f.Random.Number(999)))
                .RuleFor(o => o.Email, f => f.Internet.Email())
                .RuleFor(o => o.WebSite, f => f.Internet.Url())
                .RuleFor(o => o.ContactNumber, f => f.Phone.PhoneNumber())
                .RuleFor(o => o.Description, f => f.Lorem.Sentences(Randomizer.Seed.Next(5), " "))
                .RuleFor(o => o.CreatedByUserId, f => f.PickRandom(users).Id)
                .RuleFor(o => o.ThemeId, f => f.PickRandom(themes).Id)
                .RuleFor(o => o.IsDeleted, false);

            var organizations = organizationFaker.Generate(amount).ToArray();

            var instanceFaker = new Faker<Instance>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Platform, f => f.PickRandom("Windows", "Linux"))
                .RuleFor(o => o.Title, f => f.PickRandom("Instance" + f.Random.Number(999)))
                .RuleFor(o => o.Address, f => f.Internet.Mac())
                .RuleFor(o => o.IsActive, true)
                .RuleFor(o => o.OrganizationId, f => f.PickRandom(organizations).Id)
                .RuleFor(o => o.IsDeleted, false);

            var instances = instanceFaker.Generate(amount).ToArray();

            var dashboardFaker = new Faker<Dashboard>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Title, f => f.PickRandom("Title" + f.Random.Number(999)))
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.InstanceId, f => f.PickRandom(instances).Id)
                .RuleFor(o => o.IsDeleted, false);

            var dashboards = dashboardFaker.Generate(amount).ToArray();

            var chartFaker = new Faker<Chart>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                //.RuleFor(o => o.ShowCommon, true)
                .RuleFor(o => o.Threshold, f => f.Random.Number(100))
                .RuleFor(o => o.MostLoaded, 1)
                .RuleFor(o => o.DashboardId, f => f.PickRandom(dashboards).Id)
                .RuleFor(o => o.SchemeType, "ordinal")
                .RuleFor(o => o.ShowLegend, true)
                .RuleFor(o => o.LegendTitle, "Legend")
                .RuleFor(o => o.Gradient, false)
                .RuleFor(o => o.ShowXAxis, true)
                .RuleFor(o => o.ShowYAxis, true)
                .RuleFor(o => o.ShowXAxisLabel, true)
                .RuleFor(o => o.ShowYAxisLabel, true)
                .RuleFor(o => o.YAxisLabel, "Y Label")
                .RuleFor(o => o.XAxisLabel, "X Label")
                .RuleFor(o => o.AutoScale, true)
                .RuleFor(o => o.ShowGridLines, true)
                .RuleFor(o => o.RangeFillOpacity, 0.5d)
                .RuleFor(o => o.RoundDomains, false)
                .RuleFor(o => o.IsTooltipDisabled, false)
                .RuleFor(o => o.IsShowSeriesOnHover, true)
                .RuleFor(o => o.Title, string.Empty)
                .RuleFor(o => o.Type, f => f.Random.Enum<ChartType>())
                .RuleFor(o => o.Sources, f => f.PickRandom("0,1"))
                .RuleFor(o => o.IsLightTheme, true)
                .RuleFor(o => o.IsDeleted, false);

            var charts = chartFaker.Generate(amount).ToArray();

            var notificationFaker = new Faker<Notification>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.UserId, f => f.PickRandom(users).Id)
                .RuleFor(o => o.NotificationSettingId, f => f.PickRandom(notificationSettings).Id)
                .RuleFor(o => o.IsDeleted, false);

            var notifications = notificationFaker.Generate(amount).ToArray();

            var userOrganizations = users.Select(x =>
                new UserOrganization
                {
                    UserId = x.Id,
                    OrganizationId = organizations[Randomizer.Seed.Next(0, organizations.Length - 1)].Id,
                    OrganizationRoleId = organizationRoles[0].Id
                }).ToArray();

            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<OrganizationRole>().HasData(organizationRoles);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Chat>().HasData(userChats);
            modelBuilder.Entity<Message>().HasData(messages);
            modelBuilder.Entity<Feedback>().HasData(feedbacks);
            modelBuilder.Entity<Response>().HasData(responces);
            modelBuilder.Entity<NotificationSetting>().HasData(notificationSettings);

            modelBuilder.Entity<Theme>().HasData(themes);
            modelBuilder.Entity<Organization>().HasData(organizations);
            modelBuilder.Entity<Instance>().HasData(instances);
            modelBuilder.Entity<Dashboard>().HasData(dashboards);
            modelBuilder.Entity<Chart>().HasData(charts);
            modelBuilder.Entity<Notification>().HasData(notifications);
            modelBuilder.Entity<UserOrganization>().HasData(userOrganizations);
        }
    }
}
