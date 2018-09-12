using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Added_CollectorAppVersion_Entity : Migration
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

            migrationBuilder.CreateTable(
                name: "CollectorAppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    ExeLink = table.Column<string>(nullable: true),
                    DebLink = table.Column<string>(nullable: true),
                    TgzLink = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectorAppVersions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 100, 73 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 3, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                column: "Threshold",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 93, 85, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 97, 85, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 29, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 82 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 94, 22 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 10 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 16, 35, 400, DateTimeKind.Local), 88, "Title581" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 47, 37, 743, DateTimeKind.Local), 87, "Title249" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 36, 50, 527, DateTimeKind.Local), 90, "Title250" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 16, 56, 99, DateTimeKind.Local), 89, "Title246" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 11, 54, 493, DateTimeKind.Local), 86, "Title832" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 45, 9, 716, DateTimeKind.Local), 88, "Title936" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 48, 3, 481, DateTimeKind.Local), 87, "Title737" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 6, 16, 551, DateTimeKind.Local), 82, "Title592" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 4, 52, 406, DateTimeKind.Local), 87, "Title989" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 39, 11, 690, DateTimeKind.Local), 86, "Title643" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "cd:40:84:90:f1:a9", 71, "Instance135" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3b:e0:98:ca:69:61", 75, "Instance576" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e2:f0:97:0f:87:79", 80, "Instance412" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Title" },
                values: new object[] { "ed:c2:42:1e:af:b5", "Instance771" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4c:21:21:f2:71:54", 78, "Instance207" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "ae:10:fc:62:ff:dc", "Instance982" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b3:d6:d5:8c:fa:79", 77, "Windows", "Instance34" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "41:6e:c1:f2:73:c0", 79, "Instance106" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "bf:ba:44:e6:58:dc", 78, "Linux", "Instance614" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "0d:a9:f3:bc:c3:76", 73, "Instance120" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Theme910");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme776" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme313" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme823" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "Theme781");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme126" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme282" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme484" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme866" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme60" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "0260ccd0-3a37-4ed2-ab2f-543810027907", null, new DateTime(2018, 9, 11, 12, 31, 5, 55, DateTimeKind.Local), "Euna", "Joelle.Harber@gmail.com", null, "Fay", true, false, "Conroy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dhoot_amit/128.jpg", 1 },
                    { "666909a1-17b5-41af-8ccb-2e861a540155", null, new DateTime(2018, 9, 11, 19, 30, 17, 214, DateTimeKind.Local), "Audrey", "Derrick55@yahoo.com", null, "Eleazar", true, false, "Blick", null, "https://s3.amazonaws.com/uifaces/faces/twitter/timgthomas/128.jpg", 2 },
                    { "2ec236a6-25a4-4dc5-8926-af73b29dd42c", null, new DateTime(2018, 9, 11, 2, 34, 31, 512, DateTimeKind.Local), "Marques", "Cyril30@hotmail.com", null, "Ellis", true, false, "Morar", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ManikRathee/128.jpg", 2 },
                    { "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8", null, new DateTime(2018, 9, 11, 0, 13, 47, 23, DateTimeKind.Local), "Ashton", "Golda.Stokes@yahoo.com", null, "Keshaun", true, false, "Collins", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joaoedumedeiros/128.jpg", 1 },
                    { "7883317d-40ed-441a-a54d-7bb483b1863d", null, new DateTime(2018, 9, 11, 9, 14, 54, 947, DateTimeKind.Local), "Wilfrid", "Lela_Beier90@hotmail.com", null, "Fidel", true, false, "Lowe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/heycamtaylor/128.jpg", 1 },
                    { "b828e516-c495-4b5e-adb5-3caa41fb3231", null, new DateTime(2018, 9, 11, 7, 16, 46, 277, DateTimeKind.Local), "Guillermo", "Bertha_Blanda@hotmail.com", null, "Rodrigo", true, false, "Reichert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dshster/128.jpg", 2 },
                    { "df715b76-4cf3-46f9-8850-aac5300375f1", null, new DateTime(2018, 9, 11, 17, 38, 48, 398, DateTimeKind.Local), "Emelie", "Felton33@yahoo.com", null, "Johann", true, false, "Wilkinson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/rtyukmaev/128.jpg", 2 },
                    { "7337fdcd-7e5f-4251-b92e-2646668d6715", null, new DateTime(2018, 9, 11, 4, 5, 20, 150, DateTimeKind.Local), "Rebekah", "Rose.Beer@yahoo.com", null, "Devyn", true, false, "Conn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cherif_b/128.jpg", 1 },
                    { "107ded11-f698-4020-a5b6-66b70d0afbb9", null, new DateTime(2018, 9, 11, 19, 50, 47, 800, DateTimeKind.Local), "Spencer", "Camryn73@hotmail.com", null, "Nikko", true, false, "Friesen", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ilya_pestov/128.jpg", 2 },
                    { "5cb4609d-26f4-4eda-971d-8c7e56136de3", null, new DateTime(2018, 9, 11, 7, 39, 7, 52, DateTimeKind.Local), "Richie", "Herman_Marks@gmail.com", null, "Shanny", true, false, "Kovacek", null, "https://s3.amazonaws.com/uifaces/faces/twitter/demersdesigns/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5cb4609d-26f4-4eda-971d-8c7e56136de3", "consectetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8", "laboriosam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "107ded11-f698-4020-a5b6-66b70d0afbb9", "exercitationem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0260ccd0-3a37-4ed2-ab2f-543810027907", "repellat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0260ccd0-3a37-4ed2-ab2f-543810027907", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "df715b76-4cf3-46f9-8850-aac5300375f1", "tempore" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7883317d-40ed-441a-a54d-7bb483b1863d", "quos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "107ded11-f698-4020-a5b6-66b70d0afbb9", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "df715b76-4cf3-46f9-8850-aac5300375f1", "at" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8", "nam" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 1, 27, 796, DateTimeKind.Local), "Dolore sed beatae.", "b828e516-c495-4b5e-adb5-3caa41fb3231" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 35, 24, 61, DateTimeKind.Local), "Autem quae eum iusto accusantium ratione numquam.", "7883317d-40ed-441a-a54d-7bb483b1863d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 15, 29, 606, DateTimeKind.Local), "Quod corporis reprehenderit.", "7337fdcd-7e5f-4251-b92e-2646668d6715" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 25, 31, 123, DateTimeKind.Local), "Assumenda non perspiciatis dolorum hic eveniet laudantium dolor.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 57, 47, 151, DateTimeKind.Local), "Consequatur eius voluptatibus laborum fugiat.", "7883317d-40ed-441a-a54d-7bb483b1863d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 24, 17, 442, DateTimeKind.Local), "Dolores totam labore nemo.", "7337fdcd-7e5f-4251-b92e-2646668d6715" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 22, 4, 16, 974, DateTimeKind.Local), "Perferendis recusandae consequuntur cupiditate placeat qui corporis dolorum iusto omnis.", "107ded11-f698-4020-a5b6-66b70d0afbb9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 36, 31, 65, DateTimeKind.Local), "Deleniti culpa id iure earum accusamus pariatur quia.", "b828e516-c495-4b5e-adb5-3caa41fb3231" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 24, 51, 451, DateTimeKind.Local), "Et et et distinctio nesciunt provident eius quis aut alias.", "b828e516-c495-4b5e-adb5-3caa41fb3231" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 26, 4, 450, DateTimeKind.Local), "Cupiditate suscipit dolores veritatis animi unde inventore saepe.", "107ded11-f698-4020-a5b6-66b70d0afbb9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 10, 21, 15, 54, 941, DateTimeKind.Local), "Sit neque esse autem aut et quis aliquid.", "5cb4609d-26f4-4eda-971d-8c7e56136de3", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 9, 11, 3, 17, 44, 396, DateTimeKind.Local), "Atque architecto placeat modi sed et iusto.", "666909a1-17b5-41af-8ccb-2e861a540155", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 16, 24, 21, 23, DateTimeKind.Local), "Consequatur nihil iusto aut sed recusandae natus eum.", "5cb4609d-26f4-4eda-971d-8c7e56136de3", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 10, 23, 18, 47, 52, DateTimeKind.Local), "Adipisci eum fuga expedita magnam odit nisi.", "b828e516-c495-4b5e-adb5-3caa41fb3231", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 26, 44, 100, DateTimeKind.Local), "Harum dolores dolorem et.", "2ec236a6-25a4-4dc5-8926-af73b29dd42c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 18, 30, 38, 352, DateTimeKind.Local), "Minus facilis itaque.", "7337fdcd-7e5f-4251-b92e-2646668d6715" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 11, 19, 15, 0, 15, DateTimeKind.Local), "Aperiam enim magnam dolorem soluta consequatur libero.", "7883317d-40ed-441a-a54d-7bb483b1863d", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 10, 23, 32, 23, 372, DateTimeKind.Local), "Reiciendis atque odio vero eos sunt odio qui occaecati.", "df715b76-4cf3-46f9-8850-aac5300375f1", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 16, 15, 9, 216, DateTimeKind.Local), "Laudantium amet est ipsam dolorem et.", "df715b76-4cf3-46f9-8850-aac5300375f1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 0, 41, 38, 703, DateTimeKind.Local), "Voluptatem hic corrupti dolores illo.", "7883317d-40ed-441a-a54d-7bb483b1863d", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, true, "107ded11-f698-4020-a5b6-66b70d0afbb9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "666909a1-17b5-41af-8ccb-2e861a540155" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "2ec236a6-25a4-4dc5-8926-af73b29dd42c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "2ec236a6-25a4-4dc5-8926-af73b29dd42c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, false, "107ded11-f698-4020-a5b6-66b70d0afbb9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "b828e516-c495-4b5e-adb5-3caa41fb3231" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "df715b76-4cf3-46f9-8850-aac5300375f1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 1, "df715b76-4cf3-46f9-8850-aac5300375f1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 17, 46, 903, DateTimeKind.Local), 19, "Molestias est est commodi consequatur qui.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 32, 15, 190, DateTimeKind.Local), 20, "Autem excepturi id facere aliquid voluptatem voluptas voluptatem officiis.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 32, 23, 780, DateTimeKind.Local), 15, "Dolorum est temporibus esse enim impedit enim veniam.", "666909a1-17b5-41af-8ccb-2e861a540155" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 0, 13, 37, 278, DateTimeKind.Local), 20, "Accusantium dolore voluptate veniam praesentium.", "df715b76-4cf3-46f9-8850-aac5300375f1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 16, 19, 829, DateTimeKind.Local), 18, "Dolorem fugiat fuga dolorum incidunt iure dolor.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 47, 32, 11, DateTimeKind.Local), 16, "Iste et sequi officia eius voluptatibus.", "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 21, 5, 28, 386, DateTimeKind.Local), 12, "Vitae voluptas consectetur esse voluptas perferendis sint.", "7883317d-40ed-441a-a54d-7bb483b1863d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 35, 0, 72, DateTimeKind.Local), 15, "Voluptatibus adipisci autem earum neque autem.", "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 24, 13, 222, DateTimeKind.Local), "Adipisci reprehenderit perferendis dolor sed explicabo qui et deleniti et.", "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 16, 45, 122, DateTimeKind.Local), 16, "Quas et quia ut quis eos voluptas est.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(861) 847-1235 x27376", "5cb4609d-26f4-4eda-971d-8c7e56136de3", "Eos accusamus quibusdam et a quam aut laborum eveniet.", "Kailey_Strosin99@gmail.com", "Company591", 66, "https://vada.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-800-794-1004", "7337fdcd-7e5f-4251-b92e-2646668d6715", "Beatae in minima et iure et sint iste.", "Kaela_Jast5@yahoo.com", "Company686", 66, "https://sienna.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "698-940-1784", "7337fdcd-7e5f-4251-b92e-2646668d6715", "Possimus blanditiis aut.", "Milan.Grimes@gmail.com", "Company552", 68, "https://kieran.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "848.934.5430", "df715b76-4cf3-46f9-8850-aac5300375f1", "Commodi vel aut inventore voluptatem et suscipit. Veniam eligendi totam molestiae vel. Et recusandae laborum illum voluptas voluptatum necessitatibus. Asperiores a perferendis ex dolor quis ut ut consequatur cum.", "Ethyl12@yahoo.com", "Company666", 67, "http://thurman.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "685-568-5156 x389", "5cb4609d-26f4-4eda-971d-8c7e56136de3", "Desmond58@hotmail.com", "Company10", 62, "https://shanie.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "289.719.5489", "7883317d-40ed-441a-a54d-7bb483b1863d", "Soluta nulla dolores neque aut. Nihil repellendus non quo reiciendis sed natus dolores. Expedita corporis omnis enim sit in quas molestias.", "Erik73@hotmail.com", "Company51", 67, "https://geovanni.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(478) 264-1173 x492", "2ec236a6-25a4-4dc5-8926-af73b29dd42c", "Explicabo expedita sed rerum. Suscipit aperiam ut ad. Dolorem quis harum qui aut. Atque architecto dolore ea.", "Hassie17@hotmail.com", "Company696", 70, "http://ardella.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "271-681-2545 x805", "2ec236a6-25a4-4dc5-8926-af73b29dd42c", "Ratione et saepe sapiente quos rerum aspernatur numquam doloremque et. Alias voluptatem ut maiores inventore sequi consequatur non impedit.", "Frances.Hartmann28@hotmail.com", "Company443", "http://margaret.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(834) 370-4937 x20192", "5cb4609d-26f4-4eda-971d-8c7e56136de3", "Optio aliquam ullam id est id. Cumque eos reprehenderit enim mollitia minima quis voluptatem.", "Barney_Osinski@gmail.com", "Company293", 62, "https://stanley.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-930-349-6511", "0260ccd0-3a37-4ed2-ab2f-543810027907", "Impedit pariatur cum sed voluptatem accusantium reprehenderit magnam.", "Lyda_Kihn79@yahoo.com", "Company540", 61, "https://lulu.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 20, 26, 287, DateTimeKind.Local), 49, "Iste et at consequatur nemo necessitatibus fuga sint.", "2ec236a6-25a4-4dc5-8926-af73b29dd42c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 19, 16, 1, 792, DateTimeKind.Local), 49, "Architecto facilis praesentium ut sit similique aut facilis mollitia.", "5cb4609d-26f4-4eda-971d-8c7e56136de3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 18, 6, 5, 245, DateTimeKind.Local), 42, "Minus repellendus est hic qui perferendis eveniet.", "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 11, 48, 1, 124, DateTimeKind.Local), 45, "Soluta at veritatis asperiores vel.", "666909a1-17b5-41af-8ccb-2e861a540155" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 23, 9, 597, DateTimeKind.Local), 45, "Molestias veritatis quam eos est qui voluptas maxime.", "666909a1-17b5-41af-8ccb-2e861a540155" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 16, 49, 903, DateTimeKind.Local), 42, "Doloribus omnis sunt aut eveniet similique reiciendis sed aut est.", "b828e516-c495-4b5e-adb5-3caa41fb3231" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 0, 56, 493, DateTimeKind.Local), 46, "Voluptatum quas sit voluptatem.", "5cb4609d-26f4-4eda-971d-8c7e56136de3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 18, 24, 851, DateTimeKind.Local), 47, "Aspernatur tempore consequatur qui.", "7337fdcd-7e5f-4251-b92e-2646668d6715" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 59, 0, 649, DateTimeKind.Local), 45, "Non ut id eum.", "0260ccd0-3a37-4ed2-ab2f-543810027907" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 35, 37, 219, DateTimeKind.Local), 48, "Atque et quia ut cum repellendus laboriosam aut reiciendis nihil.", "107ded11-f698-4020-a5b6-66b70d0afbb9" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "7883317d-40ed-441a-a54d-7bb483b1863d", 72, 1 },
                    { "7337fdcd-7e5f-4251-b92e-2646668d6715", 71, 1 },
                    { "df715b76-4cf3-46f9-8850-aac5300375f1", 71, 1 },
                    { "b828e516-c495-4b5e-adb5-3caa41fb3231", 77, 1 },
                    { "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8", 71, 1 },
                    { "2ec236a6-25a4-4dc5-8926-af73b29dd42c", 76, 1 },
                    { "666909a1-17b5-41af-8ccb-2e861a540155", 74, 1 },
                    { "0260ccd0-3a37-4ed2-ab2f-543810027907", 77, 1 },
                    { "107ded11-f698-4020-a5b6-66b70d0afbb9", 76, 1 },
                    { "5cb4609d-26f4-4eda-971d-8c7e56136de3", 79, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectorAppVersions");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0260ccd0-3a37-4ed2-ab2f-543810027907", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "107ded11-f698-4020-a5b6-66b70d0afbb9", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2ec236a6-25a4-4dc5-8926-af73b29dd42c", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5cb4609d-26f4-4eda-971d-8c7e56136de3", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "666909a1-17b5-41af-8ccb-2e861a540155", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7337fdcd-7e5f-4251-b92e-2646668d6715", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7883317d-40ed-441a-a54d-7bb483b1863d", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b828e516-c495-4b5e-adb5-3caa41fb3231", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "df715b76-4cf3-46f9-8850-aac5300375f1", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0260ccd0-3a37-4ed2-ab2f-543810027907");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "107ded11-f698-4020-a5b6-66b70d0afbb9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2ec236a6-25a4-4dc5-8926-af73b29dd42c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5cb4609d-26f4-4eda-971d-8c7e56136de3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "666909a1-17b5-41af-8ccb-2e861a540155");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7337fdcd-7e5f-4251-b92e-2646668d6715");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7883317d-40ed-441a-a54d-7bb483b1863d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b828e516-c495-4b5e-adb5-3caa41fb3231");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d77e6e28-4a33-4a48-8263-dbd1d4e1a7c8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "df715b76-4cf3-46f9-8850-aac5300375f1");

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
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 91, 37, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                column: "Threshold",
                value: 73);

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
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 98, 0 });

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
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 95, 57 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 93, 78 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 36, 59, 89, DateTimeKind.Local), 82, "Title712" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "54:bc:6c:85:e1:55", 78, "Instance802" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2d:74:0e:71:6f:7a", 76, "Instance819" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "Title" },
                values: new object[] { "04:d6:00:79:e3:b7", "Instance161" });

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
                columns: new[] { "Address", "Title" },
                values: new object[] { "5e:42:96:2e:00:e0", "Instance731" });

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
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "e7:0a:de:ee:bf:6e", 74, "Instance701" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "16:66:b1:ef:be:c1", 73, "Windows", "Instance831" });

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
                column: "Name",
                value: "Theme497");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme140" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme871" });

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
                column: "Name",
                value: "Theme326");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme509" });

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
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme292" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme180" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme513" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 18, 34, 36, 38, DateTimeKind.Local), "Sequi odit inventore unde quibusdam tempore voluptates consequuntur et.", "0da18978-1656-4b4d-ac10-940871d87e18", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 9, 10, 21, 58, 678, DateTimeKind.Local), "Quam culpa qui autem accusamus.", "0b22d062-92ae-494c-9481-11c2931737da", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 44, 26, 9, DateTimeKind.Local), "Nihil quia ad et odio et dolorem.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", true });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 9, 1, 15, 27, 632, DateTimeKind.Local), "Maiores dolor nihil earum suscipit at consectetur non et sunt.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 9, 16, 35, 21, 699, DateTimeKind.Local), "Minima natus unde dicta aspernatur earum deserunt sint tempora reprehenderit.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, false, "0bddde5f-5756-4d7f-8521-42d0476f3aa0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "0da18978-1656-4b4d-ac10-940871d87e18" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "14e7d6f2-3626-423b-959b-e8ca1b882173" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "0b22d062-92ae-494c-9481-11c2931737da" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, true, "6aa322ac-217f-449e-8ebf-12b4f2e2436c" });

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
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "632bbf3e-2c78-49fc-ad87-e2e5e93b02e1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "9a549b2b-8fd0-4d70-9145-569474fea109" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 23, 32, 536, DateTimeKind.Local), 13, "Officiis dolores dolores tenetur nesciunt.", "36410a7e-ff1b-4570-8a45-82e6d045bfda" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 57, 27, 602, DateTimeKind.Local), 18, "Quis sint beatae assumenda.", "0da18978-1656-4b4d-ac10-940871d87e18" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(204) 999-6677 x405", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c", "", "Domingo.Stiedemann@yahoo.com", "Company114", 67, "http://janis.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(440) 509-1684", "14e7d6f2-3626-423b-959b-e8ca1b882173", "", "Sofia_Schaefer8@hotmail.com", "Company613", 69, "http://lew.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "662.300.3345", "14e7d6f2-3626-423b-959b-e8ca1b882173", "Nostrum iusto voluptatem culpa ut.", "Madyson19@hotmail.com", "Company435", 68, "https://mose.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "614.292.9580 x822", "36410a7e-ff1b-4570-8a45-82e6d045bfda", "Alessandra.Heller42@gmail.com", "Company165", 67, "https://kamron.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-958-620-8119 x139", "0da18978-1656-4b4d-ac10-940871d87e18", "", "Elias.Schmeler76@yahoo.com", "Company221", 61, "http://bert.biz" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(938) 960-5637", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Quo consequatur vero sint ut autem aut doloremque ullam laborum. Rerum repellendus est qui sit rerum.", "Juliet_Powlowski@yahoo.com", "Company297", "https://josiane.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(732) 704-3028 x624", "0bddde5f-5756-4d7f-8521-42d0476f3aa0", "Id modi distinctio animi dolorem. Amet quia sint id harum exercitationem.", "Madison.Collins@yahoo.com", "Company179", 70, "http://orlo.name" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 54, 52, 111, DateTimeKind.Local), 46, "Omnis recusandae consectetur magnam provident explicabo.", "14e7d6f2-3626-423b-959b-e8ca1b882173" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 3, 44, 42, 883, DateTimeKind.Local), 49, "Id quia unde quae eveniet delectus ea.", "cd12165e-60bb-40a0-a6da-ee98a35e2a2c" });

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
