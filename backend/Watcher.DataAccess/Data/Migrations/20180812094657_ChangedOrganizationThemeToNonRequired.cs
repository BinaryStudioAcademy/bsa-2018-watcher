using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedOrganizationThemeToNonRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "067d80ea-b8ae-4b02-b94c-10408ba303f8", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2425fb21-d140-40cc-99a3-6dbdb921748e", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "493926fd-7139-4f2e-9ba3-ff8d886bd793", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4c6b1005-0ade-482b-989a-53a21c60ec1b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5f349ebd-7d15-4a97-a913-ab6b168e87a6", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d701dc50-7274-43b3-a28c-c0f6c0cbcecf", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e630c5ba-9e5d-4767-871a-c57544ff7092", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "eb854e5a-dd61-4063-b49e-e95e570488b5", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "067d80ea-b8ae-4b02-b94c-10408ba303f8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2425fb21-d140-40cc-99a3-6dbdb921748e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "493926fd-7139-4f2e-9ba3-ff8d886bd793");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4c6b1005-0ade-482b-989a-53a21c60ec1b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5f349ebd-7d15-4a97-a913-ab6b168e87a6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "72c46d3f-7f13-42d4-b700-7d7ec31b68ea");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d701dc50-7274-43b3-a28c-c0f6c0cbcecf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e630c5ba-9e5d-4767-871a-c57544ff7092");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eb854e5a-dd61-4063-b49e-e95e570488b5");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 92, "MostLoaded3", "Common3", "Source2", 40 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Common3", 62, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common3", "Source1", 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", "Common1", "Source3", 78, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 95, "MostLoaded2", "Common2", "Source3", 4 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", "Source3", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Source1", 47, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source1", 24 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common2", "Source3", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 96, "MostLoaded3", "Source2", 92 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 9, 55, 136, DateTimeKind.Local), 86, "Title618" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 5, 13, 24, 452, DateTimeKind.Local), 81, "Title677" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 5, 5, 7, 641, DateTimeKind.Local), 83, "Title680" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 10, 2, 112, DateTimeKind.Local), 88 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 19, 11, 53, 470, DateTimeKind.Local), "Title164" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 6, 52, 28, 184, DateTimeKind.Local), 87, "Title893" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 4, 40, 0, 279, DateTimeKind.Local), 86, "Title569" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 24, 41, 513, DateTimeKind.Local), 88, "Title713" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 11, 45, 28, 157, DateTimeKind.Local), 81, "Title834" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 3, 3, 59, 386, DateTimeKind.Local), 82, "Title856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e6:f1:d2:92:f4:39", 80, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "69:aa:13:38:70:91", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "0b:40:1d:fb:4e:1b", 71, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e8:32:37:65:ff:0d", 79, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "d7:36:1c:12:03:7d", 73 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "b7:d9:17:14:e4:4a", 75, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e5:51:e3:82:13:28", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "d9:a2:a9:c2:01:8d", 71, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "d7:ff:61:39:75:53", 79, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f8:5c:43:74:04:03", 73 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme75" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme260" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme832" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme779" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme603");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme765" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Theme115");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme313" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme882" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "8af174fd-45ab-44b1-b756-61b08b4e54fb", null, new DateTime(2018, 8, 11, 19, 37, 22, 517, DateTimeKind.Local), "Leif", "Marlin10@gmail.com", "Jedidiah", true, "Cronin", null, 2 },
                    { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", null, new DateTime(2018, 8, 12, 6, 23, 16, 223, DateTimeKind.Local), "Fabian", "Roel_Quitzon@hotmail.com", "Barbara", true, "Hilll", null, 1 },
                    { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", null, new DateTime(2018, 8, 12, 10, 53, 37, 128, DateTimeKind.Local), "Rachel", "Hester56@yahoo.com", "Kamron", true, "Kuphal", null, 1 },
                    { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", null, new DateTime(2018, 8, 12, 3, 40, 7, 898, DateTimeKind.Local), "Leonard", "Kattie_Lockman3@yahoo.com", "Marcelina", true, "Wisoky", null, 2 },
                    { "a5001d94-a4ad-40d8-a333-9dc16a882630", null, new DateTime(2018, 8, 12, 9, 42, 42, 479, DateTimeKind.Local), "Marilie", "Clint_MacGyver@hotmail.com", "Nona", true, "Tromp", null, 2 },
                    { "e55cc846-c35c-4068-a96e-7e4d3a350a11", null, new DateTime(2018, 8, 11, 19, 38, 45, 259, DateTimeKind.Local), "Lennie", "Yadira71@yahoo.com", "Precious", true, "Johnston", null, 2 },
                    { "34a73032-25cd-4e18-8078-ec7e1280ddfe", null, new DateTime(2018, 8, 11, 13, 32, 7, 795, DateTimeKind.Local), "Laurie", "Brennon.Rosenbaum29@gmail.com", "June", true, "Bailey", null, 1 },
                    { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", null, new DateTime(2018, 8, 11, 22, 11, 40, 183, DateTimeKind.Local), "Graciela", "Layne.Cassin40@hotmail.com", "Pink", true, "Torphy", null, 2 },
                    { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", null, new DateTime(2018, 8, 11, 20, 28, 11, 579, DateTimeKind.Local), "Sandrine", "Abby.Conroy@yahoo.com", "Valentine", true, "Kertzmann", null, 2 },
                    { "a4c77589-fde9-498b-a93d-dfdfed4b5168", null, new DateTime(2018, 8, 12, 8, 13, 53, 547, DateTimeKind.Local), "Forest", "Ellen.Kub84@hotmail.com", "Emilia", true, "Kunde", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "34a73032-25cd-4e18-8078-ec7e1280ddfe", "explicabo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", "sint" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedById",
                value: "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8af174fd-45ab-44b1-b756-61b08b4e54fb", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "optio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "vero" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "veniam" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 7, 58, 10, 468, DateTimeKind.Local), "Sapiente vel odio placeat consequuntur.", "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 39, 20, 506, DateTimeKind.Local), "Temporibus repudiandae similique commodi autem et accusantium omnis perferendis at.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 18, 53, 50, 916, DateTimeKind.Local), "Nulla est dolores.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 19, 13, 56, 153, DateTimeKind.Local), "Aut aut enim neque at.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 11, 46, 195, DateTimeKind.Local), "Aut vel illo reprehenderit soluta nam.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 4, 50, 52, 751, DateTimeKind.Local), "Autem ipsa placeat.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 36, 54, 704, DateTimeKind.Local), "Deserunt quia provident doloribus tempora sed.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 53, 25, 613, DateTimeKind.Local), "Perspiciatis eveniet quibusdam.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 0, 48, 226, DateTimeKind.Local), "Porro harum et dolore modi vel sapiente laudantium sed.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 6, 1, 780, DateTimeKind.Local), "Tempore cumque cumque fugiat aut dicta.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 12, 1, 30, 58, 839, DateTimeKind.Local), "In delectus eos quas consequuntur rerum.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 11, 14, 40, 38, 676, DateTimeKind.Local), "Voluptatem atque rerum aut ullam voluptates.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 11, 18, 26, 48, 569, DateTimeKind.Local), "Dolorum est dicta eum ab est ad ea corporis.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 11, 14, 16, 36, 4, DateTimeKind.Local), "Consequuntur consequatur ut molestiae possimus ab delectus temporibus.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 3, 58, 44, 421, DateTimeKind.Local), "Odio hic ut commodi quia fugit nihil.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 11, 18, 25, 39, 229, DateTimeKind.Local), "Quasi adipisci illum vitae repellat iure temporibus molestiae qui quia.", "e55cc846-c35c-4068-a96e-7e4d3a350a11", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 16, 39, 17, DateTimeKind.Local), "Ut eum corrupti voluptatem veniam.", "a5001d94-a4ad-40d8-a333-9dc16a882630", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 12, 9, 8, 1, 935, DateTimeKind.Local), "Sit facilis culpa illum consequatur omnis officia dolores aperiam est.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 17, 6, 10, 925, DateTimeKind.Local), "Enim sint consectetur ut quae culpa consequatur.", "e55cc846-c35c-4068-a96e-7e4d3a350a11", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 12, 8, 7, 721, DateTimeKind.Local), "Ut blanditiis amet delectus ea voluptate quia voluptatibus maxime non.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, true, "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 3, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 0, "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 39, 22, 177, DateTimeKind.Local), "Molestiae recusandae hic est maiores quia placeat quasi.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 20, 24, 20, 521, DateTimeKind.Local), 20, "Totam quia quia.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 42, 13, 203, DateTimeKind.Local), 12, "Inventore sit aut blanditiis earum sunt asperiores dolorem.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 19, 16, 907, DateTimeKind.Local), "Laboriosam aut placeat sunt nobis.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 23, 5, 77, DateTimeKind.Local), 19, "Quod maiores molestiae fugiat sint dolore et doloribus nesciunt quasi.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 56, 0, 770, DateTimeKind.Local), 14, "Eum ipsam deleniti consequatur voluptatem asperiores nesciunt.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 12, 40, 53, DateTimeKind.Local), 19, "Nostrum amet porro harum.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 54, 36, 685, DateTimeKind.Local), 14, "Qui voluptatem ut soluta.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 10, 42, 791, DateTimeKind.Local), 14, "Quia aut necessitatibus tempore ea.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 51, 13, 847, DateTimeKind.Local), 12, "Quia eos tempora qui voluptas.", "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "257-895-7084 x45551", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "Ea magnam sint eum dolorem aut est quidem voluptas reprehenderit. Reprehenderit consequatur quas et enim impedit veritatis dolores impedit. Est quis ratione aut exercitationem rerum praesentium.", "Lane_Schaden66@hotmail.com", "Company437", 61, "https://elwyn.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(218) 668-9637 x56037", "8af174fd-45ab-44b1-b756-61b08b4e54fb", "Hic officiis neque incidunt atque dolore velit qui ut. Ipsum quod velit est quia. Consequatur provident vitae aliquam corporis sed voluptate sapiente aut. Quis expedita veritatis alias reprehenderit et sit ullam eaque.", "Mitchell7@gmail.com", "Company190", 66, "https://tressa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(527) 866-4742", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "A perspiciatis beatae nisi necessitatibus iste natus eveniet. Inventore aliquam qui recusandae quisquam sit animi officiis.", "Thea60@yahoo.com", "Company668", "https://tania.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "494.336.9723 x233", "a4c77589-fde9-498b-a93d-dfdfed4b5168", "Et repudiandae exercitationem. Officiis libero illo non necessitatibus maxime ullam rerum culpa. Similique alias quasi iure praesentium.", "Dejuan_Dicki98@gmail.com", "Company894", 69, "https://richard.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(670) 729-4927 x06074", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "Aliquid dolores alias saepe nihil velit saepe mollitia. Eveniet maiores deserunt neque maiores.", "Waylon88@hotmail.com", "Company970", 70, "https://kamryn.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(724) 861-1489 x84849", "a5001d94-a4ad-40d8-a333-9dc16a882630", "", "Keven.Kunde96@hotmail.com", "Company404", 64, "https://london.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "200-499-4659", "34a73032-25cd-4e18-8078-ec7e1280ddfe", "Earum aspernatur ea ducimus iusto id sit illum ab. Amet excepturi qui dolorem sint adipisci consequatur. Et alias qui vel temporibus harum autem blanditiis fugiat sed. In non ea sequi recusandae repellendus.", "Myra.Padberg@hotmail.com", "Company119", 63, "https://cleora.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "451-892-5376", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "Atque commodi est id repellendus ex sint eum minima et. Sint nobis eum temporibus ea quis blanditiis incidunt necessitatibus. Excepturi sit perspiciatis. Ut consectetur quisquam modi voluptas quas.", "Chanel_Schiller17@gmail.com", "Company976", 61, "https://kennith.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-241-641-0340", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "Dolor odit velit sint dolorem autem nesciunt tenetur quam excepturi. Rem eos ea beatae iure inventore accusantium voluptas iste. Fugiat cupiditate autem illum inventore corporis veritatis corporis amet. Asperiores enim porro magnam eius cumque aut eaque aliquam quis.", "Erich.Tromp@yahoo.com", "Company213", 70, "http://isadore.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-354-461-4062", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "Nesciunt nihil odit vero est dolor maiores qui ut. Et perferendis perferendis quo veritatis labore voluptatibus libero non et. Ut excepturi voluptates quidem nostrum sit recusandae omnis.", "Zane63@hotmail.com", "Company511", 62, "http://graciela.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 5, 17, 774, DateTimeKind.Local), 43, "Voluptatem quod vitae quis quo et quae nulla repellendus accusamus.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 49, 33, 572, DateTimeKind.Local), 47, "Velit nobis vitae.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 40, 8, 374, DateTimeKind.Local), 43, "Sit suscipit tempore libero esse et corporis quo.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 2, 45, 39, 871, DateTimeKind.Local), 50, "Voluptas qui saepe voluptatibus sapiente molestias hic repudiandae dolorum.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 46, 50, 964, DateTimeKind.Local), 50, "Vel fuga nostrum voluptatem necessitatibus officia qui.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 5, 29, 108, DateTimeKind.Local), 44, "Velit dolorum ullam amet maxime dolores.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 51, 41, 37, DateTimeKind.Local), 42, "Provident soluta occaecati cumque.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 23, 17, 38, 135, DateTimeKind.Local), 42, "Sunt repudiandae unde est eos eaque dolorum perferendis.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 43, 8, 166, DateTimeKind.Local), 46, "Soluta atque voluptate corrupti similique nisi non omnis.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 37, 19, 431, DateTimeKind.Local), 42, "Unde quis nulla rerum assumenda ducimus assumenda mollitia.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e55cc846-c35c-4068-a96e-7e4d3a350a11", 76 },
                    { "a5001d94-a4ad-40d8-a333-9dc16a882630", 74 },
                    { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", 79 },
                    { "34a73032-25cd-4e18-8078-ec7e1280ddfe", 75 },
                    { "8af174fd-45ab-44b1-b756-61b08b4e54fb", 76 },
                    { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", 71 },
                    { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", 77 },
                    { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", 76 },
                    { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", 77 },
                    { "a4c77589-fde9-498b-a93d-dfdfed4b5168", 72 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "34a73032-25cd-4e18-8078-ec7e1280ddfe", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8af174fd-45ab-44b1-b756-61b08b4e54fb", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a4c77589-fde9-498b-a93d-dfdfed4b5168", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a5001d94-a4ad-40d8-a333-9dc16a882630", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34a73032-25cd-4e18-8078-ec7e1280ddfe");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d092db0-7b72-4313-af6b-f4fdf12c5f7d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5c8ec0eb-c030-497f-9977-ff1d7c9021e4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "68ed0dc9-00df-4e70-8fab-7a6b1d996b50");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8af174fd-45ab-44b1-b756-61b08b4e54fb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a4c77589-fde9-498b-a93d-dfdfed4b5168");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a5001d94-a4ad-40d8-a333-9dc16a882630");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e55cc846-c35c-4068-a96e-7e4d3a350a11");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "Organizations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded2", "Common2", "Source1", 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Common1", 59, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Common2", "Source3", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Common3", "Source2", 35, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 93, "MostLoaded1", "Common3", "Source2", 79 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", "Source1", 66, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Source3", 82, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded1", "Common3", "Source3", 81 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Common1", "Source2", 23, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded1", "Source3", 9 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 34, 13, 275, DateTimeKind.Local), 83, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 0, 1, 83, DateTimeKind.Local), 87, "Title360" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 10, 24, 58, 326, DateTimeKind.Local), 85, "Title256" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId" },
                values: new object[] { new DateTime(2018, 8, 10, 18, 48, 8, 389, DateTimeKind.Local), 86 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 14, 4, 857, DateTimeKind.Local), "Title8" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 0, 26, 45, 279, DateTimeKind.Local), 89, "Title375" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 10, 18, 53, 34, 900, DateTimeKind.Local), 89, "Title735" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 10, 20, 59, 44, 461, DateTimeKind.Local), 84, "Title304" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 57, 50, 718, DateTimeKind.Local), 88, "Title131" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 12, 32, 10, 608, DateTimeKind.Local), 85, "Title439" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "1f:fd:b4:5d:f6:e9", 77, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "34:4e:34:a8:e6:ee", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "f9:c5:2f:11:f0:e3", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "0e:34:5f:58:d6:4f", 71, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f8:79:8c:38:47:1b", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "47:bb:f7:82:7e:de", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "12:7a:d3:db:6c:b6", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "ce:e6:4f:c2:89:45", 76, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "49:1e:af:6d:62:56", 80, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "0c:1e:ca:35:eb:ac", 74 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme82" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme621" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme580" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme586" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme718" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme880");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme762" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Theme981");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme931" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme46" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "eb854e5a-dd61-4063-b49e-e95e570488b5", null, new DateTime(2018, 8, 10, 20, 8, 20, 569, DateTimeKind.Local), "Walker", "Oliver.Klein@yahoo.com", "Lilla", true, "Connelly", null, 1 },
                    { "5f349ebd-7d15-4a97-a913-ab6b168e87a6", null, new DateTime(2018, 8, 10, 19, 21, 54, 90, DateTimeKind.Local), "Amie", "Lon87@hotmail.com", "Zoila", true, "Rippin", null, 2 },
                    { "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", null, new DateTime(2018, 8, 11, 5, 48, 39, 843, DateTimeKind.Local), "Rickey", "Malvina.Baumbach@gmail.com", "Ada", true, "Feil", null, 1 },
                    { "d701dc50-7274-43b3-a28c-c0f6c0cbcecf", null, new DateTime(2018, 8, 10, 23, 31, 25, 853, DateTimeKind.Local), "Monroe", "Kasey80@hotmail.com", "Sage", true, "Lehner", null, 2 },
                    { "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", null, new DateTime(2018, 8, 11, 4, 11, 40, 631, DateTimeKind.Local), "Viva", "Erik.Rolfson11@hotmail.com", "Marcelo", true, "Lebsack", null, 1 },
                    { "e630c5ba-9e5d-4767-871a-c57544ff7092", null, new DateTime(2018, 8, 10, 19, 7, 59, 989, DateTimeKind.Local), "Iva", "Geraldine_Hackett72@hotmail.com", "Alex", true, "Kiehn", null, 1 },
                    { "067d80ea-b8ae-4b02-b94c-10408ba303f8", null, new DateTime(2018, 8, 11, 14, 59, 27, 3, DateTimeKind.Local), "Keara", "Adelia80@yahoo.com", "Maybell", true, "Legros", null, 1 },
                    { "493926fd-7139-4f2e-9ba3-ff8d886bd793", null, new DateTime(2018, 8, 11, 16, 51, 47, 110, DateTimeKind.Local), "Stanton", "Dominic_White26@yahoo.com", "Bert", true, "Keebler", null, 1 },
                    { "4c6b1005-0ade-482b-989a-53a21c60ec1b", null, new DateTime(2018, 8, 11, 5, 3, 13, 480, DateTimeKind.Local), "Riley", "Drake52@gmail.com", "Torey", true, "D'Amore", null, 1 },
                    { "2425fb21-d140-40cc-99a3-6dbdb921748e", null, new DateTime(2018, 8, 11, 14, 1, 37, 872, DateTimeKind.Local), "Cooper", "Ian_Hand43@hotmail.com", "Alfreda", true, "Macejkovic", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eb854e5a-dd61-4063-b49e-e95e570488b5", "deleniti" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eb854e5a-dd61-4063-b49e-e95e570488b5", "fugit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4c6b1005-0ade-482b-989a-53a21c60ec1b", "eaque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4c6b1005-0ade-482b-989a-53a21c60ec1b", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedById",
                value: "4c6b1005-0ade-482b-989a-53a21c60ec1b");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", "cupiditate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "067d80ea-b8ae-4b02-b94c-10408ba303f8", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "067d80ea-b8ae-4b02-b94c-10408ba303f8", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "493926fd-7139-4f2e-9ba3-ff8d886bd793", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eb854e5a-dd61-4063-b49e-e95e570488b5", "quis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 1, 56, 57, 336, DateTimeKind.Local), "Consectetur mollitia ullam mollitia ullam cupiditate ut ut maiores.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 12, 49, 47, 222, DateTimeKind.Local), "Commodi et ut maiores qui.", "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 12, 29, 32, 243, DateTimeKind.Local), "Sapiente quae rem facilis quisquam cupiditate magnam dolorum quis neque.", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 19, 1, 51, 779, DateTimeKind.Local), "Explicabo veniam quasi maiores quaerat.", "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 7, 13, 54, 647, DateTimeKind.Local), "Aperiam sit nobis eum molestiae qui id commodi voluptatibus.", "2425fb21-d140-40cc-99a3-6dbdb921748e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 54, 39, 370, DateTimeKind.Local), "Maxime consequatur qui.", "067d80ea-b8ae-4b02-b94c-10408ba303f8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 18, 53, 50, 266, DateTimeKind.Local), "Est ad et provident qui odio in repellat ut.", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 5, 34, 12, 373, DateTimeKind.Local), "Rerum quaerat aut eos molestiae doloremque repellendus quaerat nostrum quibusdam.", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 19, 13, 51, 639, DateTimeKind.Local), "Quisquam voluptatem neque qui quis eos.", "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 22, 33, 45, 5, DateTimeKind.Local), "Dolor corrupti dolore quas adipisci dolore.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 11, 3, 16, 41, 589, DateTimeKind.Local), "Ullam consequatur voluptatum dicta sed vel a molestias numquam.", "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 10, 21, 7, 17, 125, DateTimeKind.Local), "Neque quo vero cum dolorum qui quasi.", "493926fd-7139-4f2e-9ba3-ff8d886bd793", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 10, 23, 0, 5, 274, DateTimeKind.Local), "Sunt porro molestiae harum veritatis voluptas.", "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 11, 0, 51, 21, 26, DateTimeKind.Local), "Itaque et ab in suscipit molestiae earum sint.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 11, 12, 10, 52, 320, DateTimeKind.Local), "Dolorem eaque libero sit quod ea qui nesciunt quia eligendi.", "e630c5ba-9e5d-4767-871a-c57544ff7092", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 11, 0, 12, 53, 718, DateTimeKind.Local), "Voluptas libero labore esse nesciunt architecto sint facere similique.", "2425fb21-d140-40cc-99a3-6dbdb921748e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 31, 36, 152, DateTimeKind.Local), "Incidunt quo aut enim asperiores laudantium.", "eb854e5a-dd61-4063-b49e-e95e570488b5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 10, 21, 7, 25, 371, DateTimeKind.Local), "Eos deleniti et incidunt sit laboriosam facere nisi sunt.", "067d80ea-b8ae-4b02-b94c-10408ba303f8", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 11, 9, 28, 2, 453, DateTimeKind.Local), "At magnam quis aspernatur itaque.", "493926fd-7139-4f2e-9ba3-ff8d886bd793", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 15, 2, 43, 691, DateTimeKind.Local), "Reiciendis impedit delectus.", "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 2, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, false, "067d80ea-b8ae-4b02-b94c-10408ba303f8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 2, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 17, 35, 57, 948, DateTimeKind.Local), "Illum qui fugiat dolores est dolores adipisci aliquid.", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 0, 50, 0, 237, DateTimeKind.Local), 17, "Est delectus harum quidem rerum consectetur.", "e630c5ba-9e5d-4767-871a-c57544ff7092" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 4, 47, 18, 953, DateTimeKind.Local), 18, "Iste et vero.", "e630c5ba-9e5d-4767-871a-c57544ff7092" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 58, 15, 355, DateTimeKind.Local), "Illum et sit quod quia.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 2, 19, 10, 36, DateTimeKind.Local), 18, "Quis cum enim sit.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 1, 16, 20, 878, DateTimeKind.Local), 20, "Quod reprehenderit quaerat magni praesentium et quibusdam perspiciatis eaque.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 4, 43, 24, 28, DateTimeKind.Local), 12, "Tempora sunt et sit adipisci animi dignissimos facilis.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 17, 40, 46, 358, DateTimeKind.Local), 12, "Quam qui aperiam quaerat enim rem eligendi odit.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 2, 4, 9, 725, DateTimeKind.Local), 16, "Sed ea placeat iure adipisci dolores iure.", "2425fb21-d140-40cc-99a3-6dbdb921748e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 11, 34, 20, 231, DateTimeKind.Local), 13, "Odit quo enim blanditiis.", "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-641-327-4993 x304", "4c6b1005-0ade-482b-989a-53a21c60ec1b", "Explicabo voluptas quod consequatur.", "Vance.Mohr@gmail.com", "Company736", 65, "https://hadley.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(785) 264-5534 x240", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", "Deleniti corporis et alias eaque tempore fugit officia. Quod veniam animi non qui. Aut non quis iste est sit nemo. Quia sit vel aliquam vitae deleniti facilis.", "Reymundo_Monahan36@yahoo.com", "Company956", 69, "http://avery.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-886-477-6004 x051", "e630c5ba-9e5d-4767-871a-c57544ff7092", "Tempore tempora quam doloremque aut rerum. Deleniti nulla est nam excepturi corporis fugit. Possimus magnam soluta assumenda omnis at.", "Annabell90@gmail.com", "Company751", "https://josiah.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(534) 738-2898", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", "", "Kellie66@hotmail.com", "Company490", 64, "https://wilson.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-703-411-1612 x67372", "e630c5ba-9e5d-4767-871a-c57544ff7092", "Reiciendis natus suscipit reprehenderit inventore dignissimos. Dolorum dolorum eum fugiat culpa quis laudantium. Rerum blanditiis assumenda explicabo vel. Est dolor qui esse architecto quia enim autem suscipit quasi.", "Robert_Schuppe@hotmail.com", "Company965", 66, "https://calista.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "487.241.9920", "2425fb21-d140-40cc-99a3-6dbdb921748e", "Dolor id reiciendis voluptatibus voluptatem. Dolorem quis omnis nemo illo.", "Mckayla_Lesch@yahoo.com", "Company466", 69, "http://maritza.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-486-440-3493", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", "Iste cum provident. Vero labore deserunt maiores. Voluptates molestiae id. Alias aut a qui.", "Bert30@hotmail.com", "Company684", 61, "http://hilario.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "988.534.7149 x842", "493926fd-7139-4f2e-9ba3-ff8d886bd793", "Fugit ducimus velit consectetur consequatur id.", "Minnie.Wolf@yahoo.com", "Company351", 64, "https://marquise.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "536.842.5705 x73353", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", "Dolores laborum at adipisci consectetur esse. Rem atque sequi quos voluptas mollitia recusandae qui vel reprehenderit. Magnam vitae est maxime sed sit maiores quia rerum modi.", "Velma_Luettgen36@hotmail.com", "Company458", 66, "https://abraham.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(300) 995-5259 x516", "067d80ea-b8ae-4b02-b94c-10408ba303f8", "Quos libero non maiores rem nobis reiciendis saepe sequi. Vel optio cupiditate illo. Et id et et.", "Stacey_Jaskolski@hotmail.com", "Company997", 68, "https://dejon.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 3, 20, 8, 79, DateTimeKind.Local), 42, "Omnis dicta maiores natus est quia.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 29, 10, 644, DateTimeKind.Local), 42, "Qui culpa reiciendis omnis ex.", "5f349ebd-7d15-4a97-a913-ab6b168e87a6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 0, 3, 314, DateTimeKind.Local), 49, "Esse voluptatibus illum sit nam et.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 13, 44, 42, 812, DateTimeKind.Local), 42, "Quo sed qui eos suscipit id.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 0, 23, 18, 182, DateTimeKind.Local), 44, "Eaque reiciendis ea accusantium id recusandae et velit.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 6, 23, 2, 973, DateTimeKind.Local), 48, "Consequuntur iure sit.", "2425fb21-d140-40cc-99a3-6dbdb921748e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 11, 15, 59, 234, DateTimeKind.Local), 50, "Inventore similique rerum porro praesentium.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 4, 2, 49, 59, DateTimeKind.Local), 48, "Facilis voluptatem sit quod earum qui vel iusto.", "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 21, 37, 34, 929, DateTimeKind.Local), 48, "Cumque debitis facere repellat veritatis maxime velit veritatis.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 10, 23, 53, 13, 777, DateTimeKind.Local), 50, "Vitae aut aspernatur qui quaerat earum.", "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "493926fd-7139-4f2e-9ba3-ff8d886bd793", 73 },
                    { "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64", 72 },
                    { "d701dc50-7274-43b3-a28c-c0f6c0cbcecf", 74 },
                    { "4c6b1005-0ade-482b-989a-53a21c60ec1b", 77 },
                    { "eb854e5a-dd61-4063-b49e-e95e570488b5", 72 },
                    { "067d80ea-b8ae-4b02-b94c-10408ba303f8", 77 },
                    { "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", 71 },
                    { "e630c5ba-9e5d-4767-871a-c57544ff7092", 71 },
                    { "5f349ebd-7d15-4a97-a913-ab6b168e87a6", 75 },
                    { "2425fb21-d140-40cc-99a3-6dbdb921748e", 72 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
