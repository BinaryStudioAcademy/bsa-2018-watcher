using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class RemovedThemeFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Themes_ThemeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ThemeId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "080a477e-414e-409c-8ae6-60935915d212", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "25163190-bc6d-4a00-9bef-9daa1f48c357", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "82f7755a-c076-486d-9ec3-8c8482c04551", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c93d5042-5283-4883-bc08-0b707273edbb", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef405225-ec6a-41a1-bcda-793467d67aa6", 61 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "080a477e-414e-409c-8ae6-60935915d212");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15b2e656-c73d-4f52-9de5-4da521a7c5f7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25163190-bc6d-4a00-9bef-9daa1f48c357");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "312c4307-f729-4d41-888b-e8e4a5b3cd9a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3a411cc8-95ea-4496-8528-a6ea6e6d596b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "56c50529-8f61-4811-ad6b-014632e81bc3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "82f7755a-c076-486d-9ec3-8c8482c04551");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c93d5042-5283-4883-bc08-0b707273edbb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef405225-ec6a-41a1-bcda-793467d67aa6");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 24, 1 });

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
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 88, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 69, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 86, 50 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 85, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 86, 84 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 15, 9, 577, DateTimeKind.Local), "Title749" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 3, 19, 43, 168, DateTimeKind.Local), 71, "Title2" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 28, 1, 383, DateTimeKind.Local), 80, "Title632" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "59:b6:e7:80:e3:ea", 61, "Linux", "Instance131" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4c:de:80:e5:8a:7c", 69, "Windows", "Instance116" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "cc:cb:fd:f3:89:03", 67, "Instance974" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "47:18:9b:cc:b4:82", 66, "Linux", "Instance210" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b1:cc:1b:6c:dd:59", 64, "Instance764" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ce:54:07:81:6c:80", 69, "Windows", "Instance606" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d4:0f:ed:eb:6e:8f", 64, "Linux", "Instance362" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 17, 22, 441, DateTimeKind.Local), "Iure aliquam omnis voluptas commodi voluptatum exercitationem harum omnis.", "627a6262-4d28-4d65-99b6-f9f26c9700a9" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 4, 48, 16, 233, DateTimeKind.Local), "Impedit reiciendis consequatur.", "a683daa1-586f-4926-ad81-dca096d75c90" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 30, 38, 233, DateTimeKind.Local), "Consectetur ipsum consectetur animi necessitatibus amet ut.", "afebd73a-4f74-4256-8ab5-f05bbac8026b", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 10, 4, 26, 54, 359, DateTimeKind.Local), "Porro et quo.", "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 10, 16, 32, 3, 814, DateTimeKind.Local), "Maiores velit fugiat.", "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 1, "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "4553d455-2948-46da-8851-f2cd1ba3680d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, true, "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "627a6262-4d28-4d65-99b6-f9f26c9700a9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "4ff77ea5-e57b-4625-94c8-549ecfaeedc5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 4, "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 4, "8f8ec893-10e4-4304-8d0c-b248ec7f4275" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 4, "fc75ff6e-4847-4504-8a91-d8534bad2d55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "2c05f61f-2653-419a-976e-15edefe30f3c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "3d6f3d08-21ca-4edc-9872-6742f53e84db" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 16, 31, 72, DateTimeKind.Local), 17, "Excepturi itaque quis.", "2c05f61f-2653-419a-976e-15edefe30f3c" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(523) 495-6351", "727ffc07-b199-4a46-8b70-16162352ca3a", "Esse qui eius qui minima atque architecto voluptatum sed.", "Sylvan.Mertz91@yahoo.com", "Company666", 2, "https://gia.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-974-456-8341 x9018", "8f8ec893-10e4-4304-8d0c-b248ec7f4275", "Vitae eos repellendus sed suscipit quibusdam necessitatibus saepe.", "Rudolph.Dooley99@hotmail.com", "Company173", 1, "http://martina.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-746-484-5379 x427", "a683daa1-586f-4926-ad81-dca096d75c90", "Beatae inventore dolorem necessitatibus nemo possimus reiciendis doloribus illum. Maiores ipsa sunt est rerum. Earum eos minima beatae. Sint omnis qui.", "Nels17@hotmail.com", "Company270", "http://bernhard.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "273-862-8396", "fc75ff6e-4847-4504-8a91-d8534bad2d55", "", "Rashawn_Zboncak26@hotmail.com", "Company655", "http://betsy.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 3, 49, 336, DateTimeKind.Local), 42, "Doloremque eaque eum veniam est.", "a683daa1-586f-4926-ad81-dca096d75c90" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 36, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 82, 100, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 99, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 84, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 87, 84 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 82, 66 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 32, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 6, 57, 584, DateTimeKind.Local), 77, "Title709" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 18, 55, 587, DateTimeKind.Local), "Title168" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 50, 2, 286, DateTimeKind.Local), 74, "Title998" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 17, 19, 813, DateTimeKind.Local), 79, "Title328" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 18, 40, 524, DateTimeKind.Local), 72, "Title477" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 25, 23, 612, DateTimeKind.Local), 79, "Title550" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 2, 49, 366, DateTimeKind.Local), 77, "Title941" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 9, 8, 451, DateTimeKind.Local), 78, "Title348" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 17, 52, 944, DateTimeKind.Local), 78, "Title526" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 52, 20, 762, DateTimeKind.Local), 78, "Title474" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "28:5e:9b:40:7d:1a", 63, "Instance603" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cb:4a:62:d9:11:e1", 66, "Windows", "Instance604" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "43:17:d9:1d:67:5d", 64, "Windows", "Instance232" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "48:84:df:00:6d:fa", 61, "Linux", "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "28:8a:54:15:75:07", 66, "Linux", "Instance326" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d4:7b:12:65:0c:11", 66, "Instance180" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "bb:a2:63:9f:18:47", 65, "Windows", "Instance849" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "de:d5:ec:a1:0c:b8", 68, "Instance420" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d1:d9:72:d6:26:cd", 65, "Linux", "Instance657" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "75:85:e8:33:de:85", 62, "Windows", "Instance955" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId", "ThemeId" },
                values: new object[,]
                {
                    { "ef405225-ec6a-41a1-bcda-793467d67aa6", null, new DateTime(2018, 9, 9, 19, 11, 5, 723, DateTimeKind.Local), "Marcelino", "Trey.Hegmann@gmail.com", null, "Loyal", true, false, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vytautas_a/128.jpg", 2, 1 },
                    { "56c50529-8f61-4811-ad6b-014632e81bc3", null, new DateTime(2018, 9, 9, 23, 55, 20, 77, DateTimeKind.Local), "Robbie", "Mina18@gmail.com", null, "Sydnee", true, false, "Crooks", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mandalareopens/128.jpg", 1, 2 },
                    { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", null, new DateTime(2018, 9, 10, 0, 34, 45, 992, DateTimeKind.Local), "Brock", "Nicklaus.Lubowitz10@yahoo.com", null, "Jess", true, false, "Monahan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/themadray/128.jpg", 2, 1 },
                    { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", null, new DateTime(2018, 9, 9, 4, 23, 40, 199, DateTimeKind.Local), "Judson", "Amiya.Baumbach@gmail.com", null, "Adrienne", true, false, "Williamson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/alek_djuric/128.jpg", 2, 2 },
                    { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", null, new DateTime(2018, 9, 9, 11, 14, 32, 754, DateTimeKind.Local), "Patsy", "Dejah_Schroeder@hotmail.com", null, "Dion", true, false, "Wiza", null, "https://s3.amazonaws.com/uifaces/faces/twitter/leeiio/128.jpg", 1, 1 },
                    { "25163190-bc6d-4a00-9bef-9daa1f48c357", null, new DateTime(2018, 9, 9, 9, 33, 52, 683, DateTimeKind.Local), "Abigale", "Hal.Vandervort94@yahoo.com", null, "Willy", true, false, "Kihn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ostirbu/128.jpg", 1, 2 },
                    { "080a477e-414e-409c-8ae6-60935915d212", null, new DateTime(2018, 9, 9, 12, 36, 29, 445, DateTimeKind.Local), "Anibal", "Cristian.Fahey49@yahoo.com", null, "Arianna", true, false, "Jast", null, "https://s3.amazonaws.com/uifaces/faces/twitter/thekevinjones/128.jpg", 1, 1 },
                    { "82f7755a-c076-486d-9ec3-8c8482c04551", null, new DateTime(2018, 9, 9, 11, 51, 31, 810, DateTimeKind.Local), "Katarina", "Caesar.Hoeger@gmail.com", null, "Sadye", true, false, "Hermiston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/agromov/128.jpg", 1, 1 },
                    { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", null, new DateTime(2018, 9, 9, 22, 28, 57, 291, DateTimeKind.Local), "Cheyenne", "Theodore72@hotmail.com", null, "Tristian", true, false, "Hessel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/silvanmuhlemann/128.jpg", 1, 1 },
                    { "c93d5042-5283-4883-bc08-0b707273edbb", null, new DateTime(2018, 9, 10, 1, 19, 27, 352, DateTimeKind.Local), "Hal", "Adolphus.Kuhlman21@yahoo.com", null, "Alia", true, false, "Toy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cemshid/128.jpg", 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c93d5042-5283-4883-bc08-0b707273edbb", "temporibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "ex" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "blanditiis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", "ducimus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "25163190-bc6d-4a00-9bef-9daa1f48c357", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef405225-ec6a-41a1-bcda-793467d67aa6", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", "nisi" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 1, 17, 90, DateTimeKind.Local), "Voluptate sequi laboriosam dolor quaerat.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 9, 41, 515, DateTimeKind.Local), "Fugiat vero non dolorem.", "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 6, 27, 567, DateTimeKind.Local), "Impedit hic et eum eveniet sunt praesentium quia nihil.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 35, 48, 191, DateTimeKind.Local), "Molestiae enim minus voluptatem et blanditiis illum.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 44, 24, 387, DateTimeKind.Local), "Iure consequuntur error tempore quo dolore tenetur aut tenetur hic.", "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 35, 5, 31, DateTimeKind.Local), "Provident sed quod eos.", "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 48, 19, 429, DateTimeKind.Local), "Repudiandae non tenetur accusamus et ut aut sed velit impedit.", "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 23, 53, 951, DateTimeKind.Local), "Porro error itaque ut modi aliquam.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 42, 30, 157, DateTimeKind.Local), "Eveniet ex accusamus vel aut.", "82f7755a-c076-486d-9ec3-8c8482c04551" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 25, 17, 968, DateTimeKind.Local), "Voluptatem sunt ipsum.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 8, 54, 341, DateTimeKind.Local), "Eos voluptas corrupti ea quidem.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 8, 25, 19, 392, DateTimeKind.Local), "Quo id dolores ut voluptatibus a vel.", "25163190-bc6d-4a00-9bef-9daa1f48c357", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 10, 51, 1, 556, DateTimeKind.Local), "Nihil aut ducimus aperiam qui ut doloribus nihil tempore.", "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 11, 45, 39, 693, DateTimeKind.Local), "Et veritatis qui aut omnis non officia.", "c93d5042-5283-4883-bc08-0b707273edbb", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 9, 12, 1, 33, 335, DateTimeKind.Local), "In deserunt voluptas dolores officia et dolor ullam dolorum id.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 0, 17, 45, 692, DateTimeKind.Local), "Iusto hic eos dicta placeat laborum.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 8, 36, 460, DateTimeKind.Local), "Qui distinctio magnam tempora ut eaque sed qui fugiat.", "c93d5042-5283-4883-bc08-0b707273edbb", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 22, 46, 57, 563, DateTimeKind.Local), "Ut aliquid sapiente voluptatem ratione eius et quis.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 7, 0, 56, 632, DateTimeKind.Local), "Dolorem iure alias quas consequatur.", "56c50529-8f61-4811-ad6b-014632e81bc3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 12, 2, 59, 136, DateTimeKind.Local), "Qui laboriosam debitis.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 2, "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, false, "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 0, "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 1, "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 1, "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 34, 5, 12, DateTimeKind.Local), 11, "Aut recusandae distinctio dolores dolorem est consectetur delectus vel.", "56c50529-8f61-4811-ad6b-014632e81bc3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 38, 25, 28, DateTimeKind.Local), 13, "Porro ut adipisci beatae velit ipsam corporis et temporibus porro.", "82f7755a-c076-486d-9ec3-8c8482c04551" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 49, 21, 140, DateTimeKind.Local), 11, "Quas saepe et facilis excepturi vero hic accusantium cupiditate.", "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 47, 23, 394, DateTimeKind.Local), 16, "Harum quibusdam ducimus et incidunt harum placeat velit non excepturi.", "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 58, 11, 317, DateTimeKind.Local), 19, "Non modi eius suscipit repellendus culpa repudiandae.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 26, 3, 428, DateTimeKind.Local), 15, "Et incidunt a est autem quia.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 20, 49, 231, DateTimeKind.Local), 11, "Quasi laboriosam consequatur explicabo beatae dolores dignissimos sunt.", "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 4, 23, 23, DateTimeKind.Local), 17, "Ut sit aut corporis et autem molestiae repellat earum qui.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 38, 27, 204, DateTimeKind.Local), 19, "Temporibus est omnis corporis id ut.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 17, 34, 98, DateTimeKind.Local), 19, "Voluptate labore nihil dicta totam fugit est quia molestiae et.", "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(251) 958-8736 x160", "3a411cc8-95ea-4496-8528-a6ea6e6d596b", "Nulla quo minus qui velit eius.", "Marie_Weimann60@yahoo.com", "Company847", 1, "http://alice.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "320-369-8202 x276", "25163190-bc6d-4a00-9bef-9daa1f48c357", "Sint voluptas placeat qui blanditiis incidunt. Optio ad necessitatibus quas. Dolorum provident in rerum excepturi vitae fuga veritatis enim.", "Amber96@gmail.com", "Company295", 2, "https://mackenzie.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "491-301-9491 x11276", "56c50529-8f61-4811-ad6b-014632e81bc3", "Facilis perferendis et aspernatur voluptas a nobis et.", "Tom8@gmail.com", "Company63", "http://isabella.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-908-566-8501", "c93d5042-5283-4883-bc08-0b707273edbb", "Reprehenderit voluptas et qui quo delectus labore magnam in.", "Gustave_Beier@gmail.com", "Company360", 2, "http://connor.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "752.672.7201", "82f7755a-c076-486d-9ec3-8c8482c04551", "", "Moshe.Braun@hotmail.com", "Company638", 2, "https://gustave.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "878.966.8501 x81429", "56c50529-8f61-4811-ad6b-014632e81bc3", "Necessitatibus possimus quos beatae. Dolorem deleniti earum aliquid magnam odio et laudantium dolorum sit.", "Axel_Gleichner91@hotmail.com", "Company566", "http://kayli.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "600.727.1898 x8739", "56c50529-8f61-4811-ad6b-014632e81bc3", "Consequatur et perspiciatis similique voluptas sit.", "Gunnar.Klocko@hotmail.com", "Company908", "http://ottilie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "742.364.2240", "82f7755a-c076-486d-9ec3-8c8482c04551", "Deleniti velit architecto ut dolorem labore vel molestiae. Unde est quam illum veritatis impedit occaecati.", "Hobart84@hotmail.com", "Company597", 1, "http://pansy.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "820-782-2216 x9978", "25163190-bc6d-4a00-9bef-9daa1f48c357", "", "Karianne94@yahoo.com", "Company597", "https://sandrine.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "933-272-7844 x0843", "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "Dolorum aut illum nihil nihil. Itaque laudantium aliquam voluptatem non consequatur magnam maxime.", "Maurice.Kertzmann@hotmail.com", "Company392", "https://annette.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 39, 25, 392, DateTimeKind.Local), 47, "Ipsum optio assumenda itaque ratione quam.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 8, 5, 399, DateTimeKind.Local), 50, "Quasi ducimus delectus.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 6, 47, 308, DateTimeKind.Local), 48, "Id voluptas animi aperiam animi repellat cupiditate quibusdam ut facere.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 51, 46, 694, DateTimeKind.Local), 48, "Eos facilis aut assumenda similique blanditiis.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 25, 5, 598, DateTimeKind.Local), 46, "Et nobis placeat enim et incidunt amet.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 9, 57, 915, DateTimeKind.Local), 47, "Sunt rem quam similique cumque et.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 55, 50, 732, DateTimeKind.Local), 50, "At delectus porro recusandae aut.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 29, 35, 933, DateTimeKind.Local), 42, "Tempore libero delectus doloribus eum sint.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 42, 18, 675, DateTimeKind.Local), 43, "Similique omnis doloribus consequuntur aut similique ipsum est.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 16, 10, 129, DateTimeKind.Local), 44, "Dolorem magni quaerat quibusdam.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "080a477e-414e-409c-8ae6-60935915d212", 64, 1 },
                    { "25163190-bc6d-4a00-9bef-9daa1f48c357", 67, 1 },
                    { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", 64, 1 },
                    { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", 64, 1 },
                    { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", 69, 1 },
                    { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", 67, 1 },
                    { "56c50529-8f61-4811-ad6b-014632e81bc3", 66, 1 },
                    { "ef405225-ec6a-41a1-bcda-793467d67aa6", 61, 1 },
                    { "82f7755a-c076-486d-9ec3-8c8482c04551", 68, 1 },
                    { "c93d5042-5283-4883-bc08-0b707273edbb", 65, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ThemeId",
                table: "Users",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Themes_ThemeId",
                table: "Users",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
