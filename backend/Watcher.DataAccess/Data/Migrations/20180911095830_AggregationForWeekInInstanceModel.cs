using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AggregationForWeekInInstanceModel : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForWeek",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 97, 50 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 63 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 10, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 92, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 35, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 85, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 3, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 59, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 39, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 15, 19, 429, DateTimeKind.Local), 82, "Title684" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 44, 20, 243, DateTimeKind.Local), 90, "Title920" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 23, 11, 466, DateTimeKind.Local), 88, "Title570" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 54, 36, 692, DateTimeKind.Local), 88, "Title221" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 0, 7, 463, DateTimeKind.Local), 81, "Title507" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 57, 42, 908, DateTimeKind.Local), 87, "Title527" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 38, 5, 834, DateTimeKind.Local), 83, "Title234" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 13, 5, 975, DateTimeKind.Local), 83, "Title424" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 26, 8, 974, DateTimeKind.Local), 83, "Title446" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 19, 59, 27, 358, DateTimeKind.Local), 83, "Title654" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "33:90:26:f1:8e:38", true, true, true, 90f, 90f, 80, "Windows", 90f, "Instance201" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "60:4b:27:ad:d2:ee", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance778" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "a9:31:38:ea:75:a2", true, true, true, 90f, 90f, 71, "Linux", 90f, "Instance432" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "5f:d6:f4:11:a6:71", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance42" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "4c:9f:dc:e2:66:7c", true, true, true, 90f, 90f, 71, "Windows", 90f, "Instance189" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "ed:41:fb:d8:42:02", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance553" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "RamMaxPercent", "Title" },
                values: new object[] { "2f:af:16:2c:d3:89", true, true, true, 90f, 90f, 74, 90f, "Instance480" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "8f:5a:56:bf:0e:09", true, true, true, 90f, 90f, 74, "Windows", 90f, "Instance29" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "a0:9a:ad:8f:ad:1e", true, true, true, 90f, 90f, 79, "Windows", 90f, "Instance517" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "1a:23:87:43:7f:9c", true, true, true, 90f, 90f, 76, "Windows", 90f, "Instance809" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme285" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme303" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme26" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme185" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme337" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme301" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme157" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme895" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme875" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme765" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", null, new DateTime(2018, 9, 10, 14, 40, 18, 378, DateTimeKind.Local), "Sim", "Elvis72@hotmail.com", null, "Shany", true, false, "Lemke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sasha_shestakov/128.jpg", 2 },
                    { "389a422b-9013-4486-b81f-7b6dcca703f1", null, new DateTime(2018, 9, 10, 23, 2, 46, 958, DateTimeKind.Local), "Zackary", "Howell.Johnston96@gmail.com", null, "Amely", true, false, "White", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ricburton/128.jpg", 1 },
                    { "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", null, new DateTime(2018, 9, 11, 7, 48, 9, 752, DateTimeKind.Local), "Veronica", "Al.Sauer35@gmail.com", null, "Justine", true, false, "Lindgren", null, "https://s3.amazonaws.com/uifaces/faces/twitter/stephcoue/128.jpg", 2 },
                    { "cda19867-84de-4479-93a6-43270bef193f", null, new DateTime(2018, 9, 11, 12, 8, 4, 120, DateTimeKind.Local), "Jalon", "Ethelyn_Lakin@gmail.com", null, "Madonna", true, false, "Collins", null, "https://s3.amazonaws.com/uifaces/faces/twitter/matthewkay_/128.jpg", 1 },
                    { "b24b21aa-3996-4d86-8f7d-e05aa486d370", null, new DateTime(2018, 9, 11, 5, 42, 50, 414, DateTimeKind.Local), "Garrett", "Trevor_Steuber@gmail.com", null, "Adelia", true, false, "Rolfson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/melvindidit/128.jpg", 1 },
                    { "e2e54396-b4f8-4a18-b086-3eb415e3c272", null, new DateTime(2018, 9, 11, 9, 39, 11, 707, DateTimeKind.Local), "Fern", "Candido67@yahoo.com", null, "Forrest", true, false, "Goldner", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Silveredge9/128.jpg", 2 },
                    { "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc", null, new DateTime(2018, 9, 11, 1, 16, 23, 993, DateTimeKind.Local), "Elijah", "Gabriella.Bailey@hotmail.com", null, "Frankie", true, false, "Moen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sachacorazzi/128.jpg", 1 },
                    { "b1758db9-1724-4e4c-a732-d7bb439a2740", null, new DateTime(2018, 9, 11, 4, 14, 20, 523, DateTimeKind.Local), "Howard", "Jakob_Strosin@yahoo.com", null, "Brooks", true, false, "White", null, "https://s3.amazonaws.com/uifaces/faces/twitter/coreyweb/128.jpg", 1 },
                    { "9ae2e670-2176-43d0-961e-09eac31bce0e", null, new DateTime(2018, 9, 11, 6, 40, 36, 866, DateTimeKind.Local), "Claude", "Nikita_Herman21@hotmail.com", null, "Jett", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/meelford/128.jpg", 1 },
                    { "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9", null, new DateTime(2018, 9, 10, 20, 54, 26, 830, DateTimeKind.Local), "Aimee", "Jazmin_Kilback@hotmail.com", null, "Gideon", true, false, "Runte", null, "https://s3.amazonaws.com/uifaces/faces/twitter/iamsteffen/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b24b21aa-3996-4d86-8f7d-e05aa486d370", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cda19867-84de-4479-93a6-43270bef193f", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", "harum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cda19867-84de-4479-93a6-43270bef193f", "suscipit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e2e54396-b4f8-4a18-b086-3eb415e3c272", "hic" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc", "ad" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9ae2e670-2176-43d0-961e-09eac31bce0e", "impedit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 23, 40, 565, DateTimeKind.Local), "Dolore eveniet impedit.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 46, 43, 101, DateTimeKind.Local), "Vel quo enim sit error quaerat nisi et nisi quae.", "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 20, 50, 846, DateTimeKind.Local), "Animi ut velit ipsa ipsa perferendis dolor voluptatibus quaerat placeat.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 32, 25, 406, DateTimeKind.Local), "Adipisci commodi aut.", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 40, 40, 825, DateTimeKind.Local), "Qui autem eveniet inventore voluptas aut.", "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 42, 42, 916, DateTimeKind.Local), "Ipsum impedit consequuntur enim est rerum et.", "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 26, 58, 700, DateTimeKind.Local), "Libero omnis vel reiciendis sed sapiente nesciunt fugiat natus.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 7, 14, 696, DateTimeKind.Local), "Et dolorem est ea officia.", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 11, 50, 440, DateTimeKind.Local), "Doloremque fugit enim nesciunt vel unde fuga quibusdam velit.", "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 59, 32, 401, DateTimeKind.Local), "Possimus dolorum omnis est aliquid qui dolor explicabo.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 14, 15, 16, 905, DateTimeKind.Local), "Aliquam dolores iusto ut nisi maxime voluptas optio.", "9ae2e670-2176-43d0-961e-09eac31bce0e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 10, 16, 44, 48, 869, DateTimeKind.Local), "Non veritatis qui odio est.", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 11, 25, 36, 107, DateTimeKind.Local), "Adipisci natus iusto similique.", "9ae2e670-2176-43d0-961e-09eac31bce0e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 13, 49, 12, 945, DateTimeKind.Local), "Enim cupiditate explicabo nisi ipsum quae quibusdam.", "b24b21aa-3996-4d86-8f7d-e05aa486d370", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 18, 32, 19, 920, DateTimeKind.Local), "Distinctio unde eligendi.", "9ae2e670-2176-43d0-961e-09eac31bce0e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 10, 21, 48, 2, 783, DateTimeKind.Local), "Ut reiciendis eos ipsa ut et repellendus et quia.", "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 3, 33, 4, 739, DateTimeKind.Local), "Omnis qui sed porro.", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 10, 22, 24, 53, 767, DateTimeKind.Local), "Fugit autem architecto provident perferendis maxime numquam enim et omnis.", "cda19867-84de-4479-93a6-43270bef193f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 4, 57, 0, 976, DateTimeKind.Local), "Autem molestiae quaerat.", "b1758db9-1724-4e4c-a732-d7bb439a2740", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 10, 16, 19, 18, 624, DateTimeKind.Local), "Doloremque quos repellat sapiente ut illo ipsum.", "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "e2e54396-b4f8-4a18-b086-3eb415e3c272" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 4, "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "b24b21aa-3996-4d86-8f7d-e05aa486d370" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "2f792c47-2b5d-4cbc-9317-ecf25bd550b9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 55, 4, 901, DateTimeKind.Local), "Molestiae ipsum alias aut aut suscipit nulla et.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 52, 20, 9, DateTimeKind.Local), 14, "Veritatis consectetur animi ratione commodi ea facilis voluptatibus accusamus non.", "cda19867-84de-4479-93a6-43270bef193f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 13, 2, 18, 331, DateTimeKind.Local), 16, "Sed aspernatur sed quibusdam voluptas dolores.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 45, 13, 539, DateTimeKind.Local), 16, "Quos itaque quod est dolores eius similique temporibus.", "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 9, 3, 52, DateTimeKind.Local), 19, "Voluptates quod accusantium voluptatem.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 50, 57, 648, DateTimeKind.Local), 11, "Autem rerum laudantium quisquam quibusdam placeat.", "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 44, 33, 715, DateTimeKind.Local), 20, "Et aut est et et.", "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 35, 26, 340, DateTimeKind.Local), 14, "Et ea officia assumenda culpa vero.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 16, 31, 9, 639, DateTimeKind.Local), "Eligendi est et dolores dicta itaque pariatur rem sit.", "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 12, 19, 130, DateTimeKind.Local), 12, "Cumque aliquam voluptas esse culpa ipsa sunt animi provident esse.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "772.448.0953", "e2e54396-b4f8-4a18-b086-3eb415e3c272", "", "Sophie.Schuppe@yahoo.com", "Company829", "http://isaias.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(565) 567-0870 x21916", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9", "Ratione corrupti omnis vero sunt iste veniam distinctio sequi. Ut quibusdam consequatur rerum in aliquam eum. Iure ex in.", "Treva.Rippin56@hotmail.com", "Company342", 67, "http://nelda.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(408) 783-8415 x19468", "cda19867-84de-4479-93a6-43270bef193f", "Corporis reprehenderit nihil. Et est adipisci atque. Repellat qui sed accusantium voluptatem.", "Dion_Grant57@gmail.com", "Company989", 61, "http://izaiah.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(686) 293-4903 x639", "b24b21aa-3996-4d86-8f7d-e05aa486d370", "Id vel veritatis nostrum dicta. Omnis voluptates optio ea. Et ut consequatur velit et. Aliquid quia quidem commodi praesentium eum voluptas pariatur similique.", "Florence_Emmerich@yahoo.com", "Company740", 63, "https://haven.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "812-361-5164", "389a422b-9013-4486-b81f-7b6dcca703f1", "Facilis adipisci voluptatibus. Repellat modi dignissimos sint. Deleniti ipsum dolorum odio et porro accusantium et vel. Optio molestiae sunt quo voluptatem voluptas.", "Karli_Legros59@hotmail.com", "Company739", 63, "http://braden.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-669-343-0588 x3518", "cda19867-84de-4479-93a6-43270bef193f", "Fugit iste ex fugiat. Accusamus sit cumque quas cupiditate pariatur nulla iure error. Eum eos dolor numquam eius perferendis sit tempore occaecati aut. Enim quis aliquid atque aut autem ea beatae omnis.", "London87@gmail.com", "Company742", 70, "https://estell.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(930) 267-1088", "b24b21aa-3996-4d86-8f7d-e05aa486d370", "Iste est ut. Quam illo corrupti. Et natus voluptate beatae aliquam.", "Cristopher_Wolff@hotmail.com", "Company58", 61, "http://cleveland.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "664.913.9156", "cda19867-84de-4479-93a6-43270bef193f", "Velit impedit illum qui autem animi.", "Amina.Veum43@hotmail.com", "Company36", 68, "http://aubree.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-483-911-2733 x44236", "cda19867-84de-4479-93a6-43270bef193f", "Id inventore placeat omnis suscipit doloremque accusamus nulla amet.", "Javon_Braun32@gmail.com", "Company140", 64, "http://creola.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-454-483-6271", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", "Saepe sequi magnam sequi doloribus at. Occaecati hic placeat. Eius facere quidem vitae omnis repellendus neque aut autem esse.", "Fidel.Murphy@hotmail.com", "Company524", "https://richie.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 3, 55, 122, DateTimeKind.Local), 41, "Cum rerum voluptates nulla ullam.", "b24b21aa-3996-4d86-8f7d-e05aa486d370" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 17, 32, 205, DateTimeKind.Local), 42, "Iure dolor qui omnis corrupti eius dolorem sunt suscipit.", "b24b21aa-3996-4d86-8f7d-e05aa486d370" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 45, 34, 840, DateTimeKind.Local), 50, "Exercitationem quas et ad et.", "389a422b-9013-4486-b81f-7b6dcca703f1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 28, 46, 461, DateTimeKind.Local), 48, "Nihil at quod mollitia.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 5, 18, 774, DateTimeKind.Local), 50, "Dolores repellat ipsam eveniet exercitationem.", "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 17, 40, 23, 766, DateTimeKind.Local), 42, "Magni incidunt quia omnis.", "b1758db9-1724-4e4c-a732-d7bb439a2740" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 15, 7, 240, DateTimeKind.Local), 49, "Nisi ea animi voluptatem quod.", "9ae2e670-2176-43d0-961e-09eac31bce0e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 20, 11, 35, 810, DateTimeKind.Local), 49, "Rem ut vel saepe.", "2f792c47-2b5d-4cbc-9317-ecf25bd550b9" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 43, 52, 431, DateTimeKind.Local), 50, "Tempora nihil debitis.", "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 20, 24, 132, DateTimeKind.Local), 46, "Minima nobis debitis sapiente porro iusto.", "2b7f0286-0e54-4e1c-aac6-9682797bc9eb" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", 72, 1 },
                    { "b1758db9-1724-4e4c-a732-d7bb439a2740", 79, 1 },
                    { "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc", 71, 1 },
                    { "389a422b-9013-4486-b81f-7b6dcca703f1", 78, 1 },
                    { "e2e54396-b4f8-4a18-b086-3eb415e3c272", 76, 1 },
                    { "b24b21aa-3996-4d86-8f7d-e05aa486d370", 75, 1 },
                    { "cda19867-84de-4479-93a6-43270bef193f", 78, 1 },
                    { "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", 78, 1 },
                    { "9ae2e670-2176-43d0-961e-09eac31bce0e", 74, 1 },
                    { "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9", 76, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2b7f0286-0e54-4e1c-aac6-9682797bc9eb", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2f792c47-2b5d-4cbc-9317-ecf25bd550b9", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "389a422b-9013-4486-b81f-7b6dcca703f1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9ae2e670-2176-43d0-961e-09eac31bce0e", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b1758db9-1724-4e4c-a732-d7bb439a2740", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b24b21aa-3996-4d86-8f7d-e05aa486d370", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cda19867-84de-4479-93a6-43270bef193f", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e2e54396-b4f8-4a18-b086-3eb415e3c272", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2b7f0286-0e54-4e1c-aac6-9682797bc9eb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2f792c47-2b5d-4cbc-9317-ecf25bd550b9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "389a422b-9013-4486-b81f-7b6dcca703f1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6cc549f2-afeb-4c8c-9900-9f218ad0e2dc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9ae2e670-2176-43d0-961e-09eac31bce0e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b1758db9-1724-4e4c-a732-d7bb439a2740");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b24b21aa-3996-4d86-8f7d-e05aa486d370");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cda19867-84de-4479-93a6-43270bef193f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e2e54396-b4f8-4a18-b086-3eb415e3c272");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fad7ef4f-74ed-4957-bf42-08f8cad0bcb9");

            migrationBuilder.DropColumn(
                name: "AggregationForWeek",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 92, 38 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 98, 25 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 37, 2 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 83, 0 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 27, 12, 317, DateTimeKind.Local), 83, "Title766" });

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
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "37:22:f2:5d:8c:f8", false, false, false, 0f, 0f, 76, "Linux", 0f, "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "7a:db:32:bb:5b:c2", false, false, false, 0f, 0f, 78, "Linux", 0f, "Instance369" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "a1:b5:02:9d:a2:a3", false, false, false, 0f, 0f, 75, "Windows", 0f, "Instance970" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "88:08:62:98:11:a9", false, false, false, 0f, 0f, 78, "Linux", 0f, "Instance610" });

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
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "0b:22:7d:81:af:8a", false, false, false, 0f, 0f, 72, "Linux", 0f, "Instance664" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "5e:9e:9e:7d:9b:f2", false, false, false, 0f, 0f, 73, "Linux", 0f, "Instance833" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "OrganizationId", "Platform", "RamMaxPercent", "Title" },
                values: new object[] { "89:61:dc:fc:f6:cf", false, false, false, 0f, 0f, 79, "Linux", 0f, "Instance909" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme751" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme242" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme206" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme483" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme13" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme407" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme786" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme921" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 36, 21, 994, DateTimeKind.Local), "Ut praesentium dolor voluptas.", "48496f80-3505-4088-bce9-721237904d3e", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 9, 21, 6, 38, 692, DateTimeKind.Local), "Qui eius ut.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 20, 48, 3, 467, DateTimeKind.Local), "Saepe adipisci alias voluptatem ut aut nihil sapiente.", "4d0ca69b-3af6-4f4f-91c0-4c40af481ac6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 9, 14, 27, 17, 993, DateTimeKind.Local), "Ut dolores dolor corporis voluptatem illo quia id numquam iure.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 10, 42, 18, 245, DateTimeKind.Local), "Accusantium beatae et sunt velit reiciendis et debitis.", "94e2a11d-e4bd-4f1e-8e18-bd302131b886" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 7, 35, 39, 765, DateTimeKind.Local), "Aut ut aut earum vero.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 6, 31, 5, 489, DateTimeKind.Local), "Maiores quia quis earum itaque qui.", "733804e3-2791-4002-81c8-c134b163717b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 20, 10, 30, 838, DateTimeKind.Local), "Architecto officiis nobis quia.", "48496f80-3505-4088-bce9-721237904d3e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "733804e3-2791-4002-81c8-c134b163717b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "79e46537-a194-4592-b5ab-04b90c068eb3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 3, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 2, "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 2, "ec62c0a6-f281-40a1-a913-35c180dc66fd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 3, 50, 887, DateTimeKind.Local), "Laborum tempora enim consequatur voluptas et odit at corporis modi.", "8ad214b9-dbd3-4eb6-ada3-eda95c538e17" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 3, 29, 820, DateTimeKind.Local), "Molestiae debitis blanditiis blanditiis debitis ducimus eum ad.", "8311d2de-57c8-4c5c-8641-ebf1e1fb1c85" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "711.651.8263", "48496f80-3505-4088-bce9-721237904d3e", "Inventore omnis consequatur sit. Autem ut saepe dolores debitis quaerat distinctio consequatur. Debitis quo delectus vero dignissimos possimus a illum dolor. Et non vel ad ipsa totam.", "Vincenzo61@yahoo.com", "Company998", "https://jolie.info" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-246-456-0031 x633", "733804e3-2791-4002-81c8-c134b163717b", "Cupiditate voluptate deserunt veritatis illum quia praesentium suscipit vitae.", "Whitney.Sipes@gmail.com", "Company409", 70, "http://river.biz" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(755) 580-7585 x792", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "", "Afton66@hotmail.com", "Company360", 62, "http://lindsey.org" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "513-788-7830 x8497", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca", "Est ipsam aut et iusto sit rerum delectus vel. Repellendus sapiente nihil dignissimos. Impedit quia qui minus assumenda. Quaerat autem et consectetur.", "Keely33@hotmail.com", "Company433", "http://janice.biz" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 32, 36, 556, DateTimeKind.Local), 47, "Accusamus consequuntur non animi.", "eb45ec73-aae9-4fc7-9f1c-9e4ab43bd4ca" });

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
