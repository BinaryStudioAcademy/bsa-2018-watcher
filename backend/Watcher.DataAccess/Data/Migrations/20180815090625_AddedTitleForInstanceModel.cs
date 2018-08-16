using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedTitleForInstanceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "187015d1-188d-44fc-8239-11ae2c506e2f", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2735687e-a5b5-4154-a952-de9d810a6c7f", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "38d449c2-96b3-4ab7-ba30-814f9fe96587", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "419c3e58-ffbf-456f-86f6-2d54a39b609c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5a1558a3-0421-4247-a5ee-df47360c9d09", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5e76c8bb-3095-4a28-82a8-3da25315b73a", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ad9d5836-dd59-4035-b4bd-2f5423752527", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ba229852-6f9f-4d85-b956-ff5bea3dcb84", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "db507c3c-7654-4083-9250-457e9c7411be", 78 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "187015d1-188d-44fc-8239-11ae2c506e2f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2735687e-a5b5-4154-a952-de9d810a6c7f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38d449c2-96b3-4ab7-ba30-814f9fe96587");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "419c3e58-ffbf-456f-86f6-2d54a39b609c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5a1558a3-0421-4247-a5ee-df47360c9d09");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5e76c8bb-3095-4a28-82a8-3da25315b73a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ad9d5836-dd59-4035-b4bd-2f5423752527");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ba229852-6f9f-4d85-b956-ff5bea3dcb84");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "db507c3c-7654-4083-9250-457e9c7411be");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Instances",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded3", "Common3", "Source1", 48, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Common2", "Source1", 11, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Common2", "Source1", 52, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Common3", "Source2", 85, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 94, "Common3", "Source1", 60 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "Common2", "Source2", 84, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "ShowCommon", "Source" },
                values: new object[] { 99, "Common1", "Source2" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Common1", 47, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", "Common2", "Source1", 48, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 95, 49, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 57, 42, 235, DateTimeKind.Local), 89, "Title919" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 58, 25, 876, DateTimeKind.Local), 87, "Title929" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 22, 53, 27, 643, DateTimeKind.Local), 85, "Title8" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 51, 2, 570, DateTimeKind.Local), 81, "Title0" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 9, 39, 11, 937, DateTimeKind.Local), 90, "Title751" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 18, 26, 52, 255, DateTimeKind.Local), 81, "Title486" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 4, 4, 20, 879, DateTimeKind.Local), 89, "Title278" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 21, 22, 69, DateTimeKind.Local), 87, "Title135" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 14, 27, 47, 518, DateTimeKind.Local), 82, "Title482" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 6, 39, 20, 596, DateTimeKind.Local), 83, "Title675" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "4d:9e:24:de:b9:c3", 79, "Instance750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "72:47:79:8c:1e:7f", 73, "Windows", "Instance167" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c0:07:04:25:01:54", 75, "Linux", "Instance777" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "04:7c:40:3a:3e:72", 72, "Windows", "Instance478" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3b:a6:35:ec:36:e3", 72, "Instance815" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "Title" },
                values: new object[] { "fc:ce:96:80:1a:46", "Instance343" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4f:b3:f4:4a:f2:f5", 71, "Linux", "Instance865" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "51:fa:14:09:04:19", 79, "Windows", "Instance304" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "27:35:ca:77:e3:35", "Windows", "Instance931" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "d8:2e:5d:6c:6d:88", 77, "Instance127" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme513" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme114" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme99" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme595" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme421" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme913" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme80" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme893" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme269" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme275" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "a8980cbb-75d9-40f1-b402-6b407eed99a4", null, new DateTime(2018, 8, 15, 5, 0, 5, 489, DateTimeKind.Local), "Bell", "Clementina90@yahoo.com", "Lexie", true, "Hilpert", null, 2 },
                    { "c6c22843-72fc-4836-9297-d2590ed79141", null, new DateTime(2018, 8, 15, 3, 19, 7, 528, DateTimeKind.Local), "Georgiana", "Willie78@hotmail.com", "Nayeli", true, "Von", null, 1 },
                    { "a659adfa-4f86-42a1-84ce-ace552bc4559", null, new DateTime(2018, 8, 14, 13, 46, 41, 179, DateTimeKind.Local), "Johan", "Frieda_Parker77@hotmail.com", "Abbigail", true, "Kohler", null, 2 },
                    { "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2", null, new DateTime(2018, 8, 15, 10, 47, 21, 306, DateTimeKind.Local), "Kirstin", "Cordelia.Stoltenberg@gmail.com", "Evans", true, "Kovacek", null, 2 },
                    { "4d60b58f-974f-4da9-8cec-61bdf80b937b", null, new DateTime(2018, 8, 15, 7, 4, 12, 966, DateTimeKind.Local), "Eda", "Mervin.Bergstrom29@hotmail.com", "Jamel", true, "Graham", null, 1 },
                    { "3d4a1813-a2c9-4727-ba38-ecab1951235a", null, new DateTime(2018, 8, 14, 12, 40, 10, 611, DateTimeKind.Local), "Duncan", "Sam51@gmail.com", "Aurelie", true, "Jakubowski", null, 2 },
                    { "1e156360-6f98-48ec-8e6f-627f64ecbbd0", null, new DateTime(2018, 8, 14, 20, 10, 27, 739, DateTimeKind.Local), "Nola", "Irma_Schneider86@yahoo.com", "Brent", true, "Hickle", null, 2 },
                    { "48052434-ab0c-4e5b-8ec2-56425365e387", null, new DateTime(2018, 8, 15, 11, 32, 3, 12, DateTimeKind.Local), "Kailey", "Dana_Rice@gmail.com", "Elvera", true, "Lockman", null, 1 },
                    { "b5ac7258-7629-4c76-a03f-230bc1010fd5", null, new DateTime(2018, 8, 15, 4, 0, 45, 170, DateTimeKind.Local), "Jerrold", "Annamae.Gulgowski45@gmail.com", "Jay", true, "Reichel", null, 2 },
                    { "14105d91-1320-41b1-9fc4-b92c647b725a", null, new DateTime(2018, 8, 14, 15, 24, 39, 54, DateTimeKind.Local), "Esteban", "Joyce26@hotmail.com", "Aric", true, "Ernser", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b5ac7258-7629-4c76-a03f-230bc1010fd5", "in" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "14105d91-1320-41b1-9fc4-b92c647b725a", "possimus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a8980cbb-75d9-40f1-b402-6b407eed99a4", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48052434-ab0c-4e5b-8ec2-56425365e387", "eius" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d4a1813-a2c9-4727-ba38-ecab1951235a", "omnis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48052434-ab0c-4e5b-8ec2-56425365e387", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d60b58f-974f-4da9-8cec-61bdf80b937b", "itaque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3d4a1813-a2c9-4727-ba38-ecab1951235a", "neque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d60b58f-974f-4da9-8cec-61bdf80b937b", "temporibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "4d60b58f-974f-4da9-8cec-61bdf80b937b", "est" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 45, 33, 750, DateTimeKind.Local), "Illo illo reiciendis saepe culpa eos ut molestiae sunt enim.", "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 10, 41, 16, 323, DateTimeKind.Local), "Et molestiae dignissimos consequatur molestias recusandae.", "a8980cbb-75d9-40f1-b402-6b407eed99a4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 21, 13, 30, 718, DateTimeKind.Local), "Recusandae corrupti ab ut.", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 54, 35, 361, DateTimeKind.Local), "Blanditiis et ut temporibus velit et sunt culpa expedita dolor.", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 1, 14, 49, 838, DateTimeKind.Local), "Ut cumque voluptatum porro.", "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 5, 55, 294, DateTimeKind.Local), "Corrupti ipsa sit consequatur voluptates eveniet.", "c6c22843-72fc-4836-9297-d2590ed79141" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 20, 41, 38, 465, DateTimeKind.Local), "Voluptas ut occaecati tempora maiores sed.", "c6c22843-72fc-4836-9297-d2590ed79141" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 15, 49, 5, 465, DateTimeKind.Local), "Ut sit suscipit eos aliquid sit nihil nihil.", "a659adfa-4f86-42a1-84ce-ace552bc4559" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 16, 24, 8, 989, DateTimeKind.Local), "Perferendis suscipit dolor aut.", "4d60b58f-974f-4da9-8cec-61bdf80b937b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 9, 53, 40, 551, DateTimeKind.Local), "Dignissimos ut debitis corporis quod ut.", "b5ac7258-7629-4c76-a03f-230bc1010fd5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 9, 31, 53, 987, DateTimeKind.Local), "Eligendi dolorem hic aut qui et ut.", "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 11, 42, 16, 937, DateTimeKind.Local), "Dignissimos omnis dolores animi quia officiis perferendis tenetur repellat repudiandae.", "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 14, 19, 7, 19, 751, DateTimeKind.Local), "Dolorum dolorem suscipit laudantium quasi.", "48052434-ab0c-4e5b-8ec2-56425365e387", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 14, 18, 55, 49, 23, DateTimeKind.Local), "Aut veniam velit cum ea dignissimos odit perferendis qui.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 14, 12, 59, 23, 425, DateTimeKind.Local), "Natus deserunt sint omnis dolor quos recusandae.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 15, 10, 28, 26, 942, DateTimeKind.Local), "Est sapiente blanditiis dolor.", "48052434-ab0c-4e5b-8ec2-56425365e387", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 26, new DateTime(2018, 8, 15, 0, 48, 10, 536, DateTimeKind.Local), "Deserunt id minima.", "a8980cbb-75d9-40f1-b402-6b407eed99a4", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 15, 8, 25, 5, 763, DateTimeKind.Local), "Enim culpa tenetur modi quisquam et voluptatum.", "a659adfa-4f86-42a1-84ce-ace552bc4559" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 14, 20, 33, 43, 644, DateTimeKind.Local), "Et voluptatem sunt possimus ipsum libero ratione natus unde.", "c6c22843-72fc-4836-9297-d2590ed79141" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 14, 19, 27, 3, 903, DateTimeKind.Local), "Ut doloribus labore sint nemo sint non.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 4, "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 2, "1e156360-6f98-48ec-8e6f-627f64ecbbd0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 3, "1e156360-6f98-48ec-8e6f-627f64ecbbd0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, "a8980cbb-75d9-40f1-b402-6b407eed99a4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 0, "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "b5ac7258-7629-4c76-a03f-230bc1010fd5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "a659adfa-4f86-42a1-84ce-ace552bc4559" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "a659adfa-4f86-42a1-84ce-ace552bc4559" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 7, 52, 0, 441, DateTimeKind.Local), 19, "Provident delectus itaque qui fugit.", "4d60b58f-974f-4da9-8cec-61bdf80b937b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 13, 25, 364, DateTimeKind.Local), 16, "Alias doloribus atque similique illum temporibus aliquid.", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 23, 40, 11, 714, DateTimeKind.Local), 11, "Qui ea dolorem occaecati voluptates dolorem deserunt quia.", "4d60b58f-974f-4da9-8cec-61bdf80b937b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 11, 27, 36, 273, DateTimeKind.Local), 14, "Corporis facere laudantium pariatur iste nostrum aut exercitationem autem.", "1e156360-6f98-48ec-8e6f-627f64ecbbd0" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 9, 2, 22, 643, DateTimeKind.Local), 15, "Asperiores aut animi officiis et nobis dicta illum facere sed.", "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 3, 33, 53, 714, DateTimeKind.Local), 18, "Nostrum qui ipsam ipsam perferendis ut sequi sit vel.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 2, 25, 249, DateTimeKind.Local), 17, "Sint nemo eos sed.", "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 10, 51, 51, 602, DateTimeKind.Local), 15, "Quisquam asperiores corporis mollitia et rerum voluptatem omnis quidem suscipit.", "c6c22843-72fc-4836-9297-d2590ed79141" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 9, 18, 4, DateTimeKind.Local), 20, "Impedit voluptatum quo cum velit qui vel.", "a659adfa-4f86-42a1-84ce-ace552bc4559" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 12, 6, 38, 260, DateTimeKind.Local), 11, "Odio similique molestias necessitatibus.", "4d60b58f-974f-4da9-8cec-61bdf80b937b" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-985-995-3812 x8603", "3d4a1813-a2c9-4727-ba38-ecab1951235a", "Minus voluptatem corrupti blanditiis repellendus labore voluptatem pariatur. Itaque non velit accusamus ut rerum possimus dolorum. Sit et ducimus ut atque. Debitis temporibus hic voluptates eum deserunt laborum distinctio quia.", "Wilmer70@yahoo.com", "Company279", 70, "http://billy.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "910.671.0248 x75922", "3d4a1813-a2c9-4727-ba38-ecab1951235a", "Voluptas ut voluptatem. Voluptatem impedit consequuntur aut ex.", "Verdie_Nitzsche93@hotmail.com", "Company932", 61, "https://magnolia.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-250-492-9355 x863", "1e156360-6f98-48ec-8e6f-627f64ecbbd0", "Braeden.Parisian34@yahoo.com", "Company480", 67, "http://kayla.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(382) 454-7907 x61531", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2", "Voluptatum et minus quas dolorem voluptatem quos tempora quia corrupti. Aut qui autem est aliquid ut repellendus veritatis tempore ad.", "Gerardo73@gmail.com", "Company855", 62, "http://ephraim.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(530) 893-9198 x8438", "a659adfa-4f86-42a1-84ce-ace552bc4559", "Est consequuntur eum nihil. Tempore dicta labore cupiditate. Dolore velit est et excepturi animi. Quisquam ipsam molestias tenetur est sunt enim minima ratione.", "Tobin_Frami99@yahoo.com", "Company646", 69, "http://jewell.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-814-851-5543 x256", "14105d91-1320-41b1-9fc4-b92c647b725a", "Quaerat quo eaque natus nihil. Odio voluptatem temporibus ullam quo voluptas odio consectetur sed incidunt.", "Guy.Wisozk@yahoo.com", "Company451", 68, "http://marco.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-388-761-5216 x534", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2", "Maxime enim ratione aliquid.", "Precious.Goyette@hotmail.com", "Company199", 61, "https://layla.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "756.899.8959", "b5ac7258-7629-4c76-a03f-230bc1010fd5", "Nam dolor magnam iusto. Voluptas consequatur perspiciatis. Nihil molestiae delectus vel. Rerum aperiam id maiores quo tempore.", "Zetta_Medhurst@yahoo.com", "Company277", 62, "https://hyman.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(783) 804-7611 x235", "4d60b58f-974f-4da9-8cec-61bdf80b937b", "Quasi omnis quaerat officia enim ratione dolore. Et molestias et error sapiente blanditiis non. Est suscipit molestias dolores facilis quasi eligendi quo occaecati hic. Nihil aut et.", "Julien.Schmitt@hotmail.com", "Company678", 63, "http://oma.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-898-519-2590", "c6c22843-72fc-4836-9297-d2590ed79141", "Alias vitae unde et quia aut ut quas et. Autem rerum distinctio. Est autem laudantium excepturi.", "Keeley82@gmail.com", "Company677", 67, "http://hosea.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 8, 21, 18, 450, DateTimeKind.Local), 47, "Doloribus consequuntur et at inventore nemo voluptatibus amet quia.", "1e156360-6f98-48ec-8e6f-627f64ecbbd0" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 2, 22, 51, 38, DateTimeKind.Local), 48, "Eum sed illo libero rerum voluptatum molestias error voluptate.", "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 3, 15, 35, 974, DateTimeKind.Local), 46, "Fuga at sapiente dignissimos.", "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 21, 48, 3, 736, DateTimeKind.Local), 47, "Iusto in id ex dolor nihil aliquid.", "48052434-ab0c-4e5b-8ec2-56425365e387" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 5, 42, 26, 235, DateTimeKind.Local), "Quisquam deserunt sequi cum magnam architecto vitae et nemo.", "3d4a1813-a2c9-4727-ba38-ecab1951235a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 8, 21, 27, 190, DateTimeKind.Local), 50, "Ratione vero soluta magni modi aut temporibus at.", "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 19, 10, 55, 599, DateTimeKind.Local), 47, "Ducimus enim impedit assumenda nesciunt ut dolorum quod.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 6, 27, 40, 214, DateTimeKind.Local), 49, "Dolor quo consequatur quis sequi incidunt.", "b5ac7258-7629-4c76-a03f-230bc1010fd5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 7, 7, 27, 775, DateTimeKind.Local), 49, "Non voluptatem accusantium eius quis et debitis aut error et.", "a8980cbb-75d9-40f1-b402-6b407eed99a4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 7, 1, 23, 627, DateTimeKind.Local), 46, "Autem pariatur ratione ullam sapiente voluptatibus alias neque magnam.", "14105d91-1320-41b1-9fc4-b92c647b725a" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "1e156360-6f98-48ec-8e6f-627f64ecbbd0", 72 },
                    { "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2", 76 },
                    { "4d60b58f-974f-4da9-8cec-61bdf80b937b", 71 },
                    { "b5ac7258-7629-4c76-a03f-230bc1010fd5", 72 },
                    { "a8980cbb-75d9-40f1-b402-6b407eed99a4", 78 },
                    { "3d4a1813-a2c9-4727-ba38-ecab1951235a", 77 },
                    { "a659adfa-4f86-42a1-84ce-ace552bc4559", 76 },
                    { "48052434-ab0c-4e5b-8ec2-56425365e387", 71 },
                    { "c6c22843-72fc-4836-9297-d2590ed79141", 79 },
                    { "14105d91-1320-41b1-9fc4-b92c647b725a", 76 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "14105d91-1320-41b1-9fc4-b92c647b725a", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1e156360-6f98-48ec-8e6f-627f64ecbbd0", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3d4a1813-a2c9-4727-ba38-ecab1951235a", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48052434-ab0c-4e5b-8ec2-56425365e387", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "4d60b58f-974f-4da9-8cec-61bdf80b937b", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a659adfa-4f86-42a1-84ce-ace552bc4559", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a8980cbb-75d9-40f1-b402-6b407eed99a4", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b5ac7258-7629-4c76-a03f-230bc1010fd5", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c6c22843-72fc-4836-9297-d2590ed79141", 79 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14105d91-1320-41b1-9fc4-b92c647b725a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1e156360-6f98-48ec-8e6f-627f64ecbbd0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3199fe3c-63e6-4f62-a0ad-d4f32497b0a2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d4a1813-a2c9-4727-ba38-ecab1951235a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48052434-ab0c-4e5b-8ec2-56425365e387");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4d60b58f-974f-4da9-8cec-61bdf80b937b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a659adfa-4f86-42a1-84ce-ace552bc4559");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a8980cbb-75d9-40f1-b402-6b407eed99a4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b5ac7258-7629-4c76-a03f-230bc1010fd5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c6c22843-72fc-4836-9297-d2590ed79141");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Common2", "Source3", 7, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded3", "Common3", "Source2", 60, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded2", "Common3", "Source3", 77, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded3", "Common1", "Source1", 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 99, "Common1", "Source3", 33 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common3", "Source1", 10, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "ShowCommon", "Source" },
                values: new object[] { 91, "Common3", "Source3" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Common3", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Common3", "Source2", 27, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 100, 66, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 34, 38, 908, DateTimeKind.Local), 83, "Title915" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 3, 17, 23, 774, DateTimeKind.Local), 88, "Title680" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 2, 13, 16, 933, DateTimeKind.Local), 83, "Title7" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 36, 25, 124, DateTimeKind.Local), 82, "Title293" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 53, 35, 557, DateTimeKind.Local), 84, "Title141" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 17, 15, 19, 69, DateTimeKind.Local), 89, "Title920" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 24, 36, 970, DateTimeKind.Local), 86, "Title207" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 19, 57, 58, DateTimeKind.Local), 83, "Title562" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 9, 39, 70, DateTimeKind.Local), 87, "Title272" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 15, 55, 714, DateTimeKind.Local), 84, "Title903" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "45:0d:da:b2:c1:13", 76 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "4c:9b:54:1a:4e:71", 72, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "20:ce:31:25:85:b8", 77, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "48:e5:ba:f1:dc:4d", 74, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "e1:71:f7:ae:9c:5c", 74 });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                column: "Address",
                value: "ba:db:6c:8b:2e:5d");

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "b0:2e:a1:01:48:df", 77, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "63:50:6a:db:58:96", 72, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "Platform" },
                values: new object[] { "3b:43:38:dd:79:7a", "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId" },
                values: new object[] { "77:b8:6a:a9:4c:1e", 74 });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme364" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme563" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme790" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme742" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme850" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme805" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme828" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme627" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme536" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme994" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "RoleId" },
                values: new object[,]
                {
                    { "5e76c8bb-3095-4a28-82a8-3da25315b73a", null, new DateTime(2018, 8, 13, 21, 31, 25, 847, DateTimeKind.Local), "Bernard", "Renee98@gmail.com", "Chance", true, "Rohan", null, 2 },
                    { "187015d1-188d-44fc-8239-11ae2c506e2f", null, new DateTime(2018, 8, 14, 10, 36, 43, 645, DateTimeKind.Local), "Elijah", "Kody.Schuppe92@hotmail.com", "Wendy", true, "Orn", null, 2 },
                    { "5a1558a3-0421-4247-a5ee-df47360c9d09", null, new DateTime(2018, 8, 13, 13, 28, 52, 450, DateTimeKind.Local), "Princess", "Noemy_Rempel@hotmail.com", "Deja", true, "Schiller", null, 1 },
                    { "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2", null, new DateTime(2018, 8, 14, 2, 14, 45, 976, DateTimeKind.Local), "Leonor", "Taryn.Stoltenberg@yahoo.com", "Jarrell", true, "Williamson", null, 2 },
                    { "ba229852-6f9f-4d85-b956-ff5bea3dcb84", null, new DateTime(2018, 8, 14, 2, 3, 10, 227, DateTimeKind.Local), "Katheryn", "Susanna28@yahoo.com", "Adela", true, "McGlynn", null, 1 },
                    { "419c3e58-ffbf-456f-86f6-2d54a39b609c", null, new DateTime(2018, 8, 14, 10, 40, 54, 628, DateTimeKind.Local), "Giuseppe", "Toby31@gmail.com", "Dina", true, "Stracke", null, 1 },
                    { "ad9d5836-dd59-4035-b4bd-2f5423752527", null, new DateTime(2018, 8, 13, 13, 10, 36, 356, DateTimeKind.Local), "Mallie", "Jesus.Quitzon66@yahoo.com", "Lyric", true, "Grant", null, 1 },
                    { "db507c3c-7654-4083-9250-457e9c7411be", null, new DateTime(2018, 8, 13, 23, 53, 23, 864, DateTimeKind.Local), "Cloyd", "Madonna2@hotmail.com", "Brooks", true, "Lang", null, 2 },
                    { "38d449c2-96b3-4ab7-ba30-814f9fe96587", null, new DateTime(2018, 8, 13, 13, 14, 13, 19, DateTimeKind.Local), "Rupert", "Leonel54@hotmail.com", "Darryl", true, "Goodwin", null, 2 },
                    { "2735687e-a5b5-4154-a952-de9d810a6c7f", null, new DateTime(2018, 8, 14, 7, 28, 56, 904, DateTimeKind.Local), "Verla", "Miracle6@gmail.com", "Ambrose", true, "Ebert", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db507c3c-7654-4083-9250-457e9c7411be", "fugit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5e76c8bb-3095-4a28-82a8-3da25315b73a", "quia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db507c3c-7654-4083-9250-457e9c7411be", "consectetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5e76c8bb-3095-4a28-82a8-3da25315b73a", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "187015d1-188d-44fc-8239-11ae2c506e2f", "minima" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5a1558a3-0421-4247-a5ee-df47360c9d09", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "419c3e58-ffbf-456f-86f6-2d54a39b609c", "quaerat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "38d449c2-96b3-4ab7-ba30-814f9fe96587", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ad9d5836-dd59-4035-b4bd-2f5423752527", "blanditiis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db507c3c-7654-4083-9250-457e9c7411be", "quo" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 12, 16, 16, 746, DateTimeKind.Local), "Iusto velit fugit atque alias ab laborum id soluta.", "ba229852-6f9f-4d85-b956-ff5bea3dcb84" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 14, 14, 239, DateTimeKind.Local), "Rerum ipsam quia odit.", "187015d1-188d-44fc-8239-11ae2c506e2f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 5, 15, 47, 238, DateTimeKind.Local), "Est assumenda et delectus et voluptatem a doloremque labore.", "ba229852-6f9f-4d85-b956-ff5bea3dcb84" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 42, 1, 784, DateTimeKind.Local), "Aspernatur magni quia quis iste et.", "38d449c2-96b3-4ab7-ba30-814f9fe96587" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 34, 23, 108, DateTimeKind.Local), "Earum tempora libero impedit.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 4, 39, 58, 227, DateTimeKind.Local), "Deleniti impedit ipsam ut est quibusdam beatae beatae non dignissimos.", "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 6, 33, 56, 233, DateTimeKind.Local), "Voluptatem quis ipsam.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 20, 42, 27, 266, DateTimeKind.Local), "Odit soluta earum voluptas et.", "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 55, 43, 23, DateTimeKind.Local), "Dolor ut labore quaerat maiores rerum ut.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 9, 50, 928, DateTimeKind.Local), "Aspernatur assumenda ullam illo consequuntur voluptas aut non ut nulla.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 28, 3, 229, DateTimeKind.Local), "Laborum tempore harum est.", "2735687e-a5b5-4154-a952-de9d810a6c7f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 17, 55, 47, 386, DateTimeKind.Local), "Enim esse dolor ducimus dolorum suscipit alias.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 14, 10, 45, 46, 885, DateTimeKind.Local), "Sint deserunt qui neque rerum id officia animi.", "5e76c8bb-3095-4a28-82a8-3da25315b73a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 13, 20, 18, 10, 426, DateTimeKind.Local), "Et ab ut minima quisquam nesciunt iusto.", "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 13, 19, 53, 2, 379, DateTimeKind.Local), "Vel repudiandae ipsam.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 13, 21, 30, 47, 209, DateTimeKind.Local), "Qui eligendi vitae.", "38d449c2-96b3-4ab7-ba30-814f9fe96587", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 14, 10, 51, 4, 309, DateTimeKind.Local), "Ipsam enim numquam sed ipsum earum quia quis laudantium et.", "ad9d5836-dd59-4035-b4bd-2f5423752527", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 13, 19, 6, 5, 891, DateTimeKind.Local), "Tempore et consequuntur eum qui.", "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 13, 16, 11, 22, 378, DateTimeKind.Local), "Non illo aut delectus ex libero necessitatibus veniam.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 13, 16, 58, 46, 113, DateTimeKind.Local), "Et officiis autem doloremque nihil.", "38d449c2-96b3-4ab7-ba30-814f9fe96587" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 0, "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, true, 3, "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 2, "38d449c2-96b3-4ab7-ba30-814f9fe96587" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 0, "38d449c2-96b3-4ab7-ba30-814f9fe96587" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, "ba229852-6f9f-4d85-b956-ff5bea3dcb84" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, false, 3, "187015d1-188d-44fc-8239-11ae2c506e2f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "2735687e-a5b5-4154-a952-de9d810a6c7f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 3, "38d449c2-96b3-4ab7-ba30-814f9fe96587" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 1, 1, 37, 212, DateTimeKind.Local), 18, "Consectetur autem sed quis.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 0, 41, 16, 825, DateTimeKind.Local), 13, "Asperiores fugiat maxime debitis aperiam.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 19, 2, 39, 628, DateTimeKind.Local), 20, "Quis quod omnis unde aut.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 57, 1, 274, DateTimeKind.Local), 17, "Magni deserunt nihil amet ad et at.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 14, 39, 33, 989, DateTimeKind.Local), 14, "Deserunt porro eum dolorum sed provident.", "ba229852-6f9f-4d85-b956-ff5bea3dcb84" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 5, 10, 32, 255, DateTimeKind.Local), 12, "Expedita facere facere alias.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 47, 6, 777, DateTimeKind.Local), 14, "Iure nam voluptate molestiae recusandae ut quia molestiae.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 57, 16, 693, DateTimeKind.Local), 17, "Consectetur eum explicabo.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 23, 2, 40, 652, DateTimeKind.Local), 15, "Sequi molestiae enim illum exercitationem.", "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 8, 9, 8, 183, DateTimeKind.Local), 19, "Tempore amet voluptatibus saepe qui numquam voluptatem consequatur accusantium.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(618) 245-9185", "5e76c8bb-3095-4a28-82a8-3da25315b73a", "Ea soluta et iure veritatis sit laborum. Ab commodi alias voluptatem iure quia sit.", "Maurice_Roob6@gmail.com", "Company700", 68, "https://anika.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "501-796-2012 x074", "ba229852-6f9f-4d85-b956-ff5bea3dcb84", "Ut sunt aut.", "Jaida44@yahoo.com", "Company951", 63, "http://hardy.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "213-338-3781 x8593", "187015d1-188d-44fc-8239-11ae2c506e2f", "Tiffany.Jones99@yahoo.com", "Company364", 64, "http://cordelia.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "669.403.6217 x82473", "38d449c2-96b3-4ab7-ba30-814f9fe96587", "Recusandae voluptatibus odit.", "Tressie51@yahoo.com", "Company39", 69, "http://austin.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(554) 394-5689", "ad9d5836-dd59-4035-b4bd-2f5423752527", "Beatae asperiores ut exercitationem. Voluptatum quis aut expedita odit est soluta ullam explicabo. Est consectetur quia iste qui.", "Molly.Rath@hotmail.com", "Company616", 63, "https://zion.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "374.812.1613 x25818", "2735687e-a5b5-4154-a952-de9d810a6c7f", "", "Raymundo.Cassin@hotmail.com", "Company29", 65, "http://allie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-387-203-6109 x4158", "ba229852-6f9f-4d85-b956-ff5bea3dcb84", "Debitis cum ipsam odio laudantium aut molestiae blanditiis ipsa est. Assumenda minus est et temporibus omnis quam amet ut porro. Veritatis quos dignissimos voluptas.", "Jess_Stoltenberg51@hotmail.com", "Company614", 67, "http://faustino.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "763-448-4376", "ad9d5836-dd59-4035-b4bd-2f5423752527", "Harum dolores voluptatem.", "Allene_Feest33@hotmail.com", "Company15", 67, "http://herminia.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "273.919.6357 x05309", "5a1558a3-0421-4247-a5ee-df47360c9d09", "Rerum velit quod et rerum quisquam.", "Juanita.Runolfsson@hotmail.com", "Company821", 65, "https://saul.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "896.288.1974 x3480", "ba229852-6f9f-4d85-b956-ff5bea3dcb84", "Praesentium autem rem veritatis consectetur perspiciatis et dolorum labore. Laudantium inventore aspernatur unde voluptatem vero quisquam voluptatem. Totam a qui pariatur est possimus vel.", "Sven_King@hotmail.com", "Company550", 61, "http://jana.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 6, 1, 12, 476, DateTimeKind.Local), 46, "Iusto dolores laudantium occaecati nemo sed earum qui nihil iure.", "5a1558a3-0421-4247-a5ee-df47360c9d09" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 2, 10, 937, DateTimeKind.Local), 42, "Amet voluptas culpa architecto rem.", "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 7, 6, 42, 918, DateTimeKind.Local), 49, "Ab illo omnis aut expedita recusandae cum velit suscipit.", "ad9d5836-dd59-4035-b4bd-2f5423752527" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 11, 46, 7, 86, DateTimeKind.Local), 46, "Occaecati sed distinctio.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 21, 42, 28, 177, DateTimeKind.Local), "Vel ipsa possimus officia omnis et.", "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 14, 5, 20, 24, 237, DateTimeKind.Local), 41, "Minus similique corporis voluptas esse laudantium possimus iusto.", "419c3e58-ffbf-456f-86f6-2d54a39b609c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 16, 19, 42, 309, DateTimeKind.Local), 45, "Et dicta voluptates corrupti veritatis consequatur praesentium velit qui dolore.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 18, 35, 50, 170, DateTimeKind.Local), 43, "Ullam delectus unde.", "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 22, 11, 50, 946, DateTimeKind.Local), 50, "Mollitia deleniti veritatis et quibusdam odit et et.", "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 13, 15, 30, 28, 891, DateTimeKind.Local), 50, "Ea quia libero cum veritatis.", "db507c3c-7654-4083-9250-457e9c7411be" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "db507c3c-7654-4083-9250-457e9c7411be", 78 },
                    { "5a1558a3-0421-4247-a5ee-df47360c9d09", 77 },
                    { "419c3e58-ffbf-456f-86f6-2d54a39b609c", 74 },
                    { "187015d1-188d-44fc-8239-11ae2c506e2f", 72 },
                    { "9841b8e2-2d03-4fe3-8780-e15fcbfd9ac2", 74 },
                    { "ba229852-6f9f-4d85-b956-ff5bea3dcb84", 71 },
                    { "38d449c2-96b3-4ab7-ba30-814f9fe96587", 76 },
                    { "5e76c8bb-3095-4a28-82a8-3da25315b73a", 75 },
                    { "ad9d5836-dd59-4035-b4bd-2f5423752527", 71 },
                    { "2735687e-a5b5-4154-a952-de9d810a6c7f", 79 }
                });
        }
    }
}
