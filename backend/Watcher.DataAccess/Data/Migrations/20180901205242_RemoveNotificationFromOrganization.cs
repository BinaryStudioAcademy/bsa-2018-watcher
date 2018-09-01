using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class RemoveNotificationFromOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Organizations_OrganizationId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_OrganizationId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8a65aa2c-1690-4985-b55a-52cad5015049", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9022ac94-1cd8-46cc-a0a8-b24258800d30", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f0a5b62a-da54-4712-9452-6440ef65945d", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f851c462-8fe4-48e6-bb81-4d9cfb740521", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0cc0334a-a604-4fef-89b6-677392e535c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45c5b61c-04f3-410b-a4bb-70c0b3d71dab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7221ab73-0b1e-474a-912b-9aa7ace94fdf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8a65aa2c-1690-4985-b55a-52cad5015049");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9022ac94-1cd8-46cc-a0a8-b24258800d30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cf19e2fd-f01a-4d18-bf12-fd1be10a4299");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f0a5b62a-da54-4712-9452-6440ef65945d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f851c462-8fe4-48e6-bb81-4d9cfb740521");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", false, 92, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", false, 35, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, false, 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 92, false, 93 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", false, 21, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", false, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", false, 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, false, 59, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 99, "MostLoaded2", false, 30 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", false, 45, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 13, 46, 552, DateTimeKind.Local), 85, "Title393" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 14, 42, 744, DateTimeKind.Local), 86, "Title649" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 15, 31, 10, 63, DateTimeKind.Local), 87, "Title369" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 10, 28, 226, DateTimeKind.Local), 83, "Title718" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 46, 17, 771, DateTimeKind.Local), 89, "Title472" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 37, 15, 617, DateTimeKind.Local), 89, "Title404" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 4, 35, 12, 8, DateTimeKind.Local), 84, "Title804" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 27, 43, 183, DateTimeKind.Local), 86, "Title641" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 18, 15, 52, 397, DateTimeKind.Local), 87, "Title322" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 34, 41, 251, DateTimeKind.Local), 86, "Title953" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b4:19:1b:2e:8a:be", 75, "Linux", "Instance159" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "81:0f:9d:6e:dc:ac", 72, "Windows", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5f:b5:e2:dd:06:44", 73, "Windows", "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "92:bb:36:33:cf:da", 72, "Instance441" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "83:4f:14:bc:d7:58", 71, "Windows", "Instance820" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2b:c0:da:2b:c7:ff", 73, "Instance617" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:5b:c4:b0:49:c5", 79, "Instance153" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:cc:7b:80:7a:10", 77, "Instance619" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "34:92:85:5c:37:d1", 79, "Windows", "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a3:e5:3a:8c:fb:27", 76, "Windows", "Instance418" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme563");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme795" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme315" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme390" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme511" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme406" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme389" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme938" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme741" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", null, new DateTime(2018, 9, 1, 0, 28, 48, 302, DateTimeKind.Local), "Laney", "Destany.Walker@yahoo.com", null, "Kareem", true, false, "Predovic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BrianPurkiss/128.jpg", 1 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", null, new DateTime(2018, 9, 1, 12, 8, 4, 251, DateTimeKind.Local), "Deshaun", "Kiera_Gusikowski@hotmail.com", null, "Dangelo", true, false, "Upton", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidsasda/128.jpg", 2 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", null, new DateTime(2018, 9, 1, 10, 27, 25, 47, DateTimeKind.Local), "Shayna", "Hayden.Buckridge62@yahoo.com", null, "Vernice", true, false, "Hettinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Talbi_ConSept/128.jpg", 1 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", null, new DateTime(2018, 9, 1, 22, 15, 38, 588, DateTimeKind.Local), "Madelynn", "Bailee.Hudson47@hotmail.com", null, "Gabrielle", true, false, "Romaguera", null, "https://s3.amazonaws.com/uifaces/faces/twitter/drewbyreese/128.jpg", 2 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", null, new DateTime(2018, 9, 1, 6, 8, 46, 241, DateTimeKind.Local), "Ettie", "Ora_Ferry42@yahoo.com", null, "Jewel", true, false, "Heathcote", null, "https://s3.amazonaws.com/uifaces/faces/twitter/geobikas/128.jpg", 1 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", null, new DateTime(2018, 9, 1, 10, 42, 5, 898, DateTimeKind.Local), "Jodie", "Helene_Pfannerstill@yahoo.com", null, "Lemuel", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/al_li/128.jpg", 2 },
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", null, new DateTime(2018, 9, 1, 16, 45, 38, 815, DateTimeKind.Local), "Eudora", "Lavinia32@yahoo.com", null, "Tessie", true, false, "VonRueden", null, "https://s3.amazonaws.com/uifaces/faces/twitter/psdesignuk/128.jpg", 1 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", null, new DateTime(2018, 9, 1, 23, 31, 24, 903, DateTimeKind.Local), "Orion", "Leatha.Hoeger92@yahoo.com", null, "Austin", true, false, "Bernier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/r_garcia/128.jpg", 1 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", null, new DateTime(2018, 9, 1, 1, 1, 26, 128, DateTimeKind.Local), "Shawna", "Sophia.Schiller@gmail.com", null, "Flo", true, false, "Kertzmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kohette/128.jpg", 1 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", null, new DateTime(2018, 9, 1, 1, 31, 45, 433, DateTimeKind.Local), "Hyman", "Bernard40@hotmail.com", null, "Haylie", true, false, "Kulas", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kostaspt/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", "cum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedById",
                value: "37cdecd7-aaac-4dc2-9c84-7e7289b521c4");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "perferendis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", "asperiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "odit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 53, 14, 78, DateTimeKind.Local), "Numquam eveniet quo sed.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 49, 17, 251, DateTimeKind.Local), "Consequatur libero et ut facere ullam quibusdam natus id sunt.", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 14, 56, 746, DateTimeKind.Local), "Mollitia recusandae ut ab facere earum sed dolores.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 27, 52, 8, DateTimeKind.Local), "Officia cum consequuntur similique dolorem eos et eaque maiores eos.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 28, 21, 616, DateTimeKind.Local), "Rem voluptate minus libero.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 46, 42, 91, DateTimeKind.Local), "Laboriosam ea velit error veniam.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 5, 24, 16, 360, DateTimeKind.Local), "Sit quibusdam quos vel corrupti.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 31, 32, 496, DateTimeKind.Local), "Ipsum tempora id.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 23, 36, 19, 108, DateTimeKind.Local), "Magnam officiis blanditiis voluptatem odit in ut non accusamus at.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 19, 30, 190, DateTimeKind.Local), "Amet voluptatem error quis adipisci voluptatum ut.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 1, 6, 41, 58, 762, DateTimeKind.Local), "Qui eum laudantium ratione suscipit consequatur qui nulla voluptates.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 0, 19, 48, 931, DateTimeKind.Local), "Consequatur et minus quia qui fuga quia omnis.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 9, 43, 41, 791, DateTimeKind.Local), "Sed sed consequatur ad id magni.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 1, 5, 14, 7, 727, DateTimeKind.Local), "Nisi laborum molestiae unde consectetur non cumque.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 1, 11, 44, 0, 426, DateTimeKind.Local), "Voluptatem inventore et rerum minus et eaque.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 23, 9, 29, 927, DateTimeKind.Local), "Qui et et reiciendis.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 16, 15, 49, 192, DateTimeKind.Local), "Fugit omnis voluptas velit sunt qui in veniam.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 21, 12, 29, 577, DateTimeKind.Local), "Maxime numquam vitae corrupti repudiandae aut repellat.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 5, 57, 18, 812, DateTimeKind.Local), "Qui quis dolor quisquam.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 16, 37, 59, 517, DateTimeKind.Local), "Ratione veniam vel odio nesciunt doloremque laudantium sed sint.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 0, "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 4, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 6, 57, 34, 661, DateTimeKind.Local), 16, "Omnis corrupti ut aliquid tempore sint ab non.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 21, 20, 774, DateTimeKind.Local), 14, "Consectetur velit laudantium delectus et.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 24, 55, 38, DateTimeKind.Local), 20, "Illum labore ex.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 55, 23, 113, DateTimeKind.Local), 16, "Aut voluptas consequatur qui dolorem expedita corrupti et laborum illo.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 2, 41, 46, 334, DateTimeKind.Local), 19, "Et rem quibusdam quae laborum iste ex corrupti.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 45, 16, 740, DateTimeKind.Local), 13, "Expedita sapiente dolore.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 20, 26, 742, DateTimeKind.Local), 19, "Architecto voluptas autem laborum soluta corrupti sed et distinctio aliquid.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 27, 21, 972, DateTimeKind.Local), "Aliquid neque voluptas natus aut qui vel fuga.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 13, 10, 179, DateTimeKind.Local), 12, "Vel repellat non omnis et iste consequatur nobis dolores vel.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 7, 26, 469, DateTimeKind.Local), 18, "Beatae harum eligendi eos voluptatem blanditiis itaque.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(577) 691-9767", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Aut consequatur quos. Eos omnis labore sint tenetur sunt voluptas dolorem blanditiis.", "Amina36@hotmail.com", "Company845", 66, "https://malcolm.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(867) 873-0725 x4204", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "Molestiae nulla est. Modi cum eveniet culpa dolores. Voluptatibus explicabo et ut aspernatur harum cumque debitis iure optio. Est consequatur at ducimus et.", "Mozelle_Lockman57@gmail.com", "Company24", 65, "http://caroline.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(313) 973-9204 x851", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "", "Brad_Bashirian@hotmail.com", "Company728", 69, "https://katlynn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(255) 205-4271 x42556", "b2afb5d0-3114-42ab-806c-1f127173d81f", "Sint iusto occaecati dicta illum harum dolores impedit autem voluptas.", "Riley.Gutkowski@hotmail.com", "Company153", 68, "https://justus.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-866-552-3615 x9077", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Dicta voluptas veniam non enim dignissimos.", "Jaclyn.Krajcik42@hotmail.com", "Company450", 70, "https://moshe.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "915.804.6936", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Dolorum saepe laboriosam aut ducimus omnis rem vel. Assumenda asperiores illum. Et voluptas ipsam unde.", "Margarete_Hegmann18@gmail.com", "Company691", 67, "http://omer.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "230.244.8763 x821", "2133e14e-a893-4630-9c75-b8f41dce4c1c", "Ex in ratione nemo commodi. Aperiam expedita velit omnis qui veritatis quis. Deserunt cum natus cumque ipsum voluptatibus cumque eos. Officiis dolorem libero perferendis ut quo fuga.", "Ignacio_Gorczany18@hotmail.com", "Company14", 63, "https://reid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-445-200-6350", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "Quos qui ad atque optio iste veritatis. In neque amet animi recusandae nisi aut accusantium ipsa est. Consequatur et est quis. Qui nesciunt asperiores necessitatibus sunt exercitationem aperiam voluptatem harum.", "Ozella.OConner@yahoo.com", "Company464", "http://wilford.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "752.498.8375 x405", "b2afb5d0-3114-42ab-806c-1f127173d81f", "At minima magni et. Sunt laudantium voluptas est aut exercitationem nam sunt quisquam neque.", "Fidel_Krajcik56@gmail.com", "Company965", 61, "http://rebeca.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-598-997-6208", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Numquam iusto hic enim dolorum adipisci. Et est quis ex sint tenetur et natus. Voluptatem aut occaecati sequi animi. Voluptate soluta veritatis deleniti facere.", "Lesly11@gmail.com", "Company568", 61, "http://raina.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 26, 11, 135, DateTimeKind.Local), 50, "Sit consequuntur reprehenderit explicabo sit.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 21, 50, 23, 857, DateTimeKind.Local), 50, "Velit quam voluptatem sed aut sapiente cupiditate.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 7, 43, 44, 409, DateTimeKind.Local), 41, "Rerum et expedita tempora adipisci consequatur est earum ut quia.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 9, 30, 814, DateTimeKind.Local), 45, "Quia consectetur porro atque perferendis est molestiae.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 16, 8, 33, 965, DateTimeKind.Local), 44, "Aperiam qui blanditiis.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 56, 4, 316, DateTimeKind.Local), 46, "Rerum quaerat qui provident rem.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 28, 59, 3, DateTimeKind.Local), 44, "Dolores commodi praesentium id aliquid dicta aperiam maiores est aut.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 8, 35, 688, DateTimeKind.Local), 49, "Eligendi quis ut aut nesciunt vitae.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 3, 22, 131, DateTimeKind.Local), 50, "Nihil sit aut omnis deserunt quisquam omnis qui.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 6, 3, 911, DateTimeKind.Local), 43, "Delectus soluta assumenda rerum eligendi totam unde.", "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 },
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSettings_Chats_ChatId",
                table: "NotificationSettings");

            migrationBuilder.DropIndex(
                name: "IX_NotificationSettings_ChatId",
                table: "NotificationSettings");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "047c0189-76a6-4446-8294-3d5e0d3e5d9c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2133e14e-a893-4630-9c75-b8f41dce4c1c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2984b34d-5667-4986-8eef-ec4e17658c33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37cdecd7-aaac-4dc2-9c84-7e7289b521c4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "538a13da-2a85-426a-80fb-3388aa78c68a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8948ed9a-bc9b-4fa4-bd76-e196ae717a71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b2afb5d0-3114-42ab-806c-1f127173d81f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8354a9d-9f70-454a-8fb6-bf15ca19cf85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f7a272fa-80ff-48b3-a78a-a800be071761");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Notifications",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", true, 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", true, 43, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, true, 71, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 100, true, 15 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", true, 36, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded1", true, 12, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", true, 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, true, 68, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 93, "MostLoaded3", true, 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", true, 72, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 29, 21, 278, DateTimeKind.Local), 86, "Title150" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 53, 8, 623, DateTimeKind.Local), 90, "Title277" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 29, 33, 969, DateTimeKind.Local), 82, "Title629" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 54, 43, 857, DateTimeKind.Local), 85, "Title750" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 22, 30, 557, DateTimeKind.Local), 90, "Title536" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 40, 53, 305, DateTimeKind.Local), 82, "Title286" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 27, 30, 216, DateTimeKind.Local), 82, "Title975" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 44, 51, 22, DateTimeKind.Local), 88, "Title696" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 17, 43, 42, 651, DateTimeKind.Local), 86, "Title106" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 48, 35, 540, DateTimeKind.Local), 89, "Title912" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "73:ec:19:cd:61:fe", 73, "Windows", "Instance582" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "11:45:22:0c:0f:e4", 71, "Linux", "Instance224" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0f:96:40:a1:31:b6", 77, "Linux", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "86:7f:ad:1e:2a:c6", 79, "Instance648" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a5:b7:54:b8:a5:1f", 73, "Linux", "Instance262" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "dd:f3:15:0f:17:dc", 77, "Instance428" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "60:e0:e2:2d:b9:91", 76, "Instance607" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "0f:3c:a8:37:e0:57", 73, "Instance880" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6c:cc:e5:99:2e:93", 75, "Linux", "Instance987" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1a:5d:3d:98:7a:c4", 79, "Linux", "Instance27" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme482");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme897" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme558" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme998" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme189" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme516" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme394" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme150" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme615" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme637" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "0cc0334a-a604-4fef-89b6-677392e535c1", null, new DateTime(2018, 8, 30, 0, 49, 14, 925, DateTimeKind.Local), "Dessie", "Louvenia.Dietrich@gmail.com", null, "Ford", true, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidhemphill/128.jpg", 2 },
                    { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", null, new DateTime(2018, 8, 29, 21, 12, 30, 563, DateTimeKind.Local), "Amani", "Yolanda.Ruecker27@yahoo.com", null, "Yesenia", true, "Labadie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/antonyryndya/128.jpg", 1 },
                    { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", null, new DateTime(2018, 8, 30, 14, 5, 13, 34, DateTimeKind.Local), "Billy", "Godfrey_Douglas86@yahoo.com", null, "Gwen", true, "McCullough", null, "https://s3.amazonaws.com/uifaces/faces/twitter/svenlen/128.jpg", 1 },
                    { "f851c462-8fe4-48e6-bb81-4d9cfb740521", null, new DateTime(2018, 8, 29, 22, 41, 9, 135, DateTimeKind.Local), "Christa", "Kitty.Schiller3@yahoo.com", null, "Elena", true, "Stamm", null, "https://s3.amazonaws.com/uifaces/faces/twitter/eddiechen/128.jpg", 2 },
                    { "9022ac94-1cd8-46cc-a0a8-b24258800d30", null, new DateTime(2018, 8, 30, 15, 24, 23, 341, DateTimeKind.Local), "Dusty", "Orrin65@yahoo.com", null, "Jadyn", true, "Bogan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sethlouey/128.jpg", 2 },
                    { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", null, new DateTime(2018, 8, 30, 14, 19, 48, 547, DateTimeKind.Local), "Nona", "Sean83@hotmail.com", null, "Jamison", true, "Leannon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joki4/128.jpg", 2 },
                    { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", null, new DateTime(2018, 8, 30, 9, 34, 26, 103, DateTimeKind.Local), "Kolby", "Kailyn86@yahoo.com", null, "Eldred", true, "Conroy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/chacky14/128.jpg", 2 },
                    { "f0a5b62a-da54-4712-9452-6440ef65945d", null, new DateTime(2018, 8, 30, 3, 26, 41, 214, DateTimeKind.Local), "Elsie", "Candace.Sporer@hotmail.com", null, "Lexie", true, "Wiza", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gseguin/128.jpg", 1 },
                    { "8a65aa2c-1690-4985-b55a-52cad5015049", null, new DateTime(2018, 8, 30, 14, 25, 52, 791, DateTimeKind.Local), "Willow", "Quincy_Weber@hotmail.com", null, "Zion", true, "Rau", null, "https://s3.amazonaws.com/uifaces/faces/twitter/smaczny/128.jpg", 1 },
                    { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", null, new DateTime(2018, 8, 30, 10, 34, 39, 193, DateTimeKind.Local), "Brielle", "Elvie_Wiegand53@gmail.com", null, "Johnathan", true, "Schiller", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adellecharles/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", "quis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", "nisi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedById",
                value: "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "beatae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "omnis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", "ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 46, 13, 987, DateTimeKind.Local), "Qui consequuntur corrupti cumque minus minus soluta fugit.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 9, 21, 5, 834, DateTimeKind.Local), "Nihil aut aut animi odit nobis expedita voluptatum molestiae est.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 13, 21, 30, 794, DateTimeKind.Local), "Eos praesentium minima sequi.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 55, 39, 779, DateTimeKind.Local), "Sit illo inventore beatae.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 1, 53, 17, 853, DateTimeKind.Local), "Et molestias quis neque quis ut rerum sint.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 12, 20, 12, 949, DateTimeKind.Local), "Omnis ut ipsam enim sed quae ad sit.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 36, 7, 217, DateTimeKind.Local), "Qui cupiditate dolorem aliquid enim.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 17, 14, 36, DateTimeKind.Local), "Est perspiciatis omnis ut consequatur ut qui atque.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 10, 24, 38, 797, DateTimeKind.Local), "Ut eligendi deserunt molestias id.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 2, 36, 399, DateTimeKind.Local), "Sint aut aut eaque repellat officiis vel illo.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 30, 1, 13, 15, 226, DateTimeKind.Local), "Consectetur architecto vel expedita vel possimus velit.", "f0a5b62a-da54-4712-9452-6440ef65945d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 6, 7, 14, 616, DateTimeKind.Local), "Vitae soluta non eum.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 7, 29, 34, 528, DateTimeKind.Local), "Vel earum impedit et incidunt aut amet laudantium iusto ut.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 30, 14, 41, 42, 17, DateTimeKind.Local), "Debitis molestiae non dolor.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 30, 2, 22, 49, 985, DateTimeKind.Local), "Nulla enim repudiandae.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 30, 11, 43, 20, 406, DateTimeKind.Local), "Repellat qui vel dolores odit doloremque culpa placeat perferendis.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 9, 43, 41, 380, DateTimeKind.Local), "Quos et voluptas quas beatae veritatis omnis sunt.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 30, 19, 30, 35, 606, DateTimeKind.Local), "Et explicabo eaque porro reprehenderit molestiae iste sed consequatur.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 29, 21, 7, 12, 67, DateTimeKind.Local), "Doloremque fugit assumenda sit possimus consequatur sit illum velit eum.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 29, 20, 55, 59, 223, DateTimeKind.Local), "Pariatur itaque sunt quos dolore expedita.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 1, "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 3, "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 10, 12, 42, 808, DateTimeKind.Local), 11, "Asperiores doloribus at dolores quibusdam ipsam repudiandae illo.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 15, 58, 3, 482, DateTimeKind.Local), 19, "Ea quia quo magnam.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 7, 55, 46, 613, DateTimeKind.Local), 18, "Reiciendis enim perferendis qui atque quod atque ut.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 14, 56, 13, 279, DateTimeKind.Local), 14, "Perspiciatis repudiandae sunt alias dolore.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 27, 9, 834, DateTimeKind.Local), 17, "Vel consectetur sit tempore cum vero corrupti.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 40, 20, 724, DateTimeKind.Local), 12, "Explicabo magnam quo nobis reiciendis ut aut illo fugiat.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 17, 5, 15, 812, DateTimeKind.Local), 12, "Possimus expedita ducimus placeat impedit alias a.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 7, 42, 543, DateTimeKind.Local), "Sed fugiat repudiandae consequatur.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 13, 16, 34, 10, DateTimeKind.Local), 19, "Et alias amet.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 7, 38, 13, 219, DateTimeKind.Local), 13, "Voluptatibus non autem.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-975-536-0633", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Perspiciatis veritatis ullam tenetur maxime voluptates nam molestias error non.", "Bernadine39@yahoo.com", "Company506", 69, "https://keara.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "474.995.9541", "f0a5b62a-da54-4712-9452-6440ef65945d", "Quae nostrum autem facilis earum saepe ipsam possimus ipsa. Officiis est officia nobis excepturi et. Ut sunt est pariatur eveniet. Beatae consequatur velit.", "Kathlyn78@hotmail.com", "Company741", 70, "http://enrique.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-218-909-9203", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Dicta voluptatem accusantium ratione nostrum ullam rerum provident ratione vel.", "Maryse_Weissnat25@yahoo.com", "Company631", 67, "https://javonte.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "910-805-5830 x5678", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Iure quo enim sed et vel laudantium dolorem illum magni. Corrupti consequatur ea excepturi. Nisi molestias fugit consequatur.", "Moises94@hotmail.com", "Company995", 63, "https://maurice.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "493.650.0332 x93009", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Voluptatem veniam est nihil at neque. Quis sunt sed perferendis.", "Joelle.Schmeler@yahoo.com", "Company598", 65, "https://allene.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(867) 964-8993", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Provident iusto reprehenderit optio. Sapiente eveniet vitae. Molestiae perferendis qui doloremque quos perspiciatis.", "Kaci_Leannon81@gmail.com", "Company242", 61, "https://jensen.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(349) 931-0048 x7859", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Tenetur et tempore fugit eveniet tempore sapiente voluptate eos. Blanditiis neque nisi velit ratione molestias repellat modi eveniet atque. Dicta quos eveniet quos laudantium placeat.", "Melany19@hotmail.com", "Company590", 69, "https://kylie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-903-268-7272 x830", "f851c462-8fe4-48e6-bb81-4d9cfb740521", "", "Mohammad68@hotmail.com", "Company608", "https://ross.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(951) 543-5401", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Quisquam provident ea nam omnis dolorem minus error.", "Houston_Walsh25@yahoo.com", "Company376", 64, "https://marjorie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "726.469.6688", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Aut quo reprehenderit nihil accusamus quos rerum.", "Evie48@gmail.com", "Company308", 69, "https://laurel.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 19, 47, 54, 169, DateTimeKind.Local), 42, "Expedita earum ratione.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 24, 58, 385, DateTimeKind.Local), 41, "Repellat enim corporis qui error consectetur aut veritatis quos.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 51, 24, 388, DateTimeKind.Local), 50, "Itaque corrupti adipisci.", "f0a5b62a-da54-4712-9452-6440ef65945d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 8, 46, 23, 207, DateTimeKind.Local), 42, "Dolor explicabo et repudiandae eum ratione veritatis.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 33, 59, 556, DateTimeKind.Local), 50, "Harum voluptate delectus velit sint ducimus quia ducimus.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 25, 55, 312, DateTimeKind.Local), 43, "Et adipisci quod dolore vitae ipsum.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 3, 52, 42, 102, DateTimeKind.Local), 41, "Mollitia doloribus ut.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 38, 8, 581, DateTimeKind.Local), 46, "Magni in qui exercitationem et tempora.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 42, 18, 681, DateTimeKind.Local), 44, "Placeat qui quis nemo nisi nulla quo dolorem quisquam rerum.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 52, 29, 591, DateTimeKind.Local), 41, "Ut iure officia consequatur aut excepturi fugiat.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f851c462-8fe4-48e6-bb81-4d9cfb740521", 71 },
                    { "f0a5b62a-da54-4712-9452-6440ef65945d", 75 },
                    { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", 78 },
                    { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", 77 },
                    { "9022ac94-1cd8-46cc-a0a8-b24258800d30", 74 },
                    { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", 79 },
                    { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", 76 },
                    { "0cc0334a-a604-4fef-89b6-677392e535c1", 71 },
                    { "8a65aa2c-1690-4985-b55a-52cad5015049", 77 },
                    { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", 76 }
                });
        }
    }
}
