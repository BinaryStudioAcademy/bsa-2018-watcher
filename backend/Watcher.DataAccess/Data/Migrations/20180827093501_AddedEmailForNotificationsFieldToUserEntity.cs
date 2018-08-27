using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedEmailForNotificationsFieldToUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0de4179a-3887-44e7-be81-cfce4a099114", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1122f684-9878-4102-bcc7-e10517b0702b", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2adade50-e5c5-4eca-bede-4db6f7d46d8b", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2d4eda0b-daed-441c-a106-e9c41c02d5f7", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3734c9ec-be2b-4d96-8d0f-11ede0414abc", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "39bd9adb-e2dd-4312-a766-87cedf8b16a6", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5786467e-41f6-4673-b24c-8ff9a42e81bd", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f6842948-5164-4056-b43f-7a58d1f4e924", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0de4179a-3887-44e7-be81-cfce4a099114");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1122f684-9878-4102-bcc7-e10517b0702b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2adade50-e5c5-4eca-bede-4db6f7d46d8b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2d4eda0b-daed-441c-a106-e9c41c02d5f7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3734c9ec-be2b-4d96-8d0f-11ede0414abc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39bd9adb-e2dd-4312-a766-87cedf8b16a6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5786467e-41f6-4673-b24c-8ff9a42e81bd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f6842948-5164-4056-b43f-7a58d1f4e924");

            migrationBuilder.AddColumn<string>(
                name: "EmailForNotifications",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Common2", "Source2", 16, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Common3", "Source2", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Source", "Threshold" },
                values: new object[] { "MostLoaded2", "Source2", 38 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 79, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common1", "Source3", 91, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded3", "Common2", 99, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source1", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", "Common2", "Source3", 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ShowCommon", "Threshold", "Type" },
                values: new object[] { "Common3", 92, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 65, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 37, 38, 527, DateTimeKind.Local), 83, "Title116" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 31, 18, 371, DateTimeKind.Local), 85, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 5, 15, 337, DateTimeKind.Local), 82, "Title644" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 29, 52, 955, DateTimeKind.Local), 86, "Title555" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 50, 791, DateTimeKind.Local), "Title29" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 1, 7, 847, DateTimeKind.Local), 86, "Title2" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 33, 40, 566, DateTimeKind.Local), 87, "Title446" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 12, 0, 45, 355, DateTimeKind.Local), 82, "Title98" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 54, 13, 125, DateTimeKind.Local), 86, "Title611" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 46, 47, 434, DateTimeKind.Local), 88, "Title443" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8b:73:29:8f:db:a4", 74, "Linux", "Instance830" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c8:9e:b5:4e:36:5a", 74, "Windows", "Instance333" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a4:4a:17:28:e7:6e", 78, "Instance856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Title" },
                values: new object[] { "29:25:96:ce:e7:f9", "Instance504" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "02:69:f0:71:ad:46", 71, "Instance828" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6c:36:05:00:c9:41", 74, "Linux", "Instance660" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "dc:cd:d5:d2:4e:a3", 71, "Windows", "Instance658" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "39:c7:6d:95:d1:3a", 74, "Linux", "Instance402" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "58:15:e2:d5:16:f3", 72, "Linux", "Instance483" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "9c:20:ed:67:68:35", 76, "Linux", "Instance21" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme519" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme419" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme141" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme712" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme102" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme35" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme23" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme796" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme878" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", null, new DateTime(2018, 8, 27, 7, 45, 59, 423, DateTimeKind.Local), "Talon", "Einar11@gmail.com", null, "Lily", true, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_scottburgess/128.jpg", 2 },
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", null, new DateTime(2018, 8, 27, 7, 34, 13, 456, DateTimeKind.Local), "Tiara", "Bret.Trantow46@hotmail.com", null, "Bessie", true, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarsen/128.jpg", 2 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", null, new DateTime(2018, 8, 27, 2, 37, 12, 614, DateTimeKind.Local), "Rowan", "Ellie.Kerluke@yahoo.com", null, "Cody", true, "Reinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cyril_gaillard/128.jpg", 1 },
                    { "97778277-833d-4bba-bc08-96216119b974", null, new DateTime(2018, 8, 26, 18, 16, 47, 561, DateTimeKind.Local), "Zula", "Jensen_Schmidt@hotmail.com", null, "Alexane", true, "Rosenbaum", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vicivadeline/128.jpg", 2 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", null, new DateTime(2018, 8, 27, 2, 59, 19, 669, DateTimeKind.Local), "Kian", "Mazie.Kassulke@yahoo.com", null, "Mikel", true, "Zulauf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/danro/128.jpg", 1 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", null, new DateTime(2018, 8, 26, 19, 49, 5, 288, DateTimeKind.Local), "Kamren", "Christy_Abshire3@yahoo.com", null, "Baby", true, "Quitzon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/a_brixen/128.jpg", 1 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", null, new DateTime(2018, 8, 27, 0, 34, 6, 531, DateTimeKind.Local), "Bret", "Gerry_Hermiston84@hotmail.com", null, "Sister", true, "Abernathy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ruzinav/128.jpg", 1 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", null, new DateTime(2018, 8, 26, 21, 43, 8, 409, DateTimeKind.Local), "Rachael", "Arvilla.Prosacco@hotmail.com", null, "Roxane", true, "Becker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", 2 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", null, new DateTime(2018, 8, 27, 12, 7, 6, 946, DateTimeKind.Local), "Amelia", "Koby_Fritsch@yahoo.com", null, "Edyth", true, "Johnston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/petrangr/128.jpg", 2 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", null, new DateTime(2018, 8, 27, 10, 15, 54, 80, DateTimeKind.Local), "Kevin", "Arlo_Paucek@yahoo.com", null, "Marie", true, "Kunde", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mhesslow/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "ratione" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", "eaque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "fuga" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 12, 55, 32, 550, DateTimeKind.Local), "Non laudantium et ipsum labore.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 51, 3, 229, DateTimeKind.Local), "Rerum reiciendis veritatis ut eum itaque.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 56, 8, 443, DateTimeKind.Local), "Inventore dolorum error vel.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 59, 31, 499, DateTimeKind.Local), "Voluptatem est ut sunt laborum.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 1, 12, 34, 73, DateTimeKind.Local), "Cupiditate et quasi.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 49, 9, 397, DateTimeKind.Local), "Culpa magnam voluptatem qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 49, 922, DateTimeKind.Local), "Nam nostrum nam pariatur sit libero incidunt architecto maiores odio.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 46, 21, 73, DateTimeKind.Local), "Sit deserunt dignissimos similique aut et rem ipsa maxime molestiae.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 0, 52, 10, 701, DateTimeKind.Local), "Sit voluptatum consequatur velit libero voluptas assumenda qui.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 7, 32, 41, 421, DateTimeKind.Local), "Et deserunt voluptatem ad earum sed laudantium nostrum et tempore.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 14, 45, 18, 135, DateTimeKind.Local), "Sint doloremque vero et est.", "d7c68027-7a0a-4b78-aef9-02781e94182c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 27, 11, 36, 52, 472, DateTimeKind.Local), "Laborum debitis consequatur laborum autem ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 26, 13, 32, 31, 447, DateTimeKind.Local), "Corrupti cupiditate ullam cumque modi est veniam sit.", "d274933f-0df6-4ce1-860f-29ba557430f5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 4, 16, 1, 104, DateTimeKind.Local), "Consectetur dignissimos quis sapiente ut consequatur repellendus temporibus.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 10, 4, 45, 818, DateTimeKind.Local), "Incidunt voluptates quia quae est.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 29, 49, 943, DateTimeKind.Local), "Natus neque omnis non fuga temporibus temporibus.", "d7c68027-7a0a-4b78-aef9-02781e94182c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 26, 18, 19, 57, 836, DateTimeKind.Local), "Aliquid laborum omnis est nisi maiores.", "3c66a652-9d95-41f8-b4e5-431382d4ac14", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 26, 19, 4, 26, 492, DateTimeKind.Local), "Vero autem quis eos voluptas ut vitae assumenda qui omnis.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 27, 2, 59, 46, 17, DateTimeKind.Local), "Nesciunt repellat itaque.", "11d76c7c-c316-4694-80a0-8bc2810e1224", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 39, 15, 577, DateTimeKind.Local), "Natus impedit ut hic non sed animi libero voluptas.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 4, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 10, 12, 34, 962, DateTimeKind.Local), 18, "Error dicta cumque provident aliquam ea facilis nulla a.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 4, 22, 374, DateTimeKind.Local), 12, "Saepe ut veritatis vero voluptas veritatis porro magnam dolorem.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 39, 19, 508, DateTimeKind.Local), 18, "Quasi id assumenda.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 26, 37, 346, DateTimeKind.Local), 15, "Non pariatur repudiandae accusantium a optio.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 27, 5, 60, DateTimeKind.Local), 18, "Facere ratione numquam.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 53, 44, 582, DateTimeKind.Local), 13, "Dolor consequatur nisi impedit culpa id enim.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 17, 31, 229, DateTimeKind.Local), "Voluptates architecto vel laudantium et.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 57, 36, 277, DateTimeKind.Local), 13, "Aperiam ut ratione voluptas illum dolor nihil veritatis.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 42, 0, 62, DateTimeKind.Local), 17, "Accusantium sequi ea.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 45, 40, 294, DateTimeKind.Local), 14, "Aut rerum temporibus qui dolores delectus maiores qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "886-531-6165", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "", "Frankie_Cronin@hotmail.com", "Company911", 67, "https://donavon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-728-358-7494", "b09e040a-1384-4abb-bcb5-e32a9e812f40", "Repudiandae quibusdam voluptas ducimus et saepe expedita officiis. Rerum enim harum eveniet voluptas facilis iure sit id. Alias et culpa ut ipsum vero maxime qui pariatur. Dolorum praesentium nesciunt autem omnis qui quas corrupti aut.", "Elissa30@yahoo.com", "Company729", 64, "http://reuben.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(392) 738-6543 x801", "d274933f-0df6-4ce1-860f-29ba557430f5", "Voluptas ut fugit eos. Non cum et fugiat laboriosam architecto eos minima modi placeat.", "Norwood_Toy@yahoo.com", "Company170", 67, "https://cathryn.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "203.427.7650 x425", "d7c68027-7a0a-4b78-aef9-02781e94182c", "", "Jeramy39@gmail.com", "Company477", "https://reba.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(975) 209-1443 x7854", "11d76c7c-c316-4694-80a0-8bc2810e1224", "", "Frederick.Rohan@yahoo.com", "Company259", "https://alfredo.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "642-390-8585 x32466", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "Saepe nulla recusandae est voluptatem voluptatum ut. Facilis sit eius facere. Libero et qui corporis repudiandae incidunt necessitatibus.", "Erling13@yahoo.com", "Company50", 69, "https://hildegard.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "991-647-8137 x5828", "5504b109-e452-447b-97d1-a4812ac6e83e", "Sequi omnis in id. Doloremque eum voluptatem. Placeat voluptas fugiat.", "Gregorio_Corkery17@yahoo.com", "Company462", "https://braxton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "470.671.3040 x87959", "5504b109-e452-447b-97d1-a4812ac6e83e", "", "Vinnie22@gmail.com", "Company676", 61, "http://jedediah.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "929-277-5624 x6081", "3c66a652-9d95-41f8-b4e5-431382d4ac14", "Ea vitae nihil assumenda accusamus harum aut vel eaque. Possimus quidem facilis excepturi earum assumenda amet reprehenderit natus alias.", "Keagan50@gmail.com", "Company675", 68, "https://estevan.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "469-337-2948 x708", "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "", "Justine.Gulgowski@yahoo.com", "Company227", 65, "http://darrion.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 27, 5, 941, DateTimeKind.Local), 48, "Qui laboriosam possimus illum pariatur sint commodi quibusdam et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 50, 46, 373, DateTimeKind.Local), 50, "Sunt assumenda ducimus quidem natus provident incidunt similique.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 50, 33, 228, DateTimeKind.Local), 49, "Aspernatur quia praesentium in.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 54, 51, 426, DateTimeKind.Local), 41, "Error eum sit sunt tenetur unde.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 54, 7, 142, DateTimeKind.Local), 48, "Aliquam et occaecati ut delectus optio nulla et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 36, 38, 14, DateTimeKind.Local), 50, "Voluptatem magni quo dolorum.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 7, 49, 234, DateTimeKind.Local), 45, "Eius sit voluptas ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 44, 53, 482, DateTimeKind.Local), 48, "Nobis perferendis sapiente labore corrupti in a quam cum eos.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 58, 34, 722, DateTimeKind.Local), 49, "Saepe magni qui quia error sed id sit quibusdam.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 41, 33, 429, DateTimeKind.Local), 48, "Et distinctio magnam explicabo eius quaerat ut.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 },
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 },
                    { "97778277-833d-4bba-bc08-96216119b974", 71 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", 78 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8486e755-b481-4eff-be21-9d95556987d1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "97778277-833d-4bba-bc08-96216119b974", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11d76c7c-c316-4694-80a0-8bc2810e1224");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3c66a652-9d95-41f8-b4e5-431382d4ac14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48fd27a3-127f-4da8-a8e7-8f46e1d41bba");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5504b109-e452-447b-97d1-a4812ac6e83e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8486e755-b481-4eff-be21-9d95556987d1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "97778277-833d-4bba-bc08-96216119b974");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b09e040a-1384-4abb-bcb5-e32a9e812f40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c92ca16a-d03a-4f48-857d-4ded5fe4735e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d274933f-0df6-4ce1-860f-29ba557430f5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d7c68027-7a0a-4b78-aef9-02781e94182c");

            migrationBuilder.DropColumn(
                name: "EmailForNotifications",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded3", "Common3", "Source3", 38, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common2", "Source1", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Source", "Threshold" },
                values: new object[] { "MostLoaded3", "Source3", 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 83, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common2", "Source1", 72, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Common1", 21, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded1", "Common3", "Source2", 64, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", "Common3", "Source1", 67, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ShowCommon", "Threshold", "Type" },
                values: new object[] { "Common1", 25, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 94, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 10, 52, 26, 450, DateTimeKind.Local), 82, "Title332" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 6, 14, 990, DateTimeKind.Local), 90, "Title701" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 21, 16, 191, DateTimeKind.Local), 85, "Title288" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 7, 33, 56, 355, DateTimeKind.Local), 90, "Title490" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 4, 18, 918, DateTimeKind.Local), "Title191" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 7, 33, 2, 753, DateTimeKind.Local), 88, "Title174" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 13, 44, 46, 300, DateTimeKind.Local), 81, "Title308" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 10, 33, 28, 935, DateTimeKind.Local), 86, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 11, 9, 56, 745, DateTimeKind.Local), 90, "Title128" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 14, 30, 28, 677, DateTimeKind.Local), 87, "Title750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1c:48:5b:f2:92:1e", 76, "Windows", "Instance716" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c2:5e:1f:30:63:a1", 75, "Linux", "Instance691" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b9:5b:af:6e:aa:b7", 79, "Instance979" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Title" },
                values: new object[] { "08:8a:e7:e3:6a:f7", "Instance396" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b6:0b:ce:74:73:92", 80, "Instance516" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "12:46:0b:be:2b:c0", 76, "Windows", "Instance311" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "44:94:23:79:20:38", 75, "Linux", "Instance283" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "72:c8:e6:20:42:ad", 76, "Windows", "Instance772" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c7:60:ac:f7:25:c2", 75, "Windows", "Instance979" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5d:42:69:a8:95:21", 80, "Windows", "Instance720" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme689" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme545" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme404" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme894" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme957" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme547" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme239" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme521" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme850" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme165" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "2adade50-e5c5-4eca-bede-4db6f7d46d8b", null, new DateTime(2018, 8, 22, 1, 4, 25, 979, DateTimeKind.Local), "Arely", "Cayla_Douglas@gmail.com", "Jedediah", true, "Stark", null, null, 2 },
                    { "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", null, new DateTime(2018, 8, 22, 10, 52, 18, 990, DateTimeKind.Local), "Sammy", "Carmela.Stehr@yahoo.com", "Odell", true, "Bergstrom", null, null, 2 },
                    { "1122f684-9878-4102-bcc7-e10517b0702b", null, new DateTime(2018, 8, 22, 9, 37, 12, 374, DateTimeKind.Local), "Benton", "Dakota_Gottlieb29@gmail.com", "Marisol", true, "Windler", null, null, 2 },
                    { "2d4eda0b-daed-441c-a106-e9c41c02d5f7", null, new DateTime(2018, 8, 22, 3, 1, 59, 128, DateTimeKind.Local), "Marina", "Jessica_Jones16@gmail.com", "Alf", true, "Considine", null, null, 2 },
                    { "5786467e-41f6-4673-b24c-8ff9a42e81bd", null, new DateTime(2018, 8, 22, 5, 58, 22, 344, DateTimeKind.Local), "Frankie", "Nikki_Hammes@hotmail.com", "Eric", true, "Mertz", null, null, 1 },
                    { "39bd9adb-e2dd-4312-a766-87cedf8b16a6", null, new DateTime(2018, 8, 21, 22, 24, 40, 803, DateTimeKind.Local), "Darryl", "Nasir_Schmitt42@yahoo.com", "Baron", true, "Dibbert", null, null, 2 },
                    { "f6842948-5164-4056-b43f-7a58d1f4e924", null, new DateTime(2018, 8, 22, 2, 11, 30, 447, DateTimeKind.Local), "Muhammad", "Christopher.Hudson@hotmail.com", "Flavio", true, "Torphy", null, null, 1 },
                    { "0de4179a-3887-44e7-be81-cfce4a099114", null, new DateTime(2018, 8, 22, 5, 23, 8, 307, DateTimeKind.Local), "Casimer", "Johnpaul_Vandervort@yahoo.com", "Annamae", true, "Bartell", null, null, 1 },
                    { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", null, new DateTime(2018, 8, 22, 1, 28, 34, 966, DateTimeKind.Local), "Dovie", "Veronica_Kilback@hotmail.com", "Manuel", true, "Stamm", null, null, 1 },
                    { "3734c9ec-be2b-4d96-8d0f-11ede0414abc", null, new DateTime(2018, 8, 22, 2, 39, 28, 718, DateTimeKind.Local), "Raegan", "Vladimir_Quigley@hotmail.com", "Sherwood", true, "Ritchie", null, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3734c9ec-be2b-4d96-8d0f-11ede0414abc", "dolores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2d4eda0b-daed-441c-a106-e9c41c02d5f7", "reprehenderit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0de4179a-3887-44e7-be81-cfce4a099114", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", "recusandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5786467e-41f6-4673-b24c-8ff9a42e81bd", "eius" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0de4179a-3887-44e7-be81-cfce4a099114", "laborum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5786467e-41f6-4673-b24c-8ff9a42e81bd", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5786467e-41f6-4673-b24c-8ff9a42e81bd", "minima" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 12, 58, 43, 333, DateTimeKind.Local), "Est adipisci et et laborum distinctio ea est.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 15, 28, 40, 788, DateTimeKind.Local), "Doloremque repudiandae non.", "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 16, 39, 45, 951, DateTimeKind.Local), "Laudantium ullam et.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 23, 29, 10, 769, DateTimeKind.Local), "Velit expedita eius aut aperiam et.", "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 4, 15, 24, 495, DateTimeKind.Local), "Doloribus dolorem id consequatur in.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 16, 17, 44, 870, DateTimeKind.Local), "Inventore earum quis eum laboriosam excepturi enim.", "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 6, 58, 20, 889, DateTimeKind.Local), "Et quia laboriosam ut et possimus maxime labore aut.", "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 22, 27, 33, 567, DateTimeKind.Local), "Nostrum odio numquam eligendi eaque.", "2d4eda0b-daed-441c-a106-e9c41c02d5f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 2, 6, 39, 98, DateTimeKind.Local), "In est atque id.", "2adade50-e5c5-4eca-bede-4db6f7d46d8b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 4, 32, 53, 21, DateTimeKind.Local), "Et architecto ratione et aut dolor deserunt ab.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 21, 20, 34, 59, 376, DateTimeKind.Local), "Ducimus ut nesciunt consequatur explicabo vel vitae.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 22, 8, 21, 52, 419, DateTimeKind.Local), "Quia nihil qui omnis sed.", "f6842948-5164-4056-b43f-7a58d1f4e924", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 22, 13, 52, 14, 850, DateTimeKind.Local), "Adipisci accusamus similique atque explicabo fugit.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 22, 8, 52, 52, 911, DateTimeKind.Local), "A est non nihil laudantium eaque.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 21, 16, 36, 14, 460, DateTimeKind.Local), "Itaque quos perferendis est.", "2adade50-e5c5-4eca-bede-4db6f7d46d8b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 22, 11, 6, 30, 595, DateTimeKind.Local), "Velit dolorem inventore nihil nostrum quibusdam laborum quis delectus earum.", "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 21, 22, 23, 51, 954, DateTimeKind.Local), "Illo occaecati quasi et.", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 21, 20, 58, 59, 893, DateTimeKind.Local), "Ipsa non architecto totam quis tenetur.", "2adade50-e5c5-4eca-bede-4db6f7d46d8b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 22, 0, 22, 49, 987, DateTimeKind.Local), "Dolores deserunt modi.", "1122f684-9878-4102-bcc7-e10517b0702b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 0, 17, 37, 284, DateTimeKind.Local), "Ut tempora non eveniet rerum.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "1122f684-9878-4102-bcc7-e10517b0702b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "f6842948-5164-4056-b43f-7a58d1f4e924" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 2, 31, 39, 124, DateTimeKind.Local), 11, "Excepturi rem sed sed sit.", "5786467e-41f6-4673-b24c-8ff9a42e81bd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 9, 10, 607, DateTimeKind.Local), 15, "Non aut aliquid neque et rerum assumenda.", "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 13, 9, 22, 926, DateTimeKind.Local), 11, "Qui cum est occaecati rerum perferendis aut.", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 13, 13, 20, 736, DateTimeKind.Local), 14, "Id hic quia est dolor occaecati facere.", "2adade50-e5c5-4eca-bede-4db6f7d46d8b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 12, 19, 23, 298, DateTimeKind.Local), 17, "Et nobis ut eveniet accusantium maiores dolores amet aliquam.", "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 16, 33, 18, 222, DateTimeKind.Local), 14, "Fugiat cumque sit quia alias laudantium aliquid recusandae non.", "1122f684-9878-4102-bcc7-e10517b0702b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 14, 19, 44, 968, DateTimeKind.Local), "Magni assumenda dolore ipsum quidem eum ipsum rerum quia.", "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 4, 15, 13, 844, DateTimeKind.Local), 12, "Consequuntur repellat reiciendis possimus consequatur a veniam praesentium itaque voluptatum.", "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 56, 15, 8, DateTimeKind.Local), 20, "Aut officiis aut eligendi qui et consectetur.", "2d4eda0b-daed-441c-a106-e9c41c02d5f7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 11, 3, 29, 322, DateTimeKind.Local), 17, "Provident qui dolores.", "f6842948-5164-4056-b43f-7a58d1f4e924" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(969) 842-0987 x487", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", "Eos ea odit non ut omnis numquam aut. Minus id ex quia accusantium.", "Demarco_Wintheiser0@gmail.com", "Company602", 70, "https://gerda.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-282-854-1766 x80666", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", "Est recusandae optio debitis. Repellendus sit adipisci accusamus nisi distinctio sint quidem.", "Brandon_Bernhard@hotmail.com", "Company136", 67, "https://serena.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(451) 443-9529 x203", "5786467e-41f6-4673-b24c-8ff9a42e81bd", "", "Eduardo.Koepp@gmail.com", "Company996", 61, "https://brent.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "940.756.2406", "2adade50-e5c5-4eca-bede-4db6f7d46d8b", "Voluptatem officia aspernatur sapiente nihil porro dolor voluptates dolore maiores. Animi nihil est doloremque totam dolorem. Natus voluptas reiciendis.", "Davonte.Anderson@yahoo.com", "Company632", "http://ryleigh.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(495) 753-0519", "1122f684-9878-4102-bcc7-e10517b0702b", "Consequatur tenetur in possimus facilis voluptatibus ab aliquid sint.", "Michele57@hotmail.com", "Company856", "http://hershel.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-525-622-4806", "2d4eda0b-daed-441c-a106-e9c41c02d5f7", "Omnis accusamus quia molestiae dignissimos autem id. Aut ipsa tempore nisi nam. Placeat qui praesentium ea dolor. Sint est adipisci sed.", "Abdiel_Harris56@hotmail.com", "Company241", 65, "http://lyric.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-760-213-3899 x956", "f6842948-5164-4056-b43f-7a58d1f4e924", "Praesentium quisquam qui sequi cum quia in. Culpa quas quo.", "Freida.Mills@yahoo.com", "Company795", "http://dax.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "434-858-5899 x15707", "f6842948-5164-4056-b43f-7a58d1f4e924", "Dicta vitae perspiciatis ad.", "Anita71@gmail.com", "Company68", 69, "http://josefina.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "981.857.9064 x9559", "39bd9adb-e2dd-4312-a766-87cedf8b16a6", "Sed velit iusto laborum non culpa a quas sed. Sapiente eum laboriosam ut cum velit reiciendis delectus velit ut.", "Shayna_Emard@yahoo.com", "Company814", 70, "http://twila.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-715-392-3836 x6756", "39bd9adb-e2dd-4312-a766-87cedf8b16a6", "Qui error dolorum dolor non dolore ut facilis sunt. Minima qui et et non earum inventore nam cumque veritatis.", "Demario_Zieme@yahoo.com", "Company552", 67, "http://xavier.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 0, 44, 29, 477, DateTimeKind.Local), 42, "Excepturi nulla et neque provident officia aut id.", "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 0, 11, 39, 569, DateTimeKind.Local), 42, "Rem similique cum harum odio ipsa est id.", "f6842948-5164-4056-b43f-7a58d1f4e924" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 23, 7, 34, 577, DateTimeKind.Local), 43, "Dolorem eum atque odio ratione cumque iure quisquam.", "2d4eda0b-daed-441c-a106-e9c41c02d5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 6, 54, 24, 170, DateTimeKind.Local), 50, "Neque labore beatae saepe qui vero.", "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 21, 57, 41, 979, DateTimeKind.Local), 41, "Tempore laboriosam et perspiciatis voluptatem aut.", "2d4eda0b-daed-441c-a106-e9c41c02d5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 6, 36, 385, DateTimeKind.Local), 44, "Qui iure asperiores cumque aut similique officia tenetur praesentium dignissimos.", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 22, 53, 769, DateTimeKind.Local), 43, "Totam sed delectus fugiat.", "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 1, 59, 16, 92, DateTimeKind.Local), 44, "Omnis quod nesciunt qui aut.", "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 5, 46, 2, 712, DateTimeKind.Local), 45, "Ut voluptatem sit placeat omnis et autem temporibus nesciunt ut.", "2d4eda0b-daed-441c-a106-e9c41c02d5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 17, 55, 25, 637, DateTimeKind.Local), 43, "Excepturi aut incidunt beatae hic ipsa.", "5786467e-41f6-4673-b24c-8ff9a42e81bd" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "2d4eda0b-daed-441c-a106-e9c41c02d5f7", 74 },
                    { "5786467e-41f6-4673-b24c-8ff9a42e81bd", 74 },
                    { "985b0227-2f4e-4cd3-a4c5-a016e5b05fd8", 73 },
                    { "39bd9adb-e2dd-4312-a766-87cedf8b16a6", 79 },
                    { "1122f684-9878-4102-bcc7-e10517b0702b", 71 },
                    { "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8", 72 },
                    { "f6842948-5164-4056-b43f-7a58d1f4e924", 77 },
                    { "2adade50-e5c5-4eca-bede-4db6f7d46d8b", 75 },
                    { "0de4179a-3887-44e7-be81-cfce4a099114", 76 },
                    { "3734c9ec-be2b-4d96-8d0f-11ede0414abc", 72 }
                });
        }
    }
}
