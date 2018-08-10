using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedToUserLastPickedOgranization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Feedbacks_FeedbackId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_FeedbackId",
                table: "Responses");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3691f844-d30a-4664-a038-8fabe1113996", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3df70d4c-67de-460c-9a23-fe81f55a5d4d", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7aaebdba-ff37-43f7-ab90-98245d4c123e", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9c898d08-e70f-4352-b97e-3d03be59d0fb", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b57a563a-c110-4737-9061-4b0e78d5cb96", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c9c58051-889f-473c-a99d-05b7ec31287b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "de7a7411-8815-49d4-999e-ce38ab1f73ed", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "df4c167f-7d0e-43c3-a0ba-45da6a53a13d", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fc301d1b-121f-4a9f-8810-15ce0b34cf91", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3691f844-d30a-4664-a038-8fabe1113996");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3df70d4c-67de-460c-9a23-fe81f55a5d4d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7aaebdba-ff37-43f7-ab90-98245d4c123e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9c898d08-e70f-4352-b97e-3d03be59d0fb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b57a563a-c110-4737-9061-4b0e78d5cb96");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9c58051-889f-473c-a99d-05b7ec31287b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "de7a7411-8815-49d4-999e-ce38ab1f73ed");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "df4c167f-7d0e-43c3-a0ba-45da6a53a13d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fc301d1b-121f-4a9f-8810-15ce0b34cf91");

            migrationBuilder.AddColumn<int>(
                name: "LastPickedOrganizationId",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Common3", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common2", "Source1", 60, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", 33, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", "Common3", 14, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common1", "Source2", 39, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Common2", "Source2", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 99, "MostLoaded1", "Common3", "Source3", 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Common1", 36, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Common2", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common1", "Source3", 71, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 28, 55, 733, DateTimeKind.Local), 83, "Title719" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 20, 47, 40, 957, DateTimeKind.Local), 87, "Title509" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 8, 23, 49, 15, 835, DateTimeKind.Local), 88, "Title364" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 12, 51, 31, 631, DateTimeKind.Local), 89, "Title457" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 8, 22, 54, 57, 312, DateTimeKind.Local), 81, "Title15" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 12, 48, 47, 510, DateTimeKind.Local), 88, "Title702" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 57, 45, 200, DateTimeKind.Local), 89, "Title392" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 8, 22, 57, 24, 239, DateTimeKind.Local), 89, "Title701" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 1, 40, 54, 116, DateTimeKind.Local), 85, "Title213" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 46, 9, 947, DateTimeKind.Local), 86, "Title524" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "98:24:72:a9:73:6e", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "41:15:2d:20:6e:df", "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f5:f3:25:30:99:2f", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "1f:a3:9f:14:cd:98", "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "1b:79:4e:2e:aa:ec", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "dd:67:97:6e:1a:67", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "cb:4a:81:aa:2b:be", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "76:34:89:cf:cf:d9", 78, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "65:66:04:f5:91:67", 77, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "c9:78:52:31:97:3f", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme138" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme49" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme863" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme430" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme850" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme118" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme246" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme38" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme323" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme494" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastPickedOrganizationId", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "b752f3c0-ed83-4394-b041-bf5ec10bde52", null, new DateTime(2018, 8, 8, 21, 21, 11, 722, DateTimeKind.Local), "Frederic", "Alec.Hamill55@gmail.com", "Seamus", true, null, 1, "Zemlak" },
                    { "198a12e6-ef20-4a43-ac12-39187e7efc52", null, new DateTime(2018, 8, 9, 11, 2, 8, 18, DateTimeKind.Local), "Gwen", "Helga17@hotmail.com", "Benton", true, null, 1, "Hammes" },
                    { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", null, new DateTime(2018, 8, 8, 23, 33, 0, 93, DateTimeKind.Local), "Jonatan", "Willard53@yahoo.com", "Thomas", true, null, 1, "Hickle" },
                    { "4ff7c2a4-f212-42f4-9b57-4362f334992b", null, new DateTime(2018, 8, 9, 19, 47, 2, 716, DateTimeKind.Local), "Jacinthe", "Julianne.Sanford@gmail.com", "Estella", true, null, 1, "Larkin" },
                    { "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", null, new DateTime(2018, 8, 9, 18, 21, 47, 912, DateTimeKind.Local), "Cornelius", "Hanna_Harris14@hotmail.com", "Jerrell", true, null, 1, "Ernser" },
                    { "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0", null, new DateTime(2018, 8, 9, 17, 32, 14, 907, DateTimeKind.Local), "Elmer", "Linwood.Stehr@hotmail.com", "Elliott", true, null, 2, "Little" },
                    { "e5593b29-7c25-4985-a179-0ba5eaf01c00", null, new DateTime(2018, 8, 9, 5, 51, 57, 744, DateTimeKind.Local), "Josefa", "Larissa.Stroman@gmail.com", "Madelyn", true, null, 2, "O'Connell" },
                    { "783b295c-e5ba-4f3f-822c-ea2956b9edab", null, new DateTime(2018, 8, 9, 16, 46, 45, 29, DateTimeKind.Local), "Ashley", "Maybelle.Crona64@hotmail.com", "Trycia", true, null, 1, "Bruen" },
                    { "b547163a-781c-44d5-a498-4b8430b5cc94", null, new DateTime(2018, 8, 8, 23, 5, 35, 270, DateTimeKind.Local), "Frederick", "Waino90@gmail.com", "Giovani", true, null, 2, "Sawayn" },
                    { "d459eb30-de1a-49ef-9cfe-175147483ea5", null, new DateTime(2018, 8, 9, 7, 2, 45, 648, DateTimeKind.Local), "Keanu", "Kiera_Pouros46@hotmail.com", "Darryl", true, null, 1, "Ullrich" }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "198a12e6-ef20-4a43-ac12-39187e7efc52", "laborum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "783b295c-e5ba-4f3f-822c-ea2956b9edab", "minus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", "enim" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d459eb30-de1a-49ef-9cfe-175147483ea5", "maiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "198a12e6-ef20-4a43-ac12-39187e7efc52", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", "repellat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4ff7c2a4-f212-42f4-9b57-4362f334992b", "autem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4ff7c2a4-f212-42f4-9b57-4362f334992b", "quis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 10, 29, 50, 874, DateTimeKind.Local), "Odit ut blanditiis maiores voluptas laboriosam qui.", "4ff7c2a4-f212-42f4-9b57-4362f334992b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 20, 7, 29, 426, DateTimeKind.Local), "Aut labore consequatur voluptatibus.", "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 23, 5, 39, 240, DateTimeKind.Local), "Odio est et.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 1, 3, 28, 158, DateTimeKind.Local), "Modi alias ea animi.", "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 6, 58, 22, 431, DateTimeKind.Local), "Et ea reiciendis nam magnam nobis odit minus veniam.", "e5593b29-7c25-4985-a179-0ba5eaf01c00" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 1, 20, 41, 796, DateTimeKind.Local), "Reiciendis quibusdam accusamus est.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 21, 38, 51, 403, DateTimeKind.Local), "Beatae delectus ratione natus veritatis expedita laboriosam eos incidunt.", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 12, 33, 58, 896, DateTimeKind.Local), "Aut iusto sed corporis laborum voluptatem ratione minus.", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 13, 26, 17, 920, DateTimeKind.Local), "Sequi dolor labore omnis temporibus.", "4ff7c2a4-f212-42f4-9b57-4362f334992b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 4, 11, 70, DateTimeKind.Local), "Non quo ipsa itaque aut.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 9, 11, 15, 59, 232, DateTimeKind.Local), "Quaerat aut quasi voluptatum fugit delectus iste et ut velit.", "4ff7c2a4-f212-42f4-9b57-4362f334992b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 52, 48, 98, DateTimeKind.Local), "Odio corporis sit aut.", "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 9, 6, 14, 34, 299, DateTimeKind.Local), "Nihil molestiae perspiciatis.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 9, 1, 42, 34, 96, DateTimeKind.Local), "Ea qui ex dicta.", "b547163a-781c-44d5-a498-4b8430b5cc94", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 9, 19, 36, 5, 57, DateTimeKind.Local), "Animi porro sint ratione cumque vitae pariatur omnis.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 9, 2, 51, 51, 258, DateTimeKind.Local), "Incidunt ea cupiditate.", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 9, 19, 52, 21, 854, DateTimeKind.Local), "Labore nihil tempore.", "b752f3c0-ed83-4394-b041-bf5ec10bde52", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 9, 18, 16, 46, 225, DateTimeKind.Local), "Voluptas corrupti impedit exercitationem.", "b752f3c0-ed83-4394-b041-bf5ec10bde52", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 9, 7, 49, 40, 584, DateTimeKind.Local), "Alias ut eligendi nam vero quos optio earum magnam ex.", "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 9, 7, 15, 52, 192, DateTimeKind.Local), "Reprehenderit animi ea aut nulla delectus facilis maxime pariatur est.", "d459eb30-de1a-49ef-9cfe-175147483ea5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "198a12e6-ef20-4a43-ac12-39187e7efc52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 0, "198a12e6-ef20-4a43-ac12-39187e7efc52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: "b752f3c0-ed83-4394-b041-bf5ec10bde52");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 0, 44, 11, 650, DateTimeKind.Local), 13, "Quo architecto similique quaerat.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 4, 24, 47, 92, DateTimeKind.Local), 19, "Cupiditate animi incidunt esse amet occaecati temporibus.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 19, 14, 44, 19, DateTimeKind.Local), 14, "Sint quas possimus.", "4ff7c2a4-f212-42f4-9b57-4362f334992b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 11, 10, 716, DateTimeKind.Local), 19, "Reiciendis velit et accusantium voluptatem unde quas cupiditate perspiciatis.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 34, 46, 359, DateTimeKind.Local), "Qui eos qui odit aut.", "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 16, 16, 47, 189, DateTimeKind.Local), 11, "Neque cupiditate architecto aut eos tempore soluta beatae maiores.", "d459eb30-de1a-49ef-9cfe-175147483ea5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 5, 0, 16, 888, DateTimeKind.Local), 17, "Aut sed dolores culpa.", "d459eb30-de1a-49ef-9cfe-175147483ea5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 38, 19, 262, DateTimeKind.Local), 12, "Aperiam fugiat ut sunt repudiandae inventore ab est sed beatae.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 1, 1, 48, 894, DateTimeKind.Local), 18, "Et tenetur eos velit eum.", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 4, 50, 5, 798, DateTimeKind.Local), 19, "Repudiandae quia ut voluptatibus suscipit laborum ullam animi.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(461) 692-3410 x40384", "b752f3c0-ed83-4394-b041-bf5ec10bde52", "Amet qui quia.", "Nettie_Streich@hotmail.com", "Company709", 62, "https://leland.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "786.524.0136", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", "", "Garland_Zboncak@yahoo.com", "Company431", 66, "https://nico.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(452) 676-1236", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", "Fuga omnis autem id quasi sunt. Culpa voluptatem quia repudiandae debitis architecto sit iste. Iure distinctio earum qui.", "Davonte.Schroeder@yahoo.com", "Company496", 68, "http://rita.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(806) 733-1581 x661", "b752f3c0-ed83-4394-b041-bf5ec10bde52", "Repellat ut nam. Eos sed et ipsum sed voluptas ut minus.", "Roberto.Herzog87@hotmail.com", "Company381", 62, "https://wallace.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "792.792.6754 x922", "d459eb30-de1a-49ef-9cfe-175147483ea5", "Voluptates sint ut temporibus sequi. Consequuntur reprehenderit molestiae ut minus et unde. Labore eum eos qui. Dolor et alias.", "Anibal_Moore@hotmail.com", "Company386", 62, "http://noble.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(491) 495-3422 x515", "783b295c-e5ba-4f3f-822c-ea2956b9edab", "Quo officiis velit est omnis voluptates similique.", "Ignacio_Reinger@hotmail.com", "Company631", 62, "https://bernie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(621) 361-5680 x43115", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", "", "Manley7@hotmail.com", "Company590", "https://clinton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "398.240.6501", "b752f3c0-ed83-4394-b041-bf5ec10bde52", "Debitis recusandae sed voluptatem enim in. Ducimus perferendis fuga ipsum est velit aut.", "Jazmyn.Schultz@hotmail.com", "Company590", 64, "https://luella.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(243) 910-1956 x3921", "198a12e6-ef20-4a43-ac12-39187e7efc52", "", "Karley_Bernhard@hotmail.com", "Company758", 66, "https://josefa.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-516-479-4552", "4ff7c2a4-f212-42f4-9b57-4362f334992b", "Aperiam velit occaecati expedita eum fugiat laudantium. Inventore nemo explicabo eaque velit ut. Aut officia laborum odit quibusdam. Pariatur sint minima provident maxime non eum rerum laudantium et.", "Evangeline83@yahoo.com", "Company913", 70, "http://gladys.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 26, 12, 545, DateTimeKind.Local), 45, "Aut voluptates unde officiis placeat debitis vero dolor porro odio.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 8, 4, 33, 66, DateTimeKind.Local), 49, "Doloremque iusto laborum expedita asperiores eum qui aut.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 18, 2, 4, 904, DateTimeKind.Local), 49, "Officiis ut voluptas dolores expedita perspiciatis vel ut.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 18, 54, 32, 285, DateTimeKind.Local), "Natus ad voluptatem blanditiis inventore ut fugiat.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 21, 21, 44, 22, DateTimeKind.Local), 41, "Id quia modi assumenda quam sunt consequuntur ea id.", "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 18, 59, 14, 744, DateTimeKind.Local), 41, "Earum eius repellendus hic dignissimos sed omnis sed dolorum voluptatem.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 20, 30, 46, 414, DateTimeKind.Local), 43, "Qui sed reiciendis omnis eveniet.", "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 21, 4, 25, 957, DateTimeKind.Local), 41, "Et omnis reprehenderit aliquam.", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 5, 32, 20, 762, DateTimeKind.Local), 43, "Cupiditate enim ea sint voluptas error aut.", "e5593b29-7c25-4985-a179-0ba5eaf01c00" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 17, 37, 13, 171, DateTimeKind.Local), "Maiores corporis consequuntur ab ex est corporis.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e5593b29-7c25-4985-a179-0ba5eaf01c00", 76 },
                    { "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0", 76 },
                    { "b752f3c0-ed83-4394-b041-bf5ec10bde52", 72 },
                    { "b547163a-781c-44d5-a498-4b8430b5cc94", 78 },
                    { "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", 73 },
                    { "4ff7c2a4-f212-42f4-9b57-4362f334992b", 73 },
                    { "198a12e6-ef20-4a43-ac12-39187e7efc52", 77 },
                    { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", 71 },
                    { "783b295c-e5ba-4f3f-822c-ea2956b9edab", 74 },
                    { "d459eb30-de1a-49ef-9cfe-175147483ea5", 72 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LastPickedOrganizationId",
                table: "Users",
                column: "LastPickedOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ResponseId",
                table: "Feedbacks",
                column: "ResponseId",
                unique: true,
                filter: "[ResponseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Responses_ResponseId",
                table: "Feedbacks",
                column: "ResponseId",
                principalTable: "Responses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations_LastPickedOrganizationId",
                table: "Users",
                column: "LastPickedOrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Responses_ResponseId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organizations_LastPickedOrganizationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LastPickedOrganizationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ResponseId",
                table: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "198a12e6-ef20-4a43-ac12-39187e7efc52", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4ff7c2a4-f212-42f4-9b57-4362f334992b", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "783b295c-e5ba-4f3f-822c-ea2956b9edab", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b547163a-781c-44d5-a498-4b8430b5cc94", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b752f3c0-ed83-4394-b041-bf5ec10bde52", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d459eb30-de1a-49ef-9cfe-175147483ea5", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e5593b29-7c25-4985-a179-0ba5eaf01c00", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "198a12e6-ef20-4a43-ac12-39187e7efc52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ff7c2a4-f212-42f4-9b57-4362f334992b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "783b295c-e5ba-4f3f-822c-ea2956b9edab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b547163a-781c-44d5-a498-4b8430b5cc94");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b752f3c0-ed83-4394-b041-bf5ec10bde52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d459eb30-de1a-49ef-9cfe-175147483ea5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e5593b29-7c25-4985-a179-0ba5eaf01c00");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f7baf1d1-39e0-494f-90d6-5f5787f1b72f");

            migrationBuilder.DropColumn(
                name: "LastPickedOrganizationId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Common2", 49, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common1", "Source3", 49, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", 31, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common2", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common2", "Source1", 7, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common1", "Source3", 27, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 96, "MostLoaded3", "Common2", "Source2", 91 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Common2", 95, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", 78, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "Common2", "Source1", 65, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 35, 2, 933, DateTimeKind.Local), 85, "Title653" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 17, 12, 25, 951, DateTimeKind.Local), 83, "Title822" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 4, 1, 3, 28, DateTimeKind.Local), 87, "Title545" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 15, 16, 57, 666, DateTimeKind.Local), 81, "Title655" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 12, 57, 4, 99, DateTimeKind.Local), 86, "Title393" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 10, 46, 82, DateTimeKind.Local), 81, "Title533" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 0, 22, 33, 411, DateTimeKind.Local), 90, "Title717" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 15, 51, 0, 732, DateTimeKind.Local), 82, "Title853" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 5, 51, 45, 863, DateTimeKind.Local), 83, "Title715" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 8, 45, 9, 253, DateTimeKind.Local), 90, "Title312" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "ea:49:e1:5c:4b:20", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "24:32:49:71:87:f0", "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "4e:ac:84:13:b9:28", 79 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "3a:61:3d:99:e4:ca", "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "36:f7:51:0f:cd:a8", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "eb:e4:89:20:2a:93", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "28:11:5b:a1:69:aa", 79, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "70:26:22:e9:e3:86", 72, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "8e:a2:3a:8f:9e:70", 76, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "ab:8e:28:d4:9e:b8", 76, "Linux" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme130" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme768" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme839" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme425" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme600" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme134" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme239" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme544" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme411" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme537" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "df4c167f-7d0e-43c3-a0ba-45da6a53a13d", null, new DateTime(2018, 8, 9, 6, 18, 9, 850, DateTimeKind.Local), "Norberto", "Jesse.Ullrich15@gmail.com", "Layla", true, 2, "Pagac" },
                    { "de7a7411-8815-49d4-999e-ce38ab1f73ed", null, new DateTime(2018, 8, 9, 11, 54, 5, 510, DateTimeKind.Local), "Gerda", "Demarco_Torphy@yahoo.com", "Princess", true, 1, "Roob" },
                    { "3691f844-d30a-4664-a038-8fabe1113996", null, new DateTime(2018, 8, 9, 7, 4, 18, 605, DateTimeKind.Local), "Jensen", "Felicity_Hackett47@hotmail.com", "Briana", true, 2, "Gorczany" },
                    { "7aaebdba-ff37-43f7-ab90-98245d4c123e", null, new DateTime(2018, 8, 8, 18, 56, 4, 623, DateTimeKind.Local), "Sidney", "Marvin_Nitzsche@yahoo.com", "Janet", true, 2, "Welch" },
                    { "b57a563a-c110-4737-9061-4b0e78d5cb96", null, new DateTime(2018, 8, 8, 19, 41, 46, 799, DateTimeKind.Local), "Malinda", "Kris_Bechtelar@hotmail.com", "Nicola", true, 1, "Rice" },
                    { "c9c58051-889f-473c-a99d-05b7ec31287b", null, new DateTime(2018, 8, 9, 3, 5, 51, 232, DateTimeKind.Local), "Kay", "Gretchen.Glover@yahoo.com", "Aurelio", true, 1, "Willms" },
                    { "fc301d1b-121f-4a9f-8810-15ce0b34cf91", null, new DateTime(2018, 8, 9, 3, 57, 47, 376, DateTimeKind.Local), "Alexandrine", "Esteban_Schroeder@hotmail.com", "Krystina", true, 1, "Parker" },
                    { "9c898d08-e70f-4352-b97e-3d03be59d0fb", null, new DateTime(2018, 8, 9, 11, 12, 59, 767, DateTimeKind.Local), "Eldon", "Gennaro_Lindgren77@yahoo.com", "Carmela", true, 1, "White" },
                    { "3df70d4c-67de-460c-9a23-fe81f55a5d4d", null, new DateTime(2018, 8, 9, 7, 23, 34, 680, DateTimeKind.Local), "Candace", "Joey.Hudson@yahoo.com", "Antonietta", true, 1, "Mante" },
                    { "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", null, new DateTime(2018, 8, 9, 4, 5, 11, 538, DateTimeKind.Local), "Santino", "Antonina_Prosacco76@gmail.com", "Conrad", true, 2, "Hilll" }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c898d08-e70f-4352-b97e-3d03be59d0fb", "atque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b57a563a-c110-4737-9061-4b0e78d5cb96", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", "enim" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "de7a7411-8815-49d4-999e-ce38ab1f73ed", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3691f844-d30a-4664-a038-8fabe1113996", "error" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c898d08-e70f-4352-b97e-3d03be59d0fb", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7aaebdba-ff37-43f7-ab90-98245d4c123e", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7aaebdba-ff37-43f7-ab90-98245d4c123e", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c898d08-e70f-4352-b97e-3d03be59d0fb", "quidem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3691f844-d30a-4664-a038-8fabe1113996", "ut" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 49, 53, 21, DateTimeKind.Local), "Optio consequatur et qui vitae rerum sunt nemo consequatur itaque.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 21, 23, 1, 272, DateTimeKind.Local), "Eum nihil et.", "de7a7411-8815-49d4-999e-ce38ab1f73ed" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 18, 14, 2, 447, DateTimeKind.Local), "Sint ut nam occaecati doloremque molestiae soluta sed beatae.", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 12, 4, 32, 575, DateTimeKind.Local), "Modi quam veritatis.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 22, 51, 39, 728, DateTimeKind.Local), "Nihil voluptas at labore qui dolorem.", "fc301d1b-121f-4a9f-8810-15ce0b34cf91" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 5, 34, 272, DateTimeKind.Local), "Voluptatem facere quia molestiae non repellendus impedit odit.", "df4c167f-7d0e-43c3-a0ba-45da6a53a13d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 6, 50, 0, 544, DateTimeKind.Local), "Quo accusantium ea occaecati aut nisi.", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 5, 29, 4, 754, DateTimeKind.Local), "Eos delectus nesciunt eos doloribus magni nisi maiores soluta vel.", "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 0, 15, 34, 882, DateTimeKind.Local), "Est non commodi officiis ut.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 26, 39, 262, DateTimeKind.Local), "Ipsam quo consectetur autem est soluta commodi.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 9, 3, 51, 40, 70, DateTimeKind.Local), "Quod maiores ut minus quia ipsum velit consequuntur omnis.", "df4c167f-7d0e-43c3-a0ba-45da6a53a13d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 9, 0, 546, DateTimeKind.Local), "Deserunt et eius a sit sed et.", "c9c58051-889f-473c-a99d-05b7ec31287b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 8, 23, 26, 50, 126, DateTimeKind.Local), "Laborum occaecati qui qui aut.", "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 9, 7, 10, 39, 350, DateTimeKind.Local), "Vel facere veritatis repellendus molestias ipsa perferendis optio.", "9c898d08-e70f-4352-b97e-3d03be59d0fb", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 9, 13, 17, 29, 265, DateTimeKind.Local), "Quisquam esse consequatur occaecati consequatur voluptatibus temporibus reprehenderit.", "c9c58051-889f-473c-a99d-05b7ec31287b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 9, 6, 12, 14, 686, DateTimeKind.Local), "Tempore sequi odio suscipit animi eaque at officiis.", "3691f844-d30a-4664-a038-8fabe1113996", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 8, 17, 57, 2, 574, DateTimeKind.Local), "Qui itaque eveniet quibusdam dolores suscipit pariatur debitis.", "9c898d08-e70f-4352-b97e-3d03be59d0fb", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 8, 20, 50, 58, 765, DateTimeKind.Local), "Asperiores a voluptas magnam culpa velit tempora eum.", "9c898d08-e70f-4352-b97e-3d03be59d0fb", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 9, 5, 37, 15, 518, DateTimeKind.Local), "Ut repudiandae assumenda ducimus hic sint quis enim nesciunt.", "df4c167f-7d0e-43c3-a0ba-45da6a53a13d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 8, 19, 58, 14, 465, DateTimeKind.Local), "Impedit et earum dolor eos et vero.", "df4c167f-7d0e-43c3-a0ba-45da6a53a13d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "de7a7411-8815-49d4-999e-ce38ab1f73ed" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 1, "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "c9c58051-889f-473c-a99d-05b7ec31287b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: "3691f844-d30a-4664-a038-8fabe1113996");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 19, 44, 8, 764, DateTimeKind.Local), 19, "Officiis dicta quisquam minus blanditiis est neque magni rerum est.", "c9c58051-889f-473c-a99d-05b7ec31287b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 13, 8, 9, 229, DateTimeKind.Local), 20, "Eos tempore accusantium nostrum veritatis impedit nisi excepturi et.", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 14, 34, 779, DateTimeKind.Local), 17, "Architecto cupiditate qui aut neque.", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 1, 22, 2, 212, DateTimeKind.Local), 18, "Et harum nostrum ipsum perspiciatis iusto.", "c9c58051-889f-473c-a99d-05b7ec31287b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 18, 4, 30, 750, DateTimeKind.Local), "Sed consectetur illo dolorem.", "7aaebdba-ff37-43f7-ab90-98245d4c123e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 2, 7, 43, 86, DateTimeKind.Local), 13, "Error ea eius perspiciatis facere quas iusto dicta id quod.", "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 10, 38, 139, DateTimeKind.Local), 18, "Neque facilis sit reprehenderit repellat saepe dolorem voluptates nulla.", "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 7, 37, 36, 397, DateTimeKind.Local), 13, "Ratione voluptatem optio ipsum et quod.", "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 21, 30, 59, 130, DateTimeKind.Local), 19, "Aut debitis temporibus minus blanditiis.", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 7, 36, 20, 350, DateTimeKind.Local), 16, "Accusantium nihil accusantium.", "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(802) 968-5528", "de7a7411-8815-49d4-999e-ce38ab1f73ed", "Voluptas pariatur et sit et id quam et accusantium nemo. Cumque et in perspiciatis. Similique eum eligendi neque est ducimus.", "Cade_Maggio26@gmail.com", "Company863", 66, "http://geovany.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-736-969-1247", "7aaebdba-ff37-43f7-ab90-98245d4c123e", "Quia corporis eos delectus pariatur consequuntur culpa amet.", "Marquise72@gmail.com", "Company27", 67, "http://mathias.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(827) 501-5177", "b57a563a-c110-4737-9061-4b0e78d5cb96", "Inventore eum maiores dicta debitis. Fugit fugit voluptates veritatis sint doloremque ut amet tempora reprehenderit. Sint optio aliquid voluptatem fugit.", "Janie_Reynolds57@hotmail.com", "Company402", 67, "http://adeline.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "487-818-2179 x288", "c9c58051-889f-473c-a99d-05b7ec31287b", "Aut repellendus accusantium enim. Earum repudiandae laboriosam aliquid est dolorem minus molestias eligendi aut. Iure quam est debitis culpa voluptate numquam provident blanditiis. Recusandae cumque nam.", "General94@gmail.com", "Company733", 63, "https://lucinda.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(631) 964-6184 x006", "3df70d4c-67de-460c-9a23-fe81f55a5d4d", "Dolores at qui aut numquam tempore dolorem. Officia voluptas explicabo ex rerum sit inventore.", "Ethel.Cummerata@yahoo.com", "Company238", 64, "https://janis.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-838-385-1474 x2774", "3691f844-d30a-4664-a038-8fabe1113996", "Animi dolores porro sapiente omnis ut omnis expedita et. Minima corporis natus in similique quia voluptatem. Distinctio molestiae perferendis.", "Edna42@hotmail.com", "Company439", 65, "http://alisa.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(835) 493-3632 x389", "de7a7411-8815-49d4-999e-ce38ab1f73ed", "Ab est animi voluptas quia qui enim facilis quis earum.", "Carlee30@yahoo.com", "Company345", "http://salvador.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "439.220.1689", "fc301d1b-121f-4a9f-8810-15ce0b34cf91", "", "Hoyt.Jerde57@gmail.com", "Company937", 66, "http://royal.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-898-976-1044", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", "Voluptas esse ut omnis excepturi iste.", "Johnson_Okuneva77@yahoo.com", "Company100", 63, "https://isaac.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "683-311-8039 x616", "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", "Amet et est voluptas. Commodi blanditiis earum qui a. Ut aliquid nobis sit exercitationem dicta ab. Soluta quia blanditiis sit tempora animi distinctio rem nam corporis.", "Nicholas60@gmail.com", "Company530", 68, "https://wallace.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 15, 52, 10, 242, DateTimeKind.Local), 41, "Est at aut autem sit mollitia.", "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 11, 19, 26, 649, DateTimeKind.Local), 42, "Est molestiae sed provident quod quas.", "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 4, 15, 42, 644, DateTimeKind.Local), 50, "Et est nobis autem.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 7, 11, 39, 585, DateTimeKind.Local), "Eum ducimus voluptatibus et qui.", "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 22, 35, 48, 546, DateTimeKind.Local), 42, "Reiciendis ut assumenda consequatur aut quidem quibusdam.", "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 13, 17, 34, 763, DateTimeKind.Local), 43, "Illo aut molestiae corrupti dolor explicabo qui repellat.", "b57a563a-c110-4737-9061-4b0e78d5cb96" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 18, 2, 51, 806, DateTimeKind.Local), 46, "Et porro illo harum blanditiis architecto aut aut omnis at.", "3691f844-d30a-4664-a038-8fabe1113996" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 15, 38, 25, 3, DateTimeKind.Local), 43, "Quia cumque sunt rerum deserunt distinctio.", "7aaebdba-ff37-43f7-ab90-98245d4c123e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 8, 22, 53, 52, 444, DateTimeKind.Local), 41, "Voluptatem dolores rem ea voluptas.", "9c898d08-e70f-4352-b97e-3d03be59d0fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 15, 43, 48, 219, DateTimeKind.Local), "Quam qui sunt quae alias nisi impedit repudiandae.", "3df70d4c-67de-460c-9a23-fe81f55a5d4d" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "3df70d4c-67de-460c-9a23-fe81f55a5d4d", 71 },
                    { "df4c167f-7d0e-43c3-a0ba-45da6a53a13d", 74 },
                    { "9c898d08-e70f-4352-b97e-3d03be59d0fb", 71 },
                    { "b57a563a-c110-4737-9061-4b0e78d5cb96", 75 },
                    { "c9c58051-889f-473c-a99d-05b7ec31287b", 78 },
                    { "7aaebdba-ff37-43f7-ab90-98245d4c123e", 76 },
                    { "fc301d1b-121f-4a9f-8810-15ce0b34cf91", 72 },
                    { "3691f844-d30a-4664-a038-8fabe1113996", 77 },
                    { "de7a7411-8815-49d4-999e-ce38ab1f73ed", 75 },
                    { "d73c2d4c-a95e-4c33-b12a-2c08dd7d99b8", 73 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_FeedbackId",
                table: "Responses",
                column: "FeedbackId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Feedbacks_FeedbackId",
                table: "Responses",
                column: "FeedbackId",
                principalTable: "Feedbacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
