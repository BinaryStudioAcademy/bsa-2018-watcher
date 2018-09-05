using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class OrganizationRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "047c0189-76a6-4446-8294-3d5e0d3e5d9c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2133e14e-a893-4630-9c75-b8f41dce4c1c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2984b34d-5667-4986-8eef-ec4e17658c33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37cdecd7-aaac-4dc2-9c84-7e7289b521c4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "538a13da-2a85-426a-80fb-3388aa78c68a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8948ed9a-bc9b-4fa4-bd76-e196ae717a71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b2afb5d0-3114-42ab-806c-1f127173d81f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8354a9d-9f70-454a-8fb6-bf15ca19cf85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f7a272fa-80ff-48b3-a78a-a800be071761");

            migrationBuilder.CreateTable(
                name: "OrganizationRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationRoles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", 43, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 1, 3 });

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
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", 49, 3 });

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
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", 42, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", 66, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", 56, 2 });

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
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", 66, 2 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 10, 17, 995, DateTimeKind.Local), 87, "Title906" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 24, 4, 133, DateTimeKind.Local), 87, "Title940" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "61:d7:d8:5f:a4:61", 73, "Windows", "Instance361" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "70:53:49:f9:b8:1c", 74, "Linux", "Instance960" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ec:2e:59:8e:d1:6f", 71, "Linux", "Instance840" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "47:7d:20:a1:8c:dc", 75, "Instance784" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3d:8a:bd:92:33:41", 80, "Linux", "Instance209" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "08:38:5e:d9:9b:65", "Linux", "Instance157" });

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

            migrationBuilder.InsertData(
                table: "OrganizationRoles",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Manager" },
                    { 2, false, "Member" }
                });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme611" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme432");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme107" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Theme533");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme25" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme104" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme199" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme68");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme338" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 13, 14, 42, 109, DateTimeKind.Local), "Ut in et aperiam aut rem ullam ipsa iusto.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 10, 36, 8, 508, DateTimeKind.Local), "Est et enim dolor beatae quisquam.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 10, 49, 51, 602, DateTimeKind.Local), "Quia eos qui et.", "4740e1d3-a664-49cf-bde9-24133792f2d8", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 6, 33, 39, 8, DateTimeKind.Local), "Impedit vitae voluptatem est nam eaque dolor est.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 4, 22, 36, 26, 423, DateTimeKind.Local), "Molestiae delectus delectus cumque exercitationem modi quia.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 4, 20, 2, 47, 147, DateTimeKind.Local), "Eaque repellendus reprehenderit sapiente aliquid.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 8, 28, 47, 861, DateTimeKind.Local), "Nam rerum eum ut in rem.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 2, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "b3731d39-39d1-491c-950b-719b0606e9c5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "307ee358-2383-4f80-b94f-26f489bdb30f" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 59, 52, 324, DateTimeKind.Local), "Doloribus cupiditate officia magnam laudantium.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 25, 14, 44, DateTimeKind.Local), 16, "Exercitationem aliquam voluptas odit est rerum repellendus.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "544-466-5590 x515", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", "Fugit enim consequatur fugit nihil illum aut consequuntur. Deserunt sed maiores molestias eligendi saepe repellat provident tempore corrupti.", "Lavern.Hand0@gmail.com", "Company920", "https://arnold.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "897.429.7651 x48560", "89babdf6-31d6-45d2-a725-16c5e80ea915", "Quasi sit ducimus. Perspiciatis qui aliquid. Eius consequuntur voluptatem quisquam placeat ad est fuga. Dolor labore id.", "Xander13@gmail.com", "Company761", "https://cyrus.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(859) 796-7617 x454", "307ee358-2383-4f80-b94f-26f489bdb30f", "Sed et soluta recusandae ducimus facilis odit. Modi id corrupti dolores doloribus aut rerum vel omnis. Non quos est est alias eum nihil autem omnis aliquid.", "Ophelia1@yahoo.com", "Company506", "https://ethelyn.info" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 52, 19, 935, DateTimeKind.Local), 48, "Possimus rerum ut tempora.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationRoles");

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

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", 92, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 35, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", 93, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", 21, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", 59, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", 30, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", 45, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 13, 46, 552, DateTimeKind.Local), 85, "Title393" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 14, 42, 744, DateTimeKind.Local), 86, "Title649" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 15, 31, 10, 63, DateTimeKind.Local), 87, "Title369" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 10, 28, 226, DateTimeKind.Local), 83, "Title718" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 46, 17, 771, DateTimeKind.Local), 89, "Title472" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 37, 15, 617, DateTimeKind.Local), 89, "Title404" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 4, 35, 12, 8, DateTimeKind.Local), 84, "Title804" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 27, 43, 183, DateTimeKind.Local), 86, "Title641" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 18, 15, 52, 397, DateTimeKind.Local), 87, "Title322" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 34, 41, 251, DateTimeKind.Local), 86, "Title953" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b4:19:1b:2e:8a:be", 75, "Linux", "Instance159" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "81:0f:9d:6e:dc:ac", 72, "Windows", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:b5:e2:dd:06:44", 73, "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "92:bb:36:33:cf:da", 72, "Windows", "Instance441" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "83:4f:14:bc:d7:58", 71, "Instance820" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2b:c0:da:2b:c7:ff", 73, "Linux", "Instance617" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "89:5b:c4:b0:49:c5", 79, "Windows", "Instance153" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "89:cc:7b:80:7a:10", "Windows", "Instance619" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "34:92:85:5c:37:d1", 79, "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a3:e5:3a:8c:fb:27", 76, "Windows", "Instance418" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme563" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme236");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme795" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Theme315");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme390" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme511" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme406" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme389" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme938");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme741" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", null, new DateTime(2018, 9, 1, 0, 28, 48, 302, DateTimeKind.Local), "Laney", "Destany.Walker@yahoo.com", null, "Kareem", true, false, "Predovic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BrianPurkiss/128.jpg", 1 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", null, new DateTime(2018, 9, 1, 12, 8, 4, 251, DateTimeKind.Local), "Deshaun", "Kiera_Gusikowski@hotmail.com", null, "Dangelo", true, false, "Upton", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidsasda/128.jpg", 2 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", null, new DateTime(2018, 9, 1, 10, 27, 25, 47, DateTimeKind.Local), "Shayna", "Hayden.Buckridge62@yahoo.com", null, "Vernice", true, false, "Hettinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Talbi_ConSept/128.jpg", 1 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", null, new DateTime(2018, 9, 1, 22, 15, 38, 588, DateTimeKind.Local), "Madelynn", "Bailee.Hudson47@hotmail.com", null, "Gabrielle", true, false, "Romaguera", null, "https://s3.amazonaws.com/uifaces/faces/twitter/drewbyreese/128.jpg", 2 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", null, new DateTime(2018, 9, 1, 6, 8, 46, 241, DateTimeKind.Local), "Ettie", "Ora_Ferry42@yahoo.com", null, "Jewel", true, false, "Heathcote", null, "https://s3.amazonaws.com/uifaces/faces/twitter/geobikas/128.jpg", 1 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", null, new DateTime(2018, 9, 1, 10, 42, 5, 898, DateTimeKind.Local), "Jodie", "Helene_Pfannerstill@yahoo.com", null, "Lemuel", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/al_li/128.jpg", 2 },
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", null, new DateTime(2018, 9, 1, 16, 45, 38, 815, DateTimeKind.Local), "Eudora", "Lavinia32@yahoo.com", null, "Tessie", true, false, "VonRueden", null, "https://s3.amazonaws.com/uifaces/faces/twitter/psdesignuk/128.jpg", 1 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", null, new DateTime(2018, 9, 1, 23, 31, 24, 903, DateTimeKind.Local), "Orion", "Leatha.Hoeger92@yahoo.com", null, "Austin", true, false, "Bernier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/r_garcia/128.jpg", 1 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", null, new DateTime(2018, 9, 1, 1, 1, 26, 128, DateTimeKind.Local), "Shawna", "Sophia.Schiller@gmail.com", null, "Flo", true, false, "Kertzmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kohette/128.jpg", 1 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", null, new DateTime(2018, 9, 1, 1, 31, 45, 433, DateTimeKind.Local), "Hyman", "Bernard40@hotmail.com", null, "Haylie", true, false, "Kulas", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kostaspt/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", "cum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "perferendis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", "asperiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "odit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 53, 14, 78, DateTimeKind.Local), "Numquam eveniet quo sed.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 49, 17, 251, DateTimeKind.Local), "Consequatur libero et ut facere ullam quibusdam natus id sunt.", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 14, 56, 746, DateTimeKind.Local), "Mollitia recusandae ut ab facere earum sed dolores.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 27, 52, 8, DateTimeKind.Local), "Officia cum consequuntur similique dolorem eos et eaque maiores eos.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 28, 21, 616, DateTimeKind.Local), "Rem voluptate minus libero.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 46, 42, 91, DateTimeKind.Local), "Laboriosam ea velit error veniam.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 5, 24, 16, 360, DateTimeKind.Local), "Sit quibusdam quos vel corrupti.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 31, 32, 496, DateTimeKind.Local), "Ipsum tempora id.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 23, 36, 19, 108, DateTimeKind.Local), "Magnam officiis blanditiis voluptatem odit in ut non accusamus at.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 19, 30, 190, DateTimeKind.Local), "Amet voluptatem error quis adipisci voluptatum ut.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 1, 6, 41, 58, 762, DateTimeKind.Local), "Qui eum laudantium ratione suscipit consequatur qui nulla voluptates.", "f7a272fa-80ff-48b3-a78a-a800be071761", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 0, 19, 48, 931, DateTimeKind.Local), "Consequatur et minus quia qui fuga quia omnis.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 9, 43, 41, 791, DateTimeKind.Local), "Sed sed consequatur ad id magni.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 1, 5, 14, 7, 727, DateTimeKind.Local), "Nisi laborum molestiae unde consectetur non cumque.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 1, 11, 44, 0, 426, DateTimeKind.Local), "Voluptatem inventore et rerum minus et eaque.", "2984b34d-5667-4986-8eef-ec4e17658c33", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 23, 9, 29, 927, DateTimeKind.Local), "Qui et et reiciendis.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 16, 15, 49, 192, DateTimeKind.Local), "Fugit omnis voluptas velit sunt qui in veniam.", "2133e14e-a893-4630-9c75-b8f41dce4c1c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 21, 12, 29, 577, DateTimeKind.Local), "Maxime numquam vitae corrupti repudiandae aut repellat.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 5, 57, 18, 812, DateTimeKind.Local), "Qui quis dolor quisquam.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 16, 37, 59, 517, DateTimeKind.Local), "Ratione veniam vel odio nesciunt doloremque laudantium sed sint.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 0, "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 6, 57, 34, 661, DateTimeKind.Local), 16, "Omnis corrupti ut aliquid tempore sint ab non.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 21, 20, 774, DateTimeKind.Local), 14, "Consectetur velit laudantium delectus et.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 24, 55, 38, DateTimeKind.Local), "Illum labore ex.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 55, 23, 113, DateTimeKind.Local), 16, "Aut voluptas consequatur qui dolorem expedita corrupti et laborum illo.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 2, 41, 46, 334, DateTimeKind.Local), 19, "Et rem quibusdam quae laborum iste ex corrupti.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 45, 16, 740, DateTimeKind.Local), 13, "Expedita sapiente dolore.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 20, 26, 742, DateTimeKind.Local), 19, "Architecto voluptas autem laborum soluta corrupti sed et distinctio aliquid.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 27, 21, 972, DateTimeKind.Local), 18, "Aliquid neque voluptas natus aut qui vel fuga.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 13, 10, 179, DateTimeKind.Local), 12, "Vel repellat non omnis et iste consequatur nobis dolores vel.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 7, 26, 469, DateTimeKind.Local), 18, "Beatae harum eligendi eos voluptatem blanditiis itaque.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(577) 691-9767", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Aut consequatur quos. Eos omnis labore sint tenetur sunt voluptas dolorem blanditiis.", "Amina36@hotmail.com", "Company845", 66, "https://malcolm.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(867) 873-0725 x4204", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "Molestiae nulla est. Modi cum eveniet culpa dolores. Voluptatibus explicabo et ut aspernatur harum cumque debitis iure optio. Est consequatur at ducimus et.", "Mozelle_Lockman57@gmail.com", "Company24", 65, "http://caroline.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(313) 973-9204 x851", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "", "Brad_Bashirian@hotmail.com", "Company728", "https://katlynn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(255) 205-4271 x42556", "b2afb5d0-3114-42ab-806c-1f127173d81f", "Sint iusto occaecati dicta illum harum dolores impedit autem voluptas.", "Riley.Gutkowski@hotmail.com", "Company153", "https://justus.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-866-552-3615 x9077", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Dicta voluptas veniam non enim dignissimos.", "Jaclyn.Krajcik42@hotmail.com", "Company450", 70, "https://moshe.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "915.804.6936", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Dolorum saepe laboriosam aut ducimus omnis rem vel. Assumenda asperiores illum. Et voluptas ipsam unde.", "Margarete_Hegmann18@gmail.com", "Company691", 67, "http://omer.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "230.244.8763 x821", "2133e14e-a893-4630-9c75-b8f41dce4c1c", "Ex in ratione nemo commodi. Aperiam expedita velit omnis qui veritatis quis. Deserunt cum natus cumque ipsum voluptatibus cumque eos. Officiis dolorem libero perferendis ut quo fuga.", "Ignacio_Gorczany18@hotmail.com", "Company14", 63, "https://reid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-445-200-6350", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "Quos qui ad atque optio iste veritatis. In neque amet animi recusandae nisi aut accusantium ipsa est. Consequatur et est quis. Qui nesciunt asperiores necessitatibus sunt exercitationem aperiam voluptatem harum.", "Ozella.OConner@yahoo.com", "Company464", 69, "http://wilford.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "752.498.8375 x405", "b2afb5d0-3114-42ab-806c-1f127173d81f", "At minima magni et. Sunt laudantium voluptas est aut exercitationem nam sunt quisquam neque.", "Fidel_Krajcik56@gmail.com", "Company965", "http://rebeca.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-598-997-6208", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Numquam iusto hic enim dolorum adipisci. Et est quis ex sint tenetur et natus. Voluptatem aut occaecati sequi animi. Voluptate soluta veritatis deleniti facere.", "Lesly11@gmail.com", "Company568", 61, "http://raina.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 26, 11, 135, DateTimeKind.Local), 50, "Sit consequuntur reprehenderit explicabo sit.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 21, 50, 23, 857, DateTimeKind.Local), 50, "Velit quam voluptatem sed aut sapiente cupiditate.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 7, 43, 44, 409, DateTimeKind.Local), 41, "Rerum et expedita tempora adipisci consequatur est earum ut quia.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 9, 30, 814, DateTimeKind.Local), 45, "Quia consectetur porro atque perferendis est molestiae.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 16, 8, 33, 965, DateTimeKind.Local), 44, "Aperiam qui blanditiis.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 56, 4, 316, DateTimeKind.Local), 46, "Rerum quaerat qui provident rem.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 28, 59, 3, DateTimeKind.Local), 44, "Dolores commodi praesentium id aliquid dicta aperiam maiores est aut.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 8, 35, 688, DateTimeKind.Local), 49, "Eligendi quis ut aut nesciunt vitae.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 3, 22, 131, DateTimeKind.Local), 50, "Nihil sit aut omnis deserunt quisquam omnis qui.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 6, 3, 911, DateTimeKind.Local), 43, "Delectus soluta assumenda rerum eligendi totam unde.", "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 },
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 }
                });
        }
    }
}
