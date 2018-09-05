using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class RoleinUserOrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "307ee358-2383-4f80-b94f-26f489bdb30f", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4740e1d3-a664-49cf-bde9-24133792f2d8", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "52e27198-436d-4714-a6e7-e0d0738b847f", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "89babdf6-31d6-45d2-a725-16c5e80ea915", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b3731d39-39d1-491c-950b-719b0606e9c5", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", 72 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "307ee358-2383-4f80-b94f-26f489bdb30f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45e74407-0146-4659-a4f6-de7d7c0d0b9b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4740e1d3-a664-49cf-bde9-24133792f2d8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52e27198-436d-4714-a6e7-e0d0738b847f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "89babdf6-31d6-45d2-a725-16c5e80ea915");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8ce60506-64fa-4b47-a167-f77a2bbe46bc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b3731d39-39d1-491c-950b-719b0606e9c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b57b3a69-a3c9-4efd-b242-0fc6b368ff92");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d59c9c41-ee13-42c2-adf8-862e5ada2a81");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationRoleId",
                table: "UserOrganizations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", 18, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 61, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 36, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 51, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 96, 30 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 99, 26, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 42, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", 18, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded1", 74, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded1", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 56, 42, 276, DateTimeKind.Local), 88, "Title380" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 21, 40, 648, DateTimeKind.Local), 87, "Title190" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 26, 0, 448, DateTimeKind.Local), 85, "Title26" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 16, 17, 830, DateTimeKind.Local), 90, "Title594" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 22, 30, 851, DateTimeKind.Local), 90, "Title749" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 23, 55, 773, DateTimeKind.Local), 85, "Title971" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 48, 32, 301, DateTimeKind.Local), 84, "Title341" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 24, 19, 107, DateTimeKind.Local), 86, "Title100" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 9, 56, 497, DateTimeKind.Local), 83, "Title485" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 2, 51, 848, DateTimeKind.Local), 85, "Title494" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "44:04:89:e9:67:1e", 75, "Instance737" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "63:18:f5:60:46:05", 78, "Windows", "Instance265" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cd:fb:79:7f:24:12", 71, "Linux", "Instance731" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "88:a6:ae:0f:88:bd", 80, "Windows", "Instance72" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "fa:b7:85:16:5e:1e", 71, "Linux", "Instance422" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "da:b0:61:9b:ae:49", 76, "Linux", "Instance732" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0a:50:61:23:f4:bd", 75, "Windows", "Instance771" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "0a:d4:14:9a:26:16", 75, "Instance841" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Title" },
                values: new object[] { "fc:57:62:68:45:d7", "Instance125" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "31:f0:1d:17:16:a9", 74, "Windows", "Instance379" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme328" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme178" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme681" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme633" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme796" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme129" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme524" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme155" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme947" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme503" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", null, new DateTime(2018, 9, 5, 9, 7, 45, 325, DateTimeKind.Local), "Samir", "Keven.Huels25@hotmail.com", null, "Ryder", true, false, "Leffler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mbilalsiddique1/128.jpg", 1 },
                    { "3d9eb87f-4749-4005-8cc9-25b6953fb19b", null, new DateTime(2018, 9, 5, 6, 43, 25, 722, DateTimeKind.Local), "Sebastian", "Thomas.Kuhlman@gmail.com", null, "Ryder", true, false, "Gerlach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bryan_topham/128.jpg", 2 },
                    { "be796db7-8c5e-479f-9abe-b56640fadb97", null, new DateTime(2018, 9, 5, 7, 25, 39, 68, DateTimeKind.Local), "Guiseppe", "Tyree.Shields@yahoo.com", null, "Isabel", true, false, "Reichel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/missaaamy/128.jpg", 1 },
                    { "070ce34b-78ab-4ea8-8cc4-75827807a291", null, new DateTime(2018, 9, 5, 5, 30, 29, 820, DateTimeKind.Local), "Monica", "Luella5@gmail.com", null, "Lelah", true, false, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dc_user/128.jpg", 1 },
                    { "64019e2c-eb99-4670-9fd4-b5a7e22942ae", null, new DateTime(2018, 9, 5, 0, 51, 12, 329, DateTimeKind.Local), "Daryl", "Delbert.Crona98@hotmail.com", null, "Mathew", true, false, "Reynolds", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidmerrique/128.jpg", 2 },
                    { "9678e087-46f4-48fb-a30d-c977325deaf6", null, new DateTime(2018, 9, 4, 18, 14, 57, 460, DateTimeKind.Local), "Casper", "Rene_Macejkovic28@hotmail.com", null, "Hector", true, false, "Yost", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vikasvinfotech/128.jpg", 2 },
                    { "dea38051-7ab5-4de2-a554-ab9902007f03", null, new DateTime(2018, 9, 5, 7, 5, 31, 986, DateTimeKind.Local), "Monroe", "Cara.Effertz@hotmail.com", null, "Issac", true, false, "Howe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/rawdiggie/128.jpg", 1 },
                    { "70969be4-d59d-4c34-aa3f-af71656108c4", null, new DateTime(2018, 9, 4, 22, 25, 27, 210, DateTimeKind.Local), "Claudie", "Ena.Rogahn35@yahoo.com", null, "Marcia", true, false, "Hoeger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joshhemsley/128.jpg", 1 },
                    { "497eb796-037e-483e-a6da-46d34451db3a", null, new DateTime(2018, 9, 4, 16, 19, 20, 859, DateTimeKind.Local), "Mae", "Jennyfer_Howe@gmail.com", null, "Cornell", true, false, "Kreiger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/thimo_cz/128.jpg", 2 },
                    { "92ac698a-a117-446e-9d22-e1fd66cc2106", null, new DateTime(2018, 9, 5, 11, 0, 55, 567, DateTimeKind.Local), "Hillard", "Tomas40@hotmail.com", null, "Eliseo", true, false, "Stokes", null, "https://s3.amazonaws.com/uifaces/faces/twitter/polarity/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "dea38051-7ab5-4de2-a554-ab9902007f03", "fugiat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "70969be4-d59d-4c34-aa3f-af71656108c4", "quam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "70969be4-d59d-4c34-aa3f-af71656108c4", "dolorum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "70969be4-d59d-4c34-aa3f-af71656108c4", "animi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9678e087-46f4-48fb-a30d-c977325deaf6", "aliquam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9678e087-46f4-48fb-a30d-c977325deaf6", "nemo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d9eb87f-4749-4005-8cc9-25b6953fb19b", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9678e087-46f4-48fb-a30d-c977325deaf6", "hic" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "be796db7-8c5e-479f-9abe-b56640fadb97", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "be796db7-8c5e-479f-9abe-b56640fadb97", "vel" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 24, 0, 613, DateTimeKind.Local), "Ratione quis cumque vitae dolorum.", "3d9eb87f-4749-4005-8cc9-25b6953fb19b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 1, 14, 20, 536, DateTimeKind.Local), "Expedita officia eum odit ratione laborum ducimus eveniet.", "dea38051-7ab5-4de2-a554-ab9902007f03" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 20, 25, 19, 949, DateTimeKind.Local), "Labore quae autem laudantium ut omnis omnis.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 0, 23, 577, DateTimeKind.Local), "Et exercitationem minus exercitationem laboriosam mollitia fugit veniam et et.", "9678e087-46f4-48fb-a30d-c977325deaf6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 1, 30, 36, 675, DateTimeKind.Local), "Ea libero repudiandae odio.", "dea38051-7ab5-4de2-a554-ab9902007f03" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 42, 42, 690, DateTimeKind.Local), "Autem similique assumenda architecto atque tempora est qui aliquid.", "497eb796-037e-483e-a6da-46d34451db3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 43, 29, 575, DateTimeKind.Local), "Totam quisquam alias nostrum explicabo vel consequatur.", "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 37, 6, 239, DateTimeKind.Local), "Tempore quasi facilis cum repudiandae perferendis quibusdam.", "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 15, 41, 301, DateTimeKind.Local), "Quasi necessitatibus eos dicta non.", "497eb796-037e-483e-a6da-46d34451db3a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 43, 10, 264, DateTimeKind.Local), "Dolorem nostrum non.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 30, new DateTime(2018, 9, 5, 4, 48, 13, 493, DateTimeKind.Local), "Nam dolorem nobis asperiores nisi quia.", "92ac698a-a117-446e-9d22-e1fd66cc2106", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 4, 22, 55, 33, 727, DateTimeKind.Local), "Voluptatum facere sint perferendis vero.", "dea38051-7ab5-4de2-a554-ab9902007f03", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 46, 59, 864, DateTimeKind.Local), "Aliquam vel sapiente necessitatibus vel voluptatem doloremque voluptatibus debitis.", "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 4, 19, 26, 6, 345, DateTimeKind.Local), "Vel id quo ad.", "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 5, 11, 0, 30, 760, DateTimeKind.Local), "Delectus veritatis nihil animi itaque nam molestiae.", "9678e087-46f4-48fb-a30d-c977325deaf6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 5, 12, 29, 51, 971, DateTimeKind.Local), "Dignissimos quisquam aut provident consequatur autem.", "be796db7-8c5e-479f-9abe-b56640fadb97", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 46, 47, 827, DateTimeKind.Local), "Velit ut velit quia possimus.", "64019e2c-eb99-4670-9fd4-b5a7e22942ae" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 4, 19, 56, 47, 915, DateTimeKind.Local), "Aut repellat eum iure porro sunt voluptatem ducimus perferendis aut.", "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 4, 15, 18, 59, 250, DateTimeKind.Local), "Laborum maxime in.", "be796db7-8c5e-479f-9abe-b56640fadb97", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 2, 55, 39, 632, DateTimeKind.Local), "Repellendus perferendis aliquam quod perspiciatis tempore minima veniam eligendi.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "92ac698a-a117-446e-9d22-e1fd66cc2106" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "64019e2c-eb99-4670-9fd4-b5a7e22942ae" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "070ce34b-78ab-4ea8-8cc4-75827807a291" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "92ac698a-a117-446e-9d22-e1fd66cc2106" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, false, "497eb796-037e-483e-a6da-46d34451db3a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "9678e087-46f4-48fb-a30d-c977325deaf6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "92ac698a-a117-446e-9d22-e1fd66cc2106" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "92ac698a-a117-446e-9d22-e1fd66cc2106" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 3, "64019e2c-eb99-4670-9fd4-b5a7e22942ae" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 8, 48, 749, DateTimeKind.Local), 20, "Suscipit hic quia ratione.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 22, 51, 914, DateTimeKind.Local), 20, "Tempora rerum earum tempore magni id non.", "3d9eb87f-4749-4005-8cc9-25b6953fb19b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 32, 19, 290, DateTimeKind.Local), 16, "Rerum eos sit quidem.", "3d9eb87f-4749-4005-8cc9-25b6953fb19b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 1, 32, 68, DateTimeKind.Local), 15, "Sapiente eum qui eius praesentium dolor.", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 59, 27, 80, DateTimeKind.Local), 16, "Odit esse et eligendi enim placeat.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 43, 34, 595, DateTimeKind.Local), 17, "Rem quam ipsa voluptatibus.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 38, 6, 246, DateTimeKind.Local), 19, "Voluptatem enim sit.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 19, 20, 104, DateTimeKind.Local), 12, "Modi dicta quam atque dolores praesentium sint ducimus voluptas eaque.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 10, 8, 904, DateTimeKind.Local), 15, "Et unde ratione fuga consequatur aut ut laboriosam neque.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 0, 7, 267, DateTimeKind.Local), 17, "Recusandae ipsum magnam dicta et odit quisquam.", "dea38051-7ab5-4de2-a554-ab9902007f03" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(766) 300-3104 x21580", "3d9eb87f-4749-4005-8cc9-25b6953fb19b", "Et expedita autem libero alias quo qui et sit deleniti.", "Makenna47@gmail.com", "Company395", 65, "https://sallie.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "290-914-6807 x612", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "Et ducimus praesentium aspernatur. Culpa tempora quo. Aut ipsum fugit enim perspiciatis aperiam.", "Anika3@gmail.com", "Company612", 68, "http://carey.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-283-506-5806 x8824", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "Suscipit quis ut.", "Matt_Bartell5@gmail.com", "Company766", 67, "http://marcellus.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-343-937-2841 x61434", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "Tenetur porro delectus in aperiam architecto. Sit officiis eveniet omnis.", "Isaiah_Kuvalis@hotmail.com", "Company876", 69, "http://amari.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-552-625-0003", "70969be4-d59d-4c34-aa3f-af71656108c4", "Placeat molestias aut saepe voluptas. Praesentium accusamus cumque pariatur rerum.", "Tess3@hotmail.com", "Company384", 67, "https://margarita.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "673-984-9486 x146", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "Quas numquam optio velit provident a quod perspiciatis.", "Brielle.Kuphal@yahoo.com", "Company249", 61, "http://rowland.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "602-391-9900 x077", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "", "Orval89@yahoo.com", "Company400", 65, "http://marilyne.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "599.403.9061 x678", "070ce34b-78ab-4ea8-8cc4-75827807a291", "Delectus consequatur velit quibusdam porro adipisci id praesentium consequatur non. Perferendis eos at officia cum ut et.", "Reese.Hoppe44@yahoo.com", "Company437", "https://floyd.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(283) 803-5937 x7975", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", "Tempora vitae occaecati.", "Marge98@gmail.com", "Company844", 63, "https://deja.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "351-605-5395", "9678e087-46f4-48fb-a30d-c977325deaf6", "Ab quaerat ea quia adipisci quia possimus eligendi est. Quam unde et possimus occaecati et dolorem dolore velit. Repellendus in omnis eius. Fugit consequatur nobis.", "Percival.Goldner@gmail.com", "Company459", 62, "https://cortez.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 3, 47, 118, DateTimeKind.Local), 47, "Explicabo voluptate ex autem illum.", "70969be4-d59d-4c34-aa3f-af71656108c4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 29, 40, 94, DateTimeKind.Local), 50, "Quia eveniet cumque molestiae aut enim possimus.", "92ac698a-a117-446e-9d22-e1fd66cc2106" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 22, 32, 60, DateTimeKind.Local), 41, "Excepturi in qui repudiandae omnis iusto alias.", "3d9eb87f-4749-4005-8cc9-25b6953fb19b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 20, 59, 48, 565, DateTimeKind.Local), 45, "Fugit veniam nemo culpa quas distinctio quam dolorum.", "9678e087-46f4-48fb-a30d-c977325deaf6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 29, 23, 247, DateTimeKind.Local), 41, "Sapiente consectetur dolorem incidunt consequatur quibusdam.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 4, 3, 265, DateTimeKind.Local), 45, "Adipisci qui occaecati dolorem odio laborum eum.", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 45, 37, 855, DateTimeKind.Local), 43, "Corrupti dolor esse sed tempora consequatur.", "dea38051-7ab5-4de2-a554-ab9902007f03" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 38, 37, 765, DateTimeKind.Local), "Illo sunt consectetur dolorum est.", "be796db7-8c5e-479f-9abe-b56640fadb97" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 8, 24, 33, 321, DateTimeKind.Local), 46, "Consequuntur omnis cum cupiditate sunt atque veritatis soluta eius aut.", "6f93a171-b5f1-4689-949c-3c2cbd0bdedd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 7, 43, 356, DateTimeKind.Local), 48, "Molestiae voluptatum voluptate velit aut omnis doloribus ut distinctio quo.", "3d9eb87f-4749-4005-8cc9-25b6953fb19b" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "070ce34b-78ab-4ea8-8cc4-75827807a291", 79, 1 },
                    { "be796db7-8c5e-479f-9abe-b56640fadb97", 77, 1 },
                    { "9678e087-46f4-48fb-a30d-c977325deaf6", 73, 1 },
                    { "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", 73, 1 },
                    { "64019e2c-eb99-4670-9fd4-b5a7e22942ae", 79, 1 },
                    { "70969be4-d59d-4c34-aa3f-af71656108c4", 72, 1 },
                    { "dea38051-7ab5-4de2-a554-ab9902007f03", 79, 1 },
                    { "3d9eb87f-4749-4005-8cc9-25b6953fb19b", 71, 1 },
                    { "497eb796-037e-483e-a6da-46d34451db3a", 79, 1 },
                    { "92ac698a-a117-446e-9d22-e1fd66cc2106", 75, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_OrganizationRoles_OrganizationRoleId",
                table: "UserOrganizations",
                column: "OrganizationRoleId",
                principalTable: "OrganizationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganizations_OrganizationRoles_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DropIndex(
                name: "IX_UserOrganizations_OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "070ce34b-78ab-4ea8-8cc4-75827807a291", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3d9eb87f-4749-4005-8cc9-25b6953fb19b", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "497eb796-037e-483e-a6da-46d34451db3a", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "64019e2c-eb99-4670-9fd4-b5a7e22942ae", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6f93a171-b5f1-4689-949c-3c2cbd0bdedd", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "70969be4-d59d-4c34-aa3f-af71656108c4", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "92ac698a-a117-446e-9d22-e1fd66cc2106", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9678e087-46f4-48fb-a30d-c977325deaf6", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "be796db7-8c5e-479f-9abe-b56640fadb97", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "dea38051-7ab5-4de2-a554-ab9902007f03", 79 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "070ce34b-78ab-4ea8-8cc4-75827807a291");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d9eb87f-4749-4005-8cc9-25b6953fb19b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "497eb796-037e-483e-a6da-46d34451db3a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "64019e2c-eb99-4670-9fd4-b5a7e22942ae");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6f93a171-b5f1-4689-949c-3c2cbd0bdedd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "70969be4-d59d-4c34-aa3f-af71656108c4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "92ac698a-a117-446e-9d22-e1fd66cc2106");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9678e087-46f4-48fb-a30d-c977325deaf6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "be796db7-8c5e-479f-9abe-b56640fadb97");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dea38051-7ab5-4de2-a554-ab9902007f03");

            migrationBuilder.DropColumn(
                name: "OrganizationRoleId",
                table: "UserOrganizations");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded1", 43, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 99, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 49, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 99, 20 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 92, 42, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 94, 66, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", 56, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", 65, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "MostLoaded", "Threshold", "Type" },
                values: new object[] { "MostLoaded3", 66, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 6, 43, 47, 22, DateTimeKind.Local), 89, "Title556" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 4, 39, 669, DateTimeKind.Local), 89, "Title712" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 52, 40, 361, DateTimeKind.Local), 89, "Title656" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 22, 19, 518, DateTimeKind.Local), 87, "Title746" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 10, 17, 995, DateTimeKind.Local), 87, "Title906" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 32, 29, 301, DateTimeKind.Local), 90, "Title745" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 19, 38, 8, DateTimeKind.Local), 88, "Title101" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 24, 4, 133, DateTimeKind.Local), 87, "Title940" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 26, 51, 702, DateTimeKind.Local), 89, "Title868" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 24, 44, 677, DateTimeKind.Local), 87, "Title17" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "61:d7:d8:5f:a4:61", 73, "Instance361" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "70:53:49:f9:b8:1c", 74, "Linux", "Instance960" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e3:bd:e5:dc:2a:a1", 72, "Windows", "Instance320" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ec:2e:59:8e:d1:6f", 71, "Linux", "Instance840" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "47:7d:20:a1:8c:dc", 75, "Windows", "Instance784" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e0:26:e3:79:24:a3", 80, "Windows", "Instance773" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3d:8a:bd:92:33:41", 80, "Linux", "Instance209" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "08:38:5e:d9:9b:65", 77, "Instance157" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Title" },
                values: new object[] { "2f:cc:eb:fe:82:c6", "Instance311" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "7c:17:e5:c5:3a:bd", 78, "Linux", "Instance415" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme611" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme432" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme107" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme533" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme25" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme104" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme439" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme199" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme68" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme338" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", null, new DateTime(2018, 9, 5, 0, 14, 16, 920, DateTimeKind.Local), "Ulices", "Ayla.Lebsack@gmail.com", null, "Salvatore", true, false, "Grant", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ZacharyZorbas/128.jpg", 1 },
                    { "89babdf6-31d6-45d2-a725-16c5e80ea915", null, new DateTime(2018, 9, 4, 21, 12, 16, 512, DateTimeKind.Local), "Ottis", "Quinton.Jakubowski90@gmail.com", null, "Nils", true, false, "Bogan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/justinrob/128.jpg", 2 },
                    { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", null, new DateTime(2018, 9, 5, 10, 52, 38, 973, DateTimeKind.Local), "Leopoldo", "Yesenia_Will16@gmail.com", null, "Xander", true, false, "Mohr", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidbaldie/128.jpg", 2 },
                    { "52e27198-436d-4714-a6e7-e0d0738b847f", null, new DateTime(2018, 9, 5, 6, 32, 42, 645, DateTimeKind.Local), "Jerrell", "King_Eichmann67@hotmail.com", null, "Adeline", true, false, "Hoppe", null, "https://s3.amazonaws.com/uifaces/faces/twitter/roybarberuk/128.jpg", 1 },
                    { "b3731d39-39d1-491c-950b-719b0606e9c5", null, new DateTime(2018, 9, 4, 18, 59, 44, 682, DateTimeKind.Local), "Alexzander", "Werner_Beer@yahoo.com", null, "Chauncey", true, false, "Hegmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/brenton_clarke/128.jpg", 2 },
                    { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", null, new DateTime(2018, 9, 4, 14, 38, 53, 519, DateTimeKind.Local), "Gracie", "Alysa_Hammes@yahoo.com", null, "Maiya", true, false, "Kuhic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jomarmen/128.jpg", 2 },
                    { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", null, new DateTime(2018, 9, 5, 6, 25, 27, 120, DateTimeKind.Local), "Tabitha", "Marcellus_Paucek82@hotmail.com", null, "Carolanne", true, false, "Johnson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vivekprvr/128.jpg", 1 },
                    { "4740e1d3-a664-49cf-bde9-24133792f2d8", null, new DateTime(2018, 9, 5, 3, 33, 17, 365, DateTimeKind.Local), "Theo", "Aglae.Brekke61@gmail.com", null, "Ubaldo", true, false, "Nitzsche", null, "https://s3.amazonaws.com/uifaces/faces/twitter/giancarlon/128.jpg", 2 },
                    { "307ee358-2383-4f80-b94f-26f489bdb30f", null, new DateTime(2018, 9, 5, 9, 25, 18, 97, DateTimeKind.Local), "Melisa", "Idell95@hotmail.com", null, "Herta", true, false, "Daugherty", null, "https://s3.amazonaws.com/uifaces/faces/twitter/pierrestoffe/128.jpg", 1 },
                    { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", null, new DateTime(2018, 9, 5, 5, 15, 55, 959, DateTimeKind.Local), "Yasmine", "Retta95@yahoo.com", null, "Leta", true, false, "Marks", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sindresorhus/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", "possimus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "in" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "307ee358-2383-4f80-b94f-26f489bdb30f", "voluptate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", "ea" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52e27198-436d-4714-a6e7-e0d0738b847f", "alias" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b3731d39-39d1-491c-950b-719b0606e9c5", "mollitia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "89babdf6-31d6-45d2-a725-16c5e80ea915", "omnis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 59, 20, 95, DateTimeKind.Local), "Magnam repellendus est suscipit cupiditate molestiae ad molestias.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 6, 16, 212, DateTimeKind.Local), "Eaque dolor amet.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 17, 24, 56, 906, DateTimeKind.Local), "Alias qui pariatur iusto.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 21, 10, 32, 102, DateTimeKind.Local), "Ea rerum assumenda perferendis ut.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 27, 57, 402, DateTimeKind.Local), "In rerum repellendus possimus hic aut suscipit nisi numquam.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 18, 58, 19, 102, DateTimeKind.Local), "Laborum voluptates quae.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 23, 55, 2, 510, DateTimeKind.Local), "Necessitatibus eius labore velit adipisci ea eum aliquid recusandae.", "89babdf6-31d6-45d2-a725-16c5e80ea915" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 16, 17, 46, 648, DateTimeKind.Local), "Delectus totam illo adipisci rerum.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 2, 19, 7, 612, DateTimeKind.Local), "Cum architecto libero.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 8, 28, 595, DateTimeKind.Local), "Quasi molestiae nobis dolores eveniet.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 4, 21, 19, 55, 38, DateTimeKind.Local), "Odit ipsum magni eum est delectus.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 13, 14, 42, 109, DateTimeKind.Local), "Ut in et aperiam aut rem ullam ipsa iusto.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 22, 32, 910, DateTimeKind.Local), "Est temporibus deserunt repellat.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 10, 36, 8, 508, DateTimeKind.Local), "Est et enim dolor beatae quisquam.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 5, 10, 49, 51, 602, DateTimeKind.Local), "Quia eos qui et.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 6, 33, 39, 8, DateTimeKind.Local), "Impedit vitae voluptatem est nam eaque dolor est.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 36, 26, 423, DateTimeKind.Local), "Molestiae delectus delectus cumque exercitationem modi quia.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 4, 20, 2, 47, 147, DateTimeKind.Local), "Eaque repellendus reprehenderit sapiente aliquid.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 5, 1, 59, 37, 774, DateTimeKind.Local), "Similique sint nam excepturi eaque perspiciatis animi ducimus eos.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 5, 8, 28, 47, 861, DateTimeKind.Local), "Nam rerum eum ut in rem.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "b3731d39-39d1-491c-950b-719b0606e9c5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, true, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 4, "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 13, 27, 49, 68, DateTimeKind.Local), 12, "Soluta harum beatae esse quod enim occaecati illum voluptas.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 45, 39, 412, DateTimeKind.Local), 17, "Omnis dolores officia sapiente recusandae dignissimos veniam similique quidem eligendi.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 3, 59, 52, 324, DateTimeKind.Local), 20, "Doloribus cupiditate officia magnam laudantium.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 21, 21, 456, DateTimeKind.Local), 18, "Minima velit dignissimos magnam est et eos beatae beatae.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 57, 25, 749, DateTimeKind.Local), 20, "Quasi accusamus vel adipisci veniam ut quae earum voluptas.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 22, 25, 14, 44, DateTimeKind.Local), 16, "Exercitationem aliquam voluptas odit est rerum repellendus.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 20, 6, 50, 697, DateTimeKind.Local), 16, "Consectetur deserunt tenetur est et tempore.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 10, 45, 49, 436, DateTimeKind.Local), 20, "Qui porro iusto ut.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 34, 16, 876, DateTimeKind.Local), 13, "Hic autem in nostrum nesciunt quia est ipsam aut accusamus.", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 25, 39, 387, DateTimeKind.Local), 14, "Ipsam voluptas consequatur est enim enim quia et ullam.", "52e27198-436d-4714-a6e7-e0d0738b847f" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "334-328-8431", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", "", "Chanel_Kuhn63@yahoo.com", "Company414", 69, "https://rey.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "894.531.1390 x3861", "45e74407-0146-4659-a4f6-de7d7c0d0b9b", "Molestiae fugiat exercitationem veniam quia placeat minima. Alias quae impedit cum porro enim. Voluptas eveniet in laborum aut repudiandae. Voluptatem sit aut aut harum at.", "Thomas24@yahoo.com", "Company4", 62, "https://freeda.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "544-466-5590 x515", "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", "Fugit enim consequatur fugit nihil illum aut consequuntur. Deserunt sed maiores molestias eligendi saepe repellat provident tempore corrupti.", "Lavern.Hand0@gmail.com", "Company920", 69, "https://arnold.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "897.429.7651 x48560", "89babdf6-31d6-45d2-a725-16c5e80ea915", "Quasi sit ducimus. Perspiciatis qui aliquid. Eius consequuntur voluptatem quisquam placeat ad est fuga. Dolor labore id.", "Xander13@gmail.com", "Company761", 68, "https://cyrus.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "225-882-4609", "b3731d39-39d1-491c-950b-719b0606e9c5", "Rerum consequatur necessitatibus facere modi esse atque. Qui recusandae minima blanditiis atque incidunt consequuntur consequuntur quasi. Est quibusdam hic et impedit quos cupiditate odit incidunt voluptates. Magni consequuntur et porro voluptate asperiores est consequatur provident.", "Harvey72@hotmail.com", "Company560", 62, "https://ericka.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(563) 213-2115", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "", "Berenice.Kutch65@gmail.com", "Company843", 69, "http://ena.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "597.605.7450 x468", "d59c9c41-ee13-42c2-adf8-862e5ada2a81", "Esse corporis eum perferendis enim voluptas quasi. Voluptatem consequatur sapiente esse et. Alias sunt ut.", "Dax53@gmail.com", "Company478", 61, "http://haleigh.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(260) 482-0362", "b3731d39-39d1-491c-950b-719b0606e9c5", "Ut assumenda aut nesciunt sequi.", "Ivory_Bayer@yahoo.com", "Company962", "https://hank.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(859) 796-7617 x454", "307ee358-2383-4f80-b94f-26f489bdb30f", "Sed et soluta recusandae ducimus facilis odit. Modi id corrupti dolores doloribus aut rerum vel omnis. Non quos est est alias eum nihil autem omnis aliquid.", "Ophelia1@yahoo.com", "Company506", 61, "https://ethelyn.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(834) 417-5237 x5129", "8ce60506-64fa-4b47-a167-f77a2bbe46bc", "Pariatur excepturi quasi sunt possimus maiores. Minus ipsam dolores a.", "Alexandrine.Schneider@gmail.com", "Company874", 64, "http://vesta.net" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 9, 31, 3, 983, DateTimeKind.Local), 42, "Et consequuntur laborum maiores eligendi eum non animi.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 0, 34, 1, 176, DateTimeKind.Local), 48, "Magni enim voluptatibus quam ut voluptatem eum animi ipsum vel.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 33, 15, 700, DateTimeKind.Local), 47, "Sit ut nam odio soluta ipsum et ad nam.", "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 55, 8, 986, DateTimeKind.Local), 47, "Perferendis explicabo beatae eveniet.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 19, 52, 19, 935, DateTimeKind.Local), 48, "Possimus rerum ut tempora.", "45e74407-0146-4659-a4f6-de7d7c0d0b9b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 15, 23, 30, 324, DateTimeKind.Local), 41, "Maiores in pariatur quia quo ab accusantium.", "4740e1d3-a664-49cf-bde9-24133792f2d8" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 12, 29, 21, 204, DateTimeKind.Local), 47, "Explicabo at est.", "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 4, 11, 18, 556, DateTimeKind.Local), "Consequatur molestias sunt sint rerum rem aut est in a.", "8ce60506-64fa-4b47-a167-f77a2bbe46bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 4, 14, 37, 47, 174, DateTimeKind.Local), 42, "Et placeat cum aliquid minus ducimus consequatur.", "d59c9c41-ee13-42c2-adf8-862e5ada2a81" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 11, 12, 57, 670, DateTimeKind.Local), 45, "Fugiat ad qui ex.", "307ee358-2383-4f80-b94f-26f489bdb30f" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "e8512f99-a4a3-4cf4-bc56-15cc45d0b3dc", 72 },
                    { "8ce60506-64fa-4b47-a167-f77a2bbe46bc", 73 },
                    { "52e27198-436d-4714-a6e7-e0d0738b847f", 78 },
                    { "b3731d39-39d1-491c-950b-719b0606e9c5", 76 },
                    { "307ee358-2383-4f80-b94f-26f489bdb30f", 74 },
                    { "45e74407-0146-4659-a4f6-de7d7c0d0b9b", 78 },
                    { "89babdf6-31d6-45d2-a725-16c5e80ea915", 75 },
                    { "d59c9c41-ee13-42c2-adf8-862e5ada2a81", 78 },
                    { "4740e1d3-a664-49cf-bde9-24133792f2d8", 77 },
                    { "b57b3a69-a3c9-4efd-b242-0fc6b368ff92", 72 }
                });
        }
    }
}
