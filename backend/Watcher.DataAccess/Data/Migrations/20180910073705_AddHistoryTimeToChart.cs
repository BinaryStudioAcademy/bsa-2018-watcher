using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddHistoryTimeToChart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0da18978-1656-4b4d-ac10-940871d87e18", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14e7d6f2-3626-423b-959b-e8ca1b882173", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "732bab35-8c9e-4812-b4ff-251abdf5b857", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9a549b2b-8fd0-4d70-9145-569474fea109", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b22d062-92ae-494c-9481-11c2931737da");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0bddde5f-5756-4d7f-8521-42d0476f3aa0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0da18978-1656-4b4d-ac10-940871d87e18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14e7d6f2-3626-423b-959b-e8ca1b882173");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36410a7e-ff1b-4570-8a45-82e6d045bfda");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6aa322ac-217f-449e-8ebf-12b4f2e2436c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "732bab35-8c9e-4812-b4ff-251abdf5b857");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9a549b2b-8fd0-4d70-9145-569474fea109");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd12165e-60bb-40a0-a6da-ee98a35e2a2c");

            migrationBuilder.AddColumn<int>(
                name: "HistoryTime",
                table: "Charts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 92, 5, 38, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 98, 5, 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold" },
                values: new object[] { 99, 5, 89 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold" },
                values: new object[] { 92, 5, 18 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 96, 5, 37, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 93, 5, 24, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold" },
                values: new object[] { 98, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 96, 5, 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 91, 5, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "HistoryTime", "Threshold", "Type" },
                values: new object[] { 91, 5, 28, 1 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 38, 28, 262, DateTimeKind.Local), "Title172" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e8:d9:78:67:af:b3", 76, "Instance543" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b7:31:83:93:1b:c9", 72, "Windows", "Instance184" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "14:7c:f9:1e:9e:63", 80, "Instance814" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "49:c2:6b:97:56:ef", 75, "Instance613" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1e:db:44:46:0d:01", 78, "Windows", "Instance758" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a1:db:5f:5c:24:6c", 79, "Linux", "Instance520" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c3:56:da:8a:2b:f5", 78, "Windows", "Instance785" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4b:dc:1d:3d:10:38", 73, "Linux", "Instance237" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a5:23:bb:36:03:6e", 74, "Linux", "Instance63" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "0f:23:83:76:cf:c7", "Windows", "Instance449" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme751");

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme242" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme206" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme483" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme921" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 20, 36, 21, 994, DateTimeKind.Local), "Ut praesentium dolor voluptas.", "48496f80-3505-4088-bce9-721237904d3e" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 27, 17, 993, DateTimeKind.Local), "Ut dolores dolor corporis voluptatem illo quia id numquam iure.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 10, 42, 18, 245, DateTimeKind.Local), "Accusantium beatae et sunt velit reiciendis et debitis.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 7, 35, 39, 765, DateTimeKind.Local), "Aut ut aut earum vero.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 6, 31, 5, 489, DateTimeKind.Local), "Maiores quia quis earum itaque qui.", "733804e3-2791-4002-81c8-c134b163717b", true });

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
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 1, "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

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
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

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
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 44, 47, 498, DateTimeKind.Local), 14, "Cupiditate unde voluptatibus eos tenetur.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 26, 33, 203, DateTimeKind.Local), 13, "Culpa in et aut.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 7, 59, 242, DateTimeKind.Local), "Vero aut sequi accusantium qui ut.", "79e46537-a194-4592-b5ab-04b90c068eb3" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-211-966-4607 x80803", "48496f80-3505-4088-bce9-721237904d3e", "Voluptatum laboriosam nulla sed corrupti aut exercitationem voluptatibus.", "Bernita_Bayer@gmail.com", "Company944", 63, "https://clemens.info" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "811-998-1747 x598", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "Estel_McGlynn@yahoo.com", "Company727", 68, "http://howell.com" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 12, 2, 129, DateTimeKind.Local), "Et enim explicabo quas consequatur voluptatem non nemo nostrum.", "733804e3-2791-4002-81c8-c134b163717b" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 31, 13, 895, DateTimeKind.Local), "Et quae iste quia quia.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 34, 13, 587, DateTimeKind.Local), 44, "Debitis dolorum nihil.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "HistoryTime",
                table: "Charts");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 14, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 59, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 73 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 76, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 98 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 40, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 78, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 13, 23, 708, DateTimeKind.Local), 82, "Title187" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 7, 26, 619, DateTimeKind.Local), 84, "Title344" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 26, 18, 615, DateTimeKind.Local), 85, "Title328" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 20, 43, 423, DateTimeKind.Local), 82, "Title568" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 3, 4, 274, DateTimeKind.Local), "Title317" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 7, 13, 27, 393, DateTimeKind.Local), 85, "Title756" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 36, 59, 89, DateTimeKind.Local), "Title712" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 18, 28, 429, DateTimeKind.Local), 89, "Title719" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 42, 20, 709, DateTimeKind.Local), 84, "Title235" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 4, 23, 15, 916, DateTimeKind.Local), 90, "Title956" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "54:bc:6c:85:e1:55", 78, "Instance802" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "93:89:86:96:e6:11", 79, "Linux", "Instance46" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2d:74:0e:71:6f:7a", 76, "Instance819" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "04:d6:00:79:e3:b7", 72, "Instance161" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "df:be:1e:09:9c:ab", 74, "Linux", "Instance856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5e:42:96:2e:00:e0", 77, "Windows", "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c8:5c:b1:ee:61:bc", 76, "Linux", "Instance85" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e7:0a:de:ee:bf:6e", 74, "Windows", "Instance701" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "16:66:b1:ef:be:c1", 73, "Windows", "Instance831" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "09:2f:b3:74:1b:82", "Linux", "Instance474" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme497");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme140" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme871" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme602" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme326" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme509" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme91" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme292" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme180" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme513" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", null, new DateTime(2018, 9, 9, 13, 36, 12, 571, DateTimeKind.Local), "Leslie", "Javier.Paucek@gmail.com", null, "Rylee", true, false, "Kuhlman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joreira/128.jpg", 2 },
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", null, new DateTime(2018, 9, 9, 1, 55, 45, 527, DateTimeKind.Local), "Ethyl", "Raphael.Murazik@hotmail.com", null, "Cali", true, false, "Kutch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tobysaxon/128.jpg", 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", null, new DateTime(2018, 9, 9, 5, 37, 2, 549, DateTimeKind.Local), "Winston", "Austyn77@yahoo.com", null, "Shayna", true, false, "Parker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gearpixels/128.jpg", 1 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", null, new DateTime(2018, 9, 9, 19, 34, 7, 631, DateTimeKind.Local), "Andrew", "Ezekiel.Hermiston1@yahoo.com", null, "Grover", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/angelceballos/128.jpg", 2 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", null, new DateTime(2018, 9, 9, 8, 19, 36, 70, DateTimeKind.Local), "Makenna", "Davin_Schulist60@gmail.com", null, "Crawford", true, false, "Gaylord", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 2 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", null, new DateTime(2018, 9, 9, 4, 14, 16, 766, DateTimeKind.Local), "Rodrigo", "Benton14@yahoo.com", null, "Tom", true, false, "Hauck", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bargaorobalo/128.jpg", 1 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", null, new DateTime(2018, 9, 9, 3, 38, 22, 832, DateTimeKind.Local), "Jacinthe", "Zoe82@gmail.com", null, "Kellie", true, false, "Stehr", null, "https://s3.amazonaws.com/uifaces/faces/twitter/suribbles/128.jpg", 2 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", null, new DateTime(2018, 9, 9, 11, 48, 24, 489, DateTimeKind.Local), "Hope", "Sydnee90@yahoo.com", null, "Oliver", true, false, "Hoppe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bobbytwoshoes/128.jpg", 1 },
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", null, new DateTime(2018, 9, 9, 0, 52, 56, 943, DateTimeKind.Local), "Adan", "Bridget74@yahoo.com", null, "Jacky", true, false, "Keebler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 1 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", null, new DateTime(2018, 9, 9, 14, 28, 5, 94, DateTimeKind.Local), "Dillan", "Justus44@hotmail.com", null, "Carmel", true, false, "Bradtke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samihah/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0da18978-1656-4b4d-ac10-940871d87e18", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", "aliquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9a549b2b-8fd0-4d70-9145-569474fea109", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "recusandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "animi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "14e7d6f2-3626-423b-959b-e8ca1b882173", "quos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "id" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 52, 11, 195, DateTimeKind.Local), "Nulla et perspiciatis.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 29, 5, 920, DateTimeKind.Local), "Et est voluptatibus et qui cumque eos nesciunt praesentium illo.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 25, 23, 926, DateTimeKind.Local), "Adipisci quo dolores animi quo doloribus qui eos velit unde.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 8, 28, 32, DateTimeKind.Local), "Sequi reprehenderit est delectus sit dolor.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 8, 1, 415, DateTimeKind.Local), "Repellendus error officia tenetur et qui possimus voluptas.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 51, 41, 285, DateTimeKind.Local), "Consequatur dolor quia.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 4, 16, 23, 539, DateTimeKind.Local), "Ad fugiat odit quam modi et debitis est perspiciatis.", "6aa322ac-217f-449e-8ebf-12b4f2e2436c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 23, 54, 56, 711, DateTimeKind.Local), "Est ipsa consequatur ut provident ab.", "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 44, 49, 86, DateTimeKind.Local), "Maxime earum odit et non quisquam occaecati nobis aut.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 51, 6, 29, DateTimeKind.Local), "Quas quas exercitationem officiis et error cumque impedit.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 4, 38, 36, 540, DateTimeKind.Local), "Voluptatum adipisci repellendus vitae facilis odit.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 7, 44, 12, 280, DateTimeKind.Local), "Quia eaque reiciendis id non.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 18, 34, 36, 38, DateTimeKind.Local), "Sequi odit inventore unde quibusdam tempore voluptates consequuntur et.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 21, 58, 678, DateTimeKind.Local), "Quam culpa qui autem accusamus.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 6, 44, 26, 9, DateTimeKind.Local), "Nihil quia ad et odio et dolorem.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 0, 54, 33, 391, DateTimeKind.Local), "Est sed pariatur.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 13, 45, 57, 927, DateTimeKind.Local), "Numquam facere ipsa porro.", "0b22d062-92ae-494c-9481-11c2931737da", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 21, 9, 39, 318, DateTimeKind.Local), "Qui ut non accusamus quos voluptas voluptatum.", "36410a7e-ff1b-4570-8a45-82e6d045bfda", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 9, 1, 15, 27, 632, DateTimeKind.Local), "Maiores dolor nihil earum suscipit at consectetur non et sunt.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 16, 35, 21, 699, DateTimeKind.Local), "Minima natus unde dicta aspernatur earum deserunt sint tempora reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 4, "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "6aa322ac-217f-449e-8ebf-12b4f2e2436c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 37, 9, 256, DateTimeKind.Local), 16, "Tempora omnis nobis a enim explicabo qui vitae.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 58, 14, 361, DateTimeKind.Local), 18, "Aut adipisci facere perferendis.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 26, 37, 181, DateTimeKind.Local), 13, "Porro et architecto nulla.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 49, 50, 408, DateTimeKind.Local), 17, "Sequi eius est dolores aspernatur.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 29, 11, 14, DateTimeKind.Local), 12, "Doloremque impedit quod aut odit dolore delectus fuga rem mollitia.", "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 23, 32, 536, DateTimeKind.Local), 13, "Officiis dolores dolores tenetur nesciunt.", "36410a7e-ff1b-4570-8a45-82e6d045bfda" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 20, 10, 310, DateTimeKind.Local), "Et beatae non non natus quasi fugit officiis.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 54, 34, 750, DateTimeKind.Local), 20, "Soluta sit iure est qui odit.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 0, 37, 52, 879, DateTimeKind.Local), 20, "Unde accusantium accusamus.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 57, 27, 602, DateTimeKind.Local), 18, "Quis sint beatae assumenda.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "439-419-3955 x8548", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Adipisci molestias non quisquam earum dolorum molestias iste. Explicabo ea ut mollitia itaque repudiandae. Est unde quasi.", "Jarrod_Hammes29@gmail.com", "Company541", 67, "https://chadrick.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(204) 999-6677 x405", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "", "Domingo.Stiedemann@yahoo.com", "Company114", 67, "http://janis.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(440) 509-1684", "14e7d6f2-3626-423b-959b-e8ca1b882173", "", "Sofia_Schaefer8@hotmail.com", "Company613", 69, "http://lew.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "662.300.3345", "14e7d6f2-3626-423b-959b-e8ca1b882173", "Nostrum iusto voluptatem culpa ut.", "Madyson19@hotmail.com", "Company435", 68, "https://mose.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "614.292.9580 x822", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Alessandra.Heller42@gmail.com", "Company165", 67, "https://kamron.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-958-620-8119 x139", "0da18978-1656-4b4d-ac10-940871d87e18", "", "Elias.Schmeler76@yahoo.com", "Company221", 61, "http://bert.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "631.889.3525 x9022", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Enim sit quia nemo tempore accusantium. Voluptatibus eum aliquid ab. Mollitia iure doloremque omnis quaerat voluptatem ut suscipit.", "Dorothy.Torphy@hotmail.com", "Company782", 68, "https://alvina.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(938) 960-5637", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Quo consequatur vero sint ut autem aut doloremque ullam laborum. Rerum repellendus est qui sit rerum.", "Juliet_Powlowski@yahoo.com", "Company297", 65, "https://josiane.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(259) 858-0505 x993", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Dicta a hic tempora illo dolorem. Dolorum voluptas nemo ea ea.", "Lura_Kling61@yahoo.com", "Company833", 64, "http://marianna.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(732) 704-3028 x624", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Id modi distinctio animi dolorem. Amet quia sint id harum exercitationem.", "Madison.Collins@yahoo.com", "Company179", 70, "http://orlo.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 10, 3, 91, DateTimeKind.Local), 41, "Voluptas enim laborum ex explicabo voluptates est sequi.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 27, 14, 956, DateTimeKind.Local), "Saepe alias maiores aut qui ea delectus.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 59, 34, 800, DateTimeKind.Local), 48, "Modi sed quo doloremque quis atque incidunt corporis qui.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 27, 16, 499, DateTimeKind.Local), 50, "Animi consequatur molestiae omnis.", "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 58, 39, 165, DateTimeKind.Local), "Et aut ea accusamus aliquam.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 34, 33, 692, DateTimeKind.Local), 49, "Quia qui ad nihil reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 24, 31, 160, DateTimeKind.Local), 49, "Libero consectetur alias dolorum deleniti.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 54, 52, 111, DateTimeKind.Local), 46, "Omnis recusandae consectetur magnam provident explicabo.", "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 36, 22, 152, DateTimeKind.Local), 41, "Nesciunt aperiam recusandae tempore a.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 3, 44, 42, 883, DateTimeKind.Local), 49, "Id quia unde quae eveniet delectus ea.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", 71, 1 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", 77, 1 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", 76, 1 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 76, 1 },
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 73, 1 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 74, 1 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 75, 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", 74, 1 },
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", 72, 1 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", 79, 1 }
                });
        }
    }
}
