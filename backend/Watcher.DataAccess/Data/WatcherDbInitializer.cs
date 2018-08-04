namespace Watcher.DataAccess.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Bogus;

    using Watcher.DataAccess.Entities;
    using Watcher.Common.Enums;

    public static class WatcherDbInitializer
    {
        /// <summary>
        /// Seed data for WatcherDbContext if Users and Organizations is empty
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="amount">Amount of generated pairs user-organization</param>
        public static void SeedIfEmpty(WatcherDbContext dbContext)
        {
            if(dbContext.UserOrganizations.Any() ||
                 dbContext.Users.Any() ||
                 dbContext.Organizations.Any())
            {
                return;
            }

            var roles = new List<Role> {
                new Role { Name = "Admin"},
                new Role { Name = "User"}
            };

            var chartFaker = new Faker<Chart>()
                .RuleFor(o => o.Source, f => f.PickRandom("Source1", "Source2", "Source3"))
                .RuleFor(o => o.ShowCommon, f => f.PickRandom("Common1", "Common2", "Common3"))
                .RuleFor(o => o.MostLoaded, f => f.PickRandom("MostLoaded1", "MostLoaded2", "MostLoaded3"))
                .RuleFor(o => o.Threshold, f => f.Random.Number(100))
                .RuleFor(o => o.Type, f => f.Random.Enum<ChartType>());

            var dashboardFaker = new Faker<Dashboard>()
                .RuleFor(o => o.Title, f => f.PickRandom("Title" + f.Random.Number(999)))
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.Charts, f => chartFaker.Generate(f.Random.Number(3)));

            var instanceFaker = new Faker<Instance>()
                .RuleFor(o => o.Platform, f => f.PickRandom("Windows", "Linux"))
                .RuleFor(o => o.Address, f => f.Internet.Mac())
                .RuleFor(o => o.Dashboards, f => dashboardFaker.Generate(f.Random.Number(3)));

            var themeFaker = new Faker<Theme>()
                .RuleFor(o => o.Name, f => f.PickRandom("Theme" + f.Random.Number(999)))
                .RuleFor(o => o.BackgroundColor, f => f.PickRandom("White", "Gray", "Yellow"))
                .RuleFor(o => o.FontFamily, f => f.PickRandom("Helvetica", "Univers", "Frutiger", "Trade"));

            var organizationFaker = new Faker<Organization>()
                .RuleFor(o => o.Name, f => f.PickRandom("Company" + f.Random.Number(999)))
                .RuleFor(o => o.Theme, f => themeFaker.Generate())
                .RuleFor(o => o.Instances, f => instanceFaker.Generate(3));
            
            var ogranizations = organizationFaker.Generate(3);

            var notificationFaker = new Faker<Notification>()
                .RuleFor(o => o.Text, f => f.Lorem.Text())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.Organization, f => f.PickRandom(ogranizations));

            var notificationSettingFaker = new Faker<NotificationSetting>()
                .RuleFor(o => o.IsDisable, f => f.PickRandom(true, false))
                .RuleFor(o => o.IsMute, f => f.PickRandom(true, false))
                .RuleFor(o => o.Type, f => f.Random.Enum<NotificationType>());

            var feedbackFaker = new Faker<Feedback>()
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent());

            var chatFaker = new Faker<Chat>()
                .RuleFor(o => o.Name, f => f.Lorem.Word())
                .RuleFor(o => o.Type, f => f.Random.Enum<ChatType>());
            var chats = chatFaker.Generate(3);

            var messageFaker = new Faker<Message>()
                .RuleFor(o => o.Text, f => f.Lorem.Sentence())
                .RuleFor(o => o.WasRead, f => f.PickRandom(true, false))
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.Chat, f => f.PickRandom(chats));

            var userFaker = new Faker<User>()
                .RuleFor(o => o.FirstName, f => f.Name.FirstName())
                .RuleFor(o => o.SecondName, f => f.Name.LastName())
                .RuleFor(o => o.Role, f => f.PickRandom(roles))
                .RuleFor(o => o.Email, f => f.Internet.Email())
                .RuleFor(o => o.IsActive, f => f.PickRandom(true, false))
                .RuleFor(o => o.CreatedAt, f => f.Date.Recent())
                .RuleFor(o => o.NotificationSetting, f => notificationSettingFaker.Generate())
                .RuleFor(o => o.Notifications, f => notificationFaker.Generate(f.Random.Number(5)))
                .RuleFor(o => o.Feedbacks, f => feedbackFaker.Generate(3))
                .RuleFor(o => o.Messages, f => messageFaker.Generate(3));


            var userOrganizationFaker = new Faker<UserOrganization>()
                .RuleFor(o => o.Organization, f => f.PickRandom(ogranizations))
                .RuleFor(o => o.User, f => userFaker.Generate());

            dbContext.Chats.AddRange(chats);
            dbContext.UserOrganizations.AddRange(userOrganizationFaker.Generate(5));

            dbContext.SaveChanges();
        }
    }
}
