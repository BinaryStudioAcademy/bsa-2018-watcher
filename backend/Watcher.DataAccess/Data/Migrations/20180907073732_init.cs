using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FontFamily = table.Column<string>(nullable: true),
                    BackgroundColor = table.Column<string>(nullable: true),
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
                    MostLoaded = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 61, "White", "Trade", false, "Theme448" },
                    { 62, "White", "Trade", false, "Theme466" },
                    { 63, "Gray", "Helvetica", false, "Theme746" },
                    { 64, "Gray", "Frutiger", false, "Theme34" },
                    { 65, "Yellow", "Univers", false, "Theme439" },
                    { 66, "Gray", "Trade", false, "Theme85" },
                    { 67, "White", "Helvetica", false, "Theme410" },
                    { 68, "Yellow", "Trade", false, "Theme343" },
                    { 69, "White", "Helvetica", false, "Theme855" },
                    { 70, "Yellow", "Frutiger", false, "Theme647" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", null, new DateTime(2018, 9, 6, 11, 13, 52, 452, DateTimeKind.Local), "Willa", "Rubie18@hotmail.com", null, "Lenora", true, false, "Breitenberg", null, "https://s3.amazonaws.com/uifaces/faces/twitter/baumann_alex/128.jpg", 1 },
                    { "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", null, new DateTime(2018, 9, 6, 13, 9, 58, 343, DateTimeKind.Local), "Dorian", "Adrienne27@hotmail.com", null, "Adah", true, false, "West", null, "https://s3.amazonaws.com/uifaces/faces/twitter/aio___/128.jpg", 1 },
                    { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", null, new DateTime(2018, 9, 6, 20, 50, 34, 579, DateTimeKind.Local), "Jamar", "Elisabeth37@gmail.com", null, "Lilliana", true, false, "Glover", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_dwite_/128.jpg", 1 },
                    { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", null, new DateTime(2018, 9, 7, 4, 51, 13, 658, DateTimeKind.Local), "Juliet", "Jensen.Feil74@yahoo.com", null, "Toney", true, false, "Reilly", null, "https://s3.amazonaws.com/uifaces/faces/twitter/pcridesagain/128.jpg", 1 },
                    { "e7ab8a36-df4b-42c6-901b-43dc534d904d", null, new DateTime(2018, 9, 6, 20, 27, 8, 727, DateTimeKind.Local), "Neoma", "Maybell42@hotmail.com", null, "Casimir", true, false, "Ritchie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/angelcreative/128.jpg", 2 },
                    { "b6fd9197-d110-458b-8a57-844ee29ef7a6", null, new DateTime(2018, 9, 7, 3, 8, 25, 671, DateTimeKind.Local), "Fern", "Jan.Will@gmail.com", null, "Rae", true, false, "Bailey", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cherif_b/128.jpg", 2 },
                    { "3657f143-b028-4603-b633-0ad81dddd6ca", null, new DateTime(2018, 9, 6, 20, 56, 48, 196, DateTimeKind.Local), "Alexys", "Wilson.Block60@yahoo.com", null, "Astrid", true, false, "Bradtke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarjan/128.jpg", 2 },
                    { "39d976c4-7082-4deb-9f2b-c904814cf9dc", null, new DateTime(2018, 9, 6, 21, 6, 15, 175, DateTimeKind.Local), "Sonny", "Katlynn.Goldner@gmail.com", null, "Abdul", true, false, "Jakubowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/netonet_il/128.jpg", 2 },
                    { "5cafd127-4454-449f-a0d4-4065dd61ff70", null, new DateTime(2018, 9, 6, 22, 51, 15, 172, DateTimeKind.Local), "Adrain", "Guido_Hackett76@hotmail.com", null, "Deondre", true, false, "Feeney", null, "https://s3.amazonaws.com/uifaces/faces/twitter/enda/128.jpg", 2 },
                    { "0c567133-e477-4b69-831c-06f6706801cd", null, new DateTime(2018, 9, 6, 14, 0, 47, 912, DateTimeKind.Local), "Aleen", "Brielle.Swift@yahoo.com", null, "Gloria", true, false, "Rutherford", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sergeyalmone/128.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 25, "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", false, "aliquid", null, 0 },
                    { 23, "0c567133-e477-4b69-831c-06f6706801cd", false, "iusto", null, 0 },
                    { 30, "5cafd127-4454-449f-a0d4-4065dd61ff70", false, "sint", null, 0 },
                    { 28, "39d976c4-7082-4deb-9f2b-c904814cf9dc", false, "corporis", null, 0 },
                    { 22, "b6fd9197-d110-458b-8a57-844ee29ef7a6", false, "vel", null, 0 },
                    { 26, "0c567133-e477-4b69-831c-06f6706801cd", false, "sunt", null, 0 },
                    { 29, "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", false, "debitis", null, 0 },
                    { 21, "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", false, "voluptate", null, 0 },
                    { 27, "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", false, "veniam", null, 0 },
                    { 24, "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", false, "nihil", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "Friendliness", "Informatively", "IsDeleted", "Quickness", "ResponseId", "Text", "UserId", "WillUse" },
                values: new object[,]
                {
                    { 49, new DateTime(2018, 9, 7, 7, 50, 42, 924, DateTimeKind.Local), 0, 0, false, 0, null, "Odio hic sed et error similique voluptatem dignissimos.", "5cafd127-4454-449f-a0d4-4065dd61ff70", 0 },
                    { 48, new DateTime(2018, 9, 6, 23, 56, 7, 108, DateTimeKind.Local), 0, 0, false, 0, null, "Quia enim vel amet repudiandae inventore qui porro.", "b6fd9197-d110-458b-8a57-844ee29ef7a6", 0 },
                    { 42, new DateTime(2018, 9, 7, 5, 49, 29, 392, DateTimeKind.Local), 0, 0, false, 0, null, "Repellendus sequi et nisi.", "b6fd9197-d110-458b-8a57-844ee29ef7a6", 0 },
                    { 43, new DateTime(2018, 9, 6, 17, 25, 48, 393, DateTimeKind.Local), 0, 0, false, 0, null, "Quod quo molestias asperiores.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", 0 },
                    { 44, new DateTime(2018, 9, 6, 22, 20, 35, 91, DateTimeKind.Local), 0, 0, false, 0, null, "Occaecati consequatur pariatur qui asperiores a sint.", "e7ab8a36-df4b-42c6-901b-43dc534d904d", 0 },
                    { 45, new DateTime(2018, 9, 6, 14, 4, 43, 734, DateTimeKind.Local), 0, 0, false, 0, null, "Eos non tenetur doloremque eum omnis est minima enim tempora.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 0 },
                    { 46, new DateTime(2018, 9, 7, 8, 39, 48, 251, DateTimeKind.Local), 0, 0, false, 0, null, "Est officia et reprehenderit velit quasi aut voluptatem commodi.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 0 },
                    { 47, new DateTime(2018, 9, 7, 4, 2, 23, 23, DateTimeKind.Local), 0, 0, false, 0, null, "Nam officiis aliquam voluptas laboriosam et.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 0 },
                    { 50, new DateTime(2018, 9, 6, 20, 39, 52, 630, DateTimeKind.Local), 0, 0, false, 0, null, "Pariatur molestiae omnis neque et et hic non animi.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 0 },
                    { 41, new DateTime(2018, 9, 7, 2, 52, 49, 217, DateTimeKind.Local), 0, 0, false, 0, null, "Et occaecati qui vitae eligendi sed repellat rem quisquam impedit.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", 0 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "ChatId", "IsDeleted", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 18, null, false, true, false, true, 1, "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" },
                    { 20, null, false, true, true, false, 1, "5cafd127-4454-449f-a0d4-4065dd61ff70" },
                    { 17, null, false, true, true, true, 2, "3657f143-b028-4603-b633-0ad81dddd6ca" },
                    { 15, null, false, true, false, false, 1, "3657f143-b028-4603-b633-0ad81dddd6ca" },
                    { 14, null, false, false, true, false, 2, "3657f143-b028-4603-b633-0ad81dddd6ca" },
                    { 12, null, false, true, true, true, 1, "0c567133-e477-4b69-831c-06f6706801cd" },
                    { 13, null, false, false, true, true, 1, "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2" },
                    { 16, null, false, false, true, false, 2, "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" },
                    { 11, null, false, true, true, false, 3, "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5" },
                    { 19, null, false, true, false, false, 3, "e7ab8a36-df4b-42c6-901b-43dc534d904d" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 75, "(641) 848-9435 x8956", "e7ab8a36-df4b-42c6-901b-43dc534d904d", "Ut id ea eos atque rerum repellat qui. Voluptatum modi tempora laudantium fuga earum quod. Ea consequuntur eveniet eligendi.", "Roman.Kovacek@yahoo.com", null, true, false, "Company444", 62, "https://adrienne.biz" },
                    { 73, "921-832-8486", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "Aliquid sunt ex.", "Adrien18@hotmail.com", null, true, false, "Company437", 64, "https://elizabeth.info" },
                    { 80, "689.616.1922 x724", "3657f143-b028-4603-b633-0ad81dddd6ca", "", "Percy.Bahringer@gmail.com", null, true, false, "Company999", 65, "http://reba.com" },
                    { 71, "466.748.2471", "3657f143-b028-4603-b633-0ad81dddd6ca", "", "Jaycee26@yahoo.com", null, true, false, "Company144", 62, "http://alexandria.biz" },
                    { 78, "1-528-862-2833 x183", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "", "Oscar_Yost7@yahoo.com", null, true, false, "Company362", 69, "https://hattie.biz" },
                    { 74, "288.787.3177 x12655", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "", "Flavie_Wilkinson54@gmail.com", null, true, false, "Company363", 66, "https://rogelio.net" },
                    { 72, "1-590-534-8112", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "Dolor voluptatem qui tempora. Dolorem ab ducimus magni architecto.", "Fritz.Gulgowski@gmail.com", null, true, false, "Company229", 63, "http://haskell.info" },
                    { 79, "663.823.0660 x210", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", "Modi alias inventore molestias rem reiciendis alias eos. Qui dicta et at voluptas iure debitis perspiciatis asperiores. Facilis veritatis id voluptatibus rerum sint nemo voluptatem.", "Khalil.OHara@gmail.com", null, true, false, "Company284", 68, "http://era.name" },
                    { 76, "(460) 226-8050 x5706", "e7ab8a36-df4b-42c6-901b-43dc534d904d", "Illum ipsum sint. Quae omnis laborum culpa qui accusamus sed alias voluptas. Error accusantium velit temporibus laboriosam qui dicta.", "Faye.Ziemann@yahoo.com", null, true, false, "Company780", 62, "https://clotilde.net" },
                    { 77, "460.765.5043 x183", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "", "Lafayette77@yahoo.com", null, true, false, "Company438", 66, "https://manuel.info" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "IsDeleted", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 9, 6, 22, 47, 23, 124, DateTimeKind.Local), 43, false, "Qui culpa enim ut consequuntur exercitationem sint ut qui ea.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" },
                    { 54, new DateTime(2018, 9, 7, 8, 52, 44, 832, DateTimeKind.Local), 48, false, "Iure voluptas sint repellendus.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" },
                    { 55, new DateTime(2018, 9, 6, 21, 20, 51, 651, DateTimeKind.Local), 45, false, "Unde excepturi commodi aperiam et non in at voluptatem.", "3657f143-b028-4603-b633-0ad81dddd6ca" },
                    { 51, new DateTime(2018, 9, 7, 3, 46, 7, 715, DateTimeKind.Local), 42, false, "Dignissimos ipsam ab sed.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" },
                    { 52, new DateTime(2018, 9, 7, 1, 15, 45, 356, DateTimeKind.Local), 48, false, "Sint optio quis eaque quo tempore.", "39d976c4-7082-4deb-9f2b-c904814cf9dc" },
                    { 60, new DateTime(2018, 9, 6, 20, 46, 32, 113, DateTimeKind.Local), 48, false, "Maxime et repudiandae quibusdam dolores.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" },
                    { 56, new DateTime(2018, 9, 6, 16, 36, 51, 814, DateTimeKind.Local), 45, false, "Ipsa sit sequi nostrum.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" },
                    { 58, new DateTime(2018, 9, 7, 0, 47, 33, 557, DateTimeKind.Local), 44, false, "Ea repudiandae ullam et maiores repudiandae voluptas aliquam.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" },
                    { 57, new DateTime(2018, 9, 6, 21, 42, 30, 443, DateTimeKind.Local), 48, false, "Saepe mollitia error.", "5cafd127-4454-449f-a0d4-4065dd61ff70" },
                    { 53, new DateTime(2018, 9, 6, 23, 43, 28, 618, DateTimeKind.Local), 48, false, "Eum repudiandae autem et nihil.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "Title" },
                values: new object[,]
                {
                    { 81, "2a:a8:fa:5f:ca:50", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Windows", "Instance115" },
                    { 83, "d1:27:65:c0:8f:42", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", "Instance2" },
                    { 88, "6f:31:e5:56:8b:f1", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", "Instance875" },
                    { 82, "f8:8d:ba:da:08:0c", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 75, "Linux", "Instance829" },
                    { 90, "ad:63:6f:7d:39:2f", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Linux", "Instance658" },
                    { 89, "3f:86:55:94:53:59", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 74, "Linux", "Instance455" },
                    { 87, "70:16:29:60:72:92", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 74, "Windows", "Instance811" },
                    { 85, "45:e0:52:8f:4c:a6", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 71, "Windows", "Instance23" },
                    { 84, "ea:65:35:d3:fa:f0", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Linux", "Instance663" },
                    { 86, "20:90:03:4c:2b:03", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Windows", "Instance432" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsDeleted", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 33, 25, new DateTime(2018, 9, 7, 8, 25, 44, 192, DateTimeKind.Local), false, "Autem molestiae minima accusantium eos et dolorum ratione sed alias.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", true },
                    { 32, 26, new DateTime(2018, 9, 6, 18, 5, 43, 856, DateTimeKind.Local), false, "Est deserunt accusamus et facilis libero aut sunt.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false },
                    { 38, 28, new DateTime(2018, 9, 7, 6, 57, 23, 438, DateTimeKind.Local), false, "Natus qui qui et eaque suscipit et deserunt quis.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false },
                    { 31, 29, new DateTime(2018, 9, 6, 17, 38, 19, 636, DateTimeKind.Local), false, "Ipsam voluptatem dolores aut quo.", "5cafd127-4454-449f-a0d4-4065dd61ff70", false },
                    { 34, 24, new DateTime(2018, 9, 6, 14, 16, 43, 645, DateTimeKind.Local), false, "Quisquam hic repellat repellendus molestias.", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", true },
                    { 35, 21, new DateTime(2018, 9, 7, 9, 21, 10, 804, DateTimeKind.Local), false, "Distinctio quasi accusamus officia exercitationem dolor.", "b6fd9197-d110-458b-8a57-844ee29ef7a6", false },
                    { 40, 28, new DateTime(2018, 9, 6, 15, 44, 24, 453, DateTimeKind.Local), false, "Animi sunt quis rerum ut voluptatum.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", false },
                    { 36, 23, new DateTime(2018, 9, 6, 11, 12, 28, 707, DateTimeKind.Local), false, "Iusto delectus nulla doloremque tempora omnis est officia.", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", false },
                    { 37, 23, new DateTime(2018, 9, 6, 20, 19, 2, 899, DateTimeKind.Local), false, "Consequatur tempore est facere facere error rerum vitae.", "39d976c4-7082-4deb-9f2b-c904814cf9dc", false },
                    { 39, 23, new DateTime(2018, 9, 7, 9, 59, 38, 485, DateTimeKind.Local), false, "Labore omnis error qui esse facilis magni eius dolorum.", "3657f143-b028-4603-b633-0ad81dddd6ca", true }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 115, new DateTime(2018, 9, 6, 22, 39, 4, 791, DateTimeKind.Local), false, 17, "Saepe autem cum enim odio repellat ut.", "b6fd9197-d110-458b-8a57-844ee29ef7a6", false },
                    { 113, new DateTime(2018, 9, 6, 16, 34, 24, 52, DateTimeKind.Local), false, 20, "Est et odio.", "e7ab8a36-df4b-42c6-901b-43dc534d904d", false },
                    { 120, new DateTime(2018, 9, 7, 5, 58, 18, 829, DateTimeKind.Local), false, 15, "Soluta qui cumque voluptas ex voluptatem dolor rerum delectus.", "5cafd127-4454-449f-a0d4-4065dd61ff70", false },
                    { 111, new DateTime(2018, 9, 7, 7, 14, 28, 43, DateTimeKind.Local), false, 15, "Velit est quaerat corrupti beatae suscipit numquam quam.", "39d976c4-7082-4deb-9f2b-c904814cf9dc", false },
                    { 117, new DateTime(2018, 9, 7, 2, 0, 11, 326, DateTimeKind.Local), false, 14, "Ab quia nesciunt quaerat.", "b6fd9197-d110-458b-8a57-844ee29ef7a6", false },
                    { 116, new DateTime(2018, 9, 7, 7, 38, 58, 179, DateTimeKind.Local), false, 12, "Nulla reiciendis voluptatem aliquid magnam animi quod.", "e7ab8a36-df4b-42c6-901b-43dc534d904d", false },
                    { 114, new DateTime(2018, 9, 7, 2, 58, 15, 604, DateTimeKind.Local), false, 19, "Omnis laudantium ut.", "0c567133-e477-4b69-831c-06f6706801cd", false },
                    { 119, new DateTime(2018, 9, 7, 5, 29, 29, 445, DateTimeKind.Local), false, 16, "Aut eligendi autem eos sit voluptatibus voluptates voluptate.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false },
                    { 118, new DateTime(2018, 9, 7, 6, 14, 21, 63, DateTimeKind.Local), false, 16, "Neque similique quod cum nesciunt architecto repellat.", "5cafd127-4454-449f-a0d4-4065dd61ff70", false },
                    { 112, new DateTime(2018, 9, 6, 22, 48, 55, 235, DateTimeKind.Local), false, 16, "Omnis culpa et illo ducimus cum.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "5cafd127-4454-449f-a0d4-4065dd61ff70", 75, 1 },
                    { "3657f143-b028-4603-b633-0ad81dddd6ca", 73, 1 },
                    { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", 73, 1 },
                    { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 71, 1 },
                    { "e7ab8a36-df4b-42c6-901b-43dc534d904d", 71, 1 },
                    { "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", 73, 1 },
                    { "39d976c4-7082-4deb-9f2b-c904814cf9dc", 79, 1 },
                    { "b6fd9197-d110-458b-8a57-844ee29ef7a6", 79, 1 },
                    { "0c567133-e477-4b69-831c-06f6706801cd", 75, 1 },
                    { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", 74, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 100, new DateTime(2018, 9, 7, 7, 26, 46, 824, DateTimeKind.Local), 81, false, "Title731" },
                    { 93, new DateTime(2018, 9, 6, 18, 22, 32, 338, DateTimeKind.Local), 88, false, "Title933" },
                    { 94, new DateTime(2018, 9, 7, 0, 24, 58, 644, DateTimeKind.Local), 88, false, "Title225" },
                    { 95, new DateTime(2018, 9, 6, 12, 41, 35, 549, DateTimeKind.Local), 88, false, "Title899" },
                    { 99, new DateTime(2018, 9, 6, 13, 28, 30, 89, DateTimeKind.Local), 88, false, "Title360" },
                    { 91, new DateTime(2018, 9, 6, 17, 15, 6, 57, DateTimeKind.Local), 84, false, "Title947" },
                    { 92, new DateTime(2018, 9, 7, 2, 30, 57, 491, DateTimeKind.Local), 87, false, "Title114" },
                    { 96, new DateTime(2018, 9, 7, 8, 13, 52, 974, DateTimeKind.Local), 82, false, "Title578" },
                    { 98, new DateTime(2018, 9, 7, 0, 51, 55, 335, DateTimeKind.Local), 82, false, "Title45" },
                    { 97, new DateTime(2018, 9, 6, 12, 47, 52, 202, DateTimeKind.Local), 85, false, "Title429" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 106, true, 100, false, false, true, true, false, "Legend", "MostLoaded2", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 56, "", 1, "X Label", "Y Label" },
                    { 110, true, 100, false, false, true, true, false, "Legend", "MostLoaded3", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 20, "", 0, "X Label", "Y Label" },
                    { 101, true, 94, false, false, true, true, false, "Legend", "MostLoaded3", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 100, "", 2, "X Label", "Y Label" },
                    { 103, true, 94, false, false, true, true, false, "Legend", "MostLoaded1", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 54, "", 1, "X Label", "Y Label" },
                    { 108, true, 95, false, false, true, true, false, "Legend", "MostLoaded2", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 65, "", 1, "X Label", "Y Label" },
                    { 107, true, 92, false, false, true, true, false, "Legend", "MostLoaded1", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 3, "", 3, "X Label", "Y Label" },
                    { 109, true, 92, false, false, true, true, false, "Legend", "MostLoaded1", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 81, "", 1, "X Label", "Y Label" },
                    { 104, true, 96, false, false, true, true, false, "Legend", "MostLoaded1", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 90, "", 3, "X Label", "Y Label" },
                    { 102, true, 98, false, false, true, true, false, "Legend", "MostLoaded2", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 16, "", 1, "X Label", "Y Label" },
                    { 105, true, 97, false, false, true, true, false, "Legend", "MostLoaded3", 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 57, "", 0, "X Label", "Y Label" }
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
