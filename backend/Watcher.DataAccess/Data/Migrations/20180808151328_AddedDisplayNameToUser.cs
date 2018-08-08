using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedDisplayNameToUser : Migration
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
                name: "NotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    IsMute = table.Column<bool>(nullable: false),
                    IsDisable = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationSettings_Users_UserId1",
                        column: x => x.UserId1,
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
                columns: new[] { "Id", "IsDisable", "IsMute", "Type", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, true, true, 0, 0, null },
                    { 2, false, false, 1, 0, null },
                    { 3, false, true, 0, 0, null },
                    { 4, true, true, 0, 0, null },
                    { 5, false, false, 0, 0, null },
                    { 6, true, false, 0, 0, null },
                    { 7, true, true, 0, 0, null },
                    { 8, true, true, 0, 0, null },
                    { 9, true, true, 0, 0, null },
                    { 10, false, true, 1, 0, null }
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
                    { 61, "White", "Helvetica", "Theme261" },
                    { 62, "Gray", "Frutiger", "Theme287" },
                    { 63, "White", "Frutiger", "Theme603" },
                    { 64, "Gray", "Trade", "Theme818" },
                    { 65, "Yellow", "Frutiger", "Theme245" },
                    { 66, "White", "Frutiger", "Theme129" },
                    { 67, "Gray", "Univers", "Theme975" },
                    { 68, "Yellow", "Univers", "Theme299" },
                    { 69, "White", "Trade", "Theme527" },
                    { 70, "Gray", "Frutiger", "Theme105" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "ThemeId" },
                values: new object[,]
                {
                    { 75, "Company192", 70 },
                    { 78, "Company984", 69 },
                    { 73, "Company678", 69 },
                    { 74, "Company233", 68 },
                    { 71, "Company899", 66 },
                    { 76, "Company773", 65 },
                    { 79, "Company177", 62 },
                    { 77, "Company115", 61 },
                    { 72, "Company134", 61 },
                    { 80, "Company25", 69 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "8e70d16d-c344-43d2-a917-0a0e087c8b5a", new DateTime(2018, 8, 7, 21, 37, 36, 351, DateTimeKind.Local), "Tommie", "Gerson.Dare@hotmail.com", "Woodrow", true, 2, "Grimes" },
                    { "3008686f-a95c-4e25-b0f7-1ac58ccccefe", new DateTime(2018, 8, 7, 22, 5, 14, 166, DateTimeKind.Local), "Spencer", "Else.Kunde73@yahoo.com", "Federico", false, 2, "Tromp" },
                    { "28d9560d-e2f2-409e-bc0e-8864ea939882", new DateTime(2018, 8, 8, 17, 3, 45, 697, DateTimeKind.Local), "Ethelyn", "Rhiannon_Breitenberg38@gmail.com", "Jan", true, 2, "Rau" },
                    { "5282bfd7-5a16-4bc0-92d2-354a14217853", new DateTime(2018, 8, 8, 8, 21, 32, 799, DateTimeKind.Local), "Mateo", "Lorena_Blanda@hotmail.com", "Armani", false, 1, "Doyle" },
                    { "04db4214-f5bb-4449-a4eb-cc485c03244f", new DateTime(2018, 8, 8, 16, 51, 25, 653, DateTimeKind.Local), "Maude", "Lorenz47@hotmail.com", "Lora", true, 1, "Quitzon" },
                    { "de8f0970-c1bc-4072-9c76-a5e598e3d6e4", new DateTime(2018, 8, 8, 9, 41, 47, 297, DateTimeKind.Local), "Micah", "Gerson62@hotmail.com", "Keaton", false, 1, "Hilpert" },
                    { "a257c7de-ea3b-4c26-ace2-68b0d490577b", new DateTime(2018, 8, 7, 23, 9, 49, 597, DateTimeKind.Local), "Sigrid", "Kurt58@hotmail.com", "Ross", true, 1, "Herzog" },
                    { "87f77ff4-670d-4715-9831-a703e38d52ca", new DateTime(2018, 8, 8, 7, 57, 12, 296, DateTimeKind.Local), "Sylvan", "Leonor.Graham9@gmail.com", "Rowland", false, 1, "Nader" },
                    { "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", new DateTime(2018, 8, 8, 5, 58, 59, 864, DateTimeKind.Local), "Gideon", "Ardith.Torp@yahoo.com", "Chadd", true, 2, "Kessler" },
                    { "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", new DateTime(2018, 8, 8, 16, 54, 26, 920, DateTimeKind.Local), "Jaylen", "Kyla95@gmail.com", "Jarrod", true, 1, "Stehr" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 25, "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", "est", null, 0 },
                    { 30, "8e70d16d-c344-43d2-a917-0a0e087c8b5a", "nemo", null, 0 },
                    { 24, "8e70d16d-c344-43d2-a917-0a0e087c8b5a", "officia", null, 0 },
                    { 28, "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", "et", null, 0 },
                    { 26, "a257c7de-ea3b-4c26-ace2-68b0d490577b", "voluptas", null, 0 },
                    { 22, "a257c7de-ea3b-4c26-ace2-68b0d490577b", "totam", null, 0 },
                    { 21, "04db4214-f5bb-4449-a4eb-cc485c03244f", "illum", null, 0 },
                    { 27, "87f77ff4-670d-4715-9831-a703e38d52ca", "illum", null, 0 },
                    { 23, "87f77ff4-670d-4715-9831-a703e38d52ca", "aut", null, 0 },
                    { 29, "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", "consectetur", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 49, new DateTime(2018, 8, 8, 10, 49, 39, 119, DateTimeKind.Local), null, "Iure dolores officia nesciunt asperiores occaecati quisquam inventore ratione.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 41, new DateTime(2018, 8, 8, 5, 33, 1, 298, DateTimeKind.Local), null, "Voluptatibus voluptate repellat voluptates aliquid quaerat facilis cupiditate iusto accusamus.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 47, new DateTime(2018, 8, 7, 23, 54, 44, 720, DateTimeKind.Local), null, "Quisquam fugiat laudantium velit.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 45, new DateTime(2018, 8, 8, 14, 7, 30, 856, DateTimeKind.Local), null, "Et sed qui est repellat sed molestiae.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 44, new DateTime(2018, 8, 8, 12, 13, 30, 475, DateTimeKind.Local), null, "Velit incidunt sed consequatur quia exercitationem numquam dolor dolores.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 48, new DateTime(2018, 8, 8, 2, 22, 30, 313, DateTimeKind.Local), null, "Dolores praesentium repellendus modi deleniti quod saepe quia rerum.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 43, new DateTime(2018, 8, 8, 15, 48, 46, 720, DateTimeKind.Local), null, "Non eum quisquam eos porro saepe rerum eos.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 50, new DateTime(2018, 8, 7, 19, 39, 30, 851, DateTimeKind.Local), null, "Quisquam saepe necessitatibus aut.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 42, new DateTime(2018, 8, 8, 5, 10, 14, 614, DateTimeKind.Local), null, "Quis quo consectetur rerum tenetur eaque ad id inventore labore.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 46, new DateTime(2018, 8, 7, 20, 58, 6, 500, DateTimeKind.Local), null, "Facilis quae vel aut sunt sequi harum consectetur odit amet.", "de8f0970-c1bc-4072-9c76-a5e598e3d6e4" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 84, "ea:09:b0:f5:8e:ec", 77, "Linux" },
                    { 88, "18:81:da:b2:46:fa", 71, "Linux" },
                    { 90, "b0:af:03:c1:12:f5", 72, "Windows" },
                    { 89, "dd:74:7b:7c:be:1b", 72, "Windows" },
                    { 85, "0d:94:12:18:0e:a7", 72, "Windows" },
                    { 82, "f0:84:8d:89:10:d1", 73, "Linux" },
                    { 86, "68:e0:2c:92:82:72", 73, "Linux" },
                    { 87, "f9:57:02:26:72:6a", 71, "Windows" },
                    { 83, "1a:df:7e:6b:a1:3f", 76, "Windows" },
                    { 81, "e1:a0:23:c5:bb:f7", 80, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 120, new DateTime(2018, 8, 7, 22, 13, 31, 533, DateTimeKind.Local), 8, null, "Doloribus rerum dolor.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0" },
                    { 119, new DateTime(2018, 8, 8, 16, 20, 47, 373, DateTimeKind.Local), 3, null, "Ut odio maiores voluptate aut.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0" },
                    { 114, new DateTime(2018, 8, 8, 2, 7, 30, 988, DateTimeKind.Local), 8, null, "Est qui vel.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 116, new DateTime(2018, 8, 8, 6, 20, 7, 50, DateTimeKind.Local), 8, null, "Cumque quia dolores deserunt libero unde ut.", "5282bfd7-5a16-4bc0-92d2-354a14217853" },
                    { 112, new DateTime(2018, 8, 7, 19, 21, 31, 714, DateTimeKind.Local), 10, null, "Dolorem vel ab dignissimos aliquid ut iusto dolor quis quam.", "a257c7de-ea3b-4c26-ace2-68b0d490577b" },
                    { 115, new DateTime(2018, 8, 8, 1, 57, 43, 99, DateTimeKind.Local), 3, null, "Atque quas aut placeat non modi ipsam unde harum sit.", "a257c7de-ea3b-4c26-ace2-68b0d490577b" },
                    { 117, new DateTime(2018, 8, 8, 17, 36, 3, 729, DateTimeKind.Local), 10, null, "Eum quos maxime velit et placeat cupiditate iusto sit quis.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 111, new DateTime(2018, 8, 8, 14, 41, 6, 217, DateTimeKind.Local), 9, null, "Totam incidunt cum tempora.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 113, new DateTime(2018, 8, 8, 12, 9, 47, 989, DateTimeKind.Local), 6, null, "Non quas minus iste et enim aut sit sint.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 118, new DateTime(2018, 8, 8, 1, 26, 38, 335, DateTimeKind.Local), 6, null, "Sit repellat laudantium.", "de8f0970-c1bc-4072-9c76-a5e598e3d6e4" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "3008686f-a95c-4e25-b0f7-1ac58ccccefe", 73 },
                    { "de8f0970-c1bc-4072-9c76-a5e598e3d6e4", 74 },
                    { "87f77ff4-670d-4715-9831-a703e38d52ca", 74 },
                    { "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", 76 },
                    { "5282bfd7-5a16-4bc0-92d2-354a14217853", 77 },
                    { "04db4214-f5bb-4449-a4eb-cc485c03244f", 77 },
                    { "a257c7de-ea3b-4c26-ace2-68b0d490577b", 77 },
                    { "28d9560d-e2f2-409e-bc0e-8864ea939882", 72 },
                    { "8e70d16d-c344-43d2-a917-0a0e087c8b5a", 76 },
                    { "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", 73 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 93, new DateTime(2018, 8, 8, 7, 44, 4, 222, DateTimeKind.Local), 81, "Title639" },
                    { 94, new DateTime(2018, 8, 8, 6, 34, 19, 700, DateTimeKind.Local), 86, "Title549" },
                    { 100, new DateTime(2018, 8, 7, 22, 24, 1, 236, DateTimeKind.Local), 82, "Title601" },
                    { 95, new DateTime(2018, 8, 8, 14, 25, 6, 498, DateTimeKind.Local), 88, "Title430" },
                    { 92, new DateTime(2018, 8, 8, 6, 12, 15, 765, DateTimeKind.Local), 87, "Title215" },
                    { 96, new DateTime(2018, 8, 7, 22, 49, 8, 122, DateTimeKind.Local), 83, "Title52" },
                    { 99, new DateTime(2018, 8, 8, 8, 55, 33, 516, DateTimeKind.Local), 90, "Title136" },
                    { 91, new DateTime(2018, 8, 8, 2, 1, 38, 260, DateTimeKind.Local), 90, "Title467" },
                    { 97, new DateTime(2018, 8, 8, 4, 42, 50, 405, DateTimeKind.Local), 85, "Title867" },
                    { 98, new DateTime(2018, 8, 8, 11, 52, 46, 275, DateTimeKind.Local), 86, "Title759" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 36, 30, new DateTime(2018, 8, 8, 13, 48, 0, 876, DateTimeKind.Local), "Ipsam nemo repellat non est qui pariatur voluptatum.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe", true },
                    { 39, 28, new DateTime(2018, 8, 7, 21, 48, 3, 998, DateTimeKind.Local), "Nesciunt et vitae commodi voluptas quia qui laudantium.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", true },
                    { 33, 21, new DateTime(2018, 8, 7, 20, 15, 3, 172, DateTimeKind.Local), "Ratione explicabo fugit similique assumenda reprehenderit.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a", true },
                    { 38, 27, new DateTime(2018, 8, 8, 14, 36, 22, 130, DateTimeKind.Local), "Sed et est officia temporibus voluptatem at error molestiae molestiae.", "28d9560d-e2f2-409e-bc0e-8864ea939882", true },
                    { 35, 27, new DateTime(2018, 8, 8, 16, 14, 17, 433, DateTimeKind.Local), "Non dolor ducimus ut aut.", "28d9560d-e2f2-409e-bc0e-8864ea939882", false },
                    { 37, 23, new DateTime(2018, 8, 8, 9, 21, 26, 18, DateTimeKind.Local), "Commodi incidunt incidunt.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", false },
                    { 40, 29, new DateTime(2018, 8, 7, 23, 36, 22, 505, DateTimeKind.Local), "Sunt eius quo dignissimos et.", "a257c7de-ea3b-4c26-ace2-68b0d490577b", false },
                    { 34, 29, new DateTime(2018, 8, 7, 23, 0, 23, 633, DateTimeKind.Local), "Suscipit aut aut sequi sit vero sunt.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe", false },
                    { 32, 28, new DateTime(2018, 8, 8, 11, 13, 5, 258, DateTimeKind.Local), "Adipisci adipisci quo quis iure ipsum et iure aut.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", true },
                    { 31, 25, new DateTime(2018, 8, 8, 10, 2, 36, 403, DateTimeKind.Local), "Deleniti quo blanditiis sunt.", "a257c7de-ea3b-4c26-ace2-68b0d490577b", false }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 8, 8, 14, 36, 39, 998, DateTimeKind.Local), 45, "Et suscipit enim illo consequuntur labore.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe" },
                    { 58, new DateTime(2018, 8, 8, 5, 34, 14, 607, DateTimeKind.Local), 44, "Qui sint nostrum ut saepe qui fuga voluptas.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 55, new DateTime(2018, 8, 8, 13, 50, 12, 153, DateTimeKind.Local), 43, "Recusandae nesciunt ut ut veritatis eveniet sed.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 57, new DateTime(2018, 8, 8, 10, 50, 41, 893, DateTimeKind.Local), 47, "Omnis quasi optio sequi neque reiciendis sit laborum.", "5282bfd7-5a16-4bc0-92d2-354a14217853" },
                    { 60, new DateTime(2018, 8, 8, 17, 44, 25, 390, DateTimeKind.Local), 41, "Corrupti doloribus velit delectus.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 108, 99, "MostLoaded3", "Common2", "Source1", 34, 1 },
                    { 105, 96, "MostLoaded3", "Common3", "Source1", 16, 1 },
                    { 101, 92, "MostLoaded3", "Common3", "Source2", 93, 0 },
                    { 103, 95, "MostLoaded1", "Common1", "Source3", 50, 2 },
                    { 110, 95, "MostLoaded3", "Common1", "Source3", 61, 1 },
                    { 102, 100, "MostLoaded1", "Common2", "Source2", 15, 1 },
                    { 107, 100, "MostLoaded3", "Common3", "Source1", 77, 1 },
                    { 109, 98, "MostLoaded1", "Common3", "Source1", 19, 2 },
                    { 104, 93, "MostLoaded2", "Common1", "Source1", 3, 2 },
                    { 106, 93, "MostLoaded1", "Common2", "Source3", 5, 1 }
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
                name: "IX_NotificationSettings_UserId1",
                table: "NotificationSettings",
                column: "UserId1");

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
