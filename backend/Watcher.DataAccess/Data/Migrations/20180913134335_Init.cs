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
                    { 2, "#F8FAFC", "14px", "33px", false, "Darkness", "#f58400", "#ffffff" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "94f74064-0b77-4551-b2f4-c7cfbd48e7b3", null, new DateTime(2018, 9, 13, 11, 40, 45, 127, DateTimeKind.Local), "Ellsworth", "Keshaun.Parker61@yahoo.com", null, "London", true, false, "Smith", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kylefoundry/128.jpg", 1 },
                    { "f2818533-e97e-4bae-be99-8be3d29ff037", null, new DateTime(2018, 9, 13, 2, 52, 28, 733, DateTimeKind.Local), "Valerie", "Maureen_Reinger@hotmail.com", null, "Alexzander", true, false, "Goyette", null, "https://s3.amazonaws.com/uifaces/faces/twitter/maxlinderman/128.jpg", 1 },
                    { "c69b3332-96a0-47d7-bca7-a4fde7277d7b", null, new DateTime(2018, 9, 13, 12, 43, 2, 866, DateTimeKind.Local), "Kara", "Susan_Hahn@yahoo.com", null, "Teagan", true, false, "Weimann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/diansigitp/128.jpg", 1 },
                    { "cbb4252f-aba5-44d6-8cf3-073ee809daca", null, new DateTime(2018, 9, 13, 10, 58, 16, 205, DateTimeKind.Local), "Laurence", "Pasquale.Schoen@gmail.com", null, "Kurt", true, false, "Hagenes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dicesales/128.jpg", 1 },
                    { "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", null, new DateTime(2018, 9, 13, 12, 55, 11, 92, DateTimeKind.Local), "Paige", "Antonina.Tromp88@gmail.com", null, "Ervin", true, false, "Muller", null, "https://s3.amazonaws.com/uifaces/faces/twitter/erwanhesry/128.jpg", 1 },
                    { "65d73488-1b38-456d-8fff-737be639e584", null, new DateTime(2018, 9, 13, 7, 28, 18, 199, DateTimeKind.Local), "Lizzie", "Brown_Hoppe@hotmail.com", null, "Lucienne", true, false, "Wuckert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/chadengle/128.jpg", 1 },
                    { "e697fc03-e37a-48e7-84c0-d3087cd1c915", null, new DateTime(2018, 9, 13, 2, 28, 54, 955, DateTimeKind.Local), "Abdul", "Era86@hotmail.com", null, "Dianna", true, false, "Huels", null, "https://s3.amazonaws.com/uifaces/faces/twitter/brenton_clarke/128.jpg", 1 },
                    { "0673fee2-18bc-4d1f-9a8a-cafda74912e9", null, new DateTime(2018, 9, 13, 16, 42, 51, 572, DateTimeKind.Local), "Aletha", "Madge16@yahoo.com", null, "Van", true, false, "Hane", null, "https://s3.amazonaws.com/uifaces/faces/twitter/xravil/128.jpg", 2 },
                    { "09aef456-5b88-4e19-89e6-ae20af967911", null, new DateTime(2018, 9, 13, 11, 56, 54, 658, DateTimeKind.Local), "Leatha", "Aletha.Trantow34@gmail.com", null, "Michale", true, false, "Howell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/chris_frees/128.jpg", 2 },
                    { "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", null, new DateTime(2018, 9, 12, 19, 10, 24, 943, DateTimeKind.Local), "Shawn", "Nasir17@yahoo.com", null, "Darby", true, false, "Beer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cybind/128.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 30, "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", false, "in", null, 0 },
                    { 26, "e697fc03-e37a-48e7-84c0-d3087cd1c915", false, "ad", null, 0 },
                    { 23, "c69b3332-96a0-47d7-bca7-a4fde7277d7b", false, "aut", null, 0 },
                    { 28, "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", false, "sed", null, 0 },
                    { 29, "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", false, "repellat", null, 0 },
                    { 27, "f2818533-e97e-4bae-be99-8be3d29ff037", false, "sunt", null, 0 },
                    { 25, "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", false, "occaecati", null, 0 },
                    { 22, "f2818533-e97e-4bae-be99-8be3d29ff037", false, "molestiae", null, 0 },
                    { 24, "f2818533-e97e-4bae-be99-8be3d29ff037", false, "non", null, 0 },
                    { 21, "65d73488-1b38-456d-8fff-737be639e584", false, "distinctio", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "Email", "Friendliness", "Informatively", "IsDeleted", "Name", "Quickness", "ResponseId", "Text", "UserId", "WillUse" },
                values: new object[,]
                {
                    { 48, new DateTime(2018, 9, 13, 10, 9, 25, 35, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Non ipsa sequi velit.", "f2818533-e97e-4bae-be99-8be3d29ff037", 0 },
                    { 41, new DateTime(2018, 9, 12, 21, 11, 27, 869, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Non qui enim itaque qui cumque tenetur excepturi.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", 0 },
                    { 42, new DateTime(2018, 9, 13, 13, 51, 27, 41, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Consequatur quidem quia.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", 0 },
                    { 45, new DateTime(2018, 9, 12, 23, 34, 46, 608, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Autem iste earum beatae qui consequatur incidunt deserunt.", "cbb4252f-aba5-44d6-8cf3-073ee809daca", 0 },
                    { 46, new DateTime(2018, 9, 12, 23, 28, 8, 854, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Qui nemo necessitatibus sunt sapiente quis sed quas.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", 0 },
                    { 44, new DateTime(2018, 9, 12, 22, 37, 24, 629, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Consequatur voluptate perspiciatis.", "c69b3332-96a0-47d7-bca7-a4fde7277d7b", 0 },
                    { 50, new DateTime(2018, 9, 12, 17, 38, 25, 186, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Facilis iste dolores ut doloremque quae sed nihil magnam sint.", "0673fee2-18bc-4d1f-9a8a-cafda74912e9", 0 },
                    { 49, new DateTime(2018, 9, 13, 3, 10, 6, 73, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Corrupti veritatis iste consequatur facere et.", "0673fee2-18bc-4d1f-9a8a-cafda74912e9", 0 },
                    { 47, new DateTime(2018, 9, 13, 14, 40, 41, 501, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Non quia consequatur.", "0673fee2-18bc-4d1f-9a8a-cafda74912e9", 0 },
                    { 43, new DateTime(2018, 9, 13, 6, 7, 20, 25, DateTimeKind.Local), null, 0, 0, false, null, 0, null, "Illo voluptate exercitationem optio.", "cbb4252f-aba5-44d6-8cf3-073ee809daca", 0 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "ChatId", "IsDeleted", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 16, null, false, false, true, true, 4, "09aef456-5b88-4e19-89e6-ae20af967911" },
                    { 15, null, false, true, false, false, 2, "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9" },
                    { 20, null, false, true, false, false, 1, "65d73488-1b38-456d-8fff-737be639e584" },
                    { 11, null, false, true, false, false, 1, "94f74064-0b77-4551-b2f4-c7cfbd48e7b3" },
                    { 13, null, false, true, true, true, 2, "f2818533-e97e-4bae-be99-8be3d29ff037" },
                    { 14, null, false, true, false, false, 2, "c69b3332-96a0-47d7-bca7-a4fde7277d7b" },
                    { 19, null, false, false, true, true, 4, "c69b3332-96a0-47d7-bca7-a4fde7277d7b" },
                    { 12, null, false, true, false, false, 0, "94f74064-0b77-4551-b2f4-c7cfbd48e7b3" },
                    { 17, null, false, false, true, false, 3, "cbb4252f-aba5-44d6-8cf3-073ee809daca" },
                    { 18, null, false, false, true, false, 1, "f2818533-e97e-4bae-be99-8be3d29ff037" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 66, "(337) 675-8317 x628", "cbb4252f-aba5-44d6-8cf3-073ee809daca", "Dolorem illum debitis. Exercitationem aut est molestias voluptatem illo et magni iusto iste. Et illo quas minus dicta nobis fugit asperiores magni. Adipisci rerum qui.", "Wilton.Dietrich68@hotmail.com", null, true, false, "Company158", 1, "https://krystal.name" },
                    { 69, "(696) 900-6739", "c69b3332-96a0-47d7-bca7-a4fde7277d7b", "Architecto impedit laudantium repudiandae.", "Hope_Runolfsson@gmail.com", null, true, false, "Company414", 1, "https://ludie.info" },
                    { 68, "1-859-704-2256 x0237", "e697fc03-e37a-48e7-84c0-d3087cd1c915", "Vel et et debitis aut laudantium nihil rerum ipsa explicabo. Velit consectetur itaque a minus corporis ab ut. Consectetur aliquid id magni unde eos aliquam et.", "Sadie58@hotmail.com", null, true, false, "Company53", 2, "http://elyse.info" },
                    { 62, "281-770-3987 x0300", "c69b3332-96a0-47d7-bca7-a4fde7277d7b", "Totam sint consequatur harum cumque minima sunt.", "Clement.Bruen49@yahoo.com", null, true, false, "Company351", 1, "http://shanelle.net" },
                    { 64, "263-784-4409 x94920", "94f74064-0b77-4551-b2f4-c7cfbd48e7b3", "Qui enim ducimus sit non velit enim amet sit quisquam. Fugiat aperiam doloremque nobis laboriosam enim ea.", "Seamus_Davis15@gmail.com", null, true, false, "Company890", 1, "https://paula.com" },
                    { 67, "273-747-3857", "65d73488-1b38-456d-8fff-737be639e584", "", "Neil_Abbott60@gmail.com", null, true, false, "Company628", 1, "http://joy.name" },
                    { 63, "640.536.8640", "94f74064-0b77-4551-b2f4-c7cfbd48e7b3", "", "Eliseo.Grimes@yahoo.com", null, true, false, "Company634", 1, "https://karl.name" },
                    { 61, "1-269-754-3661 x11161", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", "Inventore neque qui. Sit et est voluptas eum. Aut quod temporibus iusto dicta. Ipsum harum et voluptate et eos sequi omnis.", "Gabe.Schmeler58@yahoo.com", null, true, false, "Company535", 2, "http://allen.biz" },
                    { 65, "1-917-456-6123 x24786", "e697fc03-e37a-48e7-84c0-d3087cd1c915", "", "Mitchel_Miller@yahoo.com", null, true, false, "Company211", 1, "http://manuel.org" },
                    { 70, "(814) 554-7458 x69651", "f2818533-e97e-4bae-be99-8be3d29ff037", "Est nemo quos qui. Ea ipsum quos est. Veniam vitae aut quaerat laudantium neque. Quia debitis aperiam fuga magni ipsa.", "Vicenta_Kub89@hotmail.com", null, true, false, "Company240", 2, "https://cathy.name" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "IsDeleted", "Text", "UserId" },
                values: new object[,]
                {
                    { 52, new DateTime(2018, 9, 13, 13, 25, 43, 959, DateTimeKind.Local), 50, false, "Id eveniet minus enim facere eius.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9" },
                    { 53, new DateTime(2018, 9, 12, 17, 58, 42, 446, DateTimeKind.Local), 42, false, "Qui hic omnis neque rerum molestiae qui.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9" },
                    { 56, new DateTime(2018, 9, 13, 3, 16, 40, 384, DateTimeKind.Local), 42, false, "Distinctio ipsum dolorum commodi corporis debitis omnis maxime.", "09aef456-5b88-4e19-89e6-ae20af967911" },
                    { 55, new DateTime(2018, 9, 13, 4, 45, 47, 625, DateTimeKind.Local), 49, false, "Libero tempore consectetur est voluptatibus quae nihil ratione iure fugit.", "c69b3332-96a0-47d7-bca7-a4fde7277d7b" },
                    { 51, new DateTime(2018, 9, 13, 5, 51, 35, 385, DateTimeKind.Local), 42, false, "Id quasi enim et ipsa distinctio tempore nostrum.", "65d73488-1b38-456d-8fff-737be639e584" },
                    { 60, new DateTime(2018, 9, 13, 13, 19, 16, 149, DateTimeKind.Local), 45, false, "Dolorum soluta in.", "c69b3332-96a0-47d7-bca7-a4fde7277d7b" },
                    { 59, new DateTime(2018, 9, 13, 13, 59, 58, 711, DateTimeKind.Local), 46, false, "Vel culpa consequuntur et.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e" },
                    { 54, new DateTime(2018, 9, 13, 4, 47, 59, 137, DateTimeKind.Local), 45, false, "Eos voluptas atque.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e" },
                    { 58, new DateTime(2018, 9, 13, 11, 57, 19, 488, DateTimeKind.Local), 49, false, "Id id sed et ducimus praesentium commodi iusto.", "f2818533-e97e-4bae-be99-8be3d29ff037" },
                    { 57, new DateTime(2018, 9, 13, 7, 47, 28, 444, DateTimeKind.Local), 50, false, "Molestiae maxime sunt dolore vel et omnis ut aperiam nostrum.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "AggregationForWeek", "CpuMaxPercent", "DiskMaxPercent", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "RamMaxPercent", "StatusCheckedAt", "Title" },
                values: new object[,]
                {
                    { 76, "a6:82:5a:d1:6d:0e", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 62, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance200" },
                    { 74, "b8:6f:00:95:a8:58", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 66, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance261" },
                    { 71, "d5:4e:e3:8d:ad:a8", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance399" },
                    { 80, "37:0f:6e:a1:67:ca", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance156" },
                    { 72, "88:01:fd:f5:ed:f8", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance58" },
                    { 78, "68:c1:f2:fa:5a:8f", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 67, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance300" },
                    { 75, "3a:99:1a:36:ac:df", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance403" },
                    { 77, "0c:6f:99:b4:8b:18", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance301" },
                    { 79, "dc:f2:65:30:b4:35", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance714" },
                    { 73, "28:c6:2c:63:40:e7", true, true, true, false, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 67, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance431" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsDeleted", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 38, 27, new DateTime(2018, 9, 13, 7, 40, 8, 109, DateTimeKind.Local), false, "Ut aliquid natus dicta aliquam ut sit.", "09aef456-5b88-4e19-89e6-ae20af967911", false },
                    { 37, 27, new DateTime(2018, 9, 13, 10, 7, 51, 228, DateTimeKind.Local), false, "Dolor similique sit velit suscipit et itaque qui quam magni.", "c69b3332-96a0-47d7-bca7-a4fde7277d7b", true },
                    { 40, 24, new DateTime(2018, 9, 13, 14, 21, 52, 931, DateTimeKind.Local), false, "Sed expedita dolores delectus et voluptas fuga qui.", "09aef456-5b88-4e19-89e6-ae20af967911", false },
                    { 39, 22, new DateTime(2018, 9, 13, 12, 46, 6, 158, DateTimeKind.Local), false, "Saepe ducimus repellendus molestiae explicabo perspiciatis.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", false },
                    { 33, 22, new DateTime(2018, 9, 13, 13, 48, 6, 762, DateTimeKind.Local), false, "Ea aperiam est corporis voluptatem qui quia.", "c69b3332-96a0-47d7-bca7-a4fde7277d7b", true },
                    { 31, 22, new DateTime(2018, 9, 12, 17, 38, 1, 192, DateTimeKind.Local), false, "Praesentium vero itaque quibusdam quisquam id.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", false },
                    { 35, 25, new DateTime(2018, 9, 13, 14, 58, 6, 592, DateTimeKind.Local), false, "Perferendis voluptates odit iusto rerum quo recusandae pariatur blanditiis.", "0673fee2-18bc-4d1f-9a8a-cafda74912e9", false },
                    { 34, 28, new DateTime(2018, 9, 12, 21, 43, 45, 356, DateTimeKind.Local), false, "Sed sit maiores voluptas iure tempore voluptas numquam velit.", "65d73488-1b38-456d-8fff-737be639e584", true },
                    { 32, 29, new DateTime(2018, 9, 13, 5, 50, 15, 946, DateTimeKind.Local), false, "Nesciunt labore quaerat odit et necessitatibus.", "09aef456-5b88-4e19-89e6-ae20af967911", true },
                    { 36, 29, new DateTime(2018, 9, 13, 14, 36, 4, 868, DateTimeKind.Local), false, "Quo est perspiciatis voluptatem necessitatibus ea.", "09aef456-5b88-4e19-89e6-ae20af967911", true }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "InstanceGuidId", "InstanceId", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 106, new DateTime(2018, 9, 13, 7, 6, 6, 306, DateTimeKind.Local), null, null, false, 17, "Minima expedita enim corporis quas.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", false },
                    { 107, new DateTime(2018, 9, 13, 12, 23, 38, 343, DateTimeKind.Local), null, null, false, 11, "Et possimus autem quisquam facilis vero magnam iste sed dolor.", "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", false },
                    { 103, new DateTime(2018, 9, 13, 12, 16, 23, 131, DateTimeKind.Local), null, null, false, 13, "Optio non est ut hic et.", "e697fc03-e37a-48e7-84c0-d3087cd1c915", false },
                    { 108, new DateTime(2018, 9, 12, 22, 5, 3, 366, DateTimeKind.Local), null, null, false, 11, "Consequatur officiis distinctio ducimus consequatur.", "65d73488-1b38-456d-8fff-737be639e584", false },
                    { 102, new DateTime(2018, 9, 13, 14, 40, 35, 487, DateTimeKind.Local), null, null, false, 18, "Non quia et ea voluptates vel reiciendis aut ipsum harum.", "94f74064-0b77-4551-b2f4-c7cfbd48e7b3", false },
                    { 104, new DateTime(2018, 9, 12, 20, 11, 16, 592, DateTimeKind.Local), null, null, false, 18, "Est provident sunt sit et sint beatae ut.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", false },
                    { 109, new DateTime(2018, 9, 13, 2, 38, 45, 112, DateTimeKind.Local), null, null, false, 18, "Ab assumenda illo.", "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", false },
                    { 105, new DateTime(2018, 9, 12, 23, 5, 32, 248, DateTimeKind.Local), null, null, false, 15, "Earum veniam reprehenderit nostrum voluptatibus vel voluptatem iusto.", "09aef456-5b88-4e19-89e6-ae20af967911", false },
                    { 101, new DateTime(2018, 9, 13, 3, 2, 14, 427, DateTimeKind.Local), null, null, false, 19, "Deleniti quia quasi qui mollitia ut vel aut accusamus a.", "cbb4252f-aba5-44d6-8cf3-073ee809daca", false },
                    { 110, new DateTime(2018, 9, 13, 16, 18, 1, 561, DateTimeKind.Local), null, null, false, 14, "Blanditiis officiis magni quisquam dignissimos cupiditate.", "09aef456-5b88-4e19-89e6-ae20af967911", false }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "2ed2cc2b-f1ff-4247-92e5-dd40fd88cd2e", 66, 1 },
                    { "0673fee2-18bc-4d1f-9a8a-cafda74912e9", 66, 1 },
                    { "e697fc03-e37a-48e7-84c0-d3087cd1c915", 69, 1 },
                    { "65d73488-1b38-456d-8fff-737be639e584", 64, 1 },
                    { "cbb4252f-aba5-44d6-8cf3-073ee809daca", 64, 1 },
                    { "94f74064-0b77-4551-b2f4-c7cfbd48e7b3", 65, 1 },
                    { "c69b3332-96a0-47d7-bca7-a4fde7277d7b", 68, 1 },
                    { "397c0e5c-ca8b-4ad3-b25c-2f13b1bf49b9", 63, 1 },
                    { "09aef456-5b88-4e19-89e6-ae20af967911", 63, 1 },
                    { "f2818533-e97e-4bae-be99-8be3d29ff037", 69, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 88, new DateTime(2018, 9, 13, 9, 5, 46, 733, DateTimeKind.Local), 76, false, "Title347" },
                    { 90, new DateTime(2018, 9, 13, 11, 22, 56, 703, DateTimeKind.Local), 76, false, "Title136" },
                    { 87, new DateTime(2018, 9, 12, 23, 58, 59, 90, DateTimeKind.Local), 74, false, "Title819" },
                    { 85, new DateTime(2018, 9, 13, 14, 16, 21, 782, DateTimeKind.Local), 71, false, "Title925" },
                    { 86, new DateTime(2018, 9, 13, 8, 41, 55, 580, DateTimeKind.Local), 71, false, "Title412" },
                    { 83, new DateTime(2018, 9, 13, 7, 44, 43, 558, DateTimeKind.Local), 75, false, "Title892" },
                    { 82, new DateTime(2018, 9, 13, 1, 54, 9, 261, DateTimeKind.Local), 77, false, "Title639" },
                    { 81, new DateTime(2018, 9, 13, 2, 51, 20, 342, DateTimeKind.Local), 79, false, "Title400" },
                    { 89, new DateTime(2018, 9, 13, 10, 13, 40, 631, DateTimeKind.Local), 73, false, "Title562" },
                    { 84, new DateTime(2018, 9, 13, 12, 39, 49, 469, DateTimeKind.Local), 78, false, "Title868" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "HistoryTime", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 92, true, 88, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 71, "", 1, "X Label", "Y Label" },
                    { 94, true, 88, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 30, "", 2, "X Label", "Y Label" },
                    { 100, true, 87, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 19, "", 1, "X Label", "Y Label" },
                    { 91, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 78, "", 3, "X Label", "Y Label" },
                    { 95, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 33, "", 0, "X Label", "Y Label" },
                    { 99, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 69, "", 1, "X Label", "Y Label" },
                    { 93, true, 83, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 4, "", 2, "X Label", "Y Label" },
                    { 96, true, 83, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 67, "", 1, "X Label", "Y Label" },
                    { 97, true, 89, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 24, "", 3, "X Label", "Y Label" },
                    { 98, true, 89, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 11, "", 2, "X Label", "Y Label" }
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
