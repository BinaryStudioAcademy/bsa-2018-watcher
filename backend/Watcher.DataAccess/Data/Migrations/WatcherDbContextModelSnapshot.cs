﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Watcher.DataAccess.Data;

namespace Watcher.DataAccess.Data.Migrations
{
    [DbContext(typeof(WatcherDbContext))]
    partial class WatcherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Watcher.DataAccess.Entities.Chart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DashboardId");

                    b.Property<string>("MostLoaded");

                    b.Property<string>("ShowCommon");

                    b.Property<string>("Source")
                        .IsRequired();

                    b.Property<int>("Threshold");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.ToTable("Charts");

                    b.HasData(
                        new { Id = 101, DashboardId = 92, MostLoaded = "MostLoaded1", ShowCommon = "Common2", Source = "Source1", Threshold = 3, Type = 1 },
                        new { Id = 102, DashboardId = 99, MostLoaded = "MostLoaded1", ShowCommon = "Common3", Source = "Source1", Threshold = 12, Type = 1 },
                        new { Id = 103, DashboardId = 99, MostLoaded = "MostLoaded2", ShowCommon = "Common1", Source = "Source2", Threshold = 78, Type = 2 },
                        new { Id = 104, DashboardId = 91, MostLoaded = "MostLoaded1", ShowCommon = "Common3", Source = "Source3", Threshold = 0, Type = 1 },
                        new { Id = 105, DashboardId = 95, MostLoaded = "MostLoaded2", ShowCommon = "Common2", Source = "Source1", Threshold = 22, Type = 1 },
                        new { Id = 106, DashboardId = 93, MostLoaded = "MostLoaded1", ShowCommon = "Common2", Source = "Source3", Threshold = 12, Type = 2 },
                        new { Id = 107, DashboardId = 94, MostLoaded = "MostLoaded2", ShowCommon = "Common2", Source = "Source3", Threshold = 35, Type = 0 },
                        new { Id = 108, DashboardId = 92, MostLoaded = "MostLoaded2", ShowCommon = "Common3", Source = "Source3", Threshold = 54, Type = 1 },
                        new { Id = 109, DashboardId = 96, MostLoaded = "MostLoaded1", ShowCommon = "Common2", Source = "Source3", Threshold = 86, Type = 0 },
                        new { Id = 110, DashboardId = 91, MostLoaded = "MostLoaded3", ShowCommon = "Common1", Source = "Source2", Threshold = 15, Type = 2 }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedById");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrganizationId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("OrganizationId")
                        .IsUnique()
                        .HasFilter("[OrganizationId] IS NOT NULL");

                    b.ToTable("Chats");

                    b.HasData(
                        new { Id = 21, CreatedById = "e5f54f66-0cb0-46b9-857f-9aca56305c3d", Name = "est", Type = 0 },
                        new { Id = 22, CreatedById = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", Name = "qui", Type = 0 },
                        new { Id = 23, CreatedById = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", Name = "ut", Type = 0 },
                        new { Id = 24, CreatedById = "c716da2b-a608-4e2d-b525-a164e2f0aa12", Name = "amet", Type = 0 },
                        new { Id = 25, CreatedById = "54179531-bb49-4e4f-9c03-48fe4d5c430a", Name = "earum", Type = 0 },
                        new { Id = 26, CreatedById = "54179531-bb49-4e4f-9c03-48fe4d5c430a", Name = "ab", Type = 0 },
                        new { Id = 27, CreatedById = "65397671-3a9c-437c-97b0-4ea3309c82e8", Name = "voluptatem", Type = 0 },
                        new { Id = 28, CreatedById = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", Name = "est", Type = 0 },
                        new { Id = 29, CreatedById = "65397671-3a9c-437c-97b0-4ea3309c82e8", Name = "quam", Type = 0 },
                        new { Id = 30, CreatedById = "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", Name = "similique", Type = 0 }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("InstanceId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("InstanceId");

                    b.ToTable("Dashboards");

                    b.HasData(
                        new { Id = 91, CreatedAt = new DateTime(2018, 8, 6, 19, 36, 39, 124, DateTimeKind.Local), InstanceId = 86, Title = "Title689" },
                        new { Id = 92, CreatedAt = new DateTime(2018, 8, 6, 13, 25, 42, 122, DateTimeKind.Local), InstanceId = 88, Title = "Title87" },
                        new { Id = 93, CreatedAt = new DateTime(2018, 8, 6, 20, 32, 38, 868, DateTimeKind.Local), InstanceId = 89, Title = "Title69" },
                        new { Id = 94, CreatedAt = new DateTime(2018, 8, 7, 0, 57, 36, 913, DateTimeKind.Local), InstanceId = 86, Title = "Title444" },
                        new { Id = 95, CreatedAt = new DateTime(2018, 8, 6, 16, 10, 43, 612, DateTimeKind.Local), InstanceId = 83, Title = "Title642" },
                        new { Id = 96, CreatedAt = new DateTime(2018, 8, 6, 22, 58, 49, 65, DateTimeKind.Local), InstanceId = 90, Title = "Title648" },
                        new { Id = 97, CreatedAt = new DateTime(2018, 8, 7, 10, 49, 8, 579, DateTimeKind.Local), InstanceId = 90, Title = "Title523" },
                        new { Id = 98, CreatedAt = new DateTime(2018, 8, 7, 4, 10, 3, 481, DateTimeKind.Local), InstanceId = 83, Title = "Title100" },
                        new { Id = 99, CreatedAt = new DateTime(2018, 8, 7, 6, 40, 9, 381, DateTimeKind.Local), InstanceId = 82, Title = "Title247" },
                        new { Id = 100, CreatedAt = new DateTime(2018, 8, 7, 0, 33, 38, 200, DateTimeKind.Local), InstanceId = 88, Title = "Title663" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("ResponseId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new { Id = 41, CreatedAt = new DateTime(2018, 8, 7, 3, 15, 31, 451, DateTimeKind.Local), Text = "Animi dolores ab soluta nisi suscipit maiores enim ut.", UserId = "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                        new { Id = 42, CreatedAt = new DateTime(2018, 8, 7, 4, 28, 59, 172, DateTimeKind.Local), Text = "Et possimus odit.", UserId = "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                        new { Id = 43, CreatedAt = new DateTime(2018, 8, 6, 23, 57, 51, 573, DateTimeKind.Local), Text = "Qui tenetur non similique omnis at at qui.", UserId = "65397671-3a9c-437c-97b0-4ea3309c82e8" },
                        new { Id = 44, CreatedAt = new DateTime(2018, 8, 7, 2, 36, 28, 416, DateTimeKind.Local), Text = "Ut perspiciatis natus.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402" },
                        new { Id = 45, CreatedAt = new DateTime(2018, 8, 7, 12, 49, 58, 220, DateTimeKind.Local), Text = "Eum cum ratione.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                        new { Id = 46, CreatedAt = new DateTime(2018, 8, 6, 18, 48, 44, 429, DateTimeKind.Local), Text = "Inventore quod quo sit sed accusantium.", UserId = "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                        new { Id = 47, CreatedAt = new DateTime(2018, 8, 6, 18, 36, 20, 29, DateTimeKind.Local), Text = "Consequatur voluptatum dolorem nisi natus doloremque quisquam adipisci dolorem necessitatibus.", UserId = "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                        new { Id = 48, CreatedAt = new DateTime(2018, 8, 7, 3, 9, 17, 767, DateTimeKind.Local), Text = "Enim debitis explicabo sunt.", UserId = "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                        new { Id = 49, CreatedAt = new DateTime(2018, 8, 7, 9, 42, 1, 670, DateTimeKind.Local), Text = "Eligendi officia eligendi soluta rem.", UserId = "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                        new { Id = 50, CreatedAt = new DateTime(2018, 8, 6, 16, 8, 13, 954, DateTimeKind.Local), Text = "Cupiditate id molestiae repellendus laudantium magni voluptatem et minus aut.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Instance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("OrganizationId");

                    b.Property<string>("Platform")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Instances");

                    b.HasData(
                        new { Id = 81, Address = "29:70:47:d6:2f:56", OrganizationId = 79, Platform = "Windows" },
                        new { Id = 82, Address = "35:0a:9c:68:71:a3", OrganizationId = 75, Platform = "Windows" },
                        new { Id = 83, Address = "54:c9:a9:7d:1a:7e", OrganizationId = 79, Platform = "Windows" },
                        new { Id = 84, Address = "de:b1:ef:09:b5:0f", OrganizationId = 78, Platform = "Linux" },
                        new { Id = 85, Address = "23:b9:5d:6b:d3:c4", OrganizationId = 71, Platform = "Linux" },
                        new { Id = 86, Address = "71:71:07:84:bc:2e", OrganizationId = 74, Platform = "Linux" },
                        new { Id = 87, Address = "88:9e:aa:c3:cb:11", OrganizationId = 71, Platform = "Windows" },
                        new { Id = 88, Address = "95:61:f7:7d:66:cd", OrganizationId = 77, Platform = "Linux" },
                        new { Id = 89, Address = "47:16:45:b7:45:01", OrganizationId = 76, Platform = "Windows" },
                        new { Id = 90, Address = "c7:b1:0c:a9:77:56", OrganizationId = 72, Platform = "Linux" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChatId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.Property<bool>("WasRead");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new { Id = 31, ChatId = 24, CreatedAt = new DateTime(2018, 8, 6, 13, 49, 41, 569, DateTimeKind.Local), Text = "Quasi quis qui quisquam odio id.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", WasRead = true },
                        new { Id = 32, ChatId = 29, CreatedAt = new DateTime(2018, 8, 7, 9, 40, 43, 473, DateTimeKind.Local), Text = "Qui at numquam.", UserId = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", WasRead = false },
                        new { Id = 33, ChatId = 25, CreatedAt = new DateTime(2018, 8, 6, 21, 5, 35, 880, DateTimeKind.Local), Text = "Nihil nostrum quo et consequuntur corrupti quisquam.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402", WasRead = true },
                        new { Id = 34, ChatId = 25, CreatedAt = new DateTime(2018, 8, 6, 22, 33, 0, 613, DateTimeKind.Local), Text = "Ipsam aut voluptatem et ipsam alias velit laudantium occaecati inventore.", UserId = "54179531-bb49-4e4f-9c03-48fe4d5c430a", WasRead = false },
                        new { Id = 35, ChatId = 24, CreatedAt = new DateTime(2018, 8, 7, 4, 41, 8, 677, DateTimeKind.Local), Text = "Ullam saepe eum voluptate animi ut ut saepe.", UserId = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", WasRead = true },
                        new { Id = 36, ChatId = 27, CreatedAt = new DateTime(2018, 8, 6, 21, 13, 22, 350, DateTimeKind.Local), Text = "Quisquam nemo ducimus provident.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402", WasRead = false },
                        new { Id = 37, ChatId = 29, CreatedAt = new DateTime(2018, 8, 7, 11, 26, 51, 125, DateTimeKind.Local), Text = "Error unde voluptatem dolorum voluptas beatae consequatur et explicabo.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402", WasRead = false },
                        new { Id = 38, ChatId = 28, CreatedAt = new DateTime(2018, 8, 7, 13, 7, 6, 608, DateTimeKind.Local), Text = "Pariatur aperiam quo doloribus nisi vitae nulla.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", WasRead = true },
                        new { Id = 39, ChatId = 23, CreatedAt = new DateTime(2018, 8, 7, 6, 37, 11, 73, DateTimeKind.Local), Text = "Non est voluptas qui eum commodi et totam.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", WasRead = true },
                        new { Id = 40, ChatId = 25, CreatedAt = new DateTime(2018, 8, 7, 8, 46, 41, 851, DateTimeKind.Local), Text = "Saepe non maxime voluptatem.", UserId = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", WasRead = false }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("NotificationSettingId");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("NotificationSettingId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new { Id = 111, CreatedAt = new DateTime(2018, 8, 7, 9, 38, 53, 38, DateTimeKind.Local), NotificationSettingId = 1, Text = "Nulla labore eos eius inventore unde praesentium.", UserId = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c" },
                        new { Id = 112, CreatedAt = new DateTime(2018, 8, 7, 6, 26, 11, 599, DateTimeKind.Local), NotificationSettingId = 5, Text = "Blanditiis harum non rerum.", UserId = "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                        new { Id = 113, CreatedAt = new DateTime(2018, 8, 6, 21, 8, 55, 355, DateTimeKind.Local), NotificationSettingId = 6, Text = "Aut odio molestias accusantium quasi illo eaque id et.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                        new { Id = 114, CreatedAt = new DateTime(2018, 8, 6, 13, 31, 36, 481, DateTimeKind.Local), NotificationSettingId = 5, Text = "Veniam omnis sed odit eos possimus natus asperiores nesciunt.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402" },
                        new { Id = 115, CreatedAt = new DateTime(2018, 8, 7, 0, 42, 48, 217, DateTimeKind.Local), NotificationSettingId = 1, Text = "Qui cum fuga.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                        new { Id = 116, CreatedAt = new DateTime(2018, 8, 6, 17, 48, 33, 300, DateTimeKind.Local), NotificationSettingId = 5, Text = "Voluptatibus adipisci voluptatem laboriosam non autem dolorem sit.", UserId = "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                        new { Id = 117, CreatedAt = new DateTime(2018, 8, 6, 16, 24, 11, 249, DateTimeKind.Local), NotificationSettingId = 8, Text = "Sint qui quia officiis qui quo molestiae saepe.", UserId = "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                        new { Id = 118, CreatedAt = new DateTime(2018, 8, 7, 10, 14, 0, 472, DateTimeKind.Local), NotificationSettingId = 5, Text = "Sit animi tenetur expedita commodi aut.", UserId = "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                        new { Id = 119, CreatedAt = new DateTime(2018, 8, 7, 4, 54, 48, 807, DateTimeKind.Local), NotificationSettingId = 9, Text = "Voluptas sunt est et saepe et deserunt ut dolor.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                        new { Id = 120, CreatedAt = new DateTime(2018, 8, 6, 20, 30, 57, 572, DateTimeKind.Local), NotificationSettingId = 7, Text = "Porro modi et saepe nobis error amet pariatur numquam totam.", UserId = "f8a4e5e2-ef65-46d8-adba-9f341e3cd924" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.NotificationSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDisable");

                    b.Property<bool>("IsMute");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("NotificationSettings");

                    b.HasData(
                        new { Id = 1, IsDisable = false, IsMute = false, Type = 1 },
                        new { Id = 2, IsDisable = false, IsMute = true, Type = 1 },
                        new { Id = 3, IsDisable = true, IsMute = true, Type = 0 },
                        new { Id = 4, IsDisable = true, IsMute = true, Type = 0 },
                        new { Id = 5, IsDisable = false, IsMute = true, Type = 1 },
                        new { Id = 6, IsDisable = true, IsMute = false, Type = 0 },
                        new { Id = 7, IsDisable = true, IsMute = true, Type = 1 },
                        new { Id = 8, IsDisable = true, IsMute = true, Type = 1 },
                        new { Id = 9, IsDisable = false, IsMute = true, Type = 1 },
                        new { Id = 10, IsDisable = true, IsMute = true, Type = 1 }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new { Id = 71, Name = "Company460", ThemeId = 68 },
                        new { Id = 72, Name = "Company996", ThemeId = 61 },
                        new { Id = 73, Name = "Company311", ThemeId = 68 },
                        new { Id = 74, Name = "Company874", ThemeId = 69 },
                        new { Id = 75, Name = "Company106", ThemeId = 62 },
                        new { Id = 76, Name = "Company306", ThemeId = 68 },
                        new { Id = 77, Name = "Company237", ThemeId = 64 },
                        new { Id = 78, Name = "Company590", ThemeId = 69 },
                        new { Id = 79, Name = "Company957", ThemeId = 70 },
                        new { Id = 80, Name = "Company550", ThemeId = 66 }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("FeedbackId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Responses");

                    b.HasData(
                        new { Id = 51, CreatedAt = new DateTime(2018, 8, 7, 10, 19, 44, 734, DateTimeKind.Local), FeedbackId = 49, Text = "Deleniti voluptatem magni.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                        new { Id = 52, CreatedAt = new DateTime(2018, 8, 7, 8, 26, 3, 794, DateTimeKind.Local), FeedbackId = 48, Text = "Sapiente ut perspiciatis animi accusantium ea.", UserId = "9dac3529-7462-48ab-99ea-df3e17506402" },
                        new { Id = 53, CreatedAt = new DateTime(2018, 8, 6, 21, 12, 14, 291, DateTimeKind.Local), FeedbackId = 45, Text = "Accusamus voluptate sed dolor.", UserId = "54179531-bb49-4e4f-9c03-48fe4d5c430a" },
                        new { Id = 54, CreatedAt = new DateTime(2018, 8, 7, 6, 53, 3, 856, DateTimeKind.Local), FeedbackId = 46, Text = "Nihil aut aut consequatur ea rem ut assumenda dolorem non.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                        new { Id = 55, CreatedAt = new DateTime(2018, 8, 7, 6, 25, 13, 418, DateTimeKind.Local), FeedbackId = 43, Text = "Suscipit commodi reiciendis quis adipisci dolorem omnis aut non pariatur.", UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                        new { Id = 56, CreatedAt = new DateTime(2018, 8, 7, 9, 12, 43, 44, DateTimeKind.Local), FeedbackId = 45, Text = "Omnis sit consequatur incidunt nam magni.", UserId = "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                        new { Id = 57, CreatedAt = new DateTime(2018, 8, 7, 8, 43, 6, 648, DateTimeKind.Local), FeedbackId = 42, Text = "Debitis architecto veritatis quaerat.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                        new { Id = 58, CreatedAt = new DateTime(2018, 8, 6, 18, 5, 12, 418, DateTimeKind.Local), FeedbackId = 49, Text = "Officia doloribus architecto voluptas.", UserId = "f8a4e5e2-ef65-46d8-adba-9f341e3cd924" },
                        new { Id = 59, CreatedAt = new DateTime(2018, 8, 6, 13, 30, 5, 871, DateTimeKind.Local), FeedbackId = 45, Text = "Ut voluptatem sit neque occaecati assumenda labore et.", UserId = "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                        new { Id = 60, CreatedAt = new DateTime(2018, 8, 6, 22, 12, 5, 785, DateTimeKind.Local), FeedbackId = 49, Text = "Ut nihil impedit.", UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new { Id = 1, Name = "Admin" },
                        new { Id = 2, Name = "User" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Sample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SampleField");

                    b.HasKey("Id");

                    b.ToTable("Samples");
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("FontFamily");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Themes");

                    b.HasData(
                        new { Id = 61, BackgroundColor = "Yellow", FontFamily = "Frutiger", Name = "Theme413" },
                        new { Id = 62, BackgroundColor = "Yellow", FontFamily = "Helvetica", Name = "Theme910" },
                        new { Id = 63, BackgroundColor = "Gray", FontFamily = "Trade", Name = "Theme0" },
                        new { Id = 64, BackgroundColor = "Gray", FontFamily = "Helvetica", Name = "Theme527" },
                        new { Id = 65, BackgroundColor = "Gray", FontFamily = "Univers", Name = "Theme895" },
                        new { Id = 66, BackgroundColor = "Yellow", FontFamily = "Trade", Name = "Theme633" },
                        new { Id = 67, BackgroundColor = "Gray", FontFamily = "Helvetica", Name = "Theme264" },
                        new { Id = 68, BackgroundColor = "White", FontFamily = "Univers", Name = "Theme315" },
                        new { Id = 69, BackgroundColor = "Yellow", FontFamily = "Trade", Name = "Theme936" },
                        new { Id = 70, BackgroundColor = "Gray", FontFamily = "Helvetica", Name = "Theme875" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.User", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("NotificationSettingId");

                    b.Property<int>("RoleId");

                    b.Property<string>("SecondName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("NotificationSettingId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = "54179531-bb49-4e4f-9c03-48fe4d5c430a", CreatedAt = new DateTime(2018, 8, 7, 5, 31, 0, 489, DateTimeKind.Local), Email = "Mose_Terry@yahoo.com", FirstName = "Velva", IsActive = false, NotificationSettingId = 2, RoleId = 1, SecondName = "Kerluke" },
                        new { Id = "65397671-3a9c-437c-97b0-4ea3309c82e8", CreatedAt = new DateTime(2018, 8, 7, 8, 5, 28, 829, DateTimeKind.Local), Email = "Violet60@yahoo.com", FirstName = "Maci", IsActive = false, NotificationSettingId = 6, RoleId = 2, SecondName = "Walker" },
                        new { Id = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", CreatedAt = new DateTime(2018, 8, 6, 16, 44, 27, 881, DateTimeKind.Local), Email = "Mandy10@yahoo.com", FirstName = "Desmond", IsActive = true, NotificationSettingId = 10, RoleId = 1, SecondName = "Paucek" },
                        new { Id = "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", CreatedAt = new DateTime(2018, 8, 6, 14, 21, 50, 88, DateTimeKind.Local), Email = "Josiah.VonRueden@hotmail.com", FirstName = "Hollis", IsActive = true, NotificationSettingId = 8, RoleId = 2, SecondName = "Howe" },
                        new { Id = "9dac3529-7462-48ab-99ea-df3e17506402", CreatedAt = new DateTime(2018, 8, 7, 6, 5, 17, 127, DateTimeKind.Local), Email = "Kylee1@yahoo.com", FirstName = "Bernhard", IsActive = true, NotificationSettingId = 1, RoleId = 1, SecondName = "Graham" },
                        new { Id = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", CreatedAt = new DateTime(2018, 8, 7, 10, 17, 11, 816, DateTimeKind.Local), Email = "Chris_Ebert@hotmail.com", FirstName = "Isidro", IsActive = false, NotificationSettingId = 10, RoleId = 2, SecondName = "Daugherty" },
                        new { Id = "e5f54f66-0cb0-46b9-857f-9aca56305c3d", CreatedAt = new DateTime(2018, 8, 6, 15, 2, 30, 954, DateTimeKind.Local), Email = "Davin26@gmail.com", FirstName = "Nat", IsActive = true, NotificationSettingId = 8, RoleId = 2, SecondName = "Kuhn" },
                        new { Id = "8bd9ceb7-2599-4270-8cb1-4133bf305731", CreatedAt = new DateTime(2018, 8, 6, 23, 26, 15, 71, DateTimeKind.Local), Email = "Elody_Gorczany@gmail.com", FirstName = "Jermain", IsActive = true, NotificationSettingId = 7, RoleId = 2, SecondName = "Marvin" },
                        new { Id = "c716da2b-a608-4e2d-b525-a164e2f0aa12", CreatedAt = new DateTime(2018, 8, 7, 10, 9, 45, 917, DateTimeKind.Local), Email = "Katelin85@yahoo.com", FirstName = "Evans", IsActive = false, NotificationSettingId = 2, RoleId = 2, SecondName = "Weimann" },
                        new { Id = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", CreatedAt = new DateTime(2018, 8, 6, 16, 12, 4, 759, DateTimeKind.Local), Email = "Kali85@hotmail.com", FirstName = "Chaya", IsActive = true, NotificationSettingId = 5, RoleId = 1, SecondName = "Littel" }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.UserOrganization", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<int>("OrganizationId");

                    b.HasKey("UserId", "OrganizationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("UserOrganizations");

                    b.HasData(
                        new { UserId = "54179531-bb49-4e4f-9c03-48fe4d5c430a", OrganizationId = 78 },
                        new { UserId = "65397671-3a9c-437c-97b0-4ea3309c82e8", OrganizationId = 75 },
                        new { UserId = "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", OrganizationId = 76 },
                        new { UserId = "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", OrganizationId = 77 },
                        new { UserId = "9dac3529-7462-48ab-99ea-df3e17506402", OrganizationId = 77 },
                        new { UserId = "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", OrganizationId = 78 },
                        new { UserId = "e5f54f66-0cb0-46b9-857f-9aca56305c3d", OrganizationId = 72 },
                        new { UserId = "8bd9ceb7-2599-4270-8cb1-4133bf305731", OrganizationId = 77 },
                        new { UserId = "c716da2b-a608-4e2d-b525-a164e2f0aa12", OrganizationId = 75 },
                        new { UserId = "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", OrganizationId = 71 }
                    );
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Chart", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Dashboard", "Dashboard")
                        .WithMany("Charts")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Chat", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.User", "CreatedBy")
                        .WithMany("CreatedChats")
                        .HasForeignKey("CreatedById");

                    b.HasOne("Watcher.DataAccess.Entities.Organization", "Organization")
                        .WithOne("Chat")
                        .HasForeignKey("Watcher.DataAccess.Entities.Chat", "OrganizationId");
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Dashboard", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Instance", "Instance")
                        .WithMany("Dashboards")
                        .HasForeignKey("InstanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Feedback", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Instance", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Organization", "Organization")
                        .WithMany("Instances")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Message", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Watcher.DataAccess.Entities.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Notification", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.NotificationSetting", "NotificationSetting")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationSettingId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Watcher.DataAccess.Entities.Organization", "Organization")
                        .WithMany("Notifications")
                        .HasForeignKey("OrganizationId");

                    b.HasOne("Watcher.DataAccess.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Organization", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.Response", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Feedback", "Feedback")
                        .WithOne("Response")
                        .HasForeignKey("Watcher.DataAccess.Entities.Response", "FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Watcher.DataAccess.Entities.User", "User")
                        .WithMany("Responses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.User", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.NotificationSetting", "NotificationSetting")
                        .WithMany()
                        .HasForeignKey("NotificationSettingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Watcher.DataAccess.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watcher.DataAccess.Entities.UserOrganization", b =>
                {
                    b.HasOne("Watcher.DataAccess.Entities.Organization", "Organization")
                        .WithMany("UserOrganizations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Watcher.DataAccess.Entities.User", "User")
                        .WithMany("UserOrganizations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
