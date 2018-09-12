using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class InstanceGuidInNotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Instances_InstanceId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_InstanceId",
                table: "Notifications");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0840ac69-7999-487c-a61c-99073e9b99e0", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "32185bec-5623-463d-9d32-dff833189c31", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "378606ac-b59f-4b1d-94d0-500f2ddaac9f", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "53f8c5f0-26a6-4746-b58e-df09b0f95f5f", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6d11d143-9820-43e6-b3cc-745bfdd18061", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8abc3436-3ce4-4d66-9985-cf207393656d", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8da92424-ba3f-4126-bb43-2810fc99abef", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a70677ea-748f-4259-8068-598460f07e86", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b76bdc42-3b4a-4f8c-9991-b99831c10236", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fba67b9e-b7b0-415f-b131-ac022c311ddd", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0840ac69-7999-487c-a61c-99073e9b99e0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32185bec-5623-463d-9d32-dff833189c31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "378606ac-b59f-4b1d-94d0-500f2ddaac9f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53f8c5f0-26a6-4746-b58e-df09b0f95f5f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6d11d143-9820-43e6-b3cc-745bfdd18061");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8abc3436-3ce4-4d66-9985-cf207393656d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8da92424-ba3f-4126-bb43-2810fc99abef");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a70677ea-748f-4259-8068-598460f07e86");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b76bdc42-3b4a-4f8c-9991-b99831c10236");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fba67b9e-b7b0-415f-b131-ac022c311ddd");

            migrationBuilder.AddColumn<Guid>(
                name: "InstanceGuidId",
                table: "Notifications",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 92, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 8 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 46 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 69, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 98 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 39, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 100, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 17, 43, 317, DateTimeKind.Local), 89, "Title611" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 6, 21, 167, DateTimeKind.Local), 87, "Title271" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 25, 41, 605, DateTimeKind.Local), 90, "Title795" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 50, 58, 122, DateTimeKind.Local), 86, "Title953" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 11, 44, 262, DateTimeKind.Local), 88, "Title598" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 21, 18, 214, DateTimeKind.Local), 85, "Title64" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 9, 12, 737, DateTimeKind.Local), 89, "Title255" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 5, 50, 583, DateTimeKind.Local), 88, "Title900" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 2, 34, 510, DateTimeKind.Local), 88, "Title652" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 26, 39, 479, DateTimeKind.Local), 82, "Title500" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a0:6c:b6:e8:b4:c5", 71, "Linux", "Instance625" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "20:28:47:fd:00:60", 75, "Instance158" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "32:d8:e7:e2:75:22", "Windows", "Instance928" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0e:54:67:a5:f1:59", 77, "Linux", "Instance679" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b6:ed:23:32:97:9c", 80, "Linux", "Instance341" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "77:3b:f5:e8:39:c7", 76, "Linux", "Instance124" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b6:5b:63:87:48:cc", 78, "Linux", "Instance448" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b9:ab:27:80:01:45", 78, "Linux", "Instance46" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "39:15:90:52:2a:d2", 74, "Linux", "Instance294" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Title" },
                values: new object[] { "d3:d3:48:c4:b6:5a", "Instance420" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme826" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme251" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme159" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme531" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme664" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme283" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme94" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme770" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme402" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme932" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "38b090b8-5212-4be8-8271-107f26f0137b", null, new DateTime(2018, 9, 11, 12, 42, 29, 445, DateTimeKind.Local), "Angeline", "Mireya_Williamson@yahoo.com", null, "Katrina", true, false, "Zboncak", null, "https://s3.amazonaws.com/uifaces/faces/twitter/saschadroste/128.jpg", 2 },
                    { "bedb5749-96a4-4e19-9c54-fe32499e9fa8", null, new DateTime(2018, 9, 11, 4, 39, 53, 274, DateTimeKind.Local), "Autumn", "Erika_Brown5@yahoo.com", null, "Xander", true, false, "Marks", null, "https://s3.amazonaws.com/uifaces/faces/twitter/andrea211087/128.jpg", 2 },
                    { "ca176e61-f550-4e6e-a6a9-b69ba461f707", null, new DateTime(2018, 9, 11, 12, 7, 39, 673, DateTimeKind.Local), "Isaac", "Janessa.Romaguera@gmail.com", null, "Cora", true, false, "Heathcote", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kurafire/128.jpg", 1 },
                    { "6b2e411e-c208-4c9a-b571-7c1824a2c621", null, new DateTime(2018, 9, 11, 17, 55, 15, 257, DateTimeKind.Local), "Jose", "Prince.Weber@gmail.com", null, "Felicita", true, false, "Macejkovic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/zauerkraut/128.jpg", 1 },
                    { "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", null, new DateTime(2018, 9, 11, 12, 35, 47, 475, DateTimeKind.Local), "Bonita", "Stacy.Ankunding@gmail.com", null, "Quinton", true, false, "Flatley", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cicerobr/128.jpg", 2 },
                    { "8b970bea-dde1-410a-9e85-a46d31bd73a3", null, new DateTime(2018, 9, 11, 4, 50, 22, 331, DateTimeKind.Local), "Amelie", "Magnus64@gmail.com", null, "Brian", true, false, "Steuber", null, "https://s3.amazonaws.com/uifaces/faces/twitter/thierrykoblentz/128.jpg", 2 },
                    { "790dbe85-4e53-4302-9a95-3df7ac88f84f", null, new DateTime(2018, 9, 11, 15, 46, 9, 117, DateTimeKind.Local), "Roslyn", "Addison.Tillman@hotmail.com", null, "Johnson", true, false, "Rodriguez", null, "https://s3.amazonaws.com/uifaces/faces/twitter/janpalounek/128.jpg", 2 },
                    { "9557c516-6909-4918-ad95-d8476651c115", null, new DateTime(2018, 9, 11, 1, 31, 2, 656, DateTimeKind.Local), "Collin", "Jana_Steuber@gmail.com", null, "Roxane", true, false, "Lind", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ah_lice/128.jpg", 2 },
                    { "91427d15-02cf-4321-91a4-ee64f69d18d9", null, new DateTime(2018, 9, 11, 18, 31, 58, 577, DateTimeKind.Local), "Maida", "Judy.Goodwin@gmail.com", null, "Kailee", true, false, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/michaelcomiskey/128.jpg", 2 },
                    { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", null, new DateTime(2018, 9, 11, 7, 34, 21, 462, DateTimeKind.Local), "Garry", "Ashlee_Abshire@gmail.com", null, "Dejah", true, false, "Renner", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ripplemdk/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ca176e61-f550-4e6e-a6a9-b69ba461f707", "nostrum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bedb5749-96a4-4e19-9c54-fe32499e9fa8", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", "dicta" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ca176e61-f550-4e6e-a6a9-b69ba461f707", "omnis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "790dbe85-4e53-4302-9a95-3df7ac88f84f", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", "iusto" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", "saepe" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ca176e61-f550-4e6e-a6a9-b69ba461f707", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", "praesentium" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 16, 9, 753, DateTimeKind.Local), "Repudiandae illo totam eum.", "6b2e411e-c208-4c9a-b571-7c1824a2c621" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 5, 30, 436, DateTimeKind.Local), "Iure soluta aperiam dolorum sint quis.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 26, 29, 807, DateTimeKind.Local), "Eum delectus molestiae ad aspernatur consequatur.", "9557c516-6909-4918-ad95-d8476651c115" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 43, 31, 707, DateTimeKind.Local), "Enim qui deserunt accusantium suscipit.", "9557c516-6909-4918-ad95-d8476651c115" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 55, 28, 545, DateTimeKind.Local), "Aliquid consequatur sit quia iusto qui provident.", "91427d15-02cf-4321-91a4-ee64f69d18d9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 32, 5, 677, DateTimeKind.Local), "Esse iure voluptas et quam quibusdam ut quia.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 24, 59, 304, DateTimeKind.Local), "Aut aut nobis.", "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 28, 0, 552, DateTimeKind.Local), "Labore eveniet commodi nisi ab saepe.", "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 22, 14, 663, DateTimeKind.Local), "Quidem dolore qui dolorem qui molestias ut architecto a.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 12, 59, 37, DateTimeKind.Local), "Est quibusdam illo.", "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 4, 34, 0, 647, DateTimeKind.Local), "Et sunt ullam qui libero provident.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 1, 13, 2, 708, DateTimeKind.Local), "Eum omnis et fugiat libero voluptates voluptates.", "91427d15-02cf-4321-91a4-ee64f69d18d9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 4, 39, 50, 963, DateTimeKind.Local), "Voluptas omnis aliquid.", "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 13, 51, 879, DateTimeKind.Local), "Ut ducimus et eum optio autem tempore quam quam dolor.", "91427d15-02cf-4321-91a4-ee64f69d18d9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 20, 52, 37, 820, DateTimeKind.Local), "Aut architecto inventore voluptatem repudiandae nemo ducimus est.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 1, 19, 42, 702, DateTimeKind.Local), "Ipsam sed vero quia iste soluta voluptatem eum molestiae cupiditate.", "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 6, 3, 4, 785, DateTimeKind.Local), "Cumque voluptas voluptas illo occaecati saepe rem.", "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 14, 38, 59, 640, DateTimeKind.Local), "Qui quo non quia tempora qui assumenda odit.", "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 6, 9, 7, 195, DateTimeKind.Local), "Atque ad a omnis sint.", "91427d15-02cf-4321-91a4-ee64f69d18d9", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 20, 35, 453, DateTimeKind.Local), "Aliquam modi esse qui consequatur nulla laborum dolor voluptas nihil.", "6b2e411e-c208-4c9a-b571-7c1824a2c621", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 4, "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "ca176e61-f550-4e6e-a6a9-b69ba461f707" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, true, "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 3, "9557c516-6909-4918-ad95-d8476651c115" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 0, 3, 814, DateTimeKind.Local), 12, "Autem vel id cumque sapiente quo explicabo quaerat.", "6b2e411e-c208-4c9a-b571-7c1824a2c621" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 20, 11, 250, DateTimeKind.Local), 13, "Eveniet aut blanditiis delectus a ab.", "6b2e411e-c208-4c9a-b571-7c1824a2c621" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 36, 58, 358, DateTimeKind.Local), 19, "Asperiores voluptatem beatae.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 46, 36, 788, DateTimeKind.Local), 13, "Aliquam quod vero.", "6b2e411e-c208-4c9a-b571-7c1824a2c621" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 8, 47, 102, DateTimeKind.Local), 14, "Quia impedit qui tenetur nesciunt sapiente consequuntur soluta eveniet.", "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 46, 27, 562, DateTimeKind.Local), 17, "Ea aperiam distinctio quaerat.", "8b970bea-dde1-410a-9e85-a46d31bd73a3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 35, 40, 362, DateTimeKind.Local), 19, "Laboriosam dolorum recusandae aut incidunt sequi deserunt mollitia ad.", "8b970bea-dde1-410a-9e85-a46d31bd73a3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 33, 50, 531, DateTimeKind.Local), 16, "Voluptas dolore quia ullam amet quis doloribus ipsam.", "91427d15-02cf-4321-91a4-ee64f69d18d9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 2, 42, 555, DateTimeKind.Local), 19, "Et cumque eius beatae.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 34, 42, 656, DateTimeKind.Local), 17, "Consequatur dolor sunt quibusdam voluptas molestiae aut.", "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "629.535.2439 x84979", "790dbe85-4e53-4302-9a95-3df7ac88f84f", "Ducimus error qui quia nemo in. Quia et sit aut eum fugiat sed nemo omnis et. A est iure aut voluptate perferendis dolor.", "Carole.Spencer27@hotmail.com", "Company614", 67, "https://jake.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(877) 311-0545", "bedb5749-96a4-4e19-9c54-fe32499e9fa8", "Quia perferendis dicta explicabo. Sequi vel nisi libero molestiae molestias non. Modi aut harum eaque quia voluptate. Molestiae corporis dicta consequatur tempore fugit eius officiis maxime.", "Bernita_Altenwerth41@gmail.com", "Company476", 63, "https://pamela.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-677-939-0443 x112", "ca176e61-f550-4e6e-a6a9-b69ba461f707", "Porro quam qui itaque molestias mollitia iste optio perspiciatis cupiditate. Quis odit ut laboriosam minima. Ea reprehenderit porro qui quidem necessitatibus est dolore. Laboriosam fuga molestiae vero corporis qui veritatis et rerum.", "Tre_Ziemann@gmail.com", "Company962", 64, "https://nayeli.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "347-281-7056 x662", "38b090b8-5212-4be8-8271-107f26f0137b", "Est modi unde modi eaque accusantium veritatis necessitatibus at. Blanditiis est saepe dignissimos et quibusdam. Eveniet voluptates voluptatum ut velit natus maiores. Minima eos maxime quo quia eius cum aspernatur rem et.", "Alexa26@hotmail.com", "Company810", 65, "https://marlene.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "917-934-8265 x3713", "9557c516-6909-4918-ad95-d8476651c115", "", "Ashleigh.Collier@yahoo.com", "Company463", 63, "http://jamel.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "864.432.8894 x3652", "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", "Voluptatem eos et assumenda a eos doloremque animi debitis.", "Tyrell.McGlynn@yahoo.com", "Company778", 67, "http://jillian.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(443) 978-4987 x25982", "f5debfb9-dfc8-4f26-8583-7f91f2940f22", "A magnam consequatur similique sint non occaecati voluptatem delectus. Atque culpa quos assumenda repellat voluptates veniam assumenda. Nostrum est consequuntur modi sequi.", "Oscar10@gmail.com", "Company316", 67, "http://gene.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-449-507-1933 x92560", "91427d15-02cf-4321-91a4-ee64f69d18d9", "Velit fugiat accusantium pariatur harum. Iste esse enim rerum id. Dolores velit ad officiis sapiente maiores ipsam rerum suscipit culpa. Quasi consectetur sunt voluptatem voluptatem.", "Armand.VonRueden@gmail.com", "Company972", 65, "http://jerome.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(684) 702-1636 x67096", "6b2e411e-c208-4c9a-b571-7c1824a2c621", "Distinctio veritatis tenetur sed occaecati ut totam repudiandae ad perferendis. Laborum est eos.", "Blake.Boyer@yahoo.com", "Company417", 62, "http://manuela.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "751.241.1462 x3084", "91427d15-02cf-4321-91a4-ee64f69d18d9", "Numquam doloremque et similique est commodi rerum ab velit. Asperiores ullam sed quisquam voluptas amet sapiente consequuntur minus.", "Javon34@hotmail.com", "Company28", 68, "http://ezra.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 46, 3, 800, DateTimeKind.Local), 44, "Odio dolore ut.", "8b970bea-dde1-410a-9e85-a46d31bd73a3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 27, 35, 510, DateTimeKind.Local), 48, "Nostrum accusamus totam reprehenderit commodi quos autem modi.", "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 1, 14, 704, DateTimeKind.Local), 44, "Impedit tempora et fugiat accusantium est sit amet esse.", "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 52, 58, 653, DateTimeKind.Local), 48, "Animi autem excepturi est.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 13, 17, 977, DateTimeKind.Local), 46, "Consequuntur aut quidem.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 22, 6, 743, DateTimeKind.Local), 42, "Natus et veritatis quidem suscipit voluptatem quod debitis dolorem velit.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 27, 28, 847, DateTimeKind.Local), 48, "Minima omnis assumenda.", "bedb5749-96a4-4e19-9c54-fe32499e9fa8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 50, 35, 843, DateTimeKind.Local), 44, "Eos qui consequatur ipsum aut qui culpa quia.", "38b090b8-5212-4be8-8271-107f26f0137b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 12, 51, 880, DateTimeKind.Local), 49, "Qui et et qui.", "f5debfb9-dfc8-4f26-8583-7f91f2940f22" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 36, 18, 542, DateTimeKind.Local), 46, "Repudiandae est ea reiciendis veritatis culpa a nulla quia.", "790dbe85-4e53-4302-9a95-3df7ac88f84f" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "38b090b8-5212-4be8-8271-107f26f0137b", 77, 1 },
                    { "bedb5749-96a4-4e19-9c54-fe32499e9fa8", 79, 1 },
                    { "8b970bea-dde1-410a-9e85-a46d31bd73a3", 78, 1 },
                    { "ca176e61-f550-4e6e-a6a9-b69ba461f707", 75, 1 },
                    { "9557c516-6909-4918-ad95-d8476651c115", 79, 1 },
                    { "6b2e411e-c208-4c9a-b571-7c1824a2c621", 76, 1 },
                    { "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", 76, 1 },
                    { "790dbe85-4e53-4302-9a95-3df7ac88f84f", 74, 1 },
                    { "91427d15-02cf-4321-91a4-ee64f69d18d9", 72, 1 },
                    { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", 72, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "38b090b8-5212-4be8-8271-107f26f0137b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6b2e411e-c208-4c9a-b571-7c1824a2c621", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "790dbe85-4e53-4302-9a95-3df7ac88f84f", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8b970bea-dde1-410a-9e85-a46d31bd73a3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "91427d15-02cf-4321-91a4-ee64f69d18d9", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9557c516-6909-4918-ad95-d8476651c115", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bedb5749-96a4-4e19-9c54-fe32499e9fa8", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ca176e61-f550-4e6e-a6a9-b69ba461f707", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f5debfb9-dfc8-4f26-8583-7f91f2940f22", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38b090b8-5212-4be8-8271-107f26f0137b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6b2e411e-c208-4c9a-b571-7c1824a2c621");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "790dbe85-4e53-4302-9a95-3df7ac88f84f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b970bea-dde1-410a-9e85-a46d31bd73a3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "91427d15-02cf-4321-91a4-ee64f69d18d9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9557c516-6909-4918-ad95-d8476651c115");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bedb5749-96a4-4e19-9c54-fe32499e9fa8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c8c48ce7-7e59-4b3c-8eca-e262d1ede5b0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ca176e61-f550-4e6e-a6a9-b69ba461f707");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f5debfb9-dfc8-4f26-8583-7f91f2940f22");

            migrationBuilder.DropColumn(
                name: "InstanceGuidId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 30, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 35, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 42, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 95, 58 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 98, 65 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 19, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 82, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 66 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 71, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 36, 10, 318, DateTimeKind.Local), 88, "Title67" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 2, 0, 709, DateTimeKind.Local), 86, "Title84" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 18, 27, 398, DateTimeKind.Local), 83, "Title523" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 33, 31, 501, DateTimeKind.Local), 82, "Title169" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 13, 42, 14, 298, DateTimeKind.Local), 85, "Title983" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 17, 12, 2, 691, DateTimeKind.Local), 84, "Title632" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 6, 17, 936, DateTimeKind.Local), 88, "Title100" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 0, 58, 198, DateTimeKind.Local), 87, "Title310" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 45, 59, 961, DateTimeKind.Local), 81, "Title710" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 24, 13, 591, DateTimeKind.Local), 88, "Title949" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "33:90:26:f1:8e:38", 80, "Windows", "Instance201" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "60:4b:27:ad:d2:ee", 74, "Instance778" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "a9:31:38:ea:75:a2", "Linux", "Instance432" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5f:d6:f4:11:a6:71", 74, "Windows", "Instance42" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4c:9f:dc:e2:66:7c", 71, "Windows", "Instance189" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ed:41:fb:d8:42:02", 74, "Windows", "Instance553" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2f:af:16:2c:d3:89", 74, "Windows", "Instance480" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8f:5a:56:bf:0e:09", 74, "Windows", "Instance29" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a0:9a:ad:8f:ad:1e", 79, "Windows", "Instance517" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "Title" },
                values: new object[] { "1a:23:87:43:7f:9c", "Instance809" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme620" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme65" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme210" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme335" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme821" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme821" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme383" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme263" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme635" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme34" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "0840ac69-7999-487c-a61c-99073e9b99e0", null, new DateTime(2018, 9, 10, 22, 43, 28, 56, DateTimeKind.Local), "Domenic", "Cristian_Emmerich80@yahoo.com", null, "Cora", true, false, "Quitzon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/findingjenny/128.jpg", 1 },
                    { "fba67b9e-b7b0-415f-b131-ac022c311ddd", null, new DateTime(2018, 9, 10, 13, 50, 14, 287, DateTimeKind.Local), "Dillon", "Destin.Mante10@hotmail.com", null, "Tanner", true, false, "Pacocha", null, "https://s3.amazonaws.com/uifaces/faces/twitter/marosholly/128.jpg", 2 },
                    { "53f8c5f0-26a6-4746-b58e-df09b0f95f5f", null, new DateTime(2018, 9, 11, 10, 20, 57, 634, DateTimeKind.Local), "Trent", "Johnathon.Morissette4@hotmail.com", null, "Joesph", true, false, "O'Kon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ecommerceil/128.jpg", 1 },
                    { "32185bec-5623-463d-9d32-dff833189c31", null, new DateTime(2018, 9, 11, 6, 30, 16, 204, DateTimeKind.Local), "Jarrod", "Eduardo.Lubowitz@hotmail.com", null, "Elfrieda", true, false, "Stroman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kevinoh/128.jpg", 1 },
                    { "378606ac-b59f-4b1d-94d0-500f2ddaac9f", null, new DateTime(2018, 9, 11, 5, 21, 47, 78, DateTimeKind.Local), "Adolf", "Joan_Hoeger92@gmail.com", null, "Nicholas", true, false, "Wyman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sachacorazzi/128.jpg", 1 },
                    { "b76bdc42-3b4a-4f8c-9991-b99831c10236", null, new DateTime(2018, 9, 11, 0, 22, 16, 205, DateTimeKind.Local), "Scot", "Christop27@yahoo.com", null, "Kaylee", true, false, "Goyette", null, "https://s3.amazonaws.com/uifaces/faces/twitter/areus/128.jpg", 2 },
                    { "8da92424-ba3f-4126-bb43-2810fc99abef", null, new DateTime(2018, 9, 11, 5, 57, 48, 61, DateTimeKind.Local), "August", "Sarina_Lynch18@gmail.com", null, "Kane", true, false, "Howell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kosmar/128.jpg", 1 },
                    { "6d11d143-9820-43e6-b3cc-745bfdd18061", null, new DateTime(2018, 9, 10, 14, 23, 46, 159, DateTimeKind.Local), "Jerod", "Velda20@yahoo.com", null, "Reagan", true, false, "Kuphal", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vinciarts/128.jpg", 2 },
                    { "a70677ea-748f-4259-8068-598460f07e86", null, new DateTime(2018, 9, 11, 8, 27, 6, 451, DateTimeKind.Local), "Harmony", "Eugenia.Waelchi@gmail.com", null, "Thalia", true, false, "Paucek", null, "https://s3.amazonaws.com/uifaces/faces/twitter/faisalabid/128.jpg", 1 },
                    { "8abc3436-3ce4-4d66-9985-cf207393656d", null, new DateTime(2018, 9, 10, 16, 16, 0, 577, DateTimeKind.Local), "Halle", "Xavier98@yahoo.com", null, "Janick", true, false, "Renner", null, "https://s3.amazonaws.com/uifaces/faces/twitter/rickdt/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fba67b9e-b7b0-415f-b131-ac022c311ddd", "placeat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8da92424-ba3f-4126-bb43-2810fc99abef", "odio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fba67b9e-b7b0-415f-b131-ac022c311ddd", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a70677ea-748f-4259-8068-598460f07e86", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a70677ea-748f-4259-8068-598460f07e86", "molestiae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a70677ea-748f-4259-8068-598460f07e86", "quisquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "32185bec-5623-463d-9d32-dff833189c31", "consectetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6d11d143-9820-43e6-b3cc-745bfdd18061", "eius" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "378606ac-b59f-4b1d-94d0-500f2ddaac9f", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fba67b9e-b7b0-415f-b131-ac022c311ddd", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 28, 18, 396, DateTimeKind.Local), "Enim dignissimos quis odio consequatur adipisci autem similique omnis dolorum.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 59, 20, 732, DateTimeKind.Local), "Itaque laudantium tenetur in.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 8, 35, 267, DateTimeKind.Local), "Dicta et odit voluptatem dicta aut quo sit beatae.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 14, 22, 294, DateTimeKind.Local), "Dignissimos libero qui perspiciatis impedit exercitationem ut delectus.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 0, 43, 913, DateTimeKind.Local), "Fugit voluptas vero quia.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 58, 51, 585, DateTimeKind.Local), "Aliquam unde eum sed et excepturi laboriosam ab.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 18, 19, 613, DateTimeKind.Local), "Quae quos necessitatibus quo quibusdam.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 18, 22, 238, DateTimeKind.Local), "Et et minima aut facere rem laboriosam.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 49, 40, 245, DateTimeKind.Local), "Incidunt impedit et adipisci ea harum.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 47, 47, 915, DateTimeKind.Local), "Omnis rerum sed expedita.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 10, 48, 57, 739, DateTimeKind.Local), "Est quibusdam sunt enim.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 2, 18, 16, 90, DateTimeKind.Local), "Est est libero aut veniam et consequatur quia.", "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 7, 49, 40, 478, DateTimeKind.Local), "Qui nihil quae sit iste asperiores fugit quis.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 0, 35, 61, DateTimeKind.Local), "Ea accusamus voluptate nam perferendis veritatis minus enim aut aut.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 9, 55, 2, 905, DateTimeKind.Local), "Provident dicta ullam adipisci est ab.", "378606ac-b59f-4b1d-94d0-500f2ddaac9f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 6, 57, 45, 193, DateTimeKind.Local), "In voluptatem veniam doloremque autem labore voluptatem.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 3, 42, 35, 888, DateTimeKind.Local), "Qui voluptas est qui doloremque enim eum officiis.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 21, 33, 38, 910, DateTimeKind.Local), "Recusandae ut a non cumque quisquam dolor dolore.", "8abc3436-3ce4-4d66-9985-cf207393656d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 5, 49, 1, 478, DateTimeKind.Local), "Id reiciendis nesciunt.", "6d11d143-9820-43e6-b3cc-745bfdd18061", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 52, 32, 588, DateTimeKind.Local), "Pariatur ex quia mollitia fuga.", "0840ac69-7999-487c-a61c-99073e9b99e0", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 0, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, false, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 2, "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 0, "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "53f8c5f0-26a6-4746-b58e-df09b0f95f5f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 7, 32, 886, DateTimeKind.Local), 11, "Ut suscipit itaque neque voluptatibus vitae eius tempore officia.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 24, 49, 700, DateTimeKind.Local), 16, "Cupiditate quaerat dolorum nihil neque eum quia.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 7, 13, 676, DateTimeKind.Local), 18, "Cum magni corporis corporis.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 37, 30, 273, DateTimeKind.Local), 15, "Quis corporis nostrum impedit ullam dolore eum aut ut.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 13, 12, 759, DateTimeKind.Local), 13, "Magnam et facere.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 44, 55, 503, DateTimeKind.Local), 12, "Mollitia quis et accusantium facere dolor atque at.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 24, 23, 662, DateTimeKind.Local), 15, "Laborum commodi qui ad incidunt unde quia dolor sit.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 30, 54, 928, DateTimeKind.Local), 15, "Dolores aut nihil rerum omnis vel ea ut quasi.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 7, 0, 657, DateTimeKind.Local), 14, "A sint omnis reiciendis odit.", "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 16, 13, 265, DateTimeKind.Local), 13, "Nobis cupiditate ut occaecati vel eum aut quis explicabo.", "378606ac-b59f-4b1d-94d0-500f2ddaac9f" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-713-785-1075", "0840ac69-7999-487c-a61c-99073e9b99e0", "Molestias nihil alias omnis tempora rem. Tempore maxime debitis dolor dolores in blanditiis ab. Ipsum cumque sit sunt est qui enim.", "Orlo_Murray89@hotmail.com", "Company409", 65, "https://celestino.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "864-254-3846", "fba67b9e-b7b0-415f-b131-ac022c311ddd", "Deleniti expedita et dicta ex. Est omnis voluptatem alias laboriosam libero quod voluptatem. Alias qui nemo ut magnam amet voluptas cumque.", "Valentina87@yahoo.com", "Company558", 61, "https://ericka.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(859) 364-0869", "fba67b9e-b7b0-415f-b131-ac022c311ddd", "Quod quis incidunt voluptatem est. Quia quidem a est ab et inventore. Nihil eligendi praesentium provident officiis consequatur.", "Fiona_Koch@gmail.com", "Company739", 65, "https://gabe.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "523-902-1330", "8abc3436-3ce4-4d66-9985-cf207393656d", "", "Trycia_Moore86@hotmail.com", "Company175", 70, "http://alvera.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(484) 880-3058 x94404", "6d11d143-9820-43e6-b3cc-745bfdd18061", "Qui aspernatur consequuntur eius. Ipsa dignissimos fuga quam corrupti nemo molestiae cumque ut ipsum.", "Garry33@yahoo.com", "Company168", 64, "http://elvera.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "737.951.5206", "0840ac69-7999-487c-a61c-99073e9b99e0", "Qui vero et id consequatur beatae debitis officiis. Expedita sunt aperiam voluptatem adipisci praesentium amet at reprehenderit.", "Michaela73@yahoo.com", "Company32", 66, "http://ephraim.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-759-681-6704 x1398", "6d11d143-9820-43e6-b3cc-745bfdd18061", "Nisi cumque sit ea soluta sunt sint.", "Juanita.Daugherty@hotmail.com", "Company982", 62, "https://jace.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(650) 426-9178 x078", "0840ac69-7999-487c-a61c-99073e9b99e0", "", "Greta.Pollich@yahoo.com", "Company859", 69, "https://tristian.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "250.848.9012", "0840ac69-7999-487c-a61c-99073e9b99e0", "", "Cecilia_Nikolaus99@gmail.com", "Company123", 66, "http://corbin.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(988) 355-8036", "0840ac69-7999-487c-a61c-99073e9b99e0", "", "Rocky.Dickinson@gmail.com", "Company802", 64, "https://jessyca.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 58, 55, 656, DateTimeKind.Local), 45, "Exercitationem quaerat labore ad ipsa enim distinctio.", "53f8c5f0-26a6-4746-b58e-df09b0f95f5f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 17, 4, 34, 712, DateTimeKind.Local), 43, "Nam beatae qui similique quo ut sunt quia quam nihil.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 36, 20, 470, DateTimeKind.Local), 42, "Molestiae nemo placeat et porro officia suscipit.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 20, 23, 462, DateTimeKind.Local), 41, "Et porro iusto.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 10, 45, 336, DateTimeKind.Local), 45, "Reiciendis et similique quibusdam excepturi adipisci ab vero vitae qui.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 34, 46, 777, DateTimeKind.Local), 45, "Voluptatibus tempore sed alias.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 31, 10, 739, DateTimeKind.Local), 49, "Rerum et recusandae omnis corrupti ea harum eos sed.", "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 25, 15, 870, DateTimeKind.Local), 47, "Id aperiam consequuntur.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 25, 5, 153, DateTimeKind.Local), 41, "Quas sint est labore qui et qui quae ipsam.", "fba67b9e-b7b0-415f-b131-ac022c311ddd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 0, 46, 47, DateTimeKind.Local), 50, "Dolores perferendis itaque et sapiente nihil.", "53f8c5f0-26a6-4746-b58e-df09b0f95f5f" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "a70677ea-748f-4259-8068-598460f07e86", 75, 1 },
                    { "378606ac-b59f-4b1d-94d0-500f2ddaac9f", 73, 1 },
                    { "8da92424-ba3f-4126-bb43-2810fc99abef", 77, 1 },
                    { "b76bdc42-3b4a-4f8c-9991-b99831c10236", 75, 1 },
                    { "32185bec-5623-463d-9d32-dff833189c31", 79, 1 },
                    { "53f8c5f0-26a6-4746-b58e-df09b0f95f5f", 71, 1 },
                    { "fba67b9e-b7b0-415f-b131-ac022c311ddd", 77, 1 },
                    { "0840ac69-7999-487c-a61c-99073e9b99e0", 76, 1 },
                    { "6d11d143-9820-43e6-b3cc-745bfdd18061", 73, 1 },
                    { "8abc3436-3ce4-4d66-9985-cf207393656d", 72, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_InstanceId",
                table: "Notifications",
                column: "InstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Instances_InstanceId",
                table: "Notifications",
                column: "InstanceId",
                principalTable: "Instances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
