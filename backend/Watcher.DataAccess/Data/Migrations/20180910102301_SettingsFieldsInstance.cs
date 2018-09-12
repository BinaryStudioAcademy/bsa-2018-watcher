using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class SettingsFieldsInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0da18978-1656-4b4d-ac10-940871d87e18", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14e7d6f2-3626-423b-959b-e8ca1b882173", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "732bab35-8c9e-4812-b4ff-251abdf5b857", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9a549b2b-8fd0-4d70-9145-569474fea109", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b22d062-92ae-494c-9481-11c2931737da");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0bddde5f-5756-4d7f-8521-42d0476f3aa0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0da18978-1656-4b4d-ac10-940871d87e18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14e7d6f2-3626-423b-959b-e8ca1b882173");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36410a7e-ff1b-4570-8a45-82e6d045bfda");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6aa322ac-217f-449e-8ebf-12b4f2e2436c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "732bab35-8c9e-4812-b4ff-251abdf5b857");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9a549b2b-8fd0-4d70-9145-569474fea109");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd12165e-60bb-40a0-a6da-ee98a35e2a2c");

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForDay",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForHour",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForMonth",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "CpuMaxPercent",
                table: "Instances",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DiskMaxPercent",
                table: "Instances",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "RamMaxPercent",
                table: "Instances",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 28, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 95, 92 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 12 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 57, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 98, 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 92, 83 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 84, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 41, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 19, 20, 162, DateTimeKind.Local), 90, "Title555" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 12, 9, 81, DateTimeKind.Local), 81, "Title665" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 59, 13, 87, DateTimeKind.Local), 82, "Title593" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 3, 31, 24, 262, DateTimeKind.Local), 85, "Title143" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 14, 57, 579, DateTimeKind.Local), 83, "Title488" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 7, 28, 404, DateTimeKind.Local), 83, "Title779" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 10, 50, 58, 220, DateTimeKind.Local), "Title882" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 18, 12, 584, DateTimeKind.Local), 86, "Title662" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 49, 25, 406, DateTimeKind.Local), 83, "Title874" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 27, 47, 716, DateTimeKind.Local), 85, "Title497" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "37:22:f2:5d:8c:f8", 76, "Linux", "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "7a:db:32:bb:5b:c2", 78, "Instance369" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a1:b5:02:9d:a2:a3", 75, "Windows", "Instance970" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "88:08:62:98:11:a9", 78, "Linux", "Instance610" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b3:16:96:4a:c8:63", 73, "Instance896" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ba:95:d0:cb:af:81", 72, "Linux", "Instance34" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "80:e3:45:08:d5:72", 75, "Windows", "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0b:22:7d:81:af:8a", 72, "Linux", "Instance664" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "5e:9e:9e:7d:9b:f2", "Linux", "Instance833" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:61:dc:fc:f6:cf", 79, "Instance909" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme281" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme118" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme869" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme52" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme299" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme870");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme993" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme271" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme561" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme799" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "fbe373fd-3b47-46fb-94a3-93ca1d825d14", null, new DateTime(2018, 9, 9, 22, 26, 11, 668, DateTimeKind.Local), "Alana", "Dayana93@gmail.com", null, "Jimmy", true, false, "Williamson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/attacks/128.jpg", 1 },
                    { "a6a964f2-d795-4b3c-af4c-a903e41c34ce", null, new DateTime(2018, 9, 10, 10, 25, 20, 524, DateTimeKind.Local), "Hazle", "Wendell.Ziemann70@hotmail.com", null, "Shaun", true, false, "Steuber", null, "https://s3.amazonaws.com/uifaces/faces/twitter/theonlyzeke/128.jpg", 1 },
                    { "e7912c8a-ef1e-4a77-8b57-692133075552", null, new DateTime(2018, 9, 9, 16, 2, 17, 310, DateTimeKind.Local), "Erich", "Boyd51@gmail.com", null, "Dorcas", true, false, "Hagenes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/thierrykoblentz/128.jpg", 2 },
                    { "a4196fc7-7711-43fe-a875-bb9fd6f911ac", null, new DateTime(2018, 9, 9, 18, 54, 57, 837, DateTimeKind.Local), "Frederick", "Stacy_Strosin@hotmail.com", null, "Candido", true, false, "McDermott", null, "https://s3.amazonaws.com/uifaces/faces/twitter/harry_sistalam/128.jpg", 1 },
                    { "5185e9e4-9ca3-456b-94bb-e00cec2e4111", null, new DateTime(2018, 9, 9, 16, 56, 25, 284, DateTimeKind.Local), "Rosario", "Alva.Mertz@yahoo.com", null, "Winnifred", true, false, "Braun", null, "https://s3.amazonaws.com/uifaces/faces/twitter/carlosjgsousa/128.jpg", 1 },
                    { "6f298990-71dd-4677-aebd-c1f7225d705d", null, new DateTime(2018, 9, 10, 2, 24, 52, 983, DateTimeKind.Local), "Timmothy", "Kattie71@hotmail.com", null, "Murphy", true, false, "Rogahn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/leeiio/128.jpg", 2 },
                    { "00e474b0-3967-4af2-a38e-f93f795a347c", null, new DateTime(2018, 9, 10, 6, 25, 15, 840, DateTimeKind.Local), "Edythe", "Abbigail.Schuppe@yahoo.com", null, "Deontae", true, false, "Gislason", null, "https://s3.amazonaws.com/uifaces/faces/twitter/benoitboucart/128.jpg", 1 },
                    { "5a80e498-6d51-4a7f-8557-dddb9d3323f4", null, new DateTime(2018, 9, 10, 9, 38, 5, 292, DateTimeKind.Local), "Dallas", "Louisa.Thiel@yahoo.com", null, "Trent", true, false, "Hane", null, "https://s3.amazonaws.com/uifaces/faces/twitter/foczzi/128.jpg", 2 },
                    { "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6", null, new DateTime(2018, 9, 9, 21, 25, 28, 299, DateTimeKind.Local), "Lia", "Wilmer_Halvorson@gmail.com", null, "Ona", true, false, "Stanton", null, "https://s3.amazonaws.com/uifaces/faces/twitter/llun/128.jpg", 2 },
                    { "d451fc62-30dc-4b46-9728-247662789858", null, new DateTime(2018, 9, 10, 11, 14, 17, 868, DateTimeKind.Local), "Kristian", "Houston_Medhurst67@gmail.com", null, "Yoshiko", true, false, "Stark", null, "https://s3.amazonaws.com/uifaces/faces/twitter/saulihirvi/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a6a964f2-d795-4b3c-af4c-a903e41c34ce", "provident" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d451fc62-30dc-4b46-9728-247662789858", "quod" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5a80e498-6d51-4a7f-8557-dddb9d3323f4", "corrupti" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a4196fc7-7711-43fe-a875-bb9fd6f911ac", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fbe373fd-3b47-46fb-94a3-93ca1d825d14", "exercitationem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a4196fc7-7711-43fe-a875-bb9fd6f911ac", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "00e474b0-3967-4af2-a38e-f93f795a347c", "minus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e7912c8a-ef1e-4a77-8b57-692133075552", "ea" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5185e9e4-9ca3-456b-94bb-e00cec2e4111", "amet" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 46, 32, 459, DateTimeKind.Local), "Delectus voluptatem repudiandae repellendus et et error quisquam architecto harum.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 22, 41, 448, DateTimeKind.Local), "Dolorum aspernatur quas deserunt et magnam esse accusamus.", "5185e9e4-9ca3-456b-94bb-e00cec2e4111" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 11, 33, 44, 636, DateTimeKind.Local), "Voluptatem et dolores sed et.", "a4196fc7-7711-43fe-a875-bb9fd6f911ac" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 51, 14, 40, DateTimeKind.Local), "Eum aut nesciunt assumenda quibusdam mollitia ullam laboriosam.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 23, 8, 600, DateTimeKind.Local), "Illo possimus officiis et voluptatem et.", "00e474b0-3967-4af2-a38e-f93f795a347c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 42, 23, 128, DateTimeKind.Local), "Esse ducimus sed ullam quisquam dolorum cupiditate quibusdam consequatur.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 53, 35, 661, DateTimeKind.Local), "Dolore hic dolorem qui laudantium sit nihil repellat sed voluptates.", "00e474b0-3967-4af2-a38e-f93f795a347c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 49, 7, 412, DateTimeKind.Local), "Quis sed iure sed.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 31, 18, 21, DateTimeKind.Local), "Odio occaecati labore itaque.", "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 0, 51, 480, DateTimeKind.Local), "Dolor quasi quas.", "5a80e498-6d51-4a7f-8557-dddb9d3323f4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 19, 26, 3, 797, DateTimeKind.Local), "Voluptatem corrupti voluptas ipsam quia debitis sit.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 10, 11, 25, 9, 468, DateTimeKind.Local), "Excepturi atque voluptas et.", "e7912c8a-ef1e-4a77-8b57-692133075552", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 10, 8, 51, 49, 341, DateTimeKind.Local), "Necessitatibus asperiores possimus totam at et autem dicta quis rerum.", "6f298990-71dd-4677-aebd-c1f7225d705d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 58, 8, 460, DateTimeKind.Local), "Velit animi veniam debitis vitae corporis perspiciatis ea.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 6, 55, 6, 851, DateTimeKind.Local), "Omnis aperiam temporibus.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 18, 14, 54, 887, DateTimeKind.Local), "Sunt pariatur ex autem reprehenderit recusandae.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 10, 9, 16, 48, 58, DateTimeKind.Local), "Ut nam sunt ipsum.", "00e474b0-3967-4af2-a38e-f93f795a347c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 10, 5, 33, 3, 763, DateTimeKind.Local), "Harum architecto veniam harum corporis.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 17, 14, 28, 396, DateTimeKind.Local), "Sint quo vel.", "d451fc62-30dc-4b46-9728-247662789858", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 4, 30, 38, 503, DateTimeKind.Local), "Est consequatur vitae error earum dolorem alias.", "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 2, "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "00e474b0-3967-4af2-a38e-f93f795a347c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "d451fc62-30dc-4b46-9728-247662789858" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "5a80e498-6d51-4a7f-8557-dddb9d3323f4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "a4196fc7-7711-43fe-a875-bb9fd6f911ac" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "a4196fc7-7711-43fe-a875-bb9fd6f911ac" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "6f298990-71dd-4677-aebd-c1f7225d705d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "fbe373fd-3b47-46fb-94a3-93ca1d825d14" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 1, "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "00e474b0-3967-4af2-a38e-f93f795a347c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 4, 7, 35, 778, DateTimeKind.Local), 18, "Recusandae doloremque dolor ut inventore blanditiis sit est iusto est.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 23, 40, 484, DateTimeKind.Local), 14, "Explicabo alias eligendi quaerat ratione.", "a4196fc7-7711-43fe-a875-bb9fd6f911ac" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 20, 45, 416, DateTimeKind.Local), 12, "Aut non laborum rerum omnis tempore porro ut et harum.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 29, 43, 651, DateTimeKind.Local), 11, "Esse sed enim ut qui iure laudantium et.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 2, 41, 41, 19, DateTimeKind.Local), 18, "Ea porro est neque voluptatem culpa qui inventore eveniet est.", "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 36, 18, 791, DateTimeKind.Local), "Porro voluptatem qui.", "00e474b0-3967-4af2-a38e-f93f795a347c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 1, 7, 59, 970, DateTimeKind.Local), 17, "Quis minima est quo ut et sapiente molestias voluptatem laboriosam.", "6f298990-71dd-4677-aebd-c1f7225d705d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 54, 2, 807, DateTimeKind.Local), 18, "Alias voluptas quidem atque laudantium.", "fbe373fd-3b47-46fb-94a3-93ca1d825d14" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 3, 31, 29, 509, DateTimeKind.Local), "Sunt quos sed porro libero ipsam aperiam numquam.", "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 1, 53, 939, DateTimeKind.Local), "Odio ab voluptas et sapiente dolorum unde quidem ut recusandae.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "690-894-2372", "e7912c8a-ef1e-4a77-8b57-692133075552", "", "Darby.Hilpert38@hotmail.com", "Company595", 62, "http://concepcion.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "322.468.2006 x377", "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6", "Suscipit quasi quia in quis sed autem beatae et explicabo. Et provident libero animi dolorem magni earum autem. Et dolor molestiae est doloribus hic aspernatur nesciunt dolores error.", "Nicholas.Mohr@yahoo.com", "Company874", "http://hailee.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "317.934.8183 x8311", "00e474b0-3967-4af2-a38e-f93f795a347c", "Quam sit quidem culpa recusandae aliquam. Facilis eos totam.", "Ulises47@gmail.com", "Company982", "http://haleigh.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(730) 730-3083 x5047", "e7912c8a-ef1e-4a77-8b57-692133075552", "Recusandae et provident aut recusandae quibusdam alias inventore commodi. Molestiae delectus omnis velit earum mollitia. Quia molestiae sint perspiciatis.", "Jamie_Hermiston@hotmail.com", "Company121", "https://randy.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-823-879-6368 x632", "00e474b0-3967-4af2-a38e-f93f795a347c", "Alias voluptas magni pariatur possimus enim.", "Rowan.Keeling@yahoo.com", "Company557", 61, "http://mathilde.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "638-350-2259", "fbe373fd-3b47-46fb-94a3-93ca1d825d14", "Dolores praesentium aut occaecati. Quia voluptas molestiae tempora fugit cumque corporis. Magnam ut sunt autem eligendi rerum molestiae explicabo veritatis repellendus. Nobis hic sunt voluptas dolores.", "Tyrell_Marks@yahoo.com", "Company975", "https://murray.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "240.593.0149", "d451fc62-30dc-4b46-9728-247662789858", "", "Geoffrey.Kuhic@gmail.com", "Company187", 61, "http://mandy.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "744-873-2070", "a6a964f2-d795-4b3c-af4c-a903e41c34ce", "Libero perferendis voluptatem et voluptas libero amet ipsum odit.", "Robyn.Mraz42@hotmail.com", "Company71", 64, "http://alanna.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "566-657-9303", "e7912c8a-ef1e-4a77-8b57-692133075552", "Id corrupti sed aspernatur. Quo nisi quia ut natus tempore. Mollitia unde nemo qui et consectetur illum. Aut aut dolorem dolore et voluptatem deserunt quis neque debitis.", "Nolan_Volkman86@gmail.com", "Company810", 65, "http://trisha.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(900) 247-5859 x27694", "5185e9e4-9ca3-456b-94bb-e00cec2e4111", "Ut a distinctio voluptatem. Laudantium culpa reprehenderit aut.", "Herman.Pfannerstill63@gmail.com", "Company104", "https://mandy.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 12, 15, 51, 729, DateTimeKind.Local), 49, "Et consequatur consequatur.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 11, 25, 19, 309, DateTimeKind.Local), 46, "Autem quidem libero quas eius qui veritatis ut.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 22, 49, 40, 74, DateTimeKind.Local), 46, "Reprehenderit delectus iste qui quo necessitatibus deserunt.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 5, 42, 14, 861, DateTimeKind.Local), 49, "Cumque itaque atque omnis et error qui nisi et sapiente.", "a4196fc7-7711-43fe-a875-bb9fd6f911ac" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 4, 54, 43, 12, DateTimeKind.Local), 49, "Minus porro ut quibusdam cumque aspernatur itaque et nihil.", "a6a964f2-d795-4b3c-af4c-a903e41c34ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 7, 29, 27, 815, DateTimeKind.Local), 43, "Explicabo nesciunt est.", "5185e9e4-9ca3-456b-94bb-e00cec2e4111" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 11, 7, 570, DateTimeKind.Local), 41, "Delectus similique minus ut quaerat repellendus aliquid autem.", "6f298990-71dd-4677-aebd-c1f7225d705d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 36, 55, 768, DateTimeKind.Local), "Facere debitis reiciendis ipsum ab consequatur culpa et.", "5a80e498-6d51-4a7f-8557-dddb9d3323f4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 8, 56, 34, 757, DateTimeKind.Local), 48, "Ea molestiae atque harum.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 9, 55, 4, 106, DateTimeKind.Local), "Et explicabo rerum dolorem voluptatibus quidem sed sint maxime.", "e7912c8a-ef1e-4a77-8b57-692133075552" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "fbe373fd-3b47-46fb-94a3-93ca1d825d14", 77, 1 },
                    { "00e474b0-3967-4af2-a38e-f93f795a347c", 78, 1 },
                    { "e7912c8a-ef1e-4a77-8b57-692133075552", 79, 1 },
                    { "a6a964f2-d795-4b3c-af4c-a903e41c34ce", 74, 1 },
                    { "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6", 75, 1 },
                    { "6f298990-71dd-4677-aebd-c1f7225d705d", 76, 1 },
                    { "5185e9e4-9ca3-456b-94bb-e00cec2e4111", 73, 1 },
                    { "a4196fc7-7711-43fe-a875-bb9fd6f911ac", 72, 1 },
                    { "5a80e498-6d51-4a7f-8557-dddb9d3323f4", 76, 1 },
                    { "d451fc62-30dc-4b46-9728-247662789858", 76, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "00e474b0-3967-4af2-a38e-f93f795a347c", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5185e9e4-9ca3-456b-94bb-e00cec2e4111", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5a80e498-6d51-4a7f-8557-dddb9d3323f4", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6f298990-71dd-4677-aebd-c1f7225d705d", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a4196fc7-7711-43fe-a875-bb9fd6f911ac", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a6a964f2-d795-4b3c-af4c-a903e41c34ce", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d451fc62-30dc-4b46-9728-247662789858", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7912c8a-ef1e-4a77-8b57-692133075552", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fbe373fd-3b47-46fb-94a3-93ca1d825d14", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "00e474b0-3967-4af2-a38e-f93f795a347c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5185e9e4-9ca3-456b-94bb-e00cec2e4111");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5a80e498-6d51-4a7f-8557-dddb9d3323f4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6f298990-71dd-4677-aebd-c1f7225d705d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "81fb2ff2-02f5-40a4-8baa-a9aec161c4d6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a4196fc7-7711-43fe-a875-bb9fd6f911ac");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a6a964f2-d795-4b3c-af4c-a903e41c34ce");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d451fc62-30dc-4b46-9728-247662789858");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7912c8a-ef1e-4a77-8b57-692133075552");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fbe373fd-3b47-46fb-94a3-93ca1d825d14");

            migrationBuilder.DropColumn(
                name: "AggregationForDay",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "AggregationForHour",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "AggregationForMonth",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "CpuMaxPercent",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "DiskMaxPercent",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "RamMaxPercent",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 14, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 73, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 76, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 98 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 93, 40 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 78, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 13, 23, 708, DateTimeKind.Local), 82, "Title187" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 7, 26, 619, DateTimeKind.Local), 84, "Title344" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 26, 18, 615, DateTimeKind.Local), 85, "Title328" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 20, 43, 423, DateTimeKind.Local), 82, "Title568" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 3, 4, 274, DateTimeKind.Local), 87, "Title317" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 7, 13, 27, 393, DateTimeKind.Local), 85, "Title756" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 36, 59, 89, DateTimeKind.Local), "Title712" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 18, 28, 429, DateTimeKind.Local), 89, "Title719" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 42, 20, 709, DateTimeKind.Local), 84, "Title235" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 4, 23, 15, 916, DateTimeKind.Local), 90, "Title956" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "54:bc:6c:85:e1:55", 78, "Windows", "Instance802" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "93:89:86:96:e6:11", 79, "Instance46" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2d:74:0e:71:6f:7a", 76, "Linux", "Instance819" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "04:d6:00:79:e3:b7", 72, "Windows", "Instance161" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "df:be:1e:09:9c:ab", 74, "Instance856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5e:42:96:2e:00:e0", 77, "Windows", "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c8:5c:b1:ee:61:bc", 76, "Linux", "Instance85" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e7:0a:de:ee:bf:6e", 74, "Windows", "Instance701" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "16:66:b1:ef:be:c1", "Windows", "Instance831" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "09:2f:b3:74:1b:82", 71, "Instance474" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme497" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme140" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme871" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme602" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme326" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme509");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme91" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme292" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme180" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme513" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", null, new DateTime(2018, 9, 9, 13, 36, 12, 571, DateTimeKind.Local), "Leslie", "Javier.Paucek@gmail.com", null, "Rylee", true, false, "Kuhlman", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joreira/128.jpg", 2 },
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", null, new DateTime(2018, 9, 9, 1, 55, 45, 527, DateTimeKind.Local), "Ethyl", "Raphael.Murazik@hotmail.com", null, "Cali", true, false, "Kutch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tobysaxon/128.jpg", 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", null, new DateTime(2018, 9, 9, 5, 37, 2, 549, DateTimeKind.Local), "Winston", "Austyn77@yahoo.com", null, "Shayna", true, false, "Parker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gearpixels/128.jpg", 1 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", null, new DateTime(2018, 9, 9, 19, 34, 7, 631, DateTimeKind.Local), "Andrew", "Ezekiel.Hermiston1@yahoo.com", null, "Grover", true, false, "Ryan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/angelceballos/128.jpg", 2 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", null, new DateTime(2018, 9, 9, 8, 19, 36, 70, DateTimeKind.Local), "Makenna", "Davin_Schulist60@gmail.com", null, "Crawford", true, false, "Gaylord", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 2 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", null, new DateTime(2018, 9, 9, 4, 14, 16, 766, DateTimeKind.Local), "Rodrigo", "Benton14@yahoo.com", null, "Tom", true, false, "Hauck", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bargaorobalo/128.jpg", 1 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", null, new DateTime(2018, 9, 9, 3, 38, 22, 832, DateTimeKind.Local), "Jacinthe", "Zoe82@gmail.com", null, "Kellie", true, false, "Stehr", null, "https://s3.amazonaws.com/uifaces/faces/twitter/suribbles/128.jpg", 2 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", null, new DateTime(2018, 9, 9, 11, 48, 24, 489, DateTimeKind.Local), "Hope", "Sydnee90@yahoo.com", null, "Oliver", true, false, "Hoppe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bobbytwoshoes/128.jpg", 1 },
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", null, new DateTime(2018, 9, 9, 0, 52, 56, 943, DateTimeKind.Local), "Adan", "Bridget74@yahoo.com", null, "Jacky", true, false, "Keebler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/oscarowusu/128.jpg", 1 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", null, new DateTime(2018, 9, 9, 14, 28, 5, 94, DateTimeKind.Local), "Dillan", "Justus44@hotmail.com", null, "Carmel", true, false, "Bradtke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samihah/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0da18978-1656-4b4d-ac10-940871d87e18", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", "aliquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9a549b2b-8fd0-4d70-9145-569474fea109", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "recusandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0b22d062-92ae-494c-9481-11c2931737da", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "animi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "14e7d6f2-3626-423b-959b-e8ca1b882173", "quos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "36410a7e-ff1b-4570-8a45-82e6d045bfda", "id" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 52, 11, 195, DateTimeKind.Local), "Nulla et perspiciatis.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 29, 5, 920, DateTimeKind.Local), "Et est voluptatibus et qui cumque eos nesciunt praesentium illo.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 25, 23, 926, DateTimeKind.Local), "Adipisci quo dolores animi quo doloribus qui eos velit unde.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 8, 28, 32, DateTimeKind.Local), "Sequi reprehenderit est delectus sit dolor.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 8, 1, 415, DateTimeKind.Local), "Repellendus error officia tenetur et qui possimus voluptas.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 51, 41, 285, DateTimeKind.Local), "Consequatur dolor quia.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 4, 16, 23, 539, DateTimeKind.Local), "Ad fugiat odit quam modi et debitis est perspiciatis.", "6aa322ac-217f-449e-8ebf-12b4f2e2436c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 23, 54, 56, 711, DateTimeKind.Local), "Est ipsa consequatur ut provident ab.", "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 44, 49, 86, DateTimeKind.Local), "Maxime earum odit et non quisquam occaecati nobis aut.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 51, 6, 29, DateTimeKind.Local), "Quas quas exercitationem officiis et error cumque impedit.", "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 4, 38, 36, 540, DateTimeKind.Local), "Voluptatum adipisci repellendus vitae facilis odit.", "0b22d062-92ae-494c-9481-11c2931737da", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 7, 44, 12, 280, DateTimeKind.Local), "Quia eaque reiciendis id non.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 18, 34, 36, 38, DateTimeKind.Local), "Sequi odit inventore unde quibusdam tempore voluptates consequuntur et.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 21, 58, 678, DateTimeKind.Local), "Quam culpa qui autem accusamus.", "0b22d062-92ae-494c-9481-11c2931737da", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 44, 26, 9, DateTimeKind.Local), "Nihil quia ad et odio et dolorem.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 0, 54, 33, 391, DateTimeKind.Local), "Est sed pariatur.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 13, 45, 57, 927, DateTimeKind.Local), "Numquam facere ipsa porro.", "0b22d062-92ae-494c-9481-11c2931737da", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 21, 9, 39, 318, DateTimeKind.Local), "Qui ut non accusamus quos voluptas voluptatum.", "36410a7e-ff1b-4570-8a45-82e6d045bfda", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 9, 1, 15, 27, 632, DateTimeKind.Local), "Maiores dolor nihil earum suscipit at consectetur non et sunt.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 35, 21, 699, DateTimeKind.Local), "Minima natus unde dicta aspernatur earum deserunt sint tempora reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 3, "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "6aa322ac-217f-449e-8ebf-12b4f2e2436c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 2, "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 2, "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 37, 9, 256, DateTimeKind.Local), 16, "Tempora omnis nobis a enim explicabo qui vitae.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 58, 14, 361, DateTimeKind.Local), 18, "Aut adipisci facere perferendis.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 26, 37, 181, DateTimeKind.Local), 13, "Porro et architecto nulla.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 49, 50, 408, DateTimeKind.Local), 17, "Sequi eius est dolores aspernatur.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 29, 11, 14, DateTimeKind.Local), 12, "Doloremque impedit quod aut odit dolore delectus fuga rem mollitia.", "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 23, 32, 536, DateTimeKind.Local), "Officiis dolores dolores tenetur nesciunt.", "36410a7e-ff1b-4570-8a45-82e6d045bfda" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 20, 10, 310, DateTimeKind.Local), 11, "Et beatae non non natus quasi fugit officiis.", "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 54, 34, 750, DateTimeKind.Local), 20, "Soluta sit iure est qui odit.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 0, 37, 52, 879, DateTimeKind.Local), "Unde accusantium accusamus.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 57, 27, 602, DateTimeKind.Local), "Quis sint beatae assumenda.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "439-419-3955 x8548", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Adipisci molestias non quisquam earum dolorum molestias iste. Explicabo ea ut mollitia itaque repudiandae. Est unde quasi.", "Jarrod_Hammes29@gmail.com", "Company541", 67, "https://chadrick.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(204) 999-6677 x405", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "", "Domingo.Stiedemann@yahoo.com", "Company114", "http://janis.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(440) 509-1684", "14e7d6f2-3626-423b-959b-e8ca1b882173", "", "Sofia_Schaefer8@hotmail.com", "Company613", "http://lew.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "662.300.3345", "14e7d6f2-3626-423b-959b-e8ca1b882173", "Nostrum iusto voluptatem culpa ut.", "Madyson19@hotmail.com", "Company435", "https://mose.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "614.292.9580 x822", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "", "Alessandra.Heller42@gmail.com", "Company165", 67, "https://kamron.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-958-620-8119 x139", "0da18978-1656-4b4d-ac10-940871d87e18", "", "Elias.Schmeler76@yahoo.com", "Company221", "http://bert.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "631.889.3525 x9022", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Enim sit quia nemo tempore accusantium. Voluptatibus eum aliquid ab. Mollitia iure doloremque omnis quaerat voluptatem ut suscipit.", "Dorothy.Torphy@hotmail.com", "Company782", 68, "https://alvina.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(938) 960-5637", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Quo consequatur vero sint ut autem aut doloremque ullam laborum. Rerum repellendus est qui sit rerum.", "Juliet_Powlowski@yahoo.com", "Company297", 65, "https://josiane.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(259) 858-0505 x993", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Dicta a hic tempora illo dolorem. Dolorum voluptas nemo ea ea.", "Lura_Kling61@yahoo.com", "Company833", 64, "http://marianna.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(732) 704-3028 x624", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Id modi distinctio animi dolorem. Amet quia sint id harum exercitationem.", "Madison.Collins@yahoo.com", "Company179", "http://orlo.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 10, 3, 91, DateTimeKind.Local), 41, "Voluptas enim laborum ex explicabo voluptates est sequi.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 27, 14, 956, DateTimeKind.Local), 41, "Saepe alias maiores aut qui ea delectus.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 59, 34, 800, DateTimeKind.Local), 48, "Modi sed quo doloremque quis atque incidunt corporis qui.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 27, 16, 499, DateTimeKind.Local), 50, "Animi consequatur molestiae omnis.", "732bab35-8c9e-4812-b4ff-251abdf5b857" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 58, 39, 165, DateTimeKind.Local), 44, "Et aut ea accusamus aliquam.", "9a549b2b-8fd0-4d70-9145-569474fea109" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 34, 33, 692, DateTimeKind.Local), 49, "Quia qui ad nihil reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 24, 31, 160, DateTimeKind.Local), 49, "Libero consectetur alias dolorum deleniti.", "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 54, 52, 111, DateTimeKind.Local), "Omnis recusandae consectetur magnam provident explicabo.", "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 36, 22, 152, DateTimeKind.Local), 41, "Nesciunt aperiam recusandae tempore a.", "0da18978-1656-4b4d-ac10-940871d87e18" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 3, 44, 42, 883, DateTimeKind.Local), "Id quia unde quae eveniet delectus ea.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "36410a7e-ff1b-4570-8a45-82e6d045bfda", 71, 1 },
                    { "9a549b2b-8fd0-4d70-9145-569474fea109", 77, 1 },
                    { "14e7d6f2-3626-423b-959b-e8ca1b882173", 76, 1 },
                    { "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1", 76, 1 },
                    { "0bddde5f-5756-4d7f-8521-42d0476f3aa0", 73, 1 },
                    { "6aa322ac-217f-449e-8ebf-12b4f2e2436c", 74, 1 },
                    { "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", 75, 1 },
                    { "0b22d062-92ae-494c-9481-11c2931737da", 74, 1 },
                    { "732bab35-8c9e-4812-b4ff-251abdf5b857", 72, 1 },
                    { "0da18978-1656-4b4d-ac10-940871d87e18", 79, 1 }
                });
        }
    }
}
