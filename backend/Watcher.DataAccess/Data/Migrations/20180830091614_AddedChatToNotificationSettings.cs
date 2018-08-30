using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedChatToNotificationSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "Common2", "Source3", 97, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common3", "Source3", 55, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "Common3", 5, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded3", "Common1", "Source2", 25 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", "Common1", 27, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Source3", 85, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", 72, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Common1", "Source1", 85, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Common1", "Source3", 47, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 7, 29, 38, 163, DateTimeKind.Local), 82, "Title561" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 20, 56, 32, 301, DateTimeKind.Local), 89, "Title104" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 6, 44, 134, DateTimeKind.Local), "Title80" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 4, 49, 43, 679, DateTimeKind.Local), 88, "Title111" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 9, 5, 4, 480, DateTimeKind.Local), 88, "Title543" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 13, 27, 360, DateTimeKind.Local), 88, "Title275" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 15, 52, 28, 643, DateTimeKind.Local), 86, "Title104" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 3, 24, 39, 671, DateTimeKind.Local), 82, "Title830" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 17, 14, 359, DateTimeKind.Local), 87, "Title443" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 9, 7, 22, 687, DateTimeKind.Local), 89, "Title347" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "23:da:84:2d:c4:a1", 79, "Linux", "Instance129" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "bb:f5:c8:c3:7f:8d", 74, "Instance858" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "40:27:ba:38:23:65", 77, "Instance232" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Title" },
                values: new object[] { "06:41:7b:ba:f3:85", "Instance854" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "09:93:c2:e8:ac:a3", 72, "Instance156" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "79:11:7a:1b:ca:fc", 72, "Instance614" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "fa:7d:c2:32:ca:79", 75, "Windows", "Instance41" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8b:64:28:2e:fc:ad", 74, "Instance815" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3c:d8:c4:7b:2f:f4", 78, "Instance546" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "64:b6:f3:c9:12:8b", 79, "Instance936" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme499" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme442" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme116");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme842" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme884" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme636" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme448" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme670" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme94" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "68f4084e-f443-4968-92ae-4a11b5f3bec9", null, new DateTime(2018, 8, 29, 22, 6, 12, 309, DateTimeKind.Local), "Quinn", "Lucius_Hessel@yahoo.com", null, "Kariane", true, "Walter", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tur8le/128.jpg", 1 },
                    { "3b7e00aa-778b-409b-ac76-89da0c106903", null, new DateTime(2018, 8, 29, 17, 42, 44, 529, DateTimeKind.Local), "Katelynn", "Caroline83@gmail.com", null, "Nat", true, "Herman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vinciarts/128.jpg", 2 },
                    { "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30", null, new DateTime(2018, 8, 29, 13, 42, 10, 844, DateTimeKind.Local), "Nikolas", "Rosetta_McClure@gmail.com", null, "Vicente", true, "Pouros", null, "https://s3.amazonaws.com/uifaces/faces/twitter/karlkanall/128.jpg", 2 },
                    { "41878c18-40ac-4565-bdcb-9c9789b1c2d0", null, new DateTime(2018, 8, 30, 0, 10, 56, 759, DateTimeKind.Local), "Ludwig", "Zaria7@hotmail.com", null, "Izaiah", true, "Hansen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/panghal0/128.jpg", 2 },
                    { "96f6c674-f860-4a6e-a8a6-d9c45813f59b", null, new DateTime(2018, 8, 30, 6, 42, 1, 734, DateTimeKind.Local), "Garret", "Darrell.Lowe@yahoo.com", null, "Jon", true, "Krajcik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/wake_gs/128.jpg", 1 },
                    { "ef62f575-a324-4529-867e-0de67899f25d", null, new DateTime(2018, 8, 29, 23, 39, 37, 297, DateTimeKind.Local), "Bertram", "Hershel_Langosh12@hotmail.com", null, "Aiyana", true, "Wisoky", null, "https://s3.amazonaws.com/uifaces/faces/twitter/axel/128.jpg", 2 },
                    { "37826b87-5f58-4272-9d9c-d47055ca4861", null, new DateTime(2018, 8, 30, 8, 44, 0, 93, DateTimeKind.Local), "Frida", "Gussie_Gleason7@gmail.com", null, "Stephanie", true, "Erdman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/fuck_you_two/128.jpg", 1 },
                    { "360ebffe-bf69-4a55-a09a-83d6b102cf8f", null, new DateTime(2018, 8, 30, 3, 51, 36, 534, DateTimeKind.Local), "Jazmin", "Benny4@yahoo.com", null, "Easter", true, "Spencer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/turkutuuli/128.jpg", 1 },
                    { "bad80758-fd2c-41f8-a2b3-b5504d67a428", null, new DateTime(2018, 8, 29, 21, 1, 20, 490, DateTimeKind.Local), "Clyde", "Lura.Corkery72@yahoo.com", null, "Maria", true, "Schumm", null, "https://s3.amazonaws.com/uifaces/faces/twitter/VMilescu/128.jpg", 1 },
                    { "18d545be-dd14-41ae-98a2-79f8255d49ec", null, new DateTime(2018, 8, 29, 16, 34, 56, 975, DateTimeKind.Local), "Emmanuel", "Xzavier.Emard@gmail.com", null, "Bryon", true, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarjan/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "360ebffe-bf69-4a55-a09a-83d6b102cf8f", "asperiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96f6c674-f860-4a6e-a8a6-d9c45813f59b", "ex" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bad80758-fd2c-41f8-a2b3-b5504d67a428", "quod" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37826b87-5f58-4272-9d9c-d47055ca4861", "eius" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "18d545be-dd14-41ae-98a2-79f8255d49ec", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef62f575-a324-4529-867e-0de67899f25d", "illum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "68f4084e-f443-4968-92ae-4a11b5f3bec9", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37826b87-5f58-4272-9d9c-d47055ca4861", "tempora" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef62f575-a324-4529-867e-0de67899f25d", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37826b87-5f58-4272-9d9c-d47055ca4861", "occaecati" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 1, 23, 54, 748, DateTimeKind.Local), "Nulla nesciunt cupiditate.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 14, 22, 18, 114, DateTimeKind.Local), "Id sint eaque quas.", "37826b87-5f58-4272-9d9c-d47055ca4861" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 44, 45, 84, DateTimeKind.Local), "Et excepturi voluptatem accusamus voluptas sed reiciendis.", "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 10, 47, 41, 100, DateTimeKind.Local), "Saepe quos minus id exercitationem.", "3b7e00aa-778b-409b-ac76-89da0c106903" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 19, 34, 32, 551, DateTimeKind.Local), "Quia assumenda sit est exercitationem velit et exercitationem.", "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 15, 1, 30, 576, DateTimeKind.Local), "Assumenda aspernatur voluptatem sunt similique sequi sed.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 10, 7, 38, DateTimeKind.Local), "Consequatur earum nulla aut temporibus et.", "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 3, 5, 23, 895, DateTimeKind.Local), "Dignissimos blanditiis voluptates aut quod ut.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 19, 43, 35, 853, DateTimeKind.Local), "Dolorem fuga unde molestias.", "360ebffe-bf69-4a55-a09a-83d6b102cf8f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 8, 16, 39, 996, DateTimeKind.Local), "Ut maxime et.", "ef62f575-a324-4529-867e-0de67899f25d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 30, 9, 35, 10, 596, DateTimeKind.Local), "Voluptatibus velit sequi occaecati soluta sit.", "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 29, 13, 27, 40, 320, DateTimeKind.Local), "Delectus facilis dolores.", "3b7e00aa-778b-409b-ac76-89da0c106903", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 30, 4, 19, 10, 116, DateTimeKind.Local), "Omnis recusandae laudantium quasi tempore suscipit et molestiae eligendi.", "96f6c674-f860-4a6e-a8a6-d9c45813f59b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 29, 22, 29, 32, 837, DateTimeKind.Local), "Omnis perferendis culpa sed aut inventore nobis.", "3b7e00aa-778b-409b-ac76-89da0c106903", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 0, 49, 37, 981, DateTimeKind.Local), "Animi repellat et nobis expedita iure eum nihil.", "3b7e00aa-778b-409b-ac76-89da0c106903" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 29, 20, 32, 45, 145, DateTimeKind.Local), "Amet illum possimus placeat corrupti voluptatibus.", "bad80758-fd2c-41f8-a2b3-b5504d67a428", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 30, 9, 3, 53, 32, DateTimeKind.Local), "Delectus maxime similique.", "41878c18-40ac-4565-bdcb-9c9789b1c2d0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 29, 18, 26, 40, 80, DateTimeKind.Local), "Ut a minus et occaecati aut ut rerum.", "41878c18-40ac-4565-bdcb-9c9789b1c2d0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 56, 44, 917, DateTimeKind.Local), "Qui est optio et non accusantium.", "68f4084e-f443-4968-92ae-4a11b5f3bec9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 5, 7, 16, 7, DateTimeKind.Local), "Dolores dolor porro voluptates.", "18d545be-dd14-41ae-98a2-79f8255d49ec", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 3, "ef62f575-a324-4529-867e-0de67899f25d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "3b7e00aa-778b-409b-ac76-89da0c106903" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "37826b87-5f58-4272-9d9c-d47055ca4861" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "41878c18-40ac-4565-bdcb-9c9789b1c2d0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 3, "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 2, "68f4084e-f443-4968-92ae-4a11b5f3bec9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 0, "41878c18-40ac-4565-bdcb-9c9789b1c2d0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 54, 28, 528, DateTimeKind.Local), 17, "In et rem natus sed et nam.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 48, 15, 246, DateTimeKind.Local), 11, "Ad quia est nam omnis consequuntur.", "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 56, 28, 904, DateTimeKind.Local), 19, "Non deleniti velit.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 15, 39, 18, 839, DateTimeKind.Local), 14, "Cupiditate a et exercitationem recusandae ut quisquam.", "68f4084e-f443-4968-92ae-4a11b5f3bec9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 11, 6, 13, 468, DateTimeKind.Local), 16, "Inventore quas in in et et sunt architecto praesentium.", "ef62f575-a324-4529-867e-0de67899f25d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 9, 51, 38, 724, DateTimeKind.Local), 20, "Libero ut non est eos ad alias minima et.", "37826b87-5f58-4272-9d9c-d47055ca4861" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 54, 10, 731, DateTimeKind.Local), 19, "Adipisci nisi itaque ut.", "ef62f575-a324-4529-867e-0de67899f25d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 56, 20, 991, DateTimeKind.Local), 15, "Assumenda sint et non pariatur ad voluptatibus pariatur qui.", "68f4084e-f443-4968-92ae-4a11b5f3bec9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 59, 38, 131, DateTimeKind.Local), "Et libero quod architecto quisquam possimus nemo.", "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 19, 2, 48, 230, DateTimeKind.Local), 19, "Et velit qui incidunt eos corrupti et repellat.", "68f4084e-f443-4968-92ae-4a11b5f3bec9" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "432.633.4642 x00873", "3b7e00aa-778b-409b-ac76-89da0c106903", "Dolor nemo architecto perferendis et accusamus aut. Tempore aut odio ipsam minus nulla at illum ad.", "Emilie22@yahoo.com", "Company56", 70, "https://green.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(656) 470-7947 x2361", "37826b87-5f58-4272-9d9c-d47055ca4861", "Placeat vel et ut culpa. Odio et atque dolores dicta ad quibusdam. Error voluptatem fugit sit sint odit. Et beatae voluptas eaque corporis assumenda non perspiciatis.", "Damion51@gmail.com", "Company763", 64, "http://vesta.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "751.201.0266", "96f6c674-f860-4a6e-a8a6-d9c45813f59b", "Nobis ullam deleniti incidunt minima assumenda incidunt. Autem minus veritatis voluptatum molestiae. Harum iusto distinctio hic praesentium quia aut debitis. Omnis provident magni maxime veritatis voluptatum.", "Norene.Ward7@hotmail.com", "Company23", 68, "http://spencer.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-590-923-5666 x266", "360ebffe-bf69-4a55-a09a-83d6b102cf8f", "Quisquam optio ratione accusantium dolorem dolor quis sapiente est. Est unde consequatur velit iusto sequi ipsum. Praesentium corrupti perspiciatis illum quas aut ut. Nulla vel sunt fugit incidunt et minima.", "Armando22@gmail.com", "Company339", 66, "https://edward.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "615-501-1339 x12669", "ef62f575-a324-4529-867e-0de67899f25d", "Est suscipit repellat enim incidunt nobis voluptates excepturi voluptates. Est totam id.", "Jewell93@gmail.com", "Company526", 61, "http://jamel.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(635) 487-4061 x552", "41878c18-40ac-4565-bdcb-9c9789b1c2d0", "Perferendis ratione aut iusto pariatur. Corporis voluptatem reiciendis ipsum in occaecati et nemo. Dolore excepturi enim assumenda architecto sunt dolores.", "Harvey.Nienow@gmail.com", "Company284", 62, "http://jedidiah.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-917-231-3432 x57080", "3b7e00aa-778b-409b-ac76-89da0c106903", "Tempore eligendi debitis dolorem hic molestias voluptas.", "Yoshiko_Upton76@yahoo.com", "Company928", 64, "https://gaetano.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "237-898-6479", "ef62f575-a324-4529-867e-0de67899f25d", "", "Ramona_Stark@gmail.com", "Company243", 67, "https://dino.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-244-390-4660 x49319", "bad80758-fd2c-41f8-a2b3-b5504d67a428", "", "Margie54@hotmail.com", "Company256", 64, "http://kolby.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "947-946-7324", "bad80758-fd2c-41f8-a2b3-b5504d67a428", "Voluptate delectus laborum assumenda sunt autem non. Et nobis et amet. Quisquam voluptate animi rerum sunt aut et.", "Maxime_Marks@gmail.com", "Company390", 64, "https://arlo.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 16, 52, 51, 931, DateTimeKind.Local), 44, "Quia dolor et.", "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 10, 2, 527, DateTimeKind.Local), 47, "Quas similique veniam beatae velit nulla fugit vero.", "96f6c674-f860-4a6e-a8a6-d9c45813f59b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 14, 29, 42, 698, DateTimeKind.Local), 43, "Ipsum voluptatibus veritatis voluptatem.", "bad80758-fd2c-41f8-a2b3-b5504d67a428" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 11, 4, 48, 969, DateTimeKind.Local), 44, "Accusamus cupiditate rerum ipsa.", "18d545be-dd14-41ae-98a2-79f8255d49ec" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 4, 56, 39, 264, DateTimeKind.Local), "Qui natus non architecto quae.", "360ebffe-bf69-4a55-a09a-83d6b102cf8f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 57, 53, 997, DateTimeKind.Local), 43, "Rem nemo nulla officia et.", "41878c18-40ac-4565-bdcb-9c9789b1c2d0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 19, 51, 0, 127, DateTimeKind.Local), 41, "Esse aut fugit eos suscipit hic in adipisci aut reiciendis.", "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 1, 14, 588, DateTimeKind.Local), 49, "Dolores fugiat consequuntur id deleniti.", "3b7e00aa-778b-409b-ac76-89da0c106903" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 55, 14, 897, DateTimeKind.Local), "Aut reiciendis iusto unde voluptate.", "37826b87-5f58-4272-9d9c-d47055ca4861" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 44, 3, 459, DateTimeKind.Local), 49, "Autem et dolores labore neque accusamus modi.", "96f6c674-f860-4a6e-a8a6-d9c45813f59b" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "68f4084e-f443-4968-92ae-4a11b5f3bec9", 77 },
                    { "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30", 72 },
                    { "bad80758-fd2c-41f8-a2b3-b5504d67a428", 76 },
                    { "ef62f575-a324-4529-867e-0de67899f25d", 71 },
                    { "41878c18-40ac-4565-bdcb-9c9789b1c2d0", 73 },
                    { "360ebffe-bf69-4a55-a09a-83d6b102cf8f", 74 },
                    { "96f6c674-f860-4a6e-a8a6-d9c45813f59b", 79 },
                    { "37826b87-5f58-4272-9d9c-d47055ca4861", 74 },
                    { "3b7e00aa-778b-409b-ac76-89da0c106903", 78 },
                    { "18d545be-dd14-41ae-98a2-79f8255d49ec", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "18d545be-dd14-41ae-98a2-79f8255d49ec", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "360ebffe-bf69-4a55-a09a-83d6b102cf8f", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "37826b87-5f58-4272-9d9c-d47055ca4861", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3b7e00aa-778b-409b-ac76-89da0c106903", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "41878c18-40ac-4565-bdcb-9c9789b1c2d0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "68f4084e-f443-4968-92ae-4a11b5f3bec9", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "96f6c674-f860-4a6e-a8a6-d9c45813f59b", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bad80758-fd2c-41f8-a2b3-b5504d67a428", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef62f575-a324-4529-867e-0de67899f25d", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18d545be-dd14-41ae-98a2-79f8255d49ec");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "360ebffe-bf69-4a55-a09a-83d6b102cf8f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37826b87-5f58-4272-9d9c-d47055ca4861");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3a8570bc-6d2c-4ef2-a84e-ed83c7322b30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3b7e00aa-778b-409b-ac76-89da0c106903");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41878c18-40ac-4565-bdcb-9c9789b1c2d0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "68f4084e-f443-4968-92ae-4a11b5f3bec9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "96f6c674-f860-4a6e-a8a6-d9c45813f59b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bad80758-fd2c-41f8-a2b3-b5504d67a428");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef62f575-a324-4529-867e-0de67899f25d");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 14, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "Common3", "Source1", 5, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common1", "Source1", 40, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "Common2", 45, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded2", "Common3", "Source1", 89 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Common3", 87, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Source1", 99, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Common3", "Source2", 55, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Common3", "Source2", 17, 2 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 37, 28, 263, DateTimeKind.Local), "Title987" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 51, 59, 538, DateTimeKind.Local), 89, "Title7" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 8, 47, 16, 861, DateTimeKind.Local), 87, "Title982" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "9c:db:13:e3:a8:a7", 80, "Windows", "Instance67" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ce:08:64:28:10:27", 76, "Instance392" });

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
                columns: new[] { "Address", "Title" },
                values: new object[] { "25:fe:7d:11:44:49", "Instance306" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4b:a2:65:69:1a:3d", 80, "Instance307" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme504" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme329" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme976");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme315" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme430" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme452" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 29, 21, 59, 49, 113, DateTimeKind.Local), "Fuga quis exercitationem deserunt possimus.", "f3b4c548-be18-49c1-a2e7-e11f2355e621", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 18, 9, 47, 19, DateTimeKind.Local), "Voluptatem qui nobis iste cum placeat illum.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 29, 14, 21, 13, 990, DateTimeKind.Local), "Corrupti voluptatum repellat tempora molestiae est.", "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 29, 3, 10, 30, 303, DateTimeKind.Local), "Omnis molestiae quisquam sit officia.", "8880d06a-4f1c-4adc-a4c5-f0a901c7509e" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 18, 33, 27, 99, DateTimeKind.Local), "Eveniet sit rerum illum deserunt non beatae.", "5c1251fb-ba57-4ccf-90bb-08f87ded1a40" });

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
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 2, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "2ca00e2e-c335-4921-be38-be5f7edd679b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
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
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 3, "0cacfc5d-8b3d-49d5-b6f4-c357d25e4e52" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "d4b1b17f-aa16-40be-bc50-e59759bc9cb7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 2, "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 11, 5, 28, 5, DateTimeKind.Local), 13, "Sint molestiae illo beatae sed.", "f3b4c548-be18-49c1-a2e7-e11f2355e621" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 41, 48, 14, DateTimeKind.Local), "Est commodi ipsam dolorum ipsum assumenda et consectetur aut.", "6be48c54-e679-4ec1-9c83-c4fe60b63535" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 21, 52, 476, DateTimeKind.Local), "Alias ut ea.", "6739075a-d110-47dd-aa10-e77085b38762" });

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
        }
    }
}
