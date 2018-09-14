using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollectorAppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    ExeLink = table.Column<string>(nullable: true),
                    DebLink = table.Column<string>(nullable: true),
                    TgzLink = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectorAppVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                    SampleField = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
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
                    BodyColor = table.Column<string>(nullable: false),
                    ThemePrimaryColor = table.Column<string>(nullable: false),
                    ThemeSecondaryColor = table.Column<string>(nullable: false),
                    ControlsHeight = table.Column<string>(nullable: false),
                    ButtonFontSize = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
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
                    ChatId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
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
                    UserId = table.Column<string>(nullable: true),
                    ChatId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserChat",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ChatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChat", x => new { x.UserId, x.ChatId });
                });

            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShowCommon = table.Column<bool>(nullable: false),
                    Threshold = table.Column<int>(nullable: false),
                    MostLoaded = table.Column<int>(nullable: false),
                    HistoryTime = table.Column<int>(nullable: false),
                    DashboardId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SchemeType = table.Column<string>(nullable: true),
                    ShowLegend = table.Column<bool>(nullable: false),
                    LegendTitle = table.Column<string>(nullable: true),
                    Gradient = table.Column<bool>(nullable: false),
                    ShowXAxis = table.Column<bool>(nullable: false),
                    ShowYAxis = table.Column<bool>(nullable: false),
                    ShowXAxisLabel = table.Column<bool>(nullable: false),
                    ShowYAxisLabel = table.Column<bool>(nullable: false),
                    YAxisLabel = table.Column<string>(nullable: true),
                    XAxisLabel = table.Column<string>(nullable: true),
                    AutoScale = table.Column<bool>(nullable: false),
                    ShowGridLines = table.Column<bool>(nullable: false),
                    RangeFillOpacity = table.Column<double>(nullable: false),
                    RoundDomains = table.Column<bool>(nullable: false),
                    IsTooltipDisabled = table.Column<bool>(nullable: false),
                    IsShowSeriesOnHover = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Sources = table.Column<string>(nullable: true),
                    IsLightTheme = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    InstanceId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    WasRead = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    InstanceId = table.Column<int>(nullable: true),
                    InstanceGuidId = table.Column<Guid>(nullable: true),
                    NotificationSettingId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                        column: x => x.NotificationSettingId,
                        principalTable: "NotificationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOrganizations",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    OrganizationRoleId = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrganizations", x => new { x.UserId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_UserOrganizations_OrganizationRoles_OrganizationRoleId",
                        column: x => x.OrganizationRoleId,
                        principalTable: "OrganizationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    OrganizationId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Platform = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    GuidId = table.Column<Guid>(nullable: false),
                    AggregationForHour = table.Column<bool>(nullable: false),
                    AggregationForDay = table.Column<bool>(nullable: false),
                    AggregationForWeek = table.Column<bool>(nullable: false),
                    AggregationForMonth = table.Column<bool>(nullable: false),
                    CpuMaxPercent = table.Column<float>(nullable: false),
                    RamMaxPercent = table.Column<float>(nullable: false),
                    DiskMaxPercent = table.Column<float>(nullable: false),
                    StatusCheckedAt = table.Column<DateTime>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationInvites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExperationDate = table.Column<DateTime>(nullable: false),
                    InviteEmail = table.Column<string>(nullable: true),
                    InvitedUserId = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationInvites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    EmailForNotifications = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PhotoURL = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    LastPickedOrganizationId = table.Column<int>(nullable: true)
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
                    ImageURL = table.Column<string>(nullable: true),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    ThemeId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                    UserId = table.Column<string>(nullable: true),
                    FeedbackId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                    WillUse = table.Column<int>(nullable: false),
                    Informatively = table.Column<int>(nullable: false),
                    Friendliness = table.Column<int>(nullable: false),
                    Quickness = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ResponseId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OrganizationRoles",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Manager" },
                    { 2, false, "Member" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Admin" },
                    { 2, false, "User" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BodyColor", "ButtonFontSize", "ControlsHeight", "IsDeleted", "Name", "ThemePrimaryColor", "ThemeSecondaryColor" },
                values: new object[,]
                {
                    { 1, "#F8FAFC", "14px", "33px", false, "Default", "#007ad9", "#ffffff" },
                    { 2, "#F8FAFC", "14px", "33px", false, "Darkness", "#f58400", "#ffffff" },
                    { 3, "#F8FAFC", "14px", "33px", false, "Lightness", "#1c94c4", "#f6a828" },
                    { 4, "#F8FAFC", "14px", "33px", false, "Voclain", "#c95864", "#ffffff" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "5eae5868-a67d-459e-9ce9-af417b9eca7e", null, new DateTime(2018, 9, 13, 23, 11, 49, 359, DateTimeKind.Local), "Zion", "Hilma.Will36@gmail.com", null, "Tianna", true, false, "Ritchie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dzantievm/128.jpg", 1 },
                    { "80b514b8-529e-49a9-a795-09cbfd52c4e1", null, new DateTime(2018, 9, 14, 1, 14, 57, 672, DateTimeKind.Local), "Savion", "Micaela_Altenwerth50@yahoo.com", null, "Sydnee", true, false, "Schaden", null, "https://s3.amazonaws.com/uifaces/faces/twitter/madebyvadim/128.jpg", 1 },
                    { "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", null, new DateTime(2018, 9, 14, 5, 42, 52, 49, DateTimeKind.Local), "Anabelle", "Emiliano_Pfeffer67@hotmail.com", null, "Duane", true, false, "Schaefer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", 2 },
                    { "9053142c-1ad7-402d-968e-5407670c8b2b", null, new DateTime(2018, 9, 13, 20, 53, 36, 991, DateTimeKind.Local), "Madisyn", "Selena.Vandervort33@gmail.com", null, "Earline", true, false, "Abbott", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Skyhartman/128.jpg", 2 },
                    { "b4e997d1-19e4-482f-823d-4171b363dcc3", null, new DateTime(2018, 9, 14, 8, 50, 58, 378, DateTimeKind.Local), "Eldon", "Mortimer.Von42@yahoo.com", null, "Dallin", true, false, "Bosco", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ilya_pestov/128.jpg", 2 },
                    { "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef", null, new DateTime(2018, 9, 13, 21, 47, 52, 139, DateTimeKind.Local), "Bradford", "Montana_Yost@yahoo.com", null, "Winston", true, false, "Schoen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/fronx/128.jpg", 2 },
                    { "8f08ab90-0943-4926-8252-1b13121c2498", null, new DateTime(2018, 9, 14, 9, 8, 36, 261, DateTimeKind.Local), "Maudie", "Obie_Abernathy92@hotmail.com", null, "Emilia", true, false, "Bartell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/flexrs/128.jpg", 2 },
                    { "017421d0-13e2-4d48-9eed-afa09fdde7d3", null, new DateTime(2018, 9, 13, 14, 5, 1, 250, DateTimeKind.Local), "Danial", "Itzel.Rosenbaum@gmail.com", null, "Eulah", true, false, "Ondricka", null, "https://s3.amazonaws.com/uifaces/faces/twitter/agromov/128.jpg", 2 },
                    { "4c4c4312-0971-4275-bb34-f71a3bace392", null, new DateTime(2018, 9, 13, 19, 50, 12, 374, DateTimeKind.Local), "Ozella", "Larry_Heidenreich@gmail.com", null, "Bria", true, false, "Bernhard", null, "https://s3.amazonaws.com/uifaces/faces/twitter/allagringaus/128.jpg", 2 },
                    { "051af418-dccf-47b5-8e85-17ca398e968b", null, new DateTime(2018, 9, 13, 19, 22, 46, 630, DateTimeKind.Local), "Alford", "Alena_Bashirian@gmail.com", null, "Werner", true, false, "Lehner", null, "https://s3.amazonaws.com/uifaces/faces/twitter/arthurholcombe1/128.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 23, "b4e997d1-19e4-482f-823d-4171b363dcc3", false, "asperiores", null, 0 },
                    { 29, "b4e997d1-19e4-482f-823d-4171b363dcc3", false, "eos", null, 0 },
                    { 27, "017421d0-13e2-4d48-9eed-afa09fdde7d3", false, "suscipit", null, 0 },
                    { 24, "80b514b8-529e-49a9-a795-09cbfd52c4e1", false, "in", null, 0 },
                    { 21, "80b514b8-529e-49a9-a795-09cbfd52c4e1", false, "autem", null, 0 },
                    { 30, "80b514b8-529e-49a9-a795-09cbfd52c4e1", false, "omnis", null, 0 },
                    { 28, "4c4c4312-0971-4275-bb34-f71a3bace392", false, "odit", null, 0 },
                    { 26, "051af418-dccf-47b5-8e85-17ca398e968b", false, "officia", null, 0 },
                    { 22, "4c4c4312-0971-4275-bb34-f71a3bace392", false, "sint", null, 0 },
                    { 25, "9053142c-1ad7-402d-968e-5407670c8b2b", false, "enim", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "Email", "Friendliness", "Informatively", "IsDeleted", "Name", "Quickness", "ResponseId", "Text", "UserId", "WillUse" },
                values: new object[,]
                {
                    { 47, new DateTime(2018, 9, 14, 3, 7, 44, 777, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Voluptatem sunt omnis architecto optio nobis dolorem quis.", "4c4c4312-0971-4275-bb34-f71a3bace392", 0 },
                    { 41, new DateTime(2018, 9, 13, 21, 34, 40, 17, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Aperiam iusto aperiam aut.", "9053142c-1ad7-402d-968e-5407670c8b2b", 0 },
                    { 50, new DateTime(2018, 9, 14, 9, 54, 0, 184, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Officia sint consectetur odio doloremque maiores sit.", "017421d0-13e2-4d48-9eed-afa09fdde7d3", 0 },
                    { 49, new DateTime(2018, 9, 14, 8, 42, 9, 298, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Repellendus dolorem est nesciunt et sint consequatur voluptatum totam.", "8f08ab90-0943-4926-8252-1b13121c2498", 0 },
                    { 42, new DateTime(2018, 9, 14, 3, 56, 4, 473, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Earum aut at consequatur dolorem rerum non.", "8f08ab90-0943-4926-8252-1b13121c2498", 0 },
                    { 45, new DateTime(2018, 9, 13, 19, 10, 33, 274, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Doloribus rerum quia velit ad.", "051af418-dccf-47b5-8e85-17ca398e968b", 0 },
                    { 48, new DateTime(2018, 9, 13, 23, 25, 54, 178, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Ut quae quo repellat sed sed molestiae in ut ea.", "9053142c-1ad7-402d-968e-5407670c8b2b", 0 },
                    { 44, new DateTime(2018, 9, 13, 19, 45, 26, 164, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Et consequatur veritatis rem consequatur.", "5eae5868-a67d-459e-9ce9-af417b9eca7e", 0 },
                    { 46, new DateTime(2018, 9, 13, 21, 25, 39, 418, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Dolor sunt distinctio dolor quis maiores alias.", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", 0 },
                    { 43, new DateTime(2018, 9, 14, 3, 5, 16, 964, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Harum dolor quasi molestiae sapiente id.", "80b514b8-529e-49a9-a795-09cbfd52c4e1", 0 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "ChatId", "IsDeleted", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 16, null, false, true, false, false, 4, "80b514b8-529e-49a9-a795-09cbfd52c4e1" },
                    { 18, null, false, true, true, true, 1, "5eae5868-a67d-459e-9ce9-af417b9eca7e" },
                    { 13, null, false, false, false, false, 1, "9053142c-1ad7-402d-968e-5407670c8b2b" },
                    { 11, null, false, false, false, false, 1, "4c4c4312-0971-4275-bb34-f71a3bace392" },
                    { 15, null, false, true, true, true, 2, "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd" },
                    { 17, null, false, true, false, true, 2, "b4e997d1-19e4-482f-823d-4171b363dcc3" },
                    { 12, null, false, true, true, true, 1, "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef" },
                    { 20, null, false, true, true, false, 1, "017421d0-13e2-4d48-9eed-afa09fdde7d3" },
                    { 14, null, false, false, false, true, 3, "8f08ab90-0943-4926-8252-1b13121c2498" },
                    { 19, null, false, false, true, true, 4, "017421d0-13e2-4d48-9eed-afa09fdde7d3" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 64, "(273) 595-7182", "5eae5868-a67d-459e-9ce9-af417b9eca7e", "", "Carlie_Dickens@yahoo.com", null, true, false, "Company976", 2, "https://jared.biz" },
                    { 65, "712.349.8764 x03704", "5eae5868-a67d-459e-9ce9-af417b9eca7e", "", "Abigale_Blanda@gmail.com", null, true, false, "Company622", 1, "http://pinkie.biz" },
                    { 63, "591-382-4976", "017421d0-13e2-4d48-9eed-afa09fdde7d3", "Maxime aspernatur aut iusto odio in est necessitatibus dolor.", "Milton.Fadel@gmail.com", null, true, false, "Company406", 1, "http://cielo.name" },
                    { 62, "1-567-658-1376 x1819", "017421d0-13e2-4d48-9eed-afa09fdde7d3", "Quod voluptatem laborum et magni earum sed esse odit nisi. Itaque eum qui et debitis. Magni amet voluptatem distinctio aut sint. Optio optio quas quisquam consequatur eius dolorem.", "Joshuah79@gmail.com", null, true, false, "Company975", 4, "http://estefania.net" },
                    { 69, "(235) 417-8355", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", "Consequatur natus placeat est aut ut at.", "Laurine.Bailey21@gmail.com", null, true, false, "Company41", 2, "https://tomas.net" },
                    { 66, "(523) 377-7347 x94359", "051af418-dccf-47b5-8e85-17ca398e968b", "Et repudiandae deserunt. Laborum eaque repellat ea nesciunt quis.", "Evan_Gaylord@hotmail.com", null, true, false, "Company802", 3, "http://nakia.net" },
                    { 61, "385-382-6038", "9053142c-1ad7-402d-968e-5407670c8b2b", "", "Giovanni_Fahey@yahoo.com", null, true, false, "Company177", 2, "https://mertie.info" },
                    { 67, "772.783.4739", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", "Eum consequuntur ea nulla non modi et in et accusamus. Et quo eligendi voluptatem laudantium autem quod soluta aspernatur. Sed officiis repellendus eveniet assumenda sed.", "Broderick20@gmail.com", null, true, false, "Company529", 3, "https://ada.org" },
                    { 68, "298-598-5110 x4535", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", "Magnam et hic odio aut. Necessitatibus recusandae quis quia eaque cum quis magnam aut.", "Santiago.Bashirian@yahoo.com", null, true, false, "Company498", 3, "http://ethan.org" },
                    { 70, "1-328-871-1406 x15755", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", "Ipsam sit doloremque. Facilis impedit consectetur.", "Jakayla75@yahoo.com", null, true, false, "Company822", 3, "https://dannie.biz" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "IsDeleted", "Text", "UserId" },
                values: new object[,]
                {
                    { 55, new DateTime(2018, 9, 13, 21, 50, 23, 542, DateTimeKind.Local), 48, false, "Fuga expedita dignissimos voluptatem dolorum ut dicta quis.", "8f08ab90-0943-4926-8252-1b13121c2498" },
                    { 60, new DateTime(2018, 9, 14, 3, 14, 16, 24, DateTimeKind.Local), 44, false, "Veritatis consequuntur illum autem eaque delectus deleniti voluptas amet iure.", "80b514b8-529e-49a9-a795-09cbfd52c4e1" },
                    { 52, new DateTime(2018, 9, 14, 6, 30, 7, 556, DateTimeKind.Local), 50, false, "Nostrum provident asperiores aut commodi et voluptatibus in quasi non.", "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef" },
                    { 51, new DateTime(2018, 9, 14, 3, 26, 14, 131, DateTimeKind.Local), 44, false, "Non hic repellendus fugiat ducimus sunt amet est.", "017421d0-13e2-4d48-9eed-afa09fdde7d3" },
                    { 53, new DateTime(2018, 9, 14, 8, 2, 15, 818, DateTimeKind.Local), 48, false, "Labore a sed quis ipsum voluptatem quia.", "017421d0-13e2-4d48-9eed-afa09fdde7d3" },
                    { 59, new DateTime(2018, 9, 13, 11, 42, 21, 27, DateTimeKind.Local), 47, false, "Et rerum in eaque asperiores.", "5eae5868-a67d-459e-9ce9-af417b9eca7e" },
                    { 58, new DateTime(2018, 9, 13, 23, 6, 50, 37, DateTimeKind.Local), 48, false, "Voluptatem aliquid nesciunt aliquam repellat culpa.", "5eae5868-a67d-459e-9ce9-af417b9eca7e" },
                    { 56, new DateTime(2018, 9, 13, 23, 58, 51, 445, DateTimeKind.Local), 48, false, "Necessitatibus eum suscipit tempora similique sapiente.", "9053142c-1ad7-402d-968e-5407670c8b2b" },
                    { 57, new DateTime(2018, 9, 13, 12, 20, 32, 17, DateTimeKind.Local), 42, false, "Saepe quaerat harum minima.", "4c4c4312-0971-4275-bb34-f71a3bace392" },
                    { 54, new DateTime(2018, 9, 13, 16, 44, 11, 929, DateTimeKind.Local), 43, false, "Dicta totam ut nostrum optio.", "051af418-dccf-47b5-8e85-17ca398e968b" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "AggregationForWeek", "CpuMaxPercent", "DiskMaxPercent", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "RamMaxPercent", "StatusCheckedAt", "Title" },
                values: new object[,]
                {
                    { 79, "27:d9:26:85:92:08", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance278" },
                    { 80, "26:6e:ed:0c:88:68", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance185" },
                    { 73, "c3:a4:8c:e5:25:dc", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 66, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance902" },
                    { 78, "c5:9e:51:a3:ad:96", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance954" },
                    { 77, "bb:05:34:08:0e:99", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance217" },
                    { 76, "44:f3:25:50:c5:7a", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance987" },
                    { 71, "1e:86:53:5c:4a:4b", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 62, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance419" },
                    { 74, "fc:1d:c1:f4:fa:20", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 69, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance82" },
                    { 75, "6d:2d:3c:45:9e:4d", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 68, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance477" },
                    { 72, "b7:ba:5d:ef:b9:a1", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 68, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance876" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsDeleted", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 31, 22, new DateTime(2018, 9, 14, 4, 42, 35, 104, DateTimeKind.Local), false, "Fugit quis nesciunt eveniet voluptas eum quas accusantium.", "051af418-dccf-47b5-8e85-17ca398e968b", true },
                    { 37, 22, new DateTime(2018, 9, 13, 18, 8, 15, 218, DateTimeKind.Local), false, "Animi voluptate alias magni.", "80b514b8-529e-49a9-a795-09cbfd52c4e1", false },
                    { 35, 30, new DateTime(2018, 9, 14, 2, 22, 6, 367, DateTimeKind.Local), false, "Distinctio non sint error nemo voluptatibus id quia dolorum aut.", "017421d0-13e2-4d48-9eed-afa09fdde7d3", true },
                    { 34, 30, new DateTime(2018, 9, 14, 9, 24, 2, 708, DateTimeKind.Local), false, "Quaerat officia possimus dolorem incidunt corrupti architecto.", "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef", false },
                    { 40, 24, new DateTime(2018, 9, 14, 3, 35, 4, 310, DateTimeKind.Local), false, "Qui molestias amet molestiae accusantium hic quaerat sint ipsam odit.", "017421d0-13e2-4d48-9eed-afa09fdde7d3", true },
                    { 39, 24, new DateTime(2018, 9, 14, 7, 43, 57, 827, DateTimeKind.Local), false, "Unde quam quia ipsum voluptates eos maiores vel sed accusantium.", "051af418-dccf-47b5-8e85-17ca398e968b", true },
                    { 38, 22, new DateTime(2018, 9, 14, 7, 51, 53, 775, DateTimeKind.Local), false, "Aliquid voluptatibus nihil omnis harum cum id atque aut cupiditate.", "b4e997d1-19e4-482f-823d-4171b363dcc3", false },
                    { 32, 28, new DateTime(2018, 9, 13, 12, 43, 30, 791, DateTimeKind.Local), false, "Dignissimos amet dolorem eum ea nesciunt quibusdam et.", "80b514b8-529e-49a9-a795-09cbfd52c4e1", true },
                    { 33, 28, new DateTime(2018, 9, 14, 0, 15, 31, 566, DateTimeKind.Local), false, "Omnis omnis et.", "017421d0-13e2-4d48-9eed-afa09fdde7d3", true },
                    { 36, 22, new DateTime(2018, 9, 14, 0, 50, 11, 912, DateTimeKind.Local), false, "Hic repellendus quia.", "5eae5868-a67d-459e-9ce9-af417b9eca7e", false }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "InstanceGuidId", "InstanceId", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 108, new DateTime(2018, 9, 13, 14, 49, 44, 486, DateTimeKind.Local), null, null, false, 17, "Ratione nesciunt sed consequatur adipisci neque voluptatem ea provident nihil.", "5eae5868-a67d-459e-9ce9-af417b9eca7e", false },
                    { 107, new DateTime(2018, 9, 13, 13, 19, 35, 973, DateTimeKind.Local), null, null, false, 19, "Voluptatibus voluptatem minima et harum.", "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef", false },
                    { 109, new DateTime(2018, 9, 14, 2, 45, 26, 164, DateTimeKind.Local), null, null, false, 14, "Asperiores fugit autem et fugiat possimus impedit.", "4c4c4312-0971-4275-bb34-f71a3bace392", false },
                    { 104, new DateTime(2018, 9, 13, 14, 26, 53, 284, DateTimeKind.Local), null, null, false, 17, "Eius beatae at quis rerum iure illum.", "80b514b8-529e-49a9-a795-09cbfd52c4e1", false },
                    { 101, new DateTime(2018, 9, 13, 23, 40, 4, 903, DateTimeKind.Local), null, null, false, 18, "Sit repellat veritatis qui.", "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef", false },
                    { 103, new DateTime(2018, 9, 14, 1, 17, 23, 533, DateTimeKind.Local), null, null, false, 13, "Aperiam veritatis odio iusto error aut eum est aliquid eos.", "b4e997d1-19e4-482f-823d-4171b363dcc3", false },
                    { 102, new DateTime(2018, 9, 13, 16, 35, 36, 257, DateTimeKind.Local), null, null, false, 13, "Laudantium vero officiis quo omnis.", "051af418-dccf-47b5-8e85-17ca398e968b", false },
                    { 110, new DateTime(2018, 9, 13, 18, 6, 14, 565, DateTimeKind.Local), null, null, false, 15, "Quaerat qui quas quis occaecati.", "8f08ab90-0943-4926-8252-1b13121c2498", false },
                    { 106, new DateTime(2018, 9, 14, 0, 34, 8, 253, DateTimeKind.Local), null, null, false, 16, "In officia odit veniam repellendus blanditiis consectetur soluta.", "5eae5868-a67d-459e-9ce9-af417b9eca7e", false },
                    { 105, new DateTime(2018, 9, 13, 19, 57, 33, 727, DateTimeKind.Local), null, null, false, 13, "Ea repellendus voluptatem sequi.", "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", false }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "80b514b8-529e-49a9-a795-09cbfd52c4e1", 69, 1 },
                    { "b4e997d1-19e4-482f-823d-4171b363dcc3", 69, 1 },
                    { "4c4c4312-0971-4275-bb34-f71a3bace392", 62, 1 },
                    { "017421d0-13e2-4d48-9eed-afa09fdde7d3", 63, 1 },
                    { "051af418-dccf-47b5-8e85-17ca398e968b", 63, 1 },
                    { "fbd4c9e9-1ad1-4eb3-8de8-0fb11a9df1dd", 67, 1 },
                    { "1e2d61b9-7e5b-40f5-9866-7fd24a3cfaef", 65, 1 },
                    { "9053142c-1ad7-402d-968e-5407670c8b2b", 64, 1 },
                    { "5eae5868-a67d-459e-9ce9-af417b9eca7e", 64, 1 },
                    { "8f08ab90-0943-4926-8252-1b13121c2498", 66, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 82, new DateTime(2018, 9, 14, 2, 6, 49, 275, DateTimeKind.Local), 78, false, "Title300" },
                    { 84, new DateTime(2018, 9, 13, 18, 39, 23, 442, DateTimeKind.Local), 72, false, "Title182" },
                    { 88, new DateTime(2018, 9, 14, 5, 4, 23, 888, DateTimeKind.Local), 72, false, "Title339" },
                    { 87, new DateTime(2018, 9, 14, 0, 38, 0, 170, DateTimeKind.Local), 75, false, "Title530" },
                    { 81, new DateTime(2018, 9, 14, 11, 1, 56, 521, DateTimeKind.Local), 74, false, "Title202" },
                    { 83, new DateTime(2018, 9, 13, 23, 17, 20, 543, DateTimeKind.Local), 77, false, "Title650" },
                    { 86, new DateTime(2018, 9, 14, 10, 59, 26, 910, DateTimeKind.Local), 77, false, "Title681" },
                    { 85, new DateTime(2018, 9, 13, 14, 19, 13, 279, DateTimeKind.Local), 79, false, "Title375" },
                    { 89, new DateTime(2018, 9, 14, 6, 34, 25, 140, DateTimeKind.Local), 71, false, "Title270" },
                    { 90, new DateTime(2018, 9, 13, 15, 1, 4, 844, DateTimeKind.Local), 71, false, "Title260" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "HistoryTime", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 95, true, 84, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 20, "", 3, "X Label", "Y Label" },
                    { 91, true, 88, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 76, "", 3, "X Label", "Y Label" },
                    { 99, true, 88, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 42, "", 0, "X Label", "Y Label" },
                    { 98, true, 87, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 87, "", 3, "X Label", "Y Label" },
                    { 100, true, 87, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 54, "", 0, "X Label", "Y Label" },
                    { 93, true, 83, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 45, "", 2, "X Label", "Y Label" },
                    { 94, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 65, "", 1, "X Label", "Y Label" },
                    { 97, true, 85, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 37, "", 1, "X Label", "Y Label" },
                    { 92, true, 89, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 46, "", 0, "X Label", "Y Label" },
                    { 96, true, 90, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 30, "", 1, "X Label", "Y Label" }
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
                name: "IX_Feedbacks_ResponseId",
                table: "Feedbacks",
                column: "ResponseId",
                unique: true,
                filter: "[ResponseId] IS NOT NULL");

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
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_ChatId",
                table: "NotificationSettings",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_UserId",
                table: "NotificationSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_CreatedByUserId",
                table: "OrganizationInvites",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_InvitedUserId",
                table: "OrganizationInvites",
                column: "InvitedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_OrganizationId",
                table: "OrganizationInvites",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CreatedByUserId",
                table: "Organizations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_ThemeId",
                table: "Organizations",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_UserId",
                table: "Responses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserChat_ChatId",
                table: "UserChat",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationId",
                table: "UserOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LastPickedOrganizationId",
                table: "Users",
                column: "LastPickedOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSettings_Users_UserId",
                table: "NotificationSettings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSettings_Chats_ChatId",
                table: "NotificationSettings",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChat_Users_UserId",
                table: "UserChat",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserChat_Chats_ChatId",
                table: "UserChat",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Charts_Dashboards_DashboardId",
                table: "Charts",
                column: "DashboardId",
                principalTable: "Dashboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_Instances_InstanceId",
                table: "Dashboards",
                column: "InstanceId",
                principalTable: "Instances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_Users_UserId",
                table: "UserOrganizations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_Organizations_OrganizationId",
                table: "UserOrganizations",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Organizations_OrganizationId",
                table: "Chats",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instances_Organizations_OrganizationId",
                table: "Instances",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationInvites_Users_CreatedByUserId",
                table: "OrganizationInvites",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationInvites_Users_InvitedUserId",
                table: "OrganizationInvites",
                column: "InvitedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationInvites_Organizations_OrganizationId",
                table: "OrganizationInvites",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations_LastPickedOrganizationId",
                table: "Users",
                column: "LastPickedOrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_CreatedByUserId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropTable(
                name: "CollectorAppVersions");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrganizationInvites");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "UserChat");

            migrationBuilder.DropTable(
                name: "UserOrganizations");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "NotificationSettings");

            migrationBuilder.DropTable(
                name: "OrganizationRoles");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
