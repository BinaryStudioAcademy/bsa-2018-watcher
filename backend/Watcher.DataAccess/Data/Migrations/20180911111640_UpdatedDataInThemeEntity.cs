using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class UpdatedDataInThemeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2c05f61f-2653-419a-976e-15edefe30f3c", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3d6f3d08-21ca-4edc-9872-6742f53e84db", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4553d455-2948-46da-8851-f2cd1ba3680d", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4ff77ea5-e57b-4625-94c8-549ecfaeedc5", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "627a6262-4d28-4d65-99b6-f9f26c9700a9", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "727ffc07-b199-4a46-8b70-16162352ca3a", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a683daa1-586f-4926-ad81-dca096d75c90", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "afebd73a-4f74-4256-8ab5-f05bbac8026b", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fc75ff6e-4847-4504-8a91-d8534bad2d55", 65 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2c05f61f-2653-419a-976e-15edefe30f3c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d6f3d08-21ca-4edc-9872-6742f53e84db");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4553d455-2948-46da-8851-f2cd1ba3680d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4ff77ea5-e57b-4625-94c8-549ecfaeedc5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "627a6262-4d28-4d65-99b6-f9f26c9700a9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "727ffc07-b199-4a46-8b70-16162352ca3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8f8ec893-10e4-4304-8d0c-b248ec7f4275");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a683daa1-586f-4926-ad81-dca096d75c90");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "afebd73a-4f74-4256-8ab5-f05bbac8026b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fc75ff6e-4847-4504-8a91-d8534bad2d55");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                column: "Threshold",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 22, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 82, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 40, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 82, 98, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 68, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 33, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 56, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 47, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 0, 14, 597, DateTimeKind.Local), 76, "Title994" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 45, 13, 521, DateTimeKind.Local), 74, "Title229" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 37, 27, 358, DateTimeKind.Local), "Title990" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 8, 37, 575, DateTimeKind.Local), 73, "Title77" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 37, 38, 387, DateTimeKind.Local), 80, "Title94" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 0, 47, 264, DateTimeKind.Local), 73, "Title151" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 27, 31, 827, DateTimeKind.Local), 78, "Title714" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 52, 7, 880, DateTimeKind.Local), "Title745" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 27, 2, 686, DateTimeKind.Local), 79, "Title411" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 32, 22, 397, DateTimeKind.Local), 73, "Title79" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "67:41:18:3d:c7:80", 68, "Instance901" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "05:3c:af:5a:4d:6a", 65, "Windows", "Instance311" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "27:2c:75:60:dc:81", 63, "Instance32" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "04:94:30:e1:2b:32", 67, "Instance35" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "32:6c:3a:40:de:93", 61, "Linux", "Instance276" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b3:6e:60:dc:ce:3b", 68, "Windows", "Instance167" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "36:c3:13:3b:ee:71", 61, "Instance380" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b8:b6:b0:63:d8:ba", 70, "Linux", "Instance181" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "78:2f:d7:ec:5f:96", 63, "Instance507" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "67:f9:54:01:6e:6e", "Windows", "Instance71" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BodyColor", "ButtonFontSize", "ControlsHeight", "Name", "ThemePrimaryColor" },
                values: new object[] { "#F8FAFC", "14px", "33px", "Darkness", "#f58400" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "53178434-76a8-4cce-8634-a3bd884eb625", null, new DateTime(2018, 9, 10, 17, 20, 57, 558, DateTimeKind.Local), "Brisa", "Maureen.Marvin@gmail.com", null, "Haylee", true, false, "Schaefer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/aleclarsoniv/128.jpg", 2 },
                    { "a9fde46e-f80e-42b6-ab4e-898fe2390a06", null, new DateTime(2018, 9, 11, 2, 57, 55, 667, DateTimeKind.Local), "Rahsaan", "Carli_Parker@hotmail.com", null, "Alexane", true, false, "Graham", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kapaluccio/128.jpg", 1 },
                    { "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", null, new DateTime(2018, 9, 11, 10, 25, 41, 819, DateTimeKind.Local), "Everette", "Maryse31@gmail.com", null, "Birdie", true, false, "Crona", null, "https://s3.amazonaws.com/uifaces/faces/twitter/xamorep/128.jpg", 2 },
                    { "9eda7cac-1211-455b-803a-dc2e5b08896e", null, new DateTime(2018, 9, 10, 19, 27, 2, 56, DateTimeKind.Local), "Lula", "Stanton35@hotmail.com", null, "Shyanne", true, false, "Ziemann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/balakayuriy/128.jpg", 2 },
                    { "c46ae194-d760-422a-ba43-95d8a280451e", null, new DateTime(2018, 9, 10, 17, 30, 11, 943, DateTimeKind.Local), "Gustave", "Alba_Howell38@hotmail.com", null, "Mckenna", true, false, "Robel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cggaurav/128.jpg", 1 },
                    { "244df142-7a5b-4530-b247-38c8b4159bc8", null, new DateTime(2018, 9, 10, 21, 4, 15, 219, DateTimeKind.Local), "Magdalen", "Shayne32@yahoo.com", null, "Marcia", true, false, "Wunsch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/katiemdaly/128.jpg", 1 },
                    { "2a8c280f-f385-4d2d-a5aa-c57e76b5168e", null, new DateTime(2018, 9, 11, 2, 53, 58, 674, DateTimeKind.Local), "Elmira", "Otto99@gmail.com", null, "Grant", true, false, "Schulist", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jwalter14/128.jpg", 2 },
                    { "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", null, new DateTime(2018, 9, 11, 8, 13, 25, 14, DateTimeKind.Local), "Savanna", "Hershel.Veum@hotmail.com", null, "Ivy", true, false, "Mills", null, "https://s3.amazonaws.com/uifaces/faces/twitter/yehudab/128.jpg", 1 },
                    { "482b80ab-a54b-4cd8-95f2-195e62525906", null, new DateTime(2018, 9, 10, 21, 33, 50, 644, DateTimeKind.Local), "Wilton", "Marie91@gmail.com", null, "Rod", true, false, "Wolf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/lisovsky/128.jpg", 2 },
                    { "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01", null, new DateTime(2018, 9, 11, 5, 14, 15, 710, DateTimeKind.Local), "Candida", "Cloyd16@hotmail.com", null, "Estrella", true, false, "Adams", null, "https://s3.amazonaws.com/uifaces/faces/twitter/brandonburke/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9eda7cac-1211-455b-803a-dc2e5b08896e", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "482b80ab-a54b-4cd8-95f2-195e62525906", "dolorum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9eda7cac-1211-455b-803a-dc2e5b08896e", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "244df142-7a5b-4530-b247-38c8b4159bc8", "soluta" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c46ae194-d760-422a-ba43-95d8a280451e", "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "53178434-76a8-4cce-8634-a3bd884eb625", "labore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", "laboriosam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "482b80ab-a54b-4cd8-95f2-195e62525906", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", "quas" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 18, 6, 852, DateTimeKind.Local), "Dolorem tempora laborum.", "a9fde46e-f80e-42b6-ab4e-898fe2390a06" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 48, 11, 337, DateTimeKind.Local), "Id saepe fuga voluptatem quia nemo.", "53178434-76a8-4cce-8634-a3bd884eb625" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 43, 45, 25, DateTimeKind.Local), "Animi et officiis dolores vitae ex est.", "482b80ab-a54b-4cd8-95f2-195e62525906" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 4, 29, 723, DateTimeKind.Local), "Debitis voluptatem nobis ea.", "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 47, 30, 39, DateTimeKind.Local), "Cumque voluptatibus nulla nam ut illum voluptatem non accusantium id.", "53178434-76a8-4cce-8634-a3bd884eb625" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 57, 40, 710, DateTimeKind.Local), "Non consequatur consequuntur cum rerum non est quia explicabo.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 41, 42, 640, DateTimeKind.Local), "Dolor consequuntur ullam dicta illo sed qui voluptas amet.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 6, 41, 578, DateTimeKind.Local), "Debitis sit dicta iste.", "53178434-76a8-4cce-8634-a3bd884eb625" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 47, 2, 183, DateTimeKind.Local), "Consequatur autem aperiam hic et consectetur consequatur porro sapiente.", "ce4e84e3-1dcc-4536-906a-5dbc2d20232b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 54, 53, 362, DateTimeKind.Local), "Corporis qui aut corrupti eligendi sit odio.", "53178434-76a8-4cce-8634-a3bd884eb625" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 4, 6, 51, 123, DateTimeKind.Local), "Harum unde non vel aliquid.", "a97e16f2-9d97-4c3d-a9b5-da139a7c400d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 2, 36, 47, 864, DateTimeKind.Local), "Quia quisquam aut inventore et aliquam.", "9eda7cac-1211-455b-803a-dc2e5b08896e", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 16, 39, 38, 46, DateTimeKind.Local), "Qui libero similique voluptatem et ipsum.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 9, 35, 2, 204, DateTimeKind.Local), "Et vitae soluta vel voluptate doloribus ipsam quod rerum nihil.", "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 14, 25, 51, 699, DateTimeKind.Local), "Voluptatem aspernatur voluptatem rerum.", "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 20, 54, 54, 520, DateTimeKind.Local), "Debitis facilis quos et.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 3, 58, 7, 410, DateTimeKind.Local), "Iusto deleniti sit.", "482b80ab-a54b-4cd8-95f2-195e62525906", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 10, 16, 31, 25, 103, DateTimeKind.Local), "Assumenda placeat nobis alias.", "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 17, 9, 21, 308, DateTimeKind.Local), "Id debitis sit perferendis.", "244df142-7a5b-4530-b247-38c8b4159bc8", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 45, 32, 117, DateTimeKind.Local), "Voluptas dolores qui voluptas sint occaecati quia sequi modi labore.", "a9fde46e-f80e-42b6-ab4e-898fe2390a06" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "c46ae194-d760-422a-ba43-95d8a280451e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "ce4e84e3-1dcc-4536-906a-5dbc2d20232b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "a97e16f2-9d97-4c3d-a9b5-da139a7c400d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "a9fde46e-f80e-42b6-ab4e-898fe2390a06" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "a97e16f2-9d97-4c3d-a9b5-da139a7c400d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "53178434-76a8-4cce-8634-a3bd884eb625" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 2, "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 41, 59, 153, DateTimeKind.Local), 19, "Deserunt rerum voluptatibus qui deleniti iste ut sit.", "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 36, 59, 64, DateTimeKind.Local), 19, "Maxime culpa esse necessitatibus omnis temporibus adipisci nihil exercitationem ipsam.", "2a8c280f-f385-4d2d-a5aa-c57e76b5168e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 6, 46, 230, DateTimeKind.Local), "Quidem commodi culpa distinctio deleniti dolor esse placeat.", "c46ae194-d760-422a-ba43-95d8a280451e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 21, 43, 569, DateTimeKind.Local), 19, "In totam nihil excepturi occaecati autem.", "c46ae194-d760-422a-ba43-95d8a280451e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 34, 51, 88, DateTimeKind.Local), 15, "Qui est cumque quo.", "2a8c280f-f385-4d2d-a5aa-c57e76b5168e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 23, 43, 428, DateTimeKind.Local), 12, "Omnis aliquid dolore voluptas sint.", "2a8c280f-f385-4d2d-a5aa-c57e76b5168e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 51, 31, 639, DateTimeKind.Local), 18, "Impedit cupiditate asperiores quos earum tempora.", "a97e16f2-9d97-4c3d-a9b5-da139a7c400d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 51, 20, 906, DateTimeKind.Local), 18, "Repellendus quibusdam ipsam eum quos qui blanditiis quidem vero sapiente.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 3, 23, 957, DateTimeKind.Local), 20, "Illum optio enim eius minus.", "a9fde46e-f80e-42b6-ab4e-898fe2390a06" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 20, 54, 417, DateTimeKind.Local), 14, "Commodi sed aut qui eligendi.", "c46ae194-d760-422a-ba43-95d8a280451e" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-286-813-1461 x90817", "482b80ab-a54b-4cd8-95f2-195e62525906", "Et omnis ad commodi.", "Herminio.Stark74@gmail.com", "Company747", "http://alexane.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(608) 753-3616 x005", "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", "Non in sit. Consequuntur culpa voluptatem eveniet nesciunt aut. Excepturi id laboriosam id fuga.", "Rowland8@hotmail.com", "Company708", 2, "https://leslie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-721-741-5113", "53178434-76a8-4cce-8634-a3bd884eb625", "Autem pariatur voluptatem incidunt temporibus. Nisi officia voluptatibus temporibus dignissimos consectetur voluptatem perferendis et. Veritatis incidunt dolore ut. Sunt non vitae illo voluptas ratione consectetur.", "Ella25@gmail.com", "Company386", "https://marina.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-282-401-4521", "244df142-7a5b-4530-b247-38c8b4159bc8", "Reiciendis libero modi. Earum quia laudantium facilis voluptatem. Ut quidem quia nobis est possimus. Et voluptatem assumenda sequi.", "Gabriella.Gerhold@yahoo.com", "Company154", 2, "http://jadyn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-713-289-4158 x213", "482b80ab-a54b-4cd8-95f2-195e62525906", "Ut aliquid aspernatur magni voluptates esse magni repellat. Qui quia ullam earum atque tempore eius eum.", "Aaliyah_Cummerata82@hotmail.com", "Company225", "http://dena.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "703-742-1315 x0426", "53178434-76a8-4cce-8634-a3bd884eb625", "Cumque ut officia dolorem exercitationem eius error. Enim aut earum ex quia eaque dolorem culpa nesciunt et. Facilis non dolorem sed alias voluptatem occaecati.", "Kasandra_Cronin37@gmail.com", "Company948", "https://hazel.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-500-262-7104", "c46ae194-d760-422a-ba43-95d8a280451e", "Qui eos illo in sed. Officia error est sit amet minima assumenda quos.", "Janiya67@gmail.com", "Company684", "http://rick.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-739-592-1530 x613", "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", "Sunt tempora ut.", "Nella13@gmail.com", "Company7", 1, "https://shaun.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(718) 503-2205 x912", "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01", "Id quas quam qui.", "Brenna70@yahoo.com", "Company173", 2, "https://kiera.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "497-623-0106", "a9fde46e-f80e-42b6-ab4e-898fe2390a06", "Enim tempore incidunt maxime deleniti error quia esse. Explicabo voluptas in blanditiis autem tenetur illo ratione ut sed. Sed saepe consequatur est blanditiis rem non.", "Tanya25@yahoo.com", "Company116", 1, "https://jordyn.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 5, 1, 110, DateTimeKind.Local), "Ullam est id deleniti rerum.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 25, 6, 675, DateTimeKind.Local), 42, "Quia ipsa non iure.", "ce4e84e3-1dcc-4536-906a-5dbc2d20232b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 25, 40, 108, DateTimeKind.Local), 41, "Saepe ab illum corrupti.", "c46ae194-d760-422a-ba43-95d8a280451e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 46, 25, 101, DateTimeKind.Local), 46, "Qui repellat nulla.", "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 5, 13, 728, DateTimeKind.Local), 46, "Soluta nobis architecto.", "9eda7cac-1211-455b-803a-dc2e5b08896e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 1, 47, 688, DateTimeKind.Local), 44, "Sed velit quo excepturi.", "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 22, 54, 349, DateTimeKind.Local), 50, "Rem quod sint.", "244df142-7a5b-4530-b247-38c8b4159bc8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 6, 9, 407, DateTimeKind.Local), 45, "Fugiat ut sit id blanditiis.", "482b80ab-a54b-4cd8-95f2-195e62525906" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 45, 43, 98, DateTimeKind.Local), 49, "Soluta nobis a magnam nihil suscipit voluptatem eum.", "2a8c280f-f385-4d2d-a5aa-c57e76b5168e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 36, 57, 132, DateTimeKind.Local), 49, "Est cupiditate officiis iusto et nam.", "a9fde46e-f80e-42b6-ab4e-898fe2390a06" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "9eda7cac-1211-455b-803a-dc2e5b08896e", 66, 1 },
                    { "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", 67, 1 },
                    { "2a8c280f-f385-4d2d-a5aa-c57e76b5168e", 69, 1 },
                    { "a9fde46e-f80e-42b6-ab4e-898fe2390a06", 61, 1 },
                    { "c46ae194-d760-422a-ba43-95d8a280451e", 65, 1 },
                    { "244df142-7a5b-4530-b247-38c8b4159bc8", 65, 1 },
                    { "482b80ab-a54b-4cd8-95f2-195e62525906", 61, 1 },
                    { "53178434-76a8-4cce-8634-a3bd884eb625", 65, 1 },
                    { "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", 67, 1 },
                    { "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01", 65, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "244df142-7a5b-4530-b247-38c8b4159bc8", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2a8c280f-f385-4d2d-a5aa-c57e76b5168e", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "482b80ab-a54b-4cd8-95f2-195e62525906", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "53178434-76a8-4cce-8634-a3bd884eb625", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9eda7cac-1211-455b-803a-dc2e5b08896e", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a97e16f2-9d97-4c3d-a9b5-da139a7c400d", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a9fde46e-f80e-42b6-ab4e-898fe2390a06", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c46ae194-d760-422a-ba43-95d8a280451e", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ce4e84e3-1dcc-4536-906a-5dbc2d20232b", 67 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "244df142-7a5b-4530-b247-38c8b4159bc8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2a8c280f-f385-4d2d-a5aa-c57e76b5168e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "482b80ab-a54b-4cd8-95f2-195e62525906");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53178434-76a8-4cce-8634-a3bd884eb625");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9eda7cac-1211-455b-803a-dc2e5b08896e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a97e16f2-9d97-4c3d-a9b5-da139a7c400d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a9fde46e-f80e-42b6-ab4e-898fe2390a06");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c46ae194-d760-422a-ba43-95d8a280451e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cc2f1605-0c61-4b2a-950b-d4bcd57cdc01");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ce4e84e3-1dcc-4536-906a-5dbc2d20232b");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                column: "Threshold",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 47, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 48, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 69, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 50, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 85, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 84, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 96, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 39, 48, 417, DateTimeKind.Local), 74, "Title555" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 15, 9, 577, DateTimeKind.Local), 80, "Title749" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 3, 19, 43, 168, DateTimeKind.Local), "Title2" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 24, 55, 769, DateTimeKind.Local), 72, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 11, 2, 248, DateTimeKind.Local), 71, "Title149" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 7, 41, 204, DateTimeKind.Local), 77, "Title100" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 11, 21, 13, 424, DateTimeKind.Local), 74, "Title958" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 28, 1, 383, DateTimeKind.Local), "Title632" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 40, 46, 115, DateTimeKind.Local), 74, "Title307" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 39, 21, 519, DateTimeKind.Local), 75, "Title217" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ba:8f:47:19:9b:4b", 61, "Instance474" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "60:02:41:4e:ad:87", 70, "Linux", "Instance25" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "59:b6:e7:80:e3:ea", 61, "Instance131" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4c:de:80:e5:8a:7c", 69, "Instance116" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a7:00:5a:9b:e5:d4", 62, "Windows", "Instance612" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cc:cb:fd:f3:89:03", 67, "Linux", "Instance974" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "47:18:9b:cc:b4:82", 66, "Instance210" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b1:cc:1b:6c:dd:59", 64, "Windows", "Instance764" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ce:54:07:81:6c:80", 69, "Instance606" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "d4:0f:ed:eb:6e:8f", "Linux", "Instance362" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BodyColor", "ButtonFontSize", "ControlsHeight", "Name", "ThemePrimaryColor" },
                values: new object[] { "#F8FAFC !global", "16px !global", "38px", "Pink", "#ff5a5f" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "3d6f3d08-21ca-4edc-9872-6742f53e84db", null, new DateTime(2018, 9, 10, 15, 33, 1, 470, DateTimeKind.Local), "Vivianne", "Kaycee.West@gmail.com", null, "Keagan", true, false, "Mayert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bargaorobalo/128.jpg", 2 },
                    { "afebd73a-4f74-4256-8ab5-f05bbac8026b", null, new DateTime(2018, 9, 10, 3, 1, 15, 659, DateTimeKind.Local), "Elvera", "Shanel_Morar59@hotmail.com", null, "Skylar", true, false, "Hodkiewicz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/klefue/128.jpg", 1 },
                    { "a683daa1-586f-4926-ad81-dca096d75c90", null, new DateTime(2018, 9, 10, 4, 27, 48, 376, DateTimeKind.Local), "Althea", "Deondre_Senger@yahoo.com", null, "Reva", true, false, "Langworth", null, "https://s3.amazonaws.com/uifaces/faces/twitter/michaelkoper/128.jpg", 2 },
                    { "4ff77ea5-e57b-4625-94c8-549ecfaeedc5", null, new DateTime(2018, 9, 9, 21, 48, 45, 442, DateTimeKind.Local), "Noemy", "Uriel_Koss7@yahoo.com", null, "Eldred", true, false, "Pollich", null, "https://s3.amazonaws.com/uifaces/faces/twitter/rdbannon/128.jpg", 2 },
                    { "727ffc07-b199-4a46-8b70-16162352ca3a", null, new DateTime(2018, 9, 10, 12, 21, 4, 582, DateTimeKind.Local), "Jerry", "Royce_Connelly99@gmail.com", null, "Carmella", true, false, "Nienow", null, "https://s3.amazonaws.com/uifaces/faces/twitter/txcx/128.jpg", 1 },
                    { "627a6262-4d28-4d65-99b6-f9f26c9700a9", null, new DateTime(2018, 9, 9, 21, 55, 33, 215, DateTimeKind.Local), "Edna", "Deja30@gmail.com", null, "Katelyn", true, false, "Lang", null, "https://s3.amazonaws.com/uifaces/faces/twitter/geran7/128.jpg", 1 },
                    { "4553d455-2948-46da-8851-f2cd1ba3680d", null, new DateTime(2018, 9, 10, 16, 21, 6, 65, DateTimeKind.Local), "Derrick", "Camylle50@hotmail.com", null, "Adell", true, false, "Carter", null, "https://s3.amazonaws.com/uifaces/faces/twitter/charliecwaite/128.jpg", 2 },
                    { "fc75ff6e-4847-4504-8a91-d8534bad2d55", null, new DateTime(2018, 9, 10, 5, 2, 59, 876, DateTimeKind.Local), "Nicolette", "Johan_Sauer58@yahoo.com", null, "Shea", true, false, "Aufderhar", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kudretkeskin/128.jpg", 2 },
                    { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", null, new DateTime(2018, 9, 10, 8, 14, 32, 428, DateTimeKind.Local), "Christ", "Jessyca49@hotmail.com", null, "Randall", true, false, "Kertzmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/brenmurrell/128.jpg", 2 },
                    { "2c05f61f-2653-419a-976e-15edefe30f3c", null, new DateTime(2018, 9, 9, 22, 32, 29, 49, DateTimeKind.Local), "Lavada", "Napoleon.Connelly6@gmail.com", null, "Jed", true, false, "Dicki", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sgaurav_baghel/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d6f3d08-21ca-4edc-9872-6742f53e84db", "cupiditate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4ff77ea5-e57b-4625-94c8-549ecfaeedc5", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "727ffc07-b199-4a46-8b70-16162352ca3a", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fc75ff6e-4847-4504-8a91-d8534bad2d55", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4ff77ea5-e57b-4625-94c8-549ecfaeedc5", "praesentium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", "voluptatum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2c05f61f-2653-419a-976e-15edefe30f3c", "beatae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4553d455-2948-46da-8851-f2cd1ba3680d", "in" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", "illo" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 47, 0, 336, DateTimeKind.Local), "Sit sunt consectetur occaecati aut ut sed sint dolor.", "4553d455-2948-46da-8851-f2cd1ba3680d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 47, 14, 645, DateTimeKind.Local), "Sapiente at consectetur quia sapiente.", "8f8ec893-10e4-4304-8d0c-b248ec7f4275" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 20, 42, 693, DateTimeKind.Local), "Suscipit ut architecto necessitatibus ad voluptates tempore.", "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 7, 14, 180, DateTimeKind.Local), "Architecto porro est non eius sed nihil cupiditate voluptatem.", "727ffc07-b199-4a46-8b70-16162352ca3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 19, 39, 541, DateTimeKind.Local), "Odio ut nemo est explicabo magni eius molestias ea dolor.", "afebd73a-4f74-4256-8ab5-f05bbac8026b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 11, 42, 50, 406, DateTimeKind.Local), "Ea perferendis corporis dolore aspernatur tempore.", "afebd73a-4f74-4256-8ab5-f05bbac8026b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 13, 43, 33, 804, DateTimeKind.Local), "Aspernatur aut expedita doloremque harum quasi eveniet odio qui voluptatum.", "727ffc07-b199-4a46-8b70-16162352ca3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 9, 10, 836, DateTimeKind.Local), "Qui culpa fuga illum ut voluptas magnam.", "8f8ec893-10e4-4304-8d0c-b248ec7f4275" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 40, 17, 875, DateTimeKind.Local), "Dignissimos voluptatum eos odit quia minima molestiae optio quia voluptas.", "a683daa1-586f-4926-ad81-dca096d75c90" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 51, 30, 882, DateTimeKind.Local), "Doloribus veritatis et voluptatem est.", "4ff77ea5-e57b-4625-94c8-549ecfaeedc5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 10, 17, 22, 441, DateTimeKind.Local), "Iure aliquam omnis voluptas commodi voluptatum exercitationem harum omnis.", "627a6262-4d28-4d65-99b6-f9f26c9700a9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 8, 14, 42, 975, DateTimeKind.Local), "Reprehenderit sint eligendi impedit ab.", "2c05f61f-2653-419a-976e-15edefe30f3c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 11, 29, 56, 199, DateTimeKind.Local), "Dolore soluta architecto eveniet eligendi facere aut.", "afebd73a-4f74-4256-8ab5-f05bbac8026b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 17, 55, 3, 681, DateTimeKind.Local), "Doloremque molestias quod reprehenderit consequatur est sit saepe sit.", "4553d455-2948-46da-8851-f2cd1ba3680d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 4, 48, 16, 233, DateTimeKind.Local), "Impedit reiciendis consequatur.", "a683daa1-586f-4926-ad81-dca096d75c90", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 9, 18, 25, 54, 835, DateTimeKind.Local), "Mollitia soluta ea.", "8f8ec893-10e4-4304-8d0c-b248ec7f4275" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 10, 7, 30, 38, 233, DateTimeKind.Local), "Consectetur ipsum consectetur animi necessitatibus amet ut.", "afebd73a-4f74-4256-8ab5-f05bbac8026b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 10, 11, 57, 45, 549, DateTimeKind.Local), "Laboriosam sit quisquam.", "3d6f3d08-21ca-4edc-9872-6742f53e84db", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 10, 4, 26, 54, 359, DateTimeKind.Local), "Porro et quo.", "2c05f61f-2653-419a-976e-15edefe30f3c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 32, 3, 814, DateTimeKind.Local), "Maiores velit fugiat.", "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "4553d455-2948-46da-8851-f2cd1ba3680d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "627a6262-4d28-4d65-99b6-f9f26c9700a9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "4ff77ea5-e57b-4625-94c8-549ecfaeedc5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "8f8ec893-10e4-4304-8d0c-b248ec7f4275" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 1, "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 12, 10, 501, DateTimeKind.Local), 14, "Ex necessitatibus quod sunt nesciunt excepturi illum expedita fuga.", "727ffc07-b199-4a46-8b70-16162352ca3a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 26, 23, 489, DateTimeKind.Local), 20, "Porro eum ullam quis ipsam.", "4553d455-2948-46da-8851-f2cd1ba3680d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 16, 31, 72, DateTimeKind.Local), "Excepturi itaque quis.", "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 46, 31, 293, DateTimeKind.Local), 20, "Incidunt enim et et recusandae sit non perspiciatis quae.", "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 11, 48, 40, 517, DateTimeKind.Local), 11, "Modi quaerat quos doloremque provident eum doloribus.", "4553d455-2948-46da-8851-f2cd1ba3680d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 3, 8, 8, 789, DateTimeKind.Local), 19, "Consequatur debitis voluptas autem aut porro sapiente.", "afebd73a-4f74-4256-8ab5-f05bbac8026b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 53, 14, 28, DateTimeKind.Local), 20, "Iure accusantium excepturi quis eum corporis.", "a683daa1-586f-4926-ad81-dca096d75c90" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 45, 53, 132, DateTimeKind.Local), 16, "Qui consequatur aut aliquam ducimus nisi nam odit.", "627a6262-4d28-4d65-99b6-f9f26c9700a9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 13, 24, 19, 411, DateTimeKind.Local), 14, "Voluptas inventore illo consequatur.", "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 4, 34, 47, 919, DateTimeKind.Local), 15, "Corrupti consequatur optio eum officiis laudantium.", "afebd73a-4f74-4256-8ab5-f05bbac8026b" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(523) 495-6351", "727ffc07-b199-4a46-8b70-16162352ca3a", "Esse qui eius qui minima atque architecto voluptatum sed.", "Sylvan.Mertz91@yahoo.com", "Company666", "https://gia.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "488.634.6635", "3d6f3d08-21ca-4edc-9872-6742f53e84db", "Quos qui placeat quibusdam harum quos ipsam quas. Doloribus velit architecto sunt facilis in cupiditate ipsam occaecati aliquam. Et ipsa explicabo cumque quisquam voluptatum. Fuga officiis laudantium.", "Clint2@gmail.com", "Company137", 1, "https://ruthe.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "472-270-0382 x424", "3d6f3d08-21ca-4edc-9872-6742f53e84db", "", "Amy39@hotmail.com", "Company308", "http://karina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-288-366-7592", "3d6f3d08-21ca-4edc-9872-6742f53e84db", "Autem consequuntur ut accusantium et possimus sit.", "Lonie.Konopelski76@hotmail.com", "Company158", 1, "https://samara.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-974-456-8341 x9018", "8f8ec893-10e4-4304-8d0c-b248ec7f4275", "Vitae eos repellendus sed suscipit quibusdam necessitatibus saepe.", "Rudolph.Dooley99@hotmail.com", "Company173", "http://martina.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-604-568-0397 x368", "2c05f61f-2653-419a-976e-15edefe30f3c", "Ut aliquid consequatur ratione. Fugiat cupiditate quos enim eius inventore. Dolore ea harum dolore maiores corrupti sequi totam voluptatum. Illo est voluptates et in maiores quis eaque.", "Leanne.Turner@gmail.com", "Company401", "https://ross.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(779) 224-3164", "a683daa1-586f-4926-ad81-dca096d75c90", "Ullam quisquam labore occaecati. Ut sed incidunt tempora mollitia. Molestias impedit perspiciatis maxime.", "Athena.Kutch67@yahoo.com", "Company688", "http://sofia.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "782.804.7749 x4565", "3d6f3d08-21ca-4edc-9872-6742f53e84db", "", "Shyanne86@yahoo.com", "Company476", 2, "http://lexi.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-746-484-5379 x427", "a683daa1-586f-4926-ad81-dca096d75c90", "Beatae inventore dolorem necessitatibus nemo possimus reiciendis doloribus illum. Maiores ipsa sunt est rerum. Earum eos minima beatae. Sint omnis qui.", "Nels17@hotmail.com", "Company270", 1, "http://bernhard.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "273-862-8396", "fc75ff6e-4847-4504-8a91-d8534bad2d55", "", "Rashawn_Zboncak26@hotmail.com", "Company655", 2, "http://betsy.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 3, 49, 336, DateTimeKind.Local), "Doloremque eaque eum veniam est.", "a683daa1-586f-4926-ad81-dca096d75c90" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 24, 37, 293, DateTimeKind.Local), 48, "Et sint sed doloremque numquam iste.", "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 31, 51, 311, DateTimeKind.Local), 43, "Saepe omnis non et.", "727ffc07-b199-4a46-8b70-16162352ca3a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 31, 31, 550, DateTimeKind.Local), 49, "Facere ipsa laborum rerum non ut quidem esse.", "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 53, 22, 719, DateTimeKind.Local), 48, "Expedita facilis error placeat vero tenetur.", "4ff77ea5-e57b-4625-94c8-549ecfaeedc5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 38, 29, 194, DateTimeKind.Local), 49, "Est consectetur fugiat omnis laudantium cupiditate aspernatur.", "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 6, 13, 478, DateTimeKind.Local), 49, "Doloribus non sunt voluptas voluptatem maiores.", "4ff77ea5-e57b-4625-94c8-549ecfaeedc5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 4, 49, 28, 370, DateTimeKind.Local), 43, "Quod eos vel.", "a683daa1-586f-4926-ad81-dca096d75c90" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 26, 50, 47, DateTimeKind.Local), 44, "Autem odit iusto itaque.", "a683daa1-586f-4926-ad81-dca096d75c90" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 37, 44, 468, DateTimeKind.Local), 50, "Consequatur assumenda beatae fugit ipsam quae.", "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "727ffc07-b199-4a46-8b70-16162352ca3a", 69, 1 },
                    { "3d6f3d08-21ca-4edc-9872-6742f53e84db", 67, 1 },
                    { "afebd73a-4f74-4256-8ab5-f05bbac8026b", 65, 1 },
                    { "627a6262-4d28-4d65-99b6-f9f26c9700a9", 61, 1 },
                    { "fc75ff6e-4847-4504-8a91-d8534bad2d55", 65, 1 },
                    { "a683daa1-586f-4926-ad81-dca096d75c90", 64, 1 },
                    { "4ff77ea5-e57b-4625-94c8-549ecfaeedc5", 61, 1 },
                    { "4553d455-2948-46da-8851-f2cd1ba3680d", 65, 1 },
                    { "8f8ec893-10e4-4304-8d0c-b248ec7f4275", 62, 1 },
                    { "2c05f61f-2653-419a-976e-15edefe30f3c", 64, 1 }
                });
        }
    }
}
