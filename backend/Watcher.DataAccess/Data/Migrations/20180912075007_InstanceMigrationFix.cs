using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class InstanceMigrationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2819394b-d044-4be1-960d-a60e12a21f7a", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76acb978-b2aa-4340-84d0-02494e5175e4", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94719eb2-7b6a-4420-8a6f-264380d3263f", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9603312a-f694-4178-9405-0edf297ba8b3", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9d3f18be-2903-40c5-954d-1b3718154f55", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", 65 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1a663fb2-1a63-4070-a001-ed559a8c4160");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2819394b-d044-4be1-960d-a60e12a21f7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2a6ff317-062f-4fa9-982a-b5e85d35db4f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76acb978-b2aa-4340-84d0-02494e5175e4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94719eb2-7b6a-4420-8a6f-264380d3263f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9603312a-f694-4178-9405-0edf297ba8b3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9d3f18be-2903-40c5-954d-1b3718154f55");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9d3c359-9b33-48fd-95d0-502911a4d3bc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e338b266-bcb3-4a6b-b652-3f6aea7cc02f");

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForWeek",
                table: "Instances",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 69, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 83, 53 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 21, 1 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 58, 1 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 1, 34, 793, DateTimeKind.Local), 73, "Title704" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "23:5f:5d:c6:ec:8b", 63, "Windows", "Instance442" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9b:b2:51:bd:38:2d", 62, "Instance267" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3a:a4:09:54:03:da", 66, "Instance110" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "72:fc:b4:3d:1c:e5", 64, "Instance100" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a4:78:9b:4f:b0:98", 68, "Linux", "Instance330" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "eb:be:70:0c:f9:ac", 63, "Instance303" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ButtonFontSize",
                value: "14px");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 20, 48, 55, 440, DateTimeKind.Local), "Velit sint odit.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 51, 4, 136, DateTimeKind.Local), "Atque ut voluptas omnis et optio consequatur dolorem enim.", "b2de8088-0082-443c-bbc8-b371d5a27ff2", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 12, 3, 12, 35, 479, DateTimeKind.Local), "Aliquam est qui soluta ut et natus.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 21, 8, 12, 35, DateTimeKind.Local), "Est deleniti excepturi dicta aut laboriosam voluptates aperiam earum.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 12, 42, 16, 190, DateTimeKind.Local), "Atque doloremque eius earum.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 6, 39, 43, 132, DateTimeKind.Local), "Porro aperiam ab est.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 20, 6, 2, 824, DateTimeKind.Local), "Natus aut voluptatem corrupti itaque.", "b7002900-2813-4bba-9c01-835a58145c98" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 11, 15, 24, 533, DateTimeKind.Local), "Quis nam qui rerum provident ad quos.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 2, "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 4, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-697-554-2429 x0024", "b7002900-2813-4bba-9c01-835a58145c98", "Hic ullam in. Sed recusandae eaque eum non. Ipsum et officia quia.", "Enrico23@hotmail.com", "Company963", "https://afton.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "906.988.0244", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "", "Jamel_Nader@hotmail.com", "Company158", 2, "http://eryn.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(523) 655-2975 x14953", "f2e46ed8-f6e3-4859-b73e-394d18b11d29", "", "Floyd_Gerhold@hotmail.com", "Company395", "https://vergie.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "996.512.2577 x82041", "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", "Aut vel molestiae.", "Marilou8@gmail.com", "Company515", 1, "https://felicia.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-201-887-3058", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "Quia ab labore quia et perferendis qui sed.", "Natasha20@hotmail.com", "Company892", "http://tiffany.biz" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-348-370-2684 x1577", "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", "Ullam nam temporibus quasi voluptas omnis et.", "Queenie_Wehner@gmail.com", "Company27", "http://hiram.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-413-844-8283", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "Qui perferendis et. Rerum dolorum tenetur vel reprehenderit quo et ut accusantium.", "Jaycee78@gmail.com", "Company506", 1, "https://emmy.com" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 23, 0, 822, DateTimeKind.Local), "Voluptatem aut beatae quia consequatur aperiam placeat incidunt.", "b2de8088-0082-443c-bbc8-b371d5a27ff2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 7, 16, 584, DateTimeKind.Local), "Ut enim ducimus in illum iste facere autem.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 3, 38, 863, DateTimeKind.Local), 46, "Vel quis qui amet sit.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AggregationForWeek",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 85, 54, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 82, 37, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 82, 46 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 68, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 87, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 34, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 83, 60, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 78, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 82, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 86, 96, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 24, 27, 830, DateTimeKind.Local), 72, "Title675" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 32, 13, 297, DateTimeKind.Local), 78, "Title284" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 40, 57, 508, DateTimeKind.Local), 72, "Title218" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 25, 34, 351, DateTimeKind.Local), 71, "Title223" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 55, 13, 614, DateTimeKind.Local), 74, "Title600" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 10, 57, 224, DateTimeKind.Local), 80, "Title728" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 45, 57, 536, DateTimeKind.Local), 76, "Title753" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 35, 22, 129, DateTimeKind.Local), 74, "Title12" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 52, 40, 119, DateTimeKind.Local), 77, "Title907" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 36, 32, 506, DateTimeKind.Local), 76, "Title879" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:9b:bb:7b:ac:c5", 65, "Instance663" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8e:a1:f8:a5:c6:23", 64, "Instance511" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "14:75:ba:1f:90:03", 68, "Linux", "Instance972" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "9e:a3:88:cf:44:0b", 69, "Windows", "Instance191" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "72:64:8e:8e:94:3f", 65, "Instance718" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8f:f9:b3:30:e9:e9", 69, "Instance140" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "10:53:e8:e1:11:ea", 61, "Instance917" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "45:58:36:21:06:b0", 70, "Instance379" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "90:f5:f2:2d:11:a5", 70, "Windows", "Instance544" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2a:42:10:0e:c7:1e", 65, "Instance897" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ButtonFontSize",
                value: "14px !global");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", null, new DateTime(2018, 9, 11, 4, 3, 30, 315, DateTimeKind.Local), "Art", "Watson.Legros@yahoo.com", null, "Estefania", true, false, "Senger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidbaldie/128.jpg", 1 },
                    { "2819394b-d044-4be1-960d-a60e12a21f7a", null, new DateTime(2018, 9, 11, 14, 41, 27, 196, DateTimeKind.Local), "Rahul", "Garnett_Haag@gmail.com", null, "Zander", true, false, "Swift", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sethlouey/128.jpg", 2 },
                    { "1a663fb2-1a63-4070-a001-ed559a8c4160", null, new DateTime(2018, 9, 11, 12, 19, 32, 5, DateTimeKind.Local), "Dustin", "Rosa.Stokes@gmail.com", null, "Jasper", true, false, "Hudson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/malykhinv/128.jpg", 1 },
                    { "9d3f18be-2903-40c5-954d-1b3718154f55", null, new DateTime(2018, 9, 11, 3, 41, 3, 985, DateTimeKind.Local), "Korbin", "Shaina44@hotmail.com", null, "Joanie", true, false, "Wuckert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dotgridline/128.jpg", 1 },
                    { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", null, new DateTime(2018, 9, 11, 6, 59, 56, 157, DateTimeKind.Local), "Omer", "Randall_Ondricka@yahoo.com", null, "Delfina", true, false, "Padberg", null, "https://s3.amazonaws.com/uifaces/faces/twitter/overra/128.jpg", 1 },
                    { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", null, new DateTime(2018, 9, 11, 4, 15, 45, 437, DateTimeKind.Local), "Matilde", "Meagan_Paucek@gmail.com", null, "Lionel", true, false, "Hegmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/increase/128.jpg", 1 },
                    { "94719eb2-7b6a-4420-8a6f-264380d3263f", null, new DateTime(2018, 9, 12, 2, 0, 30, 662, DateTimeKind.Local), "Richard", "Kelly.Keebler@yahoo.com", null, "Marietta", true, false, "Hills", null, "https://s3.amazonaws.com/uifaces/faces/twitter/weavermedia/128.jpg", 2 },
                    { "9603312a-f694-4178-9405-0edf297ba8b3", null, new DateTime(2018, 9, 11, 14, 11, 14, 606, DateTimeKind.Local), "Lee", "Daphnee_Beatty43@yahoo.com", null, "Billy", true, false, "Considine", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nepdud/128.jpg", 1 },
                    { "76acb978-b2aa-4340-84d0-02494e5175e4", null, new DateTime(2018, 9, 11, 6, 54, 37, 994, DateTimeKind.Local), "Blaise", "Bruce_Kozey73@yahoo.com", null, "Fernando", true, false, "Feeney", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mtolokonnikov/128.jpg", 2 },
                    { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", null, new DateTime(2018, 9, 11, 5, 37, 49, 807, DateTimeKind.Local), "Davonte", "Clint_Adams@gmail.com", null, "Guiseppe", true, false, "Sawayn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/soffes/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9603312a-f694-4178-9405-0edf297ba8b3", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "76acb978-b2aa-4340-84d0-02494e5175e4", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", "unde" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2819394b-d044-4be1-960d-a60e12a21f7a", "quasi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94719eb2-7b6a-4420-8a6f-264380d3263f", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "sint" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9d3f18be-2903-40c5-954d-1b3718154f55", "maiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "officiis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 50, 7, 285, DateTimeKind.Local), "Dolorem itaque dolorum quis facere occaecati architecto.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 51, 43, 295, DateTimeKind.Local), "Labore veniam minus dolor voluptate iusto consectetur eveniet ab culpa.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 1, 33, 971, DateTimeKind.Local), "Saepe et repellat ratione incidunt.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 29, 12, 877, DateTimeKind.Local), "Eos deleniti velit quisquam facilis et nihil.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 30, 9, 759, DateTimeKind.Local), "Praesentium eligendi officia debitis accusamus vitae laudantium quam tempora.", "1a663fb2-1a63-4070-a001-ed559a8c4160" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 38, 36, 837, DateTimeKind.Local), "Ut veniam maiores dolorum qui.", "9603312a-f694-4178-9405-0edf297ba8b3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 8, 29, 507, DateTimeKind.Local), "Nulla possimus eum iure aspernatur.", "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 53, 12, 348, DateTimeKind.Local), "Omnis consequatur corrupti sequi adipisci quibusdam.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 41, 19, 290, DateTimeKind.Local), "Perferendis illo sint soluta consequatur sed fugiat aliquam.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 34, 13, 425, DateTimeKind.Local), "Id accusantium ut quaerat.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 11, 27, 31, 574, DateTimeKind.Local), "Repellat et voluptates non quisquam corporis.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 2, 32, 326, DateTimeKind.Local), "Perferendis voluptas autem et quo et blanditiis ex pariatur consequatur.", "76acb978-b2aa-4340-84d0-02494e5175e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 4, 40, 4, 955, DateTimeKind.Local), "Laudantium nemo voluptates voluptatem error repellendus blanditiis aspernatur molestiae qui.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 7, 47, 23, 71, DateTimeKind.Local), "Et officiis est deserunt et.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 3, 12, 30, 743, DateTimeKind.Local), "Debitis sint veritatis soluta doloribus.", "76acb978-b2aa-4340-84d0-02494e5175e4", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 8, 21, 53, 116, DateTimeKind.Local), "Voluptatum impedit illum ut neque natus maxime commodi est.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 0, 45, 48, 533, DateTimeKind.Local), "Nemo dolores hic aliquid mollitia cumque est.", "94719eb2-7b6a-4420-8a6f-264380d3263f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 2, 7, 58, 12, DateTimeKind.Local), "Qui quam iusto non autem.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 0, 33, 22, 707, DateTimeKind.Local), "Inventore molestiae et nobis laudantium voluptate molestiae rerum qui.", "9d3f18be-2903-40c5-954d-1b3718154f55", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 22, 25, 11, 917, DateTimeKind.Local), "Voluptatibus laborum dolores fugit voluptatem vel facilis eum distinctio.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 2, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "9603312a-f694-4178-9405-0edf297ba8b3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 4, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 0, "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 29, 11, 981, DateTimeKind.Local), 17, "Cum aut illum illum adipisci tempore dolorem.", "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 20, 11, 539, DateTimeKind.Local), 13, "Assumenda voluptatem dolore eligendi.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 6, 37, 410, DateTimeKind.Local), 12, "Et expedita similique iusto.", "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 18, 52, 522, DateTimeKind.Local), 15, "Eveniet laudantium et cupiditate.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 39, 26, 183, DateTimeKind.Local), 17, "Quod voluptates sed voluptate unde sunt error esse.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 58, 46, 320, DateTimeKind.Local), 17, "Voluptatem voluptatem culpa quae aliquam blanditiis et.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 22, 45, 749, DateTimeKind.Local), 20, "Temporibus ab quas enim doloribus praesentium explicabo aut hic.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 4, 58, 400, DateTimeKind.Local), 18, "Autem debitis animi fugiat explicabo voluptatem aperiam perferendis consequatur.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 16, 10, 800, DateTimeKind.Local), 16, "Vero enim harum dolorem dolores iste beatae odit sit ea.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 37, 37, 590, DateTimeKind.Local), 20, "Enim necessitatibus porro quisquam nobis velit dolor aliquam vel at.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-937-869-4789", "76acb978-b2aa-4340-84d0-02494e5175e4", "Vel explicabo fuga nam corrupti corporis aut eaque velit. Qui dolorem aut eveniet sed sequi. Sed qui reprehenderit id veniam mollitia deserunt eveniet qui alias. Voluptatibus nesciunt enim doloribus.", "Jaquan38@yahoo.com", "Company776", "https://araceli.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "674-827-6351", "c9d3c359-9b33-48fd-95d0-502911a4d3bc", "Aperiam assumenda nam corporis natus inventore. Aspernatur deserunt earum.", "Felicia.Trantow@gmail.com", "Company652", 1, "http://berneice.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "286.436.6371", "9603312a-f694-4178-9405-0edf297ba8b3", "Culpa tempora modi. Doloribus et atque fuga natus est corrupti aliquam. Velit nisi enim eum fuga. Atque distinctio autem dolorum doloremque.", "Elton55@yahoo.com", "Company156", "http://adrian.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "515-678-3754 x13391", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "Qui quia est consectetur voluptatibus harum. Ipsa eligendi repellat laboriosam consequatur reiciendis. Amet quaerat iusto aut veritatis magnam.", "Kelley27@hotmail.com", "Company673", 2, "https://adella.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "984.564.9740", "76acb978-b2aa-4340-84d0-02494e5175e4", "Velit animi aperiam. Illo tenetur voluptatem ab occaecati odio ut libero nisi earum. Eligendi necessitatibus repudiandae sequi iusto aut sit explicabo earum. Repellendus autem unde magni ut totam.", "Candelario.Wehner@gmail.com", "Company538", "https://kendall.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "916-352-8594 x935", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "", "Stewart58@yahoo.com", "Company248", "https://christina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "889.616.0260", "c9d3c359-9b33-48fd-95d0-502911a4d3bc", "Porro saepe a ullam suscipit odio ab vel et consequatur. Et voluptatem at rem modi dolorem. Mollitia quia ducimus. Id sit molestias asperiores numquam at.", "Wilfrid_Wiza9@hotmail.com", "Company158", "http://dorris.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "901-586-3180", "2a6ff317-062f-4fa9-982a-b5e85d35db4f", "Fuga dignissimos ut sequi fuga temporibus laboriosam. Adipisci omnis in velit. Ut ut deserunt reprehenderit dolores.", "Aletha72@yahoo.com", "Company612", 1, "https://nina.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "459-959-9184", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "Eius accusamus eum. Quis nihil id temporibus quia officia suscipit similique non.", "Ada68@yahoo.com", "Company930", "http://shayne.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "743-668-4021 x8439", "76acb978-b2aa-4340-84d0-02494e5175e4", "", "Abdiel_Hayes@gmail.com", "Company444", 2, "http://cloyd.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 37, 52, 782, DateTimeKind.Local), 46, "Cumque enim velit dolor et omnis consequatur distinctio esse numquam.", "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 5, 20, 272, DateTimeKind.Local), 42, "Quas necessitatibus quo reprehenderit quo est aperiam.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 34, 11, 789, DateTimeKind.Local), 42, "Libero consectetur quisquam id.", "1a663fb2-1a63-4070-a001-ed559a8c4160" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 49, 2, 933, DateTimeKind.Local), 47, "Eos quasi quia provident ut doloribus sequi cum.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 7, 44, 730, DateTimeKind.Local), "Dolor culpa et ut.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 46, 39, 186, DateTimeKind.Local), "Temporibus ut deleniti omnis.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 40, 23, 316, DateTimeKind.Local), 44, "Quis molestiae molestias doloribus tenetur commodi est.", "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 33, 58, 832, DateTimeKind.Local), 41, "Ea soluta perferendis rerum aspernatur recusandae.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 16, 40, 723, DateTimeKind.Local), 45, "Corrupti animi quisquam ea consequatur molestiae a.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 0, 5, 817, DateTimeKind.Local), 50, "Deserunt officia iure modi laborum et amet quam.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "9d3f18be-2903-40c5-954d-1b3718154f55", 65, 1 },
                    { "76acb978-b2aa-4340-84d0-02494e5175e4", 68, 1 },
                    { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", 66, 1 },
                    { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", 66, 1 },
                    { "9603312a-f694-4178-9405-0edf297ba8b3", 66, 1 },
                    { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", 65, 1 },
                    { "2819394b-d044-4be1-960d-a60e12a21f7a", 68, 1 },
                    { "1a663fb2-1a63-4070-a001-ed559a8c4160", 64, 1 },
                    { "94719eb2-7b6a-4420-8a6f-264380d3263f", 61, 1 },
                    { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", 65, 1 }
                });
        }
    }
}
