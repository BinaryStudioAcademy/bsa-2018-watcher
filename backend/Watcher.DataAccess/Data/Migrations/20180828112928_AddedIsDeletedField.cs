using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedIsDeletedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8486e755-b481-4eff-be21-9d95556987d1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "97778277-833d-4bba-bc08-96216119b974", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11d76c7c-c316-4694-80a0-8bc2810e1224");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3c66a652-9d95-41f8-b4e5-431382d4ac14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48fd27a3-127f-4da8-a8e7-8f46e1d41bba");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5504b109-e452-447b-97d1-a4812ac6e83e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8486e755-b481-4eff-be21-9d95556987d1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "97778277-833d-4bba-bc08-96216119b974");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b09e040a-1384-4abb-bcb5-e32a9e812f40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c92ca16a-d03a-4f48-857d-4ded5fe4735e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d274933f-0df6-4ce1-860f-29ba557430f5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d7c68027-7a0a-4b78-aef9-02781e94182c");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Themes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Samples",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Responses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Organizations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrganizationInvites",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NotificationSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Notifications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Feedbacks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Dashboards",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Chats",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Source3", 61, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common1", "Source1", 93, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Threshold" },
                values: new object[] { "MostLoaded3", 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", "Source1", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 98, "Common2", 80 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 94, "MostLoaded1", "Common3", 100 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", "Common3", "Source2", 58, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "Common1", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Source3", 93, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Source2", 57, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 6, 59, 54, 375, DateTimeKind.Local), 88, "Title728" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 5, 16, 24, 922, DateTimeKind.Local), 89, "Title835" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 23, 9, 46, 127, DateTimeKind.Local), 83, "Title144" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 2, 4, 52, 953, DateTimeKind.Local), 87, "Title683" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 6, 9, 15, 944, DateTimeKind.Local), 84, "Title607" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 6, 20, 31, 849, DateTimeKind.Local), 88, "Title954" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 18, 28, 49, 965, DateTimeKind.Local), 84, "Title565" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 3, 21, 49, 252, DateTimeKind.Local), "Title996" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 23, 37, 20, 10, DateTimeKind.Local), 88, "Title751" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 11, 8, 54, 240, DateTimeKind.Local), 84, "Title450" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Title" },
                values: new object[] { "24:8e:7c:7a:b6:b1", "Instance910" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "b2:7e:bb:0f:81:a4", "Instance532" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "21:b4:38:0b:34:4c", 72, "Instance155" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "91:ba:b8:3e:d5:44", 71, "Instance874" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "18:50:5b:66:48:89", 74, "Windows", "Instance167" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "4a:96:8c:84:7f:6f", "Windows", "Instance619" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "80:8c:63:a0:51:f8", 78, "Instance273" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "99:26:37:e9:4c:d0", "Windows", "Instance229" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Title" },
                values: new object[] { "f9:27:2a:6e:9c:fa", "Instance762" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ee:99:e7:c0:be:8b", 80, "Windows", "Instance743" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme597" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme953" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme408" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Theme938");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme396" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme240");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme680" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme113" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme511" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme741" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", null, new DateTime(2018, 8, 27, 14, 49, 21, 537, DateTimeKind.Local), "Sammie", "Luciano.Heaney34@hotmail.com", null, "Isabelle", true, false, "Wolf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bagawarman/128.jpg", 2 },
                    { "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", null, new DateTime(2018, 8, 27, 15, 54, 34, 205, DateTimeKind.Local), "Cathrine", "Ivah_Lang@yahoo.com", null, "Adelbert", true, false, "Casper", null, "https://s3.amazonaws.com/uifaces/faces/twitter/webtanya/128.jpg", 2 },
                    { "75882f38-3d05-4f6d-a76f-571b88d70c4a", null, new DateTime(2018, 8, 28, 9, 20, 23, 671, DateTimeKind.Local), "Bella", "Ariel.Rodriguez4@yahoo.com", null, "Lexie", true, false, "Mante", null, "https://s3.amazonaws.com/uifaces/faces/twitter/madewulf/128.jpg", 1 },
                    { "5af49d04-f291-4c8d-8ca2-2a273e3f6b55", null, new DateTime(2018, 8, 28, 9, 9, 9, 141, DateTimeKind.Local), "Duncan", "Ivy70@yahoo.com", null, "Freeda", true, false, "Ruecker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/marakasina/128.jpg", 2 },
                    { "cd965e6e-519a-49dd-913b-b775bbea5191", null, new DateTime(2018, 8, 28, 2, 20, 58, 227, DateTimeKind.Local), "Deon", "Jeffery62@hotmail.com", null, "Alexandrea", true, false, "Beier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mrjamesnoble/128.jpg", 1 },
                    { "fc95dd2b-c457-48ae-9b90-964f53a60abf", null, new DateTime(2018, 8, 28, 2, 39, 51, 496, DateTimeKind.Local), "Kaela", "Steve.Jaskolski@hotmail.com", null, "Delpha", true, false, "Hayes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nastya_mane/128.jpg", 2 },
                    { "43235b60-7b49-4d27-8e66-3452df164f72", null, new DateTime(2018, 8, 28, 5, 1, 5, 722, DateTimeKind.Local), "Paige", "Agustin.Cole23@gmail.com", null, "Miguel", true, false, "Schmidt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/blakehawksworth/128.jpg", 2 },
                    { "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", null, new DateTime(2018, 8, 28, 5, 44, 0, 721, DateTimeKind.Local), "Reva", "Elta_Oberbrunner99@hotmail.com", null, "Antwon", true, false, "McCullough", null, "https://s3.amazonaws.com/uifaces/faces/twitter/s4f1/128.jpg", 2 },
                    { "0beec19d-bf3e-4d84-9015-14b9fc940eed", null, new DateTime(2018, 8, 28, 6, 15, 32, 509, DateTimeKind.Local), "Nicholaus", "Shad.Crist29@gmail.com", null, "Treva", true, false, "Will", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vovkasolovev/128.jpg", 1 },
                    { "09283e12-58d1-403a-afa2-074867f677b3", null, new DateTime(2018, 8, 28, 1, 6, 15, 536, DateTimeKind.Local), "Milo", "Maida9@hotmail.com", null, "Bruce", true, false, "Halvorson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/lvovenok/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", "amet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", "quod" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0beec19d-bf3e-4d84-9015-14b9fc940eed", "fuga" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "09283e12-58d1-403a-afa2-074867f677b3", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43235b60-7b49-4d27-8e66-3452df164f72", "dolore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd965e6e-519a-49dd-913b-b775bbea5191", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", "quod" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43235b60-7b49-4d27-8e66-3452df164f72", "neque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fc95dd2b-c457-48ae-9b90-964f53a60abf", "at" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", "quod" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 20, 1, 16, 388, DateTimeKind.Local), "Totam nesciunt cupiditate neque rem eius omnis animi doloribus repellat.", "fc95dd2b-c457-48ae-9b90-964f53a60abf" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 22, 1, 25, 815, DateTimeKind.Local), "Qui ut ex est provident consequuntur illum doloremque quisquam.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 17, 1, 24, 214, DateTimeKind.Local), "Ut qui minima possimus.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 12, 21, 4, 215, DateTimeKind.Local), "Excepturi aperiam sed commodi itaque.", "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 22, 50, 39, 291, DateTimeKind.Local), "Consequatur magnam error et qui.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 3, 7, 44, 312, DateTimeKind.Local), "Esse repellendus saepe et et natus eos maxime.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 1, 36, 53, 493, DateTimeKind.Local), "Et dolorem dolores nulla explicabo omnis esse vitae aut dolore.", "cd965e6e-519a-49dd-913b-b775bbea5191" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 0, 23, 17, 395, DateTimeKind.Local), "Odio dolorem consequatur dolor nesciunt aperiam nulla qui.", "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 10, 34, 43, 299, DateTimeKind.Local), "Ut repellat ipsam et hic ipsum praesentium necessitatibus expedita.", "fc95dd2b-c457-48ae-9b90-964f53a60abf" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 0, 41, 31, 622, DateTimeKind.Local), "Molestias ea rem necessitatibus voluptatibus similique.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 28, 4, 53, 23, 175, DateTimeKind.Local), "Dolorem cum nulla.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 27, 20, 11, 20, 58, DateTimeKind.Local), "Voluptates ut nisi rem provident dignissimos quia sint enim.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 27, 17, 45, 17, 862, DateTimeKind.Local), "Maxime sed sit optio laboriosam at aliquam tempora.", "cd965e6e-519a-49dd-913b-b775bbea5191" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 28, 10, 38, 31, 50, DateTimeKind.Local), "Reprehenderit saepe modi.", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 27, 21, 50, 43, 445, DateTimeKind.Local), "Laboriosam quisquam doloribus non quod.", "43235b60-7b49-4d27-8e66-3452df164f72", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 28, 10, 22, 19, 984, DateTimeKind.Local), "Omnis quod dolores non facilis distinctio nihil autem et omnis.", "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 23, 0, 1, 773, DateTimeKind.Local), "Nihil illum accusantium.", "0beec19d-bf3e-4d84-9015-14b9fc940eed", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 16, 57, 7, 506, DateTimeKind.Local), "Suscipit voluptate deleniti consectetur atque.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 28, 2, 0, 28, 283, DateTimeKind.Local), "Rerum molestiae libero cupiditate praesentium magnam.", "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 28, 3, 40, 22, 41, DateTimeKind.Local), "Est dolorem et modi sunt ipsam qui.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 2, "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 4, "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 4, "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, true, "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 3, "cd965e6e-519a-49dd-913b-b775bbea5191" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 1, "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 4, "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 0, 51, 41, 434, DateTimeKind.Local), 12, "Voluptatem quo quidem eligendi deserunt perferendis qui.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 3, 48, 48, 472, DateTimeKind.Local), 18, "Ut dolorum ea.", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 17, 2, 8, 816, DateTimeKind.Local), 20, "Possimus cumque aut aut natus dolor ullam perferendis magnam dolorum.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 21, 55, 32, 559, DateTimeKind.Local), 14, "Sit et quam.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 14, 45, 40, 784, DateTimeKind.Local), 11, "Eos autem sit nemo maxime.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 7, 52, 45, 824, DateTimeKind.Local), 14, "Recusandae excepturi ut est itaque consequatur harum eum.", "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 1, 14, 6, 994, DateTimeKind.Local), 18, "Omnis omnis tempore doloribus dolor aut dicta.", "09283e12-58d1-403a-afa2-074867f677b3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 23, 57, 13, 574, DateTimeKind.Local), 14, "Iure id dolorum voluptas et in illum autem rerum recusandae.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 19, 53, 49, 133, DateTimeKind.Local), 16, "Autem aspernatur vel iusto eaque esse qui doloribus.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 22, 36, 20, 402, DateTimeKind.Local), 16, "Voluptatem similique sit sunt cupiditate.", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(623) 871-6181", "43235b60-7b49-4d27-8e66-3452df164f72", "Distinctio nostrum dignissimos.", "Donny75@yahoo.com", "Company7", 66, "https://carter.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(473) 762-8208 x708", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", "Nihil omnis omnis voluptatibus. Error quia excepturi tempora ipsam laborum veritatis ut porro aut. Repudiandae delectus est deserunt rem. Possimus reiciendis quasi unde iusto excepturi expedita.", "Isai_Kuphal37@yahoo.com", "Company484", 65, "http://deshawn.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "219.250.5801 x261", "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", "", "Sandy.Medhurst82@hotmail.com", "Company645", 70, "https://avery.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "774.329.7996 x941", "09283e12-58d1-403a-afa2-074867f677b3", "Provident reprehenderit ipsa cum sunt.", "Rusty_Bins41@hotmail.com", "Company348", 64, "http://rosina.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(993) 373-2289 x7227", "43235b60-7b49-4d27-8e66-3452df164f72", "Iusto voluptatem numquam ipsum aut est ad. Doloremque explicabo non qui fuga quibusdam ipsum tenetur. Possimus nesciunt quae autem non.", "Eveline10@yahoo.com", "Company480", "https://marcelle.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(748) 529-2264 x7608", "09283e12-58d1-403a-afa2-074867f677b3", "Corrupti officia maxime velit tempora reprehenderit in quod excepturi nam. Ut rem itaque suscipit facere beatae consequuntur dignissimos et repellendus. Saepe sunt beatae et sapiente ipsum rerum quidem earum sed.", "Freddie.Romaguera@gmail.com", "Company432", 67, "https://maxwell.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "571-805-9321", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", "Expedita sed corporis molestiae ea aspernatur debitis est. Et nulla ad voluptas et. Nobis fugit dolorum eaque excepturi exercitationem ipsa nobis.", "Ezra87@hotmail.com", "Company664", 63, "https://frederic.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-964-586-4948", "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", "Ad enim expedita odit aspernatur in et et adipisci.", "Willis.Crist5@gmail.com", "Company38", 64, "http://elena.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-330-343-2172 x327", "cd965e6e-519a-49dd-913b-b775bbea5191", "Autem tenetur sint. Quibusdam rerum nihil fugit sequi nam magni blanditiis. Est ut quibusdam minus laboriosam. Inventore sint porro architecto reiciendis dolore eius inventore.", "Cynthia.Emmerich@hotmail.com", "Company492", 62, "http://joan.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-232-399-5546 x898", "43235b60-7b49-4d27-8e66-3452df164f72", "Aut itaque et in necessitatibus veniam voluptatibus doloremque. Aspernatur consequuntur vitae.", "Esmeralda.DAmore9@gmail.com", "Company125", 70, "https://melissa.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 34, 41, 455, DateTimeKind.Local), 47, "Commodi non deleniti aspernatur placeat vitae officia odio iusto nisi.", "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 18, 5, 23, 977, DateTimeKind.Local), 44, "Explicabo ducimus maiores magni quidem repellendus facilis voluptas occaecati.", "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 5, 48, 27, 860, DateTimeKind.Local), 47, "Est qui et perferendis perferendis.", "09283e12-58d1-403a-afa2-074867f677b3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 4, 44, 27, 452, DateTimeKind.Local), 46, "Fugiat sit sed dicta officiis qui modi qui cum.", "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 0, 7, 13, 586, DateTimeKind.Local), 47, "Dignissimos asperiores odio itaque est ut.", "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 22, 56, 29, 357, DateTimeKind.Local), 44, "Ducimus impedit eveniet exercitationem similique voluptas ut impedit.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 10, 19, 57, 448, DateTimeKind.Local), "Et molestiae unde repudiandae adipisci perspiciatis cumque.", "09283e12-58d1-403a-afa2-074867f677b3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 9, 35, 53, 848, DateTimeKind.Local), "Enim cumque accusamus in architecto facere placeat aut aut.", "fc95dd2b-c457-48ae-9b90-964f53a60abf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 8, 59, 11, 408, DateTimeKind.Local), 41, "Aut sequi et quos omnis cumque.", "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 13, 52, 28, 757, DateTimeKind.Local), 46, "Nisi excepturi reprehenderit optio eaque illo doloribus blanditiis aut.", "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", 76 },
                    { "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", 71 },
                    { "43235b60-7b49-4d27-8e66-3452df164f72", 75 },
                    { "75882f38-3d05-4f6d-a76f-571b88d70c4a", 73 },
                    { "5af49d04-f291-4c8d-8ca2-2a273e3f6b55", 71 },
                    { "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", 71 },
                    { "cd965e6e-519a-49dd-913b-b775bbea5191", 77 },
                    { "fc95dd2b-c457-48ae-9b90-964f53a60abf", 78 },
                    { "0beec19d-bf3e-4d84-9015-14b9fc940eed", 77 },
                    { "09283e12-58d1-403a-afa2-074867f677b3", 76 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "09283e12-58d1-403a-afa2-074867f677b3", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0beec19d-bf3e-4d84-9015-14b9fc940eed", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "43235b60-7b49-4d27-8e66-3452df164f72", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5af49d04-f291-4c8d-8ca2-2a273e3f6b55", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "75882f38-3d05-4f6d-a76f-571b88d70c4a", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a3ce5d11-3101-4cc4-a843-67df7aa301ea", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd965e6e-519a-49dd-913b-b775bbea5191", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fc95dd2b-c457-48ae-9b90-964f53a60abf", 78 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09283e12-58d1-403a-afa2-074867f677b3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0beec19d-bf3e-4d84-9015-14b9fc940eed");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43235b60-7b49-4d27-8e66-3452df164f72");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5af49d04-f291-4c8d-8ca2-2a273e3f6b55");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "75882f38-3d05-4f6d-a76f-571b88d70c4a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a3ce5d11-3101-4cc4-a843-67df7aa301ea");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd965e6e-519a-49dd-913b-b775bbea5191");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fc95dd2b-c457-48ae-9b90-964f53a60abf");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrganizationInvites");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NotificationSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Instances");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Dashboards");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Charts");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Source2", 16, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common3", "Source2", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MostLoaded", "Threshold" },
                values: new object[] { "MostLoaded2", 38 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded2", "Source3", 79, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 92, "Common1", 91 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 97, "MostLoaded3", "Common2", 99 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source1", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "Common2", 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 99, "Source1", 92, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Source1", 65, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 37, 38, 527, DateTimeKind.Local), 83, "Title116" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 31, 18, 371, DateTimeKind.Local), 85, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 5, 15, 337, DateTimeKind.Local), 82, "Title644" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 29, 52, 955, DateTimeKind.Local), 86, "Title555" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 50, 791, DateTimeKind.Local), 90, "Title29" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 1, 7, 847, DateTimeKind.Local), 86, "Title2" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 33, 40, 566, DateTimeKind.Local), 87, "Title446" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 12, 0, 45, 355, DateTimeKind.Local), "Title98" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 54, 13, 125, DateTimeKind.Local), 86, "Title611" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 46, 47, 434, DateTimeKind.Local), 88, "Title443" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Title" },
                values: new object[] { "8b:73:29:8f:db:a4", "Instance830" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "Title" },
                values: new object[] { "c8:9e:b5:4e:36:5a", "Instance333" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a4:4a:17:28:e7:6e", 78, "Instance856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "29:25:96:ce:e7:f9", 72, "Instance504" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "02:69:f0:71:ad:46", 71, "Linux", "Instance828" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "6c:36:05:00:c9:41", "Linux", "Instance660" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "dc:cd:d5:d2:4e:a3", 71, "Instance658" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "39:c7:6d:95:d1:3a", "Linux", "Instance402" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Title" },
                values: new object[] { "58:15:e2:d5:16:f3", "Instance483" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "9c:20:ed:67:68:35", 76, "Linux", "Instance21" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme519" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme419" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme141" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Theme712");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Theme102");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme35" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme23" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme796" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme878" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", null, new DateTime(2018, 8, 27, 7, 45, 59, 423, DateTimeKind.Local), "Talon", "Einar11@gmail.com", null, "Lily", true, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_scottburgess/128.jpg", 2 },
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", null, new DateTime(2018, 8, 27, 7, 34, 13, 456, DateTimeKind.Local), "Tiara", "Bret.Trantow46@hotmail.com", null, "Bessie", true, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarsen/128.jpg", 2 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", null, new DateTime(2018, 8, 27, 2, 37, 12, 614, DateTimeKind.Local), "Rowan", "Ellie.Kerluke@yahoo.com", null, "Cody", true, "Reinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cyril_gaillard/128.jpg", 1 },
                    { "97778277-833d-4bba-bc08-96216119b974", null, new DateTime(2018, 8, 26, 18, 16, 47, 561, DateTimeKind.Local), "Zula", "Jensen_Schmidt@hotmail.com", null, "Alexane", true, "Rosenbaum", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vicivadeline/128.jpg", 2 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", null, new DateTime(2018, 8, 27, 2, 59, 19, 669, DateTimeKind.Local), "Kian", "Mazie.Kassulke@yahoo.com", null, "Mikel", true, "Zulauf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/danro/128.jpg", 1 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", null, new DateTime(2018, 8, 26, 19, 49, 5, 288, DateTimeKind.Local), "Kamren", "Christy_Abshire3@yahoo.com", null, "Baby", true, "Quitzon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/a_brixen/128.jpg", 1 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", null, new DateTime(2018, 8, 27, 0, 34, 6, 531, DateTimeKind.Local), "Bret", "Gerry_Hermiston84@hotmail.com", null, "Sister", true, "Abernathy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ruzinav/128.jpg", 1 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", null, new DateTime(2018, 8, 26, 21, 43, 8, 409, DateTimeKind.Local), "Rachael", "Arvilla.Prosacco@hotmail.com", null, "Roxane", true, "Becker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", 2 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", null, new DateTime(2018, 8, 27, 12, 7, 6, 946, DateTimeKind.Local), "Amelia", "Koby_Fritsch@yahoo.com", null, "Edyth", true, "Johnston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/petrangr/128.jpg", 2 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", null, new DateTime(2018, 8, 27, 10, 15, 54, 80, DateTimeKind.Local), "Kevin", "Arlo_Paucek@yahoo.com", null, "Marie", true, "Kunde", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mhesslow/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "ratione" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", "eaque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "fuga" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 12, 55, 32, 550, DateTimeKind.Local), "Non laudantium et ipsum labore.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 51, 3, 229, DateTimeKind.Local), "Rerum reiciendis veritatis ut eum itaque.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 56, 8, 443, DateTimeKind.Local), "Inventore dolorum error vel.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 59, 31, 499, DateTimeKind.Local), "Voluptatem est ut sunt laborum.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 1, 12, 34, 73, DateTimeKind.Local), "Cupiditate et quasi.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 49, 9, 397, DateTimeKind.Local), "Culpa magnam voluptatem qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 49, 922, DateTimeKind.Local), "Nam nostrum nam pariatur sit libero incidunt architecto maiores odio.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 46, 21, 73, DateTimeKind.Local), "Sit deserunt dignissimos similique aut et rem ipsa maxime molestiae.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 0, 52, 10, 701, DateTimeKind.Local), "Sit voluptatum consequatur velit libero voluptas assumenda qui.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 7, 32, 41, 421, DateTimeKind.Local), "Et deserunt voluptatem ad earum sed laudantium nostrum et tempore.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 14, 45, 18, 135, DateTimeKind.Local), "Sint doloremque vero et est.", "d7c68027-7a0a-4b78-aef9-02781e94182c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 27, 11, 36, 52, 472, DateTimeKind.Local), "Laborum debitis consequatur laborum autem ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 26, 13, 32, 31, 447, DateTimeKind.Local), "Corrupti cupiditate ullam cumque modi est veniam sit.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 4, 16, 1, 104, DateTimeKind.Local), "Consectetur dignissimos quis sapiente ut consequatur repellendus temporibus.", "d274933f-0df6-4ce1-860f-29ba557430f5", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 27, 10, 4, 45, 818, DateTimeKind.Local), "Incidunt voluptates quia quae est.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 27, 6, 29, 49, 943, DateTimeKind.Local), "Natus neque omnis non fuga temporibus temporibus.", "d7c68027-7a0a-4b78-aef9-02781e94182c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 26, 18, 19, 57, 836, DateTimeKind.Local), "Aliquid laborum omnis est nisi maiores.", "3c66a652-9d95-41f8-b4e5-431382d4ac14", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 26, 19, 4, 26, 492, DateTimeKind.Local), "Vero autem quis eos voluptas ut vitae assumenda qui omnis.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 27, 2, 59, 46, 17, DateTimeKind.Local), "Nesciunt repellat itaque.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 5, 39, 15, 577, DateTimeKind.Local), "Natus impedit ut hic non sed animi libero voluptas.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 4, "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 1, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 1, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, false, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 10, 12, 34, 962, DateTimeKind.Local), 18, "Error dicta cumque provident aliquam ea facilis nulla a.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 4, 22, 374, DateTimeKind.Local), 12, "Saepe ut veritatis vero voluptas veritatis porro magnam dolorem.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 39, 19, 508, DateTimeKind.Local), 18, "Quasi id assumenda.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 26, 37, 346, DateTimeKind.Local), 15, "Non pariatur repudiandae accusantium a optio.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 27, 5, 60, DateTimeKind.Local), 18, "Facere ratione numquam.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 53, 44, 582, DateTimeKind.Local), 13, "Dolor consequatur nisi impedit culpa id enim.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 17, 31, 229, DateTimeKind.Local), 11, "Voluptates architecto vel laudantium et.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 57, 36, 277, DateTimeKind.Local), 13, "Aperiam ut ratione voluptas illum dolor nihil veritatis.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 42, 0, 62, DateTimeKind.Local), 17, "Accusantium sequi ea.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 45, 40, 294, DateTimeKind.Local), 14, "Aut rerum temporibus qui dolores delectus maiores qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "886-531-6165", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "", "Frankie_Cronin@hotmail.com", "Company911", 67, "https://donavon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-728-358-7494", "b09e040a-1384-4abb-bcb5-e32a9e812f40", "Repudiandae quibusdam voluptas ducimus et saepe expedita officiis. Rerum enim harum eveniet voluptas facilis iure sit id. Alias et culpa ut ipsum vero maxime qui pariatur. Dolorum praesentium nesciunt autem omnis qui quas corrupti aut.", "Elissa30@yahoo.com", "Company729", 64, "http://reuben.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(392) 738-6543 x801", "d274933f-0df6-4ce1-860f-29ba557430f5", "Voluptas ut fugit eos. Non cum et fugiat laboriosam architecto eos minima modi placeat.", "Norwood_Toy@yahoo.com", "Company170", 67, "https://cathryn.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "203.427.7650 x425", "d7c68027-7a0a-4b78-aef9-02781e94182c", "", "Jeramy39@gmail.com", "Company477", 70, "https://reba.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(975) 209-1443 x7854", "11d76c7c-c316-4694-80a0-8bc2810e1224", "", "Frederick.Rohan@yahoo.com", "Company259", "https://alfredo.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "642-390-8585 x32466", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "Saepe nulla recusandae est voluptatem voluptatum ut. Facilis sit eius facere. Libero et qui corporis repudiandae incidunt necessitatibus.", "Erling13@yahoo.com", "Company50", 69, "https://hildegard.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "991-647-8137 x5828", "5504b109-e452-447b-97d1-a4812ac6e83e", "Sequi omnis in id. Doloremque eum voluptatem. Placeat voluptas fugiat.", "Gregorio_Corkery17@yahoo.com", "Company462", 65, "https://braxton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "470.671.3040 x87959", "5504b109-e452-447b-97d1-a4812ac6e83e", "", "Vinnie22@gmail.com", "Company676", 61, "http://jedediah.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "929-277-5624 x6081", "3c66a652-9d95-41f8-b4e5-431382d4ac14", "Ea vitae nihil assumenda accusamus harum aut vel eaque. Possimus quidem facilis excepturi earum assumenda amet reprehenderit natus alias.", "Keagan50@gmail.com", "Company675", 68, "https://estevan.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "469-337-2948 x708", "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "", "Justine.Gulgowski@yahoo.com", "Company227", 65, "http://darrion.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 27, 5, 941, DateTimeKind.Local), 48, "Qui laboriosam possimus illum pariatur sint commodi quibusdam et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 50, 46, 373, DateTimeKind.Local), 50, "Sunt assumenda ducimus quidem natus provident incidunt similique.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 50, 33, 228, DateTimeKind.Local), 49, "Aspernatur quia praesentium in.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 54, 51, 426, DateTimeKind.Local), 41, "Error eum sit sunt tenetur unde.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 54, 7, 142, DateTimeKind.Local), 48, "Aliquam et occaecati ut delectus optio nulla et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 36, 38, 14, DateTimeKind.Local), 50, "Voluptatem magni quo dolorum.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 7, 49, 234, DateTimeKind.Local), "Eius sit voluptas ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 44, 53, 482, DateTimeKind.Local), "Nobis perferendis sapiente labore corrupti in a quam cum eos.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 58, 34, 722, DateTimeKind.Local), 49, "Saepe magni qui quia error sed id sit quibusdam.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 41, 33, 429, DateTimeKind.Local), 48, "Et distinctio magnam explicabo eius quaerat ut.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 },
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 },
                    { "97778277-833d-4bba-bc08-96216119b974", 71 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", 78 }
                });
        }
    }
}
