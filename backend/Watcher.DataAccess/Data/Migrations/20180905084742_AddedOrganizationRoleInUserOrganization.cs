using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedOrganizationRoleInUserOrganization : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "OrganizationRoleId",
                table: "UserOrganizations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrganizationRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationRole", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", 49, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Type" },
                values: new object[] { 96, "MostLoaded1", 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", 96, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 99, "MostLoaded1", 35 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 97, 67 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 98, "MostLoaded1", 5 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 95, "MostLoaded3", 15 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded1", 47, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 19, 3, 304, DateTimeKind.Local), 86, "Title810" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 25, 33, 845, DateTimeKind.Local), 81, "Title881" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 5, 53, 31, 175, DateTimeKind.Local), 86, "Title928" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 44, 14, 501, DateTimeKind.Local), 89, "Title985" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 5, 19, 18, 597, DateTimeKind.Local), 82, "Title372" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 26, 36, 802, DateTimeKind.Local), 83, "Title387" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 1, 8, 647, DateTimeKind.Local), 86, "Title412" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 14, 8, 646, DateTimeKind.Local), 89, "Title138" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 14, 43, 530, DateTimeKind.Local), 81, "Title404" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 32, 30, 459, DateTimeKind.Local), 89, "Title184" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a6:f0:2b:f9:6b:6b", 71, "Windows", "Instance295" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "c0:35:d3:c1:8b:a5", "Instance437" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "bd:d8:90:a8:cb:33", 76, "Linux", "Instance395" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c7:3b:ba:3b:68:ad", 76, "Instance579" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8a:b5:a3:5b:ff:fc", 75, "Instance762" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c4:b7:fa:a9:04:cd", 74, "Windows", "Instance426" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d3:da:c6:d3:3e:84", 75, "Linux", "Instance181" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "23:d7:10:bb:17:08", 73, "Linux", "Instance346" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b9:8e:bd:62:d7:10", 73, "Instance662" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4d:ff:22:8b:d6:b0", 80, "Instance212" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme39" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme217" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme576" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme669" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme728" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme582" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme844" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme951" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme726");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme685" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "263d5e43-099d-4ffb-8607-c0c0da3bdd79", null, new DateTime(2018, 9, 4, 11, 58, 1, 571, DateTimeKind.Local), "Gavin", "Tracey75@yahoo.com", null, "Wilford", true, false, "Jakubowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Chakintosh/128.jpg", 1 },
                    { "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", null, new DateTime(2018, 9, 5, 4, 13, 3, 746, DateTimeKind.Local), "Omer", "Brenda.Walsh96@yahoo.com", null, "Hipolito", true, false, "Corwin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/fronx/128.jpg", 1 },
                    { "96521809-d979-4383-80b5-e67d2a48e739", null, new DateTime(2018, 9, 4, 16, 32, 10, 479, DateTimeKind.Local), "Mckayla", "Francisco67@yahoo.com", null, "Jay", true, false, "Mraz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/zauerkraut/128.jpg", 1 },
                    { "7e805303-0570-4faa-b84a-6f5ad7e62ea8", null, new DateTime(2018, 9, 4, 20, 49, 17, 622, DateTimeKind.Local), "Gabrielle", "Cathryn_Walsh@gmail.com", null, "Cleta", true, false, "Rogahn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/terryxlife/128.jpg", 1 },
                    { "7af7bbf1-98e0-4da7-8c61-b55eab78d218", null, new DateTime(2018, 9, 5, 0, 10, 46, 890, DateTimeKind.Local), "Marlee", "Gerry63@yahoo.com", null, "Nakia", true, false, "Wunsch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jacobbennett/128.jpg", 2 },
                    { "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", null, new DateTime(2018, 9, 4, 20, 42, 27, 898, DateTimeKind.Local), "Sadye", "Norval.Torphy31@gmail.com", null, "Aubrey", true, false, "Treutel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dcalonaci/128.jpg", 2 },
                    { "9b7d527e-72be-4a9c-85a7-75fdabf51004", null, new DateTime(2018, 9, 4, 19, 11, 37, 881, DateTimeKind.Local), "Noah", "Misty_Littel@hotmail.com", null, "Kody", true, false, "Ritchie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/SULiik/128.jpg", 1 },
                    { "e269b833-9189-401b-9987-641b5208239b", null, new DateTime(2018, 9, 4, 19, 18, 20, 712, DateTimeKind.Local), "Sylvester", "Leopoldo_Blick@hotmail.com", null, "Shaniya", true, false, "Reichert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jitachi/128.jpg", 2 },
                    { "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", null, new DateTime(2018, 9, 5, 9, 6, 21, 806, DateTimeKind.Local), "Camron", "Carol.Medhurst30@hotmail.com", null, "Madisen", true, false, "Kozey", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jonkspr/128.jpg", 1 },
                    { "3f18d951-ca0e-43d1-af57-8c1f183d2185", null, new DateTime(2018, 9, 5, 2, 12, 36, 41, DateTimeKind.Local), "Litzy", "Jed92@gmail.com", null, "Bennett", true, false, "Reilly", null, "https://s3.amazonaws.com/uifaces/faces/twitter/macxim/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7e805303-0570-4faa-b84a-6f5ad7e62ea8", "aliquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "263d5e43-099d-4ffb-8607-c0c0da3bdd79", "corporis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96521809-d979-4383-80b5-e67d2a48e739", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "263d5e43-099d-4ffb-8607-c0c0da3bdd79", "temporibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", "repudiandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7af7bbf1-98e0-4da7-8c61-b55eab78d218", "perferendis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3f18d951-ca0e-43d1-af57-8c1f183d2185", "provident" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9b7d527e-72be-4a9c-85a7-75fdabf51004", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7e805303-0570-4faa-b84a-6f5ad7e62ea8", "officia" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 1, 6, 21, 277, DateTimeKind.Local), "Atque assumenda hic ullam mollitia voluptatem rem hic.", "7e805303-0570-4faa-b84a-6f5ad7e62ea8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 19, 15, 718, DateTimeKind.Local), "Molestiae enim delectus ut necessitatibus corporis corrupti.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 13, 55, 7, 382, DateTimeKind.Local), "Illum quis ullam dolor.", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 3, 31, 336, DateTimeKind.Local), "Aut suscipit corporis aperiam dolorem delectus.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 9, 25, 104, DateTimeKind.Local), "Quis asperiores dolores placeat.", "3f18d951-ca0e-43d1-af57-8c1f183d2185" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 13, 40, 939, DateTimeKind.Local), "Dolor et et alias totam quo vitae.", "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 31, 3, 913, DateTimeKind.Local), "Blanditiis nam deleniti et occaecati nobis quibusdam architecto ratione aut.", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 26, 39, 362, DateTimeKind.Local), "Corporis saepe porro soluta non quos ipsam explicabo excepturi.", "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 13, 25, 42, 782, DateTimeKind.Local), "Vero exercitationem cupiditate.", "3f18d951-ca0e-43d1-af57-8c1f183d2185" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 36, 0, 98, DateTimeKind.Local), "Dolor dolorum et molestias voluptate.", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 7, 52, 5, 614, DateTimeKind.Local), "Minima repellendus repellat.", "263d5e43-099d-4ffb-8607-c0c0da3bdd79" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 5, 9, 49, 59, 792, DateTimeKind.Local), "Sed facilis minus ad accusantium repellendus molestiae repellendus.", "9b7d527e-72be-4a9c-85a7-75fdabf51004", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 7, 36, 45, 706, DateTimeKind.Local), "Quibusdam est tempora in quasi.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 4, 17, 10, 3, 14, DateTimeKind.Local), "Nihil ut et aut perspiciatis corporis beatae voluptate.", "96521809-d979-4383-80b5-e67d2a48e739" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 4, 20, 41, 13, 965, DateTimeKind.Local), "Sit animi doloribus fuga odit ipsum culpa.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 4, 18, 32, 18, 105, DateTimeKind.Local), "Eos est ea explicabo pariatur quo.", "263d5e43-099d-4ffb-8607-c0c0da3bdd79", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 5, 10, 43, 4, 334, DateTimeKind.Local), "Qui consequatur aut atque dolorem tempore at et earum occaecati.", "263d5e43-099d-4ffb-8607-c0c0da3bdd79", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 4, 23, 2, 18, 10, DateTimeKind.Local), "Quasi recusandae ut neque architecto harum et corrupti.", "7e805303-0570-4faa-b84a-6f5ad7e62ea8", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 4, 21, 34, 12, 708, DateTimeKind.Local), "Itaque tempore iste officia nesciunt.", "96521809-d979-4383-80b5-e67d2a48e739" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 5, 11, 30, 7, 696, DateTimeKind.Local), "Esse debitis omnis pariatur necessitatibus delectus aut qui.", "e269b833-9189-401b-9987-641b5208239b", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "3f18d951-ca0e-43d1-af57-8c1f183d2185" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "9b7d527e-72be-4a9c-85a7-75fdabf51004" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 3, "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 7, 40, 823, DateTimeKind.Local), 17, "Aut quia nisi voluptates.", "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 8, 53, 397, DateTimeKind.Local), "Expedita voluptas laboriosam vel inventore.", "9b7d527e-72be-4a9c-85a7-75fdabf51004" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 12, 58, 12, 872, DateTimeKind.Local), 14, "Facilis corrupti possimus neque.", "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 19, 28, 414, DateTimeKind.Local), 14, "Omnis non ad et.", "7e805303-0570-4faa-b84a-6f5ad7e62ea8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 21, 13, 571, DateTimeKind.Local), 16, "Voluptates eligendi et nemo et id est vel.", "9b7d527e-72be-4a9c-85a7-75fdabf51004" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 11, 48, 34, 973, DateTimeKind.Local), 11, "Sint vel quas aliquam architecto ipsum sit veritatis illum.", "263d5e43-099d-4ffb-8607-c0c0da3bdd79" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 44, 59, 452, DateTimeKind.Local), 11, "Nobis rerum atque esse quidem quidem doloribus alias amet ratione.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 7, 37, 43, 627, DateTimeKind.Local), 11, "Voluptates voluptas vel est ut qui provident nemo.", "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 24, 58, 32, DateTimeKind.Local), 11, "Pariatur sequi ad consequatur voluptates libero fugiat.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 20, 27, 399, DateTimeKind.Local), 13, "Sapiente quo delectus id.", "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "837.840.9972", "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", "Quam et occaecati quae accusamus qui id. Aspernatur qui sint qui eligendi tempora aut.", "Elliot.Kuhlman58@yahoo.com", "Company667", 69, "http://celestine.com", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite", "isActive" },
                values: new object[] { "632-408-0237", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", "", "Zion_Wuckert30@hotmail.com", "Company616", "https://lonie.name", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "846-667-2893 x45166", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", "Necessitatibus rem et in non non ut qui iste aut.", "Jerrold3@gmail.com", "Company77", 64, "https://amaya.biz", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "560-355-1848 x0952", "263d5e43-099d-4ffb-8607-c0c0da3bdd79", "Doloribus sed hic vitae earum harum molestiae. Sapiente sint eum est amet.", "Branson_Lehner@yahoo.com", "Company604", 70, "http://gayle.name", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite", "isActive" },
                values: new object[] { "1-354-598-0859 x44787", "7af7bbf1-98e0-4da7-8c61-b55eab78d218", "Cum consequuntur culpa eligendi.", "Herminia.Davis@hotmail.com", "Company574", "http://cyril.info", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "(949) 855-3491 x815", "e269b833-9189-401b-9987-641b5208239b", "Exercitationem harum sunt repellendus incidunt.", "Roslyn_Gislason22@hotmail.com", "Company507", 66, "https://mikayla.com", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "867.550.3993", "3f18d951-ca0e-43d1-af57-8c1f183d2185", "Enim debitis officia ut mollitia rerum recusandae. Minus molestiae dolorem in nobis non nihil in nihil. Qui ipsa dignissimos sed non.", "Abe.Schuppe68@gmail.com", 67, "https://orie.net", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite", "isActive" },
                values: new object[] { "1-400-888-6450 x00395", "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", "Maxime quia et aliquid et rerum quo ratione quia non. Et ipsum voluptatum veritatis quibusdam omnis quasi libero tempora qui. Perspiciatis error sunt autem.", "Russel_Rutherford@hotmail.com", "Company882", "http://lindsay.net", true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "1-469-965-4602", "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", "Debitis praesentium excepturi unde harum quas quaerat aliquam aut saepe. Quo ab minus odit nihil fugit laborum dolores.", "Dannie.Schumm44@hotmail.com", "Company428", 64, "https://lambert.net",true });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite", "isActive" },
                values: new object[] { "932.488.1340 x4189", "3f18d951-ca0e-43d1-af57-8c1f183d2185", "Maiores et reprehenderit eos nihil sed. Est accusantium doloribus inventore et. Nostrum sit vitae natus veritatis architecto eum placeat. Ullam quibusdam ut voluptas.", "Keegan_Marquardt96@yahoo.com", "Company554", 66, "https://ransom.com", true });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 11, 42, 432, DateTimeKind.Local), 42, "Enim cumque cum officia eos totam et dolorem ipsam.", "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 10, 44, 408, DateTimeKind.Local), 46, "Doloremque aspernatur eum rerum.", "e269b833-9189-401b-9987-641b5208239b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 43, 15, 849, DateTimeKind.Local), 44, "Reprehenderit enim qui sit vero ad rerum sint.", "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 13, 35, 17, 125, DateTimeKind.Local), 44, "Beatae sit laborum esse.", "3f18d951-ca0e-43d1-af57-8c1f183d2185" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 13, 32, 555, DateTimeKind.Local), 46, "Eligendi reiciendis esse dolor consequatur aut placeat.", "7af7bbf1-98e0-4da7-8c61-b55eab78d218" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 43, 43, 211, DateTimeKind.Local), 47, "Et voluptatem consectetur sint et sed ea.", "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 19, 40, 571, DateTimeKind.Local), 45, "Occaecati fuga autem doloremque architecto nulla atque velit.", "cdab02f6-9ead-41a4-b11d-de8a83a43ea0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 12, 44, 31, 379, DateTimeKind.Local), 48, "Ut velit at.", "7e805303-0570-4faa-b84a-6f5ad7e62ea8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 5, 25, 46, 887, DateTimeKind.Local), 49, "Quam aut incidunt saepe placeat aut rerum.", "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 10, 32, 51, DateTimeKind.Local), 50, "Maiores odit fugiat ipsa praesentium autem aut.", "263d5e43-099d-4ffb-8607-c0c0da3bdd79" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "96521809-d979-4383-80b5-e67d2a48e739", 79, 0 },
                    { "9b7d527e-72be-4a9c-85a7-75fdabf51004", 74, 0 },
                    { "e269b833-9189-401b-9987-641b5208239b", 73, 0 },
                    { "263d5e43-099d-4ffb-8607-c0c0da3bdd79", 77, 0 },
                    { "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", 72, 0 },
                    { "7af7bbf1-98e0-4da7-8c61-b55eab78d218", 73, 0 },
                    { "7e805303-0570-4faa-b84a-6f5ad7e62ea8", 75, 0 },
                    { "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", 74, 0 },
                    { "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", 77, 0 },
                    { "3f18d951-ca0e-43d1-af57-8c1f183d2185", 75, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_OrganizationRole_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId",
                principalTable: "OrganizationRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganizations_OrganizationRole_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DropTable(
                name: "OrganizationRole");

            migrationBuilder.DropIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "263d5e43-099d-4ffb-8607-c0c0da3bdd79", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3f18d951-ca0e-43d1-af57-8c1f183d2185", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7af7bbf1-98e0-4da7-8c61-b55eab78d218", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7e805303-0570-4faa-b84a-6f5ad7e62ea8", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "96521809-d979-4383-80b5-e67d2a48e739", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9b7d527e-72be-4a9c-85a7-75fdabf51004", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cdab02f6-9ead-41a4-b11d-de8a83a43ea0", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e269b833-9189-401b-9987-641b5208239b", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "263d5e43-099d-4ffb-8607-c0c0da3bdd79");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39724b92-8f5f-4dbe-a3b3-28d8afb62bc7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3f18d951-ca0e-43d1-af57-8c1f183d2185");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7af7bbf1-98e0-4da7-8c61-b55eab78d218");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7e805303-0570-4faa-b84a-6f5ad7e62ea8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "96521809-d979-4383-80b5-e67d2a48e739");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9b7d527e-72be-4a9c-85a7-75fdabf51004");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c0d63a4f-f64c-49fa-9b42-a4bd8a792a11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cdab02f6-9ead-41a4-b11d-de8a83a43ea0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e269b833-9189-401b-9987-641b5208239b");

            migrationBuilder.DropColumn(
                name: "OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", 92, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", 35, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Type" },
                values: new object[] { 91, "MostLoaded2", 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 93, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", 21, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 92, "MostLoaded2", 83 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 26 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 100, "MostLoaded2", 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 99, "MostLoaded2", 30 });

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
                columns: new[] { "Address", "Title" },
                values: new object[] { "81:0f:9d:6e:dc:ac", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5f:b5:e2:dd:06:44", 73, "Windows", "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "92:bb:36:33:cf:da", 72, "Instance441" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "89:cc:7b:80:7a:10", 77, "Windows", "Instance619" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a3:e5:3a:8c:fb:27", 76, "Instance418" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme563" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme795" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme390" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme406" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme741" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 1, 6, 41, 58, 762, DateTimeKind.Local), "Qui eum laudantium ratione suscipit consequatur qui nulla voluptates.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 0, 19, 48, 931, DateTimeKind.Local), "Consequatur et minus quia qui fuga quia omnis.", "538a13da-2a85-426a-80fb-3388aa78c68a", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 9, 43, 41, 791, DateTimeKind.Local), "Sed sed consequatur ad id magni.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 21, 12, 29, 577, DateTimeKind.Local), "Maxime numquam vitae corrupti repudiandae aut repellat.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 5, 57, 18, 812, DateTimeKind.Local), "Qui quis dolor quisquam.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

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
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 2, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 21, 20, 774, DateTimeKind.Local), "Consectetur velit laudantium delectus et.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 24, 55, 38, DateTimeKind.Local), 20, "Illum labore ex.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(867) 873-0725 x4204", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "Molestiae nulla est. Modi cum eveniet culpa dolores. Voluptatibus explicabo et ut aspernatur harum cumque debitis iure optio. Est consequatur at ducimus et.", "Mozelle_Lockman57@gmail.com", "Company24", "http://caroline.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(313) 973-9204 x851", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "", "Brad_Bashirian@hotmail.com", "Company728", 69, "https://katlynn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(255) 205-4271 x42556", "b2afb5d0-3114-42ab-806c-1f127173d81f", "Sint iusto occaecati dicta illum harum dolores impedit autem voluptas.", "Riley.Gutkowski@hotmail.com", "Company153", 68, "https://justus.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-866-552-3615 x9077", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Dicta voluptas veniam non enim dignissimos.", "Jaclyn.Krajcik42@hotmail.com", "Company450", "https://moshe.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "ThemeId", "WebSite" },
                values: new object[] { "230.244.8763 x821", "2133e14e-a893-4630-9c75-b8f41dce4c1c", "Ex in ratione nemo commodi. Aperiam expedita velit omnis qui veritatis quis. Deserunt cum natus cumque ipsum voluptatibus cumque eos. Officiis dolorem libero perferendis ut quo fuga.", "Ignacio_Gorczany18@hotmail.com", 63, "https://reid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-445-200-6350", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "Quos qui ad atque optio iste veritatis. In neque amet animi recusandae nisi aut accusantium ipsa est. Consequatur et est quis. Qui nesciunt asperiores necessitatibus sunt exercitationem aperiam voluptatem harum.", "Ozella.OConner@yahoo.com", "Company464", "http://wilford.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "752.498.8375 x405", "b2afb5d0-3114-42ab-806c-1f127173d81f", "At minima magni et. Sunt laudantium voluptas est aut exercitationem nam sunt quisquam neque.", "Fidel_Krajcik56@gmail.com", "Company965", 61, "http://rebeca.net" });

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
