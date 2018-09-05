using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class RoleInUserOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "307ee358-2383-4f80-b94f-26f489bdb30f", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4740e1d3-a664-49cf-bde9-24133792f2d8", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "52e27198-436d-4714-a6e7-e0d0738b847f", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "89babdf6-31d6-45d2-a725-16c5e80ea915", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b3731d39-39d1-491c-950b-719b0606e9c5", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "307ee358-2383-4f80-b94f-26f489bdb30f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45e74407-0146-4659-a4f6-de7d7c0d0b9b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4740e1d3-a664-49cf-bde9-24133792f2d8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52e27198-436d-4714-a6e7-e0d0738b847f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "89babdf6-31d6-45d2-a725-16c5e80ea915");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ce60506-64fa-4b47-a167-f77a2bbe46bc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b3731d39-39d1-491c-950b-719b0606e9c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b57b3a69-a3c9-4efd-b242-0fc6b368ff92");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d59c9c41-ee13-42c2-adf8-862e5ada2a81");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationRoleId",
                table: "UserOrganizations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 47 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded2", 55, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 46, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", 94, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded" },
                values: new object[] { 93, "MostLoaded1" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 27, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 67, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded1", 44, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 96, "MostLoaded1", 94 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 53, 46, 147, DateTimeKind.Local), 83, "Title113" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 22, 4, 906, DateTimeKind.Local), 88, "Title54" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 14, 15, 56, 318, DateTimeKind.Local), 90, "Title57" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 21, 49, 775, DateTimeKind.Local), 83, "Title213" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 57, 29, 620, DateTimeKind.Local), "Title694" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 5, 58, 48, 822, DateTimeKind.Local), 82, "Title707" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 25, 10, 210, DateTimeKind.Local), 90, "Title893" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 42, 24, 365, DateTimeKind.Local), "Title122" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 15, 6, 55, 214, DateTimeKind.Local), 88, "Title835" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 24, 47, 496, DateTimeKind.Local), 82, "Title940" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "33:62:99:7b:7a:6d", 76, "Instance981" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b5:90:ec:4c:91:c9", 80, "Instance909" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "bb:54:bd:03:39:5a", 75, "Instance78" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ec:7e:2e:21:d6:28", 72, "Instance103" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8a:99:36:8b:a4:a9", 79, "Linux", "Instance125" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5c:31:65:b0:58:df", 77, "Linux", "Instance946" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "fb:9f:72:19:1d:36", 74, "Instance256" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a9:4d:50:5b:c0:22", 72, "Instance458" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "81:8e:02:bd:73:bb", 72, "Instance370" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "82:8a:64:ff:bd:ea", 72, "Windows", "Instance784" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme310" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme427" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme996" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme29" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme778" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme333");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme90" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Theme798");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme818" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme770" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9", null, new DateTime(2018, 9, 4, 15, 54, 28, 996, DateTimeKind.Local), "Estell", "Franz70@hotmail.com", null, "Destany", true, false, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jpenico/128.jpg", 1 },
                    { "85ecd13b-bea8-41c2-ab16-19d393693093", null, new DateTime(2018, 9, 5, 12, 38, 4, 446, DateTimeKind.Local), "Kraig", "Garrett35@yahoo.com", null, "Delbert", true, false, "Toy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/waghner/128.jpg", 2 },
                    { "1f91fc25-7cfd-4922-8e0f-36618e422329", null, new DateTime(2018, 9, 5, 5, 49, 29, 693, DateTimeKind.Local), "Marilie", "Agnes35@gmail.com", null, "Garnett", true, false, "Gleason", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sgaurav_baghel/128.jpg", 1 },
                    { "efb7a095-74a7-430c-a647-23054ed25b36", null, new DateTime(2018, 9, 5, 3, 15, 29, 29, DateTimeKind.Local), "Oswaldo", "Raheem.Blick77@gmail.com", null, "Felicia", true, false, "Larkin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/juangomezw/128.jpg", 1 },
                    { "7f5cb4d2-a78b-4210-9720-a33e01a768c1", null, new DateTime(2018, 9, 5, 5, 27, 46, 483, DateTimeKind.Local), "Alysson", "Federico_Nienow3@hotmail.com", null, "Alana", true, false, "Williamson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/enricocicconi/128.jpg", 1 },
                    { "6c0b1a42-427c-43a6-889c-cd19e3729593", null, new DateTime(2018, 9, 4, 16, 16, 48, 125, DateTimeKind.Local), "Arvel", "Stone85@hotmail.com", null, "Annamae", true, false, "Buckridge", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kerem/128.jpg", 2 },
                    { "291b2e40-05f0-40d2-9162-3cb46c10055b", null, new DateTime(2018, 9, 4, 18, 10, 18, 264, DateTimeKind.Local), "Anne", "Yesenia33@gmail.com", null, "Aniya", true, false, "Okuneva", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jakemoore/128.jpg", 2 },
                    { "ca11cfd9-0022-4285-85a6-b14c84a5a0c0", null, new DateTime(2018, 9, 5, 5, 54, 31, 411, DateTimeKind.Local), "Vivien", "Marietta65@gmail.com", null, "Mae", true, false, "Hammes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jordyvdboom/128.jpg", 1 },
                    { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", null, new DateTime(2018, 9, 5, 4, 48, 14, 968, DateTimeKind.Local), "Matilda", "Daphne71@hotmail.com", null, "Morris", true, false, "Ferry", null, "https://s3.amazonaws.com/uifaces/faces/twitter/shoaib253/128.jpg", 1 },
                    { "2e669749-08c5-4bf0-a7f1-e70c416c44ee", null, new DateTime(2018, 9, 5, 8, 6, 48, 880, DateTimeKind.Local), "Calista", "Lea87@gmail.com", null, "Hayden", true, false, "Wyman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/wim1k/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2e669749-08c5-4bf0-a7f1-e70c416c44ee", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", "reprehenderit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", "earum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7f5cb4d2-a78b-4210-9720-a33e01a768c1", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "85ecd13b-bea8-41c2-ab16-19d393693093", "deserunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9", "error" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "efb7a095-74a7-430c-a647-23054ed25b36", "sit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "efb7a095-74a7-430c-a647-23054ed25b36", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "85ecd13b-bea8-41c2-ab16-19d393693093", "nulla" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 8, 33, 17, 763, DateTimeKind.Local), "Corporis quia quis aut odio itaque.", "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 11, 34, 819, DateTimeKind.Local), "Optio minima voluptatem omnis ut.", "efb7a095-74a7-430c-a647-23054ed25b36" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 52, 49, 473, DateTimeKind.Local), "Sint totam nemo quidem ea error ut tempora repudiandae ratione.", "efb7a095-74a7-430c-a647-23054ed25b36" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 4, 55, 799, DateTimeKind.Local), "Cupiditate nemo et quo quia.", "6c0b1a42-427c-43a6-889c-cd19e3729593" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 15, 4, 16, 5, DateTimeKind.Local), "Atque quaerat quas.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 15, 0, 29, 616, DateTimeKind.Local), "Distinctio consequuntur adipisci nihil voluptatum dolorum ipsum.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 54, 21, 777, DateTimeKind.Local), "Quo ut natus eum aut non temporibus iste.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 19, 23, 842, DateTimeKind.Local), "Ut eum quo repudiandae.", "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 33, 43, 87, DateTimeKind.Local), "Et non aut harum eligendi aut aut aspernatur quisquam.", "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 21, 8, 861, DateTimeKind.Local), "Dolor sint autem quod repellat nihil dolor porro.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 4, 16, 33, 36, 47, DateTimeKind.Local), "Optio enim consequuntur alias corporis enim incidunt rerum a.", "85ecd13b-bea8-41c2-ab16-19d393693093", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 5, 6, 23, 10, 257, DateTimeKind.Local), "Velit consequatur sint laborum aspernatur.", "85ecd13b-bea8-41c2-ab16-19d393693093", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 5, 11, 39, 31, 33, DateTimeKind.Local), "Velit commodi quae doloremque accusamus necessitatibus pariatur.", "7f5cb4d2-a78b-4210-9720-a33e01a768c1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 5, 7, 6, 59, 395, DateTimeKind.Local), "Ut saepe quidem sunt quidem eius dolor excepturi.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 8, 54, 22, 540, DateTimeKind.Local), "Accusantium modi possimus placeat quod ea molestiae architecto est aut.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 4, 18, 52, 27, 788, DateTimeKind.Local), "Dicta suscipit quo.", "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 4, 15, 27, 37, 373, DateTimeKind.Local), "Reiciendis cupiditate minus.", "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 0, 28, 36, 0, DateTimeKind.Local), "Sapiente minima aut nulla nam sunt eos voluptate illum.", "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 5, 10, 31, 22, 940, DateTimeKind.Local), "Enim iusto ducimus quo nihil ipsam fuga praesentium.", "85ecd13b-bea8-41c2-ab16-19d393693093", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 4, 16, 59, 8, 36, DateTimeKind.Local), "Modi consequatur aliquam itaque iure maxime earum reiciendis voluptatibus.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "efb7a095-74a7-430c-a647-23054ed25b36" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 4, "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "85ecd13b-bea8-41c2-ab16-19d393693093" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "6c0b1a42-427c-43a6-889c-cd19e3729593" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 0, "291b2e40-05f0-40d2-9162-3cb46c10055b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 1, "efb7a095-74a7-430c-a647-23054ed25b36" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 55, 21, 637, DateTimeKind.Local), 14, "Fuga ut ea sit quo blanditiis et minima.", "7f5cb4d2-a78b-4210-9720-a33e01a768c1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 20, 38, 13, 844, DateTimeKind.Local), 16, "Quis ab nostrum quia aut nesciunt.", "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 41, 5, 428, DateTimeKind.Local), 12, "Quae est distinctio autem dolor.", "291b2e40-05f0-40d2-9162-3cb46c10055b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 55, 0, 750, DateTimeKind.Local), 11, "Optio non ut et molestias voluptas sed.", "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 11, 50, 671, DateTimeKind.Local), 18, "Esse rerum aspernatur illum rem.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 41, 4, 825, DateTimeKind.Local), "Autem omnis suscipit quia ea.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 49, 16, 46, DateTimeKind.Local), 17, "Tempore nemo facilis.", "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 41, 12, 124, DateTimeKind.Local), 12, "In qui dolor dignissimos necessitatibus.", "6c0b1a42-427c-43a6-889c-cd19e3729593" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 14, 27, 39, 747, DateTimeKind.Local), 20, "Pariatur nesciunt excepturi voluptas quia.", "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 13, 0, 789, DateTimeKind.Local), 17, "Consectetur recusandae debitis voluptas nostrum et ut mollitia quaerat.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(496) 233-0408", "7f5cb4d2-a78b-4210-9720-a33e01a768c1", "Aut necessitatibus culpa accusantium nihil. Quasi minus eaque nesciunt eos adipisci praesentium explicabo est voluptas.", "Trey.Morissette@hotmail.com", "Company919", 61, "http://pinkie.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-303-268-0066 x2780", "85ecd13b-bea8-41c2-ab16-19d393693093", "", "Ricardo_Welch@gmail.com", "Company156", 68, "https://kallie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-394-300-7078 x82678", "1f91fc25-7cfd-4922-8e0f-36618e422329", "Error ad vel dolor modi eaque natus suscipit ex nihil.", "Eino73@yahoo.com", "Company152", 61, "http://avery.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "292-499-5168", "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", "Totam dolorem voluptatibus sequi et et maxime mollitia culpa. Totam placeat ut. In eveniet dignissimos assumenda alias non in officia tempore.", "Juana.Bradtke62@yahoo.com", "Company332", 61, "https://lorena.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-818-482-6082 x91367", "291b2e40-05f0-40d2-9162-3cb46c10055b", "Assumenda nihil aut dolores fugit quasi ipsum facilis sit. Unde est doloribus ea nam porro rerum quae. In consectetur ipsa sed. In reiciendis debitis ipsam minima quae adipisci corporis laudantium et.", "Ryleigh.Barton@yahoo.com", "Company263", 63, "http://marlon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-847-465-3673 x99118", "efb7a095-74a7-430c-a647-23054ed25b36", "Ut et amet ea quod.", "Christ55@hotmail.com", "Company171", 66, "https://avis.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "235-871-9892", "291b2e40-05f0-40d2-9162-3cb46c10055b", "Doloribus ipsum quibusdam enim alias at quaerat. Odit rerum rerum occaecati enim provident est.", "Katlyn_Balistreri@gmail.com", "Company202", 63, "https://braulio.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "836.570.3225", "efb7a095-74a7-430c-a647-23054ed25b36", "Ut molestiae ratione delectus quibusdam ut tempora ea sit. Tempora qui qui unde fugiat aliquid minima corporis. Consequatur quia qui. Dignissimos in quo est sint.", "Anabel_Cronin96@hotmail.com", "Company732", 65, "https://jazlyn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(722) 219-1109", "7f5cb4d2-a78b-4210-9720-a33e01a768c1", "Fuga nam qui tempore nihil reprehenderit sapiente. Quo delectus non est veritatis quae aut doloremque. Cum est dolores laboriosam aut excepturi vitae. Incidunt voluptate aut.", "Thalia67@gmail.com", "Company35", 64, "https://cayla.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "271-661-1115", "efb7a095-74a7-430c-a647-23054ed25b36", "Est amet sint voluptatem.", "Lorenza12@gmail.com", "Company365", 67, "https://vladimir.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 42, 13, 54, DateTimeKind.Local), 44, "Hic sed omnis vel est exercitationem.", "ca11cfd9-0022-4285-85a6-b14c84a5a0c0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 50, 16, 842, DateTimeKind.Local), 44, "Laboriosam in quisquam aut quia quia unde hic repellendus.", "efb7a095-74a7-430c-a647-23054ed25b36" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 4, 2, 846, DateTimeKind.Local), 44, "Assumenda distinctio deserunt dicta.", "7f5cb4d2-a78b-4210-9720-a33e01a768c1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 41, 40, 835, DateTimeKind.Local), 50, "Et voluptatum maxime.", "6c0b1a42-427c-43a6-889c-cd19e3729593" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 31, 48, 709, DateTimeKind.Local), "Consectetur aut labore et recusandae eveniet voluptas itaque.", "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 18, 20, 617, DateTimeKind.Local), 50, "Incidunt assumenda quam voluptatem.", "291b2e40-05f0-40d2-9162-3cb46c10055b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 14, 32, 10, 168, DateTimeKind.Local), 43, "Quisquam explicabo quia voluptas ullam recusandae quo quo aut reiciendis.", "291b2e40-05f0-40d2-9162-3cb46c10055b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 7, 0, 762, DateTimeKind.Local), 42, "Omnis reiciendis similique eligendi autem minima molestiae quisquam earum tempora.", "1f91fc25-7cfd-4922-8e0f-36618e422329" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 40, 33, 932, DateTimeKind.Local), 41, "Non quia fuga numquam in.", "2e669749-08c5-4bf0-a7f1-e70c416c44ee" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 15, 14, 95, DateTimeKind.Local), 50, "Voluptatum aliquid alias amet magni quo cum.", "85ecd13b-bea8-41c2-ab16-19d393693093" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9", 79, 1 },
                    { "85ecd13b-bea8-41c2-ab16-19d393693093", 79, 1 },
                    { "1f91fc25-7cfd-4922-8e0f-36618e422329", 75, 1 },
                    { "291b2e40-05f0-40d2-9162-3cb46c10055b", 72, 1 },
                    { "ca11cfd9-0022-4285-85a6-b14c84a5a0c0", 73, 1 },
                    { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", 74, 1 },
                    { "7f5cb4d2-a78b-4210-9720-a33e01a768c1", 71, 1 },
                    { "6c0b1a42-427c-43a6-889c-cd19e3729593", 74, 1 },
                    { "efb7a095-74a7-430c-a647-23054ed25b36", 76, 1 },
                    { "2e669749-08c5-4bf0-a7f1-e70c416c44ee", 75, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_OrganizationRoles_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId",
                principalTable: "OrganizationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganizations_OrganizationRoles_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DropIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1f91fc25-7cfd-4922-8e0f-36618e422329", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "291b2e40-05f0-40d2-9162-3cb46c10055b", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2e669749-08c5-4bf0-a7f1-e70c416c44ee", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6c0b1a42-427c-43a6-889c-cd19e3729593", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7f5cb4d2-a78b-4210-9720-a33e01a768c1", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "85ecd13b-bea8-41c2-ab16-19d393693093", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ca11cfd9-0022-4285-85a6-b14c84a5a0c0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "efb7a095-74a7-430c-a647-23054ed25b36", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15bdceaa-9bb4-4ef1-8c85-c7aed863fa60");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1f91fc25-7cfd-4922-8e0f-36618e422329");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "291b2e40-05f0-40d2-9162-3cb46c10055b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2e669749-08c5-4bf0-a7f1-e70c416c44ee");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6c0b1a42-427c-43a6-889c-cd19e3729593");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "797183d6-15f0-4fc3-a80c-f4a32e0d0ca9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7f5cb4d2-a78b-4210-9720-a33e01a768c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "85ecd13b-bea8-41c2-ab16-19d393693093");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ca11cfd9-0022-4285-85a6-b14c84a5a0c0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efb7a095-74a7-430c-a647-23054ed25b36");

            migrationBuilder.DropColumn(
                name: "OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 43 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 49, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", 20, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded" },
                values: new object[] { 92, "MostLoaded3" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 66, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 56, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", 65, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 98, "MostLoaded3", 66 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 43, 47, 22, DateTimeKind.Local), 89, "Title556" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 4, 39, 669, DateTimeKind.Local), 89, "Title712" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 52, 40, 361, DateTimeKind.Local), 89, "Title656" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 22, 19, 518, DateTimeKind.Local), 87, "Title746" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 10, 17, 995, DateTimeKind.Local), "Title906" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 32, 29, 301, DateTimeKind.Local), 90, "Title745" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 19, 38, 8, DateTimeKind.Local), 88, "Title101" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 24, 4, 133, DateTimeKind.Local), "Title940" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 26, 51, 702, DateTimeKind.Local), 89, "Title868" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 24, 44, 677, DateTimeKind.Local), 87, "Title17" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "61:d7:d8:5f:a4:61", 73, "Instance361" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "70:53:49:f9:b8:1c", 74, "Instance960" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e3:bd:e5:dc:2a:a1", 72, "Instance320" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ec:2e:59:8e:d1:6f", 71, "Instance840" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "47:7d:20:a1:8c:dc", 75, "Windows", "Instance784" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e0:26:e3:79:24:a3", 80, "Windows", "Instance773" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3d:8a:bd:92:33:41", 80, "Instance209" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "08:38:5e:d9:9b:65", 77, "Instance157" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2f:cc:eb:fe:82:c6", 73, "Instance311" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "7c:17:e5:c5:3a:bd", 78, "Linux", "Instance415" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme611" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme432" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme107" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme533" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme25" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme104");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme439" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Theme199");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme68" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme338" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", null, new DateTime(2018, 9, 5, 0, 14, 16, 920, DateTimeKind.Local), "Ulices", "Ayla.Lebsack@gmail.com", null, "Salvatore", true, false, "Grant", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ZacharyZorbas/128.jpg", 1 },
                    { "89babdf6-31d6-45d2-a725-16c5e80ea915", null, new DateTime(2018, 9, 4, 21, 12, 16, 512, DateTimeKind.Local), "Ottis", "Quinton.Jakubowski90@gmail.com", null, "Nils", true, false, "Bogan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/justinrob/128.jpg", 2 },
                    { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", null, new DateTime(2018, 9, 5, 10, 52, 38, 973, DateTimeKind.Local), "Leopoldo", "Yesenia_Will16@gmail.com", null, "Xander", true, false, "Mohr", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidbaldie/128.jpg", 2 },
                    { "52e27198-436d-4714-a6e7-e0d0738b847f", null, new DateTime(2018, 9, 5, 6, 32, 42, 645, DateTimeKind.Local), "Jerrell", "King_Eichmann67@hotmail.com", null, "Adeline", true, false, "Hoppe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/roybarberuk/128.jpg", 1 },
                    { "b3731d39-39d1-491c-950b-719b0606e9c5", null, new DateTime(2018, 9, 4, 18, 59, 44, 682, DateTimeKind.Local), "Alexzander", "Werner_Beer@yahoo.com", null, "Chauncey", true, false, "Hegmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/brenton_clarke/128.jpg", 2 },
                    { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", null, new DateTime(2018, 9, 4, 14, 38, 53, 519, DateTimeKind.Local), "Gracie", "Alysa_Hammes@yahoo.com", null, "Maiya", true, false, "Kuhic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jomarmen/128.jpg", 2 },
                    { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", null, new DateTime(2018, 9, 5, 6, 25, 27, 120, DateTimeKind.Local), "Tabitha", "Marcellus_Paucek82@hotmail.com", null, "Carolanne", true, false, "Johnson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vivekprvr/128.jpg", 1 },
                    { "4740e1d3-a664-49cf-bde9-24133792f2d8", null, new DateTime(2018, 9, 5, 3, 33, 17, 365, DateTimeKind.Local), "Theo", "Aglae.Brekke61@gmail.com", null, "Ubaldo", true, false, "Nitzsche", null, "https://s3.amazonaws.com/uifaces/faces/twitter/giancarlon/128.jpg", 2 },
                    { "307ee358-2383-4f80-b94f-26f489bdb30f", null, new DateTime(2018, 9, 5, 9, 25, 18, 97, DateTimeKind.Local), "Melisa", "Idell95@hotmail.com", null, "Herta", true, false, "Daugherty", null, "https://s3.amazonaws.com/uifaces/faces/twitter/pierrestoffe/128.jpg", 1 },
                    { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", null, new DateTime(2018, 9, 5, 5, 15, 55, 959, DateTimeKind.Local), "Yasmine", "Retta95@yahoo.com", null, "Leta", true, false, "Marks", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sindresorhus/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", "possimus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "in" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "307ee358-2383-4f80-b94f-26f489bdb30f", "voluptate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", "ea" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52e27198-436d-4714-a6e7-e0d0738b847f", "alias" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b3731d39-39d1-491c-950b-719b0606e9c5", "mollitia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "89babdf6-31d6-45d2-a725-16c5e80ea915", "omnis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 59, 20, 95, DateTimeKind.Local), "Magnam repellendus est suscipit cupiditate molestiae ad molestias.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 6, 16, 212, DateTimeKind.Local), "Eaque dolor amet.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 24, 56, 906, DateTimeKind.Local), "Alias qui pariatur iusto.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 10, 32, 102, DateTimeKind.Local), "Ea rerum assumenda perferendis ut.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 27, 57, 402, DateTimeKind.Local), "In rerum repellendus possimus hic aut suscipit nisi numquam.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 58, 19, 102, DateTimeKind.Local), "Laborum voluptates quae.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 55, 2, 510, DateTimeKind.Local), "Necessitatibus eius labore velit adipisci ea eum aliquid recusandae.", "89babdf6-31d6-45d2-a725-16c5e80ea915" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 17, 46, 648, DateTimeKind.Local), "Delectus totam illo adipisci rerum.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 19, 7, 612, DateTimeKind.Local), "Cum architecto libero.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 8, 28, 595, DateTimeKind.Local), "Quasi molestiae nobis dolores eveniet.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 4, 21, 19, 55, 38, DateTimeKind.Local), "Odit ipsum magni eum est delectus.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 13, 14, 42, 109, DateTimeKind.Local), "Ut in et aperiam aut rem ullam ipsa iusto.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 4, 15, 22, 32, 910, DateTimeKind.Local), "Est temporibus deserunt repellat.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 10, 36, 8, 508, DateTimeKind.Local), "Est et enim dolor beatae quisquam.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 49, 51, 602, DateTimeKind.Local), "Quia eos qui et.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 6, 33, 39, 8, DateTimeKind.Local), "Impedit vitae voluptatem est nam eaque dolor est.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 4, 22, 36, 26, 423, DateTimeKind.Local), "Molestiae delectus delectus cumque exercitationem modi quia.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 4, 20, 2, 47, 147, DateTimeKind.Local), "Eaque repellendus reprehenderit sapiente aliquid.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 1, 59, 37, 774, DateTimeKind.Local), "Similique sint nam excepturi eaque perspiciatis animi ducimus eos.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 8, 28, 47, 861, DateTimeKind.Local), "Nam rerum eum ut in rem.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "b3731d39-39d1-491c-950b-719b0606e9c5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 3, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 2, "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 27, 49, 68, DateTimeKind.Local), 12, "Soluta harum beatae esse quod enim occaecati illum voluptas.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 45, 39, 412, DateTimeKind.Local), 17, "Omnis dolores officia sapiente recusandae dignissimos veniam similique quidem eligendi.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 59, 52, 324, DateTimeKind.Local), 20, "Doloribus cupiditate officia magnam laudantium.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 21, 21, 456, DateTimeKind.Local), 18, "Minima velit dignissimos magnam est et eos beatae beatae.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 57, 25, 749, DateTimeKind.Local), 20, "Quasi accusamus vel adipisci veniam ut quae earum voluptas.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 25, 14, 44, DateTimeKind.Local), "Exercitationem aliquam voluptas odit est rerum repellendus.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 20, 6, 50, 697, DateTimeKind.Local), 16, "Consectetur deserunt tenetur est et tempore.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 45, 49, 436, DateTimeKind.Local), 20, "Qui porro iusto ut.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 34, 16, 876, DateTimeKind.Local), 13, "Hic autem in nostrum nesciunt quia est ipsam aut accusamus.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 25, 39, 387, DateTimeKind.Local), 14, "Ipsam voluptas consequatur est enim enim quia et ullam.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "334-328-8431", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", "", "Chanel_Kuhn63@yahoo.com", "Company414", 69, "https://rey.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "894.531.1390 x3861", "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "Molestiae fugiat exercitationem veniam quia placeat minima. Alias quae impedit cum porro enim. Voluptas eveniet in laborum aut repudiandae. Voluptatem sit aut aut harum at.", "Thomas24@yahoo.com", "Company4", 62, "https://freeda.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "544-466-5590 x515", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", "Fugit enim consequatur fugit nihil illum aut consequuntur. Deserunt sed maiores molestias eligendi saepe repellat provident tempore corrupti.", "Lavern.Hand0@gmail.com", "Company920", 69, "https://arnold.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "897.429.7651 x48560", "89babdf6-31d6-45d2-a725-16c5e80ea915", "Quasi sit ducimus. Perspiciatis qui aliquid. Eius consequuntur voluptatem quisquam placeat ad est fuga. Dolor labore id.", "Xander13@gmail.com", "Company761", 68, "https://cyrus.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "225-882-4609", "b3731d39-39d1-491c-950b-719b0606e9c5", "Rerum consequatur necessitatibus facere modi esse atque. Qui recusandae minima blanditiis atque incidunt consequuntur consequuntur quasi. Est quibusdam hic et impedit quos cupiditate odit incidunt voluptates. Magni consequuntur et porro voluptate asperiores est consequatur provident.", "Harvey72@hotmail.com", "Company560", 62, "https://ericka.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(563) 213-2115", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "", "Berenice.Kutch65@gmail.com", "Company843", 69, "http://ena.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "597.605.7450 x468", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "Esse corporis eum perferendis enim voluptas quasi. Voluptatem consequatur sapiente esse et. Alias sunt ut.", "Dax53@gmail.com", "Company478", 61, "http://haleigh.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(260) 482-0362", "b3731d39-39d1-491c-950b-719b0606e9c5", "Ut assumenda aut nesciunt sequi.", "Ivory_Bayer@yahoo.com", "Company962", 66, "https://hank.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(859) 796-7617 x454", "307ee358-2383-4f80-b94f-26f489bdb30f", "Sed et soluta recusandae ducimus facilis odit. Modi id corrupti dolores doloribus aut rerum vel omnis. Non quos est est alias eum nihil autem omnis aliquid.", "Ophelia1@yahoo.com", "Company506", 61, "https://ethelyn.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(834) 417-5237 x5129", "8ce60506-64fa-4b47-a167-f77a2bbe46bc", "Pariatur excepturi quasi sunt possimus maiores. Minus ipsam dolores a.", "Alexandrine.Schneider@gmail.com", "Company874", 64, "http://vesta.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 31, 3, 983, DateTimeKind.Local), 42, "Et consequuntur laborum maiores eligendi eum non animi.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 34, 1, 176, DateTimeKind.Local), 48, "Magni enim voluptatibus quam ut voluptatem eum animi ipsum vel.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 33, 15, 700, DateTimeKind.Local), 47, "Sit ut nam odio soluta ipsum et ad nam.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 55, 8, 986, DateTimeKind.Local), 47, "Perferendis explicabo beatae eveniet.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 52, 19, 935, DateTimeKind.Local), "Possimus rerum ut tempora.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 23, 30, 324, DateTimeKind.Local), 41, "Maiores in pariatur quia quo ab accusantium.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 29, 21, 204, DateTimeKind.Local), 47, "Explicabo at est.", "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 11, 18, 556, DateTimeKind.Local), 50, "Consequatur molestias sunt sint rerum rem aut est in a.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 37, 47, 174, DateTimeKind.Local), 42, "Et placeat cum aliquid minus ducimus consequatur.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 12, 57, 670, DateTimeKind.Local), 45, "Fugiat ad qui ex.", "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", 72 },
                    { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", 73 },
                    { "52e27198-436d-4714-a6e7-e0d0738b847f", 78 },
                    { "b3731d39-39d1-491c-950b-719b0606e9c5", 76 },
                    { "307ee358-2383-4f80-b94f-26f489bdb30f", 74 },
                    { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", 78 },
                    { "89babdf6-31d6-45d2-a725-16c5e80ea915", 75 },
                    { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", 78 },
                    { "4740e1d3-a664-49cf-bde9-24133792f2d8", 77 },
                    { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", 72 }
                });
        }
    }
}
