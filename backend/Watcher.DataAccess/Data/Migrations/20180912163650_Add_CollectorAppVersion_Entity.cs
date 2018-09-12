using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Add_CollectorAppVersion_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "371e89b4-51e8-42e6-bd2b-5af8fd77078d", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9acb124f-1287-4ed6-8b4c-95a647b68f7f", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b2de8088-0082-443c-bbc8-b371d5a27ff2", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b7002900-2813-4bba-9c01-835a58145c98", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f2e46ed8-f6e3-4859-b73e-394d18b11d29", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", 66 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "371e89b4-51e8-42e6-bd2b-5af8fd77078d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8f5487ae-243e-4fe1-9051-8c3aaf7f0013");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94129cf8-f4b4-405a-b126-ce33d9dd4f10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9acb124f-1287-4ed6-8b4c-95a647b68f7f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a8d9f652-14dd-4965-a9ef-1df16b2700b6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b2de8088-0082-443c-bbc8-b371d5a27ff2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b7002900-2813-4bba-9c01-835a58145c98");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f2e46ed8-f6e3-4859-b73e-394d18b11d29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f60f47f6-3900-47e6-a4d4-2589dfaa12c8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734");

            migrationBuilder.CreateTable(
                name: "CollectorAppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    ExeLink = table.Column<string>(nullable: true),
                    DebLink = table.Column<string>(nullable: true),
                    TgzLink = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectorAppVersions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 39, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 80, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 88, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 76, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 85, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 82, 93, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 14, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 83, 30, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Threshold",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 20, 27, 49, DateTimeKind.Local), 76, "Title517" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 36, 34, 79, DateTimeKind.Local), 80, "Title481" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 48, 0, 485, DateTimeKind.Local), 74, "Title251" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 55, 11, 390, DateTimeKind.Local), 72, "Title66" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 55, 43, 464, DateTimeKind.Local), 78, "Title622" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 27, 30, 782, DateTimeKind.Local), 73, "Title588" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 20, 19, 432, DateTimeKind.Local), 77, "Title183" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 54, 33, 558, DateTimeKind.Local), "Title296" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 56, 34, 871, DateTimeKind.Local), 78, "Title934" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 19, 28, 646, DateTimeKind.Local), 74, "Title823" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "93:04:c2:97:dd:22", 63, "Instance595" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d5:d7:a4:87:f7:68", 61, "Instance726" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ed:47:ea:9f:57:79", 66, "Instance534" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5b:4e:aa:ef:b2:36", 62, "Windows", "Instance998" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8d:9c:f1:0c:a9:b7", 62, "Instance743" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "Title" },
                values: new object[] { "7d:c1:0f:ad:61:4c", "Instance754" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "98:1f:60:6c:e6:86", 62, "Windows", "Instance248" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "48:3c:97:9c:5d:50", "Linux", "Instance829" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "48:06:63:c9:d0:9a", 63, "Instance959" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "1c:fc:8e:5a:53:6d", "Linux", "Instance555" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", null, new DateTime(2018, 9, 12, 11, 21, 35, 418, DateTimeKind.Local), "Manley", "Virgil_Weissnat@yahoo.com", null, "Ed", true, false, "Baumbach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/reabo101/128.jpg", 2 },
                    { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", null, new DateTime(2018, 9, 12, 4, 42, 43, 356, DateTimeKind.Local), "Lizzie", "Marques45@gmail.com", null, "Armani", true, false, "Kilback", null, "https://s3.amazonaws.com/uifaces/faces/twitter/marakasina/128.jpg", 1 },
                    { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", null, new DateTime(2018, 9, 12, 7, 40, 13, 876, DateTimeKind.Local), "Brigitte", "Mercedes82@gmail.com", null, "Domenica", true, false, "Frami", null, "https://s3.amazonaws.com/uifaces/faces/twitter/notbadart/128.jpg", 2 },
                    { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", null, new DateTime(2018, 9, 12, 10, 24, 3, 739, DateTimeKind.Local), "Kennedi", "Fritz.Batz@yahoo.com", null, "Jules", true, false, "Gutmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sircalebgrove/128.jpg", 2 },
                    { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", null, new DateTime(2018, 9, 12, 17, 12, 58, 427, DateTimeKind.Local), "Trystan", "Bryana.Kuhic@hotmail.com", null, "Barney", true, false, "Morissette", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tomas_janousek/128.jpg", 1 },
                    { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", null, new DateTime(2018, 9, 12, 6, 33, 51, 756, DateTimeKind.Local), "Heaven", "Neal_Fay@yahoo.com", null, "Desiree", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mizhgan/128.jpg", 1 },
                    { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", null, new DateTime(2018, 9, 12, 2, 11, 37, 450, DateTimeKind.Local), "Enola", "Ed7@yahoo.com", null, "Keven", true, false, "Waelchi", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mutu_krish/128.jpg", 2 },
                    { "e7ca053c-4bec-4203-9aa0-997b882c951a", null, new DateTime(2018, 9, 12, 9, 43, 22, 693, DateTimeKind.Local), "Josianne", "Samanta.Armstrong72@gmail.com", null, "Gerda", true, false, "Corkery", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nessoila/128.jpg", 1 },
                    { "2ee32823-b021-4550-8e5f-b088c23fd874", null, new DateTime(2018, 9, 11, 23, 43, 45, 369, DateTimeKind.Local), "Wilma", "Elaina.Conroy82@hotmail.com", null, "Alysson", true, false, "Schamberger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/aoimedia/128.jpg", 1 },
                    { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", null, new DateTime(2018, 9, 12, 10, 13, 45, 193, DateTimeKind.Local), "Layla", "Cassidy.Swift63@gmail.com", null, "Alan", true, false, "Lebsack", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dhrubo/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", "quibusdam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "a" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "numquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", "inventore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "saepe" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2ee32823-b021-4550-8e5f-b088c23fd874", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "aliquid" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 51, 53, 758, DateTimeKind.Local), "Qui explicabo laboriosam.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 27, 39, 578, DateTimeKind.Local), "Dolorum hic atque officiis.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 25, 31, 347, DateTimeKind.Local), "Voluptatibus fuga sit et eum enim ipsum.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 51, 2, 365, DateTimeKind.Local), "Possimus aspernatur qui reiciendis dolorem.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 12, 31, 161, DateTimeKind.Local), "Voluptas ducimus corporis voluptates.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 30, 38, 260, DateTimeKind.Local), "Ut harum facilis ullam facere.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 41, 42, 699, DateTimeKind.Local), "Laudantium in quaerat accusantium.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 4, 23, 530, DateTimeKind.Local), "Provident sapiente alias quo qui necessitatibus.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 52, 48, 900, DateTimeKind.Local), "Exercitationem sint placeat fugit culpa nemo.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 44, 36, 491, DateTimeKind.Local), "Voluptatem aperiam rerum non fugiat.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 5, 39, 2, 576, DateTimeKind.Local), "Itaque quo dolores cupiditate.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 1, 31, 57, 152, DateTimeKind.Local), "Nam praesentium rerum autem fugit incidunt quidem.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 12, 46, 37, 858, DateTimeKind.Local), "Dolorem ducimus temporibus omnis sunt repudiandae accusantium voluptate dolores.", "2ee32823-b021-4550-8e5f-b088c23fd874" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 14, 17, 55, 412, DateTimeKind.Local), "Culpa nam qui dolorum.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 16, 21, 25, 909, DateTimeKind.Local), "Et vitae aperiam et consequatur sed ullam.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 19, 25, 32, 705, DateTimeKind.Local), "Ut nisi ut omnis libero ut est quasi aliquid.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 12, 8, 19, 40, 625, DateTimeKind.Local), "Aut incidunt magni iusto iure qui cum molestiae.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 3, 30, 182, DateTimeKind.Local), "Sed adipisci rem.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 9, 30, 32, 36, DateTimeKind.Local), "Voluptatem pariatur vero voluptatem magnam.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 17, 58, 11, 879, DateTimeKind.Local), "Natus aut ea.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 3, "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 4, "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "2ee32823-b021-4550-8e5f-b088c23fd874" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 2, "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 1, "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 43, 26, 305, DateTimeKind.Local), 20, "Maiores assumenda corrupti maxime asperiores cupiditate labore et.", "2ee32823-b021-4550-8e5f-b088c23fd874" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 37, 22, 18, DateTimeKind.Local), 14, "Voluptatum explicabo aperiam tempora doloribus excepturi et ullam.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 48, 44, 338, DateTimeKind.Local), 19, "Qui earum sed ut sint vero.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 7, 45, 344, DateTimeKind.Local), 14, "Ut officia qui dolorem recusandae facilis eos iste.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 8, 25, 527, DateTimeKind.Local), 11, "Eum magni ipsam quas inventore ut at quia neque.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 38, 16, 254, DateTimeKind.Local), 19, "Ab doloribus saepe excepturi illo.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 52, 43, 362, DateTimeKind.Local), 16, "Eum ducimus vitae neque in maiores nesciunt earum quasi.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 21, 34, 540, DateTimeKind.Local), 16, "Ea aperiam esse.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 31, 58, 418, DateTimeKind.Local), 18, "Et culpa ipsum aut voluptatum rerum et dolore.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 16, 18, 563, DateTimeKind.Local), 18, "Hic sit ullam accusamus quam saepe assumenda accusamus ab.", "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "904-366-5161", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "Labore ducimus sint ut. Repudiandae eos qui. Illum fugit et et similique eum reprehenderit molestias praesentium labore. Dolore et voluptas enim omnis modi pariatur.", "King24@gmail.com", "Company418", 1, "https://tiffany.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "300.425.0816 x1838", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", "Est autem et et beatae eligendi qui. Assumenda ex eos sunt optio facere dolorem ut in et. Tempora placeat incidunt.", "Irving.Runte63@yahoo.com", "Company579", "https://dangelo.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "977.548.1294 x41479", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Qui excepturi vero esse occaecati dolores voluptatem. Voluptas quam minima nemo nostrum voluptatem enim quia omnis.", "Wilfred.Parker@hotmail.com", "Company802", 2, "https://destini.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "740-976-5325", "e7ca053c-4bec-4203-9aa0-997b882c951a", "Blanditiis nulla sapiente et sequi neque delectus soluta. Consequuntur accusamus corrupti incidunt nesciunt incidunt praesentium dolorem aut. Assumenda ad numquam provident laboriosam consequatur non error molestias amet. Occaecati aut incidunt officiis saepe omnis asperiores.", "Felix.Mueller25@yahoo.com", "Company622", "http://arvid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-350-542-3689", "3f7af429-6ed4-40e8-ac34-299fe0d586e5", "Quos enim est possimus aliquam ea. Blanditiis laudantium odio repellendus est. Rem at repudiandae labore vel reprehenderit ut quasi.", "Francesca99@hotmail.com", "Company162", 1, "https://lance.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(403) 274-3967 x6849", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Eum consequatur omnis et iure quam.", "Hilma.OHara@gmail.com", "Company109", "https://cara.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "880.996.0464", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Praesentium voluptatem et maiores eveniet animi non minima. Sit excepturi fugit fuga non porro asperiores iste tempora asperiores. Praesentium vel fuga dolores atque itaque dolorum.", "Leopold53@hotmail.com", "Company229", "https://coty.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "425-737-4490", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", "Quos consequuntur ut facilis rerum sunt. Sapiente reiciendis rerum voluptatibus eveniet aut et. Sed inventore consequatur quasi ducimus deserunt sapiente. Possimus omnis eaque odit cumque.", "Joaquin.Johnston@gmail.com", "Company996", 1, "https://benny.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "737-237-8123 x5047", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", "Deleniti sunt animi laudantium et voluptatum possimus necessitatibus dolor. A reiciendis incidunt sit incidunt distinctio quisquam nulla et.", "Theodora.Lebsack@gmail.com", "Company54", 2, "https://megane.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-977-618-8124", "b785f6e0-927e-465f-bd0c-f80fe56e6a37", "Quod repudiandae rerum tempora fugit ut nemo. Et et quo ducimus ut voluptatem et. Incidunt rerum in est inventore. Maiores libero enim dolores iste fugiat eaque quisquam dolorum.", "Dahlia87@yahoo.com", "Company31", "http://celia.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 1, 53, 507, DateTimeKind.Local), 50, "Accusamus non ea voluptates et reprehenderit.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 23, 2, 738, DateTimeKind.Local), 41, "Voluptates molestiae reprehenderit odio et.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 31, 30, 614, DateTimeKind.Local), 47, "Quibusdam ipsum est nesciunt.", "c8cbd2c7-f945-4fe2-9c5f-16a93334e847" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 29, 37, 132, DateTimeKind.Local), 41, "Et autem alias magni ipsum.", "cc463ef1-3498-4b49-8450-aaaafcd1dcb8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 15, 25, 547, DateTimeKind.Local), 47, "Nulla perspiciatis nam quia.", "e7ca053c-4bec-4203-9aa0-997b882c951a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 28, 27, 995, DateTimeKind.Local), 48, "Neque molestiae sapiente aut autem aliquam suscipit dolorem officia voluptates.", "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 36, 22, 523, DateTimeKind.Local), "Consequatur a magni temporibus sed repudiandae numquam id ullam minima.", "3f7af429-6ed4-40e8-ac34-299fe0d586e5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 36, 55, 46, DateTimeKind.Local), 49, "Laboriosam sed quos iure maiores adipisci nisi aut.", "48ee168e-2faf-46e5-aa8c-8f6f7805e83f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 50, 54, 814, DateTimeKind.Local), 48, "Nam corporis qui eius illum et ea.", "b785f6e0-927e-465f-bd0c-f80fe56e6a37" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 4, 20, 976, DateTimeKind.Local), 45, "Occaecati dolore placeat placeat nihil et nobis laudantium est porro.", "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", 69, 1 },
                    { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", 67, 1 },
                    { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", 61, 1 },
                    { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", 63, 1 },
                    { "2ee32823-b021-4550-8e5f-b088c23fd874", 61, 1 },
                    { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", 66, 1 },
                    { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", 68, 1 },
                    { "e7ca053c-4bec-4203-9aa0-997b882c951a", 63, 1 },
                    { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", 69, 1 },
                    { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", 63, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectorAppVersions");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2ee32823-b021-4550-8e5f-b088c23fd874", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3f7af429-6ed4-40e8-ac34-299fe0d586e5", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48ee168e-2faf-46e5-aa8c-8f6f7805e83f", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b785f6e0-927e-465f-bd0c-f80fe56e6a37", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c8cbd2c7-f945-4fe2-9c5f-16a93334e847", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cc463ef1-3498-4b49-8450-aaaafcd1dcb8", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7ca053c-4bec-4203-9aa0-997b882c951a", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a", 69 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ee32823-b021-4550-8e5f-b088c23fd874");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3f7af429-6ed4-40e8-ac34-299fe0d586e5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48ee168e-2faf-46e5-aa8c-8f6f7805e83f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6063a3ce-cac8-4cfc-a2c0-26b9e8bb6b97");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aa977dc2-4d2e-49c5-9dd6-f9cd7b0e90a7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b785f6e0-927e-465f-bd0c-f80fe56e6a37");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c8cbd2c7-f945-4fe2-9c5f-16a93334e847");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cc463ef1-3498-4b49-8450-aaaafcd1dcb8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7ca053c-4bec-4203-9aa0-997b882c951a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ec78b0f9-a9cf-41e1-9dd5-95e35adff60a");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 69, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 83, 53, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 21, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 83, 15, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 33, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Threshold",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 40, 26, 697, DateTimeKind.Local), 73, "Title662" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 39, 36, 543, DateTimeKind.Local), 77, "Title611" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 59, 42, 450, DateTimeKind.Local), 77, "Title622" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 25, 18, 139, DateTimeKind.Local), 75, "Title325" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 38, 34, 58, DateTimeKind.Local), 71, "Title992" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 45, 35, 503, DateTimeKind.Local), 71, "Title726" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 46, 46, 757, DateTimeKind.Local), 71, "Title224" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 1, 34, 793, DateTimeKind.Local), "Title704" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 33, 14, 895, DateTimeKind.Local), 71, "Title437" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 2, 48, 161, DateTimeKind.Local), 79, "Title740" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8d:79:8f:09:41:73", 66, "Instance167" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ef:95:d0:e0:ff:f9", 66, "Instance628" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "23:5f:5d:c6:ec:8b", 63, "Instance442" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4a:14:0c:86:c6:07", 66, "Linux", "Instance362" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "50:3d:fe:a5:71:ce", 69, "Instance759" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "Title" },
                values: new object[] { "9b:b2:51:bd:38:2d", "Instance267" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3a:a4:09:54:03:da", 66, "Linux", "Instance110" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "72:fc:b4:3d:1c:e5", "Windows", "Instance100" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a4:78:9b:4f:b0:98", 68, "Instance330" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "eb:be:70:0c:f9:ac", "Windows", "Instance303" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "371e89b4-51e8-42e6-bd2b-5af8fd77078d", null, new DateTime(2018, 9, 11, 23, 24, 57, 884, DateTimeKind.Local), "Clint", "Corene32@gmail.com", null, "Salma", true, false, "Brakus", null, "https://s3.amazonaws.com/uifaces/faces/twitter/claudioguglieri/128.jpg", 1 },
                    { "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", null, new DateTime(2018, 9, 11, 21, 37, 47, 869, DateTimeKind.Local), "Velda", "Mabel.Hermiston@gmail.com", null, "Blake", true, false, "Johnson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 1 },
                    { "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", null, new DateTime(2018, 9, 12, 8, 15, 20, 103, DateTimeKind.Local), "Ryann", "Jermain49@hotmail.com", null, "Daisha", true, false, "Gaylord", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jmfsocial/128.jpg", 1 },
                    { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", null, new DateTime(2018, 9, 11, 21, 41, 50, 691, DateTimeKind.Local), "Mae", "Angeline39@yahoo.com", null, "Margarita", true, false, "Skiles", null, "https://s3.amazonaws.com/uifaces/faces/twitter/SULiik/128.jpg", 2 },
                    { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", null, new DateTime(2018, 9, 11, 21, 7, 51, 904, DateTimeKind.Local), "Sofia", "Nettie_Halvorson@yahoo.com", null, "Perry", true, false, "Weimann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joki4/128.jpg", 1 },
                    { "f2e46ed8-f6e3-4859-b73e-394d18b11d29", null, new DateTime(2018, 9, 11, 22, 19, 32, 362, DateTimeKind.Local), "Tristian", "Hillary.McCullough@gmail.com", null, "Henderson", true, false, "Tillman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ssbb_me/128.jpg", 1 },
                    { "9acb124f-1287-4ed6-8b4c-95a647b68f7f", null, new DateTime(2018, 9, 11, 13, 24, 29, 86, DateTimeKind.Local), "Billy", "Anderson.Grimes57@yahoo.com", null, "Paris", true, false, "Rodriguez", null, "https://s3.amazonaws.com/uifaces/faces/twitter/charliegann/128.jpg", 2 },
                    { "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", null, new DateTime(2018, 9, 11, 16, 34, 7, 749, DateTimeKind.Local), "Shaylee", "Blanche42@hotmail.com", null, "Jakayla", true, false, "VonRueden", null, "https://s3.amazonaws.com/uifaces/faces/twitter/herbigt/128.jpg", 2 },
                    { "b2de8088-0082-443c-bbc8-b371d5a27ff2", null, new DateTime(2018, 9, 11, 16, 4, 32, 929, DateTimeKind.Local), "Maci", "Casandra.Quigley93@hotmail.com", null, "Hannah", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joshuasortino/128.jpg", 1 },
                    { "b7002900-2813-4bba-9c01-835a58145c98", null, new DateTime(2018, 9, 11, 22, 6, 13, 661, DateTimeKind.Local), "Delta", "Alia_Murphy@gmail.com", null, "Caleigh", true, false, "Lemke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ratbus/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", "amet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f2e46ed8-f6e3-4859-b73e-394d18b11d29", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b2de8088-0082-443c-bbc8-b371d5a27ff2", "omnis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", "molestiae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9acb124f-1287-4ed6-8b4c-95a647b68f7f", "exercitationem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b7002900-2813-4bba-9c01-835a58145c98", "ut" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 12, 28, 93, DateTimeKind.Local), "Eveniet asperiores sunt praesentium voluptas et sit architecto mollitia.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 47, 17, 469, DateTimeKind.Local), "Repudiandae tenetur eos quia qui cupiditate voluptatem.", "b7002900-2813-4bba-9c01-835a58145c98" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 36, 21, 92, DateTimeKind.Local), "Sed ad itaque libero earum et quia soluta.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 47, 24, 795, DateTimeKind.Local), "Suscipit molestiae laudantium.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 0, 21, 198, DateTimeKind.Local), "Et eaque molestiae doloribus et sequi quia.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 18, 15, 259, DateTimeKind.Local), "Consequatur facilis praesentium officia.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 47, 16, 792, DateTimeKind.Local), "Autem illum cupiditate distinctio.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 31, 46, 918, DateTimeKind.Local), "Repudiandae est sint omnis in accusantium cum neque voluptas.", "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 8, 50, 552, DateTimeKind.Local), "Ipsa maxime in quia qui harum.", "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 7, 12, 745, DateTimeKind.Local), "Eaque ullam alias quia et omnis libero qui consequatur pariatur.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 20, 48, 55, 440, DateTimeKind.Local), "Velit sint odit.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 1, 51, 4, 136, DateTimeKind.Local), "Atque ut voluptas omnis et optio consequatur dolorem enim.", "b2de8088-0082-443c-bbc8-b371d5a27ff2", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 12, 3, 12, 35, 479, DateTimeKind.Local), "Aliquam est qui soluta ut et natus.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 21, 8, 12, 35, DateTimeKind.Local), "Est deleniti excepturi dicta aut laboriosam voluptates aperiam earum.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 13, 9, 20, 254, DateTimeKind.Local), "Saepe labore excepturi vel vero repellat nemo officiis nam blanditiis.", "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 12, 42, 16, 190, DateTimeKind.Local), "Atque doloremque eius earum.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 6, 39, 43, 132, DateTimeKind.Local), "Porro aperiam ab est.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 6, 2, 824, DateTimeKind.Local), "Natus aut voluptatem corrupti itaque.", "b7002900-2813-4bba-9c01-835a58145c98", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 4, 26, 26, 127, DateTimeKind.Local), "Inventore quod quia quam eos qui praesentium ab aliquid.", "371e89b4-51e8-42e6-bd2b-5af8fd77078d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 11, 15, 24, 533, DateTimeKind.Local), "Quis nam qui rerum provident ad quos.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 2, "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 24, 15, 649, DateTimeKind.Local), 11, "Optio occaecati esse.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 2, 5, 151, DateTimeKind.Local), 19, "Non cumque accusamus labore quibusdam voluptate libero inventore et.", "8f5487ae-243e-4fe1-9051-8c3aaf7f0013" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 11, 49, 291, DateTimeKind.Local), 15, "Nisi qui modi sunt ullam rerum.", "b7002900-2813-4bba-9c01-835a58145c98" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 11, 24, 568, DateTimeKind.Local), 17, "Qui aspernatur quas dolorum qui minus.", "b7002900-2813-4bba-9c01-835a58145c98" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 34, 55, 814, DateTimeKind.Local), 16, "Qui nihil autem iusto rem aliquid et ut nam.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 14, 13, 624, DateTimeKind.Local), 18, "Inventore distinctio ut ullam voluptas et minus.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 59, 0, 203, DateTimeKind.Local), 11, "Voluptatum qui exercitationem repellendus eius.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 16, 4, 760, DateTimeKind.Local), 13, "Sed sunt et ex repellendus aspernatur hic.", "371e89b4-51e8-42e6-bd2b-5af8fd77078d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 45, 47, 500, DateTimeKind.Local), 15, "Eos pariatur in dignissimos.", "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 30, 10, 297, DateTimeKind.Local), 11, "Ipsum sint voluptatibus excepturi libero sed sapiente sit.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-697-554-2429 x0024", "b7002900-2813-4bba-9c01-835a58145c98", "Hic ullam in. Sed recusandae eaque eum non. Ipsum et officia quia.", "Enrico23@hotmail.com", "Company963", 2, "https://afton.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "906.988.0244", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "", "Jamel_Nader@hotmail.com", "Company158", "http://eryn.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(523) 655-2975 x14953", "f2e46ed8-f6e3-4859-b73e-394d18b11d29", "", "Floyd_Gerhold@hotmail.com", "Company395", 1, "https://vergie.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "996.512.2577 x82041", "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", "Aut vel molestiae.", "Marilou8@gmail.com", "Company515", "https://felicia.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-201-887-3058", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "Quia ab labore quia et perferendis qui sed.", "Natasha20@hotmail.com", "Company892", 2, "http://tiffany.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "260-202-1486 x4688", "b7002900-2813-4bba-9c01-835a58145c98", "Neque voluptate enim velit cumque earum. Sunt sed expedita sit. Officiis eaque ut eum laudantium.", "Marielle.Jaskolski@yahoo.com", "Company676", "http://helmer.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "779.889.1691 x85540", "b2de8088-0082-443c-bbc8-b371d5a27ff2", "Nulla vel odit qui fugiat et nihil. Vitae cumque totam qui harum est qui et qui a. Est eveniet adipisci aliquid ut.", "Meghan.Schneider@gmail.com", "Company990", "http://bernadette.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "800-272-6035 x66947", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", "", "Kris_Gleichner47@hotmail.com", "Company863", 2, "http://monique.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-348-370-2684 x1577", "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", "Ullam nam temporibus quasi voluptas omnis et.", "Queenie_Wehner@gmail.com", "Company27", 1, "http://hiram.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-413-844-8283", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "Qui perferendis et. Rerum dolorum tenetur vel reprehenderit quo et ut accusantium.", "Jaycee78@gmail.com", "Company506", "https://emmy.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 52, 15, 704, DateTimeKind.Local), 45, "Architecto beatae labore et.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 50, 37, 38, DateTimeKind.Local), 44, "Aut ducimus sit reprehenderit.", "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 31, 58, 429, DateTimeKind.Local), 43, "Autem doloremque ut saepe et debitis nihil repudiandae.", "371e89b4-51e8-42e6-bd2b-5af8fd77078d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 45, 0, 592, DateTimeKind.Local), 49, "Sit rem dolorem.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 23, 0, 822, DateTimeKind.Local), 49, "Voluptatem aut beatae quia consequatur aperiam placeat incidunt.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 7, 16, 584, DateTimeKind.Local), 44, "Ut enim ducimus in illum iste facere autem.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 3, 38, 863, DateTimeKind.Local), "Vel quis qui amet sit.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 38, 46, 387, DateTimeKind.Local), 44, "Maxime architecto vel porro at sed eos ab facilis sunt.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 23, 48, 193, DateTimeKind.Local), 46, "Minus similique eveniet ut rerum inventore dolores voluptatum libero iste.", "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 4, 36, 365, DateTimeKind.Local), 49, "Natus ut similique qui ut temporibus animi.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "371e89b4-51e8-42e6-bd2b-5af8fd77078d", 64, 1 },
                    { "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", 69, 1 },
                    { "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", 66, 1 },
                    { "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", 66, 1 },
                    { "b2de8088-0082-443c-bbc8-b371d5a27ff2", 65, 1 },
                    { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", 64, 1 },
                    { "f2e46ed8-f6e3-4859-b73e-394d18b11d29", 69, 1 },
                    { "9acb124f-1287-4ed6-8b4c-95a647b68f7f", 67, 1 },
                    { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", 69, 1 },
                    { "b7002900-2813-4bba-9c01-835a58145c98", 67, 1 }
                });
        }
    }
}
