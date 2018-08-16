using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedToFeedbackFourColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "34a73032-25cd-4e18-8078-ec7e1280ddfe", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8af174fd-45ab-44b1-b756-61b08b4e54fb", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a4c77589-fde9-498b-a93d-dfdfed4b5168", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a5001d94-a4ad-40d8-a333-9dc16a882630", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34a73032-25cd-4e18-8078-ec7e1280ddfe");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d092db0-7b72-4313-af6b-f4fdf12c5f7d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5c8ec0eb-c030-497f-9977-ff1d7c9021e4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "68ed0dc9-00df-4e70-8fab-7a6b1d996b50");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8af174fd-45ab-44b1-b756-61b08b4e54fb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a4c77589-fde9-498b-a93d-dfdfed4b5168");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a5001d94-a4ad-40d8-a333-9dc16a882630");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e55cc846-c35c-4068-a96e-7e4d3a350a11");

            migrationBuilder.AddColumn<int>(
                name: "Friendliness",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Informatively",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quickness",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WillUse",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                column: "Threshold",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded1", "Source3", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source2", 37, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded2", "Common3", "Source2", 39 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "Source", "Threshold" },
                values: new object[] { "MostLoaded3", "Source2", 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "Common2", "Source1", 96, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 94, "MostLoaded3", "Common1", "Source3", 9 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", "Common3", 25, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common3", "Source2", 57, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", 12, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 51, 6, 162, DateTimeKind.Local), 89, "Title41" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 4, 16, 53, 458, DateTimeKind.Local), 90, "Title628" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 26, 10, 200, DateTimeKind.Local), 87, "Title536" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 7, 46, 989, DateTimeKind.Local), 90, "Title159" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 36, 34, 744, DateTimeKind.Local), 87, "Title654" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 44, 14, 286, DateTimeKind.Local), 90, "Title155" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 21, 3, 58, 485, DateTimeKind.Local), 84, "Title246" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 9, 34, 11, 714, DateTimeKind.Local), 83, "Title726" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 8, 46, 578, DateTimeKind.Local), 85, "Title778" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 12, 28, 341, DateTimeKind.Local), 90, "Title660" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "13:82:c0:3b:9c:ba", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "85:00:7b:d6:57:85", 73 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "c7:e9:8c:f0:a2:85", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f8:7c:0b:f3:40:1e", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "92:81:6d:75:d2:2a", 71, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "d6:a3:44:c0:fe:ee", 78 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "15:9f:a0:3a:ad:09", 75 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "c4:a9:42:1f:af:2e", 79 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                column: "Address",
                value: "0e:d6:43:d6:18:d6");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e7:f3:1a:ff:41:fd", 71 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme392" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme299" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme342" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme811" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme695" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme642" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme763" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme834" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme901" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme699" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "a436d9c3-ce62-4a1e-8293-5b17534d8398", null, new DateTime(2018, 8, 14, 17, 46, 28, 389, DateTimeKind.Local), "Jewell", "Freeman_Dickinson71@yahoo.com", "Van", true, "Steuber", null, 1 },
                    { "7a3d1395-bd4d-492c-ba90-76c148d7f559", null, new DateTime(2018, 8, 14, 12, 47, 38, 792, DateTimeKind.Local), "Steve", "Bernita.Kerluke@yahoo.com", "Joy", true, "Mraz", null, 2 },
                    { "310558b5-97d8-4ad0-a0c0-cc597712123b", null, new DateTime(2018, 8, 14, 1, 40, 40, 822, DateTimeKind.Local), "Markus", "Santa_Conn@yahoo.com", "Jamie", true, "Cremin", null, 1 },
                    { "76417ced-9632-4ebd-808d-717e70a270d2", null, new DateTime(2018, 8, 13, 23, 28, 9, 101, DateTimeKind.Local), "Jamil", "Melyssa27@gmail.com", "Chris", true, "Hintz", null, 2 },
                    { "b8493acc-5078-4e21-a205-74dc72d89ff8", null, new DateTime(2018, 8, 14, 2, 2, 13, 262, DateTimeKind.Local), "Milford", "Opal.Schuppe@hotmail.com", "Mohammed", true, "Goldner", null, 1 },
                    { "df57d25e-b21d-490a-8024-d1a04e56934b", null, new DateTime(2018, 8, 14, 20, 6, 54, 675, DateTimeKind.Local), "Mike", "Jazmyn.Prohaska50@hotmail.com", "Emery", true, "Marks", null, 1 },
                    { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", null, new DateTime(2018, 8, 14, 16, 23, 3, 98, DateTimeKind.Local), "Allie", "Caleb_Crist7@hotmail.com", "Lonzo", true, "Toy", null, 1 },
                    { "70f945d0-f3c7-4587-9676-fc089b4451ce", null, new DateTime(2018, 8, 14, 11, 3, 11, 128, DateTimeKind.Local), "Adriel", "Hortense.Tremblay61@gmail.com", "Garland", true, "Rodriguez", null, 1 },
                    { "683266fc-140c-4a5e-ac01-7ff8304a848b", null, new DateTime(2018, 8, 14, 16, 55, 21, 957, DateTimeKind.Local), "Leonor", "Misael22@yahoo.com", "Fern", true, "Schimmel", null, 2 },
                    { "14052a15-abbd-4257-8aa3-14b803de5241", null, new DateTime(2018, 8, 14, 4, 58, 17, 829, DateTimeKind.Local), "Augustine", "Mariana_Schimmel@yahoo.com", "Ryley", true, "Halvorson", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7a3d1395-bd4d-492c-ba90-76c148d7f559", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedById",
                value: "b8493acc-5078-4e21-a205-74dc72d89ff8");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "labore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "df57d25e-b21d-490a-8024-d1a04e56934b", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", "excepturi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a436d9c3-ce62-4a1e-8293-5b17534d8398", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "14052a15-abbd-4257-8aa3-14b803de5241", "molestias" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", "dolor" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 19, 45, 731, DateTimeKind.Local), "Rerum mollitia natus a labore natus eum et aut.", "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 21, 10, 657, DateTimeKind.Local), "Impedit est aut et ut natus quia est cupiditate.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 56, 49, 147, DateTimeKind.Local), "Placeat qui rerum quia assumenda quisquam nihil exercitationem eum.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 38, 44, 270, DateTimeKind.Local), "Omnis tenetur dolorum odit aut assumenda aspernatur qui doloremque.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 15, 41, 535, DateTimeKind.Local), "Fuga soluta ratione officia consequuntur voluptatem ullam.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 14, 2, 878, DateTimeKind.Local), "Quia repellendus cum impedit exercitationem vel distinctio numquam.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 2, 14, 31, 507, DateTimeKind.Local), "Sequi quo ipsam earum numquam.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 51, 38, 940, DateTimeKind.Local), "Eum dolor ullam nesciunt ut dolores dicta in quo ipsum.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 4, 11, 3, 7, DateTimeKind.Local), "Modi doloremque maxime quo et ut rem.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 25, 29, 126, DateTimeKind.Local), "Voluptatibus vel ad totam nulla eum est voluptates aliquid.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 14, 16, 19, 1, 249, DateTimeKind.Local), "Ut aut odio ut maiores omnis.", "14052a15-abbd-4257-8aa3-14b803de5241", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 14, 16, 19, 39, 394, DateTimeKind.Local), "Aut voluptas est ut voluptatem.", "683266fc-140c-4a5e-ac01-7ff8304a848b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 14, 5, 4, 22, 834, DateTimeKind.Local), "Qui qui amet vel incidunt.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 14, 13, 27, 35, 716, DateTimeKind.Local), "Autem qui ut dignissimos sit autem blanditiis.", "310558b5-97d8-4ad0-a0c0-cc597712123b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 14, 4, 48, 8, 815, DateTimeKind.Local), "Similique odio quas sit magni incidunt sint.", "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 14, 19, 40, 44, 178, DateTimeKind.Local), "Labore distinctio aliquam nesciunt.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 6, 8, 6, 130, DateTimeKind.Local), "Quam asperiores in ea.", "a436d9c3-ce62-4a1e-8293-5b17534d8398", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 20, 13, 36, 924, DateTimeKind.Local), "Qui omnis quasi eos sunt maxime.", "b8493acc-5078-4e21-a205-74dc72d89ff8", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 14, 5, 18, 56, 113, DateTimeKind.Local), "Voluptates vero libero aut fugiat.", "310558b5-97d8-4ad0-a0c0-cc597712123b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 14, 17, 50, 25, 128, DateTimeKind.Local), "Quaerat quidem ullam.", "14052a15-abbd-4257-8aa3-14b803de5241", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "df57d25e-b21d-490a-8024-d1a04e56934b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 1, "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 44, 16, 752, DateTimeKind.Local), 15, "Aut voluptatem unde est.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 14, 51, 50, 898, DateTimeKind.Local), 15, "Expedita iusto quidem iure occaecati assumenda ipsum beatae perspiciatis sed.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 52, 4, 886, DateTimeKind.Local), 20, "Voluptas vel eligendi rerum dicta cupiditate in facilis vel qui.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 27, 41, 864, DateTimeKind.Local), 15, "Omnis et quis dolores deleniti.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 5, 16, 182, DateTimeKind.Local), 11, "Dolor dolor quidem.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 17, 52, 10, 274, DateTimeKind.Local), 18, "Doloremque reiciendis consequatur.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 20, 34, 134, DateTimeKind.Local), 17, "Rem nam et.", "a436d9c3-ce62-4a1e-8293-5b17534d8398" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 6, 15, 537, DateTimeKind.Local), 15, "Quia expedita repellendus aut voluptatem fuga maxime omnis amet.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 10, 27, 565, DateTimeKind.Local), 12, "Sint praesentium qui quaerat cupiditate iste aut autem dicta.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 38, 8, 302, DateTimeKind.Local), 20, "Quo ut eum.", "14052a15-abbd-4257-8aa3-14b803de5241" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-430-508-8606 x675", "863baf8a-b306-4a9f-84f0-5df0a3e7b480", "Dolorum nulla eius quia temporibus vero est. Rerum culpa magni dolores asperiores esse aliquam modi aut et. Neque molestiae voluptas vitae. Aut vitae minima repudiandae enim sunt voluptatibus iure consequatur dolore.", "Spencer.Quitzon22@hotmail.com", "Company998", 64, "https://alene.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "348-833-7077 x33756", "863baf8a-b306-4a9f-84f0-5df0a3e7b480", "Animi quod quia placeat omnis accusamus nihil eveniet ab. Deleniti itaque et error tenetur quae quaerat. Quia nulla nostrum.", "Mariah.Parker@yahoo.com", "Company517", 61, "https://tyson.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "940.349.7927 x213", "76417ced-9632-4ebd-808d-717e70a270d2", "", "Lillian_Dooley@hotmail.com", "Company72", 63, "http://yasmin.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-444-418-6761 x620", "76417ced-9632-4ebd-808d-717e70a270d2", "Ad illum asperiores excepturi nihil fugiat.", "Robbie_Mann25@yahoo.com", "Company447", 63, "https://terrance.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(637) 904-5662", "a436d9c3-ce62-4a1e-8293-5b17534d8398", "Placeat quia quos reprehenderit iusto. Ea dolorem tempore reiciendis qui voluptas architecto. Saepe expedita numquam molestiae. Odit non fugiat autem unde ut ab ut.", "Winston.Zieme@hotmail.com", "Company580", 69, "http://josiah.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(256) 875-6858 x42578", "683266fc-140c-4a5e-ac01-7ff8304a848b", "Rerum quos eum harum ea rerum. Nemo dolor ratione accusantium molestiae dicta. Quasi cum fugiat asperiores. Magnam dolor consequatur consequatur ea explicabo voluptatum maiores.", "Matilda80@hotmail.com", "Company217", 65, "https://bud.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(253) 469-4735 x77162", "7a3d1395-bd4d-492c-ba90-76c148d7f559", "", "Eloise_Kautzer@gmail.com", "Company405", 61, "http://dayna.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "427-618-2961 x924", "14052a15-abbd-4257-8aa3-14b803de5241", "Consequuntur ab facilis modi nihil non laboriosam cumque. Itaque deleniti odio repellendus voluptatem at voluptas eum ratione. Labore dolores perspiciatis autem provident suscipit aut qui suscipit iure. Quo nesciunt reiciendis explicabo odit voluptas reiciendis iusto ipsum necessitatibus.", "Lucius.Stroman81@hotmail.com", "Company538", 69, "https://maeve.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "661-685-3039 x2346", "a436d9c3-ce62-4a1e-8293-5b17534d8398", "", "Hilda_Koss82@yahoo.com", "Company369", 64, "http://barney.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-576-653-5508", "310558b5-97d8-4ad0-a0c0-cc597712123b", "Quas ut sunt in dolorum sit delectus omnis. Facere voluptatum assumenda consequuntur perspiciatis vel exercitationem voluptate qui.", "Dion53@gmail.com", "Company390", 70, "https://syble.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 20, 38, 452, DateTimeKind.Local), 49, "Delectus et fuga voluptas.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 37, 59, 716, DateTimeKind.Local), 43, "Ipsa ut unde quidem non aut similique odit repellendus.", "310558b5-97d8-4ad0-a0c0-cc597712123b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 3, 28, 38, 909, DateTimeKind.Local), "Delectus voluptatem ut architecto accusantium et.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 6, 2, 517, DateTimeKind.Local), 48, "Iure qui reiciendis et quo non aut illo voluptatem repudiandae.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 26, 35, 500, DateTimeKind.Local), 43, "Rerum sed eaque quaerat perspiciatis.", "683266fc-140c-4a5e-ac01-7ff8304a848b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 6, 11, 14, 132, DateTimeKind.Local), "Repellendus repellat officia minima aliquam sit delectus illo.", "70f945d0-f3c7-4587-9676-fc089b4451ce" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 58, 55, 398, DateTimeKind.Local), 45, "Et tenetur quod minus.", "863baf8a-b306-4a9f-84f0-5df0a3e7b480" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 45, 39, 740, DateTimeKind.Local), 45, "Enim commodi amet.", "a436d9c3-ce62-4a1e-8293-5b17534d8398" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 53, 59, 149, DateTimeKind.Local), 41, "Sed corrupti est eos inventore magni.", "7a3d1395-bd4d-492c-ba90-76c148d7f559" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 48, 22, 23, DateTimeKind.Local), 50, "Recusandae pariatur accusamus exercitationem.", "b8493acc-5078-4e21-a205-74dc72d89ff8" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "df57d25e-b21d-490a-8024-d1a04e56934b", 74 },
                    { "70f945d0-f3c7-4587-9676-fc089b4451ce", 75 },
                    { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", 75 },
                    { "b8493acc-5078-4e21-a205-74dc72d89ff8", 78 },
                    { "76417ced-9632-4ebd-808d-717e70a270d2", 75 },
                    { "310558b5-97d8-4ad0-a0c0-cc597712123b", 78 },
                    { "7a3d1395-bd4d-492c-ba90-76c148d7f559", 72 },
                    { "a436d9c3-ce62-4a1e-8293-5b17534d8398", 78 },
                    { "683266fc-140c-4a5e-ac01-7ff8304a848b", 73 },
                    { "14052a15-abbd-4257-8aa3-14b803de5241", 73 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14052a15-abbd-4257-8aa3-14b803de5241", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "310558b5-97d8-4ad0-a0c0-cc597712123b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "683266fc-140c-4a5e-ac01-7ff8304a848b", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "70f945d0-f3c7-4587-9676-fc089b4451ce", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76417ced-9632-4ebd-808d-717e70a270d2", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7a3d1395-bd4d-492c-ba90-76c148d7f559", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "863baf8a-b306-4a9f-84f0-5df0a3e7b480", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a436d9c3-ce62-4a1e-8293-5b17534d8398", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b8493acc-5078-4e21-a205-74dc72d89ff8", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "df57d25e-b21d-490a-8024-d1a04e56934b", 74 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14052a15-abbd-4257-8aa3-14b803de5241");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "310558b5-97d8-4ad0-a0c0-cc597712123b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "683266fc-140c-4a5e-ac01-7ff8304a848b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "70f945d0-f3c7-4587-9676-fc089b4451ce");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76417ced-9632-4ebd-808d-717e70a270d2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7a3d1395-bd4d-492c-ba90-76c148d7f559");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "863baf8a-b306-4a9f-84f0-5df0a3e7b480");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a436d9c3-ce62-4a1e-8293-5b17534d8398");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b8493acc-5078-4e21-a205-74dc72d89ff8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "df57d25e-b21d-490a-8024-d1a04e56934b");

            migrationBuilder.DropColumn(
                name: "Friendliness",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Informatively",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Quickness",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "WillUse",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                column: "Threshold",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Source2", 62, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common3", "Source1", 71, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 98, "MostLoaded3", "Common1", "Source3", 78 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MostLoaded", "Source", "Threshold" },
                values: new object[] { "MostLoaded2", "Source3", 4 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "Common1", "Source3", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded2", "Common3", "Source1", 47 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common2", "Source3", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", 92, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 9, 55, 136, DateTimeKind.Local), 86, "Title618" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 5, 13, 24, 452, DateTimeKind.Local), 81, "Title677" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 5, 5, 7, 641, DateTimeKind.Local), 83, "Title680" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 10, 2, 112, DateTimeKind.Local), 88, "Title379" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 19, 11, 53, 470, DateTimeKind.Local), 83, "Title164" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 6, 52, 28, 184, DateTimeKind.Local), 87, "Title893" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 4, 40, 0, 279, DateTimeKind.Local), 86, "Title569" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 24, 41, 513, DateTimeKind.Local), 88, "Title713" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 11, 45, 28, 157, DateTimeKind.Local), 81, "Title834" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 12, 3, 3, 59, 386, DateTimeKind.Local), 82, "Title856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e6:f1:d2:92:f4:39", 80, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "69:aa:13:38:70:91", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "0b:40:1d:fb:4e:1b", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e8:32:37:65:ff:0d", 79 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "d7:36:1c:12:03:7d", 73, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "b7:d9:17:14:e4:4a", 75 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e5:51:e3:82:13:28", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "d9:a2:a9:c2:01:8d", 71 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                column: "Address",
                value: "d7:ff:61:39:75:53");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "f8:5c:43:74:04:03", 73 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme75" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme260" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme832" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme47" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme779" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme603" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme765" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme115" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme313" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme882" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "8af174fd-45ab-44b1-b756-61b08b4e54fb", null, new DateTime(2018, 8, 11, 19, 37, 22, 517, DateTimeKind.Local), "Leif", "Marlin10@gmail.com", "Jedidiah", true, "Cronin", null, 2 },
                    { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", null, new DateTime(2018, 8, 12, 6, 23, 16, 223, DateTimeKind.Local), "Fabian", "Roel_Quitzon@hotmail.com", "Barbara", true, "Hilll", null, 1 },
                    { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", null, new DateTime(2018, 8, 12, 10, 53, 37, 128, DateTimeKind.Local), "Rachel", "Hester56@yahoo.com", "Kamron", true, "Kuphal", null, 1 },
                    { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", null, new DateTime(2018, 8, 12, 3, 40, 7, 898, DateTimeKind.Local), "Leonard", "Kattie_Lockman3@yahoo.com", "Marcelina", true, "Wisoky", null, 2 },
                    { "a5001d94-a4ad-40d8-a333-9dc16a882630", null, new DateTime(2018, 8, 12, 9, 42, 42, 479, DateTimeKind.Local), "Marilie", "Clint_MacGyver@hotmail.com", "Nona", true, "Tromp", null, 2 },
                    { "e55cc846-c35c-4068-a96e-7e4d3a350a11", null, new DateTime(2018, 8, 11, 19, 38, 45, 259, DateTimeKind.Local), "Lennie", "Yadira71@yahoo.com", "Precious", true, "Johnston", null, 2 },
                    { "34a73032-25cd-4e18-8078-ec7e1280ddfe", null, new DateTime(2018, 8, 11, 13, 32, 7, 795, DateTimeKind.Local), "Laurie", "Brennon.Rosenbaum29@gmail.com", "June", true, "Bailey", null, 1 },
                    { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", null, new DateTime(2018, 8, 11, 22, 11, 40, 183, DateTimeKind.Local), "Graciela", "Layne.Cassin40@hotmail.com", "Pink", true, "Torphy", null, 2 },
                    { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", null, new DateTime(2018, 8, 11, 20, 28, 11, 579, DateTimeKind.Local), "Sandrine", "Abby.Conroy@yahoo.com", "Valentine", true, "Kertzmann", null, 2 },
                    { "a4c77589-fde9-498b-a93d-dfdfed4b5168", null, new DateTime(2018, 8, 12, 8, 13, 53, 547, DateTimeKind.Local), "Forest", "Ellen.Kub84@hotmail.com", "Emilia", true, "Kunde", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "34a73032-25cd-4e18-8078-ec7e1280ddfe", "explicabo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedById",
                value: "e55cc846-c35c-4068-a96e-7e4d3a350a11");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", "sint" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8af174fd-45ab-44b1-b756-61b08b4e54fb", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "optio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "vero" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "veniam" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 7, 58, 10, 468, DateTimeKind.Local), "Sapiente vel odio placeat consequuntur.", "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 39, 20, 506, DateTimeKind.Local), "Temporibus repudiandae similique commodi autem et accusantium omnis perferendis at.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 18, 53, 50, 916, DateTimeKind.Local), "Nulla est dolores.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 19, 13, 56, 153, DateTimeKind.Local), "Aut aut enim neque at.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 11, 46, 195, DateTimeKind.Local), "Aut vel illo reprehenderit soluta nam.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 4, 50, 52, 751, DateTimeKind.Local), "Autem ipsa placeat.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 36, 54, 704, DateTimeKind.Local), "Deserunt quia provident doloribus tempora sed.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 15, 53, 25, 613, DateTimeKind.Local), "Perspiciatis eveniet quibusdam.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 0, 48, 226, DateTimeKind.Local), "Porro harum et dolore modi vel sapiente laudantium sed.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 6, 1, 780, DateTimeKind.Local), "Tempore cumque cumque fugiat aut dicta.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 12, 1, 30, 58, 839, DateTimeKind.Local), "In delectus eos quas consequuntur rerum.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 11, 14, 40, 38, 676, DateTimeKind.Local), "Voluptatem atque rerum aut ullam voluptates.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 11, 18, 26, 48, 569, DateTimeKind.Local), "Dolorum est dicta eum ab est ad ea corporis.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 11, 14, 16, 36, 4, DateTimeKind.Local), "Consequuntur consequatur ut molestiae possimus ab delectus temporibus.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 3, 58, 44, 421, DateTimeKind.Local), "Odio hic ut commodi quia fugit nihil.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 11, 18, 25, 39, 229, DateTimeKind.Local), "Quasi adipisci illum vitae repellat iure temporibus molestiae qui quia.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 12, 10, 16, 39, 17, DateTimeKind.Local), "Ut eum corrupti voluptatem veniam.", "a5001d94-a4ad-40d8-a333-9dc16a882630", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 12, 9, 8, 1, 935, DateTimeKind.Local), "Sit facilis culpa illum consequatur omnis officia dolores aperiam est.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 17, 6, 10, 925, DateTimeKind.Local), "Enim sint consectetur ut quae culpa consequatur.", "e55cc846-c35c-4068-a96e-7e4d3a350a11", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 12, 12, 8, 7, 721, DateTimeKind.Local), "Ut blanditiis amet delectus ea voluptate quia voluptatibus maxime non.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 3, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 39, 22, 177, DateTimeKind.Local), 17, "Molestiae recusandae hic est maiores quia placeat quasi.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 20, 24, 20, 521, DateTimeKind.Local), 20, "Totam quia quia.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 42, 13, 203, DateTimeKind.Local), 12, "Inventore sit aut blanditiis earum sunt asperiores dolorem.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 19, 16, 907, DateTimeKind.Local), 19, "Laboriosam aut placeat sunt nobis.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 23, 5, 77, DateTimeKind.Local), 19, "Quod maiores molestiae fugiat sint dolore et doloribus nesciunt quasi.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 56, 0, 770, DateTimeKind.Local), 14, "Eum ipsam deleniti consequatur voluptatem asperiores nesciunt.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 12, 40, 53, DateTimeKind.Local), 19, "Nostrum amet porro harum.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 21, 54, 36, 685, DateTimeKind.Local), 14, "Qui voluptatem ut soluta.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 10, 42, 791, DateTimeKind.Local), 14, "Quia aut necessitatibus tempore ea.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 51, 13, 847, DateTimeKind.Local), 12, "Quia eos tempora qui voluptas.", "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "257-895-7084 x45551", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "Ea magnam sint eum dolorem aut est quidem voluptas reprehenderit. Reprehenderit consequatur quas et enim impedit veritatis dolores impedit. Est quis ratione aut exercitationem rerum praesentium.", "Lane_Schaden66@hotmail.com", "Company437", 61, "https://elwyn.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(218) 668-9637 x56037", "8af174fd-45ab-44b1-b756-61b08b4e54fb", "Hic officiis neque incidunt atque dolore velit qui ut. Ipsum quod velit est quia. Consequatur provident vitae aliquam corporis sed voluptate sapiente aut. Quis expedita veritatis alias reprehenderit et sit ullam eaque.", "Mitchell7@gmail.com", "Company190", 66, "https://tressa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(527) 866-4742", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "A perspiciatis beatae nisi necessitatibus iste natus eveniet. Inventore aliquam qui recusandae quisquam sit animi officiis.", "Thea60@yahoo.com", "Company668", 62, "https://tania.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "494.336.9723 x233", "a4c77589-fde9-498b-a93d-dfdfed4b5168", "Et repudiandae exercitationem. Officiis libero illo non necessitatibus maxime ullam rerum culpa. Similique alias quasi iure praesentium.", "Dejuan_Dicki98@gmail.com", "Company894", 69, "https://richard.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(670) 729-4927 x06074", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "Aliquid dolores alias saepe nihil velit saepe mollitia. Eveniet maiores deserunt neque maiores.", "Waylon88@hotmail.com", "Company970", 70, "https://kamryn.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(724) 861-1489 x84849", "a5001d94-a4ad-40d8-a333-9dc16a882630", "", "Keven.Kunde96@hotmail.com", "Company404", 64, "https://london.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "200-499-4659", "34a73032-25cd-4e18-8078-ec7e1280ddfe", "Earum aspernatur ea ducimus iusto id sit illum ab. Amet excepturi qui dolorem sint adipisci consequatur. Et alias qui vel temporibus harum autem blanditiis fugiat sed. In non ea sequi recusandae repellendus.", "Myra.Padberg@hotmail.com", "Company119", 63, "https://cleora.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "451-892-5376", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", "Atque commodi est id repellendus ex sint eum minima et. Sint nobis eum temporibus ea quis blanditiis incidunt necessitatibus. Excepturi sit perspiciatis. Ut consectetur quisquam modi voluptas quas.", "Chanel_Schiller17@gmail.com", "Company976", 61, "https://kennith.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-241-641-0340", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "Dolor odit velit sint dolorem autem nesciunt tenetur quam excepturi. Rem eos ea beatae iure inventore accusantium voluptas iste. Fugiat cupiditate autem illum inventore corporis veritatis corporis amet. Asperiores enim porro magnam eius cumque aut eaque aliquam quis.", "Erich.Tromp@yahoo.com", "Company213", 70, "http://isadore.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-354-461-4062", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "Nesciunt nihil odit vero est dolor maiores qui ut. Et perferendis perferendis quo veritatis labore voluptatibus libero non et. Ut excepturi voluptates quidem nostrum sit recusandae omnis.", "Zane63@hotmail.com", "Company511", 62, "http://graciela.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 22, 5, 17, 774, DateTimeKind.Local), 43, "Voluptatem quod vitae quis quo et quae nulla repellendus accusamus.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 0, 49, 33, 572, DateTimeKind.Local), 47, "Velit nobis vitae.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 40, 8, 374, DateTimeKind.Local), "Sit suscipit tempore libero esse et corporis quo.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 2, 45, 39, 871, DateTimeKind.Local), 50, "Voluptas qui saepe voluptatibus sapiente molestias hic repudiandae dolorum.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 10, 46, 50, 964, DateTimeKind.Local), 50, "Vel fuga nostrum voluptatem necessitatibus officia qui.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 5, 29, 108, DateTimeKind.Local), "Velit dolorum ullam amet maxime dolores.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 9, 51, 41, 37, DateTimeKind.Local), 42, "Provident soluta occaecati cumque.", "a4c77589-fde9-498b-a93d-dfdfed4b5168" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 23, 17, 38, 135, DateTimeKind.Local), 42, "Sunt repudiandae unde est eos eaque dolorum perferendis.", "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 8, 43, 8, 166, DateTimeKind.Local), 46, "Soluta atque voluptate corrupti similique nisi non omnis.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 37, 19, 431, DateTimeKind.Local), 42, "Unde quis nulla rerum assumenda ducimus assumenda mollitia.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e55cc846-c35c-4068-a96e-7e4d3a350a11", 76 },
                    { "a5001d94-a4ad-40d8-a333-9dc16a882630", 74 },
                    { "5c8ec0eb-c030-497f-9977-ff1d7c9021e4", 79 },
                    { "34a73032-25cd-4e18-8078-ec7e1280ddfe", 75 },
                    { "8af174fd-45ab-44b1-b756-61b08b4e54fb", 76 },
                    { "68ed0dc9-00df-4e70-8fab-7a6b1d996b50", 71 },
                    { "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", 77 },
                    { "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", 76 },
                    { "af0420ec-2cd3-45f7-92fe-a5ecbf960fd1", 77 },
                    { "a4c77589-fde9-498b-a93d-dfdfed4b5168", 72 }
                });
        }
    }
}
