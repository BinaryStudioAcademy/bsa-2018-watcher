using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class InstanceNotificationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2ee32823-b021-4550-8e5f-b088c23fd874", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7ca053c-4bec-4203-9aa0-997b882c951a", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", 69 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ee32823-b021-4550-8e5f-b088c23fd874");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3f7af429-6ed4-40e8-ac34-299fe0d586e5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48ee168e-2faf-46e5-aa8c-8f6f7805e83f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b785f6e0-927e-465f-bd0c-f80fe56e6a37");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c8cbd2c7-f945-4fe2-9c5f-16a93334e847");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cc463ef1-3498-4b49-8450-aaaafcd1dcb8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7ca053c-4bec-4203-9aa0-997b882c951a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 32, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 60, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 88, 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 21, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 70, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 72, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 88, 26 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 87, 39 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 83, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 0, 32, 637, DateTimeKind.Local), 79, "Title216" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 20, 52, 752, DateTimeKind.Local), 76, "Title172" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 26, 17, 325, DateTimeKind.Local), 77, "Title30" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 6, 21, 591, DateTimeKind.Local), 78, "Title730" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 26, 40, 634, DateTimeKind.Local), 77, "Title576" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 30, 55, 41, DateTimeKind.Local), 76, "Title43" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 57, 40, 204, DateTimeKind.Local), 73, "Title781" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 18, 49, 847, DateTimeKind.Local), "Title59" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 7, 10, 767, DateTimeKind.Local), 71, "Title24" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 22, 33, 501, DateTimeKind.Local), 79, "Title329" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address",  "OrganizationId", "Title" },
                values: new object[] { "d4:20:62:4c:d5:09",  64, "Instance386" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address",  "OrganizationId", "Title" },
                values: new object[] { "9d:73:46:bd:54:91",  63, "Instance104" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address",  "OrganizationId", "Title" },
                values: new object[] { "81:76:08:eb:c7:67",  65, "Instance188" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address",  "OrganizationId", "Platform", "Title" },
                values: new object[] { "a0:d6:7f:a6:89:92",  70, "Linux", "Instance97" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address",  "OrganizationId", "Platform", "Title" },
                values: new object[] { "65:75:cd:b8:2e:d5",  68, "Windows", "Instance47" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address",  "OrganizationId", "Platform", "Title" },
                values: new object[] { "3a:ca:99:53:c6:5d",  61, "Windows", "Instance522" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address",  "OrganizationId", "Title" },
                values: new object[] { "8b:c1:0c:96:6d:c6",  70, "Instance519" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address",  "OrganizationId", "Title" },
                values: new object[] { "95:32:57:f6:aa:0b",  67, "Instance203" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address",  "Platform", "Title" },
                values: new object[] { "9a:13:16:00:49:d5",  "Windows", "Instance735" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address",  "OrganizationId", "Platform", "Title" },
                values: new object[] { "7b:85:89:9d:ae:a3",  65, "Windows", "Instance875" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "bfb1e6a4-218d-4333-b161-24ab083d7a28", null, new DateTime(2018, 9, 12, 13, 32, 1, 826, DateTimeKind.Local), "Krystal", "Arthur_Kshlerin74@gmail.com", null, "Johnpaul", true, false, "Murray", null, "https://s3.amazonaws.com/uifaces/faces/twitter/syropian/128.jpg", 2 },
                    { "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", null, new DateTime(2018, 9, 12, 2, 47, 5, 986, DateTimeKind.Local), "Estella", "Terry.DuBuque@gmail.com", null, "Velda", true, false, "Hermiston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/layerssss/128.jpg", 2 },
                    { "4d07300b-6cdb-4336-8873-5b787fcc233d", null, new DateTime(2018, 9, 12, 7, 36, 31, 769, DateTimeKind.Local), "Brigitte", "Lennie_Dietrich81@hotmail.com", null, "Georgianna", true, false, "Kovacek", null, "https://s3.amazonaws.com/uifaces/faces/twitter/petar_prog/128.jpg", 1 },
                    { "350281ff-c0af-46cd-a795-1cd23fbece28", null, new DateTime(2018, 9, 12, 9, 50, 51, 382, DateTimeKind.Local), "Larue", "Floyd78@yahoo.com", null, "Benjamin", true, false, "Ullrich", null, "https://s3.amazonaws.com/uifaces/faces/twitter/alterchuca/128.jpg", 1 },
                    { "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", null, new DateTime(2018, 9, 12, 18, 40, 13, 480, DateTimeKind.Local), "Chadd", "Violet_Rodriguez2@hotmail.com", null, "Madilyn", true, false, "Denesik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/franciscoamk/128.jpg", 1 },
                    { "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", null, new DateTime(2018, 9, 12, 11, 1, 19, 31, DateTimeKind.Local), "Naomie", "Lauriane48@gmail.com", null, "Raina", true, false, "West", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_pedropinho/128.jpg", 1 },
                    { "6ac80c55-193e-47e8-9926-112c1075a759", null, new DateTime(2018, 9, 12, 13, 37, 23, 451, DateTimeKind.Local), "Eric", "Eli_Kub93@yahoo.com", null, "Dannie", true, false, "Cruickshank", null, "https://s3.amazonaws.com/uifaces/faces/twitter/justinrgraham/128.jpg", 1 },
                    { "094be847-b7b1-4ff5-ba11-60fc14bfd63a", null, new DateTime(2018, 9, 12, 3, 50, 33, 677, DateTimeKind.Local), "Jayda", "Dale_Christiansen36@hotmail.com", null, "Kaya", true, false, "Kemmer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/fuck_you_two/128.jpg", 2 },
                    { "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc", null, new DateTime(2018, 9, 11, 22, 3, 16, 874, DateTimeKind.Local), "Rey", "Reymundo.Kunde25@yahoo.com", null, "Matilde", true, false, "Morissette", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sulaqo/128.jpg", 2 },
                    { "1b12dd3e-572c-4fc5-9874-4fd59b65fe28", null, new DateTime(2018, 9, 12, 9, 34, 19, 341, DateTimeKind.Local), "Gladyce", "Cleta27@yahoo.com", null, "Loyce", true, false, "Davis", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mashaaaaal/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "350281ff-c0af-46cd-a795-1cd23fbece28", "porro" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d07300b-6cdb-4336-8873-5b787fcc233d", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d07300b-6cdb-4336-8873-5b787fcc233d", "deserunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1b12dd3e-572c-4fc5-9874-4fd59b65fe28", "sit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6ac80c55-193e-47e8-9926-112c1075a759", "vero" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "350281ff-c0af-46cd-a795-1cd23fbece28", "veniam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d07300b-6cdb-4336-8873-5b787fcc233d", "accusantium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d07300b-6cdb-4336-8873-5b787fcc233d", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc", "provident" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 38, 53, 966, DateTimeKind.Local), "Et excepturi eius minus ipsum et voluptatum impedit minima.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 34, 18, 286, DateTimeKind.Local), "Voluptas error vel vel consequatur.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 24, 29, 321, DateTimeKind.Local), "Enim ut consequatur eum sint.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 24, 29, 585, DateTimeKind.Local), "Inventore ut tempora rerum rerum est maiores occaecati.", "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 40, 5, 380, DateTimeKind.Local), "Nihil ipsam nihil possimus eum illum.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 13, 28, 802, DateTimeKind.Local), "Sed impedit natus velit aut ut qui explicabo qui quo.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 4, 34, 434, DateTimeKind.Local), "Id et enim quasi.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 22, 1, 157, DateTimeKind.Local), "In eos vel soluta enim at quae.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 22, 52, 498, DateTimeKind.Local), "Similique fuga quia commodi velit ut voluptate illum veritatis soluta.", "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 6, 20, 929, DateTimeKind.Local), "Mollitia ipsam vitae non in assumenda.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 18, 34, 14, 408, DateTimeKind.Local), "Voluptas suscipit eos eos corrupti placeat.", "bfb1e6a4-218d-4333-b161-24ab083d7a28", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 20, 38, 47, 654, DateTimeKind.Local), "In sint ratione aut pariatur doloribus quo repudiandae voluptatem omnis.", "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 7, 17, 43, 406, DateTimeKind.Local), "Qui et dolorem distinctio laudantium dolorem aut numquam officiis.", "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 3, 34, 412, DateTimeKind.Local), "Ut pariatur quia deserunt esse voluptatem.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 12, 11, 19, 15, DateTimeKind.Local), "Velit et iste soluta aut sit voluptatibus eaque.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 14, 12, 24, 868, DateTimeKind.Local), "Natus voluptas quis.", "4d07300b-6cdb-4336-8873-5b787fcc233d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 9, 45, 14, 921, DateTimeKind.Local), "Minus qui sint repudiandae et velit laudantium.", "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 6, 53, 4, 938, DateTimeKind.Local), "Consequatur ab unde iste provident est.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 5, 9, 5, 584, DateTimeKind.Local), "Sunt qui ab.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 15, 43, 12, 818, DateTimeKind.Local), "Temporibus dolores eaque soluta dolorem rerum assumenda corrupti sint occaecati.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 1, "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "bfb1e6a4-218d-4333-b161-24ab083d7a28" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 0, "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "bfb1e6a4-218d-4333-b161-24ab083d7a28" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "1b12dd3e-572c-4fc5-9874-4fd59b65fe28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 24, 51, 647, DateTimeKind.Local), 14, "Similique similique ut nihil itaque architecto ab.", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 47, 31, 497, DateTimeKind.Local), 19, "Sapiente aut nobis eum ipsa necessitatibus.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 3, 47, 798, DateTimeKind.Local), 17, "Sed hic reprehenderit.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 20, 15, 284, DateTimeKind.Local), 18, "Illum officiis quos molestiae eum qui est et.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 32, 34, 437, DateTimeKind.Local), 20, "Officia fugiat id iusto itaque.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 51, 13, 551, DateTimeKind.Local), 13, "Excepturi voluptatem ut cumque qui iste consequatur.", "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 13, 0, 965, DateTimeKind.Local), 20, "Rem quam ducimus expedita eum ut dolores.", "bfb1e6a4-218d-4333-b161-24ab083d7a28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 30, 37, 853, DateTimeKind.Local), 12, "Incidunt aut a quis numquam laudantium excepturi blanditiis saepe.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 55, 15, 829, DateTimeKind.Local), 14, "Quisquam hic modi et voluptatem.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 12, 34, 704, DateTimeKind.Local), 12, "Et vel dolorem iure vitae est.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-490-926-1308 x80944", "bfb1e6a4-218d-4333-b161-24ab083d7a28", "Ex est nam sed enim est sed magnam culpa. Omnis quam et veritatis beatae voluptatem id repellendus commodi. Ea id numquam ut in nihil.", "Graham18@yahoo.com", "Company726", 2, "http://judy.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "386-573-8688", "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", "Impedit sed nemo in et. Consequuntur eos id facere optio architecto. Non est aspernatur quae magnam et modi quia est.", "Alison_Hamill@hotmail.com", "Company176", "https://avery.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "991.239.2447", "4d07300b-6cdb-4336-8873-5b787fcc233d", "Et dolorum quibusdam error similique error quos sed recusandae. Ipsam dolorem in illo non rerum sint iste libero laborum. Minus aut dicta et inventore debitis.", "Clint19@yahoo.com", "Company573", "http://jaleel.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(929) 461-6306 x890", "350281ff-c0af-46cd-a795-1cd23fbece28", "", "Reed_Donnelly@gmail.com", "Company368", "https://judy.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "539-599-2614", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", "Et odio error non suscipit deleniti. Aliquam cum et quam voluptas asperiores voluptatem sed est. Quia cumque expedita libero voluptatem labore vel est. Ut voluptatibus fugiat et ut nam tenetur voluptatem.", "Jolie16@yahoo.com", "Company814", "https://edwina.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "890.572.7717 x56574", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", "", "Arvid.Lang57@hotmail.com", "Company127", 2, "http://kyler.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(779) 214-5197 x5883", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", "Molestias quo aliquid voluptatem. Quia omnis enim.", "Alvena.Oberbrunner61@yahoo.com", "Company809", 2, "http://skyla.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "653-280-0512 x1114", "bfb1e6a4-218d-4333-b161-24ab083d7a28", "Expedita velit voluptas laudantium in velit fuga eum. Facere eligendi voluptas et laboriosam commodi.", "Caesar_Beer53@hotmail.com", "Company780", "http://haylee.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-206-722-8604 x223", "4d07300b-6cdb-4336-8873-5b787fcc233d", "Aspernatur commodi enim nobis eum et aut vero labore laboriosam.", "Kenneth_Murray@gmail.com", "Company867", 1, "http://ubaldo.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(779) 586-8936 x338", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", "Id voluptates est quibusdam quis architecto sequi pariatur nam.", "Donna.Klein37@yahoo.com", "Company25", "https://michel.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 22, 49, 33, DateTimeKind.Local), 43, "Eveniet quo ut cum voluptas debitis.", "bfb1e6a4-218d-4333-b161-24ab083d7a28" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 4, 27, 806, DateTimeKind.Local), 44, "Aut nesciunt enim consectetur vitae pariatur ut corporis.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 50, 45, 375, DateTimeKind.Local), "Praesentium nobis deleniti repellendus commodi incidunt facilis rem.", "094be847-b7b1-4ff5-ba11-60fc14bfd63a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 13, 43, 704, DateTimeKind.Local), 48, "Est atque perferendis occaecati.", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 29, 57, 307, DateTimeKind.Local), 42, "Laudantium ea aut.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 46, 40, 572, DateTimeKind.Local), 49, "Ea aperiam laudantium ut veritatis quasi amet vel nam velit.", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 22, 24, 313, DateTimeKind.Local), 41, "Placeat expedita aut quos fugit totam.", "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 35, 36, 447, DateTimeKind.Local), 45, "Quis sed nemo magnam inventore.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 14, 22, 750, DateTimeKind.Local), 41, "Ut veniam iusto laborum.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 38, 20, 114, DateTimeKind.Local), 50, "Odit aliquid quia deleniti perferendis pariatur facilis.", "094be847-b7b1-4ff5-ba11-60fc14bfd63a" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "6ac80c55-193e-47e8-9926-112c1075a759", 61, 1 },
                    { "094be847-b7b1-4ff5-ba11-60fc14bfd63a", 64, 1 },
                    { "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", 66, 1 },
                    { "350281ff-c0af-46cd-a795-1cd23fbece28", 69, 1 },
                    { "4d07300b-6cdb-4336-8873-5b787fcc233d", 66, 1 },
                    { "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", 66, 1 },
                    { "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc", 69, 1 },
                    { "bfb1e6a4-218d-4333-b161-24ab083d7a28", 68, 1 },
                    { "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", 67, 1 },
                    { "1b12dd3e-572c-4fc5-9874-4fd59b65fe28", 61, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "094be847-b7b1-4ff5-ba11-60fc14bfd63a", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1b12dd3e-572c-4fc5-9874-4fd59b65fe28", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "350281ff-c0af-46cd-a795-1cd23fbece28", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4d07300b-6cdb-4336-8873-5b787fcc233d", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6ac80c55-193e-47e8-9926-112c1075a759", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bfb1e6a4-218d-4333-b161-24ab083d7a28", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d", 66 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "094be847-b7b1-4ff5-ba11-60fc14bfd63a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1b12dd3e-572c-4fc5-9874-4fd59b65fe28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "350281ff-c0af-46cd-a795-1cd23fbece28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4d07300b-6cdb-4336-8873-5b787fcc233d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6ac80c55-193e-47e8-9926-112c1075a759");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bfb1e6a4-218d-4333-b161-24ab083d7a28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8825d6b-13e6-4790-ae0e-dc0c34ebdd9d");

            migrationBuilder.DropColumn(
                name: "AggregationForDay",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "AggregationForHour",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "AggregationForMonth",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "AggregationForWeek",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "CpuMaxPercent",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "DiskMaxPercent",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 39, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 80, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 89, 88 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 76, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 85, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 82, 93, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 86, 14 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 83, 30 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 89, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 20, 27, 49, DateTimeKind.Local), 76, "Title517" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 36, 34, 79, DateTimeKind.Local), 80, "Title481" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 48, 0, 485, DateTimeKind.Local), 74, "Title251" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 55, 11, 390, DateTimeKind.Local), 72, "Title66" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 55, 43, 464, DateTimeKind.Local), 78, "Title622" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 27, 30, 782, DateTimeKind.Local), 73, "Title588" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 20, 19, 432, DateTimeKind.Local), 77, "Title183" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 54, 33, 558, DateTimeKind.Local), "Title296" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 56, 34, 871, DateTimeKind.Local), 78, "Title934" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 19, 28, 646, DateTimeKind.Local), 74, "Title823" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "93:04:c2:97:dd:22", 63, "Instance595" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d5:d7:a4:87:f7:68", 61, "Instance726" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ed:47:ea:9f:57:79", 66, "Instance534" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5b:4e:aa:ef:b2:36", 62, "Windows", "Instance998" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8d:9c:f1:0c:a9:b7", 62, "Linux", "Instance743" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "7d:c1:0f:ad:61:4c", 62, "Linux", "Instance754" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "98:1f:60:6c:e6:86", 62, "Instance248" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "48:3c:97:9c:5d:50", 64, "Instance829" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "48:06:63:c9:d0:9a", "Linux", "Instance959" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1c:fc:8e:5a:53:6d", 63, "Linux", "Instance555" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", null, new DateTime(2018, 9, 12, 11, 21, 35, 418, DateTimeKind.Local), "Manley", "Virgil_Weissnat@yahoo.com", null, "Ed", true, false, "Baumbach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/reabo101/128.jpg", 2 },
                    { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", null, new DateTime(2018, 9, 12, 4, 42, 43, 356, DateTimeKind.Local), "Lizzie", "Marques45@gmail.com", null, "Armani", true, false, "Kilback", null, "https://s3.amazonaws.com/uifaces/faces/twitter/marakasina/128.jpg", 1 },
                    { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", null, new DateTime(2018, 9, 12, 7, 40, 13, 876, DateTimeKind.Local), "Brigitte", "Mercedes82@gmail.com", null, "Domenica", true, false, "Frami", null, "https://s3.amazonaws.com/uifaces/faces/twitter/notbadart/128.jpg", 2 },
                    { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", null, new DateTime(2018, 9, 12, 10, 24, 3, 739, DateTimeKind.Local), "Kennedi", "Fritz.Batz@yahoo.com", null, "Jules", true, false, "Gutmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sircalebgrove/128.jpg", 2 },
                    { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", null, new DateTime(2018, 9, 12, 17, 12, 58, 427, DateTimeKind.Local), "Trystan", "Bryana.Kuhic@hotmail.com", null, "Barney", true, false, "Morissette", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tomas_janousek/128.jpg", 1 },
                    { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", null, new DateTime(2018, 9, 12, 6, 33, 51, 756, DateTimeKind.Local), "Heaven", "Neal_Fay@yahoo.com", null, "Desiree", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mizhgan/128.jpg", 1 },
                    { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", null, new DateTime(2018, 9, 12, 2, 11, 37, 450, DateTimeKind.Local), "Enola", "Ed7@yahoo.com", null, "Keven", true, false, "Waelchi", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mutu_krish/128.jpg", 2 },
                    { "e7ca053c-4bec-4203-9aa0-997b882c951a", null, new DateTime(2018, 9, 12, 9, 43, 22, 693, DateTimeKind.Local), "Josianne", "Samanta.Armstrong72@gmail.com", null, "Gerda", true, false, "Corkery", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nessoila/128.jpg", 1 },
                    { "2ee32823-b021-4550-8e5f-b088c23fd874", null, new DateTime(2018, 9, 11, 23, 43, 45, 369, DateTimeKind.Local), "Wilma", "Elaina.Conroy82@hotmail.com", null, "Alysson", true, false, "Schamberger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/aoimedia/128.jpg", 1 },
                    { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", null, new DateTime(2018, 9, 12, 10, 13, 45, 193, DateTimeKind.Local), "Layla", "Cassidy.Swift63@gmail.com", null, "Alan", true, false, "Lebsack", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dhrubo/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", "quibusdam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "a" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "numquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", "inventore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "saepe" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2ee32823-b021-4550-8e5f-b088c23fd874", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "aliquid" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 51, 53, 758, DateTimeKind.Local), "Qui explicabo laboriosam.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 27, 39, 578, DateTimeKind.Local), "Dolorum hic atque officiis.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 25, 31, 347, DateTimeKind.Local), "Voluptatibus fuga sit et eum enim ipsum.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 51, 2, 365, DateTimeKind.Local), "Possimus aspernatur qui reiciendis dolorem.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 12, 31, 161, DateTimeKind.Local), "Voluptas ducimus corporis voluptates.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 30, 38, 260, DateTimeKind.Local), "Ut harum facilis ullam facere.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 41, 42, 699, DateTimeKind.Local), "Laudantium in quaerat accusantium.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 4, 23, 530, DateTimeKind.Local), "Provident sapiente alias quo qui necessitatibus.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 52, 48, 900, DateTimeKind.Local), "Exercitationem sint placeat fugit culpa nemo.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 44, 36, 491, DateTimeKind.Local), "Voluptatem aperiam rerum non fugiat.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 5, 39, 2, 576, DateTimeKind.Local), "Itaque quo dolores cupiditate.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 1, 31, 57, 152, DateTimeKind.Local), "Nam praesentium rerum autem fugit incidunt quidem.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 12, 46, 37, 858, DateTimeKind.Local), "Dolorem ducimus temporibus omnis sunt repudiandae accusantium voluptate dolores.", "2ee32823-b021-4550-8e5f-b088c23fd874", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 17, 55, 412, DateTimeKind.Local), "Culpa nam qui dolorum.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 16, 21, 25, 909, DateTimeKind.Local), "Et vitae aperiam et consequatur sed ullam.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 19, 25, 32, 705, DateTimeKind.Local), "Ut nisi ut omnis libero ut est quasi aliquid.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 12, 8, 19, 40, 625, DateTimeKind.Local), "Aut incidunt magni iusto iure qui cum molestiae.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 10, 3, 30, 182, DateTimeKind.Local), "Sed adipisci rem.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 9, 30, 32, 36, DateTimeKind.Local), "Voluptatem pariatur vero voluptatem magnam.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 17, 58, 11, 879, DateTimeKind.Local), "Natus aut ea.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 0, "2ee32823-b021-4550-8e5f-b088c23fd874" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 3, "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 43, 26, 305, DateTimeKind.Local), 20, "Maiores assumenda corrupti maxime asperiores cupiditate labore et.", "2ee32823-b021-4550-8e5f-b088c23fd874" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 37, 22, 18, DateTimeKind.Local), 14, "Voluptatum explicabo aperiam tempora doloribus excepturi et ullam.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 48, 44, 338, DateTimeKind.Local), 19, "Qui earum sed ut sint vero.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 7, 45, 344, DateTimeKind.Local), 14, "Ut officia qui dolorem recusandae facilis eos iste.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 8, 25, 527, DateTimeKind.Local), 11, "Eum magni ipsam quas inventore ut at quia neque.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 38, 16, 254, DateTimeKind.Local), 19, "Ab doloribus saepe excepturi illo.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 52, 43, 362, DateTimeKind.Local), 16, "Eum ducimus vitae neque in maiores nesciunt earum quasi.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 21, 34, 540, DateTimeKind.Local), 16, "Ea aperiam esse.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 31, 58, 418, DateTimeKind.Local), 18, "Et culpa ipsum aut voluptatum rerum et dolore.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 16, 18, 563, DateTimeKind.Local), 18, "Hic sit ullam accusamus quam saepe assumenda accusamus ab.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "904-366-5161", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "Labore ducimus sint ut. Repudiandae eos qui. Illum fugit et et similique eum reprehenderit molestias praesentium labore. Dolore et voluptas enim omnis modi pariatur.", "King24@gmail.com", "Company418", 1, "https://tiffany.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "300.425.0816 x1838", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", "Est autem et et beatae eligendi qui. Assumenda ex eos sunt optio facere dolorem ut in et. Tempora placeat incidunt.", "Irving.Runte63@yahoo.com", "Company579", "https://dangelo.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "977.548.1294 x41479", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Qui excepturi vero esse occaecati dolores voluptatem. Voluptas quam minima nemo nostrum voluptatem enim quia omnis.", "Wilfred.Parker@hotmail.com", "Company802", "https://destini.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "740-976-5325", "e7ca053c-4bec-4203-9aa0-997b882c951a", "Blanditiis nulla sapiente et sequi neque delectus soluta. Consequuntur accusamus corrupti incidunt nesciunt incidunt praesentium dolorem aut. Assumenda ad numquam provident laboriosam consequatur non error molestias amet. Occaecati aut incidunt officiis saepe omnis asperiores.", "Felix.Mueller25@yahoo.com", "Company622", "http://arvid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-350-542-3689", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "Quos enim est possimus aliquam ea. Blanditiis laudantium odio repellendus est. Rem at repudiandae labore vel reprehenderit ut quasi.", "Francesca99@hotmail.com", "Company162", "https://lance.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(403) 274-3967 x6849", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Eum consequatur omnis et iure quam.", "Hilma.OHara@gmail.com", "Company109", 1, "https://cara.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "880.996.0464", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Praesentium voluptatem et maiores eveniet animi non minima. Sit excepturi fugit fuga non porro asperiores iste tempora asperiores. Praesentium vel fuga dolores atque itaque dolorum.", "Leopold53@hotmail.com", "Company229", 1, "https://coty.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "425-737-4490", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", "Quos consequuntur ut facilis rerum sunt. Sapiente reiciendis rerum voluptatibus eveniet aut et. Sed inventore consequatur quasi ducimus deserunt sapiente. Possimus omnis eaque odit cumque.", "Joaquin.Johnston@gmail.com", "Company996", "https://benny.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "737-237-8123 x5047", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Deleniti sunt animi laudantium et voluptatum possimus necessitatibus dolor. A reiciendis incidunt sit incidunt distinctio quisquam nulla et.", "Theodora.Lebsack@gmail.com", "Company54", 2, "https://megane.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-977-618-8124", "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "Quod repudiandae rerum tempora fugit ut nemo. Et et quo ducimus ut voluptatem et. Incidunt rerum in est inventore. Maiores libero enim dolores iste fugiat eaque quisquam dolorum.", "Dahlia87@yahoo.com", "Company31", "http://celia.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 1, 53, 507, DateTimeKind.Local), 50, "Accusamus non ea voluptates et reprehenderit.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 23, 2, 738, DateTimeKind.Local), 41, "Voluptates molestiae reprehenderit odio et.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 31, 30, 614, DateTimeKind.Local), "Quibusdam ipsum est nesciunt.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 29, 37, 132, DateTimeKind.Local), 41, "Et autem alias magni ipsum.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 15, 25, 547, DateTimeKind.Local), 47, "Nulla perspiciatis nam quia.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 28, 27, 995, DateTimeKind.Local), 48, "Neque molestiae sapiente aut autem aliquam suscipit dolorem officia voluptates.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 36, 22, 523, DateTimeKind.Local), 46, "Consequatur a magni temporibus sed repudiandae numquam id ullam minima.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 36, 55, 46, DateTimeKind.Local), 49, "Laboriosam sed quos iure maiores adipisci nisi aut.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 50, 54, 814, DateTimeKind.Local), 48, "Nam corporis qui eius illum et ea.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 4, 20, 976, DateTimeKind.Local), 45, "Occaecati dolore placeat placeat nihil et nobis laudantium est porro.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", 69, 1 },
                    { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", 67, 1 },
                    { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", 61, 1 },
                    { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", 63, 1 },
                    { "2ee32823-b021-4550-8e5f-b088c23fd874", 61, 1 },
                    { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", 66, 1 },
                    { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", 68, 1 },
                    { "e7ca053c-4bec-4203-9aa0-997b882c951a", 63, 1 },
                    { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", 69, 1 },
                    { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", 63, 1 }
                });
        }
    }
}
