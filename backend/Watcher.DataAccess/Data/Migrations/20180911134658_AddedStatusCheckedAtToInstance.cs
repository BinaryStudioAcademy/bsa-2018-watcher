using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedStatusCheckedAtToInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "31d1aeea-fca1-4233-a640-d19ec2d5690a", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48496f80-3505-4088-bce9-721237904d3e", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "733804e3-2791-4002-81c8-c134b163717b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ec62c0a6-f281-40a1-a913-35c180dc66fd", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31d1aeea-fca1-4233-a640-d19ec2d5690a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48496f80-3505-4088-bce9-721237904d3e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "733804e3-2791-4002-81c8-c134b163717b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "79e46537-a194-4592-b5ab-04b90c068eb3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ad214b9-dbd3-4eb6-ada3-eda95c538e17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94e2a11d-e4bd-4f1e-8e18-bd302131b886");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ec62c0a6-f281-40a1-a913-35c180dc66fd");

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusCheckedAt",
                table: "Instances",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 64, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 62, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 90, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 92, 91 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 86, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 28, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 42, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 100, 94 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 54, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 36, 18, 521, DateTimeKind.Local), 86, "Title928" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 4, 45, 687, DateTimeKind.Local), 89, "Title211" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 27, 13, 408, DateTimeKind.Local), 81, "Title629" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 3, 4, 925, DateTimeKind.Local), 85, "Title221" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 42, 1, 329, DateTimeKind.Local), 89, "Title792" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 30, 27, 674, DateTimeKind.Local), 88, "Title27" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 25, 6, 376, DateTimeKind.Local), "Title881" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 26, 47, 181, DateTimeKind.Local), 90, "Title663" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 32, 26, 389, DateTimeKind.Local), 89, "Title667" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 1, 21, 413, DateTimeKind.Local), 83, "Title177" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "5e:94:b4:e7:82:a0", true, true, true, 90f, 90f, 71, "Windows", 90f, "Instance543" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "7b:0d:d6:76:9c:ad", true, true, true, 90f, 90f, 80, "Windows", 90f, "Instance457" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "7a:d6:1c:2f:a6:b8", true, true, true, 90f, 90f, 90f, "Instance357" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "d3:52:74:5d:97:79", true, true, true, 90f, 90f, 90f, "Instance938" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "1c:72:d1:c1:15:30", true, true, true, 90f, 90f, 77, 90f, "Instance398" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "14:2b:e6:be:3f:87", true, true, true, 90f, 90f, 75, 90f, "Instance710" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "26:16:32:e3:40:29", true, true, true, 90f, 90f, 76, "Linux", 90f, "Instance254" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "e9:73:bf:18:b0:07", true, true, true, 90f, 90f, 71, "Windows", 90f, "Instance868" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "08:f0:35:2b:7c:a8", true, true, true, 90f, 90f, 75, "Windows", 90f, "Instance101" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "01:3f:47:9b:1b:05", true, true, true, 90f, 90f, 73, 90f, "Instance114" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme194" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme439" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme491" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme594" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme970" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme999" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme718" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme120" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme507" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme452" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d35bccfa-a9f4-456c-a18f-e334c78563f0", null, new DateTime(2018, 9, 10, 18, 4, 49, 44, DateTimeKind.Local), "Myles", "Mikel_Pfeffer@yahoo.com", null, "Jacey", true, false, "Zemlak", null, "https://s3.amazonaws.com/uifaces/faces/twitter/louis_currie/128.jpg", 1 },
                    { "d8deb96d-e4ec-4100-9238-de69c5786c38", null, new DateTime(2018, 9, 10, 18, 48, 31, 903, DateTimeKind.Local), "Brady", "Jamarcus80@gmail.com", null, "Ursula", true, false, "Veum", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Chakintosh/128.jpg", 2 },
                    { "c5dd7424-d8cc-404d-ad1d-d3d2362130c2", null, new DateTime(2018, 9, 11, 2, 13, 36, 718, DateTimeKind.Local), "Judson", "Ted48@hotmail.com", null, "Gisselle", true, false, "Feil", null, "https://s3.amazonaws.com/uifaces/faces/twitter/steynviljoen/128.jpg", 2 },
                    { "e52db057-e8ba-4a30-b771-e5b3982d6721", null, new DateTime(2018, 9, 11, 6, 28, 39, 913, DateTimeKind.Local), "Neva", "Carissa.Hartmann@hotmail.com", null, "Obie", true, false, "Breitenberg", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nateschulte/128.jpg", 1 },
                    { "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", null, new DateTime(2018, 9, 11, 6, 51, 39, 631, DateTimeKind.Local), "Jesus", "Jamaal.Kshlerin96@hotmail.com", null, "Akeem", true, false, "Gulgowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/elenadissi/128.jpg", 2 },
                    { "14fb8ee9-92d8-4aec-811c-f12481229d30", null, new DateTime(2018, 9, 11, 4, 1, 44, 410, DateTimeKind.Local), "Aliyah", "Olga.Lakin@hotmail.com", null, "Lawson", true, false, "Kuphal", null, "https://s3.amazonaws.com/uifaces/faces/twitter/okseanjay/128.jpg", 1 },
                    { "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", null, new DateTime(2018, 9, 11, 13, 56, 58, 351, DateTimeKind.Local), "Demetris", "Cruz2@yahoo.com", null, "Caden", true, false, "Auer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/lebinoclard/128.jpg", 1 },
                    { "dfc5a668-78f7-4868-bb28-5fb599184b2f", null, new DateTime(2018, 9, 11, 8, 17, 55, 593, DateTimeKind.Local), "Jaycee", "Hosea.Reichel64@hotmail.com", null, "Curtis", true, false, "Fahey", null, "https://s3.amazonaws.com/uifaces/faces/twitter/simobenso/128.jpg", 1 },
                    { "886b78f3-1a13-4eda-bd05-da5f9ceb3359", null, new DateTime(2018, 9, 11, 16, 10, 0, 811, DateTimeKind.Local), "Bethel", "Milan.Leannon99@yahoo.com", null, "Camren", true, false, "Hermann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jwalter14/128.jpg", 1 },
                    { "d5027330-edba-46bd-87e8-5d17cafec535", null, new DateTime(2018, 9, 11, 4, 14, 59, 746, DateTimeKind.Local), "Scot", "Katelynn_OConner@yahoo.com", null, "Tommie", true, false, "Effertz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/hota_v/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "886b78f3-1a13-4eda-bd05-da5f9ceb3359", "explicabo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "quod" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", "iste" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "dfc5a668-78f7-4868-bb28-5fb599184b2f", "magni" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d5027330-edba-46bd-87e8-5d17cafec535", "at" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e52db057-e8ba-4a30-b771-e5b3982d6721", "laboriosam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "dfc5a668-78f7-4868-bb28-5fb599184b2f", "necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d8deb96d-e4ec-4100-9238-de69c5786c38", "rem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "886b78f3-1a13-4eda-bd05-da5f9ceb3359", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 24, 36, 622, DateTimeKind.Local), "Consectetur quisquam maxime sed placeat dolores quasi nobis.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 17, 45, 42, 533, DateTimeKind.Local), "Eum vel et quis reprehenderit laborum minus.", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 14, 21, 644, DateTimeKind.Local), "Qui mollitia rerum sed a eum quis recusandae velit.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 41, 5, 898, DateTimeKind.Local), "Non qui tempore voluptate ad quos voluptatem quas rerum voluptas.", "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 36, 46, 356, DateTimeKind.Local), "Velit corporis ad rem similique.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 13, 6, 928, DateTimeKind.Local), "Et praesentium quia quibusdam repudiandae temporibus corporis optio facere.", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 3, 53, 945, DateTimeKind.Local), "Praesentium pariatur quibusdam cumque maiores suscipit.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 43, 35, 281, DateTimeKind.Local), "Et sapiente aut ut non unde non aspernatur.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 7, 39, 77, DateTimeKind.Local), "Perferendis consequuntur distinctio ea unde est ea nihil a aut.", "dfc5a668-78f7-4868-bb28-5fb599184b2f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 7, 26, 841, DateTimeKind.Local), "Harum illum natus molestias sunt.", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 11, 20, 48, 66, DateTimeKind.Local), "Veritatis voluptatibus similique qui quia voluptate error et.", "e52db057-e8ba-4a30-b771-e5b3982d6721", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 2, 35, 33, 108, DateTimeKind.Local), "Laboriosam aut libero amet occaecati est non qui deserunt sit.", "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 20, 58, 8, 197, DateTimeKind.Local), "Impedit rerum odio est iusto vel.", "e52db057-e8ba-4a30-b771-e5b3982d6721" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 17, 57, 19, 38, DateTimeKind.Local), "Quia error pariatur maxime impedit dolores.", "e52db057-e8ba-4a30-b771-e5b3982d6721", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 56, 13, 366, DateTimeKind.Local), "Veniam distinctio aut cum sed totam sapiente molestiae.", "d8deb96d-e4ec-4100-9238-de69c5786c38", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 9, 25, 26, 742, DateTimeKind.Local), "Totam repellendus ut hic.", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 17, 25, 19, 87, DateTimeKind.Local), "Sunt atque facilis exercitationem pariatur nemo rerum et voluptas perspiciatis.", "dfc5a668-78f7-4868-bb28-5fb599184b2f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 21, 37, 31, 599, DateTimeKind.Local), "Omnis voluptas error eos maxime facere.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 10, 59, 20, 267, DateTimeKind.Local), "Molestiae voluptatem aut reprehenderit voluptatem.", "14fb8ee9-92d8-4aec-811c-f12481229d30" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 11, 2, 45, 166, DateTimeKind.Local), "Doloremque et dolorum expedita temporibus et est et.", "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 1, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "14fb8ee9-92d8-4aec-811c-f12481229d30" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 0, "e52db057-e8ba-4a30-b771-e5b3982d6721" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 9, 6, 351, DateTimeKind.Local), 16, "Aliquam dolore fugiat est quis sunt.", "14fb8ee9-92d8-4aec-811c-f12481229d30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 0, 13, 886, DateTimeKind.Local), 17, "Asperiores sequi aut quam sed quia ea hic quibusdam enim.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 26, 24, 508, DateTimeKind.Local), "Natus et sapiente eveniet molestias maiores unde.", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 23, 2, 53, DateTimeKind.Local), "Consectetur ea voluptas repellat qui eos necessitatibus.", "e52db057-e8ba-4a30-b771-e5b3982d6721" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 57, 18, 496, DateTimeKind.Local), 13, "Sapiente sint ipsa deserunt eos esse sit tenetur sit.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 49, 36, 149, DateTimeKind.Local), 20, "Consequatur consequuntur et quae.", "e52db057-e8ba-4a30-b771-e5b3982d6721" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 19, 52, 686, DateTimeKind.Local), 14, "Officia illum aut omnis quidem hic et voluptate.", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 29, 52, 641, DateTimeKind.Local), 18, "Temporibus sapiente dignissimos vero repudiandae.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 11, 21, 969, DateTimeKind.Local), 13, "Consequatur atque sunt sed quidem harum animi.", "886b78f3-1a13-4eda-bd05-da5f9ceb3359" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 47, 59, 598, DateTimeKind.Local), 14, "Corporis aut quis cumque doloremque fugiat et laudantium voluptatem unde.", "886b78f3-1a13-4eda-bd05-da5f9ceb3359" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "333.479.5985", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "Recusandae voluptatem et. A aut ut aliquid. Voluptatem vel quidem voluptas et eos qui.", "Bessie48@yahoo.com", "Company224", 61, "http://kitty.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-594-664-9805 x46251", "d8deb96d-e4ec-4100-9238-de69c5786c38", "Quasi optio illo a omnis omnis qui excepturi. Sed ab sed ab porro dolores vitae. Voluptatem ducimus odio non cumque harum. Porro ut error quis est numquam et reiciendis qui iusto.", "Gordon.Boyle@yahoo.com", "Company829", 70, "http://margarete.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "484-665-5301 x22139", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", "Architecto est laborum omnis nesciunt voluptatem corrupti veniam.", "Ralph.Durgan89@hotmail.com", "Company763", "https://nelda.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "497.896.7668", "dfc5a668-78f7-4868-bb28-5fb599184b2f", "", "Wilson75@hotmail.com", "Company300", 62, "http://adrain.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "712-484-3893", "14fb8ee9-92d8-4aec-811c-f12481229d30", "Nobis facere et quo omnis fuga accusantium eum exercitationem necessitatibus. Qui rerum saepe corrupti rerum id accusantium. Ad sed est ab.", "Devyn34@yahoo.com", "Company840", 65, "http://alexandrine.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-650-699-8703 x99419", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "", "Kari_Bruen7@gmail.com", "Company434", 64, "http://myah.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(899) 314-6268", "886b78f3-1a13-4eda-bd05-da5f9ceb3359", "", "Doug_Heaney84@yahoo.com", "Company960", 65, "http://billy.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(461) 307-7995", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "Blanditiis reiciendis voluptatum molestias eius quod ratione excepturi vel accusamus. Vitae et quisquam modi. Ipsum deleniti alias eum sit. Rerum tempora maiores consequuntur sint dicta praesentium aut.", "Bo_Williamson58@gmail.com", "Company103", 66, "https://oral.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(554) 935-4745 x477", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2", "", "Wilfrid36@yahoo.com", "Company931", 66, "http://lloyd.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "919-278-2423", "d35bccfa-a9f4-456c-a18f-e334c78563f0", "Culpa alias sunt sapiente. Rem iusto voluptates. Fugit qui ad fugiat similique labore cupiditate asperiores quia ducimus.", "Amely_Ward@gmail.com", "Company93", 64, "http://helmer.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 15, 36, 537, DateTimeKind.Local), 43, "Blanditiis dicta earum et fugit.", "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 41, 52, 969, DateTimeKind.Local), 46, "Mollitia nostrum et consequatur qui sit consectetur iusto sequi.", "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 12, 21, 727, DateTimeKind.Local), 45, "Ut qui quaerat soluta ut fugit doloribus voluptatem.", "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 41, 25, 738, DateTimeKind.Local), 43, "Iste ipsa porro eos iusto quo autem.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 32, 9, 981, DateTimeKind.Local), 43, "Enim sapiente ut atque consequatur quasi quam odit aliquam minus.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 42, 28, 46, DateTimeKind.Local), "Et et accusamus aliquam.", "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 20, 26, 725, DateTimeKind.Local), 48, "Maxime quo nostrum.", "14fb8ee9-92d8-4aec-811c-f12481229d30" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 40, 26, 809, DateTimeKind.Local), 50, "Animi quasi omnis eligendi dolorem doloribus quisquam aperiam.", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 37, 54, 860, DateTimeKind.Local), 46, "Accusamus voluptatem rerum.", "886b78f3-1a13-4eda-bd05-da5f9ceb3359" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 57, 32, 450, DateTimeKind.Local), 44, "Alias vitae quas non et dolores officia.", "c5dd7424-d8cc-404d-ad1d-d3d2362130c2" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "d35bccfa-a9f4-456c-a18f-e334c78563f0", 79, 1 },
                    { "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", 77, 1 },
                    { "d8deb96d-e4ec-4100-9238-de69c5786c38", 74, 1 },
                    { "dfc5a668-78f7-4868-bb28-5fb599184b2f", 73, 1 },
                    { "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", 77, 1 },
                    { "c5dd7424-d8cc-404d-ad1d-d3d2362130c2", 74, 1 },
                    { "e52db057-e8ba-4a30-b771-e5b3982d6721", 77, 1 },
                    { "14fb8ee9-92d8-4aec-811c-f12481229d30", 72, 1 },
                    { "886b78f3-1a13-4eda-bd05-da5f9ceb3359", 72, 1 },
                    { "d5027330-edba-46bd-87e8-5d17cafec535", 72, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14fb8ee9-92d8-4aec-811c-f12481229d30", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "886b78f3-1a13-4eda-bd05-da5f9ceb3359", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c5dd7424-d8cc-404d-ad1d-d3d2362130c2", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d35bccfa-a9f4-456c-a18f-e334c78563f0", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d5027330-edba-46bd-87e8-5d17cafec535", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d8deb96d-e4ec-4100-9238-de69c5786c38", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "dfc5a668-78f7-4868-bb28-5fb599184b2f", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e52db057-e8ba-4a30-b771-e5b3982d6721", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14fb8ee9-92d8-4aec-811c-f12481229d30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4e50b15b-ec6b-4ee4-941e-099d059e4bb2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "886b78f3-1a13-4eda-bd05-da5f9ceb3359");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c5dd7424-d8cc-404d-ad1d-d3d2362130c2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d35bccfa-a9f4-456c-a18f-e334c78563f0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d5027330-edba-46bd-87e8-5d17cafec535");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d8deb96d-e4ec-4100-9238-de69c5786c38");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dfc5a668-78f7-4868-bb28-5fb599184b2f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e52db057-e8ba-4a30-b771-e5b3982d6721");

            migrationBuilder.DropColumn(
                name: "StatusCheckedAt",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 38, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 24, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 83 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 28, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 16, 59, 891, DateTimeKind.Local), 83, "Title722" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 15, 5, 78, DateTimeKind.Local), 82, "Title821" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 27, 12, 317, DateTimeKind.Local), 83, "Title766" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 24, 17, 16, DateTimeKind.Local), 83, "Title922" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 38, 28, 262, DateTimeKind.Local), 87, "Title172" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 54, 3, 699, DateTimeKind.Local), 86, "Title641" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 52, 5, 534, DateTimeKind.Local), "Title709" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 56, 45, 392, DateTimeKind.Local), 85, "Title159" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 41, 18, 205, DateTimeKind.Local), 86, "Title283" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 51, 20, 966, DateTimeKind.Local), 86, "Title966" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "37:22:f2:5d:8c:f8", false, false, false, 0f, 0f, 76, "Linux", 0f, "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "7a:db:32:bb:5b:c2", false, false, false, 0f, 0f, 78, "Linux", 0f, "Instance369" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "a1:b5:02:9d:a2:a3", false, false, false, 0f, 0f, 0f, "Instance970" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "88:08:62:98:11:a9", false, false, false, 0f, 0f, 0f, "Instance610" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "b3:16:96:4a:c8:63", false, false, false, 0f, 0f, 73, 0f, "Instance896" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "ba:95:d0:cb:af:81", false, false, false, 0f, 0f, 72, 0f, "Instance34" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "80:e3:45:08:d5:72", false, false, false, 0f, 0f, 75, "Windows", 0f, "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "0b:22:7d:81:af:8a", false, false, false, 0f, 0f, 72, "Linux", 0f, "Instance664" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "5e:9e:9e:7d:9b:f2", false, false, false, 0f, 0f, 73, "Linux", 0f, "Instance833" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "89:61:dc:fc:f6:cf", false, false, false, 0f, 0f, 79, 0f, "Instance909" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme751" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme79" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme242" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme206" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme483" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme13" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme407" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme786" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme921" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", null, new DateTime(2018, 9, 9, 19, 6, 27, 318, DateTimeKind.Local), "Zelma", "Elmore.Heller29@yahoo.com", null, "Maida", true, false, "Mayert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/karolkrakowiak_/128.jpg", 1 },
                    { "48496f80-3505-4088-bce9-721237904d3e", null, new DateTime(2018, 9, 10, 4, 35, 50, 455, DateTimeKind.Local), "Mandy", "Jazmyn66@yahoo.com", null, "Margret", true, false, "Nikolaus", null, "https://s3.amazonaws.com/uifaces/faces/twitter/renbyrd/128.jpg", 1 },
                    { "79e46537-a194-4592-b5ab-04b90c068eb3", null, new DateTime(2018, 9, 10, 6, 5, 32, 507, DateTimeKind.Local), "Alycia", "Julio.Goodwin40@gmail.com", null, "Brook", true, false, "Robel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ernestsemerda/128.jpg", 2 },
                    { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", null, new DateTime(2018, 9, 9, 18, 21, 41, 839, DateTimeKind.Local), "Emery", "Wilhelmine_Hane@hotmail.com", null, "Germaine", true, false, "Grimes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oaktreemedia/128.jpg", 1 },
                    { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", null, new DateTime(2018, 9, 10, 0, 45, 46, 297, DateTimeKind.Local), "Agustina", "Odessa.Leannon@yahoo.com", null, "Axel", true, false, "Fay", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nckjrvs/128.jpg", 1 },
                    { "31d1aeea-fca1-4233-a640-d19ec2d5690a", null, new DateTime(2018, 9, 9, 23, 14, 45, 22, DateTimeKind.Local), "Destini", "Enos.Schinner@yahoo.com", null, "Russell", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samgrover/128.jpg", 1 },
                    { "ec62c0a6-f281-40a1-a913-35c180dc66fd", null, new DateTime(2018, 9, 10, 8, 54, 43, 614, DateTimeKind.Local), "Bridgette", "Micheal_Dicki@gmail.com", null, "Simeon", true, false, "Gottlieb", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bagawarman/128.jpg", 1 },
                    { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", null, new DateTime(2018, 9, 9, 19, 33, 28, 461, DateTimeKind.Local), "Pansy", "Savanah.Blick@yahoo.com", null, "Melisa", true, false, "White", null, "https://s3.amazonaws.com/uifaces/faces/twitter/madewulf/128.jpg", 1 },
                    { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", null, new DateTime(2018, 9, 9, 21, 12, 13, 440, DateTimeKind.Local), "Madalyn", "Lura.Abbott98@yahoo.com", null, "Blanche", true, false, "Kessler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bereto/128.jpg", 2 },
                    { "733804e3-2791-4002-81c8-c134b163717b", null, new DateTime(2018, 9, 10, 1, 9, 38, 564, DateTimeKind.Local), "Domenic", "Quincy_Cummerata84@yahoo.com", null, "Eula", true, false, "Rippin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/arindam_/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "31d1aeea-fca1-4233-a640-d19ec2d5690a", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "733804e3-2791-4002-81c8-c134b163717b", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", "rerum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48496f80-3505-4088-bce9-721237904d3e", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", "veritatis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", "quasi" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 54, 54, 778, DateTimeKind.Local), "Nemo molestiae ipsum.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 2, 23, 793, DateTimeKind.Local), "Et est aliquid provident ut.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 6, 1, 775, DateTimeKind.Local), "Voluptas beatae aut.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 9, 48, 5, 352, DateTimeKind.Local), "Possimus laudantium perferendis.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 36, 38, 179, DateTimeKind.Local), "Eos dolorum unde omnis commodi recusandae soluta.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 37, 6, 418, DateTimeKind.Local), "Consequatur deserunt fugiat.", "31d1aeea-fca1-4233-a640-d19ec2d5690a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 19, 42, 479, DateTimeKind.Local), "Qui vel rerum nihil est quibusdam ea.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 24, 38, 234, DateTimeKind.Local), "Accusamus neque quis nulla voluptates dolores tempore error corrupti.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 37, 26, 100, DateTimeKind.Local), "Ipsum suscipit dolores sunt saepe enim architecto molestias reiciendis.", "31d1aeea-fca1-4233-a640-d19ec2d5690a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 8, 51, 208, DateTimeKind.Local), "Rerum harum reprehenderit soluta.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 20, 36, 21, 994, DateTimeKind.Local), "Ut praesentium dolor voluptas.", "48496f80-3505-4088-bce9-721237904d3e", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 9, 21, 6, 38, 692, DateTimeKind.Local), "Qui eius ut.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 20, 48, 3, 467, DateTimeKind.Local), "Saepe adipisci alias voluptatem ut aut nihil sapiente.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 9, 14, 27, 17, 993, DateTimeKind.Local), "Ut dolores dolor corporis voluptatem illo quia id numquam iure.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 42, 18, 245, DateTimeKind.Local), "Accusantium beatae et sunt velit reiciendis et debitis.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 7, 35, 39, 765, DateTimeKind.Local), "Aut ut aut earum vero.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 9, 12, 9, 11, 787, DateTimeKind.Local), "Velit sint et quasi soluta aut similique enim aliquam voluptatum.", "733804e3-2791-4002-81c8-c134b163717b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 15, 23, 15, 962, DateTimeKind.Local), "Non earum ut et id nemo quisquam similique.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 6, 31, 5, 489, DateTimeKind.Local), "Maiores quia quis earum itaque qui.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 20, 10, 30, 838, DateTimeKind.Local), "Architecto officiis nobis quia.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 2, "79e46537-a194-4592-b5ab-04b90c068eb3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 0, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 2, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 3, 50, 887, DateTimeKind.Local), 15, "Laborum tempora enim consequatur voluptas et odit at corporis modi.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 35, 42, 256, DateTimeKind.Local), 11, "Ratione neque eum animi omnis.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 44, 47, 498, DateTimeKind.Local), "Cupiditate unde voluptatibus eos tenetur.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 26, 33, 203, DateTimeKind.Local), "Culpa in et aut.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 9, 51, 365, DateTimeKind.Local), 11, "Et pariatur ea commodi rerum earum.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 4, 59, 198, DateTimeKind.Local), 18, "Qui ducimus voluptas adipisci consequuntur.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 7, 59, 242, DateTimeKind.Local), 11, "Vero aut sequi accusantium qui ut.", "79e46537-a194-4592-b5ab-04b90c068eb3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 5, 51, 545, DateTimeKind.Local), 17, "Dolores provident quam ex sunt nulla ut id.", "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 3, 29, 820, DateTimeKind.Local), 19, "Molestiae debitis blanditiis blanditiis debitis ducimus eum ad.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 3, 23, 887, DateTimeKind.Local), 11, "Iure ex facere qui consequatur laudantium expedita nam minima consequatur.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "711.651.8263", "48496f80-3505-4088-bce9-721237904d3e", "Inventore omnis consequatur sit. Autem ut saepe dolores debitis quaerat distinctio consequatur. Debitis quo delectus vero dignissimos possimus a illum dolor. Et non vel ad ipsa totam.", "Vincenzo61@yahoo.com", "Company998", 69, "https://jolie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(851) 373-1278 x02293", "31d1aeea-fca1-4233-a640-d19ec2d5690a", "Velit architecto pariatur accusantium facere molestiae. Omnis dignissimos eligendi est recusandae voluptates aliquid.", "Cicero94@yahoo.com", "Company162", 65, "http://casey.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-211-966-4607 x80803", "48496f80-3505-4088-bce9-721237904d3e", "Voluptatum laboriosam nulla sed corrupti aut exercitationem voluptatibus.", "Bernita_Bayer@gmail.com", "Company944", "https://clemens.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-246-456-0031 x633", "733804e3-2791-4002-81c8-c134b163717b", "Cupiditate voluptate deserunt veritatis illum quia praesentium suscipit vitae.", "Whitney.Sipes@gmail.com", "Company409", 70, "http://river.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "811-998-1747 x598", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "", "Estel_McGlynn@yahoo.com", "Company727", 68, "http://howell.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-219-481-5686 x261", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Quia ratione aperiam assumenda magnam omnis.", "Ward_Hauck97@yahoo.com", "Company515", 65, "http://garrett.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(756) 217-5288 x0980", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", "Dolorem ab id dolor facere.", "Arvel.Boyer@gmail.com", "Company835", 70, "http://leila.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(755) 580-7585 x792", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "", "Afton66@hotmail.com", "Company360", 62, "http://lindsey.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-223-240-3397 x2150", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", "Aliquid officia adipisci occaecati earum distinctio.", "Ada16@hotmail.com", "Company387", 63, "http://johnnie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "513-788-7830 x8497", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Est ipsam aut et iusto sit rerum delectus vel. Repellendus sapiente nihil dignissimos. Impedit quia qui minus assumenda. Quaerat autem et consectetur.", "Keely33@hotmail.com", "Company433", 68, "http://janice.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 9, 32, 3, 297, DateTimeKind.Local), 42, "Qui rerum in et occaecati.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 12, 2, 129, DateTimeKind.Local), 41, "Et enim explicabo quas consequatur voluptatem non nemo nostrum.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 53, 18, 245, DateTimeKind.Local), 43, "Ea consequatur qui.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 4, 37, 882, DateTimeKind.Local), 46, "Maxime doloribus libero nihil maxime.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 31, 13, 895, DateTimeKind.Local), 44, "Et quae iste quia quia.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 34, 13, 587, DateTimeKind.Local), "Debitis dolorum nihil.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 54, 15, 772, DateTimeKind.Local), 41, "Ipsum et ut voluptas.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 32, 36, 556, DateTimeKind.Local), 47, "Accusamus consequuntur non animi.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 31, 9, 531, DateTimeKind.Local), 42, "Et eaque cum sint ut delectus illum illum aut.", "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 27, 49, 198, DateTimeKind.Local), 47, "At expedita animi suscipit voluptatem in quaerat.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", 73, 1 },
                    { "48496f80-3505-4088-bce9-721237904d3e", 77, 1 },
                    { "ec62c0a6-f281-40a1-a913-35c180dc66fd", 72, 1 },
                    { "31d1aeea-fca1-4233-a640-d19ec2d5690a", 79, 1 },
                    { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", 71, 1 },
                    { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", 71, 1 },
                    { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", 72, 1 },
                    { "79e46537-a194-4592-b5ab-04b90c068eb3", 74, 1 },
                    { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", 78, 1 },
                    { "733804e3-2791-4002-81c8-c134b163717b", 77, 1 }
                });
        }
    }
}
