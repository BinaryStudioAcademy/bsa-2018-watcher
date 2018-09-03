using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedEmailToFeedback : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", 64, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Type" },
                values: new object[] { 99, "MostLoaded2", 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", 34, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", 80, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 8, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 64, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 95, "MostLoaded1", 4 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 91, "MostLoaded3", 84 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 35, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 6, 40, 22, 355, DateTimeKind.Local), 82, "Title284" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 2, 23, 2, 54, 857, DateTimeKind.Local), 88, "Title376" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 1, 55, 52, 777, DateTimeKind.Local), 85, "Title655" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 17, 12, 47, 738, DateTimeKind.Local), 82, "Title93" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 2, 23, 28, 35, 209, DateTimeKind.Local), 81, "Title894" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 9, 57, 32, 886, DateTimeKind.Local), 84, "Title355" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 2, 39, 59, 41, DateTimeKind.Local), 83, "Title787" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 12, 28, 11, 819, DateTimeKind.Local), "Title635" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 13, 12, 14, 827, DateTimeKind.Local), 83, "Title846" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 3, 6, 49, 10, 759, DateTimeKind.Local), 83, "Title511" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4e:4d:ad:70:30:1a", 72, "Windows", "Instance760" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d9:77:dc:14:e8:8e", 75, "Linux", "Instance808" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f7:bc:16:8e:a8:54", 77, "Linux", "Instance512" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8f:b8:da:bc:83:6d", 71, "Linux", "Instance246" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "30:03:43:e5:96:c6", 76, "Instance757" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "1b:ea:fb:06:0b:92", "Instance255" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6f:7d:5d:fa:f7:20", 77, "Instance779" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:73:1d:53:8b:f4", 75, "Instance566" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d4:ad:6a:02:b9:a4", 78, "Instance970" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "37:e6:3d:e6:c0:b3", 77, "Linux", "Instance688" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme929" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme905" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme981" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Theme213");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme1" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme203" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme368" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Theme166");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme301" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme400" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "03cdfd90-7099-41ff-ae4a-666cb98d80f4", null, new DateTime(2018, 9, 3, 0, 30, 32, 235, DateTimeKind.Local), "Ashlee", "Judge.Lind@gmail.com", null, "Edd", true, false, "Hamill", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nicoleglynn/128.jpg", 1 },
                    { "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f", null, new DateTime(2018, 9, 3, 10, 23, 57, 415, DateTimeKind.Local), "Benton", "Caleb.Williamson@gmail.com", null, "Edward", true, false, "Wiza", null, "https://s3.amazonaws.com/uifaces/faces/twitter/abelcabans/128.jpg", 1 },
                    { "436a886f-d941-4eda-ae4b-0166d8d84611", null, new DateTime(2018, 9, 3, 3, 34, 44, 522, DateTimeKind.Local), "Kay", "Raleigh.Hammes@hotmail.com", null, "Gilbert", true, false, "Anderson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/enjoythetau/128.jpg", 1 },
                    { "2e8efde3-b23e-409d-a296-6b9592a7020f", null, new DateTime(2018, 9, 3, 14, 13, 1, 89, DateTimeKind.Local), "Renee", "Allie_Stiedemann@yahoo.com", null, "Lionel", true, false, "Lesch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/craighenneberry/128.jpg", 1 },
                    { "556655b2-1ce3-49db-aa85-e29bb1ceac3a", null, new DateTime(2018, 9, 2, 23, 45, 20, 110, DateTimeKind.Local), "Jazmyn", "Brigitte_Welch@hotmail.com", null, "Earl", true, false, "Hirthe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/xamorep/128.jpg", 1 },
                    { "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1", null, new DateTime(2018, 9, 3, 13, 7, 2, 596, DateTimeKind.Local), "Ardella", "Luis73@yahoo.com", null, "Scarlett", true, false, "Waters", null, "https://s3.amazonaws.com/uifaces/faces/twitter/beshur/128.jpg", 2 },
                    { "3e44d9ca-d67c-44d3-9660-58746a30d3ed", null, new DateTime(2018, 9, 3, 5, 43, 38, 895, DateTimeKind.Local), "Kianna", "Nelda_Von@gmail.com", null, "D'angelo", true, false, "Heidenreich", null, "https://s3.amazonaws.com/uifaces/faces/twitter/lososina/128.jpg", 1 },
                    { "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60", null, new DateTime(2018, 9, 3, 2, 56, 50, 576, DateTimeKind.Local), "Chase", "Tyrel_Denesik@yahoo.com", null, "Brannon", true, false, "Renner", null, "https://s3.amazonaws.com/uifaces/faces/twitter/imsoper/128.jpg", 1 },
                    { "2e3cb29a-adcd-400a-8f21-1790baa33375", null, new DateTime(2018, 9, 3, 16, 0, 51, 468, DateTimeKind.Local), "Sim", "Larry_Eichmann6@gmail.com", null, "Craig", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BenouarradeM/128.jpg", 2 },
                    { "ab6e60c6-9396-4a82-b6c2-a5eda5913563", null, new DateTime(2018, 9, 2, 19, 44, 13, 949, DateTimeKind.Local), "Elda", "Cleveland12@hotmail.com", null, "Camilla", true, false, "Collins", null, "https://s3.amazonaws.com/uifaces/faces/twitter/herkulano/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "03cdfd90-7099-41ff-ae4a-666cb98d80f4", "a" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "556655b2-1ce3-49db-aa85-e29bb1ceac3a", "unde" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "436a886f-d941-4eda-ae4b-0166d8d84611", "ea" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f", "doloribus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2e3cb29a-adcd-400a-8f21-1790baa33375", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f", "quis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ab6e60c6-9396-4a82-b6c2-a5eda5913563", "iusto" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2e3cb29a-adcd-400a-8f21-1790baa33375", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "556655b2-1ce3-49db-aa85-e29bb1ceac3a", "minima" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 1, 51, 16, 184, DateTimeKind.Local), "Et voluptatem maxime atque.", "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 13, 33, 54, 363, DateTimeKind.Local), "A dolorem veniam omnis deleniti expedita sit non atque.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 15, 16, 44, 69, DateTimeKind.Local), "Cum est qui.", "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 4, 5, 23, 414, DateTimeKind.Local), "Sed aut vel consequatur.", "556655b2-1ce3-49db-aa85-e29bb1ceac3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 16, 17, 8, 690, DateTimeKind.Local), "Alias doloribus doloremque.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 13, 29, 21, 183, DateTimeKind.Local), "Quis veritatis dolores cum hic.", "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 2, 4, 9, 747, DateTimeKind.Local), "Laboriosam eos reprehenderit.", "2e3cb29a-adcd-400a-8f21-1790baa33375" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 11, 35, 42, 947, DateTimeKind.Local), "Ea fuga natus est neque reiciendis quaerat quia.", "556655b2-1ce3-49db-aa85-e29bb1ceac3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 19, 2, 40, 629, DateTimeKind.Local), "Animi consequatur libero voluptatum libero sequi officiis dolorem rerum quisquam.", "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 1, 12, 28, 136, DateTimeKind.Local), "Officiis molestiae cupiditate numquam velit delectus doloribus ex qui facere.", "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 3, 13, 17, 37, 357, DateTimeKind.Local), "Iure dolor voluptate.", "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 9, 28, 33, 173, DateTimeKind.Local), "Quaerat enim et culpa perferendis iure voluptatum qui vel.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 3, 12, 10, 43, 482, DateTimeKind.Local), "Aut officia aperiam maiores laboriosam eum ad neque cupiditate tempora.", "2e3cb29a-adcd-400a-8f21-1790baa33375", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 3, 0, 8, 13, 669, DateTimeKind.Local), "Molestiae delectus eius adipisci.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 2, 19, 9, 48, 515, DateTimeKind.Local), "Ad consequatur sapiente sunt voluptatem.", "ab6e60c6-9396-4a82-b6c2-a5eda5913563", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 3, 15, 22, 30, 680, DateTimeKind.Local), "Quis qui occaecati velit consectetur omnis.", "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 3, 14, 44, 7, 749, DateTimeKind.Local), "Repellendus vel facilis magnam necessitatibus.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 3, 7, 33, 6, 128, DateTimeKind.Local), "Earum iste est quo.", "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 3, 16, 57, 44, 50, DateTimeKind.Local), "Nostrum dolores nemo nesciunt praesentium quia ea.", "ab6e60c6-9396-4a82-b6c2-a5eda5913563" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 2, 22, 6, 58, 774, DateTimeKind.Local), "Sed blanditiis consequatur corrupti asperiores voluptatem voluptatem dolores.", "2e8efde3-b23e-409d-a296-6b9592a7020f", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "2e3cb29a-adcd-400a-8f21-1790baa33375" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "ab6e60c6-9396-4a82-b6c2-a5eda5913563" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 1, "2e3cb29a-adcd-400a-8f21-1790baa33375" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 17, 41, 22, 824, DateTimeKind.Local), 19, "Odio ex excepturi qui consequuntur labore et quaerat.", "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 19, 19, 49, 542, DateTimeKind.Local), 11, "Iusto fugit quia exercitationem corrupti adipisci et voluptas magni assumenda.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 23, 30, 22, 844, DateTimeKind.Local), 12, "Sit sunt ut molestias velit est.", "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 21, 1, 29, 811, DateTimeKind.Local), 18, "Veritatis illo nemo consequatur natus eius corporis quisquam doloremque.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 7, 45, 45, 62, DateTimeKind.Local), 17, "Illo sunt accusantium est ipsam occaecati libero nihil.", "556655b2-1ce3-49db-aa85-e29bb1ceac3a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 10, 22, 28, 367, DateTimeKind.Local), 12, "Inventore accusantium quos.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 7, 17, 28, 717, DateTimeKind.Local), 20, "Repudiandae commodi incidunt et necessitatibus.", "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 13, 18, 27, 331, DateTimeKind.Local), 14, "Non et voluptatem illum velit debitis.", "556655b2-1ce3-49db-aa85-e29bb1ceac3a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 8, 20, 2, 736, DateTimeKind.Local), 17, "Dignissimos officia non.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 21, 9, 48, 192, DateTimeKind.Local), 19, "Facere quas adipisci consequatur quam repellat eligendi corporis.", "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "615-670-4823", "2e8efde3-b23e-409d-a296-6b9592a7020f", "", "Clotilde40@yahoo.com", "Company78", "http://adrain.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "991-633-3516 x4103", "ab6e60c6-9396-4a82-b6c2-a5eda5913563", "", "Lucinda_Fritsch92@yahoo.com", "Company565", 63, "https://samson.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "757.428.8557", "ab6e60c6-9396-4a82-b6c2-a5eda5913563", "Tempore aut autem. Alias et mollitia repudiandae eligendi architecto optio suscipit dolores voluptas. Odit itaque qui sint ut. Neque qui pariatur aut minus.", "Domenick_Sawayn@gmail.com", "Company649", 62, "https://nona.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "314.366.1235 x7542", "03cdfd90-7099-41ff-ae4a-666cb98d80f4", "Molestias voluptatibus cupiditate eum ut ducimus qui qui.", "Jerry.Rolfson@yahoo.com", "Company520", "http://hailee.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(394) 366-8092 x3684", "436a886f-d941-4eda-ae4b-0166d8d84611", "Excepturi id quo est molestiae officiis molestiae laborum sed. Rerum aut laboriosam et debitis maiores praesentium dolorem est ullam. Autem fugiat nulla qui repellat dolorem repudiandae consectetur praesentium iste. Vel ea at mollitia distinctio quos.", "Irwin.Tremblay36@gmail.com", "Company201", 64, "http://garnett.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(797) 698-1405", "436a886f-d941-4eda-ae4b-0166d8d84611", "Commodi tempora velit voluptatibus non minima quia delectus. Et molestias fuga odio eos aut dolor.", "Mattie_Windler84@yahoo.com", "Company793", 70, "http://hailie.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-828-463-7676", "03cdfd90-7099-41ff-ae4a-666cb98d80f4", "", "Jerome40@gmail.com", "Company499", "http://mathew.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "559-850-5567 x1277", "ab6e60c6-9396-4a82-b6c2-a5eda5913563", "Dolor sed ut consequatur. Voluptatibus aut molestiae voluptatem beatae vero molestiae vel. Nam tempora voluptatem labore minima praesentium non harum dolorem iste. Natus quidem id dolores pariatur in sed.", "Erin_Gorczany36@gmail.com", "Company487", "http://annabelle.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "760-799-5439", "2e3cb29a-adcd-400a-8f21-1790baa33375", "Autem dolorem eos ut enim. Corporis et voluptatem ut aut.", "Luz_Weimann@hotmail.com", "Company183", "http://reba.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "928-700-6962 x98805", "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1", "Asperiores eveniet eligendi quod quo eaque velit. Numquam laborum placeat qui qui. Blanditiis rerum nostrum aliquid fuga quasi nihil iusto. Commodi architecto neque autem.", "Roscoe81@gmail.com", "Company505", 68, "https://ethyl.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 0, 49, 57, 608, DateTimeKind.Local), 44, "Quam eveniet soluta voluptatem dolore consequatur.", "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 21, 51, 29, 685, DateTimeKind.Local), 41, "In provident libero voluptatibus occaecati.", "ab6e60c6-9396-4a82-b6c2-a5eda5913563" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 19, 27, 13, 930, DateTimeKind.Local), 45, "Vitae harum id labore blanditiis quae.", "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 14, 15, 8, 557, DateTimeKind.Local), "Officiis inventore voluptatibus aut labore minus reiciendis.", "2e3cb29a-adcd-400a-8f21-1790baa33375" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 18, 57, 53, 43, DateTimeKind.Local), 46, "Voluptas sed cupiditate natus.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 2, 18, 14, 45, 144, DateTimeKind.Local), "Rem non dolor placeat tempora nostrum autem nobis distinctio tempora.", "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 7, 22, 3, 522, DateTimeKind.Local), 46, "Magni voluptatum nemo deserunt et.", "436a886f-d941-4eda-ae4b-0166d8d84611" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 8, 54, 37, 401, DateTimeKind.Local), 44, "Dicta cupiditate quia et molestiae numquam cum molestias.", "2e8efde3-b23e-409d-a296-6b9592a7020f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 13, 56, 15, 837, DateTimeKind.Local), 46, "Quasi explicabo nemo possimus consequatur dignissimos quae ipsam sint rerum.", "3e44d9ca-d67c-44d3-9660-58746a30d3ed" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 3, 11, 42, 41, 36, DateTimeKind.Local), 48, "Quae magnam ex.", "03cdfd90-7099-41ff-ae4a-666cb98d80f4" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f", 72 },
                    { "3e44d9ca-d67c-44d3-9660-58746a30d3ed", 72 },
                    { "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60", 74 },
                    { "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1", 72 },
                    { "03cdfd90-7099-41ff-ae4a-666cb98d80f4", 76 },
                    { "436a886f-d941-4eda-ae4b-0166d8d84611", 74 },
                    { "556655b2-1ce3-49db-aa85-e29bb1ceac3a", 76 },
                    { "2e8efde3-b23e-409d-a296-6b9592a7020f", 71 },
                    { "2e3cb29a-adcd-400a-8f21-1790baa33375", 73 },
                    { "ab6e60c6-9396-4a82-b6c2-a5eda5913563", 78 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "03cdfd90-7099-41ff-ae4a-666cb98d80f4", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2e3cb29a-adcd-400a-8f21-1790baa33375", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2e8efde3-b23e-409d-a296-6b9592a7020f", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3e44d9ca-d67c-44d3-9660-58746a30d3ed", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "436a886f-d941-4eda-ae4b-0166d8d84611", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "556655b2-1ce3-49db-aa85-e29bb1ceac3a", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ab6e60c6-9396-4a82-b6c2-a5eda5913563", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60", 74 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "03cdfd90-7099-41ff-ae4a-666cb98d80f4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2e3cb29a-adcd-400a-8f21-1790baa33375");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2e8efde3-b23e-409d-a296-6b9592a7020f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3e44d9ca-d67c-44d3-9660-58746a30d3ed");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "436a886f-d941-4eda-ae4b-0166d8d84611");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "556655b2-1ce3-49db-aa85-e29bb1ceac3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8f0ff7d5-a4b1-440b-b9cd-c30ea4593d8f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ab6e60c6-9396-4a82-b6c2-a5eda5913563");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "af132db0-f4c3-4b96-b4a9-2749ea7fc4c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fdfd6ac9-b62b-4e4a-8d9d-08d525451e60");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Feedbacks");

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
                columns: new[] { "DashboardId", "MostLoaded", "Type" },
                values: new object[] { 95, "MostLoaded3", 2 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 26, 1 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 45, 1 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 27, 43, 183, DateTimeKind.Local), "Title641" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5f:b5:e2:dd:06:44", 73, "Windows", "Instance22" });

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
                columns: new[] { "Address", "Title" },
                values: new object[] { "2b:c0:da:2b:c7:ff", "Instance617" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:5b:c4:b0:49:c5", 79, "Instance153" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:cc:7b:80:7a:10", 77, "Instance619" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme563" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme236" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme511" });

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
                column: "Name",
                value: "Theme389");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme938" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 1, 6, 41, 58, 762, DateTimeKind.Local), "Qui eum laudantium ratione suscipit consequatur qui nulla voluptates.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 19, 48, 931, DateTimeKind.Local), "Consequatur et minus quia qui fuga quia omnis.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 16, 15, 49, 192, DateTimeKind.Local), "Fugit omnis voluptas velit sunt qui in veniam.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

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
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "f7a272fa-80ff-48b3-a78a-a800be071761" });

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
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 3, "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 2, "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(577) 691-9767", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Aut consequatur quos. Eos omnis labore sint tenetur sunt voluptas dolorem blanditiis.", "Amina36@hotmail.com", "Company845", "https://malcolm.info" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(313) 973-9204 x851", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "", "Brad_Bashirian@hotmail.com", "Company728", 69, "https://katlynn.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "230.244.8763 x821", "2133e14e-a893-4630-9c75-b8f41dce4c1c", "Ex in ratione nemo commodi. Aperiam expedita velit omnis qui veritatis quis. Deserunt cum natus cumque ipsum voluptatibus cumque eos. Officiis dolorem libero perferendis ut quo fuga.", "Ignacio_Gorczany18@hotmail.com", "Company14", "https://reid.info" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 9, 30, 814, DateTimeKind.Local), "Quia consectetur porro atque perferendis est molestiae.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 56, 4, 316, DateTimeKind.Local), "Rerum quaerat qui provident rem.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

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
