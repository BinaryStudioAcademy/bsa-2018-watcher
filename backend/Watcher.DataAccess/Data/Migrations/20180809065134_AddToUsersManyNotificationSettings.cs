using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddToUsersManyNotificationSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Count = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    SampleField = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    FontFamily = table.Column<string>(nullable: true),
                    BackgroundColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ResponseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    IsMute = table.Column<bool>(nullable: false),
                    IsDisable = table.Column<bool>(nullable: false),
                    IsEmailable = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationSettings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    ThemeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizations_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    FeedbackId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responses_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    Platform = table.Column<string>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instances_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    NotificationSettingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                        column: x => x.NotificationSettingId,
                        principalTable: "NotificationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOrganizations",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrganizations", x => new { x.UserId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_UserOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOrganizations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    WasRead = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ChatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    InstanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dashboards_Instances_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    ShowCommon = table.Column<string>(nullable: true),
                    Threshold = table.Column<int>(nullable: false),
                    MostLoaded = table.Column<string>(nullable: true),
                    DashboardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charts_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 11, false, true, false, 1, 0 },
                    { 12, true, true, true, 1, 0 },
                    { 13, false, false, true, 1, 0 },
                    { 14, true, false, false, 1, 0 },
                    { 15, false, false, false, 1, 0 },
                    { 16, true, false, false, 0, 0 },
                    { 17, false, false, true, 1, 0 },
                    { 18, true, true, true, 1, 0 },
                    { 19, true, true, false, 1, 0 },
                    { 20, true, true, true, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "User" },
                    { 1, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "Name" },
                values: new object[,]
                {
                    { 61, "Gray", "Univers", "Theme650" },
                    { 62, "White", "Trade", "Theme657" },
                    { 63, "White", "Trade", "Theme219" },
                    { 64, "Gray", "Helvetica", "Theme578" },
                    { 65, "Gray", "Univers", "Theme855" },
                    { 66, "Gray", "Trade", "Theme766" },
                    { 67, "White", "Univers", "Theme906" },
                    { 68, "White", "Univers", "Theme164" },
                    { 69, "White", "Frutiger", "Theme663" },
                    { 70, "Gray", "Univers", "Theme398" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 8, 9, 3, 18, 7, 763, DateTimeKind.Local), "Jayde.Upton40@yahoo.com", "Alessandro", true, 1, "Jast" },
                    { 2, new DateTime(2018, 8, 9, 8, 52, 10, 724, DateTimeKind.Local), "Dan.Bergstrom22@hotmail.com", "Alexanne", true, 1, "Torp" },
                    { 3, new DateTime(2018, 8, 9, 7, 7, 29, 611, DateTimeKind.Local), "Timothy4@gmail.com", "Grover", true, 1, "Jast" },
                    { 6, new DateTime(2018, 8, 8, 19, 1, 53, 711, DateTimeKind.Local), "Cyril.Balistreri7@yahoo.com", "Nigel", true, 1, "Hermiston" },
                    { 8, new DateTime(2018, 8, 9, 4, 9, 53, 512, DateTimeKind.Local), "Ashley_Labadie@hotmail.com", "Rashad", true, 1, "Braun" },
                    { 9, new DateTime(2018, 8, 8, 15, 43, 2, 750, DateTimeKind.Local), "Rae.Hessel@yahoo.com", "Elvie", true, 1, "Sipes" },
                    { 4, new DateTime(2018, 8, 9, 3, 50, 51, 350, DateTimeKind.Local), "Antonette97@gmail.com", "Freda", true, 2, "Bailey" },
                    { 5, new DateTime(2018, 8, 8, 13, 18, 20, 894, DateTimeKind.Local), "Audra.Mayert@hotmail.com", "Kayli", true, 2, "Schneider" },
                    { 7, new DateTime(2018, 8, 9, 1, 53, 33, 867, DateTimeKind.Local), "Rosamond90@yahoo.com", "Melyssa", true, 2, "Gibson" },
                    { 10, new DateTime(2018, 8, 8, 23, 32, 31, 254, DateTimeKind.Local), "Vance_Okuneva54@gmail.com", "Caitlyn", true, 2, "Zieme" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 26, 1, "saepe", null, 0 },
                    { 24, 4, "quidem", null, 0 },
                    { 27, 6, "quidem", null, 0 },
                    { 23, 6, "sed", null, 0 },
                    { 25, 9, "aspernatur", null, 0 },
                    { 28, 5, "fugiat", null, 0 },
                    { 22, 5, "praesentium", null, 0 },
                    { 30, 10, "voluptates", null, 0 },
                    { 29, 1, "odit", null, 0 },
                    { 21, 9, "voluptatem", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 42, new DateTime(2018, 8, 9, 5, 28, 6, 601, DateTimeKind.Local), null, "Esse in omnis beatae delectus consequatur labore quibusdam.", 2 },
                    { 43, new DateTime(2018, 8, 8, 19, 3, 46, 189, DateTimeKind.Local), null, "Sit amet quia deleniti molestiae excepturi aut natus qui eius.", 5 },
                    { 49, new DateTime(2018, 8, 8, 13, 46, 13, 466, DateTimeKind.Local), null, "Non delectus et sed error.", 5 },
                    { 50, new DateTime(2018, 8, 8, 16, 55, 14, 858, DateTimeKind.Local), null, "Molestiae commodi aut minima recusandae et reprehenderit minima et.", 10 },
                    { 46, new DateTime(2018, 8, 8, 14, 39, 17, 948, DateTimeKind.Local), null, "At nobis ex occaecati quas.", 1 },
                    { 44, new DateTime(2018, 8, 8, 16, 14, 9, 44, DateTimeKind.Local), null, "Hic beatae debitis ex voluptas quidem fugit porro quos dolor.", 6 },
                    { 45, new DateTime(2018, 8, 9, 2, 20, 41, 35, DateTimeKind.Local), null, "Ea sint adipisci aut impedit enim delectus doloribus suscipit a.", 6 },
                    { 48, new DateTime(2018, 8, 8, 16, 59, 36, 487, DateTimeKind.Local), null, "Iure ut itaque odit officia consequatur.", 6 },
                    { 47, new DateTime(2018, 8, 9, 3, 4, 39, 884, DateTimeKind.Local), null, "Consequuntur necessitatibus corrupti aut a unde quasi.", 9 },
                    { 41, new DateTime(2018, 8, 8, 11, 54, 1, 602, DateTimeKind.Local), null, "Ad consequatur repellendus.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 114, new DateTime(2018, 8, 8, 15, 56, 46, 64, DateTimeKind.Local), 13, null, "Et et ipsa nulla exercitationem dolores ut.", 4 },
                    { 118, new DateTime(2018, 8, 9, 2, 9, 43, 257, DateTimeKind.Local), 13, null, "Velit facilis non dolores.", 8 },
                    { 119, new DateTime(2018, 8, 9, 5, 52, 29, 500, DateTimeKind.Local), 14, null, "Quod eos dolore beatae amet facilis porro.", 8 },
                    { 113, new DateTime(2018, 8, 9, 7, 0, 3, 242, DateTimeKind.Local), 15, null, "Accusamus nostrum deserunt veniam ut temporibus provident sed.", 1 },
                    { 115, new DateTime(2018, 8, 8, 21, 42, 24, 269, DateTimeKind.Local), 15, null, "Explicabo sapiente qui.", 1 },
                    { 120, new DateTime(2018, 8, 8, 23, 44, 52, 99, DateTimeKind.Local), 18, null, "Et architecto consectetur est culpa similique velit voluptas.", 1 },
                    { 111, new DateTime(2018, 8, 8, 21, 27, 21, 560, DateTimeKind.Local), 14, null, "Alias debitis quia quis a qui neque quo adipisci quisquam.", 3 },
                    { 116, new DateTime(2018, 8, 8, 17, 46, 25, 225, DateTimeKind.Local), 16, null, "Assumenda commodi iusto eius non officiis sed voluptates atque qui.", 2 },
                    { 112, new DateTime(2018, 8, 9, 7, 15, 3, 217, DateTimeKind.Local), 20, null, "Sint ut eum omnis voluptas doloribus sed voluptatem.", 8 },
                    { 117, new DateTime(2018, 8, 8, 16, 21, 50, 648, DateTimeKind.Local), 15, null, "Non omnis est dicta hic est.", 10 }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "IsActive", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 80, "422-710-1258 x159", 6, "Ut esse velit voluptate minima a facilis quod ad iste. Autem ducimus laborum qui ullam est voluptates. Cum nam optio quaerat et et veritatis qui ratione tempora.", "Grover_Schmeler96@yahoo.com", true, "Company77", 69, "http://emmitt.name" },
                    { 72, "(637) 542-4055 x80728", 2, "", "Elyse84@hotmail.com", true, "Company976", 70, "https://russell.org" },
                    { 75, "(284) 474-6810 x2153", 8, "Sed et fugit dolorem aut voluptatem qui cum itaque reprehenderit. Sunt facilis nisi dolor quos. Dolorum dolorem repellendus est excepturi voluptate labore iusto esse corporis. Fugit recusandae ut laborum vel incidunt facilis voluptas culpa cum.", "Twila18@hotmail.com", true, "Company332", 68, "https://matteo.org" },
                    { 79, "466.594.3939 x586", 9, "", "Ashlee.Koelpin81@gmail.com", true, "Company533", 67, "https://terrance.org" },
                    { 73, "1-793-285-1079 x25233", 5, "", "Sheldon26@gmail.com", true, "Company145", 61, "http://enrico.net" },
                    { 74, "1-371-984-9797 x604", 5, "Quia sapiente molestias totam velit eum exercitationem veniam est fugiat. Accusantium tempora dolore. Quo non consequatur sit. Corporis voluptas aut unde non dolores quo consequuntur enim.", "Mustafa.Beer62@gmail.com", true, "Company41", 61, "https://lydia.com" },
                    { 76, "902.606.8759", 5, "Consequatur consequuntur eligendi possimus esse cumque esse. Ullam voluptates quasi minima culpa doloremque architecto et voluptatem dolorem. Voluptatem iure omnis ipsam aut placeat asperiores. Odit cumque rerum sequi quibusdam laborum qui.", "Esta24@yahoo.com", true, "Company505", 63, "https://susana.net" },
                    { 78, "723.583.4916", 7, "Neque sed expedita odio impedit. Blanditiis illo asperiores laboriosam.", "Viola_Harvey@hotmail.com", true, "Company886", 64, "https://kaci.net" },
                    { 77, "643.848.1285 x04032", 6, "Ad libero repellat iste accusamus officia a suscipit dignissimos.", "Arjun_Kuhn3@hotmail.com", true, "Company478", 66, "http://ova.name" },
                    { 71, "(362) 643-4463", 10, "Mollitia quo quod quaerat dolor dolor quidem tempore. Officia architecto quibusdam adipisci. Consequuntur nam laboriosam quos qui natus sit commodi.", "Henry_Feeney@yahoo.com", true, "Company562", 70, "https://tiara.com" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 88, "8d:79:65:90:1f:09", 71, "Windows" },
                    { 84, "27:8b:ca:37:5f:7f", 76, "Linux" },
                    { 89, "71:55:f2:8f:a2:1a", 74, "Windows" },
                    { 85, "bd:1c:a2:91:4a:2c", 72, "Linux" },
                    { 90, "5d:d3:fc:90:ef:a0", 72, "Linux" },
                    { 87, "64:f6:5a:ac:12:2c", 74, "Windows" },
                    { 83, "cb:8d:84:a3:0d:f7", 74, "Linux" },
                    { 81, "28:e1:52:8d:1c:ea", 73, "Windows" },
                    { 82, "a4:f5:05:b0:ab:45", 77, "Windows" },
                    { 86, "a7:7d:08:b3:ad:92", 80, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 35, 28, new DateTime(2018, 8, 9, 4, 10, 11, 408, DateTimeKind.Local), "Consequatur enim nam ea rerum quidem nemo eaque ipsum.", 5, false },
                    { 40, 22, new DateTime(2018, 8, 8, 17, 54, 53, 591, DateTimeKind.Local), "Atque deleniti natus quia quas qui voluptatem.", 5, false },
                    { 39, 22, new DateTime(2018, 8, 8, 21, 49, 38, 252, DateTimeKind.Local), "Ea fugit alias eveniet harum.", 1, false },
                    { 37, 21, new DateTime(2018, 8, 9, 5, 23, 46, 193, DateTimeKind.Local), "Eius et est amet cum mollitia.", 7, false },
                    { 33, 22, new DateTime(2018, 8, 8, 21, 44, 57, 159, DateTimeKind.Local), "Et optio cupiditate voluptas omnis aliquid ullam voluptas harum voluptates.", 3, false },
                    { 32, 21, new DateTime(2018, 8, 9, 5, 10, 58, 930, DateTimeKind.Local), "Non fuga iure ut.", 1, false },
                    { 31, 27, new DateTime(2018, 8, 8, 22, 40, 44, 539, DateTimeKind.Local), "Dolor consectetur qui sint.", 5, false },
                    { 38, 27, new DateTime(2018, 8, 8, 11, 9, 36, 284, DateTimeKind.Local), "Est enim similique laudantium asperiores qui sed nihil est quasi.", 3, false },
                    { 34, 21, new DateTime(2018, 8, 9, 8, 33, 41, 17, DateTimeKind.Local), "Nihil eos impedit debitis similique.", 10, true },
                    { 36, 29, new DateTime(2018, 8, 9, 9, 3, 16, 417, DateTimeKind.Local), "Incidunt dolorum officia fugiat impedit similique quod commodi.", 5, true }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 57, new DateTime(2018, 8, 9, 5, 1, 57, 464, DateTimeKind.Local), 48, "Eum molestiae quis qui.", 3 },
                    { 60, new DateTime(2018, 8, 9, 8, 43, 1, 71, DateTimeKind.Local), 41, "Qui dolorem ad eius fugit adipisci.", 1 },
                    { 53, new DateTime(2018, 8, 8, 15, 41, 43, 516, DateTimeKind.Local), 47, "Ut unde eum sapiente distinctio nihil.", 7 },
                    { 56, new DateTime(2018, 8, 9, 6, 35, 35, 526, DateTimeKind.Local), 42, "Quis tenetur aliquam repellendus harum nihil rem aut eos sint.", 4 },
                    { 51, new DateTime(2018, 8, 9, 7, 32, 47, 573, DateTimeKind.Local), 49, "Quisquam eveniet impedit dolores omnis molestiae omnis velit placeat.", 10 },
                    { 59, new DateTime(2018, 8, 8, 17, 47, 48, 45, DateTimeKind.Local), 45, "Debitis facere rem.", 4 },
                    { 54, new DateTime(2018, 8, 9, 9, 5, 35, 779, DateTimeKind.Local), 44, "Sed similique rerum quis vitae.", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { 1, 73 },
                    { 6, 78 },
                    { 3, 79 },
                    { 10, 77 },
                    { 7, 76 },
                    { 8, 76 },
                    { 9, 76 },
                    { 2, 78 },
                    { 5, 78 },
                    { 4, 73 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 94, new DateTime(2018, 8, 8, 18, 54, 7, 826, DateTimeKind.Local), 86, "Title816" },
                    { 93, new DateTime(2018, 8, 8, 23, 7, 13, 219, DateTimeKind.Local), 81, "Title566" },
                    { 99, new DateTime(2018, 8, 8, 14, 18, 33, 590, DateTimeKind.Local), 81, "Title924" },
                    { 100, new DateTime(2018, 8, 8, 17, 58, 44, 691, DateTimeKind.Local), 81, "Title681" },
                    { 95, new DateTime(2018, 8, 8, 12, 34, 55, 872, DateTimeKind.Local), 83, "Title617" },
                    { 98, new DateTime(2018, 8, 8, 14, 54, 19, 15, DateTimeKind.Local), 83, "Title245" },
                    { 92, new DateTime(2018, 8, 8, 13, 38, 15, 243, DateTimeKind.Local), 87, "Title412" },
                    { 91, new DateTime(2018, 8, 8, 23, 13, 7, 567, DateTimeKind.Local), 89, "Title583" },
                    { 97, new DateTime(2018, 8, 8, 16, 12, 57, 455, DateTimeKind.Local), 84, "Title287" },
                    { 96, new DateTime(2018, 8, 8, 23, 41, 31, 155, DateTimeKind.Local), 88, "Title344" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 104, 94, "MostLoaded2", "Common3", "Source2", 54, 1 },
                    { 107, 99, "MostLoaded2", "Common2", "Source1", 20, 0 },
                    { 109, 99, "MostLoaded3", "Common3", "Source2", 96, 2 },
                    { 110, 100, "MostLoaded2", "Common1", "Source2", 0, 2 },
                    { 103, 98, "MostLoaded3", "Common2", "Source1", 97, 0 },
                    { 102, 92, "MostLoaded3", "Common3", "Source2", 25, 1 },
                    { 101, 91, "MostLoaded2", "Common3", "Source2", 80, 0 },
                    { 105, 97, "MostLoaded1", "Common1", "Source3", 51, 2 },
                    { 106, 97, "MostLoaded3", "Common2", "Source3", 89, 1 },
                    { 108, 96, "MostLoaded3", "Common3", "Source2", 64, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Charts_DashboardId",
                table: "Charts",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_CreatedById",
                table: "Chats",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_OrganizationId",
                table: "Chats",
                column: "OrganizationId",
                unique: true,
                filter: "[OrganizationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_InstanceId",
                table: "Dashboards",
                column: "InstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instances_OrganizationId",
                table: "Instances",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationSettingId",
                table: "Notifications",
                column: "NotificationSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_OrganizationId",
                table: "Notifications",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_UserId",
                table: "NotificationSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CreatedByUserId",
                table: "Organizations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_ThemeId",
                table: "Organizations",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_FeedbackId",
                table: "Responses",
                column: "FeedbackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_UserId",
                table: "Responses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationId",
                table: "UserOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "UserOrganizations");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "NotificationSettings");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
