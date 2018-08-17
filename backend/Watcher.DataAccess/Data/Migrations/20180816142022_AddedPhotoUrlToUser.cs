using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedPhotoUrlToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14052a15-abbd-4257-8aa3-14b803de5241", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "310558b5-97d8-4ad0-a0c0-cc597712123b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "70f945d0-f3c7-4587-9676-fc089b4451ce", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76417ced-9632-4ebd-808d-717e70a270d2", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7a3d1395-bd4d-492c-ba90-76c148d7f559", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a436d9c3-ce62-4a1e-8293-5b17534d8398", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "df57d25e-b21d-490a-8024-d1a04e56934b", 74 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14052a15-abbd-4257-8aa3-14b803de5241");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "310558b5-97d8-4ad0-a0c0-cc597712123b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "683266fc-140c-4a5e-ac01-7ff8304a848b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "70f945d0-f3c7-4587-9676-fc089b4451ce");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76417ced-9632-4ebd-808d-717e70a270d2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7a3d1395-bd4d-492c-ba90-76c148d7f559");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "863baf8a-b306-4a9f-84f0-5df0a3e7b480");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a436d9c3-ce62-4a1e-8293-5b17534d8398");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b8493acc-5078-4e21-a205-74dc72d89ff8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "df57d25e-b21d-490a-8024-d1a04e56934b");

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Source1", 55, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 33, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "Common2", 19, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Source3", 7, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 99, "Source1", 10 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", "Source2", 79, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 93, "MostLoaded2", "Source1", 75 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "Common2", "Source3", 52, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 98, "Source3", 28, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded1", "Common1", "Source1", 51 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 47, 43, 927, DateTimeKind.Local), "Title736" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 54, 49, 376, DateTimeKind.Local), 86, "Title684" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 38, 34, 479, DateTimeKind.Local), 82, "Title522" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 15, 1, 590, DateTimeKind.Local), 87, "Title786" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 35, 6, 218, DateTimeKind.Local), 86, "Title807" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 2, 26, 46, 746, DateTimeKind.Local), 83, "Title65" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 43, 19, 481, DateTimeKind.Local), 81, "Title130" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 45, 14, 481, DateTimeKind.Local), 82, "Title991" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 55, 17, 546, DateTimeKind.Local), 87, "Title334" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 1, 27, 20, 455, DateTimeKind.Local), 85, "Title192" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c9:82:f9:92:a8:84", 74, "Instance100" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "63:ce:14:be:5c:dd", "Instance452" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9e:16:ca:02:9f:58", 76, "Instance613" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4e:dd:23:c2:40:81", 80, "Instance750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0e:23:3f:89:ab:7b", 71, "Linux", "Instance199" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f7:0b:93:99:43:b2", 78, "Linux", "Instance1" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "fc:f2:58:83:e2:85", 77, "Instance949" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Title" },
                values: new object[] { "f2:72:54:e1:71:7a", "Instance494" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "58:be:6a:47:f8:43", 73, "Instance339" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c9:f4:dd:e3:bf:1b", 78, "Instance496" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme580" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme719" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme336");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme734" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme61" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme766" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme475" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme643" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme532" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme84" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "666f434f-7bc9-4276-abf0-723993d8ed27", null, new DateTime(2018, 8, 15, 19, 20, 8, 693, DateTimeKind.Local), "Landen", "Nora.Paucek@gmail.com", "Chandler", true, "Tremblay", null, null, 1 },
                    { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", null, new DateTime(2018, 8, 15, 20, 44, 8, 716, DateTimeKind.Local), "Dejah", "Turner_Hegmann56@gmail.com", "Hilton", true, "Gutmann", null, null, 2 },
                    { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", null, new DateTime(2018, 8, 15, 19, 50, 22, 785, DateTimeKind.Local), "Danielle", "Audra.Hermiston34@hotmail.com", "Ansel", true, "Von", null, null, 1 },
                    { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", null, new DateTime(2018, 8, 16, 17, 0, 40, 359, DateTimeKind.Local), "Harvey", "Eudora_Hayes@hotmail.com", "Zakary", true, "Wisoky", null, null, 2 },
                    { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", null, new DateTime(2018, 8, 16, 12, 21, 25, 361, DateTimeKind.Local), "Giuseppe", "Alden22@hotmail.com", "Ayden", true, "Crist", null, null, 2 },
                    { "2bd76fc2-f512-4341-9aed-06f434f095e7", null, new DateTime(2018, 8, 16, 9, 29, 0, 150, DateTimeKind.Local), "Kameron", "Wilford67@gmail.com", "Vita", true, "Herman", null, null, 2 },
                    { "f3d31655-6174-47c9-965a-2ec360683e18", null, new DateTime(2018, 8, 16, 3, 39, 38, 491, DateTimeKind.Local), "Braulio", "Elvie.Gorczany1@gmail.com", "Oscar", true, "Mayer", null, null, 1 },
                    { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", null, new DateTime(2018, 8, 16, 1, 33, 32, 328, DateTimeKind.Local), "Faustino", "Norberto.Skiles51@hotmail.com", "Abdul", true, "Sporer", null, null, 1 },
                    { "58282afb-62fc-4591-8d86-7c86ec8cfff6", null, new DateTime(2018, 8, 15, 20, 5, 56, 31, DateTimeKind.Local), "Clotilde", "Hester_Hackett15@yahoo.com", "Brennan", true, "Grant", null, null, 1 },
                    { "5aa34b99-8805-4234-9050-9e40616a7db4", null, new DateTime(2018, 8, 16, 12, 11, 58, 355, DateTimeKind.Local), "Jovanny", "Brandon.Mosciski28@gmail.com", "Eloisa", true, "Rosenbaum", null, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", "modi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", "animi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", "voluptatum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", "tenetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", "tenetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", "vitae" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 26, 34, 247, DateTimeKind.Local), "Doloribus sint quo.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 37, 20, 735, DateTimeKind.Local), "Odio excepturi est rem neque odit.", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 34, 36, 583, DateTimeKind.Local), "In et et odio nisi temporibus voluptas quia.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 24, 45, 362, DateTimeKind.Local), "Sunt ut optio.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 1, 20, 9, 741, DateTimeKind.Local), "Minima blanditiis possimus qui saepe sed optio pariatur.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 8, 1, 1, 693, DateTimeKind.Local), "Iusto consectetur laudantium saepe qui occaecati in quos facere.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 38, 35, 536, DateTimeKind.Local), "Voluptatem autem rerum quis.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 53, 2, 931, DateTimeKind.Local), "Vel qui sunt non dolorem voluptate earum.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 25, 8, 765, DateTimeKind.Local), "Dolorem deserunt cum et aut nobis possimus.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 22, 27, 88, DateTimeKind.Local), "Vel ullam quo et dolore.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 16, 3, 8, 0, 840, DateTimeKind.Local), "Laborum ut laboriosam deserunt occaecati repudiandae aliquid.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 16, 2, 6, 21, 1, DateTimeKind.Local), "Ea quam libero dolorem et enim nihil ipsa.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 7, 30, 36, 279, DateTimeKind.Local), "Earum asperiores maiores qui quae magni aspernatur.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 15, 20, 33, 8, 970, DateTimeKind.Local), "Qui nihil quam voluptas eligendi aut ipsam et ipsum.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 16, 15, 14, 55, 532, DateTimeKind.Local), "Cum expedita autem autem reiciendis.", "2bd76fc2-f512-4341-9aed-06f434f095e7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 16, 3, 41, 12, 386, DateTimeKind.Local), "Consequatur eligendi unde et blanditiis nihil hic eos consectetur exercitationem.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 16, 15, 29, 19, 656, DateTimeKind.Local), "Fuga dolor sit ducimus aliquid consequuntur.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 16, 5, 27, 53, 232, DateTimeKind.Local), "Et aperiam corporis id dolor laborum.", "5aa34b99-8805-4234-9050-9e40616a7db4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 16, 10, 37, 24, 820, DateTimeKind.Local), "Quasi totam placeat facilis qui sunt.", "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 16, 2, 32, 32, 788, DateTimeKind.Local), "Voluptates ex similique possimus occaecati tempora quibusdam.", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, true, "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 4, "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 43, 52, 296, DateTimeKind.Local), 12, "Est non laudantium saepe culpa et quisquam.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 52, 17, 592, DateTimeKind.Local), 13, "Ad non facere aspernatur voluptatem accusamus quam possimus earum veritatis.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 15, 18, 55, 586, DateTimeKind.Local), 19, "Eum molestias nobis illo.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 19, 41, 51, 598, DateTimeKind.Local), 16, "Consectetur et quia veniam voluptas earum ut.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 15, 11, 8, 12, DateTimeKind.Local), 15, "Est alias porro quae consequatur aut ex dicta sint.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 41, 18, 917, DateTimeKind.Local), 13, "Ipsum quod facere.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 22, 42, 57, 701, DateTimeKind.Local), 12, "Sint sequi nam quod magnam.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 40, 46, 324, DateTimeKind.Local), "At eaque dolorum est ab soluta.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 38, 31, 30, DateTimeKind.Local), "Quia qui et quis occaecati optio aperiam dolore.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 1, 40, 773, DateTimeKind.Local), 17, "Et sit sed quis blanditiis laboriosam reiciendis autem tempora.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "789.983.9175 x2028", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", "Sed eligendi tempore quod non expedita temporibus earum. Laborum sit voluptatum odio laborum cumque et dolores. Sunt officia adipisci impedit voluptates minus nisi dolores ex qui. Recusandae quo ut sed odio saepe ea.", "Aubree.Becker9@hotmail.com", "Company365", 65, "http://bryon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "727-924-4793 x32937", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Ea repellat quisquam exercitationem doloremque est quisquam doloremque et quaerat. Impedit natus pariatur qui dolore voluptatibus. Voluptatem error quas qui aut in fuga non perferendis et.", "Tremayne17@gmail.com", "Company257", 62, "http://myrtle.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-800-335-9094 x7245", "d0fcb793-4ae2-4b33-add9-580d3ec6f237", "Dameon.Conn54@yahoo.com", "Company618", 67, "https://clarabelle.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(828) 508-9735 x1487", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Fugiat eius omnis animi.", "Donald_Feil@hotmail.com", "Company504", 61, "http://euna.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "451-382-6529 x13295", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", "", "Maximilian_Keeling@yahoo.com", "Company872", 61, "http://peter.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-371-365-5609", "51eb640e-60b6-48f0-89cb-6d3e6c19074c", "", "Turner.Schaefer@gmail.com", "Company56", 61, "http://elvis.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(749) 505-8220 x732", "666f434f-7bc9-4276-abf0-723993d8ed27", "Veritatis ea ea aut eaque nihil. Quos optio vel. Quia mollitia molestias minus illo.", "Ramona_Farrell60@hotmail.com", "Company451", "http://aubrey.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-562-682-7970", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Quo dolorem aut qui nostrum omnis sint consequatur est nisi. Minus ipsam delectus tempore consequatur nam et. Enim aut qui nihil nihil occaecati suscipit.", "Aurelia.Pfeffer13@gmail.com", "Company628", 65, "https://oren.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "236-409-8985 x43753", "666f434f-7bc9-4276-abf0-723993d8ed27", "Quod aspernatur debitis a illo. Id in doloremque. Atque dicta qui. Sit dolorum quasi dignissimos.", "Kiara38@gmail.com", "Company270", 68, "https://christophe.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-570-218-0260 x08382", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", "Cumque est inventore quis. Provident commodi suscipit.", "Luz_Howe85@hotmail.com", "Company783", 66, "https://josiah.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 2, 14, 450, DateTimeKind.Local), 47, "Recusandae consequatur eum non molestias consequuntur quia.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 38, 8, 563, DateTimeKind.Local), 42, "Atque debitis perspiciatis saepe a qui quibusdam assumenda.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 4, 58, 33, 470, DateTimeKind.Local), 45, "Culpa ex et nesciunt.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 29, 38, 98, DateTimeKind.Local), 41, "Asperiores quia suscipit ipsa et.", "5aa34b99-8805-4234-9050-9e40616a7db4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 14, 27, 78, DateTimeKind.Local), 49, "Voluptas quas laboriosam explicabo quasi est reprehenderit.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 57, 54, 939, DateTimeKind.Local), 49, "Ducimus veritatis distinctio.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 19, 24, 44, 385, DateTimeKind.Local), 44, "Vero odio ut consequatur.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 28, 39, 937, DateTimeKind.Local), 48, "Enim perspiciatis et reprehenderit aliquam et quo eius.", "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 38, 14, 591, DateTimeKind.Local), 47, "Excepturi nihil tempore.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 28, 33, 947, DateTimeKind.Local), 47, "Quo recusandae excepturi ut numquam fuga.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f3d31655-6174-47c9-965a-2ec360683e18", 76 },
                    { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", 76 },
                    { "666f434f-7bc9-4276-abf0-723993d8ed27", 76 },
                    { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", 71 },
                    { "58282afb-62fc-4591-8d86-7c86ec8cfff6", 76 },
                    { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", 78 },
                    { "2bd76fc2-f512-4341-9aed-06f434f095e7", 75 },
                    { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", 78 },
                    { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", 71 },
                    { "5aa34b99-8805-4234-9050-9e40616a7db4", 74 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bd76fc2-f512-4341-9aed-06f434f095e7", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "666f434f-7bc9-4276-abf0-723993d8ed27", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bd76fc2-f512-4341-9aed-06f434f095e7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51eb640e-60b6-48f0-89cb-6d3e6c19074c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "58282afb-62fc-4591-8d86-7c86ec8cfff6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5aa34b99-8805-4234-9050-9e40616a7db4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "666f434f-7bc9-4276-abf0-723993d8ed27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d0fcb793-4ae2-4b33-add9-580d3ec6f237");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f3d31655-6174-47c9-965a-2ec360683e18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", "Source2", 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "Common1", 37, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 97, "Source2", 39, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 95, "Source2", 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded2", "Source1", 96, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 94, "MostLoaded3", "Source3", 9 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common3", "Source1", 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Source2", 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded2", "Common3", "Source2", 12 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 51, 6, 162, DateTimeKind.Local), "Title41" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 4, 16, 53, 458, DateTimeKind.Local), 90, "Title628" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 26, 10, 200, DateTimeKind.Local), 87, "Title536" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 7, 46, 989, DateTimeKind.Local), 90, "Title159" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 36, 34, 744, DateTimeKind.Local), 87, "Title654" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 44, 14, 286, DateTimeKind.Local), 90, "Title155" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 21, 3, 58, 485, DateTimeKind.Local), 84, "Title246" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 9, 34, 11, 714, DateTimeKind.Local), 83, "Title726" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 8, 46, 578, DateTimeKind.Local), 85, "Title778" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 12, 28, 341, DateTimeKind.Local), 90, "Title660" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4d:9e:24:de:b9:c3", 79, "Instance750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "72:47:79:8c:1e:7f", "Instance167" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "04:7c:40:3a:3e:72", 72, "Instance478" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "fc:ce:96:80:1a:46", 77, "Windows", "Instance343" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4f:b3:f4:4a:f2:f5", 71, "Instance865" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Title" },
                values: new object[] { "51:fa:14:09:04:19", "Instance304" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme392" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme299" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme342");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme811" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme695" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme642" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme763" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme834" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme901" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme699" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "a436d9c3-ce62-4a1e-8293-5b17534d8398", null, new DateTime(2018, 8, 14, 17, 46, 28, 389, DateTimeKind.Local), "Jewell", "Freeman_Dickinson71@yahoo.com", "Van", true, "Steuber", null, 1 },
                    { "7a3d1395-bd4d-492c-ba90-76c148d7f559", null, new DateTime(2018, 8, 14, 12, 47, 38, 792, DateTimeKind.Local), "Steve", "Bernita.Kerluke@yahoo.com", "Joy", true, "Mraz", null, 2 },
                    { "310558b5-97d8-4ad0-a0c0-cc597712123b", null, new DateTime(2018, 8, 14, 1, 40, 40, 822, DateTimeKind.Local), "Markus", "Santa_Conn@yahoo.com", "Jamie", true, "Cremin", null, 1 },
                    { "76417ced-9632-4ebd-808d-717e70a270d2", null, new DateTime(2018, 8, 13, 23, 28, 9, 101, DateTimeKind.Local), "Jamil", "Melyssa27@gmail.com", "Chris", true, "Hintz", null, 2 },
                    { "b8493acc-5078-4e21-a205-74dc72d89ff8", null, new DateTime(2018, 8, 14, 2, 2, 13, 262, DateTimeKind.Local), "Milford", "Opal.Schuppe@hotmail.com", "Mohammed", true, "Goldner", null, 1 },
                    { "df57d25e-b21d-490a-8024-d1a04e56934b", null, new DateTime(2018, 8, 14, 20, 6, 54, 675, DateTimeKind.Local), "Mike", "Jazmyn.Prohaska50@hotmail.com", "Emery", true, "Marks", null, 1 },
                    { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", null, new DateTime(2018, 8, 14, 16, 23, 3, 98, DateTimeKind.Local), "Allie", "Caleb_Crist7@hotmail.com", "Lonzo", true, "Toy", null, 1 },
                    { "70f945d0-f3c7-4587-9676-fc089b4451ce", null, new DateTime(2018, 8, 14, 11, 3, 11, 128, DateTimeKind.Local), "Adriel", "Hortense.Tremblay61@gmail.com", "Garland", true, "Rodriguez", null, 1 },
                    { "683266fc-140c-4a5e-ac01-7ff8304a848b", null, new DateTime(2018, 8, 14, 16, 55, 21, 957, DateTimeKind.Local), "Leonor", "Misael22@yahoo.com", "Fern", true, "Schimmel", null, 2 },
                    { "14052a15-abbd-4257-8aa3-14b803de5241", null, new DateTime(2018, 8, 14, 4, 58, 17, 829, DateTimeKind.Local), "Augustine", "Mariana_Schimmel@yahoo.com", "Ryley", true, "Halvorson", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7a3d1395-bd4d-492c-ba90-76c148d7f559", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "labore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "df57d25e-b21d-490a-8024-d1a04e56934b", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", "excepturi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a436d9c3-ce62-4a1e-8293-5b17534d8398", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "14052a15-abbd-4257-8aa3-14b803de5241", "molestias" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "dolor" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 19, 45, 731, DateTimeKind.Local), "Rerum mollitia natus a labore natus eum et aut.", "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 21, 10, 657, DateTimeKind.Local), "Impedit est aut et ut natus quia est cupiditate.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 56, 49, 147, DateTimeKind.Local), "Placeat qui rerum quia assumenda quisquam nihil exercitationem eum.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 38, 44, 270, DateTimeKind.Local), "Omnis tenetur dolorum odit aut assumenda aspernatur qui doloremque.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 15, 41, 535, DateTimeKind.Local), "Fuga soluta ratione officia consequuntur voluptatem ullam.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 14, 2, 878, DateTimeKind.Local), "Quia repellendus cum impedit exercitationem vel distinctio numquam.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 2, 14, 31, 507, DateTimeKind.Local), "Sequi quo ipsam earum numquam.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 51, 38, 940, DateTimeKind.Local), "Eum dolor ullam nesciunt ut dolores dicta in quo ipsum.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 4, 11, 3, 7, DateTimeKind.Local), "Modi doloremque maxime quo et ut rem.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 25, 29, 126, DateTimeKind.Local), "Voluptatibus vel ad totam nulla eum est voluptates aliquid.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 14, 16, 19, 1, 249, DateTimeKind.Local), "Ut aut odio ut maiores omnis.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 19, 39, 394, DateTimeKind.Local), "Aut voluptas est ut voluptatem.", "683266fc-140c-4a5e-ac01-7ff8304a848b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 5, 4, 22, 834, DateTimeKind.Local), "Qui qui amet vel incidunt.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 14, 13, 27, 35, 716, DateTimeKind.Local), "Autem qui ut dignissimos sit autem blanditiis.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 14, 4, 48, 8, 815, DateTimeKind.Local), "Similique odio quas sit magni incidunt sint.", "df57d25e-b21d-490a-8024-d1a04e56934b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 14, 19, 40, 44, 178, DateTimeKind.Local), "Labore distinctio aliquam nesciunt.", "14052a15-abbd-4257-8aa3-14b803de5241", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 6, 8, 6, 130, DateTimeKind.Local), "Quam asperiores in ea.", "a436d9c3-ce62-4a1e-8293-5b17534d8398" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 20, 13, 36, 924, DateTimeKind.Local), "Qui omnis quasi eos sunt maxime.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 14, 5, 18, 56, 113, DateTimeKind.Local), "Voluptates vero libero aut fugiat.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 14, 17, 50, 25, 128, DateTimeKind.Local), "Quaerat quidem ullam.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, false, "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: "683266fc-140c-4a5e-ac01-7ff8304a848b");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 2, "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 44, 16, 752, DateTimeKind.Local), 15, "Aut voluptatem unde est.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 14, 51, 50, 898, DateTimeKind.Local), 15, "Expedita iusto quidem iure occaecati assumenda ipsum beatae perspiciatis sed.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 52, 4, 886, DateTimeKind.Local), 20, "Voluptas vel eligendi rerum dicta cupiditate in facilis vel qui.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 27, 41, 864, DateTimeKind.Local), 15, "Omnis et quis dolores deleniti.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 5, 16, 182, DateTimeKind.Local), 11, "Dolor dolor quidem.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 17, 52, 10, 274, DateTimeKind.Local), 18, "Doloremque reiciendis consequatur.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 20, 34, 134, DateTimeKind.Local), 17, "Rem nam et.", "a436d9c3-ce62-4a1e-8293-5b17534d8398" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 6, 15, 537, DateTimeKind.Local), "Quia expedita repellendus aut voluptatem fuga maxime omnis amet.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 10, 27, 565, DateTimeKind.Local), "Sint praesentium qui quaerat cupiditate iste aut autem dicta.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 38, 8, 302, DateTimeKind.Local), 20, "Quo ut eum.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-430-508-8606 x675", "863baf8a-b306-4a9f-84f0-5df0a3e7b480", "Dolorum nulla eius quia temporibus vero est. Rerum culpa magni dolores asperiores esse aliquam modi aut et. Neque molestiae voluptas vitae. Aut vitae minima repudiandae enim sunt voluptatibus iure consequatur dolore.", "Spencer.Quitzon22@hotmail.com", "Company998", 64, "https://alene.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "348-833-7077 x33756", "863baf8a-b306-4a9f-84f0-5df0a3e7b480", "Animi quod quia placeat omnis accusamus nihil eveniet ab. Deleniti itaque et error tenetur quae quaerat. Quia nulla nostrum.", "Mariah.Parker@yahoo.com", "Company517", 61, "https://tyson.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "940.349.7927 x213", "76417ced-9632-4ebd-808d-717e70a270d2", "Lillian_Dooley@hotmail.com", "Company72", 63, "http://yasmin.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-444-418-6761 x620", "76417ced-9632-4ebd-808d-717e70a270d2", "Ad illum asperiores excepturi nihil fugiat.", "Robbie_Mann25@yahoo.com", "Company447", 63, "https://terrance.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(637) 904-5662", "a436d9c3-ce62-4a1e-8293-5b17534d8398", "Placeat quia quos reprehenderit iusto. Ea dolorem tempore reiciendis qui voluptas architecto. Saepe expedita numquam molestiae. Odit non fugiat autem unde ut ab ut.", "Winston.Zieme@hotmail.com", "Company580", 69, "http://josiah.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(256) 875-6858 x42578", "683266fc-140c-4a5e-ac01-7ff8304a848b", "Rerum quos eum harum ea rerum. Nemo dolor ratione accusantium molestiae dicta. Quasi cum fugiat asperiores. Magnam dolor consequatur consequatur ea explicabo voluptatum maiores.", "Matilda80@hotmail.com", "Company217", 65, "https://bud.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(253) 469-4735 x77162", "7a3d1395-bd4d-492c-ba90-76c148d7f559", "", "Eloise_Kautzer@gmail.com", "Company405", "http://dayna.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "427-618-2961 x924", "14052a15-abbd-4257-8aa3-14b803de5241", "Consequuntur ab facilis modi nihil non laboriosam cumque. Itaque deleniti odio repellendus voluptatem at voluptas eum ratione. Labore dolores perspiciatis autem provident suscipit aut qui suscipit iure. Quo nesciunt reiciendis explicabo odit voluptas reiciendis iusto ipsum necessitatibus.", "Lucius.Stroman81@hotmail.com", "Company538", 69, "https://maeve.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "661-685-3039 x2346", "a436d9c3-ce62-4a1e-8293-5b17534d8398", "", "Hilda_Koss82@yahoo.com", "Company369", 64, "http://barney.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-576-653-5508", "310558b5-97d8-4ad0-a0c0-cc597712123b", "Quas ut sunt in dolorum sit delectus omnis. Facere voluptatum assumenda consequuntur perspiciatis vel exercitationem voluptate qui.", "Dion53@gmail.com", "Company390", 70, "https://syble.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 20, 38, 452, DateTimeKind.Local), 49, "Delectus et fuga voluptas.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 37, 59, 716, DateTimeKind.Local), 43, "Ipsa ut unde quidem non aut similique odit repellendus.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 3, 28, 38, 909, DateTimeKind.Local), 43, "Delectus voluptatem ut architecto accusantium et.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 6, 2, 517, DateTimeKind.Local), 48, "Iure qui reiciendis et quo non aut illo voluptatem repudiandae.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 26, 35, 500, DateTimeKind.Local), 43, "Rerum sed eaque quaerat perspiciatis.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 6, 11, 14, 132, DateTimeKind.Local), 44, "Repellendus repellat officia minima aliquam sit delectus illo.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 58, 55, 398, DateTimeKind.Local), 45, "Et tenetur quod minus.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 45, 39, 740, DateTimeKind.Local), 45, "Enim commodi amet.", "a436d9c3-ce62-4a1e-8293-5b17534d8398" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 53, 59, 149, DateTimeKind.Local), 41, "Sed corrupti est eos inventore magni.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 48, 22, 23, DateTimeKind.Local), 50, "Recusandae pariatur accusamus exercitationem.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "df57d25e-b21d-490a-8024-d1a04e56934b", 74 },
                    { "70f945d0-f3c7-4587-9676-fc089b4451ce", 75 },
                    { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", 75 },
                    { "b8493acc-5078-4e21-a205-74dc72d89ff8", 78 },
                    { "76417ced-9632-4ebd-808d-717e70a270d2", 75 },
                    { "310558b5-97d8-4ad0-a0c0-cc597712123b", 78 },
                    { "7a3d1395-bd4d-492c-ba90-76c148d7f559", 72 },
                    { "a436d9c3-ce62-4a1e-8293-5b17534d8398", 78 },
                    { "683266fc-140c-4a5e-ac01-7ff8304a848b", 73 },
                    { "14052a15-abbd-4257-8aa3-14b803de5241", 73 }
                });
        }
    }
}
