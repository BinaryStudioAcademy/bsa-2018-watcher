using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedInstanceIdToNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "31d1aeea-fca1-4233-a640-d19ec2d5690a", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48496f80-3505-4088-bce9-721237904d3e", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "733804e3-2791-4002-81c8-c134b163717b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ec62c0a6-f281-40a1-a913-35c180dc66fd", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31d1aeea-fca1-4233-a640-d19ec2d5690a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48496f80-3505-4088-bce9-721237904d3e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "733804e3-2791-4002-81c8-c134b163717b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "79e46537-a194-4592-b5ab-04b90c068eb3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ad214b9-dbd3-4eb6-ada3-eda95c538e17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94e2a11d-e4bd-4f1e-8e18-bd302131b886");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ec62c0a6-f281-40a1-a913-35c180dc66fd");

            migrationBuilder.AddColumn<int>(
                name: "InstanceId",
                table: "Notifications",
                nullable: true);

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 66, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                column: "DashboardId",
                value: 93);

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 18, 27, 398, DateTimeKind.Local), "Title523" });

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
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "19:f6:bc:df:74:03", true, true, true, 90f, 90f, 90f, "Instance253" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "29:02:ad:fa:bd:9c", true, true, true, 90f, 90f, 75, 90f, "Instance831" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "f6:26:92:80:60:20", true, true, true, 90f, 90f, 77, 90f, "Instance126" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "e3:d8:f0:6e:3f:ae", true, true, true, 90f, 90f, 90f, "Instance799" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "97:ff:f8:0d:6f:dd", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance812" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "91:2a:dd:f8:22:f2", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance864" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "53:9b:09:e7:91:51", true, true, true, 90f, 90f, 71, 90f, "Instance493" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "d8:0a:6b:3b:b1:f6", true, true, true, 90f, 90f, "Windows", 90f, "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "cb:55:1d:67:5c:b9", true, true, true, 90f, 90f, 80, 90f, "Instance68" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "4b:88:ee:7c:91:fb", true, true, true, 90f, 90f, 80, 90f, "Instance295" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme65" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme821" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme821" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme263" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme635" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Theme34");

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 18, 16, 90, DateTimeKind.Local), "Est est libero aut veniam et consequatur quia.", "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 7, 49, 40, 478, DateTimeKind.Local), "Qui nihil quae sit iste asperiores fugit quis.", "6d11d143-9820-43e6-b3cc-745bfdd18061", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 6, 0, 35, 61, DateTimeKind.Local), "Ea accusamus voluptate nam perferendis veritatis minus enim aut aut.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 49, 1, 478, DateTimeKind.Local), "Id reiciendis nesciunt.", "6d11d143-9820-43e6-b3cc-745bfdd18061", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 3, 52, 32, 588, DateTimeKind.Local), "Pariatur ex quia mollitia fuga.", "0840ac69-7999-487c-a61c-99073e9b99e0", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "8da92424-ba3f-4126-bb43-2810fc99abef" });

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
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, true, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, false, "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "0840ac69-7999-487c-a61c-99073e9b99e0" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "523-902-1330", "8abc3436-3ce4-4d66-9985-cf207393656d", "", "Trycia_Moore86@hotmail.com", "Company175", "http://alvera.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(650) 426-9178 x078", "0840ac69-7999-487c-a61c-99073e9b99e0", "Greta.Pollich@yahoo.com", "Company859", 69, "https://tristian.info" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 25, 15, 870, DateTimeKind.Local), "Id aperiam consequuntur.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "InstanceId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 38, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 89, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 92, 18 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 24, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                column: "DashboardId",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 28, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 16, 59, 891, DateTimeKind.Local), 83, "Title722" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 15, 5, 78, DateTimeKind.Local), 82, "Title821" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 27, 12, 317, DateTimeKind.Local), "Title766" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 24, 17, 16, DateTimeKind.Local), 83, "Title922" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 38, 28, 262, DateTimeKind.Local), 87, "Title172" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 54, 3, 699, DateTimeKind.Local), 86, "Title641" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 52, 5, 534, DateTimeKind.Local), 82, "Title709" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 56, 45, 392, DateTimeKind.Local), 85, "Title159" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 41, 18, 205, DateTimeKind.Local), 86, "Title283" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 51, 20, 966, DateTimeKind.Local), 86, "Title966" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "37:22:f2:5d:8c:f8", false, false, false, 0f, 0f, 0f, "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "7a:db:32:bb:5b:c2", false, false, false, 0f, 0f, 78, 0f, "Instance369" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "a1:b5:02:9d:a2:a3", false, false, false, 0f, 0f, 75, 0f, "Instance970" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "RamMaxPercent", "Title" },
                values: new object[] { "88:08:62:98:11:a9", false, false, false, 0f, 0f, 0f, "Instance610" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "b3:16:96:4a:c8:63", false, false, false, 0f, 0f, 73, "Linux", 0f, "Instance896" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "ba:95:d0:cb:af:81", false, false, false, 0f, 0f, 72, "Linux", 0f, "Instance34" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "80:e3:45:08:d5:72", false, false, false, 0f, 0f, 75, 0f, "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "0b:22:7d:81:af:8a", false, false, false, 0f, 0f, "Linux", 0f, "Instance664" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "5e:9e:9e:7d:9b:f2", false, false, false, 0f, 0f, 73, 0f, "Instance833" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "89:61:dc:fc:f6:cf", false, false, false, 0f, 0f, 79, 0f, "Instance909" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme751" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme79" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme242" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme206" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme483" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme13" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme407" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme786" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Theme921");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", null, new DateTime(2018, 9, 9, 19, 6, 27, 318, DateTimeKind.Local), "Zelma", "Elmore.Heller29@yahoo.com", null, "Maida", true, false, "Mayert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/karolkrakowiak_/128.jpg", 1 },
                    { "48496f80-3505-4088-bce9-721237904d3e", null, new DateTime(2018, 9, 10, 4, 35, 50, 455, DateTimeKind.Local), "Mandy", "Jazmyn66@yahoo.com", null, "Margret", true, false, "Nikolaus", null, "https://s3.amazonaws.com/uifaces/faces/twitter/renbyrd/128.jpg", 1 },
                    { "79e46537-a194-4592-b5ab-04b90c068eb3", null, new DateTime(2018, 9, 10, 6, 5, 32, 507, DateTimeKind.Local), "Alycia", "Julio.Goodwin40@gmail.com", null, "Brook", true, false, "Robel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ernestsemerda/128.jpg", 2 },
                    { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", null, new DateTime(2018, 9, 9, 18, 21, 41, 839, DateTimeKind.Local), "Emery", "Wilhelmine_Hane@hotmail.com", null, "Germaine", true, false, "Grimes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oaktreemedia/128.jpg", 1 },
                    { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", null, new DateTime(2018, 9, 10, 0, 45, 46, 297, DateTimeKind.Local), "Agustina", "Odessa.Leannon@yahoo.com", null, "Axel", true, false, "Fay", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nckjrvs/128.jpg", 1 },
                    { "31d1aeea-fca1-4233-a640-d19ec2d5690a", null, new DateTime(2018, 9, 9, 23, 14, 45, 22, DateTimeKind.Local), "Destini", "Enos.Schinner@yahoo.com", null, "Russell", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samgrover/128.jpg", 1 },
                    { "ec62c0a6-f281-40a1-a913-35c180dc66fd", null, new DateTime(2018, 9, 10, 8, 54, 43, 614, DateTimeKind.Local), "Bridgette", "Micheal_Dicki@gmail.com", null, "Simeon", true, false, "Gottlieb", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bagawarman/128.jpg", 1 },
                    { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", null, new DateTime(2018, 9, 9, 19, 33, 28, 461, DateTimeKind.Local), "Pansy", "Savanah.Blick@yahoo.com", null, "Melisa", true, false, "White", null, "https://s3.amazonaws.com/uifaces/faces/twitter/madewulf/128.jpg", 1 },
                    { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", null, new DateTime(2018, 9, 9, 21, 12, 13, 440, DateTimeKind.Local), "Madalyn", "Lura.Abbott98@yahoo.com", null, "Blanche", true, false, "Kessler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bereto/128.jpg", 2 },
                    { "733804e3-2791-4002-81c8-c134b163717b", null, new DateTime(2018, 9, 10, 1, 9, 38, 564, DateTimeKind.Local), "Domenic", "Quincy_Cummerata84@yahoo.com", null, "Eula", true, false, "Rippin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/arindam_/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "31d1aeea-fca1-4233-a640-d19ec2d5690a", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "733804e3-2791-4002-81c8-c134b163717b", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", "rerum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48496f80-3505-4088-bce9-721237904d3e", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "79e46537-a194-4592-b5ab-04b90c068eb3", "veritatis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", "quasi" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 54, 54, 778, DateTimeKind.Local), "Nemo molestiae ipsum.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 2, 23, 793, DateTimeKind.Local), "Et est aliquid provident ut.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 6, 1, 775, DateTimeKind.Local), "Voluptas beatae aut.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 9, 48, 5, 352, DateTimeKind.Local), "Possimus laudantium perferendis.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 36, 38, 179, DateTimeKind.Local), "Eos dolorum unde omnis commodi recusandae soluta.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 37, 6, 418, DateTimeKind.Local), "Consequatur deserunt fugiat.", "31d1aeea-fca1-4233-a640-d19ec2d5690a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 19, 42, 479, DateTimeKind.Local), "Qui vel rerum nihil est quibusdam ea.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 24, 38, 234, DateTimeKind.Local), "Accusamus neque quis nulla voluptates dolores tempore error corrupti.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 37, 26, 100, DateTimeKind.Local), "Ipsum suscipit dolores sunt saepe enim architecto molestias reiciendis.", "31d1aeea-fca1-4233-a640-d19ec2d5690a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 8, 51, 208, DateTimeKind.Local), "Rerum harum reprehenderit soluta.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 20, 36, 21, 994, DateTimeKind.Local), "Ut praesentium dolor voluptas.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 6, 38, 692, DateTimeKind.Local), "Qui eius ut.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 20, 48, 3, 467, DateTimeKind.Local), "Saepe adipisci alias voluptatem ut aut nihil sapiente.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 9, 14, 27, 17, 993, DateTimeKind.Local), "Ut dolores dolor corporis voluptatem illo quia id numquam iure.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 10, 42, 18, 245, DateTimeKind.Local), "Accusantium beatae et sunt velit reiciendis et debitis.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 7, 35, 39, 765, DateTimeKind.Local), "Aut ut aut earum vero.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 9, 12, 9, 11, 787, DateTimeKind.Local), "Velit sint et quasi soluta aut similique enim aliquam voluptatum.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 15, 23, 15, 962, DateTimeKind.Local), "Non earum ut et id nemo quisquam similique.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 31, 5, 489, DateTimeKind.Local), "Maiores quia quis earum itaque qui.", "733804e3-2791-4002-81c8-c134b163717b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 20, 10, 30, 838, DateTimeKind.Local), "Architecto officiis nobis quia.", "48496f80-3505-4088-bce9-721237904d3e", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, false, "79e46537-a194-4592-b5ab-04b90c068eb3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, true, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 0, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 3, 50, 887, DateTimeKind.Local), 15, "Laborum tempora enim consequatur voluptas et odit at corporis modi.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 35, 42, 256, DateTimeKind.Local), 11, "Ratione neque eum animi omnis.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 44, 47, 498, DateTimeKind.Local), 14, "Cupiditate unde voluptatibus eos tenetur.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 26, 33, 203, DateTimeKind.Local), 13, "Culpa in et aut.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 9, 51, 365, DateTimeKind.Local), 11, "Et pariatur ea commodi rerum earum.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 4, 59, 198, DateTimeKind.Local), 18, "Qui ducimus voluptas adipisci consequuntur.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 7, 59, 242, DateTimeKind.Local), 11, "Vero aut sequi accusantium qui ut.", "79e46537-a194-4592-b5ab-04b90c068eb3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 5, 51, 545, DateTimeKind.Local), 17, "Dolores provident quam ex sunt nulla ut id.", "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 3, 29, 820, DateTimeKind.Local), 19, "Molestiae debitis blanditiis blanditiis debitis ducimus eum ad.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 3, 23, 887, DateTimeKind.Local), 11, "Iure ex facere qui consequatur laudantium expedita nam minima consequatur.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "711.651.8263", "48496f80-3505-4088-bce9-721237904d3e", "Inventore omnis consequatur sit. Autem ut saepe dolores debitis quaerat distinctio consequatur. Debitis quo delectus vero dignissimos possimus a illum dolor. Et non vel ad ipsa totam.", "Vincenzo61@yahoo.com", "Company998", 69, "https://jolie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(851) 373-1278 x02293", "31d1aeea-fca1-4233-a640-d19ec2d5690a", "Velit architecto pariatur accusantium facere molestiae. Omnis dignissimos eligendi est recusandae voluptates aliquid.", "Cicero94@yahoo.com", "Company162", 65, "http://casey.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-211-966-4607 x80803", "48496f80-3505-4088-bce9-721237904d3e", "Voluptatum laboriosam nulla sed corrupti aut exercitationem voluptatibus.", "Bernita_Bayer@gmail.com", "Company944", 63, "https://clemens.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-246-456-0031 x633", "733804e3-2791-4002-81c8-c134b163717b", "Cupiditate voluptate deserunt veritatis illum quia praesentium suscipit vitae.", "Whitney.Sipes@gmail.com", "Company409", "http://river.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "811-998-1747 x598", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", "", "Estel_McGlynn@yahoo.com", "Company727", 68, "http://howell.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-219-481-5686 x261", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Quia ratione aperiam assumenda magnam omnis.", "Ward_Hauck97@yahoo.com", "Company515", 65, "http://garrett.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(756) 217-5288 x0980", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", "Dolorem ab id dolor facere.", "Arvel.Boyer@gmail.com", "Company835", 70, "http://leila.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(755) 580-7585 x792", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Afton66@hotmail.com", "Company360", 62, "http://lindsey.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-223-240-3397 x2150", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", "Aliquid officia adipisci occaecati earum distinctio.", "Ada16@hotmail.com", "Company387", 63, "http://johnnie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "513-788-7830 x8497", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Est ipsam aut et iusto sit rerum delectus vel. Repellendus sapiente nihil dignissimos. Impedit quia qui minus assumenda. Quaerat autem et consectetur.", "Keely33@hotmail.com", "Company433", 68, "http://janice.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 9, 32, 3, 297, DateTimeKind.Local), 42, "Qui rerum in et occaecati.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 12, 2, 129, DateTimeKind.Local), 41, "Et enim explicabo quas consequatur voluptatem non nemo nostrum.", "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 53, 18, 245, DateTimeKind.Local), 43, "Ea consequatur qui.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 4, 37, 882, DateTimeKind.Local), 46, "Maxime doloribus libero nihil maxime.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 31, 13, 895, DateTimeKind.Local), 44, "Et quae iste quia quia.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 34, 13, 587, DateTimeKind.Local), 44, "Debitis dolorum nihil.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 54, 15, 772, DateTimeKind.Local), 41, "Ipsum et ut voluptas.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 32, 36, 556, DateTimeKind.Local), "Accusamus consequuntur non animi.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 31, 9, 531, DateTimeKind.Local), 42, "Et eaque cum sint ut delectus illum illum aut.", "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 27, 49, 198, DateTimeKind.Local), 47, "At expedita animi suscipit voluptatem in quaerat.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", 73, 1 },
                    { "48496f80-3505-4088-bce9-721237904d3e", 77, 1 },
                    { "ec62c0a6-f281-40a1-a913-35c180dc66fd", 72, 1 },
                    { "31d1aeea-fca1-4233-a640-d19ec2d5690a", 79, 1 },
                    { "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", 71, 1 },
                    { "94e2a11d-e4bd-4f1e-8e18-bd302131b886", 71, 1 },
                    { "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6", 72, 1 },
                    { "79e46537-a194-4592-b5ab-04b90c068eb3", 74, 1 },
                    { "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", 78, 1 },
                    { "733804e3-2791-4002-81c8-c134b163717b", 77, 1 }
                });
        }
    }
}
