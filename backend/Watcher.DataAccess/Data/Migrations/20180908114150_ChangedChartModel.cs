using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedChartModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0c567133-e477-4b69-831c-06f6706801cd", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3657f143-b028-4603-b633-0ad81dddd6ca", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "39d976c4-7082-4deb-9f2b-c904814cf9dc", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5cafd127-4454-449f-a0d4-4065dd61ff70", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b6fd9197-d110-458b-8a57-844ee29ef7a6", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7ab8a36-df4b-42c6-901b-43dc534d904d", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0c567133-e477-4b69-831c-06f6706801cd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3657f143-b028-4603-b633-0ad81dddd6ca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39d976c4-7082-4deb-9f2b-c904814cf9dc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ff23f2c-126c-48cb-b3c5-ee749ec59d02");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5cafd127-4454-449f-a0d4-4065dd61ff70");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b6fd9197-d110-458b-8a57-844ee29ef7a6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7ab8a36-df4b-42c6-901b-43dc534d904d");

            migrationBuilder.AlterColumn<int>(
                name: "MostLoaded",
                table: "Charts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 97, 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 95, 1, 92 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, 1, 71, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 98, 1, 78, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, 1, 37, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, 1, 38, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, 1, 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, 1, 95, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, 1, 52, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, 1, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 53, 16, 363, DateTimeKind.Local), 88, "Title478" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 15, 55, 197, DateTimeKind.Local), 86, "Title876" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 14, 53, 23, 647, DateTimeKind.Local), 90, "Title467" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 1, 40, 37, 983, DateTimeKind.Local), 85, "Title360" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 40, 58, 709, DateTimeKind.Local), 83, "Title173" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 1, 11, 279, DateTimeKind.Local), 89, "Title477" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 4, 37, 43, 331, DateTimeKind.Local), 83, "Title774" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 4, 39, 20, 468, DateTimeKind.Local), 86, "Title785" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 9, 28, 13, 134, DateTimeKind.Local), 84, "Title696" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 32, 24, 330, DateTimeKind.Local), 85, "Title849" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:09:fd:43:0c:90", 78, "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "ad:72:b0:c0:ed:f3", "Instance400" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "39:84:d2:b4:08:24", 77, "Instance328" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cb:e4:34:8e:18:77", 78, "Windows", "Instance971" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "Title" },
                values: new object[] { "b3:a6:d2:25:d2:f9", "Instance218" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "ae:e8:fc:bd:ef:db", "Instance770" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e3:a6:b3:57:d5:c9", 73, "Instance230" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "39:37:bb:fe:be:93", 77, "Windows", "Instance658" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "22:38:5e:38:5f:e3", 80, "Instance883" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "40:70:f5:50:72:0c", 80, "Windows", "Instance619" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme109" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme432" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme491" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme427" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme647" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme749" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme837" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme67" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme717" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme335" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", null, new DateTime(2018, 9, 8, 6, 59, 40, 90, DateTimeKind.Local), "Alfredo", "Raina_Bergnaum33@yahoo.com", null, "Jody", true, false, "Greenholt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ivanfilipovbg/128.jpg", 2 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", null, new DateTime(2018, 9, 7, 21, 17, 52, 743, DateTimeKind.Local), "Bruce", "Delpha.Donnelly50@yahoo.com", null, "Murphy", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ryankirkman/128.jpg", 2 },
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", null, new DateTime(2018, 9, 7, 21, 19, 14, 495, DateTimeKind.Local), "Kaci", "Xzavier.Jenkins@hotmail.com", null, "Elmer", true, false, "Hahn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bertboerland/128.jpg", 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", null, new DateTime(2018, 9, 8, 4, 24, 34, 420, DateTimeKind.Local), "Rebecca", "Amari.Kiehn48@gmail.com", null, "Stone", true, false, "Satterfield", null, "https://s3.amazonaws.com/uifaces/faces/twitter/juaumlol/128.jpg", 2 },
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", null, new DateTime(2018, 9, 8, 1, 2, 26, 556, DateTimeKind.Local), "Peggie", "Oma_Waters@gmail.com", null, "Brooks", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kylefrost/128.jpg", 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", null, new DateTime(2018, 9, 8, 14, 26, 21, 99, DateTimeKind.Local), "Juston", "Troy.VonRueden@hotmail.com", null, "Doug", true, false, "Kunze", null, "https://s3.amazonaws.com/uifaces/faces/twitter/d_kobelyatsky/128.jpg", 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", null, new DateTime(2018, 9, 7, 17, 39, 36, 959, DateTimeKind.Local), "Hipolito", "Stephanie_Romaguera24@hotmail.com", null, "David", true, false, "Roob", null, "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg", 2 },
                    { "c317a221-686e-4211-8402-be5800f50db3", null, new DateTime(2018, 9, 8, 1, 20, 52, 332, DateTimeKind.Local), "Clementina", "Savion.Frami56@yahoo.com", null, "Giuseppe", true, false, "Jones", null, "https://s3.amazonaws.com/uifaces/faces/twitter/faisalabid/128.jpg", 2 },
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", null, new DateTime(2018, 9, 8, 12, 23, 25, 863, DateTimeKind.Local), "Karen", "Carlo_Wunsch@hotmail.com", null, "Pat", true, false, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dactrtr/128.jpg", 1 },
                    { "17303a7b-f861-4993-b650-202b9805a826", null, new DateTime(2018, 9, 8, 5, 6, 39, 950, DateTimeKind.Local), "Sabrina", "Nona32@gmail.com", null, "Alice", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/AM_Kn2/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "104e789a-998a-478b-8240-46925d8eb289", "ullam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c317a221-686e-4211-8402-be5800f50db3", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", "laudantium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", "alias" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 19, 46, 29, 445, DateTimeKind.Local), "Nulla et facere architecto non placeat voluptatem tenetur qui.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 47, 10, 241, DateTimeKind.Local), "Maxime cupiditate tempora numquam veritatis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 36, 9, 856, DateTimeKind.Local), "Nam facere corporis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 24, 59, 250, DateTimeKind.Local), "Dicta earum in.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 20, 7, 14, 365, DateTimeKind.Local), "Dolorum eveniet consequatur ipsum dolor.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 6, 28, 44, 938, DateTimeKind.Local), "Velit dolorem error qui illum eum.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 3, 20, 589, DateTimeKind.Local), "Quaerat architecto sed possimus non dolor explicabo animi autem.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 18, 39, 445, DateTimeKind.Local), "Beatae autem numquam qui eos quo pariatur sint.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 52, 21, 34, DateTimeKind.Local), "Praesentium laboriosam qui voluptas amet.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 1, 2, 39, 319, DateTimeKind.Local), "Distinctio occaecati dicta voluptatem at dicta dolores eligendi porro repudiandae.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 8, 2, 22, 30, 156, DateTimeKind.Local), "Aut et culpa.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 7, 16, 11, 49, 696, DateTimeKind.Local), "Doloribus ad similique qui soluta.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 41, 14, 398, DateTimeKind.Local), "Sed voluptas quam possimus minus vitae molestias.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 8, 8, 9, 8, 710, DateTimeKind.Local), "Distinctio facilis ea tempore fugit neque quis voluptas accusantium neque.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 20, 28, 618, DateTimeKind.Local), "Ut repellendus sint.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 8, 7, 20, 11, 194, DateTimeKind.Local), "Eum dolorum ab quia et adipisci.", "77ac325e-dfe7-4b14-835d-b20f271c9150", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 8, 11, 11, 30, 395, DateTimeKind.Local), "Et molestiae quae consequatur quia omnis sit voluptates atque autem.", "77ac325e-dfe7-4b14-835d-b20f271c9150", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 7, 14, 59, 38, 323, DateTimeKind.Local), "Et dignissimos praesentium corrupti officia et sunt dolor voluptatem illo.", "104e789a-998a-478b-8240-46925d8eb289", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 8, 10, 18, 36, 796, DateTimeKind.Local), "At architecto non pariatur qui amet modi omnis.", "72c4d158-c9f9-4bb1-8279-86c127637cfa", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 7, 19, 54, 9, 787, DateTimeKind.Local), "Sunt vitae voluptatum.", "17303a7b-f861-4993-b650-202b9805a826", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 4, "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 20, 17, 3, 643, DateTimeKind.Local), 12, "Laboriosam et placeat voluptatum debitis.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 15, 45, 15, 614, DateTimeKind.Local), 12, "Doloribus optio consequatur saepe quae a sapiente optio.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 1, 43, 796, DateTimeKind.Local), 12, "Eos non atque recusandae accusantium sed sed.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 14, 58, 38, 961, DateTimeKind.Local), "Expedita aut eaque animi.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 14, 35, 670, DateTimeKind.Local), 14, "Consequatur officia ut consectetur vero atque fuga adipisci.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 18, 9, 328, DateTimeKind.Local), 19, "Dolores magni minus sed aut.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 2, 26, 21, 475, DateTimeKind.Local), 18, "Qui blanditiis voluptatem at.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 12, 52, 27, 167, DateTimeKind.Local), 19, "Ex aut delectus.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 9, 37, 150, DateTimeKind.Local), 14, "Et suscipit et qui ea nisi ut debitis vitae eos.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 6, 24, 32, 255, DateTimeKind.Local), 19, "Et quisquam adipisci doloremque ducimus ut magni ut laboriosam.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(323) 396-2347", "104e789a-998a-478b-8240-46925d8eb289", "Rerum eius corporis. Similique quas quo eos autem nostrum adipisci quis.", "Rupert57@gmail.com", "Company325", 70, "http://kathryn.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "680-498-9816 x664", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "", "Garnet68@hotmail.com", "Company48", 69, "https://mckayla.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(385) 482-0280 x4425", "361b7f86-2f9f-4278-af42-a49bc5187139", "Velit enim magnam consequatur ea. Iusto quasi aut cupiditate sint qui.", "Walter.Von59@hotmail.com", "Company246", 63, "http://lucio.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "924-373-3710 x372", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Quibusdam quo veniam voluptas sit aut natus autem magni minus. Voluptates natus occaecati nostrum praesentium sunt nihil maiores esse veniam. Commodi aut consequuntur consequatur ut explicabo impedit voluptates voluptatibus. Aut delectus delectus.", "Dorris_Morissette12@hotmail.com", "Company720", "https://carolina.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "923-623-5034", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Iusto laudantium nam eius facere delectus odit mollitia iste rerum. Eligendi vel ut aut quas distinctio expedita quasi est error. Sed sequi laborum nam id.", "Ike70@yahoo.com", "Company397", 64, "https://jaunita.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "460.366.5740 x3649", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Voluptatem molestias est.", "Noble97@gmail.com", "Company964", 63, "http://terrill.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-436-414-0109 x2636", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Repudiandae porro id enim. Ut cum voluptatibus inventore sit eos libero laboriosam sed. Cumque animi doloribus odit porro eaque.", "Renee.Schmidt53@yahoo.com", "Company696", 61, "https://gisselle.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "448-875-3606 x3885", "17303a7b-f861-4993-b650-202b9805a826", "Autem in ab. Molestias est officia quo.", "Dante_Purdy45@hotmail.com", "Company15", 64, "http://cassie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "316.470.3214", "77ac325e-dfe7-4b14-835d-b20f271c9150", "", "Morgan.Rodriguez@gmail.com", "Company970", 70, "https://brionna.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "428-684-2468 x2295", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Quia blanditiis voluptas rerum quo libero ratione. Quia iure quo totam quas porro qui ut. Quos quia modi est et nihil optio quia cumque cumque.", "Mekhi.Bruen@gmail.com", "Company77", 69, "https://sigmund.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 29, 31, 950, DateTimeKind.Local), 45, "Cum omnis sed ducimus aliquid consequatur.", "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 53, 14, 827, DateTimeKind.Local), 42, "Quibusdam modi temporibus.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 11, 17, 25, 563, DateTimeKind.Local), 41, "Et eligendi consequatur iure et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 2, 57, 49, 818, DateTimeKind.Local), 49, "Et rerum voluptatem magni id.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 42, 29, 907, DateTimeKind.Local), 41, "Natus cumque reprehenderit quo aspernatur necessitatibus vel dolorem totam.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 6, 29, 70, DateTimeKind.Local), 47, "Vitae culpa vel consequatur debitis asperiores.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 12, 31, 23, 226, DateTimeKind.Local), 45, "Reprehenderit maiores enim aperiam.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 15, 57, 42, 951, DateTimeKind.Local), 46, "Doloribus tenetur officiis vero velit.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 0, 21, 40, 347, DateTimeKind.Local), "In optio cum cumque sapiente exercitationem architecto natus dignissimos facere.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 14, 17, 51, 573, DateTimeKind.Local), 42, "Ut et sunt alias pariatur temporibus vero est et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", 78, 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73, 1 },
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73, 1 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79, 1 },
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72, 1 },
                    { "c317a221-686e-4211-8402-be5800f50db3", 78, 1 },
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72, 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", 77, 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74, 1 },
                    { "17303a7b-f861-4993-b650-202b9805a826", 76, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "104e789a-998a-478b-8240-46925d8eb289", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "17303a7b-f861-4993-b650-202b9805a826", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c317a221-686e-4211-8402-be5800f50db3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "104e789a-998a-478b-8240-46925d8eb289");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17303a7b-f861-4993-b650-202b9805a826");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "361b7f86-2f9f-4278-af42-a49bc5187139");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "72c4d158-c9f9-4bb1-8279-86c127637cfa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "77ac325e-dfe7-4b14-835d-b20f271c9150");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c317a221-686e-4211-8402-be5800f50db3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd91ae36-8dd0-484f-b488-0eec3b81dbe5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d65d8522-a0e6-41ed-af72-52b85ea1e523");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e9afaf96-7110-42c2-abf6-2c900a02badb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f07d7131-08d8-4381-96af-7fcd543c9f41");

            migrationBuilder.AlterColumn<string>(
                name: "MostLoaded",
                table: "Charts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", 100, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 98, "MostLoaded2", 16 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", 54, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", 90, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded3", 57, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", 56, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", 65, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", 81, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", 20, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 17, 15, 6, 57, DateTimeKind.Local), 84, "Title947" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 2, 30, 57, 491, DateTimeKind.Local), 87, "Title114" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 18, 22, 32, 338, DateTimeKind.Local), 88, "Title933" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 0, 24, 58, 644, DateTimeKind.Local), 88, "Title225" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 12, 41, 35, 549, DateTimeKind.Local), 88, "Title899" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 8, 13, 52, 974, DateTimeKind.Local), 82, "Title578" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 12, 47, 52, 202, DateTimeKind.Local), 85, "Title429" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 0, 51, 55, 335, DateTimeKind.Local), 82, "Title45" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 13, 28, 30, 89, DateTimeKind.Local), 88, "Title360" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 7, 26, 46, 824, DateTimeKind.Local), 81, "Title731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2a:a8:fa:5f:ca:50", 79, "Instance115" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "f8:8d:ba:da:08:0c", "Instance829" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d1:27:65:c0:8f:42", 79, "Instance2" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ea:65:35:d3:fa:f0", 77, "Linux", "Instance663" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "Title" },
                values: new object[] { "45:e0:52:8f:4c:a6", "Instance23" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "20:90:03:4c:2b:03", "Instance432" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "70:16:29:60:72:92", 74, "Instance811" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6f:31:e5:56:8b:f1", 79, "Linux", "Instance875" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3f:86:55:94:53:59", 74, "Instance455" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ad:63:6f:7d:39:2f", 78, "Linux", "Instance658" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme448" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme466" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme746" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme34" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme439" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme85" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme410" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme343" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme855" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme647" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", null, new DateTime(2018, 9, 6, 11, 13, 52, 452, DateTimeKind.Local), "Willa", "Rubie18@hotmail.com", null, "Lenora", true, false, "Breitenberg", null, "https://s3.amazonaws.com/uifaces/faces/twitter/baumann_alex/128.jpg", 1 },
                    { "e7ab8a36-df4b-42c6-901b-43dc534d904d", null, new DateTime(2018, 9, 6, 20, 27, 8, 727, DateTimeKind.Local), "Neoma", "Maybell42@hotmail.com", null, "Casimir", true, false, "Ritchie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/angelcreative/128.jpg", 2 },
                    { "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", null, new DateTime(2018, 9, 6, 13, 9, 58, 343, DateTimeKind.Local), "Dorian", "Adrienne27@hotmail.com", null, "Adah", true, false, "West", null, "https://s3.amazonaws.com/uifaces/faces/twitter/aio___/128.jpg", 1 },
                    { "b6fd9197-d110-458b-8a57-844ee29ef7a6", null, new DateTime(2018, 9, 7, 3, 8, 25, 671, DateTimeKind.Local), "Fern", "Jan.Will@gmail.com", null, "Rae", true, false, "Bailey", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cherif_b/128.jpg", 2 },
                    { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", null, new DateTime(2018, 9, 6, 20, 50, 34, 579, DateTimeKind.Local), "Jamar", "Elisabeth37@gmail.com", null, "Lilliana", true, false, "Glover", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_dwite_/128.jpg", 1 },
                    { "3657f143-b028-4603-b633-0ad81dddd6ca", null, new DateTime(2018, 9, 6, 20, 56, 48, 196, DateTimeKind.Local), "Alexys", "Wilson.Block60@yahoo.com", null, "Astrid", true, false, "Bradtke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarjan/128.jpg", 2 },
                    { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", null, new DateTime(2018, 9, 7, 4, 51, 13, 658, DateTimeKind.Local), "Juliet", "Jensen.Feil74@yahoo.com", null, "Toney", true, false, "Reilly", null, "https://s3.amazonaws.com/uifaces/faces/twitter/pcridesagain/128.jpg", 1 },
                    { "39d976c4-7082-4deb-9f2b-c904814cf9dc", null, new DateTime(2018, 9, 6, 21, 6, 15, 175, DateTimeKind.Local), "Sonny", "Katlynn.Goldner@gmail.com", null, "Abdul", true, false, "Jakubowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/netonet_il/128.jpg", 2 },
                    { "5cafd127-4454-449f-a0d4-4065dd61ff70", null, new DateTime(2018, 9, 6, 22, 51, 15, 172, DateTimeKind.Local), "Adrain", "Guido_Hackett76@hotmail.com", null, "Deondre", true, false, "Feeney", null, "https://s3.amazonaws.com/uifaces/faces/twitter/enda/128.jpg", 2 },
                    { "0c567133-e477-4b69-831c-06f6706801cd", null, new DateTime(2018, 9, 6, 14, 0, 47, 912, DateTimeKind.Local), "Aleen", "Brielle.Swift@yahoo.com", null, "Gloria", true, false, "Rutherford", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sergeyalmone/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "voluptate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b6fd9197-d110-458b-8a57-844ee29ef7a6", "vel" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0c567133-e477-4b69-831c-06f6706801cd", "iusto" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", "aliquid" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0c567133-e477-4b69-831c-06f6706801cd", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "veniam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "39d976c4-7082-4deb-9f2b-c904814cf9dc", "corporis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "debitis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5cafd127-4454-449f-a0d4-4065dd61ff70", "sint" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 2, 52, 49, 217, DateTimeKind.Local), "Et occaecati qui vitae eligendi sed repellat rem quisquam impedit.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 5, 49, 29, 392, DateTimeKind.Local), "Repellendus sequi et nisi.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 17, 25, 48, 393, DateTimeKind.Local), "Quod quo molestias asperiores.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 22, 20, 35, 91, DateTimeKind.Local), "Occaecati consequatur pariatur qui asperiores a sint.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 14, 4, 43, 734, DateTimeKind.Local), "Eos non tenetur doloremque eum omnis est minima enim tempora.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 8, 39, 48, 251, DateTimeKind.Local), "Est officia et reprehenderit velit quasi aut voluptatem commodi.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 4, 2, 23, 23, DateTimeKind.Local), "Nam officiis aliquam voluptas laboriosam et.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 23, 56, 7, 108, DateTimeKind.Local), "Quia enim vel amet repudiandae inventore qui porro.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 7, 50, 42, 924, DateTimeKind.Local), "Odio hic sed et error similique voluptatem dignissimos.", "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 20, 39, 52, 630, DateTimeKind.Local), "Pariatur molestiae omnis neque et et hic non animi.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 6, 17, 38, 19, 636, DateTimeKind.Local), "Ipsam voluptatem dolores aut quo.", "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 6, 18, 5, 43, 856, DateTimeKind.Local), "Est deserunt accusamus et facilis libero aut sunt.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 8, 25, 44, 192, DateTimeKind.Local), "Autem molestiae minima accusantium eos et dolorum ratione sed alias.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 6, 14, 16, 43, 645, DateTimeKind.Local), "Quisquam hic repellat repellendus molestias.", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 9, 21, 10, 804, DateTimeKind.Local), "Distinctio quasi accusamus officia exercitationem dolor.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 6, 11, 12, 28, 707, DateTimeKind.Local), "Iusto delectus nulla doloremque tempora omnis est officia.", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 6, 20, 19, 2, 899, DateTimeKind.Local), "Consequatur tempore est facere facere error rerum vitae.", "39d976c4-7082-4deb-9f2b-c904814cf9dc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 7, 6, 57, 23, 438, DateTimeKind.Local), "Natus qui qui et eaque suscipit et deserunt quis.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 7, 9, 59, 38, 485, DateTimeKind.Local), "Labore omnis error qui esse facilis magni eius dolorum.", "3657f143-b028-4603-b633-0ad81dddd6ca", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 6, 15, 44, 24, 453, DateTimeKind.Local), "Animi sunt quis rerum ut voluptatum.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 1, "0c567133-e477-4b69-831c-06f6706801cd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "3657f143-b028-4603-b633-0ad81dddd6ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "3657f143-b028-4603-b633-0ad81dddd6ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "3657f143-b028-4603-b633-0ad81dddd6ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 1, "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 7, 14, 28, 43, DateTimeKind.Local), 15, "Velit est quaerat corrupti beatae suscipit numquam quam.", "39d976c4-7082-4deb-9f2b-c904814cf9dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 22, 48, 55, 235, DateTimeKind.Local), 16, "Omnis culpa et illo ducimus cum.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 16, 34, 24, 52, DateTimeKind.Local), 20, "Est et odio.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 2, 58, 15, 604, DateTimeKind.Local), "Omnis laudantium ut.", "0c567133-e477-4b69-831c-06f6706801cd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 22, 39, 4, 791, DateTimeKind.Local), 17, "Saepe autem cum enim odio repellat ut.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 7, 38, 58, 179, DateTimeKind.Local), 12, "Nulla reiciendis voluptatem aliquid magnam animi quod.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 2, 0, 11, 326, DateTimeKind.Local), 14, "Ab quia nesciunt quaerat.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 6, 14, 21, 63, DateTimeKind.Local), 16, "Neque similique quod cum nesciunt architecto repellat.", "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 5, 29, 29, 445, DateTimeKind.Local), 16, "Aut eligendi autem eos sit voluptatibus voluptates voluptate.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 5, 58, 18, 829, DateTimeKind.Local), 15, "Soluta qui cumque voluptas ex voluptatem dolor rerum delectus.", "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "466.748.2471", "3657f143-b028-4603-b633-0ad81dddd6ca", "", "Jaycee26@yahoo.com", "Company144", 62, "http://alexandria.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-590-534-8112", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "Dolor voluptatem qui tempora. Dolorem ab ducimus magni architecto.", "Fritz.Gulgowski@gmail.com", "Company229", 63, "http://haskell.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "921-832-8486", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "Aliquid sunt ex.", "Adrien18@hotmail.com", "Company437", 64, "https://elizabeth.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "288.787.3177 x12655", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "", "Flavie_Wilkinson54@gmail.com", "Company363", "https://rogelio.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(641) 848-9435 x8956", "e7ab8a36-df4b-42c6-901b-43dc534d904d", "Ut id ea eos atque rerum repellat qui. Voluptatum modi tempora laudantium fuga earum quod. Ea consequuntur eveniet eligendi.", "Roman.Kovacek@yahoo.com", "Company444", 62, "https://adrienne.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(460) 226-8050 x5706", "e7ab8a36-df4b-42c6-901b-43dc534d904d", "Illum ipsum sint. Quae omnis laborum culpa qui accusamus sed alias voluptas. Error accusantium velit temporibus laboriosam qui dicta.", "Faye.Ziemann@yahoo.com", "Company780", 62, "https://clotilde.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "460.765.5043 x183", "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", "", "Lafayette77@yahoo.com", "Company438", 66, "https://manuel.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-528-862-2833 x183", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", "", "Oscar_Yost7@yahoo.com", "Company362", 69, "https://hattie.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "663.823.0660 x210", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", "Modi alias inventore molestias rem reiciendis alias eos. Qui dicta et at voluptas iure debitis perspiciatis asperiores. Facilis veritatis id voluptatibus rerum sint nemo voluptatem.", "Khalil.OHara@gmail.com", "Company284", 68, "http://era.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "689.616.1922 x724", "3657f143-b028-4603-b633-0ad81dddd6ca", "", "Percy.Bahringer@gmail.com", "Company999", 65, "http://reba.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 3, 46, 7, 715, DateTimeKind.Local), 42, "Dignissimos ipsam ab sed.", "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 1, 15, 45, 356, DateTimeKind.Local), 48, "Sint optio quis eaque quo tempore.", "39d976c4-7082-4deb-9f2b-c904814cf9dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 23, 43, 28, 618, DateTimeKind.Local), 48, "Eum repudiandae autem et nihil.", "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 8, 52, 44, 832, DateTimeKind.Local), 48, "Iure voluptas sint repellendus.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 21, 20, 51, 651, DateTimeKind.Local), 45, "Unde excepturi commodi aperiam et non in at voluptatem.", "3657f143-b028-4603-b633-0ad81dddd6ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 16, 36, 51, 814, DateTimeKind.Local), 45, "Ipsa sit sequi nostrum.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 21, 42, 30, 443, DateTimeKind.Local), 48, "Saepe mollitia error.", "5cafd127-4454-449f-a0d4-4065dd61ff70" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 0, 47, 33, 557, DateTimeKind.Local), 44, "Ea repudiandae ullam et maiores repudiandae voluptas aliquam.", "4ff23f2c-126c-48cb-b3c5-ee749ec59d02" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 22, 47, 23, 124, DateTimeKind.Local), "Qui culpa enim ut consequuntur exercitationem sint ut qui ea.", "b6fd9197-d110-458b-8a57-844ee29ef7a6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 20, 46, 32, 113, DateTimeKind.Local), 48, "Maxime et repudiandae quibusdam dolores.", "e7ab8a36-df4b-42c6-901b-43dc534d904d" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "5cafd127-4454-449f-a0d4-4065dd61ff70", 75, 1 },
                    { "4ff23f2c-126c-48cb-b3c5-ee749ec59d02", 73, 1 },
                    { "39d976c4-7082-4deb-9f2b-c904814cf9dc", 79, 1 },
                    { "6f77a776-9d9d-4ea8-b0c0-c75eb5976fd5", 74, 1 },
                    { "3657f143-b028-4603-b633-0ad81dddd6ca", 73, 1 },
                    { "bc97af4f-4b92-4a1a-bc0d-526f98ffbce2", 73, 1 },
                    { "e7ab8a36-df4b-42c6-901b-43dc534d904d", 71, 1 },
                    { "b6fd9197-d110-458b-8a57-844ee29ef7a6", 79, 1 },
                    { "3ccc5f60-674b-4bdd-a9b3-326cfc1adb35", 71, 1 },
                    { "0c567133-e477-4b69-831c-06f6706801cd", 75, 1 }
                });
        }
    }
}
