using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class UserToChatManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "309927ed-5909-456b-96cb-5536bc2574f7", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6932c7c0-3ad8-4c5f-8724-81e11290e682", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b5a291b2-0388-4889-a80d-83ff74c8a91e", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "309927ed-5909-456b-96cb-5536bc2574f7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6932c7c0-3ad8-4c5f-8724-81e11290e682");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ba19cd3-676f-4085-a76e-f9cbce0b0e05");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "914d28ca-74fd-4004-8a3d-d2ff3640b6ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "95e7c831-ac94-4b80-a1e3-e3cba23b475c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b5a291b2-0388-4889-a80d-83ff74c8a91e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e006ee95-72b3-4833-b5e3-2ece6aaf41d8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550");

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
                    table.ForeignKey(
                        name: "FK_UserChat_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChat_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common2", "Source1", 39, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", "Source2", 30, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "Common2", "Source2", 25, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", "Common2", "Source2", 18, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Common3", "Source3", 52, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Common1", "Source2", 64, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Common3", "Source2", 82, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "Common2", 48, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded3", "Common1", "Source3", 52 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", 55, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 6, 19, 2, 503, DateTimeKind.Local), 85, "Title988" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 0, 43, 12, 168, DateTimeKind.Local), 89, "Title397" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 46, 44, 217, DateTimeKind.Local), 87, "Title446" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 6, 47, 28, 802, DateTimeKind.Local), 88, "Title785" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 9, 8, 12, 339, DateTimeKind.Local), "Title418" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 4, 30, 11, DateTimeKind.Local), "Title354" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 56, 37, 816, DateTimeKind.Local), 88, "Title820" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 49, 47, 507, DateTimeKind.Local), 82, "Title744" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 25, 41, 467, DateTimeKind.Local), 84, "Title40" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 5, 35, 948, DateTimeKind.Local), 90, "Title411" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "55:55:be:e4:c7:d7", "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "14:bf:f7:36:a3:2e", 76, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "c2:cd:0f:45:87:09", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "67:9f:ad:e7:6c:d4", 77, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "89:3d:1c:e1:f6:48", 79 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f0:68:e1:e6:a9:6a", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                column: "Address",
                value: "77:06:94:b6:d8:17");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "3c:2d:7c:28:29:85", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "0d:4e:ad:66:11:a5", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "ea:1a:54:1e:27:32", 80, "Windows" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme489" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme314" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme416" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme51" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme95" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme611" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme846" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme506" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme618" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme783" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", null, new DateTime(2018, 8, 13, 11, 56, 33, 5, DateTimeKind.Local), "Sylvan", "Myrna.Conn33@hotmail.com", "Hiram", true, "Wyman", null, 1 },
                    { "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab", null, new DateTime(2018, 8, 13, 6, 46, 32, 810, DateTimeKind.Local), "Kristoffer", "Marlee.Schuster@yahoo.com", "Maurine", true, "Mayer", null, 2 },
                    { "021c0ca4-7514-4eed-b6b8-8d80120af65d", null, new DateTime(2018, 8, 13, 19, 43, 34, 182, DateTimeKind.Local), "Amina", "Casimer.Thiel9@yahoo.com", "Nedra", true, "Maggio", null, 2 },
                    { "a6e636ed-f426-40e7-a563-781ab2935614", null, new DateTime(2018, 8, 13, 13, 50, 18, 123, DateTimeKind.Local), "Abbey", "Franco.Bahringer86@gmail.com", "Liza", true, "Zboncak", null, 1 },
                    { "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec", null, new DateTime(2018, 8, 13, 21, 6, 31, 630, DateTimeKind.Local), "Carter", "Edyth47@gmail.com", "Alfreda", true, "Bogan", null, 1 },
                    { "9cb75417-2d81-4a82-83e1-ce586bbdf6b6", null, new DateTime(2018, 8, 13, 3, 11, 14, 255, DateTimeKind.Local), "Mark", "Russ.Dickens@yahoo.com", "Vinnie", true, "Balistreri", null, 2 },
                    { "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59", null, new DateTime(2018, 8, 13, 5, 9, 53, 631, DateTimeKind.Local), "Maudie", "Kylee.McClure@gmail.com", "Dedrick", true, "Hand", null, 2 },
                    { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", null, new DateTime(2018, 8, 13, 10, 12, 42, 995, DateTimeKind.Local), "Kamryn", "June_Wisoky@gmail.com", "Asa", true, "Stracke", null, 1 },
                    { "23afff5a-f0d1-42e6-978c-09b263e132ac", null, new DateTime(2018, 8, 13, 12, 9, 53, 987, DateTimeKind.Local), "Anastasia", "Malachi80@gmail.com", "Jaleel", true, "Monahan", null, 2 },
                    { "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", null, new DateTime(2018, 8, 13, 9, 39, 56, 732, DateTimeKind.Local), "Wyman", "Cortney.Rath@hotmail.com", "Delores", true, "Walker", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "23afff5a-f0d1-42e6-978c-09b263e132ac", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedById",
                value: "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", "modi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", "enim" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec", "enim" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", "magnam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a6e636ed-f426-40e7-a563-781ab2935614", "non" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 20, 44, 346, DateTimeKind.Local), "Sapiente ut ipsam debitis tempora sint.", "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 42, 13, 264, DateTimeKind.Local), "Rerum rem in.", "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 23, 44, 597, DateTimeKind.Local), "Soluta saepe fuga delectus quam officiis magni dicta eos.", "a6e636ed-f426-40e7-a563-781ab2935614" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 6, 1, 439, DateTimeKind.Local), "Sit voluptas et voluptatum iste animi consectetur dolorum velit atque.", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 22, 14, 785, DateTimeKind.Local), "Molestiae sed ut architecto velit necessitatibus enim aut.", "a6e636ed-f426-40e7-a563-781ab2935614" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 14, 45, 120, DateTimeKind.Local), "Veniam cum dolor excepturi eum voluptatem blanditiis.", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 57, 16, 883, DateTimeKind.Local), "Et quia sit rem repudiandae et et.", "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 16, 53, 27, DateTimeKind.Local), "Porro libero nemo asperiores.", "23afff5a-f0d1-42e6-978c-09b263e132ac" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 14, 35, 324, DateTimeKind.Local), "Ducimus est aperiam.", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 28, 44, 911, DateTimeKind.Local), "Quia consectetur aut illum cum autem ratione accusantium voluptas eaque.", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 13, 2, 26, 45, 15, DateTimeKind.Local), "Animi culpa voluptas qui laboriosam fuga adipisci saepe.", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 13, 5, 56, 7, 718, DateTimeKind.Local), "Quis nobis facilis commodi odio et rerum.", "a6e636ed-f426-40e7-a563-781ab2935614", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 13, 4, 4, 59, 501, DateTimeKind.Local), "Et voluptas enim facilis iure praesentium corporis ipsam.", "23afff5a-f0d1-42e6-978c-09b263e132ac", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 13, 9, 17, 35, 508, DateTimeKind.Local), "Odit voluptatibus nobis qui quae non eos possimus aut.", "23afff5a-f0d1-42e6-978c-09b263e132ac" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 13, 13, 50, 54, 340, DateTimeKind.Local), "Iste corrupti atque fugiat repellendus.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 13, 8, 11, 47, 454, DateTimeKind.Local), "Dolore laudantium qui veritatis nihil fuga non consequatur quibusdam sint.", "a6e636ed-f426-40e7-a563-781ab2935614", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 13, 6, 28, 18, 246, DateTimeKind.Local), "Qui deleniti rerum consequatur eos soluta eos quas.", "a6e636ed-f426-40e7-a563-781ab2935614", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 13, 19, 33, 18, 763, DateTimeKind.Local), "Provident ut velit.", "9cb75417-2d81-4a82-83e1-ce586bbdf6b6", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 49, 49, 865, DateTimeKind.Local), "Possimus quibusdam illo sit quia voluptatem maiores.", "021c0ca4-7514-4eed-b6b8-8d80120af65d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 13, 2, 29, 13, 620, DateTimeKind.Local), "Fugit velit sit.", "021c0ca4-7514-4eed-b6b8-8d80120af65d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "a6e636ed-f426-40e7-a563-781ab2935614" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "23afff5a-f0d1-42e6-978c-09b263e132ac" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "23afff5a-f0d1-42e6-978c-09b263e132ac" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 2, "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 6, 37, 256, DateTimeKind.Local), 17, "Officiis vel est sint culpa et.", "9cb75417-2d81-4a82-83e1-ce586bbdf6b6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 14, 10, 18, 367, DateTimeKind.Local), 20, "Qui quis quibusdam sunt minus similique fuga voluptas.", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 49, 45, 835, DateTimeKind.Local), 15, "Illo perspiciatis et vero accusantium temporibus ut nihil sapiente.", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 51, 21, 456, DateTimeKind.Local), 15, "Eaque voluptas occaecati ut vero id eos.", "9cb75417-2d81-4a82-83e1-ce586bbdf6b6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 56, 41, 740, DateTimeKind.Local), 11, "Cum officiis fugit enim.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 2, 9, 247, DateTimeKind.Local), 13, "Quos architecto voluptas incidunt illo quisquam animi.", "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 52, 1, 690, DateTimeKind.Local), 18, "Non voluptatem autem quas optio est aut in similique.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 18, 7, 7, 1, DateTimeKind.Local), 15, "Consequuntur harum sit sequi cum deserunt et.", "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 41, 15, 869, DateTimeKind.Local), 14, "Excepturi impedit laborum totam perspiciatis aliquam rerum deleniti placeat qui.", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 19, 3, 34, 448, DateTimeKind.Local), 13, "Esse qui nihil consequuntur corrupti.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "874-752-4800 x10226", "021c0ca4-7514-4eed-b6b8-8d80120af65d", "", "Luis32@gmail.com", "Company970", 64, "http://maximus.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "663.619.8203 x36238", "23afff5a-f0d1-42e6-978c-09b263e132ac", "", "Letha.McKenzie83@yahoo.com", "Company350", 64, "https://agustina.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-820-545-3906 x1039", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", "Reprehenderit enim eaque blanditiis doloribus dolores iusto voluptate sapiente aut. Facere inventore aut rerum.", "Quinten.Heidenreich22@gmail.com", "Company579", 63, "http://sydnie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "233-538-7857", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", "Eos ab libero. Quidem aut explicabo quibusdam quia. Et vel porro in quia quam qui vel.", "Freeda.Eichmann64@hotmail.com", "Company306", 69, "https://elouise.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "685.911.8002 x0823", "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec", "Quod distinctio autem ab quo quidem qui deleniti. Aspernatur exercitationem excepturi magnam qui tenetur. Fugit tenetur atque et rerum quasi aut labore. Consequatur inventore laborum odio ut nam aut pariatur quod alias.", "Gail_Stanton@hotmail.com", "Company540", 68, "http://ashlynn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(473) 585-7661 x09520", "021c0ca4-7514-4eed-b6b8-8d80120af65d", "Veniam distinctio excepturi eos voluptatum repellat. Eveniet sed nemo. Ab earum aliquid et illo quia aliquid. Dolorem sit magni.", "Braden6@hotmail.com", "Company40", 70, "https://eva.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "777-336-4322 x6774", "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab", "Vero maiores sed aut sequi vel. Consequatur facilis nihil fugit maxime ipsum qui. Aut nemo maxime hic. Et similique distinctio amet eveniet temporibus voluptatem placeat nihil.", "Victor_Cremin@yahoo.com", "Company329", 68, "http://araceli.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-961-680-6304", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", "Andre_Hane44@hotmail.com", "Company511", 63, "http://merl.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "407-926-1446", "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59", "Et nesciunt maxime inventore. Quod perferendis enim doloribus assumenda repellat accusantium sit. Rerum non eum.", "Freddy.Hermann51@gmail.com", "Company328", 64, "https://leda.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(829) 771-0079 x512", "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", "Asperiores dignissimos numquam impedit ipsum libero et consequatur quod sapiente. Et harum nihil odit repellat dolorem laboriosam sint.", "Justen_Brown@hotmail.com", "Company921", 64, "https://rosella.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 22, 50, 290, DateTimeKind.Local), 49, "Vitae animi dolores sunt rerum praesentium.", "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 7, 22, 824, DateTimeKind.Local), 46, "Consequatur temporibus dolor sapiente magnam aut est.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 26, 55, 134, DateTimeKind.Local), 43, "Vero veniam aperiam voluptatibus.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 11, 0, 715, DateTimeKind.Local), 45, "Debitis harum enim et.", "efca6a8e-e5bb-4257-a8b9-ab6045880b0d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 22, 37, 844, DateTimeKind.Local), 41, "Natus qui praesentium alias pariatur dignissimos sunt excepturi doloremque dolores.", "23afff5a-f0d1-42e6-978c-09b263e132ac" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 18, 57, 44, 675, DateTimeKind.Local), 45, "Sequi suscipit eum ad.", "a6e636ed-f426-40e7-a563-781ab2935614" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 12, 15, 534, DateTimeKind.Local), 50, "Est id est.", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 5, 10, 607, DateTimeKind.Local), 42, "Quisquam aliquam dolor.", "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 29, 32, 965, DateTimeKind.Local), 49, "Labore ut quis velit impedit occaecati.", "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 49, 0, 732, DateTimeKind.Local), 41, "Nesciunt est deleniti itaque soluta.", "9cb75417-2d81-4a82-83e1-ce586bbdf6b6" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", 78 },
                    { "9cb75417-2d81-4a82-83e1-ce586bbdf6b6", 74 },
                    { "23afff5a-f0d1-42e6-978c-09b263e132ac", 75 },
                    { "021c0ca4-7514-4eed-b6b8-8d80120af65d", 74 },
                    { "a6e636ed-f426-40e7-a563-781ab2935614", 75 },
                    { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", 76 },
                    { "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec", 75 },
                    { "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59", 71 },
                    { "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab", 71 },
                    { "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", 75 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserChat_ChatId",
                table: "UserChat",
                column: "ChatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChat");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "021c0ca4-7514-4eed-b6b8-8d80120af65d", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "23afff5a-f0d1-42e6-978c-09b263e132ac", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9cb75417-2d81-4a82-83e1-ce586bbdf6b6", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a6e636ed-f426-40e7-a563-781ab2935614", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "efca6a8e-e5bb-4257-a8b9-ab6045880b0d", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "021c0ca4-7514-4eed-b6b8-8d80120af65d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23afff5a-f0d1-42e6-978c-09b263e132ac");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2694f6d1-632b-4ed0-b323-bcb9a0fa0f59");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94cfe29d-5887-4ceb-8edc-c75c7b2cc5ab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9cb75417-2d81-4a82-83e1-ce586bbdf6b6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9ef82bb3-bf25-4e1e-871d-296cfe4d22fc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a6e636ed-f426-40e7-a563-781ab2935614");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cbfcb26c-f544-482a-9e85-fc51a5d0d0d1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efca6a8e-e5bb-4257-a8b9-ab6045880b0d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f1ecbf2e-6a6e-40af-beeb-acfc328fc9ec");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common3", "Source3", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", "Source3", 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Common1", "Source3", 59, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", "Common1", "Source1", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", "Common1", "Source1", 89, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", "Common3", "Source3", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded3", "Common2", "Source1", 40, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 95, "Common1", 45, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 94, "MostLoaded2", "Common2", "Source1", 18 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded1", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 23, 17, 693, DateTimeKind.Local), 90, "Title11" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 14, 24, 185, DateTimeKind.Local), 90, "Title765" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 19, 1, 717, DateTimeKind.Local), 86, "Title982" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 38, 16, 604, DateTimeKind.Local), 83, "Title612" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 42, 11, 172, DateTimeKind.Local), "Title547" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 6, 30, 3, 737, DateTimeKind.Local), "Title958" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 49, 56, 577, DateTimeKind.Local), 90, "Title850" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 21, 37, 392, DateTimeKind.Local), 88, "Title309" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 4, 20, 765, DateTimeKind.Local), 89, "Title572" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 2, 56, 464, DateTimeKind.Local), 88, "Title422" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "06:33:a4:c4:77:5d", "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e2:96:8b:82:eb:17", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "bc:c0:26:27:de:9f", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "b4:a0:d2:d4:8e:b5", 80, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "3d:08:45:33:de:f3", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "22:21:f2:83:db:b1", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                column: "Address",
                value: "de:ca:4c:0c:b5:41");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "a1:41:0f:d7:8a:96", 75 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "9f:e6:45:e2:d1:04", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "22:65:05:bd:ac:0e", 76, "Linux" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme325" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme521" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme903" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme613" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme130" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme811" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme668" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme425" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme374" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme417" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", null, new DateTime(2018, 8, 13, 1, 19, 24, 624, DateTimeKind.Local), "Madge", "Selmer22@hotmail.com", "Malvina", true, "Runolfsdottir", null, 2 },
                    { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", null, new DateTime(2018, 8, 13, 10, 5, 14, 586, DateTimeKind.Local), "Letitia", "Kenyatta73@gmail.com", "Carrie", true, "Stokes", null, 2 },
                    { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", null, new DateTime(2018, 8, 14, 0, 10, 21, 526, DateTimeKind.Local), "Roberta", "Krystina_Gleichner@gmail.com", "Vinnie", true, "Kemmer", null, 1 },
                    { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", null, new DateTime(2018, 8, 13, 12, 2, 46, 326, DateTimeKind.Local), "Stacey", "Fidel_Bergnaum@gmail.com", "Chasity", true, "Stracke", null, 1 },
                    { "309927ed-5909-456b-96cb-5536bc2574f7", null, new DateTime(2018, 8, 13, 14, 33, 59, 895, DateTimeKind.Local), "Heaven", "Karley.Schaefer75@gmail.com", "Mac", true, "Bartoletti", null, 2 },
                    { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", null, new DateTime(2018, 8, 13, 9, 40, 2, 634, DateTimeKind.Local), "Emie", "Darien.Waters@gmail.com", "Althea", true, "Stanton", null, 2 },
                    { "b5a291b2-0388-4889-a80d-83ff74c8a91e", null, new DateTime(2018, 8, 13, 12, 10, 8, 424, DateTimeKind.Local), "Nikko", "Elijah_Willms@yahoo.com", "Cali", true, "Emmerich", null, 2 },
                    { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", null, new DateTime(2018, 8, 13, 5, 5, 58, 89, DateTimeKind.Local), "Judd", "Tommie_Armstrong@gmail.com", "Gwendolyn", true, "Farrell", null, 1 },
                    { "6932c7c0-3ad8-4c5f-8724-81e11290e682", null, new DateTime(2018, 8, 13, 21, 17, 21, 45, DateTimeKind.Local), "Lawrence", "Brian.Ankunding@yahoo.com", "Erin", true, "Cartwright", null, 1 },
                    { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", null, new DateTime(2018, 8, 13, 18, 20, 1, 843, DateTimeKind.Local), "Stephania", "Jimmie_Schultz@gmail.com", "Allan", true, "Goodwin", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedById",
                value: "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6932c7c0-3ad8-4c5f-8724-81e11290e682", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "atque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "quidem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "minus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b5a291b2-0388-4889-a80d-83ff74c8a91e", "tempora" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 13, 23, 2, 89, DateTimeKind.Local), "Adipisci nihil beatae rerum ut fuga.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 52, 33, 814, DateTimeKind.Local), "Sed asperiores iusto.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 19, 10, 4, 334, DateTimeKind.Local), "Quia ea nihil blanditiis cumque reprehenderit eum laudantium.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 58, 10, 687, DateTimeKind.Local), "Dolor distinctio voluptatibus voluptas possimus asperiores.", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 33, 8, 116, DateTimeKind.Local), "Voluptate omnis facere error.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 0, 50, 6, 626, DateTimeKind.Local), "Modi rerum recusandae aut provident.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 29, 51, 506, DateTimeKind.Local), "Cumque magnam distinctio unde.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 15, 33, 589, DateTimeKind.Local), "Et saepe fugiat nulla.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 31, 5, 865, DateTimeKind.Local), "Dolor alias corporis suscipit labore.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 38, 51, 840, DateTimeKind.Local), "Eos nisi tempora illo neque culpa minima.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 13, 8, 41, 4, 172, DateTimeKind.Local), "Quos ullam saepe mollitia.", "b5a291b2-0388-4889-a80d-83ff74c8a91e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 13, 0, 22, 8, 584, DateTimeKind.Local), "Reprehenderit est id aut et aperiam facere suscipit non dicta.", "6932c7c0-3ad8-4c5f-8724-81e11290e682", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 13, 7, 17, 43, 455, DateTimeKind.Local), "Libero porro assumenda ipsa aut veniam quia qui voluptatem.", "6932c7c0-3ad8-4c5f-8724-81e11290e682", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 13, 4, 9, 39, 124, DateTimeKind.Local), "Quam voluptatem voluptatem eius nihil.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 7, 19, 35, 824, DateTimeKind.Local), "Fugiat voluptatem qui eaque.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 19, 1, 16, 414, DateTimeKind.Local), "Inventore non nemo debitis tempore at.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 13, 0, 16, 18, 531, DateTimeKind.Local), "Numquam aut officiis aut odit qui dolorem est voluptas.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 13, 4, 30, 42, 239, DateTimeKind.Local), "Non expedita necessitatibus eos enim ipsam neque omnis.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 59, 15, 603, DateTimeKind.Local), "Voluptatum consequatur fugit et rerum eum.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 8, 1, 31, 46, DateTimeKind.Local), "Non voluptatem aut eum aut perspiciatis.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "95e7c831-ac94-4b80-a1e3-e3cba23b475c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 41, 53, 79, DateTimeKind.Local), 16, "Voluptas quae nihil qui omnis accusantium.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 7, 22, 812, DateTimeKind.Local), 19, "Est ullam impedit id ut dignissimos.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 14, 18, 57, 975, DateTimeKind.Local), 12, "Deserunt id eum ea id.", "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 10, 16, 15, 285, DateTimeKind.Local), 18, "Libero mollitia debitis magni tenetur officiis.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 52, 44, 192, DateTimeKind.Local), 19, "Quam molestiae nihil culpa.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 18, 47, 531, DateTimeKind.Local), 18, "Facere est quaerat dolorem iste sint deleniti vero odit.", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 49, 2, 3, DateTimeKind.Local), 12, "Commodi voluptas quas ut.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 25, 37, 202, DateTimeKind.Local), 18, "Qui nobis ipsam est est iusto in dolorem nesciunt.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 58, 23, 280, DateTimeKind.Local), 20, "Voluptates cupiditate eius nulla ipsa a et.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 24, 50, 603, DateTimeKind.Local), 17, "Itaque architecto inventore.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-918-475-4409", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "Similique cupiditate sunt culpa. Sint autem architecto totam eum omnis optio quia enim quas.", "Nils_VonRueden@gmail.com", "Company161", 63, "http://sedrick.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "356.837.2887 x34885", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", "Et totam beatae iusto voluptatem enim. Est possimus similique est dolorem suscipit aut.", "Jared_Zieme24@hotmail.com", "Company802", 66, "https://clinton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "312.638.1775 x95996", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "", "Clementine_Zieme26@yahoo.com", "Company93", 67, "http://elza.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-891-464-1447 x59985", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "Quia voluptatem modi nisi omnis excepturi omnis corrupti ipsam corporis.", "Trey_Sawayn@hotmail.com", "Company551", 66, "http://humberto.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(780) 266-1229 x145", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", "Placeat amet optio. Dolor aliquid repudiandae dicta assumenda. Qui quia eveniet enim.", "Filomena.Sawayn98@yahoo.com", "Company344", 67, "http://genoveva.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "489.571.8576 x030", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "Aut officiis beatae rem numquam sapiente voluptates voluptas quia rerum. Repellat consequatur odit qui officiis expedita asperiores omnis facilis. Eveniet adipisci dolorem accusantium voluptatem id natus rerum. Eius tempore omnis eligendi ut et maxime neque.", "Leilani_Parker@hotmail.com", "Company825", 67, "https://lou.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "412-426-2412 x335", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "Eius cum similique officia. Quos voluptatem neque. Et ex quia rerum pariatur.", "Antonina50@yahoo.com", "Company359", 64, "http://everett.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-806-594-7988 x7692", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "Stanley.Hegmann@gmail.com", "Company215", 67, "http://cielo.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "446-372-7293 x7086", "309927ed-5909-456b-96cb-5536bc2574f7", "Blanditiis consequatur animi amet nihil est. Harum consequuntur quia aut voluptatum debitis.", "Lavada.Pagac24@yahoo.com", "Company849", 67, "http://odessa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "782-579-4679 x1695", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "Quas et eos exercitationem in excepturi porro vitae sed. Consequuntur eum aut ea quia perspiciatis quibusdam. Alias aperiam et.", "Katrina.Muller@yahoo.com", "Company635", 65, "http://anastasia.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 7, 45, 43, 909, DateTimeKind.Local), 48, "Nostrum voluptas veritatis molestias suscipit officia earum ea dolorem.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 10, 16, 51, 636, DateTimeKind.Local), 48, "Nobis eum recusandae odit recusandae.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 36, 27, 58, DateTimeKind.Local), 41, "Ducimus aspernatur reprehenderit.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 17, 41, 38, 773, DateTimeKind.Local), 48, "Distinctio officia temporibus molestiae eaque et quod tempora.", "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 12, 37, 997, DateTimeKind.Local), 43, "Debitis sequi dicta maxime magni architecto.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 2, 7, 115, DateTimeKind.Local), 41, "Ut non impedit quasi labore ipsam.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 55, 21, 682, DateTimeKind.Local), 42, "Molestiae impedit molestias aspernatur architecto.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 22, 33, 383, DateTimeKind.Local), 49, "Impedit fugiat ut.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 18, 59, 19, 758, DateTimeKind.Local), 43, "Commodi aliquid voluptatem et omnis autem nihil amet et quaerat.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 43, 43, 756, DateTimeKind.Local), 47, "Quaerat nesciunt est dignissimos totam ipsum.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", 72 },
                    { "309927ed-5909-456b-96cb-5536bc2574f7", 71 },
                    { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", 73 },
                    { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", 71 },
                    { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", 77 },
                    { "b5a291b2-0388-4889-a80d-83ff74c8a91e", 79 },
                    { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", 79 },
                    { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", 71 },
                    { "6932c7c0-3ad8-4c5f-8724-81e11290e682", 78 },
                    { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", 75 }
                });
        }
    }
}
