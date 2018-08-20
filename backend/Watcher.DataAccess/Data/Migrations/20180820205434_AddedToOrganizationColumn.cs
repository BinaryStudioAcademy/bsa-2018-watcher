using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedToOrganizationColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bd76fc2-f512-4341-9aed-06f434f095e7", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "666f434f-7bc9-4276-abf0-723993d8ed27", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bd76fc2-f512-4341-9aed-06f434f095e7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "51eb640e-60b6-48f0-89cb-6d3e6c19074c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "58282afb-62fc-4591-8d86-7c86ec8cfff6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5aa34b99-8805-4234-9050-9e40616a7db4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "666f434f-7bc9-4276-abf0-723993d8ed27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d0fcb793-4ae2-4b33-add9-580d3ec6f237");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f3d31655-6174-47c9-965a-2ec360683e18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Instances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 97, "MostLoaded3", "Common2", "Source2", 88, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 95, "Common2", 96 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 94, "Source1", 8 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded3", "Common1", "Source2", 29, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                column: "Threshold",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { "MostLoaded3", "Common3", 57 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Common2", "Source2", 100, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 96, 57, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 92, "Common1", 15, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded2", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 15, 9, 58, 911, DateTimeKind.Local), 83, "Title693" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 15, 12, 26, 449, DateTimeKind.Local), "Title228" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 10, 18, 55, 781, DateTimeKind.Local), 89, "Title424" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 14, 33, 23, 83, DateTimeKind.Local), 90, "Title988" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 11, 47, 30, 409, DateTimeKind.Local), 87, "Title463" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 16, 17, 48, 320, DateTimeKind.Local), 81, "Title657" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 23, 48, 15, 537, DateTimeKind.Local), "Title656" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 25, 27, 426, DateTimeKind.Local), "Title598" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 17, 11, 37, 544, DateTimeKind.Local), 86, "Title107" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 18, 59, 10, 962, DateTimeKind.Local), 90, "Title480" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "b9:74:72:80:2e:7e", 75, "Linux", "Instance268" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "34:cd:b1:75:99:1d", 75, "Instance157" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "f8:a5:01:ae:34:9c", 73, "Instance517" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0b:bb:a7:be:c4:fc", 77, "Linux", "Instance846" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "c5:f8:ac:f2:d6:5f", 72, "Windows" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "cc:ee:4a:29:fd:13", 75, "Windows", "Instance975" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "3f:8c:85:fb:6d:79", 72, "Instance297" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "79:60:b1:b9:55:00", 80, "Linux", "Instance693" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6f:be:eb:dd:60:1c", 75, "Instance844" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8a:e0:bf:a1:8a:39", 75, "Windows", "Instance751" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme718" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme548" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme196" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme244" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme297" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme292" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme813" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme261" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme952" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme325" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "db8fa606-d6b2-4abc-bb25-7329d8392793", null, new DateTime(2018, 8, 20, 14, 2, 10, 68, DateTimeKind.Local), "Leon", "Julia_Prosacco92@gmail.com", "Justice", true, "Rowe", null, null, 2 },
                    { "334105ba-6abf-4bc4-9fc4-a0a87a22deab", null, new DateTime(2018, 8, 20, 15, 50, 55, 40, DateTimeKind.Local), "Arlo", "Madelynn95@gmail.com", "Sally", true, "Wolff", null, null, 2 },
                    { "b986e454-4e45-4fca-ae3b-2b66c6568f38", null, new DateTime(2018, 8, 20, 14, 13, 18, 3, DateTimeKind.Local), "Mortimer", "Garry86@hotmail.com", "Harmon", true, "Cruickshank", null, null, 2 },
                    { "35c8b495-2eca-4826-ac63-e76acaa26be4", null, new DateTime(2018, 8, 20, 6, 46, 47, 543, DateTimeKind.Local), "Hudson", "Ted.Lakin@yahoo.com", "Helena", true, "Rutherford", null, null, 1 },
                    { "e0c531cb-0853-479a-b8b0-abf17f4af118", null, new DateTime(2018, 8, 20, 16, 31, 45, 920, DateTimeKind.Local), "Estel", "Moriah.Ryan@gmail.com", "Burdette", true, "Rogahn", null, null, 2 },
                    { "dc889918-2400-4afb-8e4b-1739f54b1909", null, new DateTime(2018, 8, 20, 4, 18, 23, 187, DateTimeKind.Local), "Daryl", "Bianka.Metz14@hotmail.com", "Santiago", true, "Schroeder", null, null, 2 },
                    { "5bad4243-e775-4bbd-9263-6c8e5fe999c9", null, new DateTime(2018, 8, 20, 20, 21, 25, 431, DateTimeKind.Local), "Ned", "Asia.Littel@gmail.com", "Noemi", true, "Leannon", null, null, 1 },
                    { "e801f449-f5d7-482a-b2e0-a2f448175b94", null, new DateTime(2018, 8, 20, 9, 30, 27, 497, DateTimeKind.Local), "Earlene", "Mandy_Simonis@yahoo.com", "Daisha", true, "Ferry", null, null, 1 },
                    { "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9", null, new DateTime(2018, 8, 20, 16, 16, 2, 956, DateTimeKind.Local), "Herta", "Leone.Leuschke@hotmail.com", "Zaria", true, "Macejkovic", null, null, 2 },
                    { "0070dff4-5df2-46a8-9fdc-55d3e943dfae", null, new DateTime(2018, 8, 20, 8, 31, 21, 345, DateTimeKind.Local), "Spencer", "Geraldine_Fahey@yahoo.com", "Titus", true, "Weber", null, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5bad4243-e775-4bbd-9263-6c8e5fe999c9", "dolores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db8fa606-d6b2-4abc-bb25-7329d8392793", "magnam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0070dff4-5df2-46a8-9fdc-55d3e943dfae", "ullam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5bad4243-e775-4bbd-9263-6c8e5fe999c9", "architecto" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "35c8b495-2eca-4826-ac63-e76acaa26be4", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db8fa606-d6b2-4abc-bb25-7329d8392793", "incidunt" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "db8fa606-d6b2-4abc-bb25-7329d8392793", "consectetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9", "cupiditate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "334105ba-6abf-4bc4-9fc4-a0a87a22deab", "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "dc889918-2400-4afb-8e4b-1739f54b1909", "velit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 16, 2, 37, 400, DateTimeKind.Local), "Laboriosam cupiditate eius voluptate aut earum blanditiis.", "db8fa606-d6b2-4abc-bb25-7329d8392793" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 2, 10, 17, 334, DateTimeKind.Local), "Delectus praesentium sed sapiente a dolorem sit reiciendis.", "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 1, 17, 13, 572, DateTimeKind.Local), "Velit dolore impedit ut explicabo quam.", "35c8b495-2eca-4826-ac63-e76acaa26be4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 2, 4, 630, DateTimeKind.Local), "Laudantium quia omnis dolorem numquam numquam laudantium qui.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 16, 24, 894, DateTimeKind.Local), "Commodi neque eligendi tempore.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 1, 54, 449, DateTimeKind.Local), "Dolor sed repudiandae qui numquam.", "b986e454-4e45-4fca-ae3b-2b66c6568f38" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 11, 23, 29, 411, DateTimeKind.Local), "Minima excepturi accusamus aut.", "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 0, 57, 20, 444, DateTimeKind.Local), "Autem ipsum rerum soluta consequatur placeat maxime nihil adipisci vel.", "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 12, 35, 4, 156, DateTimeKind.Local), "Eaque iste eaque.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 16, 16, 48, 609, DateTimeKind.Local), "Neque vero maxime.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 20, 1, 21, 29, 326, DateTimeKind.Local), "Nemo aut expedita ut est qui quaerat quis et.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 20, 5, 40, 15, 150, DateTimeKind.Local), "Est veniam quaerat quasi iure.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 4, 3, 37, 835, DateTimeKind.Local), "Provident aspernatur sapiente accusantium quis eum sed quia fugit.", "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 20, 16, 21, 59, 909, DateTimeKind.Local), "Est assumenda illum.", "b986e454-4e45-4fca-ae3b-2b66c6568f38", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 23, 19, 14, 48, DateTimeKind.Local), "Dolore impedit repudiandae in voluptas fugit vel perspiciatis eaque.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 20, 12, 28, 31, 106, DateTimeKind.Local), "Sit incidunt repudiandae ut eligendi minus aspernatur.", "5bad4243-e775-4bbd-9263-6c8e5fe999c9", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 20, 16, 25, 13, 225, DateTimeKind.Local), "Quam et numquam ea.", "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 20, 5, 57, 18, 194, DateTimeKind.Local), "Magnam aut autem ut dicta qui sunt nisi et.", "db8fa606-d6b2-4abc-bb25-7329d8392793", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 20, 39, 14, 724, DateTimeKind.Local), "Qui odio est est iste id nobis.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 8, 20, 21, 0, 37, 47, DateTimeKind.Local), "Adipisci voluptas quidem non quo sit quod cumque.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae", false });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 3, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 2, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 2, "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "35c8b495-2eca-4826-ac63-e76acaa26be4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 0, "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, true, "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 5, 44, 13, 891, DateTimeKind.Local), 16, "Voluptas omnis ullam excepturi et similique rem provident quos et.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 7, 47, 50, 462, DateTimeKind.Local), 16, "Eum commodi ut qui laborum labore numquam.", "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 11, 50, 46, 708, DateTimeKind.Local), 17, "Consequatur facere molestiae quibusdam at.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 47, 27, 469, DateTimeKind.Local), 20, "Odit expedita fuga.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 2, 8, 0, 717, DateTimeKind.Local), 18, "Reiciendis enim omnis culpa voluptatibus rem culpa possimus.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 45, 50, 70, DateTimeKind.Local), "Magnam quisquam expedita.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 11, 39, 2, 738, DateTimeKind.Local), 18, "Vel ipsa id quidem non consequatur dolores.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 16, 28, 6, 509, DateTimeKind.Local), 12, "Dolores ut laborum similique ut in accusamus recusandae.", "35c8b495-2eca-4826-ac63-e76acaa26be4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 3, 42, 51, 751, DateTimeKind.Local), 13, "Necessitatibus tempore et tempore nihil laboriosam ducimus cupiditate.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 10, 7, 56, 389, DateTimeKind.Local), 20, "Et et quidem fugiat.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "664.692.2176 x90831", "5bad4243-e775-4bbd-9263-6c8e5fe999c9", "", "Krystina44@yahoo.com", "Company557", 64, "https://madalyn.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "459.832.7201 x309", "b986e454-4e45-4fca-ae3b-2b66c6568f38", "Officia expedita sunt.", "Jefferey58@gmail.com", "Company365", 69, "http://madie.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "747.640.4148 x610", "e801f449-f5d7-482a-b2e0-a2f448175b94", "Amet beatae libero et. Iusto nam quis est qui numquam quos laborum. Voluptas vel quia sed.", "Edward.Konopelski43@yahoo.com", "Company189", 64, "http://skylar.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(358) 737-9810", "e801f449-f5d7-482a-b2e0-a2f448175b94", "", "Brain5@gmail.com", "Company409", 65, "http://george.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(836) 632-9419", "5bad4243-e775-4bbd-9263-6c8e5fe999c9", "Ut aut ipsa. Facilis natus voluptatem non. Pariatur debitis sapiente. Doloremque suscipit iure distinctio.", "Alberto.Brekke62@hotmail.com", "Company249", 69, "http://jaiden.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-478-471-9297", "dc889918-2400-4afb-8e4b-1739f54b1909", "Julian.Fay@yahoo.com", "Company223", 63, "https://roger.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-785-547-4075", "334105ba-6abf-4bc4-9fc4-a0a87a22deab", "Iure enim velit et. Tempore explicabo accusantium dolorem vel omnis. Non assumenda esse tenetur id rem autem.", "Jacynthe_Hermann83@yahoo.com", "Company975", 63, "http://bernadine.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "200.361.4805", "35c8b495-2eca-4826-ac63-e76acaa26be4", "", "Buster_OKeefe@hotmail.com", "Company519", 69, "https://kyla.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(327) 610-2591 x59632", "35c8b495-2eca-4826-ac63-e76acaa26be4", "Voluptatibus eos est. Voluptas temporibus et enim voluptates dolorum.", "Garrett.Kovacek@yahoo.com", "Company242", 62, "https://jailyn.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-677-449-0292", "b986e454-4e45-4fca-ae3b-2b66c6568f38", "Enim deleniti et est eum. Sed voluptatum rerum qui accusamus ut. Impedit quos dignissimos sunt unde vel quis eius suscipit fugiat. Ipsa quia officiis a in aspernatur.", "Dorian.DuBuque88@yahoo.com", "Company95", 69, "https://maurine.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 6, 12, 29, 421, DateTimeKind.Local), 48, "A architecto recusandae tenetur tenetur minima molestiae.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 16, 0, 16, 446, DateTimeKind.Local), 46, "Doloremque iure aut dolorum aperiam eum porro.", "b986e454-4e45-4fca-ae3b-2b66c6568f38" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 0, 46, 40, 11, DateTimeKind.Local), 44, "Aut est rem in.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 17, 48, 652, DateTimeKind.Local), 47, "Harum at provident.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 21, 50, 57, 547, DateTimeKind.Local), 45, "Placeat et sed non pariatur animi magnam aperiam aut.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 56, 19, 177, DateTimeKind.Local), 50, "Accusantium accusantium doloribus at.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 14, 38, 3, 959, DateTimeKind.Local), 42, "Deleniti iste ipsam a.", "35c8b495-2eca-4826-ac63-e76acaa26be4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 6, 25, 59, 652, DateTimeKind.Local), 46, "Dolores voluptatem qui rerum tempora vitae voluptatum autem.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 7, 33, 39, 845, DateTimeKind.Local), "Est laudantium enim at eaque tempora illo est et.", "db8fa606-d6b2-4abc-bb25-7329d8392793" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 15, 7, 18, 728, DateTimeKind.Local), 48, "Animi ut nobis eius sunt laudantium magnam aspernatur.", "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9", 73 },
                    { "e0c531cb-0853-479a-b8b0-abf17f4af118", 72 },
                    { "5bad4243-e775-4bbd-9263-6c8e5fe999c9", 77 },
                    { "dc889918-2400-4afb-8e4b-1739f54b1909", 75 },
                    { "35c8b495-2eca-4826-ac63-e76acaa26be4", 71 },
                    { "b986e454-4e45-4fca-ae3b-2b66c6568f38", 72 },
                    { "334105ba-6abf-4bc4-9fc4-a0a87a22deab", 71 },
                    { "db8fa606-d6b2-4abc-bb25-7329d8392793", 71 },
                    { "e801f449-f5d7-482a-b2e0-a2f448175b94", 75 },
                    { "0070dff4-5df2-46a8-9fdc-55d3e943dfae", 73 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0070dff4-5df2-46a8-9fdc-55d3e943dfae", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "334105ba-6abf-4bc4-9fc4-a0a87a22deab", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "35c8b495-2eca-4826-ac63-e76acaa26be4", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5bad4243-e775-4bbd-9263-6c8e5fe999c9", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b986e454-4e45-4fca-ae3b-2b66c6568f38", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "db8fa606-d6b2-4abc-bb25-7329d8392793", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "dc889918-2400-4afb-8e4b-1739f54b1909", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e0c531cb-0853-479a-b8b0-abf17f4af118", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e801f449-f5d7-482a-b2e0-a2f448175b94", 75 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0070dff4-5df2-46a8-9fdc-55d3e943dfae");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "334105ba-6abf-4bc4-9fc4-a0a87a22deab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35c8b495-2eca-4826-ac63-e76acaa26be4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5bad4243-e775-4bbd-9263-6c8e5fe999c9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5ea7ee6c-848f-4c20-bed2-8a1384bb79f9");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b986e454-4e45-4fca-ae3b-2b66c6568f38");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "db8fa606-d6b2-4abc-bb25-7329d8392793");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dc889918-2400-4afb-8e4b-1739f54b1909");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e0c531cb-0853-479a-b8b0-abf17f4af118");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e801f449-f5d7-482a-b2e0-a2f448175b94");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Instances");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded2", "Common3", "Source1", 55, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold" },
                values: new object[] { 100, "Common3", 33 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Source", "Threshold" },
                values: new object[] { 100, "Source2", 19 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded2", "Common3", "Source3", 7, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                column: "Threshold",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MostLoaded", "ShowCommon", "Threshold" },
                values: new object[] { "MostLoaded1", "Common2", 79 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded2", "Common1", "Source1", 75, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 98, 52, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Threshold", "Type" },
                values: new object[] { 98, "Common3", 28, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded1", 51, 0 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 47, 43, 927, DateTimeKind.Local), 89, "Title736" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 54, 49, 376, DateTimeKind.Local), "Title684" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 38, 34, 479, DateTimeKind.Local), 82, "Title522" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 15, 1, 590, DateTimeKind.Local), 87, "Title786" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 35, 6, 218, DateTimeKind.Local), 86, "Title807" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 2, 26, 46, 746, DateTimeKind.Local), 83, "Title65" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 43, 19, 481, DateTimeKind.Local), "Title130" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 45, 14, 481, DateTimeKind.Local), "Title991" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 55, 17, 546, DateTimeKind.Local), 87, "Title334" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 16, 1, 27, 20, 455, DateTimeKind.Local), 85, "Title192" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c9:82:f9:92:a8:84", 74, "Windows", "Instance100" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "63:ce:14:be:5c:dd", 73, "Instance452" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9e:16:ca:02:9f:58", 76, "Instance613" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "4e:dd:23:c2:40:81", 80, "Windows", "Instance750" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Platform" },
                values: new object[] { "0e:23:3f:89:ab:7b", 71, "Linux" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f7:0b:93:99:43:b2", 78, "Linux", "Instance1" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "fc:f2:58:83:e2:85", 77, "Instance949" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f2:72:54:e1:71:7a", 79, "Windows", "Instance494" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "58:be:6a:47:f8:43", 73, "Instance339" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c9:f4:dd:e3:bf:1b", 78, "Linux", "Instance496" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme580" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme719" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme336" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme734" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme61" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme766" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme475" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme643" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme532" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme84" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "666f434f-7bc9-4276-abf0-723993d8ed27", null, new DateTime(2018, 8, 15, 19, 20, 8, 693, DateTimeKind.Local), "Landen", "Nora.Paucek@gmail.com", "Chandler", true, "Tremblay", null, null, 1 },
                    { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", null, new DateTime(2018, 8, 15, 20, 44, 8, 716, DateTimeKind.Local), "Dejah", "Turner_Hegmann56@gmail.com", "Hilton", true, "Gutmann", null, null, 2 },
                    { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", null, new DateTime(2018, 8, 15, 19, 50, 22, 785, DateTimeKind.Local), "Danielle", "Audra.Hermiston34@hotmail.com", "Ansel", true, "Von", null, null, 1 },
                    { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", null, new DateTime(2018, 8, 16, 17, 0, 40, 359, DateTimeKind.Local), "Harvey", "Eudora_Hayes@hotmail.com", "Zakary", true, "Wisoky", null, null, 2 },
                    { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", null, new DateTime(2018, 8, 16, 12, 21, 25, 361, DateTimeKind.Local), "Giuseppe", "Alden22@hotmail.com", "Ayden", true, "Crist", null, null, 2 },
                    { "2bd76fc2-f512-4341-9aed-06f434f095e7", null, new DateTime(2018, 8, 16, 9, 29, 0, 150, DateTimeKind.Local), "Kameron", "Wilford67@gmail.com", "Vita", true, "Herman", null, null, 2 },
                    { "f3d31655-6174-47c9-965a-2ec360683e18", null, new DateTime(2018, 8, 16, 3, 39, 38, 491, DateTimeKind.Local), "Braulio", "Elvie.Gorczany1@gmail.com", "Oscar", true, "Mayer", null, null, 1 },
                    { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", null, new DateTime(2018, 8, 16, 1, 33, 32, 328, DateTimeKind.Local), "Faustino", "Norberto.Skiles51@hotmail.com", "Abdul", true, "Sporer", null, null, 1 },
                    { "58282afb-62fc-4591-8d86-7c86ec8cfff6", null, new DateTime(2018, 8, 15, 20, 5, 56, 31, DateTimeKind.Local), "Clotilde", "Hester_Hackett15@yahoo.com", "Brennan", true, "Grant", null, null, 1 },
                    { "5aa34b99-8805-4234-9050-9e40616a7db4", null, new DateTime(2018, 8, 16, 12, 11, 58, 355, DateTimeKind.Local), "Jovanny", "Brandon.Mosciski28@gmail.com", "Eloisa", true, "Rosenbaum", null, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", "modi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", "animi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", "voluptatum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", "tenetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f3d31655-6174-47c9-965a-2ec360683e18", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5aa34b99-8805-4234-9050-9e40616a7db4", "tenetur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "58282afb-62fc-4591-8d86-7c86ec8cfff6", "vitae" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 26, 34, 247, DateTimeKind.Local), "Doloribus sint quo.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 37, 20, 735, DateTimeKind.Local), "Odio excepturi est rem neque odit.", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 18, 34, 36, 583, DateTimeKind.Local), "In et et odio nisi temporibus voluptas quia.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 24, 45, 362, DateTimeKind.Local), "Sunt ut optio.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 1, 20, 9, 741, DateTimeKind.Local), "Minima blanditiis possimus qui saepe sed optio pariatur.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 8, 1, 1, 693, DateTimeKind.Local), "Iusto consectetur laudantium saepe qui occaecati in quos facere.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 5, 38, 35, 536, DateTimeKind.Local), "Voluptatem autem rerum quis.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 17, 53, 2, 931, DateTimeKind.Local), "Vel qui sunt non dolorem voluptate earum.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 25, 8, 765, DateTimeKind.Local), "Dolorem deserunt cum et aut nobis possimus.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 22, 27, 88, DateTimeKind.Local), "Vel ullam quo et dolore.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 16, 3, 8, 0, 840, DateTimeKind.Local), "Laborum ut laboriosam deserunt occaecati repudiandae aliquid.", "2bd76fc2-f512-4341-9aed-06f434f095e7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 16, 2, 6, 21, 1, DateTimeKind.Local), "Ea quam libero dolorem et enim nihil ipsa.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 16, 7, 30, 36, 279, DateTimeKind.Local), "Earum asperiores maiores qui quae magni aspernatur.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 8, 15, 20, 33, 8, 970, DateTimeKind.Local), "Qui nihil quam voluptas eligendi aut ipsam et ipsum.", "2bd76fc2-f512-4341-9aed-06f434f095e7", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 16, 15, 14, 55, 532, DateTimeKind.Local), "Cum expedita autem autem reiciendis.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 16, 3, 41, 12, 386, DateTimeKind.Local), "Consequatur eligendi unde et blanditiis nihil hic eos consectetur exercitationem.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 16, 15, 29, 19, 656, DateTimeKind.Local), "Fuga dolor sit ducimus aliquid consequuntur.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 16, 5, 27, 53, 232, DateTimeKind.Local), "Et aperiam corporis id dolor laborum.", "5aa34b99-8805-4234-9050-9e40616a7db4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 16, 10, 37, 24, 820, DateTimeKind.Local), "Quasi totam placeat facilis qui sunt.", "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 16, 2, 32, 32, 788, DateTimeKind.Local), "Voluptates ex similique possimus occaecati tempora quibusdam.", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 0, "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 4, "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 0, "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 3, "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, false, "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 43, 52, 296, DateTimeKind.Local), 12, "Est non laudantium saepe culpa et quisquam.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 52, 17, 592, DateTimeKind.Local), 13, "Ad non facere aspernatur voluptatem accusamus quam possimus earum veritatis.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 15, 18, 55, 586, DateTimeKind.Local), 19, "Eum molestias nobis illo.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 19, 41, 51, 598, DateTimeKind.Local), 16, "Consectetur et quia veniam voluptas earum ut.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 15, 11, 8, 12, DateTimeKind.Local), 15, "Est alias porro quae consequatur aut ex dicta sint.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 41, 18, 917, DateTimeKind.Local), "Ipsum quod facere.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 22, 42, 57, 701, DateTimeKind.Local), 12, "Sint sequi nam quod magnam.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 13, 40, 46, 324, DateTimeKind.Local), 15, "At eaque dolorum est ab soluta.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 14, 38, 31, 30, DateTimeKind.Local), 12, "Quia qui et quis occaecati optio aperiam dolore.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 1, 40, 773, DateTimeKind.Local), 17, "Et sit sed quis blanditiis laboriosam reiciendis autem tempora.", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "789.983.9175 x2028", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", "Sed eligendi tempore quod non expedita temporibus earum. Laborum sit voluptatum odio laborum cumque et dolores. Sunt officia adipisci impedit voluptates minus nisi dolores ex qui. Recusandae quo ut sed odio saepe ea.", "Aubree.Becker9@hotmail.com", "Company365", 65, "http://bryon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "727-924-4793 x32937", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Ea repellat quisquam exercitationem doloremque est quisquam doloremque et quaerat. Impedit natus pariatur qui dolore voluptatibus. Voluptatem error quas qui aut in fuga non perferendis et.", "Tremayne17@gmail.com", "Company257", 62, "http://myrtle.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-800-335-9094 x7245", "d0fcb793-4ae2-4b33-add9-580d3ec6f237", "", "Dameon.Conn54@yahoo.com", "Company618", 67, "https://clarabelle.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(828) 508-9735 x1487", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Fugiat eius omnis animi.", "Donald_Feil@hotmail.com", "Company504", 61, "http://euna.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "451-382-6529 x13295", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", "", "Maximilian_Keeling@yahoo.com", "Company872", 61, "http://peter.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-371-365-5609", "51eb640e-60b6-48f0-89cb-6d3e6c19074c", "Turner.Schaefer@gmail.com", "Company56", 61, "http://elvis.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(749) 505-8220 x732", "666f434f-7bc9-4276-abf0-723993d8ed27", "Veritatis ea ea aut eaque nihil. Quos optio vel. Quia mollitia molestias minus illo.", "Ramona_Farrell60@hotmail.com", "Company451", 61, "http://aubrey.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-562-682-7970", "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", "Quo dolorem aut qui nostrum omnis sint consequatur est nisi. Minus ipsam delectus tempore consequatur nam et. Enim aut qui nihil nihil occaecati suscipit.", "Aurelia.Pfeffer13@gmail.com", "Company628", 65, "https://oren.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "236-409-8985 x43753", "666f434f-7bc9-4276-abf0-723993d8ed27", "Quod aspernatur debitis a illo. Id in doloremque. Atque dicta qui. Sit dolorum quasi dignissimos.", "Kiara38@gmail.com", "Company270", 68, "https://christophe.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-570-218-0260 x08382", "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", "Cumque est inventore quis. Provident commodi suscipit.", "Luz_Howe85@hotmail.com", "Company783", 66, "https://josiah.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 2, 14, 450, DateTimeKind.Local), 47, "Recusandae consequatur eum non molestias consequuntur quia.", "d0fcb793-4ae2-4b33-add9-580d3ec6f237" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 3, 38, 8, 563, DateTimeKind.Local), 42, "Atque debitis perspiciatis saepe a qui quibusdam assumenda.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 4, 58, 33, 470, DateTimeKind.Local), 45, "Culpa ex et nesciunt.", "2bd76fc2-f512-4341-9aed-06f434f095e7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 0, 29, 38, 98, DateTimeKind.Local), 41, "Asperiores quia suscipit ipsa et.", "5aa34b99-8805-4234-9050-9e40616a7db4" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 21, 14, 27, 78, DateTimeKind.Local), 49, "Voluptas quas laboriosam explicabo quasi est reprehenderit.", "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 57, 54, 939, DateTimeKind.Local), 49, "Ducimus veritatis distinctio.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 15, 19, 24, 44, 385, DateTimeKind.Local), 44, "Vero odio ut consequatur.", "58282afb-62fc-4591-8d86-7c86ec8cfff6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 11, 28, 39, 937, DateTimeKind.Local), 48, "Enim perspiciatis et reprehenderit aliquam et quo eius.", "f3d31655-6174-47c9-965a-2ec360683e18" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 9, 38, 14, 591, DateTimeKind.Local), "Excepturi nihil tempore.", "51eb640e-60b6-48f0-89cb-6d3e6c19074c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 16, 6, 28, 33, 947, DateTimeKind.Local), 47, "Quo recusandae excepturi ut numquam fuga.", "666f434f-7bc9-4276-abf0-723993d8ed27" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f3d31655-6174-47c9-965a-2ec360683e18", 76 },
                    { "0c18b481-63c3-4edb-9c6c-a96a4f4ef3be", 76 },
                    { "666f434f-7bc9-4276-abf0-723993d8ed27", 76 },
                    { "51eb640e-60b6-48f0-89cb-6d3e6c19074c", 71 },
                    { "58282afb-62fc-4591-8d86-7c86ec8cfff6", 76 },
                    { "1ae89fe2-ae8c-4d72-b924-40f3fda7f6f3", 78 },
                    { "2bd76fc2-f512-4341-9aed-06f434f095e7", 75 },
                    { "d0fcb793-4ae2-4b33-add9-580d3ec6f237", 78 },
                    { "fa3093fa-39f2-4065-a2bc-1f27a0fe67d7", 71 },
                    { "5aa34b99-8805-4234-9050-9e40616a7db4", 74 }
                });
        }
    }
}
