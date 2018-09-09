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
                    MostLoaded = table.Column<int>(nullable: false),
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
                    { 61, "Gray", "Univers", false, "Theme497" },
                    { 62, "Gray", "Helvetica", false, "Theme140" },
                    { 63, "White", "Trade", false, "Theme871" },
                    { 64, "White", "Frutiger", false, "Theme602" },
                    { 65, "Gray", "Helvetica", false, "Theme326" },
                    { 66, "Gray", "Frutiger", false, "Theme509" },
                    { 67, "White", "Trade", false, "Theme91" },
                    { 68, "White", "Univers", false, "Theme292" },
                    { 69, "White", "Frutiger", false, "Theme180" },
                    { 70, "Yellow", "Trade", false, "Theme513" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", null, new DateTime(2018, 9, 9, 1, 55, 45, 527, DateTimeKind.Local), "Ethyl", "Raphael.Murazik@hotmail.com", null, "Cali", true, false, "Kutch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tobysaxon/128.jpg", 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", null, new DateTime(2018, 9, 9, 5, 37, 2, 549, DateTimeKind.Local), "Winston", "Austyn77@yahoo.com", null, "Shayna", true, false, "Parker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gearpixels/128.jpg", 1 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", null, new DateTime(2018, 9, 9, 4, 14, 16, 766, DateTimeKind.Local), "Rodrigo", "Benton14@yahoo.com", null, "Tom", true, false, "Hauck", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bargaorobalo/128.jpg", 1 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", null, new DateTime(2018, 9, 9, 11, 48, 24, 489, DateTimeKind.Local), "Hope", "Sydnee90@yahoo.com", null, "Oliver", true, false, "Hoppe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bobbytwoshoes/128.jpg", 1 },
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", null, new DateTime(2018, 9, 9, 0, 52, 56, 943, DateTimeKind.Local), "Adan", "Bridget74@yahoo.com", null, "Jacky", true, false, "Keebler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 1 },
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", null, new DateTime(2018, 9, 9, 13, 36, 12, 571, DateTimeKind.Local), "Leslie", "Javier.Paucek@gmail.com", null, "Rylee", true, false, "Kuhlman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joreira/128.jpg", 2 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", null, new DateTime(2018, 9, 9, 19, 34, 7, 631, DateTimeKind.Local), "Andrew", "Ezekiel.Hermiston1@yahoo.com", null, "Grover", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/angelceballos/128.jpg", 2 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", null, new DateTime(2018, 9, 9, 8, 19, 36, 70, DateTimeKind.Local), "Makenna", "Davin_Schulist60@gmail.com", null, "Crawford", true, false, "Gaylord", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 2 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", null, new DateTime(2018, 9, 9, 3, 38, 22, 832, DateTimeKind.Local), "Jacinthe", "Zoe82@gmail.com", null, "Kellie", true, false, "Stehr", null, "https://s3.amazonaws.com/uifaces/faces/twitter/suribbles/128.jpg", 2 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", null, new DateTime(2018, 9, 9, 14, 28, 5, 94, DateTimeKind.Local), "Dillan", "Justus44@hotmail.com", null, "Carmel", true, false, "Bradtke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samihah/128.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 29, "14e7d6f2-3626-423b-959b-e8ca1b882173", false, "quos", null, 0 },
                    { 30, "36410a7e-ff1b-4570-8a45-82e6d045bfda", false, "id", null, 0 },
                    { 26, "36410a7e-ff1b-4570-8a45-82e6d045bfda", false, "recusandae", null, 0 },
                    { 22, "36410a7e-ff1b-4570-8a45-82e6d045bfda", false, "commodi", null, 0 },
                    { 21, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", false, "id", null, 0 },
                    { 25, "9a549b2b-8fd0-4d70-9145-569474fea109", false, "dolorem", null, 0 },
                    { 23, "0da18978-1656-4b4d-ac10-940871d87e18", false, "voluptatem", null, 0 },
                    { 28, "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false, "animi", null, 0 },
                    { 27, "0b22d062-92ae-494c-9481-11c2931737da", false, "commodi", null, 0 },
                    { 24, "0b22d062-92ae-494c-9481-11c2931737da", false, "aliquam", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "Friendliness", "Informatively", "IsDeleted", "Quickness", "ResponseId", "Text", "UserId", "WillUse" },
                values: new object[,]
                {
                    { 42, new DateTime(2018, 9, 9, 2, 29, 5, 920, DateTimeKind.Local), 0, 0, false, 0, null, "Et est voluptatibus et qui cumque eos nesciunt praesentium illo.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 0 },
                    { 41, new DateTime(2018, 9, 9, 15, 52, 11, 195, DateTimeKind.Local), 0, 0, false, 0, null, "Nulla et perspiciatis.", "0b22d062-92ae-494c-9481-11c2931737da", 0 },
                    { 48, new DateTime(2018, 9, 8, 23, 54, 56, 711, DateTimeKind.Local), 0, 0, false, 0, null, "Est ipsa consequatur ut provident ab.", "732bab35-8c9e-4812-b4ff-251abdf5b857", 0 },
                    { 46, new DateTime(2018, 9, 9, 13, 51, 41, 285, DateTimeKind.Local), 0, 0, false, 0, null, "Consequatur dolor quia.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 0 },
                    { 50, new DateTime(2018, 9, 9, 14, 51, 6, 29, DateTimeKind.Local), 0, 0, false, 0, null, "Quas quas exercitationem officiis et error cumque impedit.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 0 },
                    { 45, new DateTime(2018, 9, 9, 14, 8, 1, 415, DateTimeKind.Local), 0, 0, false, 0, null, "Repellendus error officia tenetur et qui possimus voluptas.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 0 },
                    { 49, new DateTime(2018, 9, 9, 17, 44, 49, 86, DateTimeKind.Local), 0, 0, false, 0, null, "Maxime earum odit et non quisquam occaecati nobis aut.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 0 },
                    { 43, new DateTime(2018, 9, 9, 19, 25, 23, 926, DateTimeKind.Local), 0, 0, false, 0, null, "Adipisci quo dolores animi quo doloribus qui eos velit unde.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 0 },
                    { 47, new DateTime(2018, 9, 9, 4, 16, 23, 539, DateTimeKind.Local), 0, 0, false, 0, null, "Ad fugiat odit quam modi et debitis est perspiciatis.", "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 0 },
                    { 44, new DateTime(2018, 9, 9, 19, 8, 28, 32, DateTimeKind.Local), 0, 0, false, 0, null, "Sequi reprehenderit est delectus sit dolor.", "0da18978-1656-4b4d-ac10-940871d87e18", 0 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "ChatId", "IsDeleted", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 13, null, false, false, true, true, 1, "732bab35-8c9e-4812-b4ff-251abdf5b857" },
                    { 11, null, false, true, true, false, 3, "0bddde5f-5756-4d7f-8521-42d0476f3aa0" },
                    { 16, null, false, true, true, true, 3, "6aa322ac-217f-449e-8ebf-12b4f2e2436c" },
                    { 15, null, false, false, true, true, 1, "0b22d062-92ae-494c-9481-11c2931737da" },
                    { 14, null, false, true, false, true, 2, "14e7d6f2-3626-423b-959b-e8ca1b882173" },
                    { 17, null, false, true, false, true, 2, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" },
                    { 19, null, false, true, false, true, 2, "9a549b2b-8fd0-4d70-9145-569474fea109" },
                    { 18, null, false, true, false, true, 4, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" },
                    { 12, null, false, true, false, true, 4, "0da18978-1656-4b4d-ac10-940871d87e18" },
                    { 20, null, false, false, false, false, 2, "0b22d062-92ae-494c-9481-11c2931737da" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 72, "(204) 999-6677 x405", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "", "Domingo.Stiedemann@yahoo.com", null, true, false, "Company114", 67, "http://janis.com" },
                    { 75, "614.292.9580 x822", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "", "Alessandra.Heller42@gmail.com", null, true, false, "Company165", 67, "https://kamron.biz" },
                    { 79, "(259) 858-0505 x993", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Dicta a hic tempora illo dolorem. Dolorum voluptas nemo ea ea.", "Lura_Kling61@yahoo.com", null, true, false, "Company833", 64, "http://marianna.name" },
                    { 78, "(938) 960-5637", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Quo consequatur vero sint ut autem aut doloremque ullam laborum. Rerum repellendus est qui sit rerum.", "Juliet_Powlowski@yahoo.com", null, true, false, "Company297", 65, "https://josiane.com" },
                    { 80, "(732) 704-3028 x624", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Id modi distinctio animi dolorem. Amet quia sint id harum exercitationem.", "Madison.Collins@yahoo.com", null, true, false, "Company179", 70, "http://orlo.name" },
                    { 73, "(440) 509-1684", "14e7d6f2-3626-423b-959b-e8ca1b882173", "", "Sofia_Schaefer8@hotmail.com", null, true, false, "Company613", 69, "http://lew.info" },
                    { 71, "439-419-3955 x8548", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Adipisci molestias non quisquam earum dolorum molestias iste. Explicabo ea ut mollitia itaque repudiandae. Est unde quasi.", "Jarrod_Hammes29@gmail.com", null, true, false, "Company541", 67, "https://chadrick.name" },
                    { 74, "662.300.3345", "14e7d6f2-3626-423b-959b-e8ca1b882173", "Nostrum iusto voluptatem culpa ut.", "Madyson19@hotmail.com", null, true, false, "Company435", 68, "https://mose.info" },
                    { 76, "1-958-620-8119 x139", "0da18978-1656-4b4d-ac10-940871d87e18", "", "Elias.Schmeler76@yahoo.com", null, true, false, "Company221", 61, "http://bert.biz" },
                    { 77, "631.889.3525 x9022", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Enim sit quia nemo tempore accusantium. Voluptatibus eum aliquid ab. Mollitia iure doloremque omnis quaerat voluptatem ut suscipit.", "Dorothy.Torphy@hotmail.com", null, true, false, "Company782", 68, "https://alvina.org" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "IsDeleted", "Text", "UserId" },
                values: new object[,]
                {
                    { 56, new DateTime(2018, 9, 9, 2, 34, 33, 692, DateTimeKind.Local), 49, false, "Quia qui ad nihil reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" },
                    { 58, new DateTime(2018, 9, 9, 9, 54, 52, 111, DateTimeKind.Local), 46, false, "Omnis recusandae consectetur magnam provident explicabo.", "14e7d6f2-3626-423b-959b-e8ca1b882173" },
                    { 54, new DateTime(2018, 9, 9, 14, 27, 16, 499, DateTimeKind.Local), 50, false, "Animi consequatur molestiae omnis.", "732bab35-8c9e-4812-b4ff-251abdf5b857" },
                    { 51, new DateTime(2018, 9, 9, 12, 10, 3, 91, DateTimeKind.Local), 41, false, "Voluptas enim laborum ex explicabo voluptates est sequi.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" },
                    { 55, new DateTime(2018, 9, 9, 8, 58, 39, 165, DateTimeKind.Local), 44, false, "Et aut ea accusamus aliquam.", "9a549b2b-8fd0-4d70-9145-569474fea109" },
                    { 52, new DateTime(2018, 9, 9, 8, 27, 14, 956, DateTimeKind.Local), 41, false, "Saepe alias maiores aut qui ea delectus.", "9a549b2b-8fd0-4d70-9145-569474fea109" },
                    { 57, new DateTime(2018, 9, 9, 6, 24, 31, 160, DateTimeKind.Local), 49, false, "Libero consectetur alias dolorum deleniti.", "0b22d062-92ae-494c-9481-11c2931737da" },
                    { 53, new DateTime(2018, 9, 9, 20, 59, 34, 800, DateTimeKind.Local), 48, false, "Modi sed quo doloremque quis atque incidunt corporis qui.", "0b22d062-92ae-494c-9481-11c2931737da" },
                    { 60, new DateTime(2018, 9, 9, 3, 44, 42, 883, DateTimeKind.Local), 49, false, "Id quia unde quae eveniet delectus ea.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" },
                    { 59, new DateTime(2018, 9, 9, 19, 36, 22, 152, DateTimeKind.Local), 41, false, "Nesciunt aperiam recusandae tempore a.", "0da18978-1656-4b4d-ac10-940871d87e18" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "Title" },
                values: new object[,]
                {
                    { 83, "2d:74:0e:71:6f:7a", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 76, "Linux", "Instance819" },
                    { 90, "09:2f:b3:74:1b:82", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 71, "Linux", "Instance474" },
                    { 88, "e7:0a:de:ee:bf:6e", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 74, "Windows", "Instance701" },
                    { 85, "df:be:1e:09:9c:ab", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 74, "Linux", "Instance856" },
                    { 86, "5e:42:96:2e:00:e0", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", "Instance731" },
                    { 89, "16:66:b1:ef:be:c1", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Windows", "Instance831" },
                    { 87, "c8:5c:b1:ee:61:bc", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 76, "Linux", "Instance85" },
                    { 81, "54:bc:6c:85:e1:55", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Windows", "Instance802" },
                    { 84, "04:d6:00:79:e3:b7", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 72, "Windows", "Instance161" },
                    { 82, "93:89:86:96:e6:11", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", "Instance46" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsDeleted", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 32, 25, new DateTime(2018, 9, 9, 7, 44, 12, 280, DateTimeKind.Local), false, "Quia eaque reiciendis id non.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", true },
                    { 33, 25, new DateTime(2018, 9, 9, 18, 34, 36, 38, DateTimeKind.Local), false, "Sequi odit inventore unde quibusdam tempore voluptates consequuntur et.", "0da18978-1656-4b4d-ac10-940871d87e18", true },
                    { 40, 27, new DateTime(2018, 9, 9, 16, 35, 21, 699, DateTimeKind.Local), false, "Minima natus unde dicta aspernatur earum deserunt sint tempora reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", true },
                    { 38, 27, new DateTime(2018, 9, 9, 21, 9, 39, 318, DateTimeKind.Local), false, "Qui ut non accusamus quos voluptas voluptatum.", "36410a7e-ff1b-4570-8a45-82e6d045bfda", true },
                    { 36, 27, new DateTime(2018, 9, 9, 0, 54, 33, 391, DateTimeKind.Local), false, "Est sed pariatur.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", true },
                    { 37, 24, new DateTime(2018, 9, 9, 13, 45, 57, 927, DateTimeKind.Local), false, "Numquam facere ipsa porro.", "0b22d062-92ae-494c-9481-11c2931737da", true },
                    { 39, 21, new DateTime(2018, 9, 9, 1, 15, 27, 632, DateTimeKind.Local), false, "Maiores dolor nihil earum suscipit at consectetur non et sunt.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false },
                    { 31, 26, new DateTime(2018, 9, 9, 4, 38, 36, 540, DateTimeKind.Local), false, "Voluptatum adipisci repellendus vitae facilis odit.", "0b22d062-92ae-494c-9481-11c2931737da", false },
                    { 35, 26, new DateTime(2018, 9, 9, 6, 44, 26, 9, DateTimeKind.Local), false, "Nihil quia ad et odio et dolorem.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", true },
                    { 34, 23, new DateTime(2018, 9, 9, 10, 21, 58, 678, DateTimeKind.Local), false, "Quam culpa qui autem accusamus.", "0b22d062-92ae-494c-9481-11c2931737da", true }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 116, new DateTime(2018, 9, 9, 5, 23, 32, 536, DateTimeKind.Local), false, 13, "Officiis dolores dolores tenetur nesciunt.", "36410a7e-ff1b-4570-8a45-82e6d045bfda", false },
                    { 113, new DateTime(2018, 9, 9, 5, 26, 37, 181, DateTimeKind.Local), false, 13, "Porro et architecto nulla.", "9a549b2b-8fd0-4d70-9145-569474fea109", false },
                    { 114, new DateTime(2018, 9, 9, 19, 49, 50, 408, DateTimeKind.Local), false, 17, "Sequi eius est dolores aspernatur.", "9a549b2b-8fd0-4d70-9145-569474fea109", false },
                    { 117, new DateTime(2018, 9, 9, 6, 20, 10, 310, DateTimeKind.Local), false, 11, "Et beatae non non natus quasi fugit officiis.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", false },
                    { 120, new DateTime(2018, 9, 9, 21, 57, 27, 602, DateTimeKind.Local), false, 18, "Quis sint beatae assumenda.", "0da18978-1656-4b4d-ac10-940871d87e18", false },
                    { 115, new DateTime(2018, 9, 9, 16, 29, 11, 14, DateTimeKind.Local), false, 12, "Doloremque impedit quod aut odit dolore delectus fuga rem mollitia.", "14e7d6f2-3626-423b-959b-e8ca1b882173", false },
                    { 119, new DateTime(2018, 9, 9, 0, 37, 52, 879, DateTimeKind.Local), false, 20, "Unde accusantium accusamus.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false },
                    { 118, new DateTime(2018, 9, 9, 16, 54, 34, 750, DateTimeKind.Local), false, 20, "Soluta sit iure est qui odit.", "0b22d062-92ae-494c-9481-11c2931737da", false },
                    { 112, new DateTime(2018, 9, 9, 11, 58, 14, 361, DateTimeKind.Local), false, 18, "Aut adipisci facere perferendis.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false },
                    { 111, new DateTime(2018, 9, 9, 18, 37, 9, 256, DateTimeKind.Local), false, 16, "Tempora omnis nobis a enim explicabo qui vitae.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", 71, 1 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", 79, 1 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", 77, 1 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 75, 1 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 76, 1 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 74, 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", 74, 1 },
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 73, 1 },
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", 72, 1 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", 76, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 98, new DateTime(2018, 9, 9, 12, 18, 28, 429, DateTimeKind.Local), 89, false, "Title719" },
                    { 93, new DateTime(2018, 9, 9, 6, 26, 18, 615, DateTimeKind.Local), 85, false, "Title328" },
                    { 96, new DateTime(2018, 9, 9, 7, 13, 27, 393, DateTimeKind.Local), 85, false, "Title756" },
                    { 100, new DateTime(2018, 9, 9, 4, 23, 15, 916, DateTimeKind.Local), 90, false, "Title956" },
                    { 91, new DateTime(2018, 9, 9, 1, 13, 23, 708, DateTimeKind.Local), 82, false, "Title187" },
                    { 94, new DateTime(2018, 9, 9, 6, 20, 43, 423, DateTimeKind.Local), 82, false, "Title568" },
                    { 97, new DateTime(2018, 9, 9, 5, 36, 59, 89, DateTimeKind.Local), 82, false, "Title712" },
                    { 92, new DateTime(2018, 9, 9, 9, 7, 26, 619, DateTimeKind.Local), 84, false, "Title344" },
                    { 99, new DateTime(2018, 9, 9, 18, 42, 20, 709, DateTimeKind.Local), 84, false, "Title235" },
                    { 95, new DateTime(2018, 9, 9, 13, 3, 4, 274, DateTimeKind.Local), 87, false, "Title317" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 108, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 40, "", 0, "X Label", "Y Label" },
                    { 110, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 78, "", 3, "X Label", "Y Label" },
                    { 103, true, 91, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 37, "", 1, "X Label", "Y Label" },
                    { 102, true, 94, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 59, "", 3, "X Label", "Y Label" },
                    { 105, true, 94, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 3, "", 1, "X Label", "Y Label" },
                    { 106, true, 94, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 76, "", 2, "X Label", "Y Label" },
                    { 101, true, 97, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 14, "", 1, "X Label", "Y Label" },
                    { 104, true, 99, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 73, "", 1, "X Label", "Y Label" },
                    { 107, true, 99, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 98, "", 0, "X Label", "Y Label" },
                    { 109, true, 95, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 57, "", 2, "X Label", "Y Label" }
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
