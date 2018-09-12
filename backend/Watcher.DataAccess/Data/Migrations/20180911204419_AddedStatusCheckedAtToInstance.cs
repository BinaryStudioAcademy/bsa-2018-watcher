using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedStatusCheckedAtToInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusCheckedAt",
                table: "Instances",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 100, 49 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 76, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 37, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 46, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 40 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 95, 82 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 91, 81 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 12, 11, 872, DateTimeKind.Local), 87, "Title807" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 44, 20, 150, DateTimeKind.Local), 81, "Title518" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 43, 33, 973, DateTimeKind.Local), 86, "Title379" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 59, 5, 201, DateTimeKind.Local), 89, "Title341" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 53, 13, 807, DateTimeKind.Local), 86, "Title633" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 24, 54, 624, DateTimeKind.Local), "Title38" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 0, 58, 904, DateTimeKind.Local), 87, "Title589" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 33, 29, 814, DateTimeKind.Local), 89, "Title571" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 51, 1, 310, DateTimeKind.Local), 85, "Title828" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 17, 11, 687, DateTimeKind.Local), 84, "Title648" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "a0:84:9b:fb:20:f6", 75, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance361" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "3f:c3:86:0c:11:e7", 77, "Windows", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance737" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "e7:98:b0:49:b5:19", 79, "Linux", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance774" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "ce:3b:57:d0:3b:1a", 79, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance71" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "dc:9c:15:c4:d3:11", 73, "Linux", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance481" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "27:b4:98:82:a2:07", 79, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance631" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "24:b3:02:46:47:03", 75, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance273" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[] { "14:c5:60:b8:fd:4b", 76, "Linux", new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance816" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "de:b1:29:f8:4f:19", 77, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance462" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "StatusCheckedAt", "Title" },
                values: new object[] { "46:81:a7:74:e8:29", 77, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance177" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme841" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme887" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme481" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme34" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme174" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme288" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme500" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme924" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme70" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme386" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "9c91f9de-85da-4ea4-8c5b-181976d6362c", null, new DateTime(2018, 9, 11, 18, 56, 5, 142, DateTimeKind.Local), "Sierra", "Autumn75@hotmail.com", null, "Alec", true, false, "Block", null, "https://s3.amazonaws.com/uifaces/faces/twitter/daniloc/128.jpg", 1 },
                    { "0f31f24b-d6b2-454a-9914-581c5fd42469", null, new DateTime(2018, 9, 11, 19, 3, 6, 935, DateTimeKind.Local), "Hipolito", "Ricardo71@hotmail.com", null, "Hattie", true, false, "Zemlak", null, "https://s3.amazonaws.com/uifaces/faces/twitter/alessandroribe/128.jpg", 2 },
                    { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", null, new DateTime(2018, 9, 11, 9, 9, 15, 541, DateTimeKind.Local), "Coy", "Kiera.Schmeler42@yahoo.com", null, "Freddie", true, false, "Gerlach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mrjamesnoble/128.jpg", 2 },
                    { "a7c1dd4b-ca32-4977-aeb8-133be150c795", null, new DateTime(2018, 9, 11, 18, 32, 13, 66, DateTimeKind.Local), "Greyson", "Kendra_Rau@gmail.com", null, "Jane", true, false, "Marvin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ionuss/128.jpg", 1 },
                    { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", null, new DateTime(2018, 9, 11, 20, 27, 2, 500, DateTimeKind.Local), "Emiliano", "Stanford62@yahoo.com", null, "Dewitt", true, false, "Kuhic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/psaikali/128.jpg", 1 },
                    { "024f3656-21af-43b6-a989-218f35300913", null, new DateTime(2018, 9, 11, 2, 26, 44, 376, DateTimeKind.Local), "Jewell", "Akeem6@yahoo.com", null, "Michaela", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sur4dye/128.jpg", 2 },
                    { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", null, new DateTime(2018, 9, 11, 20, 10, 20, 608, DateTimeKind.Local), "Genesis", "Chadrick.Mosciski51@yahoo.com", null, "Aleen", true, false, "Willms", null, "https://s3.amazonaws.com/uifaces/faces/twitter/spedwig/128.jpg", 1 },
                    { "a39dd024-76e2-4401-89cf-2e74899e2448", null, new DateTime(2018, 9, 11, 3, 50, 36, 778, DateTimeKind.Local), "Deshawn", "Rebekah59@gmail.com", null, "Vada", true, false, "Buckridge", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", 1 },
                    { "24da036f-3088-4cb6-9e7d-07beb16991c1", null, new DateTime(2018, 9, 11, 18, 39, 5, 763, DateTimeKind.Local), "Retta", "Maudie.Brown@gmail.com", null, "Sabrina", true, false, "Rutherford", null, "https://s3.amazonaws.com/uifaces/faces/twitter/xadhix/128.jpg", 1 },
                    { "f8496351-6630-4b31-8f73-15324b1e9866", null, new DateTime(2018, 9, 11, 7, 15, 4, 473, DateTimeKind.Local), "Dayne", "Joel_OKon@yahoo.com", null, "Jailyn", true, false, "Hermann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/the_winslet/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "24da036f-3088-4cb6-9e7d-07beb16991c1", "quia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "024f3656-21af-43b6-a989-218f35300913", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "024f3656-21af-43b6-a989-218f35300913", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a39dd024-76e2-4401-89cf-2e74899e2448", "illo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7c1dd4b-ca32-4977-aeb8-133be150c795", "magni" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8496351-6630-4b31-8f73-15324b1e9866", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", "doloremque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", "ut" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 42, 43, 337, DateTimeKind.Local), "Eligendi commodi et consequatur qui est autem.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 45, 1, 192, DateTimeKind.Local), "Nihil optio quaerat et ea quaerat enim earum et.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 48, 9, 855, DateTimeKind.Local), "In esse eum libero omnis architecto.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 53, 1, 89, DateTimeKind.Local), "Tenetur quas occaecati voluptas eos laboriosam voluptas dolores.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 50, 59, 854, DateTimeKind.Local), "Animi officia aut et doloribus perferendis officiis rerum rem minus.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 38, 52, 138, DateTimeKind.Local), "Corporis sapiente iure dolorum voluptatum eius quisquam.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 15, 59, 700, DateTimeKind.Local), "Totam adipisci quod.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 50, 0, 195, DateTimeKind.Local), "Rerum aut distinctio occaecati delectus temporibus vel provident possimus cum.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 59, 51, 483, DateTimeKind.Local), "Enim repellat qui.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 59, 15, 286, DateTimeKind.Local), "Eveniet tenetur nihil distinctio accusantium explicabo et.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 11, 0, 49, 422, DateTimeKind.Local), "Quis asperiores ducimus quia necessitatibus doloremque doloremque reprehenderit velit.", "a7c1dd4b-ca32-4977-aeb8-133be150c795", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 21, 21, 587, DateTimeKind.Local), "Adipisci laudantium architecto iusto autem eius sapiente quasi.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 2, 57, 48, 148, DateTimeKind.Local), "Sed ad tempore et rem vitae dolore.", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 0, 49, 34, 288, DateTimeKind.Local), "Atque accusantium suscipit nam quae laboriosam aut maxime nobis id.", "024f3656-21af-43b6-a989-218f35300913", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 6, 33, 58, 18, DateTimeKind.Local), "Eveniet corporis nisi necessitatibus adipisci sed odio quos fugit.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 16, 23, 4, 226, DateTimeKind.Local), "Eligendi voluptas ipsum est.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 27, 38, 873, DateTimeKind.Local), "Id eius et itaque voluptates et.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 5, 19, 11, 18, DateTimeKind.Local), "Ut est occaecati ea.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 10, 23, 55, 15, 92, DateTimeKind.Local), "Qui sit minima perferendis.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 7, 36, 30, 890, DateTimeKind.Local), "Quia dolore libero ad ut.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 4, "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 2, "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 1, 55, 854, DateTimeKind.Local), 13, "Non voluptatem et aut fuga ex quia magni.", "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 16, 16, 834, DateTimeKind.Local), 14, "Consequatur soluta sint et libero quis optio et amet accusamus.", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 5, 52, 816, DateTimeKind.Local), "Eum sunt rem aut ut dolorem.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 46, 7, 707, DateTimeKind.Local), "Non nesciunt omnis impedit atque occaecati tenetur aliquid.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 26, 49, 957, DateTimeKind.Local), 15, "Non deserunt consequatur eaque repudiandae nam.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 25, 34, 916, DateTimeKind.Local), "Quisquam magni ut harum expedita inventore.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 26, 8, 862, DateTimeKind.Local), 20, "Repudiandae vero ut.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 31, 20, 779, DateTimeKind.Local), 20, "Libero repudiandae perspiciatis dignissimos.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 51, 57, 116, DateTimeKind.Local), 18, "Aut iusto et.", "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 36, 23, 816, DateTimeKind.Local), 16, "Incidunt ab iusto facilis id at et saepe.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(530) 921-7377 x422", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", "Architecto aut ipsum et beatae iusto dolorem saepe velit aliquam. Optio nemo minima fugiat.", "Rachel26@yahoo.com", "Company14", 63, "http://amelia.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "281-637-1398 x30691", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", "Dolores laudantium odit. Beatae aliquam placeat deserunt provident expedita enim autem velit minus. Vitae alias eum cum et accusantium. Unde dolores ducimus nam et dicta.", "Ellis97@hotmail.com", "Company465", 63, "https://lew.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(618) 857-0996", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Veda24@gmail.com", "Company318", 64, "https://wilma.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-727-638-1843", "024f3656-21af-43b6-a989-218f35300913", "Ducimus ullam vero necessitatibus ex ipsum cum. Neque modi eveniet sapiente saepe labore enim ex.", "Watson_Lang@hotmail.com", "Company991", 65, "https://tyrel.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-405-254-6654 x425", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Norris52@yahoo.com", "Company409", 67, "http://lelah.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(239) 855-1818 x4375", "024f3656-21af-43b6-a989-218f35300913", "Reiciendis repudiandae aliquid. Officia maxime qui labore sed provident sunt minus doloremque inventore. Est dolores temporibus.", "Kendall96@gmail.com", "Company286", 69, "https://ronaldo.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-929-204-0033", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Modesta23@hotmail.com", "Company162", 61, "https://rupert.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-942-757-3026 x670", "0f31f24b-d6b2-454a-9914-581c5fd42469", "Brisa_Schoen98@hotmail.com", "Company972", 65, "http://ricardo.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-692-434-0858", "f8496351-6630-4b31-8f73-15324b1e9866", "Quod autem consequatur consequatur id aperiam et. Perspiciatis ducimus quis eos veniam quo quos dicta debitis. Est voluptate assumenda enim dolores eveniet. In molestiae mollitia voluptatibus laboriosam pariatur accusamus ipsam.", "Alison_Ankunding7@yahoo.com", "Company694", 63, "http://bailey.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(999) 691-0484", "24da036f-3088-4cb6-9e7d-07beb16991c1", "Nobis suscipit est totam autem quia mollitia esse perspiciatis ea. Vero repellat quos beatae ipsam quis id. Ex vero dolorum et et est sit ex. Qui vero architecto fugiat possimus dolor cumque consequatur.", "Evangeline16@yahoo.com", "Company636", 66, "https://brody.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 27, 16, 802, DateTimeKind.Local), "Iusto dolore sed sit quisquam cupiditate.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 29, 51, 300, DateTimeKind.Local), 49, "Excepturi ratione at et quibusdam soluta occaecati consectetur.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 32, 59, 720, DateTimeKind.Local), 43, "Fugiat enim facilis delectus labore qui quidem.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 30, 0, 481, DateTimeKind.Local), "Sed quia et suscipit accusamus.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 34, 33, 574, DateTimeKind.Local), 46, "Nesciunt voluptatem doloremque facere aspernatur voluptas eos nisi in.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 57, 2, 15, DateTimeKind.Local), 44, "Vel velit recusandae est possimus quis repellendus.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 9, 35, 152, DateTimeKind.Local), 50, "Rerum minus ut consequatur ut.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 22, 37, 180, DateTimeKind.Local), 48, "Aut praesentium sunt labore necessitatibus et in minima nostrum pariatur.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 33, 20, 426, DateTimeKind.Local), 50, "Molestias sit in sit et et quis.", "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 22, 52, 422, DateTimeKind.Local), 44, "Et commodi ullam dolores repellat molestiae distinctio et.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", 77, 1 },
                    { "24da036f-3088-4cb6-9e7d-07beb16991c1", 78, 1 },
                    { "a39dd024-76e2-4401-89cf-2e74899e2448", 75, 1 },
                    { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", 79, 1 },
                    { "024f3656-21af-43b6-a989-218f35300913", 74, 1 },
                    { "0f31f24b-d6b2-454a-9914-581c5fd42469", 75, 1 },
                    { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", 78, 1 },
                    { "a7c1dd4b-ca32-4977-aeb8-133be150c795", 76, 1 },
                    { "9c91f9de-85da-4ea4-8c5b-181976d6362c", 74, 1 },
                    { "f8496351-6630-4b31-8f73-15324b1e9866", 72, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "024f3656-21af-43b6-a989-218f35300913", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0f31f24b-d6b2-454a-9914-581c5fd42469", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "24da036f-3088-4cb6-9e7d-07beb16991c1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a39dd024-76e2-4401-89cf-2e74899e2448", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a7c1dd4b-ca32-4977-aeb8-133be150c795", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8496351-6630-4b31-8f73-15324b1e9866", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "024f3656-21af-43b6-a989-218f35300913");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0f31f24b-d6b2-454a-9914-581c5fd42469");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24da036f-3088-4cb6-9e7d-07beb16991c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "841fb6c1-cd08-491c-b1e8-72cd41e43ff6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9c91f9de-85da-4ea4-8c5b-181976d6362c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a39dd024-76e2-4401-89cf-2e74899e2448");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7c1dd4b-ca32-4977-aeb8-133be150c795");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d8693e92-5cf4-4cd9-9eba-db70b2eb013c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8496351-6630-4b31-8f73-15324b1e9866");

            migrationBuilder.DropColumn(
                name: "StatusCheckedAt",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 30 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 58, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 65, 2 });

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
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 100, 82 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 66 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 93, 83 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 18, 27, 398, DateTimeKind.Local), 83, "Title523" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 17, 12, 2, 691, DateTimeKind.Local), "Title632" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "19:f6:bc:df:74:03", 76, "Linux", "Instance253" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "29:02:ad:fa:bd:9c", 75, "Linux", "Instance831" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f6:26:92:80:60:20", 77, "Windows", "Instance126" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e3:d8:f0:6e:3f:ae", 78, "Instance799" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "97:ff:f8:0d:6f:dd", 74, "Windows", "Instance812" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "91:2a:dd:f8:22:f2", 74, "Instance864" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "53:9b:09:e7:91:51", 71, "Instance493" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d8:0a:6b:3b:b1:f6", 72, "Windows", "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "cb:55:1d:67:5c:b9", 80, "Instance68" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4b:88:ee:7c:91:fb", 80, "Instance295" });

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
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme821" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme821" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme263" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme635" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme34" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 10, 48, 57, 739, DateTimeKind.Local), "Est quibusdam sunt enim.", "fba67b9e-b7b0-415f-b131-ac022c311ddd", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 18, 16, 90, DateTimeKind.Local), "Est est libero aut veniam et consequatur quia.", "32185bec-5623-463d-9d32-dff833189c31", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 7, 49, 40, 478, DateTimeKind.Local), "Qui nihil quae sit iste asperiores fugit quis.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 6, 0, 35, 61, DateTimeKind.Local), "Ea accusamus voluptate nam perferendis veritatis minus enim aut aut.", "b76bdc42-3b4a-4f8c-9991-b99831c10236", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 9, 55, 2, 905, DateTimeKind.Local), "Provident dicta ullam adipisci est ab.", "378606ac-b59f-4b1d-94d0-500f2ddaac9f" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 42, 35, 888, DateTimeKind.Local), "Qui voluptas est qui doloremque enim eum officiis.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 10, 21, 33, 38, 910, DateTimeKind.Local), "Recusandae ut a non cumque quisquam dolor dolore.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 5, 49, 1, 478, DateTimeKind.Local), "Id reiciendis nesciunt.", "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 3, 52, 32, 588, DateTimeKind.Local), "Pariatur ex quia mollitia fuga.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "6d11d143-9820-43e6-b3cc-745bfdd18061" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "0840ac69-7999-487c-a61c-99073e9b99e0" });

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
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 7, 13, 676, DateTimeKind.Local), "Cum magni corporis corporis.", "a70677ea-748f-4259-8068-598460f07e86" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 37, 30, 273, DateTimeKind.Local), "Quis corporis nostrum impedit ullam dolore eum aut ut.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 44, 55, 503, DateTimeKind.Local), "Mollitia quis et accusantium facere dolor atque at.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "523-902-1330", "8abc3436-3ce4-4d66-9985-cf207393656d", "", "Trycia_Moore86@hotmail.com", "Company175", 70, "http://alvera.com" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 58, 55, 656, DateTimeKind.Local), "Exercitationem quaerat labore ad ipsa enim distinctio.", "53f8c5f0-26a6-4746-b58e-df09b0f95f5f" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 20, 23, 462, DateTimeKind.Local), "Et porro iusto.", "0840ac69-7999-487c-a61c-99073e9b99e0" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 25, 15, 870, DateTimeKind.Local), 47, "Id aperiam consequuntur.", "b76bdc42-3b4a-4f8c-9991-b99831c10236" });

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
        }
    }
}
