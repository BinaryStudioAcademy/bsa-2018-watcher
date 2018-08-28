using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddIsActiveToChat : Migration
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
                name: "IsActive",
                table: "Chats",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", "Common1", 10, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common1", 55, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", "Common2", "Source1", 20, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", "Common2", "Source2", 97, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common2", 44, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 94, "MostLoaded2", "Source3", 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common3", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Source2", 20, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded2", "Source2", 72 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 4, 49, 110, DateTimeKind.Local), 81, "Title380" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 13, 33, 652, DateTimeKind.Local), "Title32" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 29, 49, 40, DateTimeKind.Local), 89, "Title276" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 29, 1, 111, DateTimeKind.Local), 85, "Title140" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 54, 55, 844, DateTimeKind.Local), 81, "Title964" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 57, 37, 186, DateTimeKind.Local), 89, "Title703" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 3, 41, 0, 914, DateTimeKind.Local), 83, "Title606" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 0, 10, 21, 271, DateTimeKind.Local), 90, "Title510" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 56, 9, 945, DateTimeKind.Local), 89, "Title945" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 14, 26, 21, 124, DateTimeKind.Local), 87, "Title545" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ba:d9:61:ea:4b:59", 80, "Windows", "Instance132" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3e:63:d0:4b:b8:cc", 73, "Instance427" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "1d:45:88:2c:6d:65", 80, "Instance766" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f5:f8:85:9a:97:df", 73, "Instance769" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6f:72:e0:2b:73:e7", 73, "Instance205" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "9c:70:87:42:cf:75", "Instance99" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "66:f2:79:7e:a9:46", 79, "Instance489" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "8c:55:05:29:6f:ab", "Windows", "Instance703" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "26:6d:e4:c5:52:85", 75, "Windows", "Instance722" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8e:0a:63:4e:33:7d", 80, "Windows", "Instance791" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme903");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme265");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme618");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme277" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Theme389");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme24" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme304" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme921" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme945" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme452" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "570fb7b2-30ac-46b7-98c2-5d171bafc042", null, new DateTime(2018, 8, 27, 9, 36, 45, 9, DateTimeKind.Local), "Clifford", "Catherine3@yahoo.com", null, "Edythe", true, "Wolf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mrxloka/128.jpg", 2 },
                    { "57c67516-81b3-4916-a777-5acb7675826d", null, new DateTime(2018, 8, 26, 17, 31, 50, 718, DateTimeKind.Local), "Burdette", "Jerrold.Ziemann@yahoo.com", null, "Ena", true, "Powlowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adellecharles/128.jpg", 1 },
                    { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", null, new DateTime(2018, 8, 27, 7, 50, 6, 891, DateTimeKind.Local), "Katelynn", "Gaston27@yahoo.com", null, "Stacey", true, "Wilkinson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/karlkanall/128.jpg", 1 },
                    { "7298ee98-e991-4c10-aaf4-60a9d191f818", null, new DateTime(2018, 8, 27, 6, 21, 46, 912, DateTimeKind.Local), "Javier", "Terrill1@yahoo.com", null, "Louvenia", true, "Eichmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/andrewabogado/128.jpg", 1 },
                    { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", null, new DateTime(2018, 8, 26, 22, 21, 30, 42, DateTimeKind.Local), "Lourdes", "Elmer89@gmail.com", null, "Rebecca", true, "Schmidt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/stushona/128.jpg", 1 },
                    { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", null, new DateTime(2018, 8, 27, 14, 0, 23, 466, DateTimeKind.Local), "Deborah", "Judd.Dibbert68@hotmail.com", null, "Adolf", true, "Block", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_dwite_/128.jpg", 1 },
                    { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", null, new DateTime(2018, 8, 27, 7, 24, 18, 805, DateTimeKind.Local), "Amani", "Archibald.Renner35@gmail.com", null, "Anastasia", true, "Waters", null, "https://s3.amazonaws.com/uifaces/faces/twitter/michaelcomiskey/128.jpg", 1 },
                    { "98b7a347-498b-4edb-be18-c736b985bd08", null, new DateTime(2018, 8, 27, 11, 16, 37, 695, DateTimeKind.Local), "Cale", "Jasmin_Barton@hotmail.com", null, "Neil", true, "Adams", null, "https://s3.amazonaws.com/uifaces/faces/twitter/santi_urso/128.jpg", 1 },
                    { "29a372ec-73b4-436a-b515-a3f17a5334a0", null, new DateTime(2018, 8, 27, 1, 0, 20, 146, DateTimeKind.Local), "Tressa", "Thea_Cartwright@gmail.com", null, "Gregg", true, "Collier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cdavis565/128.jpg", 2 },
                    { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", null, new DateTime(2018, 8, 27, 1, 21, 51, 215, DateTimeKind.Local), "Deshaun", "Cathy_Cummings2@yahoo.com", null, "Korbin", true, "Gulgowski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/shalt0ni/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "saepe" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "570fb7b2-30ac-46b7-98c2-5d171bafc042", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "57c67516-81b3-4916-a777-5acb7675826d", "sunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", "repellendus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", "voluptatum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "repudiandae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "29a372ec-73b4-436a-b515-a3f17a5334a0", "iusto" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 45, 4, 815, DateTimeKind.Local), "Nisi sint et optio quia ea quam tenetur in.", "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 57, 32, 703, DateTimeKind.Local), "Alias molestiae amet.", "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 57, 40, 333, DateTimeKind.Local), "Tempore quod quis fugiat sequi qui libero nostrum aliquid dolores.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 12, 39, 392, DateTimeKind.Local), "Iure velit sunt molestias inventore.", "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 15, 54, 43, 252, DateTimeKind.Local), "Nemo error nostrum quibusdam dolor quia consequatur fuga.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 1, 41, 234, DateTimeKind.Local), "Rerum autem perspiciatis fugit corrupti excepturi.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 50, 1, 830, DateTimeKind.Local), "Rerum illo molestiae.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 14, 15, 7, 709, DateTimeKind.Local), "Libero sint repudiandae et.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 44, 50, 657, DateTimeKind.Local), "Quis commodi dolor beatae eaque autem optio.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 15, 20, 25, 691, DateTimeKind.Local), "Id vel sit maiores nulla.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 2, 6, 55, 369, DateTimeKind.Local), "Et et recusandae minima.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 0, 43, 27, 240, DateTimeKind.Local), "Officia quo quibusdam laboriosam animi non officiis vel autem tempore.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 5, 25, 13, 479, DateTimeKind.Local), "Optio facere dicta adipisci pariatur.", "29a372ec-73b4-436a-b515-a3f17a5334a0", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 26, 19, 31, 21, 44, DateTimeKind.Local), "Explicabo libero quia rerum nihil qui.", "29a372ec-73b4-436a-b515-a3f17a5334a0", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 17, 2, 41, 882, DateTimeKind.Local), "Ut eos aut est nulla aspernatur culpa omnis labore et.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 26, 19, 51, 48, 22, DateTimeKind.Local), "Unde praesentium et nostrum sunt labore.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 27, 2, 34, 34, 823, DateTimeKind.Local), "Quia tenetur ad neque repellendus amet quisquam eum.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 18, 43, 4, 720, DateTimeKind.Local), "Mollitia sint quo.", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 26, 17, 44, 12, 895, DateTimeKind.Local), "Inventore hic pariatur aut voluptatum neque aut.", "7298ee98-e991-4c10-aaf4-60a9d191f818" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 27, 10, 19, 6, 310, DateTimeKind.Local), "Sit molestiae fuga atque architecto porro.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 3, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "570fb7b2-30ac-46b7-98c2-5d171bafc042" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 3, "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 51, 47, 975, DateTimeKind.Local), 11, "Quia doloremque excepturi est tenetur itaque vero.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 49, 24, 807, DateTimeKind.Local), 16, "Qui quaerat voluptas possimus veniam.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 23, 27, 20, 672, DateTimeKind.Local), 15, "Quis sit ut id quod velit sed aut.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 21, 16, 895, DateTimeKind.Local), 16, "Explicabo laborum error laudantium ipsum aliquid error numquam.", "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 48, 55, 405, DateTimeKind.Local), 12, "Nesciunt et aut nam animi iure ea ut.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 21, 38, 12, 998, DateTimeKind.Local), "Autem et et ut.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 5, 14, 766, DateTimeKind.Local), 15, "Nam cumque quos est minima nostrum fugit et dolore suscipit.", "29a372ec-73b4-436a-b515-a3f17a5334a0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 1, 7, 165, DateTimeKind.Local), 12, "Ducimus consequuntur est qui velit ex mollitia.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 16, 41, 54, 137, DateTimeKind.Local), "Quis tempore voluptatem atque accusantium qui.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 0, 55, 933, DateTimeKind.Local), 13, "Blanditiis consequuntur sequi.", "7298ee98-e991-4c10-aaf4-60a9d191f818" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "852.353.7752 x24098", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", "Voluptatem odio sunt in repellendus quisquam. Perspiciatis optio aliquid repudiandae assumenda quam omnis facilis laborum.", "Lucie.Corkery@yahoo.com", "Company364", 63, "http://tamara.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "621-788-4740", "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", "Qui eos perferendis debitis reiciendis qui distinctio est. Molestiae optio totam eaque eveniet autem labore voluptates excepturi.", "Troy.Dooley@yahoo.com", "Company428", 63, "http://josiah.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "368.201.7008", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "Adipisci ipsa dolor architecto. Nihil incidunt eum eveniet molestiae eius maiores adipisci repellendus in.", "Lessie_Ondricka@gmail.com", "Company749", 64, "https://chanel.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(353) 533-8585", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Rerum quae exercitationem facere autem. Harum exercitationem repellendus similique assumenda corrupti earum tenetur. A occaecati voluptatem est.", "Wilhelmine.Feil@yahoo.com", "Company552", 62, "http://april.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-959-697-6749 x2560", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", "Velit et ab natus ut. Consectetur est nisi dolorem rerum sint alias vel iure.", "Sandrine_Swaniawski@yahoo.com", "Company173", 63, "https://reynold.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-987-342-6977", "98b7a347-498b-4edb-be18-c736b985bd08", "In possimus officia. Aut placeat porro. Laborum ipsam voluptatem et totam illo rerum a. Exercitationem voluptates recusandae qui veritatis accusamus velit perferendis dicta qui.", "Herminia75@yahoo.com", "Company41", 62, "https://virginie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "858-613-4360", "ee541c3a-6c64-4dfe-b599-4f6886cb3837", "Necessitatibus est laboriosam rerum reprehenderit aut autem ullam alias. Quia dolores at in tenetur odit.", "Crystal_Larkin65@yahoo.com", "Company404", 64, "https://sebastian.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "436-663-8672", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Id dolore ut. Ducimus aut quibusdam autem nemo. Ea architecto veritatis.", "Marley.Moore@gmail.com", "Company5", 63, "http://raymond.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "314-240-2344 x228", "57c67516-81b3-4916-a777-5acb7675826d", "Eum minus nemo.", "Aisha26@yahoo.com", "Company76", 63, "https://stephanie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "507-572-8538 x7478", "29a372ec-73b4-436a-b515-a3f17a5334a0", "Fuga ut et non quia est harum quibusdam et. Autem est corporis temporibus optio exercitationem inventore illum qui quibusdam.", "Nelson24@gmail.com", "Company639", 67, "https://alvera.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 52, 16, 683, DateTimeKind.Local), 42, "Exercitationem iusto iusto maxime aliquam rerum error sit sed blanditiis.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 13, 11, 27, 677, DateTimeKind.Local), 48, "Voluptatem eum sunt dolor itaque velit rem iure repudiandae.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 50, 23, 540, DateTimeKind.Local), "Sint mollitia quaerat dolorem fugiat.", "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 21, 16, 772, DateTimeKind.Local), 49, "Consequuntur ut aut sed sint at quo et sapiente.", "57c67516-81b3-4916-a777-5acb7675826d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 2, 11, 728, DateTimeKind.Local), 45, "Harum saepe nam ratione consectetur cupiditate voluptates occaecati.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 7, 45, 48, 421, DateTimeKind.Local), "Facilis qui minima et inventore.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 28, 8, 352, DateTimeKind.Local), 47, "Aliquam unde quasi in saepe.", "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 9, 8, 399, DateTimeKind.Local), 42, "Quaerat est rem aliquam.", "7298ee98-e991-4c10-aaf4-60a9d191f818" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 20, 26, 49, 757, DateTimeKind.Local), 46, "Quia in et corporis et perferendis et numquam.", "ee541c3a-6c64-4dfe-b599-4f6886cb3837" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 3, 4, 58, 146, DateTimeKind.Local), 43, "Et natus itaque sint suscipit autem ut.", "98b7a347-498b-4edb-be18-c736b985bd08" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "98b7a347-498b-4edb-be18-c736b985bd08", 75 },
                    { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", 75 },
                    { "29a372ec-73b4-436a-b515-a3f17a5334a0", 77 },
                    { "57c67516-81b3-4916-a777-5acb7675826d", 76 },
                    { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", 73 },
                    { "570fb7b2-30ac-46b7-98c2-5d171bafc042", 77 },
                    { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", 77 },
                    { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", 73 },
                    { "7298ee98-e991-4c10-aaf4-60a9d191f818", 72 },
                    { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", 79 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "29a372ec-73b4-436a-b515-a3f17a5334a0", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "570fb7b2-30ac-46b7-98c2-5d171bafc042", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "57c67516-81b3-4916-a777-5acb7675826d", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7298ee98-e991-4c10-aaf4-60a9d191f818", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "98b7a347-498b-4edb-be18-c736b985bd08", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ee541c3a-6c64-4dfe-b599-4f6886cb3837", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29a372ec-73b4-436a-b515-a3f17a5334a0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "338a8a9a-ed98-4c62-9de8-2e3ffe590ee7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4c6d6bc1-bfb2-4559-951c-f0c9e79ab859");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "570fb7b2-30ac-46b7-98c2-5d171bafc042");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "57c67516-81b3-4916-a777-5acb7675826d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7298ee98-e991-4c10-aaf4-60a9d191f818");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "98b7a347-498b-4edb-be18-c736b985bd08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7218763-5a9e-4cf3-8a8a-f4d76fb0a418");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ee541c3a-6c64-4dfe-b599-4f6886cb3837");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fe330cd3-7ea8-46f7-9c00-de6ebfe71f27");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Chats");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common2", 16, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", "Common3", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common1", "Source2", 38, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded2", "Common1", "Source3", 79, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Common1", 91, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded3", "Source1", 99 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", "Common2", 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Source1", 92, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 95, "MostLoaded1", "Source1", 65 });

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
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 31, 18, 371, DateTimeKind.Local), "Title186" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 12, 0, 45, 355, DateTimeKind.Local), 82, "Title98" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8b:73:29:8f:db:a4", 74, "Linux", "Instance830" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "c8:9e:b5:4e:36:5a", 74, "Instance333" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "02:69:f0:71:ad:46", 71, "Instance828" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "6c:36:05:00:c9:41", "Instance660" });

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
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "58:15:e2:d5:16:f3", 72, "Linux", "Instance483" });

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
                column: "Name",
                value: "Theme519");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme419");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Theme141");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme712" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Theme236");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme102" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme35" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme23" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme796" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme878" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 14, 45, 18, 135, DateTimeKind.Local), "Sint doloremque vero et est.", "d7c68027-7a0a-4b78-aef9-02781e94182c", false });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 26, 13, 32, 31, 447, DateTimeKind.Local), "Corrupti cupiditate ullam cumque modi est veniam sit.", "d274933f-0df6-4ce1-860f-29ba557430f5", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 10, 4, 45, 818, DateTimeKind.Local), "Incidunt voluptates quia quae est.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 26, 18, 19, 57, 836, DateTimeKind.Local), "Aliquid laborum omnis est nisi maiores.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

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
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 1, "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 2, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 4, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 53, 44, 582, DateTimeKind.Local), "Dolor consequatur nisi impedit culpa id enim.", "97778277-833d-4bba-bc08-96216119b974" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 42, 0, 62, DateTimeKind.Local), "Accusantium sequi ea.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(975) 209-1443 x7854", "11d76c7c-c316-4694-80a0-8bc2810e1224", "", "Frederick.Rohan@yahoo.com", "Company259", 67, "https://alfredo.biz" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 50, 33, 228, DateTimeKind.Local), "Aspernatur quia praesentium in.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 36, 38, 14, DateTimeKind.Local), "Voluptatem magni quo dolorum.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 7, 49, 234, DateTimeKind.Local), 45, "Eius sit voluptas ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 44, 53, 482, DateTimeKind.Local), 48, "Nobis perferendis sapiente labore corrupti in a quam cum eos.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

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
