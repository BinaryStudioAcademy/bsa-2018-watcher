using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedNameAndEmailToFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "104e789a-998a-478b-8240-46925d8eb289", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "17303a7b-f861-4993-b650-202b9805a826", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c317a221-686e-4211-8402-be5800f50db3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "104e789a-998a-478b-8240-46925d8eb289");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17303a7b-f861-4993-b650-202b9805a826");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "361b7f86-2f9f-4278-af42-a49bc5187139");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "72c4d158-c9f9-4bb1-8279-86c127637cfa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "77ac325e-dfe7-4b14-835d-b20f271c9150");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c317a221-686e-4211-8402-be5800f50db3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd91ae36-8dd0-484f-b488-0eec3b81dbe5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d65d8522-a0e6-41ed-af72-52b85ea1e523");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e9afaf96-7110-42c2-abf6-2c900a02badb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f07d7131-08d8-4381-96af-7fcd543c9f41");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 93, 54 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 35, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 49, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 40, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 33, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 98, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 55, 42, 27, DateTimeKind.Local), "Title466" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 5, 18, 781, DateTimeKind.Local), 82, "Title453" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 22, 31, 426, DateTimeKind.Local), 87, "Title834" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 32, 59, 530, DateTimeKind.Local), 84, "Title702" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 11, 12, 237, DateTimeKind.Local), 90, "Title2" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 8, 55, 22, 68, DateTimeKind.Local), 86, "Title280" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 4, 26, 23, 903, DateTimeKind.Local), 88, "Title512" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 22, 42, 27, 35, DateTimeKind.Local), 82, "Title761" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 23, 36, 41, 938, DateTimeKind.Local), 83, "Title659" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 7, 52, 58, 444, DateTimeKind.Local), 86, "Title678" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "31:23:57:1c:7b:1f", 74, "Instance17" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "44:e4:73:ce:17:62", 73, "Instance805" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "50:cf:c8:0c:ad:79", 71, "Instance821" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f4:72:6a:7e:b7:d3", 80, "Linux", "Instance909" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cd:b2:63:98:18:3e", 75, "Linux", "Instance468" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "7d:d8:30:73:51:62", 74, "Instance866" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "07:b2:a0:ec:ad:d2", 75, "Instance433" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6d:a8:73:79:c3:9d", 75, "Linux", "Instance88" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "10:c3:c5:59:63:1c", 73, "Windows", "Instance952" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "78:aa:30:75:51:1a", 71, "Linux", "Instance178" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme399" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme632" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme437" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme26" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme186" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme945" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme514" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme18" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme138" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme715" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "5570b2e9-9936-49f9-b17b-3919c5eecacf", null, new DateTime(2018, 9, 9, 2, 17, 25, 771, DateTimeKind.Local), "Abdul", "Ariel_Labadie58@gmail.com", null, "Zackery", true, false, "Turcotte", null, "https://s3.amazonaws.com/uifaces/faces/twitter/darylws/128.jpg", 2 },
                    { "07114155-cfa1-47cd-952b-8f5c4ec240be", null, new DateTime(2018, 9, 9, 0, 12, 35, 155, DateTimeKind.Local), "Candace", "Troy_Monahan@gmail.com", null, "Germaine", true, false, "Bergstrom", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dreizle/128.jpg", 2 },
                    { "f8094016-a206-4a40-adc3-b92ec1410934", null, new DateTime(2018, 9, 9, 20, 22, 4, 604, DateTimeKind.Local), "Vivienne", "Freeda.Bartell59@yahoo.com", null, "Audra", true, false, "Kihn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joemdesign/128.jpg", 1 },
                    { "7eadfcff-b583-4407-89a0-1bb85c0a1c84", null, new DateTime(2018, 9, 9, 14, 25, 47, 345, DateTimeKind.Local), "Carleton", "Bryon25@hotmail.com", null, "Andreanne", true, false, "Fay", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gipsy_raf/128.jpg", 1 },
                    { "ed435334-5229-4335-9e90-7da8e259a354", null, new DateTime(2018, 9, 9, 20, 50, 48, 666, DateTimeKind.Local), "Ova", "Vallie_Huels7@hotmail.com", null, "Glenda", true, false, "Will", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ariil/128.jpg", 2 },
                    { "cddea15a-1ff8-4e6c-aea2-8dfb5402e136", null, new DateTime(2018, 9, 9, 15, 25, 18, 59, DateTimeKind.Local), "Shayne", "Silas25@yahoo.com", null, "Layne", true, false, "Brown", null, "https://s3.amazonaws.com/uifaces/faces/twitter/anasnakawa/128.jpg", 1 },
                    { "7f3dc2fa-8341-48be-93f5-135ba32a7910", null, new DateTime(2018, 9, 9, 4, 24, 29, 594, DateTimeKind.Local), "Paige", "Delaney_Stiedemann@hotmail.com", null, "Augustine", true, false, "Sporer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kerem/128.jpg", 1 },
                    { "d4e37539-2f83-49a7-90fd-ef749734303b", null, new DateTime(2018, 9, 8, 23, 16, 44, 827, DateTimeKind.Local), "Kristopher", "Solon_Walter@gmail.com", null, "Kimberly", true, false, "Ondricka", null, "https://s3.amazonaws.com/uifaces/faces/twitter/envex/128.jpg", 2 },
                    { "e9d34229-2688-47b3-9662-fa8f33739186", null, new DateTime(2018, 9, 9, 13, 6, 27, 440, DateTimeKind.Local), "Marcus", "Felipa_Kessler@gmail.com", null, "Emmanuelle", true, false, "Lueilwitz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ankitind/128.jpg", 1 },
                    { "562fab8e-6fd6-4550-9ce2-673081577bac", null, new DateTime(2018, 9, 9, 18, 45, 48, 516, DateTimeKind.Local), "Asha", "Kennedy_Quigley39@gmail.com", null, "Theresa", true, false, "Pollich", null, "https://s3.amazonaws.com/uifaces/faces/twitter/VinThomas/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8094016-a206-4a40-adc3-b92ec1410934", "culpa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ed435334-5229-4335-9e90-7da8e259a354", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5570b2e9-9936-49f9-b17b-3919c5eecacf", "quisquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "07114155-cfa1-47cd-952b-8f5c4ec240be", "deleniti" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "07114155-cfa1-47cd-952b-8f5c4ec240be", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7f3dc2fa-8341-48be-93f5-135ba32a7910", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9d34229-2688-47b3-9662-fa8f33739186", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "07114155-cfa1-47cd-952b-8f5c4ec240be", "corrupti" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "07114155-cfa1-47cd-952b-8f5c4ec240be", "commodi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "562fab8e-6fd6-4550-9ce2-673081577bac", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 8, 54, 324, DateTimeKind.Local), "Id voluptatibus consequuntur et occaecati earum.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 1, 16, 939, DateTimeKind.Local), "Ipsam alias officiis et qui rerum odio.", "f8094016-a206-4a40-adc3-b92ec1410934" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 1, 49, 926, DateTimeKind.Local), "Fuga delectus non eius sit recusandae.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 3, 41, 13, 381, DateTimeKind.Local), "Dolor repellendus totam at.", "cddea15a-1ff8-4e6c-aea2-8dfb5402e136" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 0, 41, 53, 897, DateTimeKind.Local), "Sit consectetur aut dolorem deleniti.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 14, 1, 8, 78, DateTimeKind.Local), "Corrupti quaerat error ipsum provident est perferendis eum reiciendis.", "7f3dc2fa-8341-48be-93f5-135ba32a7910" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 59, 40, 519, DateTimeKind.Local), "Cupiditate omnis earum magni a et.", "cddea15a-1ff8-4e6c-aea2-8dfb5402e136" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 18, 11, 335, DateTimeKind.Local), "Nulla voluptatem sunt eos odit et dolore ullam.", "562fab8e-6fd6-4550-9ce2-673081577bac" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 33, 18, 866, DateTimeKind.Local), "Sit voluptate minus molestiae quis reprehenderit ipsum iste.", "562fab8e-6fd6-4550-9ce2-673081577bac" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 2, 19, 54, 74, DateTimeKind.Local), "Et aut sequi qui similique dolore.", "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 6, 40, 10, 618, DateTimeKind.Local), "Vel totam vero adipisci.", "7eadfcff-b583-4407-89a0-1bb85c0a1c84", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 6, 18, 41, 774, DateTimeKind.Local), "Quibusdam tenetur quia illum dolorem suscipit.", "5570b2e9-9936-49f9-b17b-3919c5eecacf" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 9, 12, 17, 42, 910, DateTimeKind.Local), "Velit et sunt facilis temporibus culpa earum.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 12, 59, 25, 777, DateTimeKind.Local), "Assumenda dolores velit est pariatur nostrum.", "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 0, 19, 54, 581, DateTimeKind.Local), "Ipsam rerum voluptatum accusantium ab.", "d4e37539-2f83-49a7-90fd-ef749734303b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 22, 27, 23, 495, DateTimeKind.Local), "Qui aut sint saepe numquam voluptate quod porro sint debitis.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 16, 18, 44, 948, DateTimeKind.Local), "Fuga natus iure eum ut soluta a autem.", "7eadfcff-b583-4407-89a0-1bb85c0a1c84", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 6, 7, 24, 969, DateTimeKind.Local), "Saepe numquam et excepturi voluptatem dignissimos quis.", "7f3dc2fa-8341-48be-93f5-135ba32a7910" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 9, 38, 28, 498, DateTimeKind.Local), "Expedita soluta vitae rerum vitae enim voluptatem eaque nisi nihil.", "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 9, 18, 2, 0, 859, DateTimeKind.Local), "Odio animi voluptatibus quidem blanditiis.", "f8094016-a206-4a40-adc3-b92ec1410934" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 4, "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "f8094016-a206-4a40-adc3-b92ec1410934" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "07114155-cfa1-47cd-952b-8f5c4ec240be" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "7eadfcff-b583-4407-89a0-1bb85c0a1c84" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 0, "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 2, "07114155-cfa1-47cd-952b-8f5c4ec240be" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "5570b2e9-9936-49f9-b17b-3919c5eecacf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "7f3dc2fa-8341-48be-93f5-135ba32a7910" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 4, 27, 200, DateTimeKind.Local), 18, "Vel atque odio veniam voluptatum.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 0, 7, 29, 929, DateTimeKind.Local), 14, "Sint delectus voluptate.", "5570b2e9-9936-49f9-b17b-3919c5eecacf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 10, 10, 229, DateTimeKind.Local), 15, "Consectetur voluptatem maiores aliquam voluptatem commodi velit expedita nulla.", "7eadfcff-b583-4407-89a0-1bb85c0a1c84" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 31, 41, 931, DateTimeKind.Local), 15, "Tenetur quas eligendi voluptatem autem odit quia recusandae.", "562fab8e-6fd6-4550-9ce2-673081577bac" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 55, 3, 212, DateTimeKind.Local), 18, "Ea maiores reiciendis optio non in nihil.", "f8094016-a206-4a40-adc3-b92ec1410934" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 15, 26, 21, 570, DateTimeKind.Local), 11, "Aperiam reiciendis voluptatibus sit architecto dolor iusto.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 13, 14, 43, 960, DateTimeKind.Local), 20, "Quasi esse enim.", "cddea15a-1ff8-4e6c-aea2-8dfb5402e136" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 48, 30, 322, DateTimeKind.Local), 20, "Et odit qui.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 37, 4, 959, DateTimeKind.Local), 20, "Iusto sapiente sint dolor est sit.", "07114155-cfa1-47cd-952b-8f5c4ec240be" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 2, 31, 196, DateTimeKind.Local), 20, "Quae qui dicta magnam sequi est et libero.", "7eadfcff-b583-4407-89a0-1bb85c0a1c84" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "247.960.9669", "f8094016-a206-4a40-adc3-b92ec1410934", "Similique sed laudantium sit maxime dolorem. Dolore quam repellat.", "Bettye_Orn16@yahoo.com", "Company629", "http://nestor.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "373.569.7364 x0554", "ed435334-5229-4335-9e90-7da8e259a354", "Iste et tempora tenetur perferendis placeat. Blanditiis hic dolorem suscipit vel quia.", "Leo.Funk@hotmail.com", "Company277", 63, "http://kyla.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(621) 531-6196 x3774", "cddea15a-1ff8-4e6c-aea2-8dfb5402e136", "Reprehenderit dolores distinctio ea non. Incidunt numquam cumque quia. Vel voluptate architecto dolorem. Minima ut eius delectus amet temporibus dolorem ipsum est consequatur.", "Edison48@yahoo.com", "Company794", 67, "http://delores.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-441-208-7843", "7f3dc2fa-8341-48be-93f5-135ba32a7910", "Non sit explicabo animi tempore corrupti. Sed libero et dolor dolorum harum ullam ab.", "Ryder.Runolfsdottir96@yahoo.com", "Company435", 70, "https://emely.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-705-316-7642", "7f3dc2fa-8341-48be-93f5-135ba32a7910", "", "Sim.Trantow33@hotmail.com", "Company201", 63, "https://carolina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-639-429-3899 x570", "ed435334-5229-4335-9e90-7da8e259a354", "Ullam eaque corrupti voluptates nostrum quia rerum labore. Et quos adipisci.", "Rodger_Kunze3@gmail.com", "Company653", 70, "https://dorian.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-836-815-8005", "07114155-cfa1-47cd-952b-8f5c4ec240be", "Commodi cumque sed rerum architecto incidunt. Omnis dolor aut. Harum dolor facilis nam ut at ipsam eos ex ut. Occaecati perspiciatis exercitationem in hic voluptatem est.", "Angeline.Berge@hotmail.com", "Company269", 64, "http://marion.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-974-948-8176 x617", "7f3dc2fa-8341-48be-93f5-135ba32a7910", "", "Jennie_Herzog25@yahoo.com", "Company449", 66, "http://laisha.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-206-278-0665", "ed435334-5229-4335-9e90-7da8e259a354", "Ashly.Mitchell@hotmail.com", "Company501", 65, "http://noe.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "939.834.3735 x7060", "d4e37539-2f83-49a7-90fd-ef749734303b", "Nihil unde consequatur aut velit. Suscipit incidunt deserunt vero et quisquam blanditiis et consequuntur. Sapiente corporis minus hic rem eos ut adipisci tempora commodi. Eos eos a hic.", "Otha72@yahoo.com", "Company856", 68, "http://cody.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 55, 19, 779, DateTimeKind.Local), 44, "Rem non dicta rerum.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 58, 5, 642, DateTimeKind.Local), 41, "Quasi voluptas provident deserunt commodi a.", "07114155-cfa1-47cd-952b-8f5c4ec240be" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 1, 18, 35, 476, DateTimeKind.Local), 48, "Omnis error quasi.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 22, 32, 4, 644, DateTimeKind.Local), 46, "Est reiciendis nihil quis ab.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 56, 42, 813, DateTimeKind.Local), 50, "Et ut quia sunt illum saepe vitae maxime atque.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 17, 0, 14, 530, DateTimeKind.Local), 44, "Voluptatem molestiae nihil ut.", "5570b2e9-9936-49f9-b17b-3919c5eecacf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 11, 31, 8, 715, DateTimeKind.Local), 47, "Officia aut quia nostrum.", "ed435334-5229-4335-9e90-7da8e259a354" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 7, 55, 32, 970, DateTimeKind.Local), 43, "Voluptatem voluptas architecto beatae.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 10, 12, 22, 173, DateTimeKind.Local), 48, "Itaque sed et deleniti quia in aut suscipit qui.", "e9d34229-2688-47b3-9662-fa8f33739186" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 22, 31, 44, 602, DateTimeKind.Local), 44, "Molestias assumenda autem non officia expedita dolorem.", "d4e37539-2f83-49a7-90fd-ef749734303b" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "7f3dc2fa-8341-48be-93f5-135ba32a7910", 73, 1 },
                    { "cddea15a-1ff8-4e6c-aea2-8dfb5402e136", 74, 1 },
                    { "ed435334-5229-4335-9e90-7da8e259a354", 77, 1 },
                    { "7eadfcff-b583-4407-89a0-1bb85c0a1c84", 78, 1 },
                    { "e9d34229-2688-47b3-9662-fa8f33739186", 72, 1 },
                    { "f8094016-a206-4a40-adc3-b92ec1410934", 75, 1 },
                    { "07114155-cfa1-47cd-952b-8f5c4ec240be", 74, 1 },
                    { "5570b2e9-9936-49f9-b17b-3919c5eecacf", 76, 1 },
                    { "d4e37539-2f83-49a7-90fd-ef749734303b", 77, 1 },
                    { "562fab8e-6fd6-4550-9ce2-673081577bac", 75, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "07114155-cfa1-47cd-952b-8f5c4ec240be", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5570b2e9-9936-49f9-b17b-3919c5eecacf", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "562fab8e-6fd6-4550-9ce2-673081577bac", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7eadfcff-b583-4407-89a0-1bb85c0a1c84", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7f3dc2fa-8341-48be-93f5-135ba32a7910", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cddea15a-1ff8-4e6c-aea2-8dfb5402e136", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d4e37539-2f83-49a7-90fd-ef749734303b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e9d34229-2688-47b3-9662-fa8f33739186", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ed435334-5229-4335-9e90-7da8e259a354", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8094016-a206-4a40-adc3-b92ec1410934", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "07114155-cfa1-47cd-952b-8f5c4ec240be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5570b2e9-9936-49f9-b17b-3919c5eecacf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "562fab8e-6fd6-4550-9ce2-673081577bac");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7eadfcff-b583-4407-89a0-1bb85c0a1c84");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7f3dc2fa-8341-48be-93f5-135ba32a7910");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cddea15a-1ff8-4e6c-aea2-8dfb5402e136");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d4e37539-2f83-49a7-90fd-ef749734303b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e9d34229-2688-47b3-9662-fa8f33739186");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ed435334-5229-4335-9e90-7da8e259a354");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8094016-a206-4a40-adc3-b92ec1410934");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 5, 3 });

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 71, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 78, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 37, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 38, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 92, 95 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 52, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 53, 16, 363, DateTimeKind.Local), "Title478" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 15, 55, 197, DateTimeKind.Local), 86, "Title876" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 14, 53, 23, 647, DateTimeKind.Local), 90, "Title467" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 1, 40, 37, 983, DateTimeKind.Local), 85, "Title360" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 40, 58, 709, DateTimeKind.Local), 83, "Title173" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 1, 11, 279, DateTimeKind.Local), 89, "Title477" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 4, 37, 43, 331, DateTimeKind.Local), 83, "Title774" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 4, 39, 20, 468, DateTimeKind.Local), 86, "Title785" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 9, 28, 13, 134, DateTimeKind.Local), 84, "Title696" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 32, 24, 330, DateTimeKind.Local), 85, "Title849" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:09:fd:43:0c:90", 78, "Instance182" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ad:72:b0:c0:ed:f3", 75, "Instance400" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "39:84:d2:b4:08:24", 77, "Instance328" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cb:e4:34:8e:18:77", 78, "Windows", "Instance971" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b3:a6:d2:25:d2:f9", 71, "Windows", "Instance218" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "ae:e8:fc:bd:ef:db", 73, "Instance770" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e3:a6:b3:57:d5:c9", 73, "Instance230" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "39:37:bb:fe:be:93", 77, "Windows", "Instance658" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "22:38:5e:38:5f:e3", 80, "Linux", "Instance883" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "40:70:f5:50:72:0c", 80, "Windows", "Instance619" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme109" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme432" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme491" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme427" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme647" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme749" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme837" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme67" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme717" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme335" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", null, new DateTime(2018, 9, 8, 6, 59, 40, 90, DateTimeKind.Local), "Alfredo", "Raina_Bergnaum33@yahoo.com", null, "Jody", true, false, "Greenholt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ivanfilipovbg/128.jpg", 2 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", null, new DateTime(2018, 9, 7, 21, 17, 52, 743, DateTimeKind.Local), "Bruce", "Delpha.Donnelly50@yahoo.com", null, "Murphy", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ryankirkman/128.jpg", 2 },
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", null, new DateTime(2018, 9, 7, 21, 19, 14, 495, DateTimeKind.Local), "Kaci", "Xzavier.Jenkins@hotmail.com", null, "Elmer", true, false, "Hahn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bertboerland/128.jpg", 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", null, new DateTime(2018, 9, 8, 4, 24, 34, 420, DateTimeKind.Local), "Rebecca", "Amari.Kiehn48@gmail.com", null, "Stone", true, false, "Satterfield", null, "https://s3.amazonaws.com/uifaces/faces/twitter/juaumlol/128.jpg", 2 },
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", null, new DateTime(2018, 9, 8, 1, 2, 26, 556, DateTimeKind.Local), "Peggie", "Oma_Waters@gmail.com", null, "Brooks", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kylefrost/128.jpg", 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", null, new DateTime(2018, 9, 8, 14, 26, 21, 99, DateTimeKind.Local), "Juston", "Troy.VonRueden@hotmail.com", null, "Doug", true, false, "Kunze", null, "https://s3.amazonaws.com/uifaces/faces/twitter/d_kobelyatsky/128.jpg", 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", null, new DateTime(2018, 9, 7, 17, 39, 36, 959, DateTimeKind.Local), "Hipolito", "Stephanie_Romaguera24@hotmail.com", null, "David", true, false, "Roob", null, "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg", 2 },
                    { "c317a221-686e-4211-8402-be5800f50db3", null, new DateTime(2018, 9, 8, 1, 20, 52, 332, DateTimeKind.Local), "Clementina", "Savion.Frami56@yahoo.com", null, "Giuseppe", true, false, "Jones", null, "https://s3.amazonaws.com/uifaces/faces/twitter/faisalabid/128.jpg", 2 },
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", null, new DateTime(2018, 9, 8, 12, 23, 25, 863, DateTimeKind.Local), "Karen", "Carlo_Wunsch@hotmail.com", null, "Pat", true, false, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dactrtr/128.jpg", 1 },
                    { "17303a7b-f861-4993-b650-202b9805a826", null, new DateTime(2018, 9, 8, 5, 6, 39, 950, DateTimeKind.Local), "Sabrina", "Nona32@gmail.com", null, "Alice", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/AM_Kn2/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "104e789a-998a-478b-8240-46925d8eb289", "ullam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c317a221-686e-4211-8402-be5800f50db3", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", "laudantium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", "alias" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 19, 46, 29, 445, DateTimeKind.Local), "Nulla et facere architecto non placeat voluptatem tenetur qui.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 47, 10, 241, DateTimeKind.Local), "Maxime cupiditate tempora numquam veritatis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 36, 9, 856, DateTimeKind.Local), "Nam facere corporis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 24, 59, 250, DateTimeKind.Local), "Dicta earum in.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 20, 7, 14, 365, DateTimeKind.Local), "Dolorum eveniet consequatur ipsum dolor.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 6, 28, 44, 938, DateTimeKind.Local), "Velit dolorem error qui illum eum.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 3, 20, 589, DateTimeKind.Local), "Quaerat architecto sed possimus non dolor explicabo animi autem.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 18, 39, 445, DateTimeKind.Local), "Beatae autem numquam qui eos quo pariatur sint.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 52, 21, 34, DateTimeKind.Local), "Praesentium laboriosam qui voluptas amet.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 1, 2, 39, 319, DateTimeKind.Local), "Distinctio occaecati dicta voluptatem at dicta dolores eligendi porro repudiandae.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 8, 2, 22, 30, 156, DateTimeKind.Local), "Aut et culpa.", "e9afaf96-7110-42c2-abf6-2c900a02badb", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 7, 16, 11, 49, 696, DateTimeKind.Local), "Doloribus ad similique qui soluta.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 8, 5, 41, 14, 398, DateTimeKind.Local), "Sed voluptas quam possimus minus vitae molestias.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 8, 8, 9, 8, 710, DateTimeKind.Local), "Distinctio facilis ea tempore fugit neque quis voluptas accusantium neque.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 8, 5, 20, 28, 618, DateTimeKind.Local), "Ut repellendus sint.", "104e789a-998a-478b-8240-46925d8eb289", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 8, 7, 20, 11, 194, DateTimeKind.Local), "Eum dolorum ab quia et adipisci.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 8, 11, 11, 30, 395, DateTimeKind.Local), "Et molestiae quae consequatur quia omnis sit voluptates atque autem.", "77ac325e-dfe7-4b14-835d-b20f271c9150", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 7, 14, 59, 38, 323, DateTimeKind.Local), "Et dignissimos praesentium corrupti officia et sunt dolor voluptatem illo.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 8, 10, 18, 36, 796, DateTimeKind.Local), "At architecto non pariatur qui amet modi omnis.", "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 7, 19, 54, 9, 787, DateTimeKind.Local), "Sunt vitae voluptatum.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 3, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 3, "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 1, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 20, 17, 3, 643, DateTimeKind.Local), 12, "Laboriosam et placeat voluptatum debitis.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 15, 45, 15, 614, DateTimeKind.Local), 12, "Doloribus optio consequatur saepe quae a sapiente optio.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 1, 43, 796, DateTimeKind.Local), 12, "Eos non atque recusandae accusantium sed sed.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 14, 58, 38, 961, DateTimeKind.Local), 19, "Expedita aut eaque animi.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 14, 35, 670, DateTimeKind.Local), 14, "Consequatur officia ut consectetur vero atque fuga adipisci.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 8, 18, 9, 328, DateTimeKind.Local), 19, "Dolores magni minus sed aut.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 2, 26, 21, 475, DateTimeKind.Local), 18, "Qui blanditiis voluptatem at.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 12, 52, 27, 167, DateTimeKind.Local), 19, "Ex aut delectus.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 9, 37, 150, DateTimeKind.Local), 14, "Et suscipit et qui ea nisi ut debitis vitae eos.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 6, 24, 32, 255, DateTimeKind.Local), 19, "Et quisquam adipisci doloremque ducimus ut magni ut laboriosam.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(323) 396-2347", "104e789a-998a-478b-8240-46925d8eb289", "Rerum eius corporis. Similique quas quo eos autem nostrum adipisci quis.", "Rupert57@gmail.com", "Company325", "http://kathryn.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "680-498-9816 x664", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "", "Garnet68@hotmail.com", "Company48", 69, "https://mckayla.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(385) 482-0280 x4425", "361b7f86-2f9f-4278-af42-a49bc5187139", "Velit enim magnam consequatur ea. Iusto quasi aut cupiditate sint qui.", "Walter.Von59@hotmail.com", "Company246", 63, "http://lucio.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "924-373-3710 x372", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Quibusdam quo veniam voluptas sit aut natus autem magni minus. Voluptates natus occaecati nostrum praesentium sunt nihil maiores esse veniam. Commodi aut consequuntur consequatur ut explicabo impedit voluptates voluptatibus. Aut delectus delectus.", "Dorris_Morissette12@hotmail.com", "Company720", 66, "https://carolina.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "923-623-5034", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Iusto laudantium nam eius facere delectus odit mollitia iste rerum. Eligendi vel ut aut quas distinctio expedita quasi est error. Sed sequi laborum nam id.", "Ike70@yahoo.com", "Company397", 64, "https://jaunita.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "460.366.5740 x3649", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Voluptatem molestias est.", "Noble97@gmail.com", "Company964", 63, "http://terrill.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-436-414-0109 x2636", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Repudiandae porro id enim. Ut cum voluptatibus inventore sit eos libero laboriosam sed. Cumque animi doloribus odit porro eaque.", "Renee.Schmidt53@yahoo.com", "Company696", 61, "https://gisselle.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "448-875-3606 x3885", "17303a7b-f861-4993-b650-202b9805a826", "Autem in ab. Molestias est officia quo.", "Dante_Purdy45@hotmail.com", "Company15", 64, "http://cassie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "316.470.3214", "77ac325e-dfe7-4b14-835d-b20f271c9150", "Morgan.Rodriguez@gmail.com", "Company970", 70, "https://brionna.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "428-684-2468 x2295", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Quia blanditiis voluptas rerum quo libero ratione. Quia iure quo totam quas porro qui ut. Quos quia modi est et nihil optio quia cumque cumque.", "Mekhi.Bruen@gmail.com", "Company77", 69, "https://sigmund.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 29, 31, 950, DateTimeKind.Local), 45, "Cum omnis sed ducimus aliquid consequatur.", "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 53, 14, 827, DateTimeKind.Local), 42, "Quibusdam modi temporibus.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 11, 17, 25, 563, DateTimeKind.Local), 41, "Et eligendi consequatur iure et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 2, 57, 49, 818, DateTimeKind.Local), 49, "Et rerum voluptatem magni id.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 42, 29, 907, DateTimeKind.Local), 41, "Natus cumque reprehenderit quo aspernatur necessitatibus vel dolorem totam.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 6, 29, 70, DateTimeKind.Local), 47, "Vitae culpa vel consequatur debitis asperiores.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 12, 31, 23, 226, DateTimeKind.Local), 45, "Reprehenderit maiores enim aperiam.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 15, 57, 42, 951, DateTimeKind.Local), 46, "Doloribus tenetur officiis vero velit.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 0, 21, 40, 347, DateTimeKind.Local), 43, "In optio cum cumque sapiente exercitationem architecto natus dignissimos facere.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 14, 17, 51, 573, DateTimeKind.Local), 42, "Ut et sunt alias pariatur temporibus vero est et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", 78, 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73, 1 },
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73, 1 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79, 1 },
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72, 1 },
                    { "c317a221-686e-4211-8402-be5800f50db3", 78, 1 },
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72, 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", 77, 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74, 1 },
                    { "17303a7b-f861-4993-b650-202b9805a826", 76, 1 }
                });
        }
    }
}
