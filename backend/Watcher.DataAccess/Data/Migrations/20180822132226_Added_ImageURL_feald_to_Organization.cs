using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Added_ImageURL_feald_to_Organization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "69176035-4bb8-43e5-8a63-138d422223c3", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a0af6468-5fc7-47f4-a87d-71473658f8e6", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "06a6f2af-515c-4700-85e9-f1fdc8ad48da");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bd2330f-9ce1-4edb-859a-b854bf6c80fd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52d682db-3377-4f04-b118-9ee72fba6dca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5f18554c-a17d-43c9-b2f0-79a37c6ec81e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69176035-4bb8-43e5-8a63-138d422223c3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "783ab59c-34ee-47dc-be3d-9d0cc68361aa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "96235b10-9c99-4d76-8d35-454cbe4afd4b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a0af6468-5fc7-47f4-a87d-71473658f8e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eaba4a55-51f2-41fa-9fc7-2379e994cd1a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Organizations",
                nullable: true);

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
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 96, "Common1", 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", "Common1", 83, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Source1", 72, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 92, "MostLoaded1", "Source1", 21 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded1", "Common3", "Source2", 64 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", 67, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Common1", 25, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Source1", 94, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 10, 52, 26, 450, DateTimeKind.Local), "Title332" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 4, 18, 918, DateTimeKind.Local), 90, "Title191" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 22, 14, 30, 28, 677, DateTimeKind.Local), "Title750" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c2:5e:1f:30:63:a1", 75, "Instance691" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "08:8a:e7:e3:6a:f7", 72, "Linux", "Instance396" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b6:0b:ce:74:73:92", 80, "Linux", "Instance516" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "12:46:0b:be:2b:c0", 76, "Instance311" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "72:c8:e6:20:42:ad", 76, "Instance772" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5d:42:69:a8:95:21", 80, "Instance720" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme404" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme894" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Theme957");

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
                column: "Name",
                value: "Theme239");

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme850" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 22, 8, 21, 52, 419, DateTimeKind.Local), "Quia nihil qui omnis sed.", "f6842948-5164-4056-b43f-7a58d1f4e924" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 22, 13, 52, 14, 850, DateTimeKind.Local), "Adipisci accusamus similique atque explicabo fugit.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 22, 8, 52, 52, 911, DateTimeKind.Local), "A est non nihil laudantium eaque.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 21, 22, 23, 51, 954, DateTimeKind.Local), "Illo occaecati quasi et.", "ade726a5-8cf6-49aa-8b7c-64c05b1f10f8" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 22, 0, 22, 49, 987, DateTimeKind.Local), "Dolores deserunt modi.", "1122f684-9878-4102-bcc7-e10517b0702b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 22, 0, 17, 37, 284, DateTimeKind.Local), "Ut tempora non eveniet rerum.", "3734c9ec-be2b-4d96-8d0f-11ede0414abc", false });

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
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 4, "1122f684-9878-4102-bcc7-e10517b0702b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "3734c9ec-be2b-4d96-8d0f-11ede0414abc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 1, "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

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
                columns: new[] { "IsEmailable", "Type", "UserId" },
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
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 3, "0de4179a-3887-44e7-be81-cfce4a099114" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: "3734c9ec-be2b-4d96-8d0f-11ede0414abc");

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 22, 14, 19, 44, 968, DateTimeKind.Local), 11, "Magni assumenda dolore ipsum quidem eum ipsum rerum quia.", "39bd9adb-e2dd-4312-a766-87cedf8b16a6" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(451) 443-9529 x203", "5786467e-41f6-4673-b24c-8ff9a42e81bd", "Eduardo.Koepp@gmail.com", "Company996", 61, "https://brent.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "940.756.2406", "2adade50-e5c5-4eca-bede-4db6f7d46d8b", "Voluptatem officia aspernatur sapiente nihil porro dolor voluptates dolore maiores. Animi nihil est doloremque totam dolorem. Natus voluptas reiciendis.", "Davonte.Anderson@yahoo.com", "Company632", 70, "http://ryleigh.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(495) 753-0519", "1122f684-9878-4102-bcc7-e10517b0702b", "Consequatur tenetur in possimus facilis voluptatibus ab aliquid sint.", "Michele57@hotmail.com", "Company856", 67, "http://hershel.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-760-213-3899 x956", "f6842948-5164-4056-b43f-7a58d1f4e924", "Praesentium quisquam qui sequi cum quia in. Culpa quas quo.", "Freida.Mills@yahoo.com", "Company795", 65, "http://dax.info" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Organizations");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", "Common2", "Source1", 34, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common1", "Source2", 58, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 91, "Common2", 61 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded1", "Common2", 42, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Source2", 56, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 98, "MostLoaded3", "Source3", 25 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 96, "MostLoaded2", "Common1", "Source1", 32 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded2", 87, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", "Common2", 44, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Source3", 92, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 38, 55, 581, DateTimeKind.Local), "Title730" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 3, 53, 1, 571, DateTimeKind.Local), 87, "Title425" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 9, 4, 22, 256, DateTimeKind.Local), 84, "Title728" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 7, 6, 53, 604, DateTimeKind.Local), 83, "Title788" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 6, 16, 401, DateTimeKind.Local), 84, "Title724" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 31, 18, 610, DateTimeKind.Local), 83, "Title344" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 9, 34, 733, DateTimeKind.Local), 83, "Title298" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 17, 28, 29, 769, DateTimeKind.Local), 81, "Title266" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 13, 9, 31, 25, DateTimeKind.Local), 84, "Title278" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 33, 0, 943, DateTimeKind.Local), "Title497" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "82:9a:82:03:00:c6", 74, "Linux", "Instance899" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "dc:87:e3:4f:3f:14", 73, "Instance705" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:ac:78:74:88:ab", 76, "Instance789" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1d:6d:e5:aa:c4:96", 80, "Windows", "Instance61" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "21:e2:b3:d4:b2:c8", 77, "Windows", "Instance838" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e2:2b:33:8f:47:d6", 72, "Instance286" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "46:34:9e:f8:80:6f", 77, "Windows", "Instance477" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "25:28:90:ca:34:7d", 80, "Instance544" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "06:53:d8:46:d9:f1", 73, "Linux", "Instance758" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "74:e1:a2:81:b9:ed", 73, "Instance388" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme581" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme207" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme361" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme936" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Theme417");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme582" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme904");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme978" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme506" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme337" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "52d682db-3377-4f04-b118-9ee72fba6dca", null, new DateTime(2018, 8, 21, 13, 35, 32, 925, DateTimeKind.Local), "Lora", "Alisha.Abbott26@yahoo.com", "Christina", true, "D'Amore", null, null, 2 },
                    { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", null, new DateTime(2018, 8, 21, 9, 26, 57, 512, DateTimeKind.Local), "Nathaniel", "Simone_Batz56@hotmail.com", "Luz", true, "Douglas", null, null, 1 },
                    { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", null, new DateTime(2018, 8, 21, 9, 40, 25, 982, DateTimeKind.Local), "Hayley", "Brendan45@yahoo.com", "Elisa", true, "Heathcote", null, null, 2 },
                    { "96235b10-9c99-4d76-8d35-454cbe4afd4b", null, new DateTime(2018, 8, 21, 4, 1, 6, 678, DateTimeKind.Local), "Ernesto", "Roma15@hotmail.com", "Donavon", true, "Walsh", null, null, 1 },
                    { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", null, new DateTime(2018, 8, 21, 7, 33, 43, 726, DateTimeKind.Local), "Jovan", "Herbert.Gulgowski87@hotmail.com", "Chad", true, "O'Conner", null, null, 2 },
                    { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", null, new DateTime(2018, 8, 21, 10, 8, 56, 773, DateTimeKind.Local), "Ollie", "Edna_Walker@hotmail.com", "Alec", true, "Feil", null, null, 2 },
                    { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", null, new DateTime(2018, 8, 20, 21, 31, 12, 698, DateTimeKind.Local), "Bernie", "Douglas5@yahoo.com", "Rahul", true, "Smith", null, null, 2 },
                    { "a0af6468-5fc7-47f4-a87d-71473658f8e6", null, new DateTime(2018, 8, 20, 22, 53, 30, 262, DateTimeKind.Local), "Una", "Mabel.Senger83@gmail.com", "Garrett", true, "West", null, null, 2 },
                    { "69176035-4bb8-43e5-8a63-138d422223c3", null, new DateTime(2018, 8, 21, 3, 3, 28, 23, DateTimeKind.Local), "Derick", "Marques_Luettgen22@gmail.com", "Kris", true, "Veum", null, null, 1 },
                    { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", null, new DateTime(2018, 8, 21, 6, 54, 56, 339, DateTimeKind.Local), "Frankie", "Halle88@hotmail.com", "Deron", true, "Moen", null, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "iure" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", "distinctio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "69176035-4bb8-43e5-8a63-138d422223c3", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 12, 14, 845, DateTimeKind.Local), "Maxime excepturi ut.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 8, 3, 9, 798, DateTimeKind.Local), "Nulla quasi voluptatem et necessitatibus unde aperiam quia beatae.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 23, 51, 56, 918, DateTimeKind.Local), "Autem occaecati placeat accusantium impedit.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 2, 45, 58, 6, DateTimeKind.Local), "Iste consequuntur dignissimos minima ullam eius rerum.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 1, 10, 408, DateTimeKind.Local), "Quia sequi illum sed impedit.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 0, 33, 59, 678, DateTimeKind.Local), "Eum aut eum voluptas.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 2, 32, 48, 63, DateTimeKind.Local), "Atque blanditiis voluptatem quis quisquam aut quia.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 23, 42, 540, DateTimeKind.Local), "Quisquam fuga maxime dolorum tempore.", "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 43, 8, 76, DateTimeKind.Local), "Porro dolore optio non.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 14, 10, 43, 652, DateTimeKind.Local), "Enim corrupti delectus autem.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 21, 4, 59, 58, 35, DateTimeKind.Local), "Delectus adipisci quo repellendus voluptate expedita cumque pariatur.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 21, 10, 14, 9, 443, DateTimeKind.Local), "Quia provident non et velit veniam tenetur inventore omnis.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 21, 12, 2, 44, 163, DateTimeKind.Local), "Rem nesciunt non voluptas.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 21, 8, 48, 26, 148, DateTimeKind.Local), "Amet nemo et expedita nam.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 21, 3, 21, 40, 546, DateTimeKind.Local), "Consectetur distinctio occaecati nesciunt tenetur quibusdam.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 21, 3, 1, 50, 596, DateTimeKind.Local), "Voluptatum unde consequatur atque incidunt eligendi odio vel.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 20, 22, 21, 5, 968, DateTimeKind.Local), "Quod itaque tenetur et.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 21, 15, 1, 5, 714, DateTimeKind.Local), "Et at excepturi hic repellat sunt.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 21, 14, 43, 9, 465, DateTimeKind.Local), "Et impedit omnis.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 23, 2, 34, 160, DateTimeKind.Local), "Iste est omnis qui quisquam aliquid esse sit voluptas porro.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 0, "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 3, "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "06a6f2af-515c-4700-85e9-f1fdc8ad48da" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: "69176035-4bb8-43e5-8a63-138d422223c3");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 44, 35, 97, DateTimeKind.Local), 16, "Aperiam iusto repellendus dolor temporibus deleniti occaecati et non animi.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 17, 42, 25, 536, DateTimeKind.Local), 13, "Laudantium quia est deserunt soluta.", "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 8, 53, 20, 648, DateTimeKind.Local), 12, "Et ex consequatur nihil in suscipit qui sunt molestiae sint.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 8, 24, 798, DateTimeKind.Local), 18, "Et qui eum est minima explicabo.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 11, 14, 7, 645, DateTimeKind.Local), 15, "Est numquam et similique.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 16, 39, 3, 660, DateTimeKind.Local), 16, "Est dignissimos sequi nihil quam omnis earum.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 10, 30, 49, 159, DateTimeKind.Local), 18, "Quod fugit nesciunt.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 10, 15, 32, 899, DateTimeKind.Local), 19, "Exercitationem ad sunt dolorem sapiente harum sunt ratione inventore.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 56, 15, 850, DateTimeKind.Local), 14, "Voluptatem dolores rerum nihil libero corporis deleniti ea est.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 44, 18, 584, DateTimeKind.Local), 12, "Debitis ipsa odit corrupti et repudiandae repellendus.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "456.932.2618 x44946", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "Omnis cumque rem in non et enim.", "Loy.Erdman@hotmail.com", "Company336", 64, "https://garnet.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-770-319-7819 x25287", "06a6f2af-515c-4700-85e9-f1fdc8ad48da", "Ea magni omnis minima expedita sapiente dolorem et. Iste quasi quae error provident. Quas qui rerum et a vel qui ullam facilis.", "Levi_Roob@yahoo.com", "Company384", 68, "http://leora.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "294-393-7864 x4089", "a0af6468-5fc7-47f4-a87d-71473658f8e6", "Chad_Schneider24@gmail.com", "Company385", 63, "http://jaylon.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(453) 497-8409", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", "Molestiae qui dolores tenetur possimus itaque ea aut illum perferendis. Perferendis et distinctio repellendus ipsum officia voluptatem rerum aut animi.", "Roy_Trantow@hotmail.com", "Company7", 66, "https://bart.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(976) 496-7823 x34629", "783ab59c-34ee-47dc-be3d-9d0cc68361aa", "Est sit soluta ut corporis veritatis eum eaque tempore. Nemo dolor sed suscipit expedita dolores assumenda soluta occaecati. Delectus commodi ut et qui nisi.", "Carli69@gmail.com", "Company308", 70, "https://evelyn.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "928-640-1960", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "Qui ut et voluptate repellendus et et. Quo quo et quaerat eveniet tempora suscipit exercitationem molestiae sit. Ut repellat enim atque vel dolores commodi harum. Sit quaerat quia esse excepturi quis et non.", "Arnaldo_King32@hotmail.com", "Company420", 66, "https://kaia.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "833.665.1752 x4997", "69176035-4bb8-43e5-8a63-138d422223c3", "Velit maxime laborum mollitia quia vel molestiae. Et voluptatem minima earum qui velit neque iure nihil.", "Minnie96@hotmail.com", "Company539", 64, "https://watson.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "975-972-3664", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", "Repudiandae ut ipsam velit ex fugit aut. Error sunt laudantium. Occaecati magni eveniet et odit distinctio maiores cumque cum.", "Rosemary.Pollich@gmail.com", "Company723", 64, "http://dane.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(332) 612-1068 x490", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", "Iusto quas aut quas voluptates. Porro ut voluptatibus ab ut rem quia alias facere. Quidem quod quasi aut qui unde illum iste nihil.", "Ludie81@hotmail.com", "Company335", 66, "http://rhea.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-345-632-5890", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", "Nulla sed maiores. Non necessitatibus est esse quibusdam voluptatem ad consectetur. Quia voluptas omnis totam error voluptate. Natus enim provident atque provident accusamus.", "Cora61@hotmail.com", "Company524", 66, "https://elmore.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 9, 39, 9, 837, DateTimeKind.Local), 46, "Dolor est illum voluptas autem.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 19, 9, 19, 706, DateTimeKind.Local), 41, "Voluptatum nihil consequatur.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 19, 57, 58, 299, DateTimeKind.Local), 44, "Sequi velit voluptatem soluta ab sit consequatur.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 56, 6, 947, DateTimeKind.Local), 44, "Qui ipsam non necessitatibus.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 15, 9, 52, 125, DateTimeKind.Local), 43, "Aut aut voluptates consequatur aut officiis.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 11, 26, 7, 656, DateTimeKind.Local), 50, "Qui qui dolores voluptatem rerum consequatur mollitia quia aperiam.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 3, 47, 7, 456, DateTimeKind.Local), 41, "Similique blanditiis tempora voluptas et qui officia temporibus non.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 6, 27, 25, 735, DateTimeKind.Local), 42, "Dolore iure quae consequatur saepe et officia dolores maxime.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 37, 59, 135, DateTimeKind.Local), 44, "Ea nostrum quod error quae veniam.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 8, 23, 376, DateTimeKind.Local), 42, "Placeat doloremque repudiandae qui quidem.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", 73 },
                    { "a0af6468-5fc7-47f4-a87d-71473658f8e6", 76 },
                    { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", 77 },
                    { "52d682db-3377-4f04-b118-9ee72fba6dca", 74 },
                    { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", 78 },
                    { "96235b10-9c99-4d76-8d35-454cbe4afd4b", 75 },
                    { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", 75 },
                    { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", 76 },
                    { "69176035-4bb8-43e5-8a63-138d422223c3", 74 },
                    { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", 78 }
                });
        }
    }
}
