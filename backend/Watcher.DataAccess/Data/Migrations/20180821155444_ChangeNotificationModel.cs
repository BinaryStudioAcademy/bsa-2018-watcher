using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangeNotificationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "WasRead",
                table: "Notifications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 100, "MostLoaded1", "Source1", 34 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", "Common1", "Source2", 58, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Source3", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 93, "MostLoaded1", "Common2", "Source3", 42, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded1", "Source2", 56, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 98, "Common1", "Source3", 25 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "MostLoaded2", "Common1", "Source1", 32, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 98, "Common3", "Source1", 87 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common2", "Source1", 44, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { "MostLoaded1", "Common3", "Source3", 92 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 38, 55, 581, DateTimeKind.Local), 82, "Title730" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 3, 53, 1, 571, DateTimeKind.Local), 87, "Title425" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 9, 4, 22, 256, DateTimeKind.Local), 84, "Title728" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 7, 6, 53, 604, DateTimeKind.Local), 83, "Title788" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 6, 16, 401, DateTimeKind.Local), 84, "Title724" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 31, 18, 610, DateTimeKind.Local), 83, "Title344" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 9, 34, 733, DateTimeKind.Local), 83, "Title298" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 17, 28, 29, 769, DateTimeKind.Local), 81, "Title266" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 13, 9, 31, 25, DateTimeKind.Local), 84, "Title278" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 33, 0, 943, DateTimeKind.Local), 87, "Title497" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "82:9a:82:03:00:c6", true, 74, "Instance899" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "dc:87:e3:4f:3f:14", true, 73, "Linux", "Instance705" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "5f:ac:78:74:88:ab", true, 76, "Windows", "Instance789" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "1d:6d:e5:aa:c4:96", true, 80, "Windows", "Instance61" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "21:e2:b3:d4:b2:c8", true, 77, "Instance838" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "e2:2b:33:8f:47:d6", true, 72, "Instance286" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "46:34:9e:f8:80:6f", true, 77, "Windows", "Instance477" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "IsActive", "Platform", "Title" },
                values: new object[] { "25:28:90:ca:34:7d", true, "Windows", "Instance544" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "06:53:d8:46:d9:f1", true, 73, "Linux", "Instance758" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "74:e1:a2:81:b9:ed", true, 73, "Instance388" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme581" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme207");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme361" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme936" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme417" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Trade", "Theme582" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Trade", "Theme904" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme978" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme506" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Theme337");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "52d682db-3377-4f04-b118-9ee72fba6dca", null, new DateTime(2018, 8, 21, 13, 35, 32, 925, DateTimeKind.Local), "Lora", "Alisha.Abbott26@yahoo.com", "Christina", true, "D'Amore", null, null, 2 },
                    { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", null, new DateTime(2018, 8, 21, 9, 26, 57, 512, DateTimeKind.Local), "Nathaniel", "Simone_Batz56@hotmail.com", "Luz", true, "Douglas", null, null, 1 },
                    { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", null, new DateTime(2018, 8, 21, 9, 40, 25, 982, DateTimeKind.Local), "Hayley", "Brendan45@yahoo.com", "Elisa", true, "Heathcote", null, null, 2 },
                    { "96235b10-9c99-4d76-8d35-454cbe4afd4b", null, new DateTime(2018, 8, 21, 4, 1, 6, 678, DateTimeKind.Local), "Ernesto", "Roma15@hotmail.com", "Donavon", true, "Walsh", null, null, 1 },
                    { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", null, new DateTime(2018, 8, 21, 7, 33, 43, 726, DateTimeKind.Local), "Jovan", "Herbert.Gulgowski87@hotmail.com", "Chad", true, "O'Conner", null, null, 2 },
                    { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", null, new DateTime(2018, 8, 21, 10, 8, 56, 773, DateTimeKind.Local), "Ollie", "Edna_Walker@hotmail.com", "Alec", true, "Feil", null, null, 2 },
                    { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", null, new DateTime(2018, 8, 20, 21, 31, 12, 698, DateTimeKind.Local), "Bernie", "Douglas5@yahoo.com", "Rahul", true, "Smith", null, null, 2 },
                    { "a0af6468-5fc7-47f4-a87d-71473658f8e6", null, new DateTime(2018, 8, 20, 22, 53, 30, 262, DateTimeKind.Local), "Una", "Mabel.Senger83@gmail.com", "Garrett", true, "West", null, null, 2 },
                    { "69176035-4bb8-43e5-8a63-138d422223c3", null, new DateTime(2018, 8, 21, 3, 3, 28, 23, DateTimeKind.Local), "Derick", "Marques_Luettgen22@gmail.com", "Kris", true, "Veum", null, null, 1 },
                    { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", null, new DateTime(2018, 8, 21, 6, 54, 56, 339, DateTimeKind.Local), "Frankie", "Halle88@hotmail.com", "Deron", true, "Moen", null, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "iure" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", "distinctio" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "69176035-4bb8-43e5-8a63-138d422223c3", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "adipisci" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", "et" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 12, 14, 845, DateTimeKind.Local), "Maxime excepturi ut.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 8, 3, 9, 798, DateTimeKind.Local), "Nulla quasi voluptatem et necessitatibus unde aperiam quia beatae.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 23, 51, 56, 918, DateTimeKind.Local), "Autem occaecati placeat accusantium impedit.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 2, 45, 58, 6, DateTimeKind.Local), "Iste consequuntur dignissimos minima ullam eius rerum.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 1, 10, 408, DateTimeKind.Local), "Quia sequi illum sed impedit.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 0, 33, 59, 678, DateTimeKind.Local), "Eum aut eum voluptas.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 2, 32, 48, 63, DateTimeKind.Local), "Atque blanditiis voluptatem quis quisquam aut quia.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 4, 23, 42, 540, DateTimeKind.Local), "Quisquam fuga maxime dolorum tempore.", "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 43, 8, 76, DateTimeKind.Local), "Porro dolore optio non.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 14, 10, 43, 652, DateTimeKind.Local), "Enim corrupti delectus autem.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 21, 4, 59, 58, 35, DateTimeKind.Local), "Delectus adipisci quo repellendus voluptate expedita cumque pariatur.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 21, 10, 14, 9, 443, DateTimeKind.Local), "Quia provident non et velit veniam tenetur inventore omnis.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 21, 12, 2, 44, 163, DateTimeKind.Local), "Rem nesciunt non voluptas.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 21, 8, 48, 26, 148, DateTimeKind.Local), "Amet nemo et expedita nam.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 21, 3, 21, 40, 546, DateTimeKind.Local), "Consectetur distinctio occaecati nesciunt tenetur quibusdam.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 8, 21, 3, 1, 50, 596, DateTimeKind.Local), "Voluptatum unde consequatur atque incidunt eligendi odio vel.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 20, 22, 21, 5, 968, DateTimeKind.Local), "Quod itaque tenetur et.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 15, 1, 5, 714, DateTimeKind.Local), "Et at excepturi hic repellat sunt.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 8, 21, 14, 43, 9, 465, DateTimeKind.Local), "Et impedit omnis.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 23, 2, 34, 160, DateTimeKind.Local), "Iste est omnis qui quisquam aliquid esse sit voluptas porro.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", true });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 1, "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 0, "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 3, "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "06a6f2af-515c-4700-85e9-f1fdc8ad48da" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 2, "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 2, "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 44, 35, 97, DateTimeKind.Local), "Aperiam iusto repellendus dolor temporibus deleniti occaecati et non animi.", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 17, 42, 25, 536, DateTimeKind.Local), 13, "Laudantium quia est deserunt soluta.", "96235b10-9c99-4d76-8d35-454cbe4afd4b" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 8, 53, 20, 648, DateTimeKind.Local), 12, "Et ex consequatur nihil in suscipit qui sunt molestiae sint.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 8, 24, 798, DateTimeKind.Local), 18, "Et qui eum est minima explicabo.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 11, 14, 7, 645, DateTimeKind.Local), 15, "Est numquam et similique.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 16, 39, 3, 660, DateTimeKind.Local), 16, "Est dignissimos sequi nihil quam omnis earum.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 10, 30, 49, 159, DateTimeKind.Local), "Quod fugit nesciunt.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 10, 15, 32, 899, DateTimeKind.Local), 19, "Exercitationem ad sunt dolorem sapiente harum sunt ratione inventore.", "a0af6468-5fc7-47f4-a87d-71473658f8e6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 56, 15, 850, DateTimeKind.Local), 14, "Voluptatem dolores rerum nihil libero corporis deleniti ea est.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 5, 44, 18, 584, DateTimeKind.Local), 12, "Debitis ipsa odit corrupti et repudiandae repellendus.", "69176035-4bb8-43e5-8a63-138d422223c3" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "456.932.2618 x44946", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "Omnis cumque rem in non et enim.", "Loy.Erdman@hotmail.com", "Company336", "https://garnet.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-770-319-7819 x25287", "06a6f2af-515c-4700-85e9-f1fdc8ad48da", "Ea magni omnis minima expedita sapiente dolorem et. Iste quasi quae error provident. Quas qui rerum et a vel qui ullam facilis.", "Levi_Roob@yahoo.com", "Company384", 68, "http://leora.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "294-393-7864 x4089", "a0af6468-5fc7-47f4-a87d-71473658f8e6", "", "Chad_Schneider24@gmail.com", "Company385", 63, "http://jaylon.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(453) 497-8409", "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", "Molestiae qui dolores tenetur possimus itaque ea aut illum perferendis. Perferendis et distinctio repellendus ipsum officia voluptatem rerum aut animi.", "Roy_Trantow@hotmail.com", "Company7", 66, "https://bart.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(976) 496-7823 x34629", "783ab59c-34ee-47dc-be3d-9d0cc68361aa", "Est sit soluta ut corporis veritatis eum eaque tempore. Nemo dolor sed suscipit expedita dolores assumenda soluta occaecati. Delectus commodi ut et qui nisi.", "Carli69@gmail.com", "Company308", 70, "https://evelyn.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "928-640-1960", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", "Qui ut et voluptate repellendus et et. Quo quo et quaerat eveniet tempora suscipit exercitationem molestiae sit. Ut repellat enim atque vel dolores commodi harum. Sit quaerat quia esse excepturi quis et non.", "Arnaldo_King32@hotmail.com", "Company420", 66, "https://kaia.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "833.665.1752 x4997", "69176035-4bb8-43e5-8a63-138d422223c3", "Velit maxime laborum mollitia quia vel molestiae. Et voluptatem minima earum qui velit neque iure nihil.", "Minnie96@hotmail.com", "Company539", 64, "https://watson.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "975-972-3664", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", "Repudiandae ut ipsam velit ex fugit aut. Error sunt laudantium. Occaecati magni eveniet et odit distinctio maiores cumque cum.", "Rosemary.Pollich@gmail.com", "Company723", 64, "http://dane.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(332) 612-1068 x490", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", "Iusto quas aut quas voluptates. Porro ut voluptatibus ab ut rem quia alias facere. Quidem quod quasi aut qui unde illum iste nihil.", "Ludie81@hotmail.com", "Company335", 66, "http://rhea.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-345-632-5890", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", "Nulla sed maiores. Non necessitatibus est esse quibusdam voluptatem ad consectetur. Quia voluptas omnis totam error voluptate. Natus enim provident atque provident accusamus.", "Cora61@hotmail.com", "Company524", 66, "https://elmore.biz" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 9, 39, 9, 837, DateTimeKind.Local), 46, "Dolor est illum voluptas autem.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 19, 9, 19, 706, DateTimeKind.Local), 41, "Voluptatum nihil consequatur.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 19, 57, 58, 299, DateTimeKind.Local), "Sequi velit voluptatem soluta ab sit consequatur.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 56, 6, 947, DateTimeKind.Local), 44, "Qui ipsam non necessitatibus.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 15, 9, 52, 125, DateTimeKind.Local), 43, "Aut aut voluptates consequatur aut officiis.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 11, 26, 7, 656, DateTimeKind.Local), "Qui qui dolores voluptatem rerum consequatur mollitia quia aperiam.", "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 3, 47, 7, 456, DateTimeKind.Local), 41, "Similique blanditiis tempora voluptas et qui officia temporibus non.", "2bd2330f-9ce1-4edb-859a-b854bf6c80fd" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 6, 27, 25, 735, DateTimeKind.Local), 42, "Dolore iure quae consequatur saepe et officia dolores maxime.", "52d682db-3377-4f04-b118-9ee72fba6dca" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 37, 59, 135, DateTimeKind.Local), 44, "Ea nostrum quod error quae veniam.", "eaba4a55-51f2-41fa-9fc7-2379e994cd1a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 21, 18, 8, 23, 376, DateTimeKind.Local), 42, "Placeat doloremque repudiandae qui quidem.", "783ab59c-34ee-47dc-be3d-9d0cc68361aa" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", 73 },
                    { "a0af6468-5fc7-47f4-a87d-71473658f8e6", 76 },
                    { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", 77 },
                    { "52d682db-3377-4f04-b118-9ee72fba6dca", 74 },
                    { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", 78 },
                    { "96235b10-9c99-4d76-8d35-454cbe4afd4b", 75 },
                    { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", 75 },
                    { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", 76 },
                    { "69176035-4bb8-43e5-8a63-138d422223c3", 74 },
                    { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", 78 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "06a6f2af-515c-4700-85e9-f1fdc8ad48da", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2bd2330f-9ce1-4edb-859a-b854bf6c80fd", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "52d682db-3377-4f04-b118-9ee72fba6dca", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5f18554c-a17d-43c9-b2f0-79a37c6ec81e", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "69176035-4bb8-43e5-8a63-138d422223c3", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "783ab59c-34ee-47dc-be3d-9d0cc68361aa", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "96235b10-9c99-4d76-8d35-454cbe4afd4b", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a0af6468-5fc7-47f4-a87d-71473658f8e6", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "eaba4a55-51f2-41fa-9fc7-2379e994cd1a", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a", 76 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "06a6f2af-515c-4700-85e9-f1fdc8ad48da");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2bd2330f-9ce1-4edb-859a-b854bf6c80fd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "52d682db-3377-4f04-b118-9ee72fba6dca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5f18554c-a17d-43c9-b2f0-79a37c6ec81e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69176035-4bb8-43e5-8a63-138d422223c3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "783ab59c-34ee-47dc-be3d-9d0cc68361aa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "96235b10-9c99-4d76-8d35-454cbe4afd4b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a0af6468-5fc7-47f4-a87d-71473658f8e6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "eaba4a55-51f2-41fa-9fc7-2379e994cd1a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ecaad6bf-6f0e-4bde-ae83-c5768f3f407a");

            migrationBuilder.DropColumn(
                name: "WasRead",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded3", "Source2", 88 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Common2", "Source3", 96, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "Source", "Threshold", "Type" },
                values: new object[] { 94, "Source1", 8, 0 });

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
                columns: new[] { "DashboardId", "MostLoaded", "Source", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", "Source1", 43, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 94, "Common3", "Source2", 57 });

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
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 96, "Common2", "Source3", 57 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "Common1", "Source3", 15, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { "MostLoaded2", "Common1", "Source1", 15 });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 15, 12, 26, 449, DateTimeKind.Local), 86, "Title228" });

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
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 23, 48, 15, 537, DateTimeKind.Local), 81, "Title656" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 25, 27, 426, DateTimeKind.Local), 82, "Title598" });

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
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "b9:74:72:80:2e:7e", false, 75, "Instance268" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "34:cd:b1:75:99:1d", false, 75, "Windows", "Instance157" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f8:a5:01:ae:34:9c", false, 73, "Linux", "Instance517" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0b:bb:a7:be:c4:fc", false, 77, "Linux", "Instance846" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "c5:f8:ac:f2:d6:5f", false, 72, "Instance199" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "cc:ee:4a:29:fd:13", false, 75, "Instance975" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "3f:8c:85:fb:6d:79", false, 72, "Linux", "Instance297" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "IsActive", "Platform", "Title" },
                values: new object[] { "79:60:b1:b9:55:00", false, "Linux", "Instance693" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Platform", "Title" },
                values: new object[] { "6f:be:eb:dd:60:1c", false, 75, "Windows", "Instance844" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "IsActive", "OrganizationId", "Title" },
                values: new object[] { "8a:e0:bf:a1:8a:39", false, 75, "Instance751" });

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
                column: "Name",
                value: "Theme548");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme196" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme297" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Frutiger", "Theme292" });

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
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme952" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Theme325");

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
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 8, 20, 1, 21, 29, 326, DateTimeKind.Local), "Nemo aut expedita ut est qui quaerat quis et.", "0070dff4-5df2-46a8-9fdc-55d3e943dfae" });

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
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 8, 20, 4, 3, 37, 835, DateTimeKind.Local), "Provident aspernatur sapiente accusantium quis eum sed quia fugit.", "dc889918-2400-4afb-8e4b-1739f54b1909", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 8, 20, 16, 21, 59, 909, DateTimeKind.Local), "Est assumenda illum.", "b986e454-4e45-4fca-ae3b-2b66c6568f38" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 23, 19, 14, 48, DateTimeKind.Local), "Dolore impedit repudiandae in voluptas fugit vel perspiciatis eaque.", "e0c531cb-0853-479a-b8b0-abf17f4af118", false });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 5, 57, 18, 194, DateTimeKind.Local), "Magnam aut autem ut dicta qui sunt nisi et.", "db8fa606-d6b2-4abc-bb25-7329d8392793" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 20, 20, 39, 14, 724, DateTimeKind.Local), "Qui odio est est iste id nobis.", "e801f449-f5d7-482a-b2e0-a2f448175b94", true });

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
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 3, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "e0c531cb-0853-479a-b8b0-abf17f4af118" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 2, "dc889918-2400-4afb-8e4b-1739f54b1909" });

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
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "35c8b495-2eca-4826-ac63-e76acaa26be4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "dc889918-2400-4afb-8e4b-1739f54b1909" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "5bad4243-e775-4bbd-9263-6c8e5fe999c9" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 5, 44, 13, 891, DateTimeKind.Local), "Voluptas omnis ullam excepturi et similique rem provident quos et.", "334105ba-6abf-4bc4-9fc4-a0a87a22deab" });

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
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 20, 45, 50, 70, DateTimeKind.Local), 13, "Magnam quisquam expedita.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 11, 39, 2, 738, DateTimeKind.Local), "Vel ipsa id quidem non consequatur dolores.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "664.692.2176 x90831", "5bad4243-e775-4bbd-9263-6c8e5fe999c9", "", "Krystina44@yahoo.com", "Company557", "https://madalyn.biz" });

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
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-478-471-9297", "dc889918-2400-4afb-8e4b-1739f54b1909", "", "Julian.Fay@yahoo.com", "Company223", 63, "https://roger.biz" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 0, 46, 40, 11, DateTimeKind.Local), "Aut est rem in.", "e0c531cb-0853-479a-b8b0-abf17f4af118" });

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
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 22, 56, 19, 177, DateTimeKind.Local), "Accusantium accusantium doloribus at.", "e801f449-f5d7-482a-b2e0-a2f448175b94" });

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
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 20, 7, 33, 39, 845, DateTimeKind.Local), 47, "Est laudantium enim at eaque tempora illo est et.", "db8fa606-d6b2-4abc-bb25-7329d8392793" });

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
    }
}
