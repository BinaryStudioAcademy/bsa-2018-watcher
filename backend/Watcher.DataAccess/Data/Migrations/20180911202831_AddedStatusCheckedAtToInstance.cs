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

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 51, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 50, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 97, 68 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 48, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 64, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 95, 23 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 94, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 76, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 48, 2, 833, DateTimeKind.Local), 82, "Title173" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 54, 26, 800, DateTimeKind.Local), 81, "Title991" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 8, 7, 412, DateTimeKind.Local), 84, "Title585" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 33, 14, 624, DateTimeKind.Local), 88, "Title821" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 29, 8, 774, DateTimeKind.Local), 81, "Title491" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 3, 5, 497, DateTimeKind.Local), 85, "Title335" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 35, 38, 961, DateTimeKind.Local), 88, "Title234" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 48, 10, 809, DateTimeKind.Local), 86, "Title587" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 19, 39, 970, DateTimeKind.Local), 90, "Title69" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 37, 14, 839, DateTimeKind.Local), 88, "Title795" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "9e:c3:68:06:fc:27", 73, "Linux", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance28" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "69:ae:a9:9e:4c:90", 72, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance332" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "15:bf:a8:35:85:d9", 71, "Linux", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance85" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "ba:63:52:94:ea:d3", 76, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance448" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "f2:c5:31:96:b8:82", 71, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance678" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "63:d3:d5:33:22:df", 72, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance38" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "17:24:c6:05:80:06", 74, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance504" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "fa:cd:11:c7:e0:50", 76, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "c7:0d:14:71:ec:e6", 76, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance490" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "b7:63:cd:8a:36:ce", 80, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance447" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme214" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme32" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme256" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme825" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme450" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme409" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme220" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme441" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme832" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme706" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "e2d35c72-f927-4bf3-90c9-455abd1ca397", null, new DateTime(2018, 9, 11, 10, 13, 28, 699, DateTimeKind.Local), "Christopher", "Charity_Bartoletti69@gmail.com", null, "Theron", true, false, "Schowalter", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joreira/128.jpg", 1 },
                    { "e72237ee-c095-4e57-8376-42a1b3844a49", null, new DateTime(2018, 9, 11, 9, 8, 40, 83, DateTimeKind.Local), "Jacky", "Violette_Armstrong@gmail.com", null, "Bell", true, false, "Abbott", null, "https://s3.amazonaws.com/uifaces/faces/twitter/unterdreht/128.jpg", 2 },
                    { "d9ce076a-0d67-4c33-863c-d1e30204e18b", null, new DateTime(2018, 9, 11, 5, 45, 55, 917, DateTimeKind.Local), "Jerome", "Dario.Wehner@gmail.com", null, "Jennings", true, false, "Braun", null, "https://s3.amazonaws.com/uifaces/faces/twitter/heyimjuani/128.jpg", 2 },
                    { "12f88475-329b-412a-8eef-b5c9c9a246e0", null, new DateTime(2018, 9, 11, 22, 50, 40, 597, DateTimeKind.Local), "Mohamed", "Fabiola_Cormier@yahoo.com", null, "Kyle", true, false, "Shields", null, "https://s3.amazonaws.com/uifaces/faces/twitter/devankoshal/128.jpg", 2 },
                    { "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", null, new DateTime(2018, 9, 11, 15, 38, 25, 835, DateTimeKind.Local), "Tavares", "Van_Jast38@yahoo.com", null, "Dennis", true, false, "Marvin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/evandrix/128.jpg", 1 },
                    { "82bef09d-3035-4ce5-9f99-7cf6740c8020", null, new DateTime(2018, 9, 11, 9, 11, 35, 251, DateTimeKind.Local), "Marilou", "Leonard94@hotmail.com", null, "Maud", true, false, "Bosco", null, "https://s3.amazonaws.com/uifaces/faces/twitter/frankiefreesbie/128.jpg", 1 },
                    { "d11f0865-34fa-4778-b88e-d9d1bfd37327", null, new DateTime(2018, 9, 11, 10, 38, 46, 601, DateTimeKind.Local), "Juwan", "Marcelino.Hettinger52@yahoo.com", null, "Hassan", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nvkznemo/128.jpg", 2 },
                    { "60aa555a-833a-468f-9371-e3b3c8a17b8f", null, new DateTime(2018, 9, 11, 17, 14, 57, 962, DateTimeKind.Local), "Samson", "Amani35@hotmail.com", null, "Thad", true, false, "Feest", null, "https://s3.amazonaws.com/uifaces/faces/twitter/svenlen/128.jpg", 2 },
                    { "3fff5aa8-3c50-40d7-90a1-3de1d905b016", null, new DateTime(2018, 9, 11, 13, 27, 41, 120, DateTimeKind.Local), "Manuel", "Yazmin.Treutel41@gmail.com", null, "Alexander", true, false, "Glover", null, "https://s3.amazonaws.com/uifaces/faces/twitter/amywebbb/128.jpg", 1 },
                    { "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", null, new DateTime(2018, 9, 11, 19, 37, 57, 245, DateTimeKind.Local), "Raheem", "Fidel79@gmail.com", null, "Myles", true, false, "Johnson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nacho/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e2d35c72-f927-4bf3-90c9-455abd1ca397", "sint" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e2d35c72-f927-4bf3-90c9-455abd1ca397", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d9ce076a-0d67-4c33-863c-d1e30204e18b", "quae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d11f0865-34fa-4778-b88e-d9d1bfd37327", "voluptates" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", "enim" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "12f88475-329b-412a-8eef-b5c9c9a246e0", "vitae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3fff5aa8-3c50-40d7-90a1-3de1d905b016", "quis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e72237ee-c095-4e57-8376-42a1b3844a49", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "12f88475-329b-412a-8eef-b5c9c9a246e0", "harum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", "explicabo" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 20, 0, 600, DateTimeKind.Local), "Sunt necessitatibus autem voluptas.", "3fff5aa8-3c50-40d7-90a1-3de1d905b016" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 41, 32, 554, DateTimeKind.Local), "Illo nihil pariatur rerum minus.", "3fff5aa8-3c50-40d7-90a1-3de1d905b016" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 30, 9, 905, DateTimeKind.Local), "Atque harum aut eligendi beatae.", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 24, 47, 256, DateTimeKind.Local), "Repudiandae molestiae expedita perspiciatis molestias.", "12f88475-329b-412a-8eef-b5c9c9a246e0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 25, 1, 639, DateTimeKind.Local), "In dolore quia odio.", "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 54, 4, 952, DateTimeKind.Local), "Doloribus numquam quis neque ut odit quis vero eos.", "82bef09d-3035-4ce5-9f99-7cf6740c8020" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 30, 9, 439, DateTimeKind.Local), "Autem culpa eum provident veritatis ratione et laudantium.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 44, 12, 704, DateTimeKind.Local), "Placeat dolor fugit cumque atque.", "60aa555a-833a-468f-9371-e3b3c8a17b8f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 27, 8, 26, DateTimeKind.Local), "Rerum eum repellendus necessitatibus deleniti nihil.", "e2d35c72-f927-4bf3-90c9-455abd1ca397" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 49, 36, 883, DateTimeKind.Local), "Perspiciatis et occaecati qui.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 5, 7, 18, 432, DateTimeKind.Local), "Laboriosam illo sed earum est voluptates reprehenderit adipisci.", "d11f0865-34fa-4778-b88e-d9d1bfd37327", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 4, 30, 15, 844, DateTimeKind.Local), "Aspernatur commodi architecto dolorem voluptatibus est quo.", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 22, 25, 11, 327, DateTimeKind.Local), "Magni repellendus est minus quis quia repudiandae omnis libero.", "e72237ee-c095-4e57-8376-42a1b3844a49", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 8, 38, 59, 697, DateTimeKind.Local), "Ut sint esse dolorum sit.", "60aa555a-833a-468f-9371-e3b3c8a17b8f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 10, 20, 5, 854, DateTimeKind.Local), "Consequuntur aut voluptatem ducimus voluptas.", "d11f0865-34fa-4778-b88e-d9d1bfd37327", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 14, 43, 45, 918, DateTimeKind.Local), "Facilis consequuntur maxime.", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 3, 39, 31, 866, DateTimeKind.Local), "Accusamus sint voluptatem nam est impedit corporis adipisci eius ipsum.", "12f88475-329b-412a-8eef-b5c9c9a246e0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 12, 16, 7, 119, DateTimeKind.Local), "Voluptatem est deleniti.", "82bef09d-3035-4ce5-9f99-7cf6740c8020", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 18, 12, 9, 515, DateTimeKind.Local), "Est repellendus doloremque.", "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 12, 27, 28, 183, DateTimeKind.Local), "Deserunt ipsum impedit debitis adipisci.", "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "3fff5aa8-3c50-40d7-90a1-3de1d905b016" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "3fff5aa8-3c50-40d7-90a1-3de1d905b016" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "e2d35c72-f927-4bf3-90c9-455abd1ca397" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 2, "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "e2d35c72-f927-4bf3-90c9-455abd1ca397" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "12f88475-329b-412a-8eef-b5c9c9a246e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "d9ce076a-0d67-4c33-863c-d1e30204e18b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 58, 48, 74, DateTimeKind.Local), 14, "Itaque beatae et.", "12f88475-329b-412a-8eef-b5c9c9a246e0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 12, 38, 605, DateTimeKind.Local), 18, "Distinctio corporis et sunt earum.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 22, 3, 522, DateTimeKind.Local), 18, "Facere repudiandae consequatur ut consequuntur repellendus fuga est soluta est.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 53, 8, 767, DateTimeKind.Local), 19, "Accusantium magnam deleniti aliquid nihil.", "82bef09d-3035-4ce5-9f99-7cf6740c8020" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 36, 57, 556, DateTimeKind.Local), 16, "Aspernatur recusandae voluptas quidem iste laboriosam est ratione amet nulla.", "e2d35c72-f927-4bf3-90c9-455abd1ca397" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 1, 13, 904, DateTimeKind.Local), 14, "Eveniet aut voluptatem qui magni consequatur id excepturi consequuntur molestiae.", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 41, 29, 414, DateTimeKind.Local), 13, "Beatae in ut et at doloremque.", "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 52, 26, 8, DateTimeKind.Local), "Et iusto doloribus laudantium.", "12f88475-329b-412a-8eef-b5c9c9a246e0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 45, 12, 928, DateTimeKind.Local), 19, "Atque veniam culpa totam omnis.", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 26, 7, 814, DateTimeKind.Local), 13, "Officia aut repudiandae expedita.", "e2d35c72-f927-4bf3-90c9-455abd1ca397" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-682-929-5004 x913", "82bef09d-3035-4ce5-9f99-7cf6740c8020", "", "Haylie.Conroy@hotmail.com", "Company401", 62, "https://margaretta.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "600.684.6398 x721", "d9ce076a-0d67-4c33-863c-d1e30204e18b", "Quo iusto nostrum laborum laboriosam id. Impedit labore iusto dicta rerum voluptas odit.", "Kay_Tremblay63@gmail.com", "Company701", 64, "https://barbara.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "359.833.4126", "e72237ee-c095-4e57-8376-42a1b3844a49", "Hic et rerum pariatur harum. Omnis vero enim tempore voluptatum et sit sequi.", "Hillard_Keeling@hotmail.com", "Company101", 70, "http://shanna.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(490) 476-9035 x5261", "60aa555a-833a-468f-9371-e3b3c8a17b8f", "Cupiditate iure non non et incidunt nihil aut libero qui. Qui quas facere eaque dolorem qui aperiam corrupti dolores. Et placeat perferendis architecto odit.", "Monte.Thiel@hotmail.com", "Company348", 65, "https://marilou.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "213-998-4565 x316", "82bef09d-3035-4ce5-9f99-7cf6740c8020", "Sunt voluptates quidem. Vero eos voluptatum maiores aut in et dolores quia rerum. In esse culpa officia nihil natus neque tempora placeat neque.", "Litzy_Goodwin@gmail.com", "Company830", 66, "http://neoma.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "759-419-5735 x69950", "82bef09d-3035-4ce5-9f99-7cf6740c8020", "Brown16@yahoo.com", "Company144", 65, "https://shakira.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-207-958-2869", "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", "Dignissimos voluptatem a et.", "Dovie5@hotmail.com", "Company683", 66, "http://devante.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(975) 753-6513", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", "Ex earum nihil ducimus rerum enim perferendis fuga fugiat. Rerum nam ea. Reprehenderit reprehenderit necessitatibus dolorem dolores.", "Libbie93@hotmail.com", "Company597", "http://hildegard.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-861-572-7414 x87022", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", "Libero aliquid at eius. Omnis modi consequuntur itaque. Totam veritatis ullam saepe labore placeat minus sunt quo quo. Qui provident quisquam aperiam.", "Joesph_OConner32@gmail.com", "Company578", 62, "https://renee.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-640-783-3385 x5936", "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", "Repellat cupiditate illum magni. Id fuga suscipit sunt.", "Harmon8@yahoo.com", "Company887", 66, "http://jaren.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 32, 5, 557, DateTimeKind.Local), "Sunt perferendis quo quaerat nostrum eaque adipisci non nulla earum.", "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 19, 2, 311, DateTimeKind.Local), 50, "Necessitatibus consequatur molestiae ea et rerum.", "d11f0865-34fa-4778-b88e-d9d1bfd37327" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 13, 48, 871, DateTimeKind.Local), "Ratione architecto voluptatum et pariatur dolorum unde aut aut.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 18, 39, 209, DateTimeKind.Local), 47, "Qui neque id harum at ipsa ut vitae non.", "60aa555a-833a-468f-9371-e3b3c8a17b8f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 45, 42, 508, DateTimeKind.Local), 46, "Explicabo consequatur voluptatem veniam ut aut aut necessitatibus.", "d9ce076a-0d67-4c33-863c-d1e30204e18b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 4, 31, 202, DateTimeKind.Local), 45, "Vitae modi qui illum reiciendis.", "d9ce076a-0d67-4c33-863c-d1e30204e18b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 40, 32, 659, DateTimeKind.Local), 43, "Aut velit voluptatem magnam id facilis commodi.", "d9ce076a-0d67-4c33-863c-d1e30204e18b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 54, 26, 88, DateTimeKind.Local), 44, "Ut ratione non dolor repellendus qui eum dolore.", "3fff5aa8-3c50-40d7-90a1-3de1d905b016" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 53, 8, 606, DateTimeKind.Local), 42, "Eaque ea assumenda illum ratione ut tenetur dolor rem incidunt.", "e72237ee-c095-4e57-8376-42a1b3844a49" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 17, 16, 926, DateTimeKind.Local), 47, "Aperiam est labore maxime ratione eveniet maiores quo.", "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "60aa555a-833a-468f-9371-e3b3c8a17b8f", 73, 1 },
                    { "d11f0865-34fa-4778-b88e-d9d1bfd37327", 71, 1 },
                    { "e72237ee-c095-4e57-8376-42a1b3844a49", 78, 1 },
                    { "d9ce076a-0d67-4c33-863c-d1e30204e18b", 78, 1 },
                    { "3fff5aa8-3c50-40d7-90a1-3de1d905b016", 76, 1 },
                    { "12f88475-329b-412a-8eef-b5c9c9a246e0", 75, 1 },
                    { "e2d35c72-f927-4bf3-90c9-455abd1ca397", 71, 1 },
                    { "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", 72, 1 },
                    { "82bef09d-3035-4ce5-9f99-7cf6740c8020", 75, 1 },
                    { "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", 79, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "12f88475-329b-412a-8eef-b5c9c9a246e0", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3fff5aa8-3c50-40d7-90a1-3de1d905b016", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "60aa555a-833a-468f-9371-e3b3c8a17b8f", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "63c8fee6-55b5-4a26-bed7-5ac84f06f23d", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "82bef09d-3035-4ce5-9f99-7cf6740c8020", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d11f0865-34fa-4778-b88e-d9d1bfd37327", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d9ce076a-0d67-4c33-863c-d1e30204e18b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e2d35c72-f927-4bf3-90c9-455abd1ca397", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e72237ee-c095-4e57-8376-42a1b3844a49", 78 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12f88475-329b-412a-8eef-b5c9c9a246e0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3fff5aa8-3c50-40d7-90a1-3de1d905b016");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "60aa555a-833a-468f-9371-e3b3c8a17b8f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "63c8fee6-55b5-4a26-bed7-5ac84f06f23d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "82bef09d-3035-4ce5-9f99-7cf6740c8020");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bb203ff7-7405-4ba1-b9a3-5c24b9e2a045");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d11f0865-34fa-4778-b88e-d9d1bfd37327");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d9ce076a-0d67-4c33-863c-d1e30204e18b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e2d35c72-f927-4bf3-90c9-455abd1ca397");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e72237ee-c095-4e57-8376-42a1b3844a49");

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
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 89 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 90, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 91, 2 });

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
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 28 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 94, 0 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 25, 6, 376, DateTimeKind.Local), 82, "Title881" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "5e:94:b4:e7:82:a0", 71, "Windows", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance543" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "7b:0d:d6:76:9c:ad", 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance457" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "7a:d6:1c:2f:a6:b8", 75, "Windows", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance357" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "d3:52:74:5d:97:79", 78, "Linux", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance938" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "1c:72:d1:c1:15:30", 77, "Linux", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance398" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "14:2b:e6:be:3f:87", 75, "Linux", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance710" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "26:16:32:e3:40:29", 76, "Linux", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance254" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "e9:73:bf:18:b0:07", 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance868" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "08:f0:35:2b:7c:a8", 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance101" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "01:3f:47:9b:1b:05", 73, "Linux", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instance114" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme194" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme594" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme999" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme718" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme120" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme452" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 2, 35, 33, 108, DateTimeKind.Local), "Laboriosam aut libero amet occaecati est non qui deserunt sit.", "d5027330-edba-46bd-87e8-5d17cafec535", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 20, 58, 8, 197, DateTimeKind.Local), "Impedit rerum odio est iusto vel.", "e52db057-e8ba-4a30-b771-e5b3982d6721", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 17, 57, 19, 38, DateTimeKind.Local), "Quia error pariatur maxime impedit dolores.", "e52db057-e8ba-4a30-b771-e5b3982d6721" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 6, 56, 13, 366, DateTimeKind.Local), "Veniam distinctio aut cum sed totam sapiente molestiae.", "d8deb96d-e4ec-4100-9238-de69c5786c38", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 10, 59, 20, 267, DateTimeKind.Local), "Molestiae voluptatem aut reprehenderit voluptatem.", "14fb8ee9-92d8-4aec-811c-f12481229d30", true });

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
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

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
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "d8deb96d-e4ec-4100-9238-de69c5786c38" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "d5027330-edba-46bd-87e8-5d17cafec535" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "14fb8ee9-92d8-4aec-811c-f12481229d30" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "e52db057-e8ba-4a30-b771-e5b3982d6721" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 26, 24, 508, DateTimeKind.Local), 14, "Natus et sapiente eveniet molestias maiores unde.", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 23, 2, 53, DateTimeKind.Local), 13, "Consectetur ea voluptas repellat qui eos necessitatibus.", "e52db057-e8ba-4a30-b771-e5b3982d6721" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 29, 52, 641, DateTimeKind.Local), "Temporibus sapiente dignissimos vero repudiandae.", "d8deb96d-e4ec-4100-9238-de69c5786c38" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "484-665-5301 x22139", "4e50b15b-ec6b-4ee4-941e-099d059e4bb2", "Architecto est laborum omnis nesciunt voluptatem corrupti veniam.", "Ralph.Durgan89@hotmail.com", "Company763", 63, "https://nelda.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-650-699-8703 x99419", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "Kari_Bruen7@gmail.com", "Company434", 64, "http://myah.name" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(461) 307-7995", "9e6e82cd-0ccc-4be4-8f6e-479a4a58db00", "Blanditiis reiciendis voluptatum molestias eius quod ratione excepturi vel accusamus. Vitae et quisquam modi. Ipsum deleniti alias eum sit. Rerum tempora maiores consequuntur sint dicta praesentium aut.", "Bo_Williamson58@gmail.com", "Company103", "https://oral.net" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 15, 36, 537, DateTimeKind.Local), "Blanditiis dicta earum et fugit.", "d5027330-edba-46bd-87e8-5d17cafec535" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 12, 21, 727, DateTimeKind.Local), "Ut qui quaerat soluta ut fugit doloribus voluptatem.", "d5027330-edba-46bd-87e8-5d17cafec535" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 42, 28, 46, DateTimeKind.Local), 44, "Et et accusamus aliquam.", "d35bccfa-a9f4-456c-a18f-e334c78563f0" });

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
    }
}
