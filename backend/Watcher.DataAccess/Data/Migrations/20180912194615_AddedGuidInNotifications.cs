using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedGuidInNotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "InstanceGuidId",
                table: "Notifications",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 36, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 42, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 55, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 88, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 90, 50 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 52, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 81, 52 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 34, 2, 582, DateTimeKind.Local), 79, "Title12" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 8, 15, 837, DateTimeKind.Local), 75, "Title152" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 10, 51, 655, DateTimeKind.Local), "Title228" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 19, 24, 710, DateTimeKind.Local), 79, "Title530" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 22, 7, 15, 746, DateTimeKind.Local), 78, "Title932" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 41, 14, 50, DateTimeKind.Local), 72, "Title391" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 6, 51, 911, DateTimeKind.Local), 76, "Title634" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 1, 43, 921, DateTimeKind.Local), 77, "Title541" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 48, 40, 992, DateTimeKind.Local), 76, "Title657" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 22, 29, 43, 414, DateTimeKind.Local), 71, "Title52" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "28:af:d8:73:a1:8d", 66, "Windows", "Instance528" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d9:8d:eb:c0:1c:e2", 67, "Instance487" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "Title" },
                values: new object[] { "8a:5a:d4:d0:c1:ef", "Instance891" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d2:6f:73:4c:7e:36", 62, "Windows", "Instance408" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "29:c8:77:e7:96:fd", "Linux", "Instance493" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "43:b6:21:fc:4a:ce", 69, "Instance425" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "20:70:9e:74:92:69", 62, "Instance695" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b2:08:ff:30:61:c2", 69, "Instance256" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2a:19:b1:39:c5:1b", 64, "Linux", "Instance227" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5a:27:e9:cc:93:b8", 62, "Instance11" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", null, new DateTime(2018, 9, 12, 9, 19, 0, 813, DateTimeKind.Local), "Tessie", "Malinda_Grady@gmail.com", null, "Phoebe", true, false, "O'Connell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/terryxlife/128.jpg", 2 },
                    { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", null, new DateTime(2018, 9, 12, 18, 18, 8, 358, DateTimeKind.Local), "Adolphus", "Arden_Cormier37@hotmail.com", null, "Doris", true, false, "Will", null, "https://s3.amazonaws.com/uifaces/faces/twitter/terpimost/128.jpg", 1 },
                    { "cfdc2394-bcac-467f-9bd1-b099c449549a", null, new DateTime(2018, 9, 12, 6, 44, 34, 502, DateTimeKind.Local), "Federico", "Garrett_Franecki@hotmail.com", null, "Gerhard", true, false, "Keebler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/picard102/128.jpg", 2 },
                    { "6eaef575-0500-4c20-b59b-03f452842bdf", null, new DateTime(2018, 9, 12, 5, 47, 33, 413, DateTimeKind.Local), "Jensen", "Vida_Skiles@hotmail.com", null, "Lamar", true, false, "Hilpert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/elisabethkjaer/128.jpg", 2 },
                    { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", null, new DateTime(2018, 9, 12, 8, 25, 32, 805, DateTimeKind.Local), "Merritt", "Colleen86@hotmail.com", null, "Madonna", true, false, "Ortiz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/polarity/128.jpg", 2 },
                    { "cca3fb1b-6b17-4629-bb52-b06163ed3252", null, new DateTime(2018, 9, 12, 8, 13, 10, 827, DateTimeKind.Local), "Raleigh", "Joanne_Becker78@gmail.com", null, "Estrella", true, false, "Lesch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/8d3k/128.jpg", 1 },
                    { "c7cb6c73-9895-498f-a06b-33597f76d4c5", null, new DateTime(2018, 9, 12, 3, 54, 14, 502, DateTimeKind.Local), "Krystina", "Rosalinda_Schaefer38@gmail.com", null, "Heloise", true, false, "Larkin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/themrdave/128.jpg", 2 },
                    { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", null, new DateTime(2018, 9, 11, 23, 16, 59, 455, DateTimeKind.Local), "Jed", "Merl29@gmail.com", null, "Marina", true, false, "Bergstrom", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BillSKenney/128.jpg", 1 },
                    { "64f2bf53-0184-44f6-b778-c46ebd040968", null, new DateTime(2018, 9, 12, 21, 32, 35, 621, DateTimeKind.Local), "Lurline", "Kathryne92@gmail.com", null, "Vernice", true, false, "Bahringer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_williamguerra/128.jpg", 1 },
                    { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", null, new DateTime(2018, 9, 12, 5, 16, 17, 701, DateTimeKind.Local), "Lexie", "Jadon_Block@yahoo.com", null, "Edythe", true, false, "Hilpert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/buzzusborne/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "ipsa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "maiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", "ipsum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 10, 11, 930, DateTimeKind.Local), "Ea deleniti sunt ab sequi dicta omnis animi libero.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 27, 54, 149, DateTimeKind.Local), "Autem impedit unde.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 20, 47, 457, DateTimeKind.Local), "Accusamus culpa natus.", "c7cb6c73-9895-498f-a06b-33597f76d4c5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 1, 41, 243, DateTimeKind.Local), "At optio et et id modi beatae saepe.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 23, 15, 754, DateTimeKind.Local), "Aliquid saepe quia.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 57, 39, 171, DateTimeKind.Local), "Ut quasi quos commodi aut.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 2, 4, 113, DateTimeKind.Local), "Rerum laudantium nisi dignissimos enim voluptatem nulla accusamus ex.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 26, 43, 287, DateTimeKind.Local), "Quo et dignissimos quia aut eum.", "c7cb6c73-9895-498f-a06b-33597f76d4c5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 54, 21, 959, DateTimeKind.Local), "Distinctio aut non dolores.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 19, 29, 359, DateTimeKind.Local), "Sed quis quae velit sequi veritatis.", "50593a1b-bc00-4fae-8ad9-7077d3fe19ee" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 30, 43, 314, DateTimeKind.Local), "Ut magnam et vitae ullam voluptatibus non.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 12, 9, 59, 0, 410, DateTimeKind.Local), "Culpa corporis velit quo ut enim nam optio.", "c7cb6c73-9895-498f-a06b-33597f76d4c5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 2, 9, 18, 727, DateTimeKind.Local), "Quis aut sed sequi est.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 15, 50, 881, DateTimeKind.Local), "Illum quia sapiente mollitia.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 14, 50, 30, 385, DateTimeKind.Local), "Sunt iste animi quia temporibus reiciendis ut odit est.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 56, 42, 72, DateTimeKind.Local), "Temporibus molestiae officiis sunt.", "cfdc2394-bcac-467f-9bd1-b099c449549a", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 12, 15, 34, 37, 300, DateTimeKind.Local), "Occaecati sequi vel sed nemo porro sit deserunt.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 12, 3, 4, 782, DateTimeKind.Local), "Est repellendus sit dolor qui totam non deserunt.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 1, 19, 21, 784, DateTimeKind.Local), "Libero praesentium perferendis hic.", "64f2bf53-0184-44f6-b778-c46ebd040968" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 13, 25, 50, 989, DateTimeKind.Local), "Ipsum voluptate odio.", "64f2bf53-0184-44f6-b778-c46ebd040968", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "50593a1b-bc00-4fae-8ad9-7077d3fe19ee" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 4, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 31, 10, 134, DateTimeKind.Local), 17, "Aut consequuntur amet qui.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 45, 18, 155, DateTimeKind.Local), 20, "Ut porro maiores et totam cupiditate amet quibusdam iusto.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 45, 44, 290, DateTimeKind.Local), 19, "Porro architecto id et facere unde reprehenderit.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 41, 52, 544, DateTimeKind.Local), 13, "Atque esse cumque at facere.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 21, 32, 53, 964, DateTimeKind.Local), 14, "Quia molestias et voluptas odio.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 34, 30, 371, DateTimeKind.Local), "Cumque consectetur nihil eos qui dicta illo qui modi.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 20, 7, 143, DateTimeKind.Local), 18, "Ut repudiandae distinctio dolores ab dolorem sit ipsa.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 11, 40, 211, DateTimeKind.Local), 17, "Quam non dignissimos quo deleniti cumque quasi repellat.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 0, 16, 63, DateTimeKind.Local), 15, "Dolorum eum laborum quibusdam ipsum id esse.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 6, 17, 978, DateTimeKind.Local), 19, "Porro odit nemo repellat.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-796-420-5948 x57950", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "Quibusdam veritatis similique odio commodi. Dolorem recusandae molestiae at blanditiis. Consequatur enim autem. Ipsa rerum illo atque consequatur.", "Juston.Ward@yahoo.com", "Company865", 1, "http://dorthy.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "WebSite" },
                values: new object[] { "674.339.8732 x1845", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", "Georgiana47@gmail.com", "Company365", "http://sabina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "553-827-1455 x1666", "64f2bf53-0184-44f6-b778-c46ebd040968", "Est est eum labore vero. Commodi nulla ipsam et maxime quia culpa. Aut asperiores perferendis beatae necessitatibus iure. Praesentium incidunt consequatur delectus ut vel beatae.", "Yasmeen.Schaden99@yahoo.com", "Company641", 2, "http://tressa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-298-580-5165 x7571", "cfdc2394-bcac-467f-9bd1-b099c449549a", "Ad necessitatibus dolorem.", "Trey.Hudson55@hotmail.com", "Company325", 2, "https://summer.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "938.881.0357 x07341", "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", "Dicta quis debitis id velit.", "Frances30@yahoo.com", "Company593", 1, "https://jacinto.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "952-818-8715 x7294", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", "Aut ipsum et dolore nihil sapiente molestiae aut ducimus est. Consequatur veniam sed vero rem sed dolor amet corrupti. Debitis eos veritatis saepe iusto et itaque velit et. Et explicabo quaerat molestiae aperiam quo unde.", "Destany23@yahoo.com", "Company935", "http://donato.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "332.490.3323 x9631", "cfdc2394-bcac-467f-9bd1-b099c449549a", "", "Jerrell.Abshire@hotmail.com", "Company830", "https://margarete.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(592) 993-3570", "64f2bf53-0184-44f6-b778-c46ebd040968", "Laudantium adipisci nam. Nulla asperiores autem vel asperiores sed blanditiis ut.", "Yadira65@yahoo.com", "Company105", "http://bobby.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-774-259-6817 x1480", "c7cb6c73-9895-498f-a06b-33597f76d4c5", "Veritatis numquam et molestiae quam. Provident illo voluptate aut repudiandae. Et ratione voluptatem aliquid nemo consequuntur magnam ullam.", "Mertie.Cassin31@gmail.com", "Company772", 2, "https://elvera.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-489-724-5605", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", "", "Aleen.Koch65@hotmail.com", "Company655", "https://alexandre.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 3, 30, 652, DateTimeKind.Local), "Qui eum facilis velit atque sed molestiae inventore.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 15, 24, 889, DateTimeKind.Local), 50, "Ipsum quaerat quam qui quibusdam distinctio modi blanditiis.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 10, 6, 401, DateTimeKind.Local), 44, "Ex placeat voluptatibus.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 47, 19, 554, DateTimeKind.Local), 46, "Aut nobis officia et repellat et laudantium quo consequuntur.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 38, 39, 152, DateTimeKind.Local), 44, "Qui eos rerum aut fuga sit ea in et corporis.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 26, 46, 596, DateTimeKind.Local), 46, "Nulla id iste omnis aut deserunt rerum.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 13, 39, 574, DateTimeKind.Local), 44, "Nihil voluptatem suscipit hic aspernatur autem laboriosam.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 34, 44, 680, DateTimeKind.Local), 47, "Et accusamus cupiditate doloremque tenetur autem.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 4, 24, 54, DateTimeKind.Local), 45, "Animi est et reiciendis.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 4, 46, 919, DateTimeKind.Local), 43, "Ad quaerat et.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", 69, 1 },
                    { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", 62, 1 },
                    { "cfdc2394-bcac-467f-9bd1-b099c449549a", 69, 1 },
                    { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", 63, 1 },
                    { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", 67, 1 },
                    { "c7cb6c73-9895-498f-a06b-33597f76d4c5", 66, 1 },
                    { "6eaef575-0500-4c20-b59b-03f452842bdf", 62, 1 },
                    { "cca3fb1b-6b17-4629-bb52-b06163ed3252", 68, 1 },
                    { "64f2bf53-0184-44f6-b778-c46ebd040968", 67, 1 },
                    { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", 65, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "64f2bf53-0184-44f6-b778-c46ebd040968", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cca3fb1b-6b17-4629-bb52-b06163ed3252", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cfdc2394-bcac-467f-9bd1-b099c449549a", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", 69 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26de10ee-aa98-4b31-b719-b1bb4fb57d8d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50593a1b-bc00-4fae-8ad9-7077d3fe19ee");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "64f2bf53-0184-44f6-b778-c46ebd040968");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6eaef575-0500-4c20-b59b-03f452842bdf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c7cb6c73-9895-498f-a06b-33597f76d4c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cca3fb1b-6b17-4629-bb52-b06163ed3252");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cfdc2394-bcac-467f-9bd1-b099c449549a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8a2257c-6f5b-420f-b475-716fa7dccd4a");

            migrationBuilder.DropColumn(
                name: "InstanceGuidId",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 31, 0 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 83, 53, 1 });

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
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 83, 15 });

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
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 90, 3 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 59, 42, 450, DateTimeKind.Local), "Title622" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d4:20:62:4c:d5:09", 64, "Linux", "Instance386" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9d:73:46:bd:54:91", 63, "Instance104" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "Title" },
                values: new object[] { "81:76:08:eb:c7:67", "Instance188" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a0:d6:7f:a6:89:92", 70, "Linux", "Instance97" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "65:75:cd:b8:2e:d5", "Windows", "Instance47" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3a:ca:99:53:c6:5d", 61, "Instance522" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8b:c1:0c:96:6d:c6", 70, "Instance519" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "95:32:57:f6:aa:0b", 67, "Instance203" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "9a:13:16:00:49:d5", 63, "Windows", "Instance735" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "7b:85:89:9d:ae:a3", 65, "Instance875" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 24, 51, 647, DateTimeKind.Local), 14, "Similique similique ut nihil itaque architecto ab.", "1f3bc470-e5e8-41c4-9d4d-c0f4e6ea6735" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 47, 31, 497, DateTimeKind.Local), 19, "Sapiente aut nobis eum ipsa necessitatibus.", "4d07300b-6cdb-4336-8873-5b787fcc233d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 3, 47, 798, DateTimeKind.Local), 17, "Sed hic reprehenderit.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 20, 15, 284, DateTimeKind.Local), 18, "Illum officiis quos molestiae eum qui est et.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 32, 34, 437, DateTimeKind.Local), 20, "Officia fugiat id iusto itaque.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 51, 13, 551, DateTimeKind.Local), "Excepturi voluptatem ut cumque qui iste consequatur.", "a58c9ba8-90a7-4f2d-af5a-faf7797c34fc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 13, 0, 965, DateTimeKind.Local), 20, "Rem quam ducimus expedita eum ut dolores.", "bfb1e6a4-218d-4333-b161-24ab083d7a28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 30, 37, 853, DateTimeKind.Local), 12, "Incidunt aut a quis numquam laudantium excepturi blanditiis saepe.", "6ac80c55-193e-47e8-9926-112c1075a759" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 55, 15, 829, DateTimeKind.Local), 14, "Quisquam hic modi et voluptatem.", "350281ff-c0af-46cd-a795-1cd23fbece28" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 12, 34, 704, DateTimeKind.Local), 12, "Et vel dolorem iure vitae est.", "0af03e47-8745-48a9-b0d5-dc03cb5ed6f5" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 48, 55, 440, DateTimeKind.Local), "Velit sint odit.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 12, 3, 12, 35, 479, DateTimeKind.Local), "Aliquam est qui soluta ut et natus.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 8, 12, 35, DateTimeKind.Local), "Est deleniti excepturi dicta aut laboriosam voluptates aperiam earum.", "94129cf8-f4b4-405a-b126-ce33d9dd4f10" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 13, 9, 20, 254, DateTimeKind.Local), "Saepe labore excepturi vel vero repellat nemo officiis nam blanditiis.", "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 42, 16, 190, DateTimeKind.Local), "Atque doloremque eius earum.", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 4, 26, 26, 127, DateTimeKind.Local), "Inventore quod quia quam eos qui praesentium ab aliquid.", "371e89b4-51e8-42e6-bd2b-5af8fd77078d" });

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
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "a8d9f652-14dd-4965-a9ef-1df16b2700b6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 1, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 0, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "9acb124f-1287-4ed6-8b4c-95a647b68f7f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "f60f47f6-3900-47e6-a4d4-2589dfaa12c8" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "WebSite" },
                values: new object[] { "906.988.0244", "f60f47f6-3900-47e6-a4d4-2589dfaa12c8", "Jamel_Nader@hotmail.com", "Company158", "http://eryn.net" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "996.512.2577 x82041", "8f5487ae-243e-4fe1-9051-8c3aaf7f0013", "Aut vel molestiae.", "Marilou8@gmail.com", "Company515", 1, "https://felicia.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "800-272-6035 x66947", "9acb124f-1287-4ed6-8b4c-95a647b68f7f", "", "Kris_Gleichner47@hotmail.com", "Company863", "http://monique.com" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 52, 15, 704, DateTimeKind.Local), "Architecto beatae labore et.", "f2e46ed8-f6e3-4859-b73e-394d18b11d29" });

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
                    { "94129cf8-f4b4-405a-b126-ce33d9dd4f10", 69, 1 },
                    { "9acb124f-1287-4ed6-8b4c-95a647b68f7f", 67, 1 },
                    { "a8d9f652-14dd-4965-a9ef-1df16b2700b6", 64, 1 },
                    { "f2e46ed8-f6e3-4859-b73e-394d18b11d29", 69, 1 },
                    { "fe8a8ea3-19c2-4f0c-8f28-78fd03ef8734", 66, 1 },
                    { "b2de8088-0082-443c-bbc8-b371d5a27ff2", 65, 1 },
                    { "b7002900-2813-4bba-9c01-835a58145c98", 67, 1 }
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
    }
}
