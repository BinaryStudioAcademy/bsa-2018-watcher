using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedUserSecondNameToLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSettings_Users_UserId",
                table: "NotificationSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_CreatedByUserId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses");

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

            migrationBuilder.RenameColumn(
                name: "SecondName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "Organizations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChatId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Common2", "Source1", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Common1", "Source2", 59, 2 });

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
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Source2", 35, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded1", "Common3", 79, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common1", "Source1", 66, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", 82, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "Common3", "Source3", 81, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ShowCommon", "Threshold", "Type" },
                values: new object[] { "Common1", 23, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", "Common3", 9, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 34, 13, 275, DateTimeKind.Local), "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 0, 1, 83, DateTimeKind.Local), "Title360" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 10, 18, 48, 8, 389, DateTimeKind.Local), 86, "Title379" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 14, 4, 857, DateTimeKind.Local), 83, "Title8" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 10, 18, 53, 34, 900, DateTimeKind.Local), "Title735" });

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
                columns: new[] { "Address", "Platform" },
                values: new object[] { "34:4e:34:a8:e6:ee", "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f9:c5:2f:11:f0:e3", 72 });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "f8:79:8c:38:47:1b", 78, "Windows" });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "ce:e6:4f:c2:89:45", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "49:1e:af:6d:62:56", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "0c:1e:ca:35:eb:ac", 74, "Linux" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme82");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme621" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme880" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme762" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme981" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme931");

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
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4c6b1005-0ade-482b-989a-53a21c60ec1b", "qui" });

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
                column: "CreatedById",
                value: "eb854e5a-dd61-4063-b49e-e95e570488b5");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 11, 3, 16, 41, 589, DateTimeKind.Local), "Ullam consequatur voluptatum dicta sed vel a molestias numquam.", "eb854e5a-dd61-4063-b49e-e95e570488b5", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 11, 0, 51, 21, 26, DateTimeKind.Local), "Itaque et ab in suscipit molestiae earum sint.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 11, 12, 10, 52, 320, DateTimeKind.Local), "Dolorem eaque libero sit quod ea qui nesciunt quia eligendi.", "e630c5ba-9e5d-4767-871a-c57544ff7092" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 15, 31, 36, 152, DateTimeKind.Local), "Incidunt quo aut enim asperiores laudantium.", "eb854e5a-dd61-4063-b49e-e95e570488b5" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 15, 2, 43, 691, DateTimeKind.Local), "Reiciendis impedit delectus.", "493926fd-7139-4f2e-9ba3-ff8d886bd793", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "493926fd-7139-4f2e-9ba3-ff8d886bd793");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "067d80ea-b8ae-4b02-b94c-10408ba303f8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 4, "493926fd-7139-4f2e-9ba3-ff8d886bd793" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "d701dc50-7274-43b3-a28c-c0f6c0cbcecf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "eb854e5a-dd61-4063-b49e-e95e570488b5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 17, 35, 57, 948, DateTimeKind.Local), 17, "Illum qui fugiat dolores est dolores adipisci aliquid.", "c4c22b94-a1fc-43ad-99a6-5b346ebc4e64" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 17, 40, 46, 358, DateTimeKind.Local), "Quam qui aperiam quaerat enim rem eligendi odit.", "4c6b1005-0ade-482b-989a-53a21c60ec1b" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-886-477-6004 x051", "e630c5ba-9e5d-4767-871a-c57544ff7092", "Tempore tempora quam doloremque aut rerum. Deleniti nulla est nam excepturi corporis fugit. Possimus magnam soluta assumenda omnis at.", "Annabell90@gmail.com", "Company751", 62, "https://josiah.info" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "988.534.7149 x842", "493926fd-7139-4f2e-9ba3-ff8d886bd793", "Fugit ducimus velit consectetur consequatur id.", "Minnie.Wolf@yahoo.com", "Company351", "https://marquise.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "536.842.5705 x73353", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea", "Dolores laborum at adipisci consectetur esse. Rem atque sequi quos voluptas mollitia recusandae qui vel reprehenderit. Magnam vitae est maxime sed sit maiores quia rerum modi.", "Velma_Luettgen36@hotmail.com", "Company458", "https://abraham.info" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 0, 3, 314, DateTimeKind.Local), "Esse voluptatibus illum sit nam et.", "72c46d3f-7f13-42d4-b700-7d7ec31b68ea" });

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
                name: "FK_Chats_Users_CreatedById",
                table: "Chats",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications",
                column: "NotificationSettingId",
                principalTable: "NotificationSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSettings_Users_UserId",
                table: "NotificationSettings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Users_CreatedByUserId",
                table: "Organizations",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSettings_Users_UserId",
                table: "NotificationSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Users_CreatedByUserId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses");

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

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "SecondName");

            migrationBuilder.AlterColumn<int>(
                name: "ThemeId",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ChatId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "Common3", "Source2", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common2", "Source1", 60, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common1", "Source2", 33, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Source3", 14, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", "Common1", 39, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common2", "Source2", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common1", "Source2", 36, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ShowCommon", "Threshold", "Type" },
                values: new object[] { "Common2", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Common1", 71, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 28, 55, 733, DateTimeKind.Local), "Title719" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 20, 47, 40, 957, DateTimeKind.Local), "Title509" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 9, 9, 57, 45, 200, DateTimeKind.Local), "Title392" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "98:24:72:a9:73:6e", 80, "Linux" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "1f:a3:9f:14:cd:98", 77, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "1b:79:4e:2e:aa:ec", 72, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "dd:67:97:6e:1a:67", 74, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "cb:4a:81:aa:2b:be", 72 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "76:34:89:cf:cf:d9", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "65:66:04:f5:91:67", 77 });

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
                column: "Name",
                value: "Theme138");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme49" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme863" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme430" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme850" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme118" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme38" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme323");

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
                column: "CreatedById",
                value: "4ff7c2a4-f212-42f4-9b57-4362f334992b");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 9, 3, 52, 48, 98, DateTimeKind.Local), "Odio corporis sit aut.", "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 9, 1, 42, 34, 96, DateTimeKind.Local), "Ea qui ex dicta.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 9, 19, 36, 5, 57, DateTimeKind.Local), "Animi porro sint ratione cumque vitae pariatur omnis.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 9, 19, 52, 21, 854, DateTimeKind.Local), "Labore nihil tempore.", "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 9, 7, 49, 40, 584, DateTimeKind.Local), "Alias ut eligendi nam vero quos optio earum magnam ex.", "b752f3c0-ed83-4394-b041-bf5ec10bde52", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 9, 7, 15, 52, 192, DateTimeKind.Local), "Reprehenderit animi ea aut nulla delectus facilis maxime pariatur est.", "d459eb30-de1a-49ef-9cfe-175147483ea5", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "198a12e6-ef20-4a43-ac12-39187e7efc52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "198a12e6-ef20-4a43-ac12-39187e7efc52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c");

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
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 0, "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "b752f3c0-ed83-4394-b041-bf5ec10bde52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 1, "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "f7baf1d1-39e0-494f-90d6-5f5787f1b72f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 11, 10, 716, DateTimeKind.Local), "Reiciendis velit et accusantium voluptatem unde quas cupiditate perspiciatis.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 14, 34, 46, 359, DateTimeKind.Local), 15, "Qui eos qui odit aut.", "2c9f98fb-92dc-48e5-8cd7-fd8a19c43ab0" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 3, 38, 19, 262, DateTimeKind.Local), "Aperiam fugiat ut sunt repudiandae inventore ab est sed beatae.", "73d76bb0-05c1-4fbb-ba1f-6d53f7dd829c" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(621) 361-5680 x43115", "f7baf1d1-39e0-494f-90d6-5f5787f1b72f", "", "Manley7@hotmail.com", "Company590", 64, "https://clinton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "398.240.6501", "b752f3c0-ed83-4394-b041-bf5ec10bde52", "Debitis recusandae sed voluptatem enim in. Ducimus perferendis fuga ipsum est velit aut.", "Jazmyn.Schultz@hotmail.com", "Company590", "https://luella.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(243) 910-1956 x3921", "198a12e6-ef20-4a43-ac12-39187e7efc52", "", "Karley_Bernhard@hotmail.com", "Company758", "https://josefa.name" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 18, 2, 4, 904, DateTimeKind.Local), "Officiis ut voluptas dolores expedita perspiciatis vel ut.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 18, 54, 32, 285, DateTimeKind.Local), 49, "Natus ad voluptatem blanditiis inventore ut fugiat.", "b547163a-781c-44d5-a498-4b8430b5cc94" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 9, 17, 37, 13, 171, DateTimeKind.Local), 43, "Maiores corporis consequuntur ab ex est corporis.", "783b295c-e5ba-4f3f-822c-ea2956b9edab" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Users_UserId",
                table: "Feedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications",
                column: "NotificationSettingId",
                principalTable: "NotificationSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSettings_Users_UserId",
                table: "NotificationSettings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Users_CreatedByUserId",
                table: "Organizations",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_Themes_ThemeId",
                table: "Organizations",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Users_UserId",
                table: "Responses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
