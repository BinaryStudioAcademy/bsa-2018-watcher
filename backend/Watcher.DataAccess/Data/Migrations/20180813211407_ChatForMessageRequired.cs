using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChatForMessageRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

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
                name: "ChatId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Source3", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Source3", 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Common1", "Source3", 59, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Threshold", "Type" },
                values: new object[] { "Source1", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded3", "Common1", "Source1", 89 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", "Common3", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common2", 40, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Source2", 45, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Source1", 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded1", "Source3", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 23, 17, 693, DateTimeKind.Local), 90, "Title11" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 14, 24, 185, DateTimeKind.Local), 90, "Title765" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 19, 1, 717, DateTimeKind.Local), 86, "Title982" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 38, 16, 604, DateTimeKind.Local), 83, "Title612" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 42, 11, 172, DateTimeKind.Local), 89, "Title547" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 6, 30, 3, 737, DateTimeKind.Local), 89, "Title958" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 49, 56, 577, DateTimeKind.Local), 90, "Title850" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 21, 37, 392, DateTimeKind.Local), "Title309" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 4, 20, 765, DateTimeKind.Local), 89, "Title572" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 2, 56, 464, DateTimeKind.Local), 88, "Title422" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "06:33:a4:c4:77:5d", 75, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e2:96:8b:82:eb:17", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "bc:c0:26:27:de:9f", 76, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "b4:a0:d2:d4:8e:b5", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "3d:08:45:33:de:f3", 77, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "22:21:f2:83:db:b1", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "de:ca:4c:0c:b5:41", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "a1:41:0f:d7:8a:96", 75, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "9f:e6:45:e2:d1:04", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "22:65:05:bd:ac:0e", 76 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme325" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme521" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme903" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme613" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme130" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme811" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme668" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme425" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme374" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme417" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", null, new DateTime(2018, 8, 13, 1, 19, 24, 624, DateTimeKind.Local), "Madge", "Selmer22@hotmail.com", "Malvina", true, "Runolfsdottir", null, 2 },
                    { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", null, new DateTime(2018, 8, 13, 10, 5, 14, 586, DateTimeKind.Local), "Letitia", "Kenyatta73@gmail.com", "Carrie", true, "Stokes", null, 2 },
                    { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", null, new DateTime(2018, 8, 14, 0, 10, 21, 526, DateTimeKind.Local), "Roberta", "Krystina_Gleichner@gmail.com", "Vinnie", true, "Kemmer", null, 1 },
                    { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", null, new DateTime(2018, 8, 13, 12, 2, 46, 326, DateTimeKind.Local), "Stacey", "Fidel_Bergnaum@gmail.com", "Chasity", true, "Stracke", null, 1 },
                    { "309927ed-5909-456b-96cb-5536bc2574f7", null, new DateTime(2018, 8, 13, 14, 33, 59, 895, DateTimeKind.Local), "Heaven", "Karley.Schaefer75@gmail.com", "Mac", true, "Bartoletti", null, 2 },
                    { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", null, new DateTime(2018, 8, 13, 9, 40, 2, 634, DateTimeKind.Local), "Emie", "Darien.Waters@gmail.com", "Althea", true, "Stanton", null, 2 },
                    { "b5a291b2-0388-4889-a80d-83ff74c8a91e", null, new DateTime(2018, 8, 13, 12, 10, 8, 424, DateTimeKind.Local), "Nikko", "Elijah_Willms@yahoo.com", "Cali", true, "Emmerich", null, 2 },
                    { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", null, new DateTime(2018, 8, 13, 5, 5, 58, 89, DateTimeKind.Local), "Judd", "Tommie_Armstrong@gmail.com", "Gwendolyn", true, "Farrell", null, 1 },
                    { "6932c7c0-3ad8-4c5f-8724-81e11290e682", null, new DateTime(2018, 8, 13, 21, 17, 21, 45, DateTimeKind.Local), "Lawrence", "Brian.Ankunding@yahoo.com", "Erin", true, "Cartwright", null, 1 },
                    { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", null, new DateTime(2018, 8, 13, 18, 20, 1, 843, DateTimeKind.Local), "Stephania", "Jimmie_Schultz@gmail.com", "Allan", true, "Goodwin", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6932c7c0-3ad8-4c5f-8724-81e11290e682", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "atque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "quidem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "minus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b5a291b2-0388-4889-a80d-83ff74c8a91e", "tempora" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 13, 23, 2, 89, DateTimeKind.Local), "Adipisci nihil beatae rerum ut fuga.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 52, 33, 814, DateTimeKind.Local), "Sed asperiores iusto.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 19, 10, 4, 334, DateTimeKind.Local), "Quia ea nihil blanditiis cumque reprehenderit eum laudantium.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 58, 10, 687, DateTimeKind.Local), "Dolor distinctio voluptatibus voluptas possimus asperiores.", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 33, 8, 116, DateTimeKind.Local), "Voluptate omnis facere error.", "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 0, 50, 6, 626, DateTimeKind.Local), "Modi rerum recusandae aut provident.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 29, 51, 506, DateTimeKind.Local), "Cumque magnam distinctio unde.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 5, 15, 33, 589, DateTimeKind.Local), "Et saepe fugiat nulla.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 31, 5, 865, DateTimeKind.Local), "Dolor alias corporis suscipit labore.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 38, 51, 840, DateTimeKind.Local), "Eos nisi tempora illo neque culpa minima.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 13, 8, 41, 4, 172, DateTimeKind.Local), "Quos ullam saepe mollitia.", "b5a291b2-0388-4889-a80d-83ff74c8a91e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 13, 0, 22, 8, 584, DateTimeKind.Local), "Reprehenderit est id aut et aperiam facere suscipit non dicta.", "6932c7c0-3ad8-4c5f-8724-81e11290e682", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 13, 7, 17, 43, 455, DateTimeKind.Local), "Libero porro assumenda ipsa aut veniam quia qui voluptatem.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 13, 4, 9, 39, 124, DateTimeKind.Local), "Quam voluptatem voluptatem eius nihil.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 7, 19, 35, 824, DateTimeKind.Local), "Fugiat voluptatem qui eaque.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 19, 1, 16, 414, DateTimeKind.Local), "Inventore non nemo debitis tempore at.", "95e7c831-ac94-4b80-a1e3-e3cba23b475c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 13, 0, 16, 18, 531, DateTimeKind.Local), "Numquam aut officiis aut odit qui dolorem est voluptas.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 13, 4, 30, 42, 239, DateTimeKind.Local), "Non expedita necessitatibus eos enim ipsam neque omnis.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 59, 15, 603, DateTimeKind.Local), "Voluptatum consequatur fugit et rerum eum.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 13, 8, 1, 31, 46, DateTimeKind.Local), "Non voluptatem aut eum aut perspiciatis.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "309927ed-5909-456b-96cb-5536bc2574f7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "95e7c831-ac94-4b80-a1e3-e3cba23b475c");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 3, "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 2, 41, 53, 79, DateTimeKind.Local), 16, "Voluptas quae nihil qui omnis accusantium.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 7, 22, 812, DateTimeKind.Local), 19, "Est ullam impedit id ut dignissimos.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 14, 18, 57, 975, DateTimeKind.Local), "Deserunt id eum ea id.", "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 10, 16, 15, 285, DateTimeKind.Local), 18, "Libero mollitia debitis magni tenetur officiis.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 52, 44, 192, DateTimeKind.Local), "Quam molestiae nihil culpa.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 18, 47, 531, DateTimeKind.Local), 18, "Facere est quaerat dolorem iste sint deleniti vero odit.", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 49, 2, 3, DateTimeKind.Local), 12, "Commodi voluptas quas ut.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 25, 37, 202, DateTimeKind.Local), 18, "Qui nobis ipsam est est iusto in dolorem nesciunt.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 58, 23, 280, DateTimeKind.Local), 20, "Voluptates cupiditate eius nulla ipsa a et.", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 24, 50, 603, DateTimeKind.Local), 17, "Itaque architecto inventore.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-918-475-4409", "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", "Similique cupiditate sunt culpa. Sint autem architecto totam eum omnis optio quia enim quas.", "Nils_VonRueden@gmail.com", "Company161", 63, "http://sedrick.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "356.837.2887 x34885", "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", "Et totam beatae iusto voluptatem enim. Est possimus similique est dolorem suscipit aut.", "Jared_Zieme24@hotmail.com", "Company802", "https://clinton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "312.638.1775 x95996", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "", "Clementine_Zieme26@yahoo.com", "Company93", 67, "http://elza.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-891-464-1447 x59985", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "Quia voluptatem modi nisi omnis excepturi omnis corrupti ipsam corporis.", "Trey_Sawayn@hotmail.com", "Company551", 66, "http://humberto.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(780) 266-1229 x145", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", "Placeat amet optio. Dolor aliquid repudiandae dicta assumenda. Qui quia eveniet enim.", "Filomena.Sawayn98@yahoo.com", "Company344", 67, "http://genoveva.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "489.571.8576 x030", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", "Aut officiis beatae rem numquam sapiente voluptates voluptas quia rerum. Repellat consequatur odit qui officiis expedita asperiores omnis facilis. Eveniet adipisci dolorem accusantium voluptatem id natus rerum. Eius tempore omnis eligendi ut et maxime neque.", "Leilani_Parker@hotmail.com", "Company825", 67, "https://lou.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "412-426-2412 x335", "95e7c831-ac94-4b80-a1e3-e3cba23b475c", "Eius cum similique officia. Quos voluptatem neque. Et ex quia rerum pariatur.", "Antonina50@yahoo.com", "Company359", 64, "http://everett.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-806-594-7988 x7692", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "", "Stanley.Hegmann@gmail.com", "Company215", 67, "http://cielo.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "446-372-7293 x7086", "309927ed-5909-456b-96cb-5536bc2574f7", "Blanditiis consequatur animi amet nihil est. Harum consequuntur quia aut voluptatum debitis.", "Lavada.Pagac24@yahoo.com", "Company849", 67, "http://odessa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "782-579-4679 x1695", "6932c7c0-3ad8-4c5f-8724-81e11290e682", "Quas et eos exercitationem in excepturi porro vitae sed. Consequuntur eum aut ea quia perspiciatis quibusdam. Alias aperiam et.", "Katrina.Muller@yahoo.com", "Company635", 65, "http://anastasia.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 7, 45, 43, 909, DateTimeKind.Local), 48, "Nostrum voluptas veritatis molestias suscipit officia earum ea dolorem.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 10, 16, 51, 636, DateTimeKind.Local), 48, "Nobis eum recusandae odit recusandae.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 36, 27, 58, DateTimeKind.Local), 41, "Ducimus aspernatur reprehenderit.", "914d28ca-74fd-4004-8a3d-d2ff3640b6ad" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 17, 41, 38, 773, DateTimeKind.Local), 48, "Distinctio officia temporibus molestiae eaque et quod tempora.", "b5a291b2-0388-4889-a80d-83ff74c8a91e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 11, 12, 37, 997, DateTimeKind.Local), 43, "Debitis sequi dicta maxime magni architecto.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 1, 2, 7, 115, DateTimeKind.Local), 41, "Ut non impedit quasi labore ipsam.", "8ba19cd3-676f-4085-a76e-f9cbce0b0e05" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 4, 55, 21, 682, DateTimeKind.Local), "Molestiae impedit molestias aspernatur architecto.", "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 3, 22, 33, 383, DateTimeKind.Local), 49, "Impedit fugiat ut.", "6932c7c0-3ad8-4c5f-8724-81e11290e682" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 18, 59, 19, 758, DateTimeKind.Local), 43, "Commodi aliquid voluptatem et omnis autem nihil amet et quaerat.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 8, 43, 43, 756, DateTimeKind.Local), 47, "Quaerat nesciunt est dignissimos totam ipsum.", "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", 72 },
                    { "309927ed-5909-456b-96cb-5536bc2574f7", 71 },
                    { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", 73 },
                    { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", 71 },
                    { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", 77 },
                    { "b5a291b2-0388-4889-a80d-83ff74c8a91e", 79 },
                    { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", 79 },
                    { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", 71 },
                    { "6932c7c0-3ad8-4c5f-8724-81e11290e682", 78 },
                    { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", 75 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Chats_ChatId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "309927ed-5909-456b-96cb-5536bc2574f7", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6932c7c0-3ad8-4c5f-8724-81e11290e682", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ba19cd3-676f-4085-a76e-f9cbce0b0e05", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "914d28ca-74fd-4004-8a3d-d2ff3640b6ad", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "95e7c831-ac94-4b80-a1e3-e3cba23b475c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b5a291b2-0388-4889-a80d-83ff74c8a91e", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e006ee95-72b3-4833-b5e3-2ece6aaf41d8", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "309927ed-5909-456b-96cb-5536bc2574f7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6932c7c0-3ad8-4c5f-8724-81e11290e682");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ba19cd3-676f-4085-a76e-f9cbce0b0e05");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "914d28ca-74fd-4004-8a3d-d2ff3640b6ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "95e7c831-ac94-4b80-a1e3-e3cba23b475c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b5a291b2-0388-4889-a80d-83ff74c8a91e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bbaa7dbf-dca5-4a9c-aea7-f01a3a8c6441");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d2e9b146-bc8a-46d9-bfa9-57834c40ea8b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e006ee95-72b3-4833-b5e3-2ece6aaf41d8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e89f95c8-f4d9-4ad0-8d95-18bb4e9c5550");

            migrationBuilder.AlterColumn<int>(
                name: "ChatId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", "Source2", 40, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 97, "Source2", 62, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common3", "Source1", 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Threshold", "Type" },
                values: new object[] { "Source3", 78, 0 });

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
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", "Common1", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common3", 47, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Source1", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Source3", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Source2", 92, 1 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 24, 41, 513, DateTimeKind.Local), "Title713" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "69:aa:13:38:70:91", 74, "Windows" });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e8:32:37:65:ff:0d", 79 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "d7:36:1c:12:03:7d", 73, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "b7:d9:17:14:e4:4a", 75 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e5:51:e3:82:13:28", 74, "Windows" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme260" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme603" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme115" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme882" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 12, 1, 30, 58, 839, DateTimeKind.Local), "In delectus eos quas consequuntur rerum.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 3, 58, 44, 421, DateTimeKind.Local), "Odio hic ut commodi quia fugit nihil.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 11, 18, 25, 39, 229, DateTimeKind.Local), "Quasi adipisci illum vitae repellat iure temporibus molestiae qui quia.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 17, 6, 10, 925, DateTimeKind.Local), "Enim sint consectetur ut quae culpa consequatur.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 12, 8, 7, 721, DateTimeKind.Local), "Ut blanditiis amet delectus ea voluptate quia voluptatibus maxime non.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "34a73032-25cd-4e18-8078-ec7e1280ddfe");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 0, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 42, 13, 203, DateTimeKind.Local), "Inventore sit aut blanditiis earum sunt asperiores dolorem.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 19, 16, 907, DateTimeKind.Local), 19, "Laboriosam aut placeat sunt nobis.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 23, 5, 77, DateTimeKind.Local), "Quod maiores molestiae fugiat sint dolore et doloribus nesciunt quasi.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(218) 668-9637 x56037", "8af174fd-45ab-44b1-b756-61b08b4e54fb", "Hic officiis neque incidunt atque dolore velit qui ut. Ipsum quod velit est quia. Consequatur provident vitae aliquam corporis sed voluptate sapiente aut. Quis expedita veritatis alias reprehenderit et sit ullam eaque.", "Mitchell7@gmail.com", "Company190", "https://tressa.net" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 51, 41, 37, DateTimeKind.Local), "Provident soluta occaecati cumque.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

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
                name: "FK_Messages_Chats_ChatId",
                table: "Messages",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
