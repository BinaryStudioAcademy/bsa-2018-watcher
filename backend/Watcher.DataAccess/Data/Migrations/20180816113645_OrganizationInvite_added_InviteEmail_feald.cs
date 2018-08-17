using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class OrganizationInvite_added_InviteEmail_feald : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "InviteEmail",
                table: "OrganizationInvites",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 93, "Source3", 73 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", "Common2", "Source1", 22, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded1", "Source3", 90 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "Common2", "Source2", 82 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source2", 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Common3", "Source1", 53, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Source2", 22, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded2", "Source2", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded1", "Source1", 93, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "Common1", 90, 0 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 11, 14, 866, DateTimeKind.Local), 90, "Title430" });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "fd:8c:4e:fc:cf:bb", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "5a:13:21:83:16:0f", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "9a:d8:70:eb:80:78", 73 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "81:47:9e:bc:6c:53", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "81:3a:b7:53:69:dd", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "85:e0:e5:ec:ec:4f", 74, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "cb:27:a0:45:b4:6f", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "54:ef:7b:87:1d:cf", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "5f:b2:02:dc:57:48", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "a8:46:65:a0:92:4c", 75 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme309" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme386" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme24" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme798" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme153" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme501" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme779" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 15, 20, 48, 10, 397, DateTimeKind.Local), "Illo doloremque aut qui ipsum voluptates aut perspiciatis.", "4be27e39-6654-495c-b3f2-ba26be8cb54b", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 16, 11, 21, 40, 316, DateTimeKind.Local), "Est sapiente excepturi culpa.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 16, 8, 34, 9, 837, DateTimeKind.Local), "Minima voluptatem nesciunt dolorum quidem voluptatem corrupti nesciunt vitae.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 16, 7, 8, 9, 213, DateTimeKind.Local), "Quia error tempore in hic laudantium.", "2bc44d1c-425a-40ad-9fc4-76bcff6a8154" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "920895bb-0bf8-46c8-996a-2730d14086fe" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "301009ad-044d-4992-98d7-441cda647c1b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "a4445bd2-b428-423a-9e33-e93bfa3a39b1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "c1db6f4c-aeb7-4d80-89b8-44d1849edda6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "4b0f0015-4592-4c6b-a021-e3eda54ced32" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 11, 47, 353, DateTimeKind.Local), "Veniam eligendi veritatis molestias et quasi.", "301009ad-044d-4992-98d7-441cda647c1b" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 33, 27, 149, DateTimeKind.Local), 11, "Quis natus voluptatibus reiciendis dignissimos nulla ipsum et.", "809d33df-f119-43b0-8627-6553ccf484c8" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 8, 49, 445, DateTimeKind.Local), 15, "Architecto quisquam quo vitae veritatis.", "a4445bd2-b428-423a-9e33-e93bfa3a39b1" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-280-719-5102", "809d33df-f119-43b0-8627-6553ccf484c8", "In nulla odit cumque rerum deserunt quas. Fugiat laborum ad voluptatum.", "Phoebe.McCullough27@gmail.com", "Company495", 69, "https://carol.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(729) 402-5163 x3053", "809d33df-f119-43b0-8627-6553ccf484c8", "Julian.OConner@yahoo.com", "Company186", 61, "http://vivien.biz" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 56, 33, 417, DateTimeKind.Local), "Aut molestiae sed aut possimus in et omnis fugiat aliquid.", "809d33df-f119-43b0-8627-6553ccf484c8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 11, 7, 835, DateTimeKind.Local), "Minima sunt adipisci dicta ut.", "9688f885-30a2-43b1-9cd8-25f5c0c962dc" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 5, 59, 150, DateTimeKind.Local), "Nobis dolorem minima eos qui id velit.", "d1ca79c3-d251-4d2e-8617-daa6e2c6322a" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "InviteEmail",
                table: "OrganizationInvites");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 92, "Source2", 40 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Common3", "Source2", 62, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 96, "MostLoaded2", "Source1", 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 98, "Common1", "Source3", 78 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Common2", "Source3", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", "Common1", "Source3", 54, 2 });

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
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Source1", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Source3", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "Common3", 92, 1 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 10, 2, 112, DateTimeKind.Local), 88, "Title379" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 19, 11, 53, 470, DateTimeKind.Local), 83, "Title164" });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e6:f1:d2:92:f4:39", 80 });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "0b:40:1d:fb:4e:1b", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e8:32:37:65:ff:0d", 79 });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "d9:a2:a9:c2:01:8d", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "d7:ff:61:39:75:53", 79 });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme75" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme779" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme603" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme765" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme115" });

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
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "qui" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 11, 14, 16, 36, 4, DateTimeKind.Local), "Consequuntur consequatur ut molestiae possimus ab delectus temporibus.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 12, 10, 16, 39, 17, DateTimeKind.Local), "Ut eum corrupti voluptatem veniam.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 12, 9, 8, 1, 935, DateTimeKind.Local), "Sit facilis culpa illum consequatur omnis officia dolores aperiam est.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 17, 6, 10, 925, DateTimeKind.Local), "Enim sint consectetur ut quae culpa consequatur.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

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
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 39, 22, 177, DateTimeKind.Local), 17, "Molestiae recusandae hic est maiores quia placeat quasi.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(527) 866-4742", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "A perspiciatis beatae nisi necessitatibus iste natus eveniet. Inventore aliquam qui recusandae quisquam sit animi officiis.", "Thea60@yahoo.com", "Company668", 62, "https://tania.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(724) 861-1489 x84849", "a5001d94-a4ad-40d8-a333-9dc16a882630", "Keven.Kunde96@hotmail.com", "Company404", 64, "https://london.biz" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 5, 17, 774, DateTimeKind.Local), "Voluptatem quod vitae quis quo et quae nulla repellendus accusamus.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 49, 33, 572, DateTimeKind.Local), "Velit nobis vitae.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 46, 50, 964, DateTimeKind.Local), "Vel fuga nostrum voluptatem necessitatibus officia qui.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 5, 29, 108, DateTimeKind.Local), "Velit dolorum ullam amet maxime dolores.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

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
        }
    }
}
