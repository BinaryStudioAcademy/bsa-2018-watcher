using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class RemovedIsActiveFieldFromChat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "Common2", "Source3", 75 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", "Common2", "Source3", 59, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded2", "Source3", 45, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", "Common1", 5, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 92, "MostLoaded2", "Common1", 29 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Source1", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Threshold", "Type" },
                values: new object[] { "Source2", 30, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common2", 63, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Common1", "Source3", 82, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 6, 0, 46, 667, DateTimeKind.Local), 82, "Title729" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 42, 9, 210, DateTimeKind.Local), 84, "Title595" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 46, 31, 658, DateTimeKind.Local), "Title355" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 38, 12, 342, DateTimeKind.Local), 86, "Title115" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 29, 28, 63, DateTimeKind.Local), "Title527" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 57, 10, 822, DateTimeKind.Local), 90, "Title534" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 19, 13, 23, 499, DateTimeKind.Local), 82, "Title449" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 18, 21, 168, DateTimeKind.Local), 89, "Title940" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 0, 54, 14, 779, DateTimeKind.Local), 81, "Title152" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 16, 54, 209, DateTimeKind.Local), 83, "Title433" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f5:4e:f5:68:a7:6d", 80, "Instance8" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "bf:93:75:44:cb:30", 76, "Linux", "Instance201" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "29:0a:12:3c:6e:d8", "Linux", "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "62:80:bf:1d:7a:72", 80, "Windows", "Instance340" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "92:34:52:77:06:fb", 80, "Linux", "Instance710" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "26:4e:39:5d:12:ea", 73, "Instance931" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4a:a7:4e:97:f1:3f", 79, "Linux", "Instance977" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "33:cb:36:24:11:f4", 78, "Instance788" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e7:c8:52:c5:75:14", 73, "Instance211" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "36:43:ba:e7:44:ea", 79, "Instance43" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme225" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme250");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme197" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme232" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme104" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme238" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme3");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme356" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme591" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme985" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", null, new DateTime(2018, 8, 29, 13, 41, 11, 293, DateTimeKind.Local), "Francesca", "Kennedi89@hotmail.com", null, "Kiera", true, false, "Cronin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ripplemdk/128.jpg", 2 },
                    { "66d92780-d516-442f-a826-8fc9140ef63c", null, new DateTime(2018, 8, 29, 19, 43, 1, 729, DateTimeKind.Local), "Nya", "Ursula_Wilderman44@hotmail.com", null, "Maximillia", true, false, "Dach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/themrdave/128.jpg", 2 },
                    { "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", null, new DateTime(2018, 8, 29, 22, 26, 3, 418, DateTimeKind.Local), "Keon", "Theodore_Kirlin56@hotmail.com", null, "Jared", true, false, "Conroy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/irae/128.jpg", 1 },
                    { "f758e32b-a6a2-431c-a408-42e333d7c3d1", null, new DateTime(2018, 8, 29, 12, 0, 47, 312, DateTimeKind.Local), "Rebecca", "Federico_Hahn@gmail.com", null, "Hollis", true, false, "Gulgowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vladarbatov/128.jpg", 2 },
                    { "d5099128-cc23-47c3-a1dd-dd3bbe8855bb", null, new DateTime(2018, 8, 29, 15, 53, 2, 621, DateTimeKind.Local), "Renee", "Nathan53@hotmail.com", null, "Emilie", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jeremery/128.jpg", 1 },
                    { "e7cd719e-8e07-42fe-b4c4-0d9388477b7f", null, new DateTime(2018, 8, 29, 15, 47, 30, 675, DateTimeKind.Local), "Zetta", "Cortney82@gmail.com", null, "Shyann", true, false, "Mertz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/grahamkennery/128.jpg", 1 },
                    { "331debbb-9ef7-4e78-8719-3cd159ac8696", null, new DateTime(2018, 8, 29, 6, 1, 57, 515, DateTimeKind.Local), "Maci", "Lucy2@gmail.com", null, "Karianne", true, false, "Koepp", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gearpixels/128.jpg", 2 },
                    { "cedb0948-5d41-40ad-8e8a-4e0d08820a7a", null, new DateTime(2018, 8, 29, 19, 8, 32, 204, DateTimeKind.Local), "Clara", "Mack39@gmail.com", null, "Haskell", true, false, "Friesen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/her_ruu/128.jpg", 2 },
                    { "bf93ed96-471c-40bb-a305-a93c713ac445", null, new DateTime(2018, 8, 29, 22, 12, 12, 198, DateTimeKind.Local), "Damien", "Dangelo74@gmail.com", null, "Brett", true, false, "Jast", null, "https://s3.amazonaws.com/uifaces/faces/twitter/duivvv/128.jpg", 1 },
                    { "6891340b-97ec-4e29-8d45-1b09c9f643af", null, new DateTime(2018, 8, 29, 12, 10, 6, 871, DateTimeKind.Local), "Forest", "Leonie.Roob84@gmail.com", null, "Deangelo", true, false, "Carroll", null, "https://s3.amazonaws.com/uifaces/faces/twitter/picard102/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6891340b-97ec-4e29-8d45-1b09c9f643af", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", "tempore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "66d92780-d516-442f-a826-8fc9140ef63c", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bf93ed96-471c-40bb-a305-a93c713ac445", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", "autem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "66d92780-d516-442f-a826-8fc9140ef63c", "harum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "66d92780-d516-442f-a826-8fc9140ef63c", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6891340b-97ec-4e29-8d45-1b09c9f643af", "blanditiis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cedb0948-5d41-40ad-8e8a-4e0d08820a7a", "porro" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 4, 43, 52, 970, DateTimeKind.Local), "Cum adipisci quis voluptatem.", "bf93ed96-471c-40bb-a305-a93c713ac445" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 6, 11, 5, 727, DateTimeKind.Local), "Omnis omnis ut voluptatem aut voluptatum blanditiis earum qui nemo.", "bf93ed96-471c-40bb-a305-a93c713ac445" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 15, 19, 32, 952, DateTimeKind.Local), "Sit dicta ducimus assumenda nihil officiis illum ipsa.", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 17, 41, 9, 482, DateTimeKind.Local), "Sint dolor reiciendis autem vero rem.", "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 12, 7, 310, DateTimeKind.Local), "Debitis sint harum voluptate et earum.", "76ecbd0e-b094-4209-a51c-4cdcedffe3e6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 42, 42, 291, DateTimeKind.Local), "Amet veniam consequuntur.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 46, 15, 852, DateTimeKind.Local), "Officia placeat sint quo a voluptatem fugiat iure quos.", "66d92780-d516-442f-a826-8fc9140ef63c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 46, 48, 949, DateTimeKind.Local), "Et nam dicta tempore sit ut ut dolorem esse blanditiis.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 5, 38, 4, 811, DateTimeKind.Local), "Tempora omnis maiores sed omnis aliquid.", "bf93ed96-471c-40bb-a305-a93c713ac445" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 50, 1, 153, DateTimeKind.Local), "Quia odit tenetur qui.", "d5099128-cc23-47c3-a1dd-dd3bbe8855bb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 29, 5, 23, 44, 789, DateTimeKind.Local), "Aperiam cupiditate officiis pariatur assumenda veniam laborum rerum impedit.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 29, 10, 52, 39, 282, DateTimeKind.Local), "Molestiae aperiam est consequatur et deserunt molestiae et architecto ut.", "6891340b-97ec-4e29-8d45-1b09c9f643af" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 29, 5, 26, 51, 453, DateTimeKind.Local), "Ipsam consequuntur eum rerum asperiores ut.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 29, 22, 5, 25, 941, DateTimeKind.Local), "Consequuntur modi nam cum eum qui placeat adipisci accusantium.", "6891340b-97ec-4e29-8d45-1b09c9f643af", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 29, 15, 15, 52, 436, DateTimeKind.Local), "Commodi quam ducimus ut nostrum adipisci cumque libero.", "6891340b-97ec-4e29-8d45-1b09c9f643af", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 41, 20, 839, DateTimeKind.Local), "Facere et maiores incidunt blanditiis.", "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 29, 9, 30, 14, 544, DateTimeKind.Local), "Qui qui id dolorem eum repudiandae et quia quisquam rerum.", "6891340b-97ec-4e29-8d45-1b09c9f643af" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 29, 23, 44, 15, 610, DateTimeKind.Local), "Eos eos eos blanditiis accusantium ad sed vero voluptatum asperiores.", "331debbb-9ef7-4e78-8719-3cd159ac8696" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 29, 11, 23, 8, 55, DateTimeKind.Local), "Eos amet sequi rem ab.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 29, 3, 9, 19, 643, DateTimeKind.Local), "Optio amet possimus dicta ab quia est repellat voluptas.", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "66d92780-d516-442f-a826-8fc9140ef63c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 4, "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "6891340b-97ec-4e29-8d45-1b09c9f643af" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "d5099128-cc23-47c3-a1dd-dd3bbe8855bb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "d5099128-cc23-47c3-a1dd-dd3bbe8855bb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "66d92780-d516-442f-a826-8fc9140ef63c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 5, 55, 27, 325, DateTimeKind.Local), 14, "Accusamus nesciunt ipsa cum ut voluptate totam repellat ut natus.", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 13, 52, 54, 308, DateTimeKind.Local), 16, "Voluptatum ut ut nihil deleniti sunt in commodi consequatur quia.", "331debbb-9ef7-4e78-8719-3cd159ac8696" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 31, 49, 489, DateTimeKind.Local), 16, "Exercitationem ratione eius cum omnis molestiae.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 30, 30, 906, DateTimeKind.Local), 12, "Saepe eveniet est error praesentium quo rerum.", "76ecbd0e-b094-4209-a51c-4cdcedffe3e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 32, 1, 461, DateTimeKind.Local), 20, "Reprehenderit maxime reprehenderit quisquam ut commodi.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 31, 35, 34, DateTimeKind.Local), 12, "Suscipit fugiat quae nihil.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 1, 33, 911, DateTimeKind.Local), 15, "Voluptates voluptate est in est.", "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 4, 3, 33, 81, DateTimeKind.Local), 15, "Et ut deleniti.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 1, 43, 23, 662, DateTimeKind.Local), 11, "Et in eum.", "bf93ed96-471c-40bb-a305-a93c713ac445" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 11, 17, 33, 986, DateTimeKind.Local), 17, "Ex culpa quis.", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "658-715-1340", "6891340b-97ec-4e29-8d45-1b09c9f643af", "Est iste quaerat nulla fugit adipisci nostrum qui harum. Est doloribus aut. Voluptates ipsam exercitationem consectetur aliquam aut qui. Adipisci ut illum aperiam alias quam autem dolorem.", "Jacynthe_Effertz53@yahoo.com", "Company520", 65, "https://dell.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "296-668-0287 x7033", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", "", "Madeline.Keebler53@hotmail.com", "Company385", 62, "https://libbie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(815) 725-8203 x758", "66d92780-d516-442f-a826-8fc9140ef63c", "Harum quae nihil nostrum et omnis nisi laboriosam. Voluptate mollitia unde. Aut hic et in hic occaecati et explicabo mollitia.", "Angela.Flatley@hotmail.com", "Company870", 68, "https://deron.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "998.274.3017 x01204", "331debbb-9ef7-4e78-8719-3cd159ac8696", "Exercitationem dolor provident aperiam vero aut occaecati.", "Alivia66@hotmail.com", "Company773", 70, "https://geovanny.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "307-850-0735 x937", "331debbb-9ef7-4e78-8719-3cd159ac8696", "", "Nakia14@hotmail.com", "Company304", 63, "http://van.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "292.917.9441", "331debbb-9ef7-4e78-8719-3cd159ac8696", "Dolor earum repellendus ad laudantium aliquid sequi. Nam voluptates sapiente veritatis. Vel nobis doloribus. Architecto tenetur fugiat dignissimos nihil recusandae vero suscipit voluptatem vel.", "Beau72@gmail.com", "Company83", 69, "http://shanie.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "771.899.1309 x5419", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", "", "Dina.Keebler@gmail.com", "Company618", 61, "https://tremayne.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "539-681-1697 x9404", "331debbb-9ef7-4e78-8719-3cd159ac8696", "Vitae repellendus earum minima consequatur minima voluptatem minus repellat. Incidunt numquam qui. Voluptatum illo dolores iste accusamus dolores laborum iste.", "Kali.Lang@gmail.com", "Company927", 70, "https://sally.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "952.913.5979 x82328", "6891340b-97ec-4e29-8d45-1b09c9f643af", "Dolorum magni et non quia aut in.", "Destiney.Yost@gmail.com", "Company879", "http://shayne.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "410-758-0927 x9026", "331debbb-9ef7-4e78-8719-3cd159ac8696", "Nisi iusto facere rerum fugit commodi doloribus deleniti at. Quibusdam omnis natus ea fuga qui possimus.", "Turner80@yahoo.com", "Company892", 63, "https://katelin.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 1, 35, 38, 22, DateTimeKind.Local), 42, "Non qui sed.", "6a2284f4-a3a2-428a-a9d7-bb60d27521d4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 28, 32, 430, DateTimeKind.Local), 49, "Aut excepturi ut necessitatibus omnis deleniti et.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 12, 9, 37, 782, DateTimeKind.Local), 41, "Minus rem nulla sit quo.", "f758e32b-a6a2-431c-a408-42e333d7c3d1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 3, 14, 35, 561, DateTimeKind.Local), 49, "Blanditiis reiciendis quisquam error expedita.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 0, 19, 54, 189, DateTimeKind.Local), 46, "Et quod rem vitae rerum.", "331debbb-9ef7-4e78-8719-3cd159ac8696" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 18, 49, 545, DateTimeKind.Local), 50, "Sit iure optio architecto qui eos.", "bf93ed96-471c-40bb-a305-a93c713ac445" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 1, 54, 47, 939, DateTimeKind.Local), 42, "Nisi et perferendis et.", "cedb0948-5d41-40ad-8e8a-4e0d08820a7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 9, 6, 34, 356, DateTimeKind.Local), 49, "Autem nihil ut rerum cumque unde qui non architecto aut.", "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 10, 38, 38, 724, DateTimeKind.Local), 45, "Velit veritatis exercitationem tempore tempore eum.", "e7cd719e-8e07-42fe-b4c4-0d9388477b7f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 0, 9, 58, 218, DateTimeKind.Local), 49, "Repudiandae culpa perspiciatis aut corrupti dicta cupiditate nemo quibusdam.", "6891340b-97ec-4e29-8d45-1b09c9f643af" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e7cd719e-8e07-42fe-b4c4-0d9388477b7f", 74 },
                    { "331debbb-9ef7-4e78-8719-3cd159ac8696", 77 },
                    { "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", 78 },
                    { "f758e32b-a6a2-431c-a408-42e333d7c3d1", 75 },
                    { "66d92780-d516-442f-a826-8fc9140ef63c", 74 },
                    { "bf93ed96-471c-40bb-a305-a93c713ac445", 79 },
                    { "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", 75 },
                    { "cedb0948-5d41-40ad-8e8a-4e0d08820a7a", 76 },
                    { "d5099128-cc23-47c3-a1dd-dd3bbe8855bb", 74 },
                    { "6891340b-97ec-4e29-8d45-1b09c9f643af", 71 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "331debbb-9ef7-4e78-8719-3cd159ac8696", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "66d92780-d516-442f-a826-8fc9140ef63c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6891340b-97ec-4e29-8d45-1b09c9f643af", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6a2284f4-a3a2-428a-a9d7-bb60d27521d4", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76ecbd0e-b094-4209-a51c-4cdcedffe3e6", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bf93ed96-471c-40bb-a305-a93c713ac445", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cedb0948-5d41-40ad-8e8a-4e0d08820a7a", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d5099128-cc23-47c3-a1dd-dd3bbe8855bb", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7cd719e-8e07-42fe-b4c4-0d9388477b7f", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f758e32b-a6a2-431c-a408-42e333d7c3d1", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "331debbb-9ef7-4e78-8719-3cd159ac8696");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "66d92780-d516-442f-a826-8fc9140ef63c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6891340b-97ec-4e29-8d45-1b09c9f643af");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6a2284f4-a3a2-428a-a9d7-bb60d27521d4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76ecbd0e-b094-4209-a51c-4cdcedffe3e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bf93ed96-471c-40bb-a305-a93c713ac445");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cedb0948-5d41-40ad-8e8a-4e0d08820a7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d5099128-cc23-47c3-a1dd-dd3bbe8855bb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7cd719e-8e07-42fe-b4c4-0d9388477b7f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f758e32b-a6a2-431c-a408-42e333d7c3d1");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", 61, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 94, "Common1", "Source1", 93 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Common1", "Source2", 71, 2 });

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
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded2", "Common2", 80, 1 });

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
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded1", "Source2", 58, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Source", "Threshold", "Type" },
                values: new object[] { "Source3", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common3", 93, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common3", "Source2", 57, 2 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 23, 9, 46, 127, DateTimeKind.Local), "Title144" });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 6, 9, 15, 944, DateTimeKind.Local), "Title607" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 28, 3, 21, 49, 252, DateTimeKind.Local), 82, "Title996" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "24:8e:7c:7a:b6:b1", 74, "Instance910" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b2:7e:bb:0f:81:a4", 74, "Windows", "Instance532" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "21:b4:38:0b:34:4c", "Windows", "Instance155" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "91:ba:b8:3e:d5:44", 71, "Linux", "Instance874" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4a:96:8c:84:7f:6f", 74, "Instance619" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "80:8c:63:a0:51:f8", 78, "Windows", "Instance273" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "99:26:37:e9:4c:d0", 74, "Instance229" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f9:27:2a:6e:9c:fa", 72, "Instance762" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ee:99:e7:c0:be:8b", 80, "Instance743" });

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
                column: "Name",
                value: "Theme953");

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme938" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme240" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme680");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 21, 50, 43, 445, DateTimeKind.Local), "Laboriosam quisquam doloribus non quod.", "43235b60-7b49-4d27-8e66-3452df164f72", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 28, 10, 22, 19, 984, DateTimeKind.Local), "Omnis quod dolores non facilis distinctio nihil autem et omnis.", "d9c92b92-34b4-4b8a-a48e-0d0ae2b02fd5", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 23, 0, 1, 773, DateTimeKind.Local), "Nihil illum accusantium.", "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

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
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "75882f38-3d05-4f6d-a76f-571b88d70c4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 2, "0beec19d-bf3e-4d84-9015-14b9fc940eed" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "8fb8631a-1cdb-412b-a804-5aa5b6ee1b7e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "43235b60-7b49-4d27-8e66-3452df164f72" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "cd965e6e-519a-49dd-913b-b775bbea5191" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "5af49d04-f291-4c8d-8ca2-2a273e3f6b55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "a3ce5d11-3101-4cc4-a843-67df7aa301ea" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(993) 373-2289 x7227", "43235b60-7b49-4d27-8e66-3452df164f72", "Iusto voluptatem numquam ipsum aut est ad. Doloremque explicabo non qui fuga quibusdam ipsum tenetur. Possimus nesciunt quae autem non.", "Eveline10@yahoo.com", "Company480", 67, "https://marcelle.name" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-330-343-2172 x327", "cd965e6e-519a-49dd-913b-b775bbea5191", "Autem tenetur sint. Quibusdam rerum nihil fugit sequi nam magni blanditiis. Est ut quibusdam minus laboriosam. Inventore sint porro architecto reiciendis dolore eius inventore.", "Cynthia.Emmerich@hotmail.com", "Company492", "http://joan.name" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 10, 19, 57, 448, DateTimeKind.Local), 45, "Et molestiae unde repudiandae adipisci perspiciatis cumque.", "09283e12-58d1-403a-afa2-074867f677b3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 28, 9, 35, 53, 848, DateTimeKind.Local), 48, "Enim cumque accusamus in architecto facere placeat aut aut.", "fc95dd2b-c457-48ae-9b90-964f53a60abf" });

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
    }
}
