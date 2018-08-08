using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddFieldsForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "04db4214-f5bb-4449-a4eb-cc485c03244f", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "28d9560d-e2f2-409e-bc0e-8864ea939882", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3008686f-a95c-4e25-b0f7-1ac58ccccefe", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5282bfd7-5a16-4bc0-92d2-354a14217853", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "87f77ff4-670d-4715-9831-a703e38d52ca", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8e70d16d-c344-43d2-a917-0a0e087c8b5a", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a257c7de-ea3b-4c26-ace2-68b0d490577b", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "de8f0970-c1bc-4072-9c76-a5e598e3d6e4", 74 });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3008686f-a95c-4e25-b0f7-1ac58ccccefe");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5282bfd7-5a16-4bc0-92d2-354a14217853");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a257c7de-ea3b-4c26-ace2-68b0d490577b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "de8f0970-c1bc-4072-9c76-a5e598e3d6e4");

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "04db4214-f5bb-4449-a4eb-cc485c03244f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18d3bc15-1982-43a9-a7e0-ef2226ed89e0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28d9560d-e2f2-409e-bc0e-8864ea939882");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "59cd0d8c-07ba-4e60-943f-7a06a967cdfd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "87f77ff4-670d-4715-9831-a703e38d52ca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e70d16d-c344-43d2-a917-0a0e087c8b5a");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChhosedOrganizationId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChoosedOrganizationId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ChoosedOrganizationId",
                table: "Users",
                column: "ChoosedOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organizations_ChoosedOrganizationId",
                table: "Users",
                column: "ChoosedOrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organizations_ChoosedOrganizationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ChoosedOrganizationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChhosedOrganizationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChoosedOrganizationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Users");

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsMute", "Type", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, true, true, 0, 0, null },
                    { 2, false, false, 1, 0, null },
                    { 3, false, true, 0, 0, null },
                    { 4, true, true, 0, 0, null },
                    { 5, false, false, 0, 0, null },
                    { 6, true, false, 0, 0, null },
                    { 7, true, true, 0, 0, null },
                    { 8, true, true, 0, 0, null },
                    { 9, true, true, 0, 0, null },
                    { 10, false, true, 1, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "User" },
                    { 1, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "Name" },
                values: new object[,]
                {
                    { 61, "White", "Helvetica", "Theme261" },
                    { 62, "Gray", "Frutiger", "Theme287" },
                    { 63, "White", "Frutiger", "Theme603" },
                    { 64, "Gray", "Trade", "Theme818" },
                    { 65, "Yellow", "Frutiger", "Theme245" },
                    { 66, "White", "Frutiger", "Theme129" },
                    { 67, "Gray", "Univers", "Theme975" },
                    { 68, "Yellow", "Univers", "Theme299" },
                    { 69, "White", "Trade", "Theme527" },
                    { 70, "Gray", "Frutiger", "Theme105" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "ThemeId" },
                values: new object[,]
                {
                    { 75, "Company192", 70 },
                    { 78, "Company984", 69 },
                    { 73, "Company678", 69 },
                    { 74, "Company233", 68 },
                    { 71, "Company899", 66 },
                    { 76, "Company773", 65 },
                    { 79, "Company177", 62 },
                    { 77, "Company115", 61 },
                    { 72, "Company134", 61 },
                    { 80, "Company25", 69 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "8e70d16d-c344-43d2-a917-0a0e087c8b5a", new DateTime(2018, 8, 7, 21, 37, 36, 351, DateTimeKind.Local), "Tommie", "Gerson.Dare@hotmail.com", "Woodrow", true, 2, "Grimes" },
                    { "3008686f-a95c-4e25-b0f7-1ac58ccccefe", new DateTime(2018, 8, 7, 22, 5, 14, 166, DateTimeKind.Local), "Spencer", "Else.Kunde73@yahoo.com", "Federico", false, 2, "Tromp" },
                    { "28d9560d-e2f2-409e-bc0e-8864ea939882", new DateTime(2018, 8, 8, 17, 3, 45, 697, DateTimeKind.Local), "Ethelyn", "Rhiannon_Breitenberg38@gmail.com", "Jan", true, 2, "Rau" },
                    { "5282bfd7-5a16-4bc0-92d2-354a14217853", new DateTime(2018, 8, 8, 8, 21, 32, 799, DateTimeKind.Local), "Mateo", "Lorena_Blanda@hotmail.com", "Armani", false, 1, "Doyle" },
                    { "04db4214-f5bb-4449-a4eb-cc485c03244f", new DateTime(2018, 8, 8, 16, 51, 25, 653, DateTimeKind.Local), "Maude", "Lorenz47@hotmail.com", "Lora", true, 1, "Quitzon" },
                    { "de8f0970-c1bc-4072-9c76-a5e598e3d6e4", new DateTime(2018, 8, 8, 9, 41, 47, 297, DateTimeKind.Local), "Micah", "Gerson62@hotmail.com", "Keaton", false, 1, "Hilpert" },
                    { "a257c7de-ea3b-4c26-ace2-68b0d490577b", new DateTime(2018, 8, 7, 23, 9, 49, 597, DateTimeKind.Local), "Sigrid", "Kurt58@hotmail.com", "Ross", true, 1, "Herzog" },
                    { "87f77ff4-670d-4715-9831-a703e38d52ca", new DateTime(2018, 8, 8, 7, 57, 12, 296, DateTimeKind.Local), "Sylvan", "Leonor.Graham9@gmail.com", "Rowland", false, 1, "Nader" },
                    { "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", new DateTime(2018, 8, 8, 5, 58, 59, 864, DateTimeKind.Local), "Gideon", "Ardith.Torp@yahoo.com", "Chadd", true, 2, "Kessler" },
                    { "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", new DateTime(2018, 8, 8, 16, 54, 26, 920, DateTimeKind.Local), "Jaylen", "Kyla95@gmail.com", "Jarrod", true, 1, "Stehr" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 25, "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", "est", null, 0 },
                    { 30, "8e70d16d-c344-43d2-a917-0a0e087c8b5a", "nemo", null, 0 },
                    { 24, "8e70d16d-c344-43d2-a917-0a0e087c8b5a", "officia", null, 0 },
                    { 28, "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", "et", null, 0 },
                    { 26, "a257c7de-ea3b-4c26-ace2-68b0d490577b", "voluptas", null, 0 },
                    { 22, "a257c7de-ea3b-4c26-ace2-68b0d490577b", "totam", null, 0 },
                    { 21, "04db4214-f5bb-4449-a4eb-cc485c03244f", "illum", null, 0 },
                    { 27, "87f77ff4-670d-4715-9831-a703e38d52ca", "illum", null, 0 },
                    { 23, "87f77ff4-670d-4715-9831-a703e38d52ca", "aut", null, 0 },
                    { 29, "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", "consectetur", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 49, new DateTime(2018, 8, 8, 10, 49, 39, 119, DateTimeKind.Local), null, "Iure dolores officia nesciunt asperiores occaecati quisquam inventore ratione.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 41, new DateTime(2018, 8, 8, 5, 33, 1, 298, DateTimeKind.Local), null, "Voluptatibus voluptate repellat voluptates aliquid quaerat facilis cupiditate iusto accusamus.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 47, new DateTime(2018, 8, 7, 23, 54, 44, 720, DateTimeKind.Local), null, "Quisquam fugiat laudantium velit.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 45, new DateTime(2018, 8, 8, 14, 7, 30, 856, DateTimeKind.Local), null, "Et sed qui est repellat sed molestiae.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 44, new DateTime(2018, 8, 8, 12, 13, 30, 475, DateTimeKind.Local), null, "Velit incidunt sed consequatur quia exercitationem numquam dolor dolores.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 48, new DateTime(2018, 8, 8, 2, 22, 30, 313, DateTimeKind.Local), null, "Dolores praesentium repellendus modi deleniti quod saepe quia rerum.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 43, new DateTime(2018, 8, 8, 15, 48, 46, 720, DateTimeKind.Local), null, "Non eum quisquam eos porro saepe rerum eos.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 50, new DateTime(2018, 8, 7, 19, 39, 30, 851, DateTimeKind.Local), null, "Quisquam saepe necessitatibus aut.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 42, new DateTime(2018, 8, 8, 5, 10, 14, 614, DateTimeKind.Local), null, "Quis quo consectetur rerum tenetur eaque ad id inventore labore.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 46, new DateTime(2018, 8, 7, 20, 58, 6, 500, DateTimeKind.Local), null, "Facilis quae vel aut sunt sequi harum consectetur odit amet.", "de8f0970-c1bc-4072-9c76-a5e598e3d6e4" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 84, "ea:09:b0:f5:8e:ec", 77, "Linux" },
                    { 88, "18:81:da:b2:46:fa", 71, "Linux" },
                    { 90, "b0:af:03:c1:12:f5", 72, "Windows" },
                    { 89, "dd:74:7b:7c:be:1b", 72, "Windows" },
                    { 85, "0d:94:12:18:0e:a7", 72, "Windows" },
                    { 82, "f0:84:8d:89:10:d1", 73, "Linux" },
                    { 86, "68:e0:2c:92:82:72", 73, "Linux" },
                    { 87, "f9:57:02:26:72:6a", 71, "Windows" },
                    { 83, "1a:df:7e:6b:a1:3f", 76, "Windows" },
                    { 81, "e1:a0:23:c5:bb:f7", 80, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 120, new DateTime(2018, 8, 7, 22, 13, 31, 533, DateTimeKind.Local), 8, null, "Doloribus rerum dolor.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0" },
                    { 119, new DateTime(2018, 8, 8, 16, 20, 47, 373, DateTimeKind.Local), 3, null, "Ut odio maiores voluptate aut.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0" },
                    { 114, new DateTime(2018, 8, 8, 2, 7, 30, 988, DateTimeKind.Local), 8, null, "Est qui vel.", "28d9560d-e2f2-409e-bc0e-8864ea939882" },
                    { 116, new DateTime(2018, 8, 8, 6, 20, 7, 50, DateTimeKind.Local), 8, null, "Cumque quia dolores deserunt libero unde ut.", "5282bfd7-5a16-4bc0-92d2-354a14217853" },
                    { 112, new DateTime(2018, 8, 7, 19, 21, 31, 714, DateTimeKind.Local), 10, null, "Dolorem vel ab dignissimos aliquid ut iusto dolor quis quam.", "a257c7de-ea3b-4c26-ace2-68b0d490577b" },
                    { 115, new DateTime(2018, 8, 8, 1, 57, 43, 99, DateTimeKind.Local), 3, null, "Atque quas aut placeat non modi ipsam unde harum sit.", "a257c7de-ea3b-4c26-ace2-68b0d490577b" },
                    { 117, new DateTime(2018, 8, 8, 17, 36, 3, 729, DateTimeKind.Local), 10, null, "Eum quos maxime velit et placeat cupiditate iusto sit quis.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 111, new DateTime(2018, 8, 8, 14, 41, 6, 217, DateTimeKind.Local), 9, null, "Totam incidunt cum tempora.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a" },
                    { 113, new DateTime(2018, 8, 8, 12, 9, 47, 989, DateTimeKind.Local), 6, null, "Non quas minus iste et enim aut sit sint.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 118, new DateTime(2018, 8, 8, 1, 26, 38, 335, DateTimeKind.Local), 6, null, "Sit repellat laudantium.", "de8f0970-c1bc-4072-9c76-a5e598e3d6e4" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "3008686f-a95c-4e25-b0f7-1ac58ccccefe", 73 },
                    { "de8f0970-c1bc-4072-9c76-a5e598e3d6e4", 74 },
                    { "87f77ff4-670d-4715-9831-a703e38d52ca", 74 },
                    { "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", 76 },
                    { "5282bfd7-5a16-4bc0-92d2-354a14217853", 77 },
                    { "04db4214-f5bb-4449-a4eb-cc485c03244f", 77 },
                    { "a257c7de-ea3b-4c26-ace2-68b0d490577b", 77 },
                    { "28d9560d-e2f2-409e-bc0e-8864ea939882", 72 },
                    { "8e70d16d-c344-43d2-a917-0a0e087c8b5a", 76 },
                    { "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", 73 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 93, new DateTime(2018, 8, 8, 7, 44, 4, 222, DateTimeKind.Local), 81, "Title639" },
                    { 94, new DateTime(2018, 8, 8, 6, 34, 19, 700, DateTimeKind.Local), 86, "Title549" },
                    { 100, new DateTime(2018, 8, 7, 22, 24, 1, 236, DateTimeKind.Local), 82, "Title601" },
                    { 95, new DateTime(2018, 8, 8, 14, 25, 6, 498, DateTimeKind.Local), 88, "Title430" },
                    { 92, new DateTime(2018, 8, 8, 6, 12, 15, 765, DateTimeKind.Local), 87, "Title215" },
                    { 96, new DateTime(2018, 8, 7, 22, 49, 8, 122, DateTimeKind.Local), 83, "Title52" },
                    { 99, new DateTime(2018, 8, 8, 8, 55, 33, 516, DateTimeKind.Local), 90, "Title136" },
                    { 91, new DateTime(2018, 8, 8, 2, 1, 38, 260, DateTimeKind.Local), 90, "Title467" },
                    { 97, new DateTime(2018, 8, 8, 4, 42, 50, 405, DateTimeKind.Local), 85, "Title867" },
                    { 98, new DateTime(2018, 8, 8, 11, 52, 46, 275, DateTimeKind.Local), 86, "Title759" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 36, 30, new DateTime(2018, 8, 8, 13, 48, 0, 876, DateTimeKind.Local), "Ipsam nemo repellat non est qui pariatur voluptatum.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe", true },
                    { 39, 28, new DateTime(2018, 8, 7, 21, 48, 3, 998, DateTimeKind.Local), "Nesciunt et vitae commodi voluptas quia qui laudantium.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", true },
                    { 32, 28, new DateTime(2018, 8, 8, 11, 13, 5, 258, DateTimeKind.Local), "Adipisci adipisci quo quis iure ipsum et iure aut.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0", true },
                    { 31, 25, new DateTime(2018, 8, 8, 10, 2, 36, 403, DateTimeKind.Local), "Deleniti quo blanditiis sunt.", "a257c7de-ea3b-4c26-ace2-68b0d490577b", false },
                    { 33, 21, new DateTime(2018, 8, 7, 20, 15, 3, 172, DateTimeKind.Local), "Ratione explicabo fugit similique assumenda reprehenderit.", "8e70d16d-c344-43d2-a917-0a0e087c8b5a", true },
                    { 38, 27, new DateTime(2018, 8, 8, 14, 36, 22, 130, DateTimeKind.Local), "Sed et est officia temporibus voluptatem at error molestiae molestiae.", "28d9560d-e2f2-409e-bc0e-8864ea939882", true },
                    { 35, 27, new DateTime(2018, 8, 8, 16, 14, 17, 433, DateTimeKind.Local), "Non dolor ducimus ut aut.", "28d9560d-e2f2-409e-bc0e-8864ea939882", false },
                    { 37, 23, new DateTime(2018, 8, 8, 9, 21, 26, 18, DateTimeKind.Local), "Commodi incidunt incidunt.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd", false },
                    { 40, 29, new DateTime(2018, 8, 7, 23, 36, 22, 505, DateTimeKind.Local), "Sunt eius quo dignissimos et.", "a257c7de-ea3b-4c26-ace2-68b0d490577b", false },
                    { 34, 29, new DateTime(2018, 8, 7, 23, 0, 23, 633, DateTimeKind.Local), "Suscipit aut aut sequi sit vero sunt.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe", false }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 51, new DateTime(2018, 8, 8, 12, 0, 49, 912, DateTimeKind.Local), 44, "Neque ratione eligendi quam amet voluptatem deserunt voluptas fugiat.", "04db4214-f5bb-4449-a4eb-cc485c03244f" },
                    { 54, new DateTime(2018, 8, 8, 18, 6, 30, 282, DateTimeKind.Local), 43, "Architecto in eveniet ea adipisci necessitatibus et quidem.", "18d3bc15-1982-43a9-a7e0-ef2226ed89e0" },
                    { 55, new DateTime(2018, 8, 8, 13, 50, 12, 153, DateTimeKind.Local), 43, "Recusandae nesciunt ut ut veritatis eveniet sed.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 57, new DateTime(2018, 8, 8, 10, 50, 41, 893, DateTimeKind.Local), 47, "Omnis quasi optio sequi neque reiciendis sit laborum.", "5282bfd7-5a16-4bc0-92d2-354a14217853" },
                    { 56, new DateTime(2018, 8, 8, 7, 0, 55, 633, DateTimeKind.Local), 47, "Quisquam sunt quod voluptatibus totam voluptas hic in repellat.", "a257c7de-ea3b-4c26-ace2-68b0d490577b" },
                    { 53, new DateTime(2018, 8, 7, 21, 21, 13, 322, DateTimeKind.Local), 47, "Et amet enim ut et qui pariatur autem sit aliquid.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 60, new DateTime(2018, 8, 8, 17, 44, 25, 390, DateTimeKind.Local), 41, "Corrupti doloribus velit delectus.", "59cd0d8c-07ba-4e60-943f-7a06a967cdfd" },
                    { 52, new DateTime(2018, 8, 8, 6, 54, 18, 315, DateTimeKind.Local), 41, "Aut aut a minus dolores tempore.", "5282bfd7-5a16-4bc0-92d2-354a14217853" },
                    { 58, new DateTime(2018, 8, 8, 5, 34, 14, 607, DateTimeKind.Local), 44, "Qui sint nostrum ut saepe qui fuga voluptas.", "87f77ff4-670d-4715-9831-a703e38d52ca" },
                    { 59, new DateTime(2018, 8, 8, 14, 36, 39, 998, DateTimeKind.Local), 45, "Et suscipit enim illo consequuntur labore.", "3008686f-a95c-4e25-b0f7-1ac58ccccefe" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 108, 99, "MostLoaded3", "Common2", "Source1", 34, 1 },
                    { 105, 96, "MostLoaded3", "Common3", "Source1", 16, 1 },
                    { 101, 92, "MostLoaded3", "Common3", "Source2", 93, 0 },
                    { 103, 95, "MostLoaded1", "Common1", "Source3", 50, 2 },
                    { 110, 95, "MostLoaded3", "Common1", "Source3", 61, 1 },
                    { 102, 100, "MostLoaded1", "Common2", "Source2", 15, 1 },
                    { 107, 100, "MostLoaded3", "Common3", "Source1", 77, 1 },
                    { 109, 98, "MostLoaded1", "Common3", "Source1", 19, 2 },
                    { 104, 93, "MostLoaded2", "Common1", "Source1", 3, 2 },
                    { 106, 93, "MostLoaded1", "Common2", "Source3", 5, 1 }
                });
        }
    }
}
