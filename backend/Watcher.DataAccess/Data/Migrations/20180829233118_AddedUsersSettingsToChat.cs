using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedUsersSettingsToChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "29a372ec-73b4-436a-b515-a3f17a5334a0", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "570fb7b2-30ac-46b7-98c2-5d171bafc042", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "57c67516-81b3-4916-a777-5acb7675826d", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7298ee98-e991-4c10-aaf4-60a9d191f818", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29a372ec-73b4-436a-b515-a3f17a5334a0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "570fb7b2-30ac-46b7-98c2-5d171bafc042");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "57c67516-81b3-4916-a777-5acb7675826d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7298ee98-e991-4c10-aaf4-60a9d191f818");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "98b7a347-498b-4edb-be18-c736b985bd08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ee541c3a-6c64-4dfe-b599-4f6886cb3837");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "NotificationSettings",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 92, "Common2", "Source1", 14 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", "Common3", "Source1", 5, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", "Common1", 40, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Source1", 45, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", "Common3", "Source1", 89, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "Common3", "Source2", 87, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 92, "MostLoaded2", "Common3", 99 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Source2", 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", 55, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 18, 43, 47, 666, DateTimeKind.Local), 83, "Title736" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 34, 42, 444, DateTimeKind.Local), 88, "Title556" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 37, 28, 263, DateTimeKind.Local), 82, "Title987" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 53, 34, 805, DateTimeKind.Local), 84, "Title6" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 42, 57, 663, DateTimeKind.Local), 82, "Title715" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 51, 59, 538, DateTimeKind.Local), "Title7" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 54, 39, 272, DateTimeKind.Local), 88, "Title180" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 55, 21, 603, DateTimeKind.Local), 88, "Title752" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 22, 37, 85, DateTimeKind.Local), 88, "Title518" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 8, 47, 16, 861, DateTimeKind.Local), "Title982" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Title" },
                values: new object[] { "9c:db:13:e3:a8:a7", "Instance67" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ce:08:64:28:10:27", 76, "Linux", "Instance392" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f1:4a:97:71:fb:2d", 75, "Instance267" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "25:fe:7d:11:44:49", 71, "Windows", "Instance306" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "fb:1e:2c:03:22:ca", 79, "Instance348" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d9:e7:13:20:d4:51", 73, "Instance984" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2a:8a:6b:70:2e:cf", 76, "Linux", "Instance905" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "22:dc:ce:69:f5:d2", 72, "Instance890" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4b:a2:65:69:1a:3d", 80, "Linux", "Instance307" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "04:62:d0:dd:b0:70", 78, "Instance236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme504" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme329" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme976" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme940" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme430" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme452" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme61" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme424" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme377" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d4b1b17f-aa16-40be-bc50-e59759bc9cb7", null, new DateTime(2018, 8, 29, 21, 11, 4, 968, DateTimeKind.Local), "Bridie", "Maeve_Weber@gmail.com", null, "Broderick", true, "Brown", null, "https://s3.amazonaws.com/uifaces/faces/twitter/michaelcomiskey/128.jpg", 2 },
                    { "f3b4c548-be18-49c1-a2e7-e11f2355e621", null, new DateTime(2018, 8, 30, 1, 53, 10, 143, DateTimeKind.Local), "Khalid", "Brett35@gmail.com", null, "Pasquale", true, "Christiansen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/laasli/128.jpg", 2 },
                    { "6739075a-d110-47dd-aa10-e77085b38762", null, new DateTime(2018, 8, 29, 5, 1, 39, 960, DateTimeKind.Local), "Tia", "Jaren.Flatley@hotmail.com", null, "Rodrick", true, "Jakubowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/marklamb/128.jpg", 1 },
                    { "9b8f17ee-e708-4072-8404-f37c90801a6d", null, new DateTime(2018, 8, 29, 10, 27, 42, 48, DateTimeKind.Local), "Jettie", "Roman_Predovic83@hotmail.com", null, "Jamey", true, "Franecki", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dimaposnyy/128.jpg", 2 },
                    { "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", null, new DateTime(2018, 8, 29, 11, 27, 28, 697, DateTimeKind.Local), "Savanah", "Jillian_Dooley41@hotmail.com", null, "Summer", true, "Johnson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/romanbulah/128.jpg", 1 },
                    { "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", null, new DateTime(2018, 8, 29, 10, 17, 22, 511, DateTimeKind.Local), "Rigoberto", "Georgette.Kassulke@yahoo.com", null, "Monte", true, "Hills", null, "https://s3.amazonaws.com/uifaces/faces/twitter/souperphly/128.jpg", 2 },
                    { "c204f301-0b97-49fa-b5e4-4254848fa6e6", null, new DateTime(2018, 8, 29, 22, 28, 10, 398, DateTimeKind.Local), "Dameon", "Haskell19@yahoo.com", null, "Enrique", true, "Parker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/theonlyzeke/128.jpg", 1 },
                    { "6be48c54-e679-4ec1-9c83-c4fe60b63535", null, new DateTime(2018, 8, 29, 2, 58, 54, 411, DateTimeKind.Local), "Leanna", "Shane37@yahoo.com", null, "Akeem", true, "Jaskolski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/desastrozo/128.jpg", 2 },
                    { "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", null, new DateTime(2018, 8, 29, 18, 39, 15, 544, DateTimeKind.Local), "Janet", "Darion.Fahey@hotmail.com", null, "Danyka", true, "Deckow", null, "https://s3.amazonaws.com/uifaces/faces/twitter/beweinreich/128.jpg", 1 },
                    { "2ca00e2e-c335-4921-be38-be5f7edd679b", null, new DateTime(2018, 8, 30, 0, 2, 26, 538, DateTimeKind.Local), "Winnifred", "Kian.Goyette29@gmail.com", null, "Nickolas", true, "Lockman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/pierre_nel/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", "reiciendis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3b4c548-be18-49c1-a2e7-e11f2355e621", "officiis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2ca00e2e-c335-4921-be38-be5f7edd679b", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c204f301-0b97-49fa-b5e4-4254848fa6e6", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9b8f17ee-e708-4072-8404-f37c90801a6d", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6be48c54-e679-4ec1-9c83-c4fe60b63535", "asperiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3b4c548-be18-49c1-a2e7-e11f2355e621", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3b4c548-be18-49c1-a2e7-e11f2355e621", "eaque" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 30, 12, 236, DateTimeKind.Local), "A excepturi quam nam voluptatem enim dolor natus dolore at.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 30, 48, 445, DateTimeKind.Local), "Dolore fugiat excepturi asperiores possimus saepe accusantium eius quibusdam.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 40, 26, 941, DateTimeKind.Local), "Veniam non rerum.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 20, 51, 45, 933, DateTimeKind.Local), "Deleniti esse ut modi autem in molestiae molestias consequatur.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 4, 49, 9, 995, DateTimeKind.Local), "Culpa exercitationem excepturi inventore aut quia.", "6739075a-d110-47dd-aa10-e77085b38762" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 8, 38, 56, 674, DateTimeKind.Local), "Atque architecto impedit nesciunt ut expedita dolorum quod.", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 20, 31, 53, 602, DateTimeKind.Local), "Eius consequatur occaecati commodi saepe voluptatem blanditiis fugit quasi.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 7, 27, 43, 685, DateTimeKind.Local), "Ducimus consequatur sapiente laudantium sed modi facilis sint quibusdam.", "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 25, 0, 207, DateTimeKind.Local), "Laboriosam voluptatem veritatis voluptate quod nemo assumenda veritatis optio repudiandae.", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 20, 15, 41, 241, DateTimeKind.Local), "Ratione neque eos libero temporibus dolorem qui qui veniam.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 1, 26, 7, 27, DateTimeKind.Local), "Nobis sint sed.", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 29, 11, 28, 30, 568, DateTimeKind.Local), "Inventore ea eos ab.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 30, 1, 15, 9, 939, DateTimeKind.Local), "Et natus libero similique non sint necessitatibus non enim accusamus.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 29, 21, 59, 49, 113, DateTimeKind.Local), "Fuga quis exercitationem deserunt possimus.", "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 29, 18, 9, 47, 19, DateTimeKind.Local), "Voluptatem qui nobis iste cum placeat illum.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 29, 14, 21, 13, 990, DateTimeKind.Local), "Corrupti voluptatum repellat tempora molestiae est.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 29, 3, 10, 30, 303, DateTimeKind.Local), "Omnis molestiae quisquam sit officia.", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 29, 20, 19, 27, 8, DateTimeKind.Local), "Reiciendis inventore suscipit quia expedita mollitia.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 29, 18, 33, 27, 99, DateTimeKind.Local), "Eveniet sit rerum illum deserunt non beatae.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 29, 15, 29, 1, 674, DateTimeKind.Local), "Quis et consequuntur tenetur esse.", "f3b4c548-be18-49c1-a2e7-e11f2355e621", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "2ca00e2e-c335-4921-be38-be5f7edd679b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "8880d06a-4f1c-4adc-a4c5-f0a901c7509e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 0, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 4, "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 18, 30, 17, 14, DateTimeKind.Local), 12, "Ut non vel quo voluptas incidunt nostrum.", "9b8f17ee-e708-4072-8404-f37c90801a6d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 6, 38, 35, 828, DateTimeKind.Local), 14, "Et vitae est.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 21, 28, 631, DateTimeKind.Local), 11, "Saepe consequatur nihil qui quo sunt quibusdam eveniet quia numquam.", "c204f301-0b97-49fa-b5e4-4254848fa6e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 5, 6, 52, 972, DateTimeKind.Local), 19, "Ipsam odio excepturi voluptatem inventore voluptatibus et doloremque minima.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 33, 32, 423, DateTimeKind.Local), 11, "Placeat autem nam qui minus nisi quia sunt hic.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 11, 5, 28, 5, DateTimeKind.Local), "Sint molestiae illo beatae sed.", "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 5, 48, 38, 545, DateTimeKind.Local), 16, "Facilis explicabo error tenetur voluptas vel.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 4, 51, 83, DateTimeKind.Local), 14, "Eaque ipsam quae odit excepturi.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 41, 48, 14, DateTimeKind.Local), 15, "Est commodi ipsam dolorum ipsum assumenda et consectetur aut.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 2, 33, 883, DateTimeKind.Local), 16, "Molestias voluptatem ratione sunt aliquam omnis perferendis quibusdam.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "225.934.0605 x11883", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", "Dolor eveniet quibusdam tenetur voluptatem ullam omnis eligendi rem. Deleniti repellendus consequatur dolores. Sit autem voluptates unde consectetur ex sed a. Voluptatum inventore beatae.", "Zack_Hessel9@gmail.com", "Company626", 62, "http://felton.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "582.868.0440 x097", "c204f301-0b97-49fa-b5e4-4254848fa6e6", "Rerum itaque quod voluptatum voluptatem eius labore. Exercitationem nihil eum dolor assumenda sunt aliquam. Voluptas magni ut qui corrupti tempore facere qui et aut.", "Abelardo45@yahoo.com", "Company175", 61, "http://alexander.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "355.470.2311", "f3b4c548-be18-49c1-a2e7-e11f2355e621", "Aut maiores perferendis delectus amet quis nulla aliquam omnis.", "Serena.Grant51@yahoo.com", "Company44", 66, "http://kaylee.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-326-257-3898 x703", "2ca00e2e-c335-4921-be38-be5f7edd679b", "Sit perferendis impedit quaerat consequatur inventore. Nihil ea qui sunt et harum ducimus ducimus ab. Adipisci voluptatum voluptas eos.", "Jeremie_Barton67@hotmail.com", "Company144", 67, "http://lexie.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(543) 774-3688", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", "Quo dignissimos deleniti nulla iste aut. Debitis sunt reprehenderit ea et id id temporibus numquam. Ut earum vel non. Ipsa temporibus omnis quo qui voluptatem.", "Domenick39@gmail.com", "Company280", 62, "https://claudia.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "720-261-6159 x965", "9b8f17ee-e708-4072-8404-f37c90801a6d", "Est exercitationem porro corrupti aut esse.", "Alfreda.Kuhn40@gmail.com", "Company51", 64, "https://zoila.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(754) 221-3361 x864", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", "", "Bettye76@hotmail.com", "Company651", 65, "http://tyrell.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(777) 295-0631", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", "Quis dignissimos odit quisquam quia consequatur. Modi delectus perspiciatis eligendi expedita aut. Blanditiis rem voluptate ut itaque iste. Quia nam quaerat non ut.", "Kelley67@yahoo.com", "Company111", 61, "https://tiara.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(861) 513-0751 x520", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", "Consectetur neque omnis nulla autem.", "Dianna.Gusikowski@gmail.com", "Company415", 70, "http://taya.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "906-305-9853 x98200", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", "", "Jessika.Keeling@yahoo.com", "Company383", 61, "http://ethan.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 0, 8, 25, 551, DateTimeKind.Local), 41, "Adipisci vitae sint.", "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 35, 35, 207, DateTimeKind.Local), 45, "Et cupiditate voluptatem harum a quae.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 12, 30, 534, DateTimeKind.Local), 44, "Explicabo provident sequi.", "c204f301-0b97-49fa-b5e4-4254848fa6e6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 11, 25, 25, 949, DateTimeKind.Local), 47, "Repellendus pariatur consequatur.", "c204f301-0b97-49fa-b5e4-4254848fa6e6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 21, 52, 476, DateTimeKind.Local), 43, "Alias ut ea.", "6739075a-d110-47dd-aa10-e77085b38762" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 50, 45, 315, DateTimeKind.Local), 44, "Cum at repellendus impedit magnam quia provident ut dolorum quam.", "2ca00e2e-c335-4921-be38-be5f7edd679b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 50, 24, 179, DateTimeKind.Local), 44, "Qui rerum dolorum quas.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 17, 15, 442, DateTimeKind.Local), 47, "Illo quibusdam ipsum et.", "c204f301-0b97-49fa-b5e4-4254848fa6e6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 15, 58, 38, 240, DateTimeKind.Local), "Dolorem ut tempora inventore quam cum consequatur soluta.", "6739075a-d110-47dd-aa10-e77085b38762" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 50, 9, 314, DateTimeKind.Local), 47, "Tempora officia tempora quisquam tempora et ad et dolor quae.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", 73 },
                    { "6be48c54-e679-4ec1-9c83-c4fe60b63535", 76 },
                    { "6739075a-d110-47dd-aa10-e77085b38762", 79 },
                    { "d4b1b17f-aa16-40be-bc50-e59759bc9cb7", 75 },
                    { "9b8f17ee-e708-4072-8404-f37c90801a6d", 78 },
                    { "c204f301-0b97-49fa-b5e4-4254848fa6e6", 77 },
                    { "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", 73 },
                    { "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", 75 },
                    { "f3b4c548-be18-49c1-a2e7-e11f2355e621", 71 },
                    { "2ca00e2e-c335-4921-be38-be5f7edd679b", 73 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSettings_ChatId",
                table: "NotificationSettings",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSettings_Chats_ChatId",
                table: "NotificationSettings",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                keyValues: new object[] { "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2ca00e2e-c335-4921-be38-be5f7edd679b", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5c1251fb-ba57-4ccf-90bb-08f87ded1a40", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6739075a-d110-47dd-aa10-e77085b38762", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6be48c54-e679-4ec1-9c83-c4fe60b63535", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8880d06a-4f1c-4adc-a4c5-f0a901c7509e", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9b8f17ee-e708-4072-8404-f37c90801a6d", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c204f301-0b97-49fa-b5e4-4254848fa6e6", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d4b1b17f-aa16-40be-bc50-e59759bc9cb7", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f3b4c548-be18-49c1-a2e7-e11f2355e621", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ca00e2e-c335-4921-be38-be5f7edd679b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5c1251fb-ba57-4ccf-90bb-08f87ded1a40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6739075a-d110-47dd-aa10-e77085b38762");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6be48c54-e679-4ec1-9c83-c4fe60b63535");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8880d06a-4f1c-4adc-a4c5-f0a901c7509e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9b8f17ee-e708-4072-8404-f37c90801a6d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c204f301-0b97-49fa-b5e4-4254848fa6e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d4b1b17f-aa16-40be-bc50-e59759bc9cb7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f3b4c548-be18-49c1-a2e7-e11f2355e621");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "NotificationSettings");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 95, "Common1", "Source2", 10 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common1", "Source2", 55, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", "Common2", 20, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Source2", 97, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common2", "Source3", 44, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "Common2", "Source3", 37, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 95, "MostLoaded3", "Common1", 17 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Source3", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", 20, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 72, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 4, 49, 110, DateTimeKind.Local), 81, "Title380" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 13, 33, 652, DateTimeKind.Local), 85, "Title32" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 29, 49, 40, DateTimeKind.Local), 89, "Title276" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 29, 1, 111, DateTimeKind.Local), 85, "Title140" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 54, 55, 844, DateTimeKind.Local), 81, "Title964" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 57, 37, 186, DateTimeKind.Local), "Title703" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 3, 41, 0, 914, DateTimeKind.Local), 83, "Title606" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 0, 10, 21, 271, DateTimeKind.Local), 90, "Title510" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 56, 9, 945, DateTimeKind.Local), 89, "Title945" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 14, 26, 21, 124, DateTimeKind.Local), "Title545" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Title" },
                values: new object[] { "ba:d9:61:ea:4b:59", "Instance132" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3e:63:d0:4b:b8:cc", 73, "Windows", "Instance427" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "1d:45:88:2c:6d:65", 80, "Instance766" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f5:f8:85:9a:97:df", 73, "Linux", "Instance769" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6f:72:e0:2b:73:e7", 73, "Instance205" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9c:70:87:42:cf:75", 74, "Instance99" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "66:f2:79:7e:a9:46", 79, "Windows", "Instance489" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8c:55:05:29:6f:ab", 74, "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "26:6d:e4:c5:52:85", 75, "Windows", "Instance722" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8e:0a:63:4e:33:7d", 80, "Instance791" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme903" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme265" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme618" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme277" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme389" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme24" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme304" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme921" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme945" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme452" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "570fb7b2-30ac-46b7-98c2-5d171bafc042", null, new DateTime(2018, 8, 27, 9, 36, 45, 9, DateTimeKind.Local), "Clifford", "Catherine3@yahoo.com", null, "Edythe", true, "Wolf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mrxloka/128.jpg", 2 },
                    { "57c67516-81b3-4916-a777-5acb7675826d", null, new DateTime(2018, 8, 26, 17, 31, 50, 718, DateTimeKind.Local), "Burdette", "Jerrold.Ziemann@yahoo.com", null, "Ena", true, "Powlowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adellecharles/128.jpg", 1 },
                    { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", null, new DateTime(2018, 8, 27, 7, 50, 6, 891, DateTimeKind.Local), "Katelynn", "Gaston27@yahoo.com", null, "Stacey", true, "Wilkinson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/karlkanall/128.jpg", 1 },
                    { "7298ee98-e991-4c10-aaf4-60a9d191f818", null, new DateTime(2018, 8, 27, 6, 21, 46, 912, DateTimeKind.Local), "Javier", "Terrill1@yahoo.com", null, "Louvenia", true, "Eichmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/andrewabogado/128.jpg", 1 },
                    { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", null, new DateTime(2018, 8, 26, 22, 21, 30, 42, DateTimeKind.Local), "Lourdes", "Elmer89@gmail.com", null, "Rebecca", true, "Schmidt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg", 1 },
                    { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", null, new DateTime(2018, 8, 27, 14, 0, 23, 466, DateTimeKind.Local), "Deborah", "Judd.Dibbert68@hotmail.com", null, "Adolf", true, "Block", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_dwite_/128.jpg", 1 },
                    { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", null, new DateTime(2018, 8, 27, 7, 24, 18, 805, DateTimeKind.Local), "Amani", "Archibald.Renner35@gmail.com", null, "Anastasia", true, "Waters", null, "https://s3.amazonaws.com/uifaces/faces/twitter/michaelcomiskey/128.jpg", 1 },
                    { "98b7a347-498b-4edb-be18-c736b985bd08", null, new DateTime(2018, 8, 27, 11, 16, 37, 695, DateTimeKind.Local), "Cale", "Jasmin_Barton@hotmail.com", null, "Neil", true, "Adams", null, "https://s3.amazonaws.com/uifaces/faces/twitter/santi_urso/128.jpg", 1 },
                    { "29a372ec-73b4-436a-b515-a3f17a5334a0", null, new DateTime(2018, 8, 27, 1, 0, 20, 146, DateTimeKind.Local), "Tressa", "Thea_Cartwright@gmail.com", null, "Gregg", true, "Collier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cdavis565/128.jpg", 2 },
                    { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", null, new DateTime(2018, 8, 27, 1, 21, 51, 215, DateTimeKind.Local), "Deshaun", "Cathy_Cummings2@yahoo.com", null, "Korbin", true, "Gulgowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/shalt0ni/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "saepe" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "570fb7b2-30ac-46b7-98c2-5d171bafc042", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "57c67516-81b3-4916-a777-5acb7675826d", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", "repellendus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", "voluptatum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "repudiandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "29a372ec-73b4-436a-b515-a3f17a5334a0", "iusto" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 45, 4, 815, DateTimeKind.Local), "Nisi sint et optio quia ea quam tenetur in.", "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 57, 32, 703, DateTimeKind.Local), "Alias molestiae amet.", "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 57, 40, 333, DateTimeKind.Local), "Tempore quod quis fugiat sequi qui libero nostrum aliquid dolores.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 12, 39, 392, DateTimeKind.Local), "Iure velit sunt molestias inventore.", "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 15, 54, 43, 252, DateTimeKind.Local), "Nemo error nostrum quibusdam dolor quia consequatur fuga.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 1, 41, 234, DateTimeKind.Local), "Rerum autem perspiciatis fugit corrupti excepturi.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 50, 1, 830, DateTimeKind.Local), "Rerum illo molestiae.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 14, 15, 7, 709, DateTimeKind.Local), "Libero sint repudiandae et.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 44, 50, 657, DateTimeKind.Local), "Quis commodi dolor beatae eaque autem optio.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 15, 20, 25, 691, DateTimeKind.Local), "Id vel sit maiores nulla.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 2, 6, 55, 369, DateTimeKind.Local), "Et et recusandae minima.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 0, 43, 27, 240, DateTimeKind.Local), "Officia quo quibusdam laboriosam animi non officiis vel autem tempore.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 5, 25, 13, 479, DateTimeKind.Local), "Optio facere dicta adipisci pariatur.", "29a372ec-73b4-436a-b515-a3f17a5334a0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 26, 19, 31, 21, 44, DateTimeKind.Local), "Explicabo libero quia rerum nihil qui.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 17, 2, 41, 882, DateTimeKind.Local), "Ut eos aut est nulla aspernatur culpa omnis labore et.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 26, 19, 51, 48, 22, DateTimeKind.Local), "Unde praesentium et nostrum sunt labore.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 27, 2, 34, 34, 823, DateTimeKind.Local), "Quia tenetur ad neque repellendus amet quisquam eum.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 18, 43, 4, 720, DateTimeKind.Local), "Mollitia sint quo.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 26, 17, 44, 12, 895, DateTimeKind.Local), "Inventore hic pariatur aut voluptatum neque aut.", "7298ee98-e991-4c10-aaf4-60a9d191f818", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 27, 10, 19, 6, 310, DateTimeKind.Local), "Sit molestiae fuga atque architecto porro.", "29a372ec-73b4-436a-b515-a3f17a5334a0", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 3, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 2, "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 51, 47, 975, DateTimeKind.Local), 11, "Quia doloremque excepturi est tenetur itaque vero.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 49, 24, 807, DateTimeKind.Local), 16, "Qui quaerat voluptas possimus veniam.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 27, 20, 672, DateTimeKind.Local), 15, "Quis sit ut id quod velit sed aut.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 21, 16, 895, DateTimeKind.Local), 16, "Explicabo laborum error laudantium ipsum aliquid error numquam.", "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 48, 55, 405, DateTimeKind.Local), 12, "Nesciunt et aut nam animi iure ea ut.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 21, 38, 12, 998, DateTimeKind.Local), "Autem et et ut.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 5, 14, 766, DateTimeKind.Local), 15, "Nam cumque quos est minima nostrum fugit et dolore suscipit.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 1, 7, 165, DateTimeKind.Local), 12, "Ducimus consequuntur est qui velit ex mollitia.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 41, 54, 137, DateTimeKind.Local), 17, "Quis tempore voluptatem atque accusantium qui.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 0, 55, 933, DateTimeKind.Local), 13, "Blanditiis consequuntur sequi.", "7298ee98-e991-4c10-aaf4-60a9d191f818" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "852.353.7752 x24098", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", "Voluptatem odio sunt in repellendus quisquam. Perspiciatis optio aliquid repudiandae assumenda quam omnis facilis laborum.", "Lucie.Corkery@yahoo.com", "Company364", 63, "http://tamara.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "621-788-4740", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", "Qui eos perferendis debitis reiciendis qui distinctio est. Molestiae optio totam eaque eveniet autem labore voluptates excepturi.", "Troy.Dooley@yahoo.com", "Company428", 63, "http://josiah.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "368.201.7008", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "Adipisci ipsa dolor architecto. Nihil incidunt eum eveniet molestiae eius maiores adipisci repellendus in.", "Lessie_Ondricka@gmail.com", "Company749", 64, "https://chanel.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(353) 533-8585", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Rerum quae exercitationem facere autem. Harum exercitationem repellendus similique assumenda corrupti earum tenetur. A occaecati voluptatem est.", "Wilhelmine.Feil@yahoo.com", "Company552", 62, "http://april.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-959-697-6749 x2560", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "Velit et ab natus ut. Consectetur est nisi dolorem rerum sint alias vel iure.", "Sandrine_Swaniawski@yahoo.com", "Company173", 63, "https://reynold.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-987-342-6977", "98b7a347-498b-4edb-be18-c736b985bd08", "In possimus officia. Aut placeat porro. Laborum ipsam voluptatem et totam illo rerum a. Exercitationem voluptates recusandae qui veritatis accusamus velit perferendis dicta qui.", "Herminia75@yahoo.com", "Company41", 62, "https://virginie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "858-613-4360", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "Necessitatibus est laboriosam rerum reprehenderit aut autem ullam alias. Quia dolores at in tenetur odit.", "Crystal_Larkin65@yahoo.com", "Company404", 64, "https://sebastian.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "436-663-8672", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Id dolore ut. Ducimus aut quibusdam autem nemo. Ea architecto veritatis.", "Marley.Moore@gmail.com", "Company5", 63, "http://raymond.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "314-240-2344 x228", "57c67516-81b3-4916-a777-5acb7675826d", "Eum minus nemo.", "Aisha26@yahoo.com", "Company76", 63, "https://stephanie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "507-572-8538 x7478", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Fuga ut et non quia est harum quibusdam et. Autem est corporis temporibus optio exercitationem inventore illum qui quibusdam.", "Nelson24@gmail.com", "Company639", 67, "https://alvera.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 52, 16, 683, DateTimeKind.Local), 42, "Exercitationem iusto iusto maxime aliquam rerum error sit sed blanditiis.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 11, 27, 677, DateTimeKind.Local), 48, "Voluptatem eum sunt dolor itaque velit rem iure repudiandae.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 50, 23, 540, DateTimeKind.Local), 49, "Sint mollitia quaerat dolorem fugiat.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 21, 16, 772, DateTimeKind.Local), 49, "Consequuntur ut aut sed sint at quo et sapiente.", "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 2, 11, 728, DateTimeKind.Local), 45, "Harum saepe nam ratione consectetur cupiditate voluptates occaecati.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 7, 45, 48, 421, DateTimeKind.Local), 50, "Facilis qui minima et inventore.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 28, 8, 352, DateTimeKind.Local), 47, "Aliquam unde quasi in saepe.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 9, 8, 399, DateTimeKind.Local), 42, "Quaerat est rem aliquam.", "7298ee98-e991-4c10-aaf4-60a9d191f818" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 26, 49, 757, DateTimeKind.Local), "Quia in et corporis et perferendis et numquam.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 3, 4, 58, 146, DateTimeKind.Local), 43, "Et natus itaque sint suscipit autem ut.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "98b7a347-498b-4edb-be18-c736b985bd08", 75 },
                    { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", 75 },
                    { "29a372ec-73b4-436a-b515-a3f17a5334a0", 77 },
                    { "57c67516-81b3-4916-a777-5acb7675826d", 76 },
                    { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", 73 },
                    { "570fb7b2-30ac-46b7-98c2-5d171bafc042", 77 },
                    { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", 77 },
                    { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", 73 },
                    { "7298ee98-e991-4c10-aaf4-60a9d191f818", 72 },
                    { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", 79 }
                });
        }
    }
}
