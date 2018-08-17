using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Added_InvitedUser_Feald_to_OrganizationInvites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "301009ad-044d-4992-98d7-441cda647c1b", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4b0f0015-4592-4c6b-a021-e3eda54ced32", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4be27e39-6654-495c-b3f2-ba26be8cb54b", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "809d33df-f119-43b0-8627-6553ccf484c8", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "920895bb-0bf8-46c8-996a-2730d14086fe", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9688f885-30a2-43b1-9cd8-25f5c0c962dc", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a4445bd2-b428-423a-9e33-e93bfa3a39b1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c1db6f4c-aeb7-4d80-89b8-44d1849edda6", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d1ca79c3-d251-4d2e-8617-daa6e2c6322a", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bc44d1c-425a-40ad-9fc4-76bcff6a8154");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "301009ad-044d-4992-98d7-441cda647c1b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4b0f0015-4592-4c6b-a021-e3eda54ced32");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4be27e39-6654-495c-b3f2-ba26be8cb54b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "809d33df-f119-43b0-8627-6553ccf484c8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "920895bb-0bf8-46c8-996a-2730d14086fe");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9688f885-30a2-43b1-9cd8-25f5c0c962dc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a4445bd2-b428-423a-9e33-e93bfa3a39b1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c1db6f4c-aeb7-4d80-89b8-44d1849edda6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d1ca79c3-d251-4d2e-8617-daa6e2c6322a");

            migrationBuilder.AddColumn<string>(
                name: "InvitedUserId",
                table: "OrganizationInvites",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common2", "Source1", 81, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 51, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Source2", 11, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 98, "Common1", 11 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", "Common3", 88, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Common1", 71, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 95, "Source1", 74 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "Common2", 6, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", "Common3", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 96, "MostLoaded1", "Source3", 92 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 17, 26, 42, 225, DateTimeKind.Local), 84, "Title903" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 22, 2, 58, 98, DateTimeKind.Local), 82, "Title891" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 5, 48, 382, DateTimeKind.Local), 89, "Title565" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 12, 55, 38, 265, DateTimeKind.Local), 84, "Title891" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 21, 54, 16, 163, DateTimeKind.Local), 84, "Title383" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 16, 54, 17, 47, DateTimeKind.Local), 83, "Title579" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 27, 4, 962, DateTimeKind.Local), 83, "Title784" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 17, 3, 20, 58, 12, DateTimeKind.Local), "Title894" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 0, 41, 712, DateTimeKind.Local), 87, "Title659" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 17, 1, 42, 21, 770, DateTimeKind.Local), 87, "Title309" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ab:9a:21:dd:4d:b2", 77, "Linux", "Instance741" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "7e:46:14:5a:3a:c5", 80, "Linux", "Instance160" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "26:ab:b7:ed:c1:ac", 79, "Instance765" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "01:00:9a:67:ba:6e", 71, "Linux", "Instance570" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "24:b0:ef:95:0e:08", 76, "Linux", "Instance230" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e2:79:c6:b8:5a:ff", 79, "Instance170" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d5:ec:3e:08:1d:7e", 77, "Windows", "Instance107" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "bb:51:c1:f2:e1:76", 78, "Linux", "Instance625" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "1c:74:88:a9:3e:87", 73, "Instance872" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8b:d6:85:9a:fc:38", 75, "Instance50" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme513" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme175");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme990" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily" },
                values: new object[] { "White", "Trade" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme586" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme15" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme187");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme435" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme574" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme555" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "4b69c911-186b-492a-8b68-82e31c5bbf2d", null, new DateTime(2018, 8, 16, 22, 57, 26, 590, DateTimeKind.Local), "Aidan", "Foster_McClure81@hotmail.com", "Hosea", true, "Schimmel", null, 1 },
                    { "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", null, new DateTime(2018, 8, 16, 10, 21, 23, 118, DateTimeKind.Local), "Augustus", "Joanne24@gmail.com", "Cyril", true, "Cassin", null, 1 },
                    { "43d2b90d-2f43-4d11-84e4-5ad540607f9d", null, new DateTime(2018, 8, 17, 6, 1, 50, 5, DateTimeKind.Local), "Abe", "Juliana99@gmail.com", "Hortense", true, "Zieme", null, 2 },
                    { "c839906f-c52e-4e9d-be69-04cf21c2e0d2", null, new DateTime(2018, 8, 16, 22, 36, 28, 699, DateTimeKind.Local), "Ona", "Isabel.Turcotte18@gmail.com", "Lenny", true, "Blick", null, 1 },
                    { "6a497a8c-b9e9-4852-9d24-33c0a797cedb", null, new DateTime(2018, 8, 17, 1, 40, 41, 205, DateTimeKind.Local), "Winston", "Dangelo.Considine@yahoo.com", "Katheryn", true, "Torphy", null, 2 },
                    { "9eb9c594-2868-45f5-b274-22c07010bd7e", null, new DateTime(2018, 8, 16, 23, 16, 29, 811, DateTimeKind.Local), "Juston", "Philip_Armstrong@gmail.com", "Rowena", true, "Wilderman", null, 2 },
                    { "aca48c6d-160e-4ff8-b47c-9b9a2feded4b", null, new DateTime(2018, 8, 17, 3, 29, 7, 103, DateTimeKind.Local), "Marcelina", "Brooks_Heller60@hotmail.com", "Sabina", true, "Russel", null, 2 },
                    { "732fb871-e25d-489f-8d02-9c8c23de0451", null, new DateTime(2018, 8, 16, 10, 55, 23, 461, DateTimeKind.Local), "Zion", "Bernice.Auer11@hotmail.com", "Anjali", true, "Lang", null, 2 },
                    { "8fed02df-18af-4e74-afda-de89e5842632", null, new DateTime(2018, 8, 17, 3, 15, 21, 432, DateTimeKind.Local), "Nikita", "Declan_Ebert@gmail.com", "Rebeka", true, "Trantow", null, 1 },
                    { "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65", null, new DateTime(2018, 8, 17, 0, 39, 50, 522, DateTimeKind.Local), "Ceasar", "Daisha_Franecki@hotmail.com", "Sabryna", true, "Quitzon", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c839906f-c52e-4e9d-be69-04cf21c2e0d2", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9eb9c594-2868-45f5-b274-22c07010bd7e", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c839906f-c52e-4e9d-be69-04cf21c2e0d2", "dicta" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "aca48c6d-160e-4ff8-b47c-9b9a2feded4b", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4b69c911-186b-492a-8b68-82e31c5bbf2d", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43d2b90d-2f43-4d11-84e4-5ad540607f9d", "quibusdam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", "odio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65", "aliquid" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43d2b90d-2f43-4d11-84e4-5ad540607f9d", "quidem" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 38, 39, 437, DateTimeKind.Local), "Molestiae voluptatem alias sed eos.", "43d2b90d-2f43-4d11-84e4-5ad540607f9d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 16, 29, 2, 167, DateTimeKind.Local), "Voluptas voluptatem repudiandae et.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 17, 27, 21, 581, DateTimeKind.Local), "Quis quia id non vitae provident sunt.", "6a497a8c-b9e9-4852-9d24-33c0a797cedb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 21, 43, 0, 407, DateTimeKind.Local), "Nostrum eius ducimus adipisci fugit.", "732fb871-e25d-489f-8d02-9c8c23de0451" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 21, 56, 43, 770, DateTimeKind.Local), "Minus quo vel est pariatur.", "c839906f-c52e-4e9d-be69-04cf21c2e0d2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 4, 36, 42, 205, DateTimeKind.Local), "Praesentium repellendus est earum corporis praesentium atque aut hic dolorem.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 15, 19, 1, 96, DateTimeKind.Local), "Quibusdam ex cumque error et pariatur facere dolor aperiam.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 32, 18, 643, DateTimeKind.Local), "In accusamus in modi.", "6a497a8c-b9e9-4852-9d24-33c0a797cedb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 19, 2, 11, 12, DateTimeKind.Local), "Numquam dolorem architecto temporibus temporibus.", "4b69c911-186b-492a-8b68-82e31c5bbf2d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 40, 38, 117, DateTimeKind.Local), "Id error et quis quis vitae voluptatum itaque ea.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 16, 7, 26, 55, 73, DateTimeKind.Local), "Aut suscipit in culpa hic dolorem est id unde.", "6a497a8c-b9e9-4852-9d24-33c0a797cedb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 17, 6, 1, 9, 232, DateTimeKind.Local), "Ab distinctio voluptatem aut perspiciatis expedita nihil.", "4b69c911-186b-492a-8b68-82e31c5bbf2d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 17, 1, 55, 16, 499, DateTimeKind.Local), "Distinctio ut impedit nemo.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 16, 17, 3, 5, 180, DateTimeKind.Local), "Maiores consequatur aut quasi enim.", "732fb871-e25d-489f-8d02-9c8c23de0451" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 17, 5, 45, 18, 39, DateTimeKind.Local), "Qui aliquid qui iure dignissimos dicta voluptatem explicabo.", "43d2b90d-2f43-4d11-84e4-5ad540607f9d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 16, 12, 29, 32, 393, DateTimeKind.Local), "Dolores repellendus dolorem maxime doloremque labore.", "732fb871-e25d-489f-8d02-9c8c23de0451", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 17, 1, 36, 57, 317, DateTimeKind.Local), "Veritatis exercitationem magnam consequatur.", "c839906f-c52e-4e9d-be69-04cf21c2e0d2", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 17, 1, 41, 31, 615, DateTimeKind.Local), "Ad ex vel recusandae sint.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 16, 18, 34, 38, 624, DateTimeKind.Local), "Rerum rerum eligendi.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 16, 10, 56, 25, 31, DateTimeKind.Local), "Unde autem at a veritatis mollitia atque quia.", "8fed02df-18af-4e74-afda-de89e5842632", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "732fb871-e25d-489f-8d02-9c8c23de0451" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "c839906f-c52e-4e9d-be69-04cf21c2e0d2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "9eb9c594-2868-45f5-b274-22c07010bd7e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "8fed02df-18af-4e74-afda-de89e5842632" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 4, "c839906f-c52e-4e9d-be69-04cf21c2e0d2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 2, "8fed02df-18af-4e74-afda-de89e5842632" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 6, 40, 28, 242, DateTimeKind.Local), 15, "Quis aperiam impedit corrupti fugit temporibus ut animi est.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 42, 52, 477, DateTimeKind.Local), 11, "Aut blanditiis expedita eveniet aut molestias molestias aliquid quisquam.", "c839906f-c52e-4e9d-be69-04cf21c2e0d2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 2, 17, 51, 229, DateTimeKind.Local), 14, "Ut molestiae amet rerum.", "9eb9c594-2868-45f5-b274-22c07010bd7e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 7, 52, 707, DateTimeKind.Local), 16, "Dolor in facere eveniet perspiciatis ad blanditiis incidunt vel.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 21, 17, 59, 707, DateTimeKind.Local), 19, "Ratione quia iure enim et est voluptatem sint similique ipsam.", "6a497a8c-b9e9-4852-9d24-33c0a797cedb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 47, 9, 248, DateTimeKind.Local), "Aut velit necessitatibus illum iste beatae.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 2, 10, 46, 772, DateTimeKind.Local), 18, "Repellat error ut illo sed laboriosam sit fuga voluptate nostrum.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 21, 4, 54, 590, DateTimeKind.Local), 19, "Reprehenderit illum voluptatem ea est dicta aliquid.", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 18, 29, 20, 253, DateTimeKind.Local), "Illum quos rerum quia sint reiciendis.", "43d2b90d-2f43-4d11-84e4-5ad540607f9d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 23, 50, 39, 326, DateTimeKind.Local), 11, "Ut quos ut qui tempora.", "732fb871-e25d-489f-8d02-9c8c23de0451" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(208) 812-0540", "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65", "Quo fuga qui quis dignissimos beatae vel tempora perferendis facere.", "Mason_Eichmann@hotmail.com", "Company186", "http://arden.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-615-540-5496 x00023", "732fb871-e25d-489f-8d02-9c8c23de0451", "Doloribus quae aliquid necessitatibus consectetur esse id qui.", "Enola.Lubowitz46@hotmail.com", "Company457", 61, "http://austyn.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "725-997-4622 x56720", "4b69c911-186b-492a-8b68-82e31c5bbf2d", "", "Maribel20@hotmail.com", "Company481", 64, "https://virginia.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "844.582.0132 x61947", "6a497a8c-b9e9-4852-9d24-33c0a797cedb", "Inventore ducimus est debitis voluptatem. Et ea et delectus voluptatibus adipisci vitae. Illum sit est eum eveniet ipsum quaerat repudiandae delectus repellat. Nam aut dignissimos.", "Noemie42@hotmail.com", "Company61", 70, "http://willis.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(220) 993-3892 x187", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", "", "Beaulah_Aufderhar@gmail.com", "Company277", 65, "http://minerva.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(456) 606-2969 x13764", "8fed02df-18af-4e74-afda-de89e5842632", "Atque qui quae officiis. Sint ipsam ut. Aperiam aperiam eaque id iure.", "Jade_Koepp69@yahoo.com", "Company690", 64, "https://anjali.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "285-725-1690 x2624", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", "Consectetur recusandae et ut corporis aperiam commodi fugit. Hic id minus. Non nihil labore sequi tempore.", "Nicolette.Kessler83@yahoo.com", "Company428", 68, "http://ramona.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-246-227-2303 x742", "6a497a8c-b9e9-4852-9d24-33c0a797cedb", "Suscipit quisquam corporis asperiores et omnis. Maiores molestiae est aspernatur reiciendis. Fugit facilis earum eum autem.", "Aubree39@hotmail.com", "Company210", 68, "http://edwardo.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "486.712.2970 x991", "aca48c6d-160e-4ff8-b47c-9b9a2feded4b", "Eius dignissimos commodi aut quasi fugiat illo repellendus esse. Quo et error numquam. Officia molestiae harum excepturi distinctio.", "Jamar.Kunde2@yahoo.com", "Company679", 63, "http://jillian.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-250-269-7294 x5276", "8fed02df-18af-4e74-afda-de89e5842632", "Deleniti veritatis voluptatem et aut magnam. Laudantium perspiciatis ut voluptates qui aperiam ipsum quos provident sint. Et explicabo cumque omnis nemo facilis omnis in soluta.", "Carmel61@yahoo.com", "Company977", 65, "https://liliana.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 20, 43, 51, 223, DateTimeKind.Local), 42, "Non iste dolores.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 36, 38, 563, DateTimeKind.Local), 50, "Et officia vitae distinctio ut ex id totam laborum.", "9eb9c594-2868-45f5-b274-22c07010bd7e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 1, 44, 27, 518, DateTimeKind.Local), 44, "Repellendus perferendis sit.", "732fb871-e25d-489f-8d02-9c8c23de0451" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 17, 29, 2, 341, DateTimeKind.Local), 49, "Et molestiae non eaque perspiciatis.", "6a497a8c-b9e9-4852-9d24-33c0a797cedb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 13, 42, 163, DateTimeKind.Local), "Aperiam facilis expedita et cumque aut et et.", "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 18, 37, 34, 345, DateTimeKind.Local), 50, "Laborum eos numquam quibusdam assumenda illo ut.", "9eb9c594-2868-45f5-b274-22c07010bd7e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 8, 32, 45, 993, DateTimeKind.Local), 49, "Voluptas temporibus minus reiciendis distinctio ipsa fugit nihil.", "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 23, 28, 39, 183, DateTimeKind.Local), 45, "Beatae et aliquam consequatur tempore assumenda commodi.", "8fed02df-18af-4e74-afda-de89e5842632" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 4, 5, 7, 305, DateTimeKind.Local), 49, "Qui veritatis quo et omnis molestias sequi voluptatem sed.", "4b69c911-186b-492a-8b68-82e31c5bbf2d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 17, 0, 4, 24, 716, DateTimeKind.Local), 49, "Ut dolores qui laborum temporibus ad repellat facilis et.", "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "9eb9c594-2868-45f5-b274-22c07010bd7e", 74 },
                    { "732fb871-e25d-489f-8d02-9c8c23de0451", 77 },
                    { "6a497a8c-b9e9-4852-9d24-33c0a797cedb", 73 },
                    { "c839906f-c52e-4e9d-be69-04cf21c2e0d2", 76 },
                    { "43d2b90d-2f43-4d11-84e4-5ad540607f9d", 74 },
                    { "8fed02df-18af-4e74-afda-de89e5842632", 76 },
                    { "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", 73 },
                    { "4b69c911-186b-492a-8b68-82e31c5bbf2d", 76 },
                    { "aca48c6d-160e-4ff8-b47c-9b9a2feded4b", 77 },
                    { "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65", 71 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_InvitedUserId",
                table: "OrganizationInvites",
                column: "InvitedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationInvites_Users_InvitedUserId",
                table: "OrganizationInvites",
                column: "InvitedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationInvites_Users_InvitedUserId",
                table: "OrganizationInvites");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationInvites_InvitedUserId",
                table: "OrganizationInvites");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "43d2b90d-2f43-4d11-84e4-5ad540607f9d", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4b69c911-186b-492a-8b68-82e31c5bbf2d", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6a497a8c-b9e9-4852-9d24-33c0a797cedb", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "732fb871-e25d-489f-8d02-9c8c23de0451", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8fed02df-18af-4e74-afda-de89e5842632", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9eb9c594-2868-45f5-b274-22c07010bd7e", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "aca48c6d-160e-4ff8-b47c-9b9a2feded4b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c839906f-c52e-4e9d-be69-04cf21c2e0d2", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43d2b90d-2f43-4d11-84e4-5ad540607f9d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4b69c911-186b-492a-8b68-82e31c5bbf2d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6a497a8c-b9e9-4852-9d24-33c0a797cedb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "732fb871-e25d-489f-8d02-9c8c23de0451");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8fed02df-18af-4e74-afda-de89e5842632");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9eb9c594-2868-45f5-b274-22c07010bd7e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aca48c6d-160e-4ff8-b47c-9b9a2feded4b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c839906f-c52e-4e9d-be69-04cf21c2e0d2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d3fabbd8-28a1-4b8f-a27f-5892bd5e0493");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7e41f73-b8e2-4a58-aa95-5ddbde1f4b65");

            migrationBuilder.DropColumn(
                name: "InvitedUserId",
                table: "OrganizationInvites");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Common3", "Source3", 73, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 22, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Source3", 90, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 91, "Common2", 82 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common1", 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Common3", 53, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 96, "Source2", 22 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "Common1", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded1", "Common2", 93, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded3", "Source2", 90 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 10, 53, 53, 724, DateTimeKind.Local), 90, "Title193" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 4, 14, 11, 809, DateTimeKind.Local), 88, "Title269" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 55, 4, 984, DateTimeKind.Local), 90, "Title72" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 22, 45, 30, 545, DateTimeKind.Local), 81, "Title477" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 48, 42, 643, DateTimeKind.Local), 86, "Title711" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 4, 14, 553, DateTimeKind.Local), 82, "Title226" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 11, 31, 91, DateTimeKind.Local), 87, "Title510" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 11, 14, 866, DateTimeKind.Local), "Title430" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 39, 56, 510, DateTimeKind.Local), 86, "Title31" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 46, 56, 849, DateTimeKind.Local), 84, "Title961" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4d:9e:24:de:b9:c3", 79, "Windows", "Instance750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "72:47:79:8c:1e:7f", 73, "Windows", "Instance167" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c0:07:04:25:01:54", 75, "Instance777" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "04:7c:40:3a:3e:72", 72, "Windows", "Instance478" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3b:a6:35:ec:36:e3", 72, "Windows", "Instance815" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "fc:ce:96:80:1a:46", 77, "Instance343" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4f:b3:f4:4a:f2:f5", 71, "Linux", "Instance865" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "51:fa:14:09:04:19", 79, "Windows", "Instance304" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "27:35:ca:77:e3:35", 79, "Instance931" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d8:2e:5d:6c:6d:88", 77, "Instance127" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme309" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme386");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme24" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily" },
                values: new object[] { "Yellow", "Univers" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme951" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme153" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme501");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme984" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme831" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme779" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "809d33df-f119-43b0-8627-6553ccf484c8", null, new DateTime(2018, 8, 15, 17, 23, 2, 594, DateTimeKind.Local), "Liana", "Elisha59@gmail.com", "Anya", true, "Brown", null, 1 },
                    { "9688f885-30a2-43b1-9cd8-25f5c0c962dc", null, new DateTime(2018, 8, 16, 5, 6, 49, 427, DateTimeKind.Local), "Laura", "Ena.Effertz23@gmail.com", "Yazmin", true, "Hauck", null, 1 },
                    { "4b0f0015-4592-4c6b-a021-e3eda54ced32", null, new DateTime(2018, 8, 15, 15, 31, 38, 64, DateTimeKind.Local), "Ally", "Madie_Dietrich@hotmail.com", "Dean", true, "Prosacco", null, 1 },
                    { "301009ad-044d-4992-98d7-441cda647c1b", null, new DateTime(2018, 8, 16, 5, 24, 42, 488, DateTimeKind.Local), "Shanny", "Gardner_Russel@gmail.com", "Marshall", true, "Farrell", null, 2 },
                    { "d1ca79c3-d251-4d2e-8617-daa6e2c6322a", null, new DateTime(2018, 8, 15, 17, 3, 11, 347, DateTimeKind.Local), "Shirley", "Chelsie_Wyman@gmail.com", "Eddie", true, "Torp", null, 2 },
                    { "4be27e39-6654-495c-b3f2-ba26be8cb54b", null, new DateTime(2018, 8, 15, 23, 6, 30, 578, DateTimeKind.Local), "Augustine", "Rigoberto.Jakubowski@yahoo.com", "Bessie", true, "Quigley", null, 1 },
                    { "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", null, new DateTime(2018, 8, 16, 4, 3, 45, 903, DateTimeKind.Local), "Theresa", "Eliza.Brown94@hotmail.com", "Kamron", true, "Wunsch", null, 1 },
                    { "920895bb-0bf8-46c8-996a-2730d14086fe", null, new DateTime(2018, 8, 15, 20, 37, 13, 352, DateTimeKind.Local), "Rae", "Florence_Schultz67@hotmail.com", "Floy", true, "Stark", null, 2 },
                    { "c1db6f4c-aeb7-4d80-89b8-44d1849edda6", null, new DateTime(2018, 8, 16, 9, 53, 44, 491, DateTimeKind.Local), "Ambrose", "Briana96@hotmail.com", "Merle", true, "Flatley", null, 1 },
                    { "a4445bd2-b428-423a-9e33-e93bfa3a39b1", null, new DateTime(2018, 8, 16, 4, 13, 36, 724, DateTimeKind.Local), "Alysson", "Vida.Turner27@gmail.com", "Emilie", true, "White", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "809d33df-f119-43b0-8627-6553ccf484c8", "unde" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "920895bb-0bf8-46c8-996a-2730d14086fe", "delectus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4b0f0015-4592-4c6b-a021-e3eda54ced32", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "920895bb-0bf8-46c8-996a-2730d14086fe", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4be27e39-6654-495c-b3f2-ba26be8cb54b", "tenetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "809d33df-f119-43b0-8627-6553ccf484c8", "architecto" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "920895bb-0bf8-46c8-996a-2730d14086fe", "cum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4be27e39-6654-495c-b3f2-ba26be8cb54b", "praesentium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "920895bb-0bf8-46c8-996a-2730d14086fe", "sit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 47, 20, 648, DateTimeKind.Local), "Quisquam suscipit omnis ut quis dolorem.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 48, 2, 394, DateTimeKind.Local), "Corrupti veniam doloribus sunt.", "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 4, 0, 44, 794, DateTimeKind.Local), "Officiis totam quia voluptas et.", "920895bb-0bf8-46c8-996a-2730d14086fe" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 2, 24, 643, DateTimeKind.Local), "Mollitia rerum ut enim.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 2, 9, 57, 505, DateTimeKind.Local), "Delectus est deserunt soluta temporibus reprehenderit rem dolor autem.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 52, 17, 845, DateTimeKind.Local), "Repellat necessitatibus in qui.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 19, 19, 58, 995, DateTimeKind.Local), "Sunt nulla et.", "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 2, 18, 24, 544, DateTimeKind.Local), "Perspiciatis harum quidem molestiae non.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 53, 17, 839, DateTimeKind.Local), "Porro voluptatem vel et nobis ab tenetur in est eum.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 40, 6, 688, DateTimeKind.Local), "Autem aliquam voluptatem commodi.", "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 16, 3, 53, 32, 780, DateTimeKind.Local), "Velit consequuntur non et est facere tempora optio.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 15, 20, 55, 28, 317, DateTimeKind.Local), "Ducimus ea et id voluptatem eaque sit qui ipsum quia.", "920895bb-0bf8-46c8-996a-2730d14086fe", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 15, 19, 18, 41, 480, DateTimeKind.Local), "Voluptas eveniet et perferendis omnis sit aliquid delectus.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 15, 20, 20, 30, 332, DateTimeKind.Local), "Perferendis ipsam vitae iste delectus id ut aut.", "a4445bd2-b428-423a-9e33-e93bfa3a39b1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 15, 20, 48, 10, 397, DateTimeKind.Local), "Illo doloremque aut qui ipsum voluptates aut perspiciatis.", "4be27e39-6654-495c-b3f2-ba26be8cb54b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 16, 0, 57, 1, 947, DateTimeKind.Local), "Laborum aspernatur qui asperiores et dicta in.", "4b0f0015-4592-4c6b-a021-e3eda54ced32", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 21, 40, 316, DateTimeKind.Local), "Est sapiente excepturi culpa.", "809d33df-f119-43b0-8627-6553ccf484c8", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 16, 8, 34, 9, 837, DateTimeKind.Local), "Minima voluptatem nesciunt dolorum quidem voluptatem corrupti nesciunt vitae.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 16, 6, 20, 33, 634, DateTimeKind.Local), "Ipsum impedit sequi.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 16, 7, 8, 9, 213, DateTimeKind.Local), "Quia error tempore in hic laudantium.", "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "920895bb-0bf8-46c8-996a-2730d14086fe");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "a4445bd2-b428-423a-9e33-e93bfa3a39b1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 4, "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 14, 47, 496, DateTimeKind.Local), 12, "Dicta quaerat molestiae eos nulla.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 35, 15, 563, DateTimeKind.Local), 18, "Non impedit veritatis quia dolores voluptatem sed explicabo nobis facilis.", "2bc44d1c-425a-40ad-9fc4-76bcff6a8154" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 22, 34, 29, 514, DateTimeKind.Local), 20, "Rerum nesciunt in sint alias corrupti qui laudantium.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 11, 47, 353, DateTimeKind.Local), 19, "Veniam eligendi veritatis molestias et quasi.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 25, 39, 446, DateTimeKind.Local), 20, "Eos incidunt et ut sint in.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 33, 27, 149, DateTimeKind.Local), "Quis natus voluptatibus reiciendis dignissimos nulla ipsum et.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 47, 7, 374, DateTimeKind.Local), 13, "Corporis est voluptatibus excepturi doloremque dolor ea non ut voluptate.", "4be27e39-6654-495c-b3f2-ba26be8cb54b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 8, 37, 6, 325, DateTimeKind.Local), 12, "Ut id similique consequatur.", "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 8, 49, 445, DateTimeKind.Local), "Architecto quisquam quo vitae veritatis.", "a4445bd2-b428-423a-9e33-e93bfa3a39b1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 15, 17, 17, 597, DateTimeKind.Local), 20, "Consequatur autem accusamus non delectus quis voluptate perspiciatis eaque doloremque.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-280-719-5102", "809d33df-f119-43b0-8627-6553ccf484c8", "In nulla odit cumque rerum deserunt quas. Fugiat laborum ad voluptatum.", "Phoebe.McCullough27@gmail.com", "Company495", "https://carol.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(220) 842-1637 x73306", "4be27e39-6654-495c-b3f2-ba26be8cb54b", "Atque totam suscipit asperiores numquam vitae. Et quo minima soluta voluptatem tempora in perferendis velit quae. Est hic consequatur nesciunt architecto ullam qui. Aut voluptates voluptas et hic dolorem.", "Dennis.Ankunding17@gmail.com", "Company841", 67, "http://aubrey.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-379-325-0963 x305", "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", "Maiores et repudiandae sit excepturi quidem omnis temporibus iure praesentium. Nobis officiis et optio. Voluptatem aut necessitatibus voluptas earum dolor necessitatibus.", "Susana.Stamm11@hotmail.com", "Company785", 65, "https://thea.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-686-933-4181 x3972", "4be27e39-6654-495c-b3f2-ba26be8cb54b", "Iure eaque consequatur quia ad sint aliquid inventore.", "Jaeden.Feeney13@hotmail.com", "Company160", 64, "https://fausto.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "784-645-0206", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a", "Id maxime possimus ut officiis nihil libero quidem. Veritatis ipsa amet rerum nemo corporis inventore ab laboriosam. Cum voluptate est cum rem aut est omnis ea quia. Unde expedita neque at tempora aut voluptatem qui est.", "Kathleen64@hotmail.com", "Company156", 69, "https://kelton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(729) 402-5163 x3053", "809d33df-f119-43b0-8627-6553ccf484c8", "", "Julian.OConner@yahoo.com", "Company186", 61, "http://vivien.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-635-289-8537", "9688f885-30a2-43b1-9cd8-25f5c0c962dc", "", "Kendall.Lemke48@gmail.com", "Company499", 67, "http://tyra.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "915-204-0327", "4b0f0015-4592-4c6b-a021-e3eda54ced32", "", "Clarabelle63@hotmail.com", "Company767", 70, "http://bernadine.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "488-469-4317", "301009ad-044d-4992-98d7-441cda647c1b", "Voluptatem occaecati officiis eligendi nobis repudiandae saepe impedit. Sint assumenda corrupti nobis praesentium nulla. Asperiores cupiditate quisquam numquam molestiae.", "Celia_Larkin70@yahoo.com", "Company419", 68, "http://silas.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-880-902-9084 x5412", "9688f885-30a2-43b1-9cd8-25f5c0c962dc", "", "Kaylin_Schumm@yahoo.com", "Company141", 64, "https://melody.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 56, 33, 417, DateTimeKind.Local), 43, "Aut molestiae sed aut possimus in et omnis fugiat aliquid.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 11, 7, 835, DateTimeKind.Local), 47, "Minima sunt adipisci dicta ut.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 39, 29, 684, DateTimeKind.Local), 47, "Quae deleniti cupiditate vitae.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 4, 50, 446, DateTimeKind.Local), 48, "Est enim nesciunt.", "920895bb-0bf8-46c8-996a-2730d14086fe" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 1, 44, 883, DateTimeKind.Local), "Quod veniam aut consectetur error suscipit cupiditate.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 5, 59, 150, DateTimeKind.Local), 44, "Nobis dolorem minima eos qui id velit.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 41, 51, 154, DateTimeKind.Local), 47, "Voluptatem dolores iure numquam.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 23, 47, 36, 749, DateTimeKind.Local), 41, "Molestiae quos temporibus.", "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 30, 20, 236, DateTimeKind.Local), 43, "Reiciendis consequuntur qui occaecati dolorem.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 8, 32, 4, 835, DateTimeKind.Local), 50, "Autem repellendus et dolorem quam dignissimos sit exercitationem.", "4be27e39-6654-495c-b3f2-ba26be8cb54b" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "920895bb-0bf8-46c8-996a-2730d14086fe", 74 },
                    { "9688f885-30a2-43b1-9cd8-25f5c0c962dc", 75 },
                    { "4b0f0015-4592-4c6b-a021-e3eda54ced32", 77 },
                    { "301009ad-044d-4992-98d7-441cda647c1b", 73 },
                    { "809d33df-f119-43b0-8627-6553ccf484c8", 77 },
                    { "c1db6f4c-aeb7-4d80-89b8-44d1849edda6", 78 },
                    { "2bc44d1c-425a-40ad-9fc4-76bcff6a8154", 71 },
                    { "d1ca79c3-d251-4d2e-8617-daa6e2c6322a", 76 },
                    { "4be27e39-6654-495c-b3f2-ba26be8cb54b", 74 },
                    { "a4445bd2-b428-423a-9e33-e93bfa3a39b1", 78 }
                });
        }
    }
}
