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
                    { 61, "Yellow", "Univers", false, "Theme402" },
                    { 62, "Yellow", "Frutiger", false, "Theme630" },
                    { 63, "Gray", "Trade", false, "Theme632" },
                    { 64, "White", "Frutiger", false, "Theme846" },
                    { 65, "Gray", "Frutiger", false, "Theme512" },
                    { 66, "Yellow", "Trade", false, "Theme383" },
                    { 67, "Gray", "Trade", false, "Theme201" },
                    { 68, "Gray", "Frutiger", false, "Theme591" },
                    { 69, "White", "Helvetica", false, "Theme354" },
                    { 70, "White", "Frutiger", false, "Theme980" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", null, new DateTime(2018, 9, 6, 15, 6, 49, 835, DateTimeKind.Local), "Myrtice", "Polly_Gutmann50@gmail.com", null, "Nicklaus", true, false, "Braun", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nvkznemo/128.jpg", 1 },
                    { "d379db4b-5ad6-4186-930f-f7e8ae97ec21", null, new DateTime(2018, 9, 7, 3, 4, 35, 136, DateTimeKind.Local), "Teresa", "Landen.Wolff69@gmail.com", null, "Betsy", true, false, "Will", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gmourier/128.jpg", 1 },
                    { "bea1b89b-27f6-471d-a9ef-3ff7452d038a", null, new DateTime(2018, 9, 7, 8, 31, 44, 288, DateTimeKind.Local), "Anderson", "Maria.Kuvalis4@hotmail.com", null, "Juwan", true, false, "Kulas", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ganserene/128.jpg", 1 },
                    { "4178fd39-7def-4d3b-a1bc-6306e894b259", null, new DateTime(2018, 9, 7, 9, 45, 12, 531, DateTimeKind.Local), "Melba", "Kaylah48@hotmail.com", null, "Marta", true, false, "Quitzon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/levisan/128.jpg", 1 },
                    { "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", null, new DateTime(2018, 9, 7, 10, 37, 4, 948, DateTimeKind.Local), "Amaya", "Norma.Wolff57@gmail.com", null, "Mable", true, false, "Lemke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oskamaya/128.jpg", 1 },
                    { "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee", null, new DateTime(2018, 9, 7, 6, 11, 57, 319, DateTimeKind.Local), "Irving", "Alford.Ryan@yahoo.com", null, "Tony", true, false, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/danthms/128.jpg", 1 },
                    { "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", null, new DateTime(2018, 9, 6, 18, 17, 35, 182, DateTimeKind.Local), "Lauretta", "Tristin_West@gmail.com", null, "Mary", true, false, "Bruen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/josep_martins/128.jpg", 2 },
                    { "073419fb-85d6-483c-8bff-d74d8f1c1fd3", null, new DateTime(2018, 9, 7, 3, 46, 32, 709, DateTimeKind.Local), "Jordane", "Athena.Kovacek78@yahoo.com", null, "Glenna", true, false, "Dickens", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kiwiupover/128.jpg", 2 },
                    { "a0901b20-6809-408e-99ad-34bad597bc1a", null, new DateTime(2018, 9, 7, 2, 34, 14, 163, DateTimeKind.Local), "Peyton", "Martin_Senger@hotmail.com", null, "Dayna", true, false, "Wintheiser", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dnirmal/128.jpg", 2 },
                    { "0d96ad0e-f880-415b-85bd-3cf6e4786597", null, new DateTime(2018, 9, 6, 11, 7, 51, 995, DateTimeKind.Local), "Aliza", "Darrel50@gmail.com", null, "Salvador", true, false, "Wisoky", null, "https://s3.amazonaws.com/uifaces/faces/twitter/carbontwelve/128.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "IsDeleted", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 21, "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", false, "aperiam", null, 0 },
                    { 25, "bea1b89b-27f6-471d-a9ef-3ff7452d038a", false, "harum", null, 0 },
                    { 27, "a0901b20-6809-408e-99ad-34bad597bc1a", false, "dolorem", null, 0 },
                    { 28, "0d96ad0e-f880-415b-85bd-3cf6e4786597", false, "vel", null, 0 },
                    { 26, "d379db4b-5ad6-4186-930f-f7e8ae97ec21", false, "dignissimos", null, 0 },
                    { 30, "0d96ad0e-f880-415b-85bd-3cf6e4786597", false, "pariatur", null, 0 },
                    { 24, "a0901b20-6809-408e-99ad-34bad597bc1a", false, "facilis", null, 0 },
                    { 29, "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", false, "similique", null, 0 },
                    { 22, "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", false, "optio", null, 0 },
                    { 23, "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", false, "nisi", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "Friendliness", "Informatively", "IsDeleted", "Quickness", "ResponseId", "Text", "UserId", "WillUse" },
                values: new object[,]
                {
                    { 44, new DateTime(2018, 9, 6, 13, 4, 30, 580, DateTimeKind.Local), 0, 0, false, 0, null, "Atque accusamus soluta nobis qui et quae sunt omnis culpa.", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", 0 },
                    { 43, new DateTime(2018, 9, 7, 6, 25, 12, 296, DateTimeKind.Local), 0, 0, false, 0, null, "Blanditiis non et ipsum iusto hic quam architecto.", "d379db4b-5ad6-4186-930f-f7e8ae97ec21", 0 },
                    { 45, new DateTime(2018, 9, 6, 19, 25, 27, 122, DateTimeKind.Local), 0, 0, false, 0, null, "Ea animi iure eos animi eaque itaque unde.", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", 0 },
                    { 41, new DateTime(2018, 9, 6, 21, 59, 54, 202, DateTimeKind.Local), 0, 0, false, 0, null, "Voluptates quia sunt quis.", "a0901b20-6809-408e-99ad-34bad597bc1a", 0 },
                    { 46, new DateTime(2018, 9, 7, 6, 51, 58, 540, DateTimeKind.Local), 0, 0, false, 0, null, "Eum laboriosam et itaque qui qui necessitatibus voluptate dolores.", "bea1b89b-27f6-471d-a9ef-3ff7452d038a", 0 },
                    { 49, new DateTime(2018, 9, 7, 3, 43, 15, 643, DateTimeKind.Local), 0, 0, false, 0, null, "Voluptatum ratione sit dignissimos voluptas animi necessitatibus.", "bea1b89b-27f6-471d-a9ef-3ff7452d038a", 0 },
                    { 42, new DateTime(2018, 9, 6, 11, 3, 0, 419, DateTimeKind.Local), 0, 0, false, 0, null, "Mollitia aliquam nesciunt officiis doloremque libero minus et cumque ut.", "a0901b20-6809-408e-99ad-34bad597bc1a", 0 },
                    { 48, new DateTime(2018, 9, 6, 14, 54, 40, 410, DateTimeKind.Local), 0, 0, false, 0, null, "Consequuntur unde ipsam eos consequatur.", "4178fd39-7def-4d3b-a1bc-6306e894b259", 0 },
                    { 50, new DateTime(2018, 9, 7, 9, 3, 22, 983, DateTimeKind.Local), 0, 0, false, 0, null, "Aut quas sequi est et.", "4178fd39-7def-4d3b-a1bc-6306e894b259", 0 },
                    { 47, new DateTime(2018, 9, 7, 5, 38, 5, 947, DateTimeKind.Local), 0, 0, false, 0, null, "Doloribus ab dolor blanditiis.", "0d96ad0e-f880-415b-85bd-3cf6e4786597", 0 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "ChatId", "IsDeleted", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 20, null, false, false, false, true, 0, "b8e2aaa9-e682-4b55-a302-3e2a4b00be11" },
                    { 13, null, false, true, false, true, 4, "bea1b89b-27f6-471d-a9ef-3ff7452d038a" },
                    { 15, null, false, true, true, false, 2, "4178fd39-7def-4d3b-a1bc-6306e894b259" },
                    { 19, null, false, false, true, false, 2, "d379db4b-5ad6-4186-930f-f7e8ae97ec21" },
                    { 16, null, false, true, false, false, 0, "d379db4b-5ad6-4186-930f-f7e8ae97ec21" },
                    { 11, null, false, false, true, false, 3, "d379db4b-5ad6-4186-930f-f7e8ae97ec21" },
                    { 12, null, false, true, false, false, 3, "0d96ad0e-f880-415b-85bd-3cf6e4786597" },
                    { 18, null, false, true, false, true, 1, "b8983bf1-3fb8-41eb-baab-03f3e5dfb614" },
                    { 14, null, false, true, true, true, 4, "b8983bf1-3fb8-41eb-baab-03f3e5dfb614" },
                    { 17, null, false, true, true, true, 2, "4178fd39-7def-4d3b-a1bc-6306e894b259" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 77, "230-333-5796 x896", "073419fb-85d6-483c-8bff-d74d8f1c1fd3", "Tenetur quae facere quia vel inventore ipsam ipsa quibusdam sit.", "Lavonne.Sauer24@gmail.com", null, true, false, "Company267", 66, "https://bernadine.org" },
                    { 73, "1-513-990-3309 x08094", "0d96ad0e-f880-415b-85bd-3cf6e4786597", "Iure et vel eum. Sed id ullam. Quae ad nisi ipsam autem labore accusamus. Dolorum beatae inventore unde iusto consequatur culpa et.", "Lorenza91@yahoo.com", null, true, false, "Company755", 64, "http://monroe.org" },
                    { 74, "1-430-439-0971", "073419fb-85d6-483c-8bff-d74d8f1c1fd3", "Blanditiis quis vel assumenda mollitia tenetur fugit ut officia magni. Alias laboriosam sit voluptatem. Hic perspiciatis alias.", "Molly_Goldner@gmail.com", null, true, false, "Company734", 69, "https://quinn.com" },
                    { 71, "906-360-0689", "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee", "Provident rerum nihil nulla esse reiciendis unde impedit inventore facere. Aut tempora ab temporibus totam. Ut ut aut nemo dolorem est ratione recusandae molestiae quis. Quo quidem voluptas quis voluptas quos corporis esse enim quia.", "Robb.Becker15@yahoo.com", null, true, false, "Company255", 65, "http://kristian.info" },
                    { 79, "490.261.4186 x13672", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", "Debitis et libero illo. Eveniet omnis sint nihil. Sunt qui cumque.", "Kailyn.Wolf@yahoo.com", null, true, false, "Company609", 64, "https://willard.name" },
                    { 76, "1-417-490-0638", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", "", "Mya.Haag5@gmail.com", null, true, false, "Company64", 65, "http://jolie.org" },
                    { 80, "658-587-7777 x99111", "0d96ad0e-f880-415b-85bd-3cf6e4786597", "", "Nick47@gmail.com", null, true, false, "Company445", 62, "http://arnold.name" },
                    { 78, "1-254-645-2095 x941", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", "Nesciunt consequatur dolor ipsum perspiciatis et vero quisquam saepe nemo. Sint omnis temporibus. Laboriosam odit incidunt provident quod.", "Olga31@hotmail.com", null, true, false, "Company616", 63, "https://providenci.net" },
                    { 75, "984.986.1868", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", "Magni commodi cum voluptatem. Beatae perferendis amet ratione aliquid amet molestiae perferendis.", "Martine84@hotmail.com", null, true, false, "Company531", 61, "http://dusty.biz" },
                    { 72, "563-982-9966 x9490", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", "Placeat autem nesciunt autem quos sed aut soluta. Error incidunt aut. Maxime sunt dicta sapiente neque vero qui vel recusandae unde.", "Cordell.VonRueden62@gmail.com", null, true, false, "Company34", 63, "http://linwood.net" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "IsDeleted", "Text", "UserId" },
                values: new object[,]
                {
                    { 56, new DateTime(2018, 9, 6, 13, 45, 7, 424, DateTimeKind.Local), 41, false, "Enim labore quia quo quam.", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11" },
                    { 53, new DateTime(2018, 9, 7, 7, 15, 37, 143, DateTimeKind.Local), 41, false, "Natus aspernatur facere autem dolores odit qui.", "073419fb-85d6-483c-8bff-d74d8f1c1fd3" },
                    { 60, new DateTime(2018, 9, 7, 3, 19, 26, 857, DateTimeKind.Local), 45, false, "Nihil excepturi et eligendi nihil aut pariatur unde.", "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee" },
                    { 57, new DateTime(2018, 9, 7, 4, 27, 17, 974, DateTimeKind.Local), 49, false, "Qui laborum dolore amet impedit adipisci eum fuga.", "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee" },
                    { 59, new DateTime(2018, 9, 7, 6, 56, 27, 465, DateTimeKind.Local), 42, false, "Cupiditate est et aut voluptates fugiat.", "a0901b20-6809-408e-99ad-34bad597bc1a" },
                    { 58, new DateTime(2018, 9, 6, 12, 38, 45, 728, DateTimeKind.Local), 42, false, "Commodi cumque quos.", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614" },
                    { 55, new DateTime(2018, 9, 7, 5, 50, 28, 591, DateTimeKind.Local), 45, false, "Quibusdam quas blanditiis est incidunt sit.", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614" },
                    { 54, new DateTime(2018, 9, 6, 16, 53, 57, 457, DateTimeKind.Local), 46, false, "In voluptas reprehenderit dolorem.", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614" },
                    { 51, new DateTime(2018, 9, 7, 9, 15, 25, 448, DateTimeKind.Local), 42, false, "Odio in consequatur quam qui quisquam facilis laboriosam qui et.", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11" },
                    { 52, new DateTime(2018, 9, 7, 4, 35, 13, 847, DateTimeKind.Local), 48, false, "Voluptatem quo esse.", "0d96ad0e-f880-415b-85bd-3cf6e4786597" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "Title" },
                values: new object[,]
                {
                    { 88, "c8:cd:dc:24:3a:19", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 72, "Linux", "Instance89" },
                    { 87, "e2:34:ea:db:4b:dc", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", "Instance695" },
                    { 84, "e4:b9:d5:b4:34:a7", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", "Instance65" },
                    { 83, "e8:81:96:73:04:12", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", "Instance366" },
                    { 81, "65:d0:e6:b6:83:80", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 74, "Windows", "Instance756" },
                    { 90, "6d:2b:66:e0:56:33", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", "Instance491" },
                    { 82, "95:76:69:4b:4a:66", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", "Instance403" },
                    { 86, "07:fd:fe:1f:37:e3", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Linux", "Instance900" },
                    { 89, "5d:c5:40:49:84:e7", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Windows", "Instance41" },
                    { 85, "67:cf:59:8e:68:76", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Windows", "Instance317" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "IsDeleted", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 34, 21, new DateTime(2018, 9, 7, 10, 18, 11, 946, DateTimeKind.Local), false, "Et eos et necessitatibus fugiat vero quia sed.", "4178fd39-7def-4d3b-a1bc-6306e894b259", true },
                    { 31, 30, new DateTime(2018, 9, 7, 6, 13, 4, 682, DateTimeKind.Local), false, "Blanditiis iure facere beatae rerum iusto a sequi.", "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", false },
                    { 37, 28, new DateTime(2018, 9, 6, 11, 4, 0, 936, DateTimeKind.Local), false, "Debitis mollitia voluptas voluptas aperiam nobis dolorum modi magnam.", "073419fb-85d6-483c-8bff-d74d8f1c1fd3", false },
                    { 35, 29, new DateTime(2018, 9, 6, 16, 17, 14, 249, DateTimeKind.Local), false, "Excepturi et molestiae.", "d379db4b-5ad6-4186-930f-f7e8ae97ec21", true },
                    { 32, 29, new DateTime(2018, 9, 6, 17, 19, 2, 923, DateTimeKind.Local), false, "Sit quia omnis voluptatum modi et autem sunt rerum minus.", "4178fd39-7def-4d3b-a1bc-6306e894b259", false },
                    { 33, 23, new DateTime(2018, 9, 6, 18, 4, 25, 27, DateTimeKind.Local), false, "Molestiae nisi maiores ipsa voluptatem et culpa distinctio earum.", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", false },
                    { 36, 26, new DateTime(2018, 9, 6, 22, 23, 45, 398, DateTimeKind.Local), false, "Modi non et a dolores odio perspiciatis fugiat.", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", false },
                    { 40, 26, new DateTime(2018, 9, 6, 21, 56, 8, 782, DateTimeKind.Local), false, "Mollitia molestias quod.", "0d96ad0e-f880-415b-85bd-3cf6e4786597", true },
                    { 39, 23, new DateTime(2018, 9, 6, 13, 39, 29, 974, DateTimeKind.Local), false, "Non mollitia recusandae suscipit quam et consequatur perspiciatis quas.", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", true },
                    { 38, 26, new DateTime(2018, 9, 7, 3, 1, 42, 356, DateTimeKind.Local), false, "Consequatur sit culpa.", "0d96ad0e-f880-415b-85bd-3cf6e4786597", false }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 118, new DateTime(2018, 9, 6, 19, 19, 32, 486, DateTimeKind.Local), false, 12, "Enim aut labore delectus illo labore quas molestias ut omnis.", "4178fd39-7def-4d3b-a1bc-6306e894b259", false },
                    { 117, new DateTime(2018, 9, 7, 1, 37, 7, 906, DateTimeKind.Local), false, 15, "Voluptates consequatur fuga et voluptas vel dolor nam.", "a0901b20-6809-408e-99ad-34bad597bc1a", false },
                    { 119, new DateTime(2018, 9, 6, 22, 42, 28, 478, DateTimeKind.Local), false, 12, "Non vel rerum doloribus culpa a eos necessitatibus non mollitia.", "a0901b20-6809-408e-99ad-34bad597bc1a", false },
                    { 116, new DateTime(2018, 9, 6, 22, 49, 54, 367, DateTimeKind.Local), false, 15, "Tempore quia consequatur ullam vitae laudantium.", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", false },
                    { 112, new DateTime(2018, 9, 6, 23, 47, 18, 578, DateTimeKind.Local), false, 19, "Aperiam molestiae voluptates laudantium et voluptas hic.", "4178fd39-7def-4d3b-a1bc-6306e894b259", false },
                    { 111, new DateTime(2018, 9, 6, 13, 21, 1, 153, DateTimeKind.Local), false, 19, "Consectetur aut at qui dolor qui dolor earum excepturi.", "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", false },
                    { 113, new DateTime(2018, 9, 6, 12, 3, 30, 577, DateTimeKind.Local), false, 11, "Voluptas aspernatur quia minima non aspernatur aliquam dolorem aut.", "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee", false },
                    { 115, new DateTime(2018, 9, 6, 11, 13, 4, 849, DateTimeKind.Local), false, 12, "Ipsa nihil deserunt.", "073419fb-85d6-483c-8bff-d74d8f1c1fd3", false },
                    { 114, new DateTime(2018, 9, 6, 14, 47, 25, 229, DateTimeKind.Local), false, 12, "Soluta delectus blanditiis dicta ut omnis provident.", "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", false },
                    { 120, new DateTime(2018, 9, 7, 3, 51, 19, 196, DateTimeKind.Local), false, 18, "Consequatur quia voluptatem.", "a0901b20-6809-408e-99ad-34bad597bc1a", false }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "b7f0e7a7-ff95-4a2d-9d2a-8cf99a381294", 75, 1 },
                    { "bea1b89b-27f6-471d-a9ef-3ff7452d038a", 72, 1 },
                    { "073419fb-85d6-483c-8bff-d74d8f1c1fd3", 74, 1 },
                    { "a0901b20-6809-408e-99ad-34bad597bc1a", 74, 1 },
                    { "6cd2b6ca-6f73-4032-8da0-e7ce8d042aee", 79, 1 },
                    { "d379db4b-5ad6-4186-930f-f7e8ae97ec21", 79, 1 },
                    { "b8983bf1-3fb8-41eb-baab-03f3e5dfb614", 79, 1 },
                    { "b8e2aaa9-e682-4b55-a302-3e2a4b00be11", 71, 1 },
                    { "0d96ad0e-f880-415b-85bd-3cf6e4786597", 72, 1 },
                    { "4178fd39-7def-4d3b-a1bc-6306e894b259", 73, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 99, new DateTime(2018, 9, 6, 18, 55, 14, 482, DateTimeKind.Local), 88, false, "Title28" },
                    { 94, new DateTime(2018, 9, 7, 6, 9, 15, 909, DateTimeKind.Local), 85, false, "Title117" },
                    { 91, new DateTime(2018, 9, 6, 21, 44, 51, 45, DateTimeKind.Local), 89, false, "Title492" },
                    { 93, new DateTime(2018, 9, 6, 14, 32, 5, 12, DateTimeKind.Local), 89, false, "Title228" },
                    { 98, new DateTime(2018, 9, 6, 11, 17, 43, 631, DateTimeKind.Local), 89, false, "Title612" },
                    { 96, new DateTime(2018, 9, 7, 1, 30, 12, 117, DateTimeKind.Local), 82, false, "Title629" },
                    { 92, new DateTime(2018, 9, 7, 4, 30, 19, 379, DateTimeKind.Local), 90, false, "Title2" },
                    { 95, new DateTime(2018, 9, 7, 8, 7, 1, 438, DateTimeKind.Local), 90, false, "Title140" },
                    { 100, new DateTime(2018, 9, 7, 2, 7, 44, 351, DateTimeKind.Local), 81, false, "Title493" },
                    { 97, new DateTime(2018, 9, 6, 16, 19, 11, 952, DateTimeKind.Local), 83, false, "Title920" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 102, true, 99, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 89, "", 1, "X Label", "Y Label" },
                    { 106, true, 91, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 99, "", 1, "X Label", "Y Label" },
                    { 107, true, 91, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 14, "", 3, "X Label", "Y Label" },
                    { 101, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 99, "", 1, "X Label", "Y Label" },
                    { 104, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 22, "", 1, "X Label", "Y Label" },
                    { 103, true, 98, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 23, "", 1, "X Label", "Y Label" },
                    { 109, true, 92, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 71, "", 3, "X Label", "Y Label" },
                    { 105, true, 95, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 87, "", 3, "X Label", "Y Label" },
                    { 108, true, 95, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 6, "", 3, "X Label", "Y Label" },
                    { 110, true, 97, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 5, "", 0, "X Label", "Y Label" }
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
