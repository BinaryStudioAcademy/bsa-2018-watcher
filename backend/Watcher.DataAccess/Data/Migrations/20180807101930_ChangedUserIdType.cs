using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedUserIdType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    IsMute = table.Column<bool>(nullable: false),
                    IsDisable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.Id);
                });

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
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    NotificationSettingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_NotificationSettings_NotificationSettingId",
                        column: x => x.NotificationSettingId,
                        principalTable: "NotificationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
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
                    ThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
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
                    UserId = table.Column<string>(nullable: true),
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
                    CreatedById = table.Column<string>(nullable: true),
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
                    UserId = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOrganizations",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
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
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    WasRead = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "IsDisable", "IsMute", "Type" },
                values: new object[,]
                {
                    { 1, false, false, 1 },
                    { 2, false, true, 1 },
                    { 3, true, true, 0 },
                    { 4, true, true, 0 },
                    { 5, false, true, 1 },
                    { 6, true, false, 0 },
                    { 7, true, true, 1 },
                    { 8, true, true, 1 },
                    { 9, false, true, 1 },
                    { 10, true, true, 1 }
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
                    { 61, "Yellow", "Frutiger", "Theme413" },
                    { 62, "Yellow", "Helvetica", "Theme910" },
                    { 63, "Gray", "Trade", "Theme0" },
                    { 64, "Gray", "Helvetica", "Theme527" },
                    { 65, "Gray", "Univers", "Theme895" },
                    { 66, "Yellow", "Trade", "Theme633" },
                    { 67, "Gray", "Helvetica", "Theme264" },
                    { 68, "White", "Univers", "Theme315" },
                    { 69, "Yellow", "Trade", "Theme936" },
                    { 70, "Gray", "Helvetica", "Theme875" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "ThemeId" },
                values: new object[,]
                {
                    { 79, "Company957", 70 },
                    { 74, "Company874", 69 },
                    { 76, "Company306", 68 },
                    { 73, "Company311", 68 },
                    { 71, "Company460", 68 },
                    { 80, "Company550", 66 },
                    { 77, "Company237", 64 },
                    { 75, "Company106", 62 },
                    { 72, "Company996", 61 },
                    { 78, "Company590", 69 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "NotificationSettingId", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "c716da2b-a608-4e2d-b525-a164e2f0aa12", new DateTime(2018, 8, 7, 10, 9, 45, 917, DateTimeKind.Local), "Katelin85@yahoo.com", "Evans", false, 2, 2, "Weimann" },
                    { "e5f54f66-0cb0-46b9-857f-9aca56305c3d", new DateTime(2018, 8, 6, 15, 2, 30, 954, DateTimeKind.Local), "Davin26@gmail.com", "Nat", true, 8, 2, "Kuhn" },
                    { "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", new DateTime(2018, 8, 7, 10, 17, 11, 816, DateTimeKind.Local), "Chris_Ebert@hotmail.com", "Isidro", false, 10, 2, "Daugherty" },
                    { "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", new DateTime(2018, 8, 6, 14, 21, 50, 88, DateTimeKind.Local), "Josiah.VonRueden@hotmail.com", "Hollis", true, 8, 2, "Howe" },
                    { "65397671-3a9c-437c-97b0-4ea3309c82e8", new DateTime(2018, 8, 7, 8, 5, 28, 829, DateTimeKind.Local), "Violet60@yahoo.com", "Maci", false, 6, 2, "Walker" },
                    { "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", new DateTime(2018, 8, 6, 16, 12, 4, 759, DateTimeKind.Local), "Kali85@hotmail.com", "Chaya", true, 5, 1, "Littel" },
                    { "9dac3529-7462-48ab-99ea-df3e17506402", new DateTime(2018, 8, 7, 6, 5, 17, 127, DateTimeKind.Local), "Kylee1@yahoo.com", "Bernhard", true, 1, 1, "Graham" },
                    { "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", new DateTime(2018, 8, 6, 16, 44, 27, 881, DateTimeKind.Local), "Mandy10@yahoo.com", "Desmond", true, 10, 1, "Paucek" },
                    { "8bd9ceb7-2599-4270-8cb1-4133bf305731", new DateTime(2018, 8, 6, 23, 26, 15, 71, DateTimeKind.Local), "Elody_Gorczany@gmail.com", "Jermain", true, 7, 2, "Marvin" },
                    { "54179531-bb49-4e4f-9c03-48fe4d5c430a", new DateTime(2018, 8, 7, 5, 31, 0, 489, DateTimeKind.Local), "Mose_Terry@yahoo.com", "Velva", false, 2, 1, "Kerluke" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 25, "54179531-bb49-4e4f-9c03-48fe4d5c430a", "earum", null, 0 },
                    { 26, "54179531-bb49-4e4f-9c03-48fe4d5c430a", "ab", null, 0 },
                    { 23, "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", "ut", null, 0 },
                    { 24, "c716da2b-a608-4e2d-b525-a164e2f0aa12", "amet", null, 0 },
                    { 22, "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", "qui", null, 0 },
                    { 27, "65397671-3a9c-437c-97b0-4ea3309c82e8", "voluptatem", null, 0 },
                    { 29, "65397671-3a9c-437c-97b0-4ea3309c82e8", "quam", null, 0 },
                    { 21, "e5f54f66-0cb0-46b9-857f-9aca56305c3d", "est", null, 0 },
                    { 30, "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", "similique", null, 0 },
                    { 28, "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", "est", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 49, new DateTime(2018, 8, 7, 9, 42, 1, 670, DateTimeKind.Local), null, "Eligendi officia eligendi soluta rem.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 47, new DateTime(2018, 8, 6, 18, 36, 20, 29, DateTimeKind.Local), null, "Consequatur voluptatum dolorem nisi natus doloremque quisquam adipisci dolorem necessitatibus.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 42, new DateTime(2018, 8, 7, 4, 28, 59, 172, DateTimeKind.Local), null, "Et possimus odit.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 46, new DateTime(2018, 8, 6, 18, 48, 44, 429, DateTimeKind.Local), null, "Inventore quod quo sit sed accusantium.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 41, new DateTime(2018, 8, 7, 3, 15, 31, 451, DateTimeKind.Local), null, "Animi dolores ab soluta nisi suscipit maiores enim ut.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 48, new DateTime(2018, 8, 7, 3, 9, 17, 767, DateTimeKind.Local), null, "Enim debitis explicabo sunt.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 43, new DateTime(2018, 8, 6, 23, 57, 51, 573, DateTimeKind.Local), null, "Qui tenetur non similique omnis at at qui.", "65397671-3a9c-437c-97b0-4ea3309c82e8" },
                    { 50, new DateTime(2018, 8, 6, 16, 8, 13, 954, DateTimeKind.Local), null, "Cupiditate id molestiae repellendus laudantium magni voluptatem et minus aut.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 45, new DateTime(2018, 8, 7, 12, 49, 58, 220, DateTimeKind.Local), null, "Eum cum ratione.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 44, new DateTime(2018, 8, 7, 2, 36, 28, 416, DateTimeKind.Local), null, "Ut perspiciatis natus.", "9dac3529-7462-48ab-99ea-df3e17506402" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 82, "35:0a:9c:68:71:a3", 75, "Windows" },
                    { 84, "de:b1:ef:09:b5:0f", 78, "Linux" },
                    { 86, "71:71:07:84:bc:2e", 74, "Linux" },
                    { 89, "47:16:45:b7:45:01", 76, "Windows" },
                    { 87, "88:9e:aa:c3:cb:11", 71, "Windows" },
                    { 85, "23:b9:5d:6b:d3:c4", 71, "Linux" },
                    { 88, "95:61:f7:7d:66:cd", 77, "Linux" },
                    { 90, "c7:b1:0c:a9:77:56", 72, "Linux" },
                    { 83, "54:c9:a9:7d:1a:7e", 79, "Windows" },
                    { 81, "29:70:47:d6:2f:56", 79, "Windows" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 119, new DateTime(2018, 8, 7, 4, 54, 48, 807, DateTimeKind.Local), 9, null, "Voluptas sunt est et saepe et deserunt ut dolor.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 115, new DateTime(2018, 8, 7, 0, 42, 48, 217, DateTimeKind.Local), 1, null, "Qui cum fuga.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 112, new DateTime(2018, 8, 7, 6, 26, 11, 599, DateTimeKind.Local), 5, null, "Blanditiis harum non rerum.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 118, new DateTime(2018, 8, 7, 10, 14, 0, 472, DateTimeKind.Local), 5, null, "Sit animi tenetur expedita commodi aut.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 111, new DateTime(2018, 8, 7, 9, 38, 53, 38, DateTimeKind.Local), 1, null, "Nulla labore eos eius inventore unde praesentium.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c" },
                    { 116, new DateTime(2018, 8, 6, 17, 48, 33, 300, DateTimeKind.Local), 5, null, "Voluptatibus adipisci voluptatem laboriosam non autem dolorem sit.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 120, new DateTime(2018, 8, 6, 20, 30, 57, 572, DateTimeKind.Local), 7, null, "Porro modi et saepe nobis error amet pariatur numquam totam.", "f8a4e5e2-ef65-46d8-adba-9f341e3cd924" },
                    { 114, new DateTime(2018, 8, 6, 13, 31, 36, 481, DateTimeKind.Local), 5, null, "Veniam omnis sed odit eos possimus natus asperiores nesciunt.", "9dac3529-7462-48ab-99ea-df3e17506402" },
                    { 117, new DateTime(2018, 8, 6, 16, 24, 11, 249, DateTimeKind.Local), 8, null, "Sint qui quia officiis qui quo molestiae saepe.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 113, new DateTime(2018, 8, 6, 21, 8, 55, 355, DateTimeKind.Local), 6, null, "Aut odio molestias accusantium quasi illo eaque id et.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", 77 },
                    { "9dac3529-7462-48ab-99ea-df3e17506402", 77 },
                    { "8bd9ceb7-2599-4270-8cb1-4133bf305731", 77 },
                    { "c716da2b-a608-4e2d-b525-a164e2f0aa12", 75 },
                    { "65397671-3a9c-437c-97b0-4ea3309c82e8", 75 },
                    { "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", 71 },
                    { "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", 76 },
                    { "e5f54f66-0cb0-46b9-857f-9aca56305c3d", 72 },
                    { "54179531-bb49-4e4f-9c03-48fe4d5c430a", 78 },
                    { "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", 78 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 98, new DateTime(2018, 8, 7, 4, 10, 3, 481, DateTimeKind.Local), 83, "Title100" },
                    { 94, new DateTime(2018, 8, 7, 0, 57, 36, 913, DateTimeKind.Local), 86, "Title444" },
                    { 91, new DateTime(2018, 8, 6, 19, 36, 39, 124, DateTimeKind.Local), 86, "Title689" },
                    { 93, new DateTime(2018, 8, 6, 20, 32, 38, 868, DateTimeKind.Local), 89, "Title69" },
                    { 100, new DateTime(2018, 8, 7, 0, 33, 38, 200, DateTimeKind.Local), 88, "Title663" },
                    { 92, new DateTime(2018, 8, 6, 13, 25, 42, 122, DateTimeKind.Local), 88, "Title87" },
                    { 99, new DateTime(2018, 8, 7, 6, 40, 9, 381, DateTimeKind.Local), 82, "Title247" },
                    { 97, new DateTime(2018, 8, 7, 10, 49, 8, 579, DateTimeKind.Local), 90, "Title523" },
                    { 96, new DateTime(2018, 8, 6, 22, 58, 49, 65, DateTimeKind.Local), 90, "Title648" },
                    { 95, new DateTime(2018, 8, 6, 16, 10, 43, 612, DateTimeKind.Local), 83, "Title642" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 35, 24, new DateTime(2018, 8, 7, 4, 41, 8, 677, DateTimeKind.Local), "Ullam saepe eum voluptate animi ut ut saepe.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", true },
                    { 31, 24, new DateTime(2018, 8, 6, 13, 49, 41, 569, DateTimeKind.Local), "Quasi quis qui quisquam odio id.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", true },
                    { 33, 25, new DateTime(2018, 8, 6, 21, 5, 35, 880, DateTimeKind.Local), "Nihil nostrum quo et consequuntur corrupti quisquam.", "9dac3529-7462-48ab-99ea-df3e17506402", true },
                    { 38, 28, new DateTime(2018, 8, 7, 13, 7, 6, 608, DateTimeKind.Local), "Pariatur aperiam quo doloribus nisi vitae nulla.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", true },
                    { 37, 29, new DateTime(2018, 8, 7, 11, 26, 51, 125, DateTimeKind.Local), "Error unde voluptatem dolorum voluptas beatae consequatur et explicabo.", "9dac3529-7462-48ab-99ea-df3e17506402", false },
                    { 32, 29, new DateTime(2018, 8, 7, 9, 40, 43, 473, DateTimeKind.Local), "Qui at numquam.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", false },
                    { 36, 27, new DateTime(2018, 8, 6, 21, 13, 22, 350, DateTimeKind.Local), "Quisquam nemo ducimus provident.", "9dac3529-7462-48ab-99ea-df3e17506402", false },
                    { 39, 23, new DateTime(2018, 8, 7, 6, 37, 11, 73, DateTimeKind.Local), "Non est voluptas qui eum commodi et totam.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", true },
                    { 40, 25, new DateTime(2018, 8, 7, 8, 46, 41, 851, DateTimeKind.Local), "Saepe non maxime voluptatem.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", false },
                    { 34, 25, new DateTime(2018, 8, 6, 22, 33, 0, 613, DateTimeKind.Local), "Ipsam aut voluptatem et ipsam alias velit laudantium occaecati inventore.", "54179531-bb49-4e4f-9c03-48fe4d5c430a", false }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 54, new DateTime(2018, 8, 7, 6, 53, 3, 856, DateTimeKind.Local), 46, "Nihil aut aut consequatur ea rem ut assumenda dolorem non.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 60, new DateTime(2018, 8, 6, 22, 12, 5, 785, DateTimeKind.Local), 49, "Ut nihil impedit.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 55, new DateTime(2018, 8, 7, 6, 25, 13, 418, DateTimeKind.Local), 43, "Suscipit commodi reiciendis quis adipisci dolorem omnis aut non pariatur.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 59, new DateTime(2018, 8, 6, 13, 30, 5, 871, DateTimeKind.Local), 45, "Ut voluptatem sit neque occaecati assumenda labore et.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 57, new DateTime(2018, 8, 7, 8, 43, 6, 648, DateTimeKind.Local), 42, "Debitis architecto veritatis quaerat.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 52, new DateTime(2018, 8, 7, 8, 26, 3, 794, DateTimeKind.Local), 48, "Sapiente ut perspiciatis animi accusantium ea.", "9dac3529-7462-48ab-99ea-df3e17506402" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 109, 96, "MostLoaded1", "Common2", "Source3", 86, 0 },
                    { 102, 99, "MostLoaded1", "Common3", "Source1", 12, 1 },
                    { 103, 99, "MostLoaded2", "Common1", "Source2", 78, 2 },
                    { 101, 92, "MostLoaded1", "Common2", "Source1", 3, 1 },
                    { 108, 92, "MostLoaded2", "Common3", "Source3", 54, 1 },
                    { 106, 93, "MostLoaded1", "Common2", "Source3", 12, 2 },
                    { 104, 91, "MostLoaded1", "Common3", "Source3", 0, 1 },
                    { 110, 91, "MostLoaded3", "Common1", "Source2", 15, 2 },
                    { 107, 94, "MostLoaded2", "Common2", "Source3", 35, 0 },
                    { 105, 95, "MostLoaded2", "Common2", "Source1", 22, 1 }
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
                name: "IX_Users_NotificationSettingId",
                table: "Users",
                column: "NotificationSettingId");

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
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "NotificationSettings");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
