using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class UpdatedInstanceSettings : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "AggregationForWeek",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 84, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 34, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 45, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 15, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 29, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 73, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 34, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 32, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 46, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 12, 57, 738, DateTimeKind.Local), 83, "Title736" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 8, 28, 543, DateTimeKind.Local), "Title239" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 18, 11, 20, DateTimeKind.Local), 85, "Title996" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 47, 45, 628, DateTimeKind.Local), 85, "Title519" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 11, 31, 80, DateTimeKind.Local), 83, "Title595" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 52, 33, 25, DateTimeKind.Local), 89, "Title903" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 52, 23, 497, DateTimeKind.Local), 89, "Title317" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 2, 51, 426, DateTimeKind.Local), "Title962" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 43, 31, 125, DateTimeKind.Local), 87, "Title467" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 1, 39, 568, DateTimeKind.Local), 87, "Title715" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "87:72:db:ff:28:f6", 71, "Instance401" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e3:b6:45:4d:a0:00", 74, "Windows", "Instance212" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "45:50:5d:bc:d8:31", 72, "Instance873" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c5:d7:ab:c2:11:eb", 76, "Windows", "Instance618" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f1:19:5c:a9:08:49", 78, "Linux", "Instance798" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "81:fe:ae:f1:b1:37", 71, "Instance533" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "Title" },
                values: new object[] { "d3:e6:95:a0:92:0b", "Instance153" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6b:81:3e:dd:83:2c", 80, "Linux", "Instance231" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "71:cb:aa:ad:15:c7", 72, "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d5:75:ba:d5:2e:0b", 76, "Instance67" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme665");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme557" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme698" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme108" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme152" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme943" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme978" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme50" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme151" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme528" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "739a6a5e-d74b-4e68-a4a3-8887ff1710e2", null, new DateTime(2018, 9, 12, 2, 58, 18, 897, DateTimeKind.Local), "Ebba", "Monroe_Muller92@gmail.com", null, "Kassandra", true, false, "Dach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/samuelkraft/128.jpg", 1 },
                    { "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06", null, new DateTime(2018, 9, 12, 0, 51, 48, 725, DateTimeKind.Local), "Elouise", "Emilio10@gmail.com", null, "Alfreda", true, false, "Mayert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/silvanmuhlemann/128.jpg", 1 },
                    { "4c5e451e-ff98-4924-822f-222b14d1c2e7", null, new DateTime(2018, 9, 11, 21, 39, 20, 784, DateTimeKind.Local), "Dane", "Dorothea_West87@yahoo.com", null, "Clarissa", true, false, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/okandungel/128.jpg", 2 },
                    { "989ceb44-5bd1-4853-9431-d9361f090c09", null, new DateTime(2018, 9, 11, 21, 31, 29, 60, DateTimeKind.Local), "Geo", "Raymundo69@gmail.com", null, "Maddison", true, false, "Schamberger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/saschamt/128.jpg", 1 },
                    { "2d5f4c3b-50e0-4871-abb0-da53cbfbe684", null, new DateTime(2018, 9, 12, 3, 49, 29, 857, DateTimeKind.Local), "Jensen", "Viva85@yahoo.com", null, "Wilburn", true, false, "Bartell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/boxmodel/128.jpg", 1 },
                    { "87b40838-f225-4a2e-83ae-b0cc477befc8", null, new DateTime(2018, 9, 11, 16, 57, 14, 714, DateTimeKind.Local), "Jo", "Isabella79@hotmail.com", null, "Augusta", true, false, "McLaughlin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sawrb/128.jpg", 2 },
                    { "ca578409-796c-4162-9883-a8438fc213ea", null, new DateTime(2018, 9, 11, 10, 20, 22, 479, DateTimeKind.Local), "Helena", "Laury.Jacobson@hotmail.com", null, "Alfredo", true, false, "O'Keefe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/borantula/128.jpg", 2 },
                    { "492f4faf-9cda-4499-9eb9-f907fd024500", null, new DateTime(2018, 9, 12, 2, 10, 31, 387, DateTimeKind.Local), "Lavinia", "Kelton57@hotmail.com", null, "Christy", true, false, "Franecki", null, "https://s3.amazonaws.com/uifaces/faces/twitter/el_fuertisimo/128.jpg", 1 },
                    { "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", null, new DateTime(2018, 9, 12, 6, 21, 21, 291, DateTimeKind.Local), "Patricia", "Regan52@hotmail.com", null, "Jordyn", true, false, "Predovic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/isnifer/128.jpg", 2 },
                    { "ecc8eb07-9060-4845-b375-08dfa1582f8c", null, new DateTime(2018, 9, 12, 4, 10, 17, 847, DateTimeKind.Local), "Rodolfo", "Alexa.Ward1@hotmail.com", null, "Halle", true, false, "Zemlak", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dcalonaci/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06", "sit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "87b40838-f225-4a2e-83ae-b0cc477befc8", "praesentium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "492f4faf-9cda-4499-9eb9-f907fd024500", "quam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ca578409-796c-4162-9883-a8438fc213ea", "quisquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ca578409-796c-4162-9883-a8438fc213ea", "harum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "87b40838-f225-4a2e-83ae-b0cc477befc8", "fugit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ecc8eb07-9060-4845-b375-08dfa1582f8c", "accusantium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2d5f4c3b-50e0-4871-abb0-da53cbfbe684", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedById",
                value: "2d5f4c3b-50e0-4871-abb0-da53cbfbe684");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 35, 48, 60, DateTimeKind.Local), "Autem quod modi qui.", "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 53, 24, 819, DateTimeKind.Local), "Qui exercitationem perspiciatis omnis eveniet et officia.", "ecc8eb07-9060-4845-b375-08dfa1582f8c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 16, 1, 856, DateTimeKind.Local), "Magni nihil at non nam velit laudantium minus neque.", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 27, 10, 274, DateTimeKind.Local), "At vitae quia reiciendis.", "4c5e451e-ff98-4924-822f-222b14d1c2e7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 4, 9, 59, 722, DateTimeKind.Local), "Facilis minima ipsum est asperiores optio.", "87b40838-f225-4a2e-83ae-b0cc477befc8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 8, 26, 48, 579, DateTimeKind.Local), "Fugit et tenetur hic.", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 27, 20, 984, DateTimeKind.Local), "Quasi voluptatem earum quo perspiciatis omnis repellat.", "492f4faf-9cda-4499-9eb9-f907fd024500" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 37, 42, 354, DateTimeKind.Local), "Velit odio laudantium ut et dolores.", "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 43, 26, 850, DateTimeKind.Local), "Provident sapiente reiciendis vero excepturi.", "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 55, 34, 513, DateTimeKind.Local), "Dolorum molestias hic explicabo dolor.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 14, 15, 56, 796, DateTimeKind.Local), "Fugiat nulla reiciendis aut.", "989ceb44-5bd1-4853-9431-d9361f090c09", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 12, 5, 31, 8, 175, DateTimeKind.Local), "Commodi accusamus quasi commodi.", "492f4faf-9cda-4499-9eb9-f907fd024500" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 4, 2, 15, 988, DateTimeKind.Local), "Dolores perferendis et dolor iusto quas at.", "989ceb44-5bd1-4853-9431-d9361f090c09", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 21, 32, 33, 974, DateTimeKind.Local), "Fugiat sed unde voluptatem amet ad deleniti dignissimos rem aut.", "4c5e451e-ff98-4924-822f-222b14d1c2e7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 7, 42, 45, 353, DateTimeKind.Local), "Est facere ipsum aut est inventore at ut praesentium.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 14, 52, 12, 169, DateTimeKind.Local), "Aspernatur sunt laborum voluptatibus consequatur.", "4c5e451e-ff98-4924-822f-222b14d1c2e7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 1, 33, 31, 979, DateTimeKind.Local), "Et illum voluptatem beatae.", "989ceb44-5bd1-4853-9431-d9361f090c09", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 16, 25, 46, 619, DateTimeKind.Local), "Quod dolore dignissimos aperiam.", "ecc8eb07-9060-4845-b375-08dfa1582f8c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 6, 19, 29, 866, DateTimeKind.Local), "Sunt dolorum eos accusamus aut amet autem sed explicabo.", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 15, 8, 38, 993, DateTimeKind.Local), "Perspiciatis doloribus sit.", "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "ecc8eb07-9060-4845-b375-08dfa1582f8c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 1, "989ceb44-5bd1-4853-9431-d9361f090c09" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: "739a6a5e-d74b-4e68-a4a3-8887ff1710e2");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "739a6a5e-d74b-4e68-a4a3-8887ff1710e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 14, 16, 351, DateTimeKind.Local), 15, "Repellendus quam et rerum aspernatur non expedita ipsa voluptatem voluptatem.", "989ceb44-5bd1-4853-9431-d9361f090c09" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 22, 49, 953, DateTimeKind.Local), 19, "Necessitatibus id et est non sit nobis perspiciatis est laboriosam.", "ecc8eb07-9060-4845-b375-08dfa1582f8c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 9, 37, 517, DateTimeKind.Local), 17, "Accusamus id provident error et ut.", "87b40838-f225-4a2e-83ae-b0cc477befc8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 34, 8, 79, DateTimeKind.Local), 14, "Labore est nemo qui voluptatem ducimus sunt.", "ecc8eb07-9060-4845-b375-08dfa1582f8c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 24, 17, 939, DateTimeKind.Local), 18, "Dolores deserunt beatae voluptas est non labore.", "87b40838-f225-4a2e-83ae-b0cc477befc8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 2, 31, 893, DateTimeKind.Local), 11, "Quisquam labore ipsum.", "492f4faf-9cda-4499-9eb9-f907fd024500" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 27, 16, 558, DateTimeKind.Local), 19, "Molestias consequatur ea ut nostrum ducimus.", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 24, 29, 96, DateTimeKind.Local), 13, "Et dolore delectus vitae quam repudiandae id.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 57, 33, 830, DateTimeKind.Local), 19, "Est impedit et ab.", "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 48, 46, 600, DateTimeKind.Local), 15, "Est id distinctio.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "864.461.7564 x4192", "87b40838-f225-4a2e-83ae-b0cc477befc8", "Incidunt voluptatum eligendi praesentium. Assumenda facilis voluptatem amet est. Sequi temporibus minus deserunt modi eos recusandae et iure.", "Ted15@gmail.com", "Company116", "http://cristobal.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(285) 975-0622 x9367", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684", "Non quis quae est et fuga voluptas vel unde est. Praesentium velit quidem culpa autem sequi laudantium voluptas consequatur porro. Consequuntur quam dolores omnis magnam labore libero fugiat. Sunt autem unde.", "Estelle_Hagenes@hotmail.com", "Company660", 64, "https://elyssa.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "761-719-1151 x624", "4c5e451e-ff98-4924-822f-222b14d1c2e7", "Ratione porro et ea dicta et neque.", "Gretchen97@yahoo.com", "Company268", 62, "http://kristopher.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "295.723.9165 x906", "492f4faf-9cda-4499-9eb9-f907fd024500", "Autem modi blanditiis omnis quos. Quas officiis sequi harum deleniti occaecati. Eaque temporibus quia voluptatem omnis recusandae sunt ipsa impedit. Voluptas quis velit aut totam eligendi illo suscipit perferendis.", "Lyric.Okuneva83@yahoo.com", "Company284", 65, "https://estel.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "818.328.2782 x6464", "492f4faf-9cda-4499-9eb9-f907fd024500", "Eaque sit aspernatur ullam laudantium.", "Kaylah55@yahoo.com", "Company746", "https://octavia.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "264-920-3920 x180", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2", "Sint laborum libero facilis corporis quasi aut eum cum ducimus. Culpa reiciendis quis delectus. Animi ut ab veniam nemo nihil omnis eos. Ratione at quae numquam.", "Lauren_Osinski24@hotmail.com", "Company291", 70, "https://rogers.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-904-936-2353", "87b40838-f225-4a2e-83ae-b0cc477befc8", "", "Alayna19@hotmail.com", "Company530", 67, "https://gage.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(723) 344-7611 x4787", "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06", "Facere et molestiae deserunt. Voluptas sit recusandae omnis laudantium assumenda laborum. Nostrum provident quaerat laudantium. Omnis neque quis a saepe.", "Herminia83@hotmail.com", "Company89", 66, "https://maria.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "939-335-9615", "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", "Tempora quia excepturi earum est pariatur quibusdam. Aliquam sit dolor tenetur quisquam sit quo dolores veritatis ut. Quia dolor perferendis perspiciatis. Eum dolorem eaque in.", "Lea_Bergstrom34@yahoo.com", "Company336", "https://art.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "994.920.8458 x3682", "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", "Natus atque consequatur in quasi. Animi consequatur odio aut a ut ipsa ullam. Alias et repellat voluptatem facilis neque earum.", "Rogers.Hintz76@yahoo.com", "Company417", 61, "https://candace.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 40, 17, 100, DateTimeKind.Local), 44, "Tenetur asperiores provident at.", "4c5e451e-ff98-4924-822f-222b14d1c2e7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 10, 14, 879, DateTimeKind.Local), 41, "Dolores et possimus aspernatur qui adipisci sequi est ullam nam.", "ca578409-796c-4162-9883-a8438fc213ea" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 47, 13, 447, DateTimeKind.Local), 49, "Molestiae dolore et laudantium.", "989ceb44-5bd1-4853-9431-d9361f090c09" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 25, 29, 153, DateTimeKind.Local), 45, "Sit est doloribus numquam delectus quas.", "492f4faf-9cda-4499-9eb9-f907fd024500" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 59, 42, 118, DateTimeKind.Local), "Rerum alias commodi perferendis impedit.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 52, 16, 436, DateTimeKind.Local), 46, "Laboriosam autem excepturi nisi dolorem.", "492f4faf-9cda-4499-9eb9-f907fd024500" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 45, 18, 902, DateTimeKind.Local), 42, "Rerum nihil eveniet aut quia.", "2d5f4c3b-50e0-4871-abb0-da53cbfbe684" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 48, 26, 368, DateTimeKind.Local), 42, "Est tempora et.", "87b40838-f225-4a2e-83ae-b0cc477befc8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 1, 28, 843, DateTimeKind.Local), 50, "Consequatur sunt et esse.", "989ceb44-5bd1-4853-9431-d9361f090c09" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 33, 13, 102, DateTimeKind.Local), 44, "Doloribus praesentium laborum quas voluptatem dolorem ipsum dolor recusandae cupiditate.", "739a6a5e-d74b-4e68-a4a3-8887ff1710e2" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", 77, 1 },
                    { "2d5f4c3b-50e0-4871-abb0-da53cbfbe684", 76, 1 },
                    { "ca578409-796c-4162-9883-a8438fc213ea", 76, 1 },
                    { "87b40838-f225-4a2e-83ae-b0cc477befc8", 77, 1 },
                    { "989ceb44-5bd1-4853-9431-d9361f090c09", 73, 1 },
                    { "4c5e451e-ff98-4924-822f-222b14d1c2e7", 72, 1 },
                    { "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06", 72, 1 },
                    { "739a6a5e-d74b-4e68-a4a3-8887ff1710e2", 74, 1 },
                    { "492f4faf-9cda-4499-9eb9-f907fd024500", 74, 1 },
                    { "ecc8eb07-9060-4845-b375-08dfa1582f8c", 75, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2d5f4c3b-50e0-4871-abb0-da53cbfbe684", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "492f4faf-9cda-4499-9eb9-f907fd024500", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4c5e451e-ff98-4924-822f-222b14d1c2e7", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "739a6a5e-d74b-4e68-a4a3-8887ff1710e2", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "87b40838-f225-4a2e-83ae-b0cc477befc8", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "989ceb44-5bd1-4853-9431-d9361f090c09", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ca578409-796c-4162-9883-a8438fc213ea", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ecc8eb07-9060-4845-b375-08dfa1582f8c", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2d5f4c3b-50e0-4871-abb0-da53cbfbe684");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "492f4faf-9cda-4499-9eb9-f907fd024500");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4c5e451e-ff98-4924-822f-222b14d1c2e7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "739a6a5e-d74b-4e68-a4a3-8887ff1710e2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76ba53b6-9c4d-4154-8b00-b3b30b0f5c06");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87b40838-f225-4a2e-83ae-b0cc477befc8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "989ceb44-5bd1-4853-9431-d9361f090c09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ca578409-796c-4162-9883-a8438fc213ea");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "caf9d9a0-f7a8-46f5-9ec2-f603e31b2313");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ecc8eb07-9060-4845-b375-08dfa1582f8c");

            migrationBuilder.DropColumn(
                name: "AggregationForWeek",
                table: "Instances");

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 83, 0 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 18, 2, 0, 709, DateTimeKind.Local), "Title84" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 15, 0, 58, 198, DateTimeKind.Local), "Title310" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "19:f6:bc:df:74:03", 76, "Instance253" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f6:26:92:80:60:20", 77, "Instance126" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e3:d8:f0:6e:3f:ae", 78, "Linux", "Instance799" });

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
                columns: new[] { "Address", "Title" },
                values: new object[] { "53:9b:09:e7:91:51", "Instance493" });

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
                column: "Name",
                value: "Theme620");

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme821" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme635" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme34" });

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
                column: "CreatedById",
                value: "fba67b9e-b7b0-415f-b131-ac022c311ddd");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 2, 18, 16, 90, DateTimeKind.Local), "Est est libero aut veniam et consequatur quia.", "32185bec-5623-463d-9d32-dff833189c31" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 6, 57, 45, 193, DateTimeKind.Local), "In voluptatem veniam doloremque autem labore voluptatem.", "6d11d143-9820-43e6-b3cc-745bfdd18061", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 3, 42, 35, 888, DateTimeKind.Local), "Qui voluptas est qui doloremque enim eum officiis.", "a70677ea-748f-4259-8068-598460f07e86", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 11, 5, 49, 1, 478, DateTimeKind.Local), "Id reiciendis nesciunt.", "6d11d143-9820-43e6-b3cc-745bfdd18061", false });

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
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "8da92424-ba3f-4126-bb43-2810fc99abef" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "32185bec-5623-463d-9d32-dff833189c31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "32185bec-5623-463d-9d32-dff833189c31" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "0840ac69-7999-487c-a61c-99073e9b99e0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
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
                column: "UserId",
                value: "0840ac69-7999-487c-a61c-99073e9b99e0");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "53f8c5f0-26a6-4746-b58e-df09b0f95f5f" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-713-785-1075", "0840ac69-7999-487c-a61c-99073e9b99e0", "Molestias nihil alias omnis tempora rem. Tempore maxime debitis dolor dolores in blanditiis ab. Ipsum cumque sit sunt est qui enim.", "Orlo_Murray89@hotmail.com", "Company409", "https://celestino.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(484) 880-3058 x94404", "6d11d143-9820-43e6-b3cc-745bfdd18061", "Qui aspernatur consequuntur eius. Ipsa dignissimos fuga quam corrupti nemo molestiae cumque ut ipsum.", "Garry33@yahoo.com", "Company168", "http://elvera.biz" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(650) 426-9178 x078", "0840ac69-7999-487c-a61c-99073e9b99e0", "", "Greta.Pollich@yahoo.com", "Company859", 69, "https://tristian.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "250.848.9012", "0840ac69-7999-487c-a61c-99073e9b99e0", "", "Cecilia_Nikolaus99@gmail.com", "Company123", "http://corbin.biz" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 10, 45, 336, DateTimeKind.Local), "Reiciendis et similique quibusdam excepturi adipisci ab vero vitae qui.", "8abc3436-3ce4-4d66-9985-cf207393656d" });

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
