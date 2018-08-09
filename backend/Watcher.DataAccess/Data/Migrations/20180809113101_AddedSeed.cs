using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedSeed : Migration
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
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: false),
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
                name: "NotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    IsMute = table.Column<bool>(nullable: false),
                    IsDisable = table.Column<bool>(nullable: false),
                    IsEmailable = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
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
                    CreatedByUserId = table.Column<string>(nullable: true),
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
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "Name" },
                values: new object[,]
                {
                    { 61, "Gray", "Helvetica", "Theme677" },
                    { 62, "Gray", "Frutiger", "Theme796" },
                    { 63, "Gray", "Frutiger", "Theme587" },
                    { 64, "White", "Trade", "Theme246" },
                    { 65, "Gray", "Trade", "Theme77" },
                    { 66, "Gray", "Frutiger", "Theme567" },
                    { 67, "White", "Frutiger", "Theme458" },
                    { 68, "Yellow", "Trade", "Theme573" },
                    { 69, "Gray", "Frutiger", "Theme966" },
                    { 70, "Gray", "Frutiger", "Theme485" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "ca404c18-30b5-4013-870a-3b985772b799", new DateTime(2018, 8, 9, 12, 25, 42, 165, DateTimeKind.Local), "Guy", "Lafayette.Leffler44@hotmail.com", "Albin", true, 1, "MacGyver" },
                    { "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", new DateTime(2018, 8, 9, 2, 20, 29, 373, DateTimeKind.Local), "Felipa", "Chadd45@gmail.com", "Chloe", true, 1, "Gleason" },
                    { "8668b4f7-ba1a-464d-8b3a-3258ee90be2c", new DateTime(2018, 8, 9, 7, 50, 32, 379, DateTimeKind.Local), "Shaniya", "Camila_Von10@gmail.com", "Darron", true, 2, "Armstrong" },
                    { "8494cede-b032-4d27-9e14-76b53134d093", new DateTime(2018, 8, 9, 11, 15, 52, 762, DateTimeKind.Local), "Tess", "Kaitlin_Kulas@gmail.com", "Justina", true, 2, "Schmidt" },
                    { "b05710a2-28da-4da2-9acb-cd549be125ee", new DateTime(2018, 8, 9, 10, 50, 29, 608, DateTimeKind.Local), "Fiona", "Aaliyah.Kozey@gmail.com", "Katrine", true, 2, "Kassulke" },
                    { "febeb402-29c2-411f-a6a6-4377e9b55835", new DateTime(2018, 8, 8, 23, 56, 33, 77, DateTimeKind.Local), "Lambert", "Amanda_Bartoletti25@hotmail.com", "Brooks", true, 2, "Rice" },
                    { "a869a697-3585-49ae-9745-77614d6c803a", new DateTime(2018, 8, 8, 17, 15, 52, 243, DateTimeKind.Local), "Sanford", "Rafael15@gmail.com", "Eulah", true, 2, "McDermott" },
                    { "02fd40d4-7d38-402e-b77b-06d76ccdb5d3", new DateTime(2018, 8, 9, 0, 59, 23, 937, DateTimeKind.Local), "Rashad", "Cortez50@hotmail.com", "Urban", true, 2, "Herzog" },
                    { "be1d775a-e864-4389-a1de-b182cfb36d11", new DateTime(2018, 8, 8, 19, 8, 46, 847, DateTimeKind.Local), "Claude", "Rolando19@gmail.com", "Delpha", true, 2, "Legros" },
                    { "07073d56-481a-4e97-9ae2-9ff377492a8a", new DateTime(2018, 8, 9, 0, 11, 38, 735, DateTimeKind.Local), "Josie", "Giovani47@gmail.com", "Muhammad", true, 2, "Schumm" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 22, "ca404c18-30b5-4013-870a-3b985772b799", "pariatur", null, 0 },
                    { 24, "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", "et", null, 0 },
                    { 27, "8494cede-b032-4d27-9e14-76b53134d093", "facilis", null, 0 },
                    { 23, "b05710a2-28da-4da2-9acb-cd549be125ee", "laudantium", null, 0 },
                    { 28, "b05710a2-28da-4da2-9acb-cd549be125ee", "id", null, 0 },
                    { 30, "02fd40d4-7d38-402e-b77b-06d76ccdb5d3", "accusamus", null, 0 },
                    { 21, "febeb402-29c2-411f-a6a6-4377e9b55835", "eius", null, 0 },
                    { 25, "febeb402-29c2-411f-a6a6-4377e9b55835", "eos", null, 0 },
                    { 26, "febeb402-29c2-411f-a6a6-4377e9b55835", "accusantium", null, 0 },
                    { 29, "febeb402-29c2-411f-a6a6-4377e9b55835", "ea", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 45, new DateTime(2018, 8, 8, 16, 17, 1, 768, DateTimeKind.Local), null, "Ex voluptas qui et.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 46, new DateTime(2018, 8, 9, 11, 1, 33, 230, DateTimeKind.Local), null, "Alias sapiente vel corrupti.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 47, new DateTime(2018, 8, 8, 17, 15, 23, 199, DateTimeKind.Local), null, "Sint dolore nemo dolor aut et odio eveniet enim excepturi.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 44, new DateTime(2018, 8, 9, 1, 32, 4, 167, DateTimeKind.Local), null, "Illo voluptatem officia voluptas voluptas tempora eveniet ipsum est libero.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 42, new DateTime(2018, 8, 9, 9, 45, 47, 738, DateTimeKind.Local), null, "Sunt aspernatur non laudantium autem libero ducimus quia odio labore.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 41, new DateTime(2018, 8, 9, 1, 34, 49, 307, DateTimeKind.Local), null, "Nisi asperiores quia quaerat laudantium enim velit voluptatem.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 50, new DateTime(2018, 8, 8, 20, 13, 51, 373, DateTimeKind.Local), null, "Vel et esse necessitatibus similique.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 49, new DateTime(2018, 8, 9, 10, 10, 28, 874, DateTimeKind.Local), null, "Ipsa nihil dignissimos cum necessitatibus sunt rerum aut.", "8668b4f7-ba1a-464d-8b3a-3258ee90be2c" },
                    { 43, new DateTime(2018, 8, 9, 13, 21, 50, 790, DateTimeKind.Local), null, "Maxime numquam sapiente harum.", "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 48, new DateTime(2018, 8, 8, 18, 18, 2, 393, DateTimeKind.Local), null, "Est ad mollitia est optio qui ipsum.", "07073d56-481a-4e97-9ae2-9ff377492a8a" }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 12, true, true, true, 0, "be1d775a-e864-4389-a1de-b182cfb36d11" },
                    { 11, false, true, false, 1, "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 14, false, false, true, 0, "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 19, false, false, false, 0, "a869a697-3585-49ae-9745-77614d6c803a" },
                    { 18, false, true, false, 0, "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 17, true, false, false, 1, "b05710a2-28da-4da2-9acb-cd549be125ee" },
                    { 20, false, false, true, 1, "8494cede-b032-4d27-9e14-76b53134d093" },
                    { 16, true, false, true, 1, "b0560ef3-3c5d-4f55-a63f-77a4b91a0567" },
                    { 13, false, false, false, 0, "ca404c18-30b5-4013-870a-3b985772b799" },
                    { 15, true, false, false, 1, "a869a697-3585-49ae-9745-77614d6c803a" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "IsActive", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 76, "1-412-286-6736 x8868", "a869a697-3585-49ae-9745-77614d6c803a", "", "Daija.Balistreri47@yahoo.com", true, "Company828", 64, "http://graham.com" },
                    { 79, "(654) 552-1201 x37954", "febeb402-29c2-411f-a6a6-4377e9b55835", "Cupiditate est sit ut et. Non cupiditate non est voluptatem voluptas reprehenderit aliquam. Cumque est saepe sed porro qui molestias est nostrum illo. Rem sunt velit laudantium ut.", "Santiago_Senger@yahoo.com", true, "Company461", 67, "https://selina.name" },
                    { 78, "908-667-6212 x972", "febeb402-29c2-411f-a6a6-4377e9b55835", "Aut veniam nulla vero sed provident blanditiis aut ut animi. Et atque ut.", "Shanon34@hotmail.com", true, "Company540", 67, "https://danny.org" },
                    { 75, "633-297-3289 x525", "febeb402-29c2-411f-a6a6-4377e9b55835", "Sint odio in ut qui id earum. Dicta ea asperiores et rerum qui laudantium. Qui vero dolores qui laboriosam accusantium autem delectus ut magni. Explicabo distinctio voluptate et ut asperiores culpa blanditiis esse qui.", "Sanford_Cummerata@yahoo.com", true, "Company944", 65, "http://elmira.org" },
                    { 74, "(910) 626-5998 x9100", "07073d56-481a-4e97-9ae2-9ff377492a8a", "Ab adipisci voluptatem enim consequuntur. Non incidunt laudantium sit sit earum voluptatem quos adipisci.", "Isidro41@yahoo.com", true, "Company405", 66, "http://cheyanne.biz" },
                    { 72, "1-877-441-9293 x6293", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3", "", "Bernita.Corwin70@hotmail.com", true, "Company408", 67, "https://vern.name" },
                    { 73, "822-687-1461 x6666", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", "Et cum eos. Laborum optio voluptatem aut numquam fuga rem voluptates ullam.", "Delphine85@hotmail.com", true, "Company743", 63, "http://ally.org" },
                    { 77, "946.766.1783 x57261", "be1d775a-e864-4389-a1de-b182cfb36d11", "", "Jefferey.Hills@gmail.com", true, "Company367", 68, "https://raheem.net" },
                    { 71, "633.313.8643", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", "Iste eum iste. Vitae nemo deleniti iusto ducimus sequi aperiam. Quia eius asperiores eius ea. Perferendis et voluptate accusamus dicta vel rerum.", "Katelin80@gmail.com", true, "Company601", 64, "http://rudolph.biz" },
                    { 80, "983-702-6901", "07073d56-481a-4e97-9ae2-9ff377492a8a", "", "Emmalee_Wyman2@gmail.com", true, "Company613", 69, "https://makayla.name" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 87, "43:66:ed:2c:b5:a5", 78, "Windows" },
                    { 83, "34:d8:35:3f:16:9c", 76, "Linux" },
                    { 86, "37:4e:e5:b4:98:b1", 76, "Windows" },
                    { 85, "6d:23:3f:ac:95:d2", 72, "Windows" },
                    { 89, "22:85:f4:86:e3:06", 72, "Windows" },
                    { 90, "a6:04:08:c8:b7:df", 72, "Windows" },
                    { 81, "83:29:6f:1d:77:60", 79, "Linux" },
                    { 82, "c7:2f:cb:61:aa:22", 77, "Linux" },
                    { 88, "95:bc:c6:42:a7:76", 71, "Linux" },
                    { 84, "56:35:b8:5d:91:7a", 71, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 35, 27, new DateTime(2018, 8, 9, 1, 51, 0, 148, DateTimeKind.Local), "Perferendis est provident.", "febeb402-29c2-411f-a6a6-4377e9b55835", false },
                    { 38, 24, new DateTime(2018, 8, 9, 6, 27, 58, 998, DateTimeKind.Local), "Eveniet aspernatur sit dignissimos.", "8668b4f7-ba1a-464d-8b3a-3258ee90be2c", false },
                    { 39, 26, new DateTime(2018, 8, 9, 12, 37, 59, 618, DateTimeKind.Local), "Libero possimus ut sequi harum.", "07073d56-481a-4e97-9ae2-9ff377492a8a", false },
                    { 34, 26, new DateTime(2018, 8, 9, 11, 33, 23, 393, DateTimeKind.Local), "Esse quo magni excepturi aut sunt repellat consequatur molestias accusantium.", "8668b4f7-ba1a-464d-8b3a-3258ee90be2c", true },
                    { 33, 26, new DateTime(2018, 8, 8, 15, 7, 38, 605, DateTimeKind.Local), "Tempora asperiores aut.", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", false },
                    { 32, 25, new DateTime(2018, 8, 8, 18, 44, 9, 17, DateTimeKind.Local), "Qui beatae est.", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", true },
                    { 31, 21, new DateTime(2018, 8, 9, 8, 33, 24, 212, DateTimeKind.Local), "Facilis ea atque inventore iusto tenetur non labore.", "be1d775a-e864-4389-a1de-b182cfb36d11", true },
                    { 40, 23, new DateTime(2018, 8, 9, 3, 46, 59, 301, DateTimeKind.Local), "Nemo esse nobis dolores iure qui.", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", false },
                    { 36, 27, new DateTime(2018, 8, 9, 5, 28, 58, 546, DateTimeKind.Local), "Praesentium facere et esse commodi quis et.", "b05710a2-28da-4da2-9acb-cd549be125ee", true },
                    { 37, 28, new DateTime(2018, 8, 9, 11, 44, 47, 303, DateTimeKind.Local), "Velit aut eius eos dolorem vitae voluptatem sint.", "ca404c18-30b5-4013-870a-3b985772b799", false }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 116, new DateTime(2018, 8, 9, 10, 37, 11, 576, DateTimeKind.Local), 14, null, "Necessitatibus dolor odio debitis temporibus et doloremque.", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567" },
                    { 117, new DateTime(2018, 8, 9, 0, 15, 20, 339, DateTimeKind.Local), 15, null, "Ullam in sint aut quod ab earum aut sequi illo.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 111, new DateTime(2018, 8, 8, 14, 37, 52, 574, DateTimeKind.Local), 14, null, "Ab molestiae nihil autem rerum nostrum ad.", "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 118, new DateTime(2018, 8, 9, 13, 37, 5, 218, DateTimeKind.Local), 19, null, "Velit sed doloremque dolorem voluptas qui.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 115, new DateTime(2018, 8, 8, 14, 38, 7, 685, DateTimeKind.Local), 12, null, "Ex et dolorem quisquam nostrum error odio quod eius architecto.", "8668b4f7-ba1a-464d-8b3a-3258ee90be2c" },
                    { 114, new DateTime(2018, 8, 9, 8, 33, 24, 617, DateTimeKind.Local), 13, null, "Est iure quo ducimus odit autem voluptate est aut praesentium.", "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 119, new DateTime(2018, 8, 8, 19, 0, 4, 795, DateTimeKind.Local), 20, null, "Aut sit quis nesciunt ut repudiandae consectetur laborum omnis.", "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 120, new DateTime(2018, 8, 9, 7, 25, 54, 976, DateTimeKind.Local), 20, null, "Itaque deleniti voluptatem ab inventore sit provident.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 112, new DateTime(2018, 8, 9, 12, 17, 11, 452, DateTimeKind.Local), 17, null, "Natus omnis nulla et unde expedita quo perferendis.", "07073d56-481a-4e97-9ae2-9ff377492a8a" },
                    { 113, new DateTime(2018, 8, 9, 9, 57, 18, 307, DateTimeKind.Local), 18, null, "Sed ullam necessitatibus modi aspernatur voluptate accusantium error.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 8, 8, 23, 29, 17, 504, DateTimeKind.Local), 41, "Explicabo pariatur et eaque.", "8668b4f7-ba1a-464d-8b3a-3258ee90be2c" },
                    { 60, new DateTime(2018, 8, 8, 21, 1, 23, 738, DateTimeKind.Local), 49, "Dicta labore ut.", "b05710a2-28da-4da2-9acb-cd549be125ee" },
                    { 51, new DateTime(2018, 8, 8, 21, 9, 15, 404, DateTimeKind.Local), 47, "Non architecto aperiam incidunt eaque voluptatum.", "febeb402-29c2-411f-a6a6-4377e9b55835" },
                    { 52, new DateTime(2018, 8, 9, 1, 14, 11, 713, DateTimeKind.Local), 45, "Voluptas occaecati beatae laborum et ut architecto non earum.", "b0560ef3-3c5d-4f55-a63f-77a4b91a0567" },
                    { 54, new DateTime(2018, 8, 9, 9, 44, 53, 129, DateTimeKind.Local), 48, "Eum autem natus consequatur voluptatum voluptate.", "8494cede-b032-4d27-9e14-76b53134d093" },
                    { 56, new DateTime(2018, 8, 9, 12, 5, 21, 233, DateTimeKind.Local), 44, "Qui dolores et.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" },
                    { 57, new DateTime(2018, 8, 9, 13, 38, 27, 581, DateTimeKind.Local), 43, "Est dicta consequatur amet est distinctio ut.", "02fd40d4-7d38-402e-b77b-06d76ccdb5d3" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "be1d775a-e864-4389-a1de-b182cfb36d11", 78 },
                    { "8668b4f7-ba1a-464d-8b3a-3258ee90be2c", 75 },
                    { "02fd40d4-7d38-402e-b77b-06d76ccdb5d3", 79 },
                    { "a869a697-3585-49ae-9745-77614d6c803a", 79 },
                    { "b05710a2-28da-4da2-9acb-cd549be125ee", 73 },
                    { "ca404c18-30b5-4013-870a-3b985772b799", 71 },
                    { "b0560ef3-3c5d-4f55-a63f-77a4b91a0567", 77 },
                    { "07073d56-481a-4e97-9ae2-9ff377492a8a", 77 },
                    { "8494cede-b032-4d27-9e14-76b53134d093", 76 },
                    { "febeb402-29c2-411f-a6a6-4377e9b55835", 79 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 100, new DateTime(2018, 8, 8, 16, 12, 16, 619, DateTimeKind.Local), 88, "Title428" },
                    { 96, new DateTime(2018, 8, 9, 12, 57, 45, 810, DateTimeKind.Local), 87, "Title74" },
                    { 99, new DateTime(2018, 8, 9, 11, 21, 15, 709, DateTimeKind.Local), 87, "Title707" },
                    { 93, new DateTime(2018, 8, 9, 6, 14, 0, 38, DateTimeKind.Local), 81, "Title781" },
                    { 92, new DateTime(2018, 8, 8, 17, 25, 39, 16, DateTimeKind.Local), 86, "Title164" },
                    { 94, new DateTime(2018, 8, 8, 16, 4, 58, 947, DateTimeKind.Local), 86, "Title847" },
                    { 95, new DateTime(2018, 8, 9, 0, 11, 49, 148, DateTimeKind.Local), 86, "Title753" },
                    { 97, new DateTime(2018, 8, 9, 1, 28, 17, 350, DateTimeKind.Local), 86, "Title239" },
                    { 91, new DateTime(2018, 8, 9, 9, 3, 46, 965, DateTimeKind.Local), 82, "Title645" },
                    { 98, new DateTime(2018, 8, 8, 15, 11, 22, 770, DateTimeKind.Local), 82, "Title692" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 101, 100, "MostLoaded1", "Common3", "Source1", 14, 1 },
                    { 102, 96, "MostLoaded3", "Common2", "Source1", 48, 0 },
                    { 105, 93, "MostLoaded2", "Common1", "Source2", 21, 2 },
                    { 107, 93, "MostLoaded1", "Common3", "Source2", 31, 0 },
                    { 104, 92, "MostLoaded1", "Common3", "Source3", 35, 2 },
                    { 106, 92, "MostLoaded1", "Common2", "Source1", 85, 0 },
                    { 110, 94, "MostLoaded1", "Common3", "Source3", 0, 2 },
                    { 108, 95, "MostLoaded2", "Common1", "Source3", 40, 0 },
                    { 103, 97, "MostLoaded1", "Common1", "Source1", 91, 1 },
                    { 109, 91, "MostLoaded1", "Common1", "Source2", 81, 1 }
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
