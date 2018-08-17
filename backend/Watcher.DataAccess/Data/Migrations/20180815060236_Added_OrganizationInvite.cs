using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Added_OrganizationInvite : Migration
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

            migrationBuilder.CreateTable(
                name: "OrganizationInvites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExperationDate = table.Column<DateTime>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationInvites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationInvites_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrganizationInvites_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 95, "MostLoaded2", "Common1", 87 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded3", "Common1", 100, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 97, "MostLoaded1", "Common2", 88 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", "Common3", "Source1", 26, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 97, "MostLoaded1", "Common1", 83 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", "Common3", 100, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded1", "Common1", "Source2", 73 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded1", "Common2", "Source3", 37 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", "Common1", "Source2", 70, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "Common1", "Source1", 32, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 4, 33, 30, 446, DateTimeKind.Local), 83, "Title612" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 11, 54, 626, DateTimeKind.Local), 89, "Title631" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 6, 43, 12, 86, DateTimeKind.Local), 86, "Title825" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 1, 54, 32, 735, DateTimeKind.Local), 83, "Title255" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 30, 4, 362, DateTimeKind.Local), 89, "Title860" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 7, 50, 646, DateTimeKind.Local), 85, "Title875" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 2, 54, 54, 744, DateTimeKind.Local), 85, "Title180" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 19, 10, 764, DateTimeKind.Local), 89, "Title533" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 11, 10, 47, 7, DateTimeKind.Local), 87, "Title406" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 53, 36, 962, DateTimeKind.Local), 88, "Title385" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "1e:fb:24:0a:f2:9e", 77 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "9d:61:8e:6c:ef:4e", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "87:94:01:b9:40:44", 73 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "84:bc:0c:5c:33:1e", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "42:ab:f2:40:a3:6c", 76, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "1a:62:3a:ea:cd:e7", 73 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "25:91:5c:8d:bf:6e", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "bc:61:86:36:92:3e", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                column: "Address",
                value: "15:ed:29:44:5c:f7");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "11:36:9e:de:0a:54", 80, "Windows" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme111" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme141" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme917" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme569" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme374" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme843" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme791" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme477" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme136");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme270" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "0decc678-4722-4c87-8f83-60585819ed9a", null, new DateTime(2018, 8, 14, 11, 59, 4, 850, DateTimeKind.Local), "Arvilla", "Terry_Skiles45@hotmail.com", "Elsa", true, "Smitham", null, 1 },
                    { "88f2de3e-70c2-456e-8dd6-73a2567f8fcd", null, new DateTime(2018, 8, 15, 0, 52, 51, 365, DateTimeKind.Local), "Alia", "Kareem_Haag21@yahoo.com", "Osvaldo", true, "Rodriguez", null, 1 },
                    { "224b945c-5404-4bb6-ae97-f066113c8ded", null, new DateTime(2018, 8, 14, 17, 7, 23, 237, DateTimeKind.Local), "Lauretta", "Freda_Medhurst@hotmail.com", "Elnora", true, "Heathcote", null, 2 },
                    { "57f36838-f431-4ef1-ade3-9b5a3d10435e", null, new DateTime(2018, 8, 15, 0, 1, 57, 819, DateTimeKind.Local), "Ayla", "Eliseo47@gmail.com", "Jacinto", true, "Pouros", null, 2 },
                    { "f211115d-c672-468a-bf02-00d805c1c9c1", null, new DateTime(2018, 8, 15, 4, 15, 2, 583, DateTimeKind.Local), "Kareem", "Virgie.Ankunding@hotmail.com", "Ansley", true, "Jakubowski", null, 2 },
                    { "92a63027-26d6-44b3-846e-17e4bd460156", null, new DateTime(2018, 8, 14, 21, 46, 18, 534, DateTimeKind.Local), "Unique", "Juston12@hotmail.com", "Olin", true, "Bergnaum", null, 1 },
                    { "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865", null, new DateTime(2018, 8, 15, 6, 28, 24, 853, DateTimeKind.Local), "Cristian", "Ericka.Bechtelar24@yahoo.com", "Elenor", true, "Rice", null, 2 },
                    { "46619219-9619-4d70-862d-7c039bc9d5a5", null, new DateTime(2018, 8, 15, 6, 11, 24, 805, DateTimeKind.Local), "Lenore", "Stephan_Schmitt35@yahoo.com", "Andres", true, "Skiles", null, 1 },
                    { "1bd314e2-35ea-40c2-a9bc-f32a88ff4226", null, new DateTime(2018, 8, 15, 6, 20, 48, 274, DateTimeKind.Local), "Agustin", "Nathan_Flatley@yahoo.com", "Jude", true, "Waelchi", null, 2 },
                    { "d25b8525-424f-42dd-8138-c6257173b2fc", null, new DateTime(2018, 8, 15, 7, 15, 42, 58, DateTimeKind.Local), "Hoyt", "Claudine_Cruickshank@yahoo.com", "Abagail", true, "Fay", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "92a63027-26d6-44b3-846e-17e4bd460156", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "57f36838-f431-4ef1-ade3-9b5a3d10435e", "id" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "224b945c-5404-4bb6-ae97-f066113c8ded", "ullam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d25b8525-424f-42dd-8138-c6257173b2fc", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865", "expedita" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f211115d-c672-468a-bf02-00d805c1c9c1", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "224b945c-5404-4bb6-ae97-f066113c8ded", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "57f36838-f431-4ef1-ade3-9b5a3d10435e", "dicta" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0decc678-4722-4c87-8f83-60585819ed9a", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "46619219-9619-4d70-862d-7c039bc9d5a5", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 30, 10, 174, DateTimeKind.Local), "Ut placeat doloremque suscipit similique cum occaecati voluptas enim.", "92a63027-26d6-44b3-846e-17e4bd460156" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 12, 45, 691, DateTimeKind.Local), "Qui vitae omnis qui exercitationem magnam earum ut excepturi.", "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 4, 36, 17, 455, DateTimeKind.Local), "Eos placeat et perferendis explicabo et ipsum.", "92a63027-26d6-44b3-846e-17e4bd460156" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 46, 46, 682, DateTimeKind.Local), "Dolores tenetur voluptatem soluta aut et totam.", "224b945c-5404-4bb6-ae97-f066113c8ded" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 0, 38, 26, 698, DateTimeKind.Local), "A dolore consequuntur repudiandae illum quam quidem et assumenda aspernatur.", "f211115d-c672-468a-bf02-00d805c1c9c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 14, 34, 28, 704, DateTimeKind.Local), "Molestiae rem illum.", "92a63027-26d6-44b3-846e-17e4bd460156" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 18, 35, 137, DateTimeKind.Local), "Nobis reprehenderit ea labore pariatur rerum dolorem et.", "224b945c-5404-4bb6-ae97-f066113c8ded" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 4, 18, 13, 288, DateTimeKind.Local), "Iusto sint sint voluptas facilis et fuga asperiores.", "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 9, 59, 4, 980, DateTimeKind.Local), "Iste esse molestiae aliquam facilis hic necessitatibus non nesciunt rem.", "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 8, 32, 39, 166, DateTimeKind.Local), "Excepturi mollitia aut minima delectus asperiores sint.", "57f36838-f431-4ef1-ade3-9b5a3d10435e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 15, 7, 40, 39, 853, DateTimeKind.Local), "Inventore omnis ut et.", "224b945c-5404-4bb6-ae97-f066113c8ded" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 16, 55, 21, 329, DateTimeKind.Local), "In est molestiae consequatur.", "1bd314e2-35ea-40c2-a9bc-f32a88ff4226", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 14, 16, 19, 34, 991, DateTimeKind.Local), "Sed suscipit ratione est sed labore ex alias.", "0decc678-4722-4c87-8f83-60585819ed9a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 14, 16, 8, 6, 687, DateTimeKind.Local), "Eum ut soluta quod.", "f211115d-c672-468a-bf02-00d805c1c9c1", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 14, 21, 8, 52, 527, DateTimeKind.Local), "Rerum libero deleniti tempora.", "f211115d-c672-468a-bf02-00d805c1c9c1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 15, 3, 17, 39, 374, DateTimeKind.Local), "Architecto earum enim et dignissimos quasi.", "92a63027-26d6-44b3-846e-17e4bd460156", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 14, 22, 30, 32, 589, DateTimeKind.Local), "Qui sint delectus magni non eveniet in consequuntur aspernatur officiis.", "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 15, 2, 14, 29, 87, DateTimeKind.Local), "Deleniti ipsum enim quibusdam vero rerum.", "88f2de3e-70c2-456e-8dd6-73a2567f8fcd" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 15, 0, 40, 23, 278, DateTimeKind.Local), "Voluptas ut est sit natus eaque saepe non totam consequatur.", "92a63027-26d6-44b3-846e-17e4bd460156" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 14, 12, 12, 0, 392, DateTimeKind.Local), "Maiores ea ut totam quas perferendis culpa asperiores deserunt labore.", "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, true, "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { true, "57f36838-f431-4ef1-ade3-9b5a3d10435e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 0, "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "0decc678-4722-4c87-8f83-60585819ed9a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { true, true, "88f2de3e-70c2-456e-8dd6-73a2567f8fcd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 4, "88f2de3e-70c2-456e-8dd6-73a2567f8fcd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 56, 27, 353, DateTimeKind.Local), 11, "Et numquam ipsum nesciunt non.", "57f36838-f431-4ef1-ade3-9b5a3d10435e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 11, 24, 44, 23, DateTimeKind.Local), 16, "Totam voluptatum qui nemo.", "f211115d-c672-468a-bf02-00d805c1c9c1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 35, 23, 632, DateTimeKind.Local), 15, "A fuga autem velit atque hic laudantium dolores quo.", "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 3, 8, 18, 602, DateTimeKind.Local), 16, "Beatae sed quaerat eum.", "1bd314e2-35ea-40c2-a9bc-f32a88ff4226" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 17, 12, 6, 498, DateTimeKind.Local), 17, "Consequuntur labore dolor necessitatibus aspernatur sunt.", "224b945c-5404-4bb6-ae97-f066113c8ded" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 0, 10, 47, 529, DateTimeKind.Local), 12, "Repellendus non necessitatibus.", "224b945c-5404-4bb6-ae97-f066113c8ded" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 6, 51, 7, 183, DateTimeKind.Local), 16, "Voluptatem ut impedit voluptatem.", "88f2de3e-70c2-456e-8dd6-73a2567f8fcd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 8, 40, 58, 893, DateTimeKind.Local), 19, "Fugit reprehenderit enim consectetur et expedita et.", "f211115d-c672-468a-bf02-00d805c1c9c1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 30, 42, 281, DateTimeKind.Local), 20, "Laborum enim eum vel aut necessitatibus.", "1bd314e2-35ea-40c2-a9bc-f32a88ff4226" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 7, 58, 1, 531, DateTimeKind.Local), 13, "Dolore impedit rerum beatae labore molestiae similique eum ea aperiam.", "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "802-895-5874", "224b945c-5404-4bb6-ae97-f066113c8ded", "Provident veritatis eveniet libero fuga sit quisquam aut. Voluptates similique consequatur officia qui illo a ratione sunt optio. Minima vel amet nisi aut soluta consequuntur aperiam id atque. Sit consequatur culpa non.", "Estefania_Beer@hotmail.com", "Company337", 62, "https://clovis.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(572) 670-3185 x598", "88f2de3e-70c2-456e-8dd6-73a2567f8fcd", "Excepturi quisquam eum quidem consequatur. Repellendus quibusdam quia velit. Velit sit consequatur voluptatem quia sunt aut expedita provident.", "Jarrod86@hotmail.com", "Company975", 68, "http://alaina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "718.636.2775 x8962", "57f36838-f431-4ef1-ade3-9b5a3d10435e", "Et totam recusandae ut sequi sed est. Et ex illum sit iure consectetur facere adipisci. Fuga qui et ipsum quis nihil nisi molestiae qui.", "Clair_Beier@gmail.com", "Company979", "http://cullen.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-790-580-3586 x107", "224b945c-5404-4bb6-ae97-f066113c8ded", "Qui omnis officia consequatur suscipit dolorem. Natus in placeat quo ut ut sit. Repudiandae reiciendis doloribus molestiae eos omnis quis soluta et. Quos temporibus nisi sunt ut natus.", "Wilfrid.Gorczany95@yahoo.com", "Company177", 64, "http://paige.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(275) 306-1087", "f211115d-c672-468a-bf02-00d805c1c9c1", "Beatae sunt molestiae voluptas aperiam voluptatem doloribus illo amet. Ut architecto maiores est eius repellat eligendi. Sit repudiandae vero in.", "Matt70@gmail.com", "Company465", 63, "http://rosemary.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-646-688-4036", "57f36838-f431-4ef1-ade3-9b5a3d10435e", "Voluptate voluptatum velit commodi id possimus nihil. Soluta animi consectetur eos illum itaque fugit et nobis modi. Tempora est et et ducimus labore iste neque inventore in.", "Seamus.Cormier@gmail.com", "Company703", 61, "https://rose.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "238-497-5416 x489", "92a63027-26d6-44b3-846e-17e4bd460156", "Consequuntur quae deserunt est excepturi quis quas natus. Sit sit porro a. Et consequuntur dicta vel et laborum sunt. Nihil dolore voluptatem nulla ut molestiae maiores quas est aut.", "Terry.Hyatt78@yahoo.com", "Company632", 62, "https://bruce.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(287) 653-4826 x23336", "57f36838-f431-4ef1-ade3-9b5a3d10435e", "Sunt facilis velit aut sit possimus provident. Eveniet deserunt perspiciatis consequatur fugit nostrum facere eaque.", "Jermaine49@gmail.com", "Company12", 63, "https://catharine.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "915.392.5288", "1bd314e2-35ea-40c2-a9bc-f32a88ff4226", "Quae fuga consequatur recusandae quo. Quis ducimus corporis asperiores. Esse et reprehenderit. Ut sed nulla.", "Jamar16@gmail.com", "Company250", 63, "http://kameron.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(571) 582-3311 x308", "46619219-9619-4d70-862d-7c039bc9d5a5", "", "Herta.Hodkiewicz@gmail.com", "Company723", "http://darius.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 11, 21, 509, DateTimeKind.Local), 49, "Nam iusto aut.", "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 12, 56, 27, 59, DateTimeKind.Local), 49, "Omnis nemo repellat est.", "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 9, 12, 30, 526, DateTimeKind.Local), 44, "Corporis debitis est ea sed tempora rem.", "d25b8525-424f-42dd-8138-c6257173b2fc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 4, 7, 59, 948, DateTimeKind.Local), "Id nisi accusantium.", "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 14, 8, 16, 186, DateTimeKind.Local), 44, "Ut omnis qui libero.", "88f2de3e-70c2-456e-8dd6-73a2567f8fcd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 1, 38, 13, 209, DateTimeKind.Local), 43, "Optio et molestiae at tempore et velit est nam sed.", "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 3, 17, 11, 152, DateTimeKind.Local), 47, "Consectetur odio alias eum id magnam pariatur facere aut.", "46619219-9619-4d70-862d-7c039bc9d5a5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 16, 53, 576, DateTimeKind.Local), 41, "Quae assumenda harum dicta quas quae nesciunt.", "1bd314e2-35ea-40c2-a9bc-f32a88ff4226" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 17, 14, 38, 591, DateTimeKind.Local), 41, "Expedita qui voluptate.", "57f36838-f431-4ef1-ade3-9b5a3d10435e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 10, 2, 34, 838, DateTimeKind.Local), "Ex asperiores molestias similique eum nam.", "57f36838-f431-4ef1-ade3-9b5a3d10435e" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f211115d-c672-468a-bf02-00d805c1c9c1", 77 },
                    { "46619219-9619-4d70-862d-7c039bc9d5a5", 75 },
                    { "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865", 72 },
                    { "92a63027-26d6-44b3-846e-17e4bd460156", 74 },
                    { "57f36838-f431-4ef1-ade3-9b5a3d10435e", 71 },
                    { "224b945c-5404-4bb6-ae97-f066113c8ded", 74 },
                    { "88f2de3e-70c2-456e-8dd6-73a2567f8fcd", 72 },
                    { "0decc678-4722-4c87-8f83-60585819ed9a", 79 },
                    { "1bd314e2-35ea-40c2-a9bc-f32a88ff4226", 75 },
                    { "d25b8525-424f-42dd-8138-c6257173b2fc", 75 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_CreatedByUserId",
                table: "OrganizationInvites",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationInvites_OrganizationId",
                table: "OrganizationInvites",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationInvites");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0decc678-4722-4c87-8f83-60585819ed9a", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1bd314e2-35ea-40c2-a9bc-f32a88ff4226", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "224b945c-5404-4bb6-ae97-f066113c8ded", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "46619219-9619-4d70-862d-7c039bc9d5a5", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "57f36838-f431-4ef1-ade3-9b5a3d10435e", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "88f2de3e-70c2-456e-8dd6-73a2567f8fcd", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "92a63027-26d6-44b3-846e-17e4bd460156", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d25b8525-424f-42dd-8138-c6257173b2fc", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f211115d-c672-468a-bf02-00d805c1c9c1", 77 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0decc678-4722-4c87-8f83-60585819ed9a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1bd314e2-35ea-40c2-a9bc-f32a88ff4226");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "224b945c-5404-4bb6-ae97-f066113c8ded");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bd9b215-8fdb-4fa2-ad74-20dc2ce11865");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "46619219-9619-4d70-862d-7c039bc9d5a5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "57f36838-f431-4ef1-ade3-9b5a3d10435e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "88f2de3e-70c2-456e-8dd6-73a2567f8fcd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "92a63027-26d6-44b3-846e-17e4bd460156");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d25b8525-424f-42dd-8138-c6257173b2fc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f211115d-c672-468a-bf02-00d805c1c9c1");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 92, "MostLoaded3", "Common3", 40 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Common3", 62, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 96, "MostLoaded2", "Common3", 71 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", "Common1", "Source3", 78, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { 95, "MostLoaded2", "Common2", 4 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { "MostLoaded2", "Common1", 54, 2 });

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
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 91, "MostLoaded3", "Common1", "Source1", 24 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Common2", "Source3", 31, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common3", "Source2", 92, 1 });

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
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e6:f1:d2:92:f4:39", 80 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "69:aa:13:38:70:91", 74, "Windows" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e8:32:37:65:ff:0d", 79, "Windows" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "e5:51:e3:82:13:28", 74, "Windows" });

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
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "f8:5c:43:74:04:03", 73, "Linux" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme75" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme832" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme779" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme603" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme765" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme115" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Theme313");

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
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e55cc846-c35c-4068-a96e-7e4d3a350a11", "ut" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 12, 1, 30, 58, 839, DateTimeKind.Local), "In delectus eos quas consequuntur rerum.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 8, 11, 18, 25, 39, 229, DateTimeKind.Local), "Quasi adipisci illum vitae repellat iure temporibus molestiae qui quia.", "e55cc846-c35c-4068-a96e-7e4d3a350a11", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 12, 10, 16, 39, 17, DateTimeKind.Local), "Ut eum corrupti voluptatem veniam.", "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 12, 9, 8, 1, 935, DateTimeKind.Local), "Sit facilis culpa illum consequatur omnis officia dolores aperiam est.", "68ed0dc9-00df-4e70-8fab-7a6b1d996b50" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 11, 17, 6, 10, 925, DateTimeKind.Local), "Enim sint consectetur ut quae culpa consequatur.", "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 12, 12, 8, 7, 721, DateTimeKind.Local), "Ut blanditiis amet delectus ea voluptate quia voluptatibus maxime non.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, false, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "8af174fd-45ab-44b1-b756-61b08b4e54fb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "UserId" },
                values: new object[] { false, "e55cc846-c35c-4068-a96e-7e4d3a350a11" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 1, "a5001d94-a4ad-40d8-a333-9dc16a882630" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "34a73032-25cd-4e18-8078-ec7e1280ddfe" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsMute", "UserId" },
                values: new object[] { false, false, "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 0, "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 0, "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(527) 866-4742", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d", "A perspiciatis beatae nisi necessitatibus iste natus eveniet. Inventore aliquam qui recusandae quisquam sit animi officiis.", "Thea60@yahoo.com", "Company668", "https://tania.com" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-354-461-4062", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0", "Nesciunt nihil odit vero est dolor maiores qui ut. Et perferendis perferendis quo veritatis labore voluptatibus libero non et. Ut excepturi voluptates quidem nostrum sit recusandae omnis.", "Zane63@hotmail.com", "Company511", "http://graciela.biz" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 14, 40, 8, 374, DateTimeKind.Local), 43, "Sit suscipit tempore libero esse et corporis quo.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 2, 45, 39, 871, DateTimeKind.Local), "Voluptas qui saepe voluptatibus sapiente molestias hic repudiandae dolorum.", "3d092db0-7b72-4313-af6b-f4fdf12c5f7d" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 11, 16, 5, 29, 108, DateTimeKind.Local), 44, "Velit dolorum ullam amet maxime dolores.", "d6d7f157-c67a-46b7-a918-79f5a4e9a5b0" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 12, 1, 37, 19, 431, DateTimeKind.Local), "Unde quis nulla rerum assumenda ducimus assumenda mollitia.", "5c8ec0eb-c030-497f-9977-ff1d7c9021e4" });

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
