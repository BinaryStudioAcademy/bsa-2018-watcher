using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddFieldsToUser : Migration
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
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80);

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
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "54179531-bb49-4e4f-9c03-48fe4d5c430a", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "65397671-3a9c-437c-97b0-4ea3309c82e8", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8bd9ceb7-2599-4270-8cb1-4133bf305731", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9dac3529-7462-48ab-99ea-df3e17506402", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c716da2b-a608-4e2d-b525-a164e2f0aa12", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e5f54f66-0cb0-46b9-857f-9aca56305c3d", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", 77 });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24);

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
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91);

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
                keyValue: 94);

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
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45);

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
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9dac3529-7462-48ab-99ea-df3e17506402");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8a4e5e2-ef65-46d8-adba-9f341e3cd924");

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
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0c24406d-3139-4e89-a48d-53a9ff4c7bfc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "54179531-bb49-4e4f-9c03-48fe4d5c430a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65397671-3a9c-437c-97b0-4ea3309c82e8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8bd9ceb7-2599-4270-8cb1-4133bf305731");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c716da2b-a608-4e2d-b525-a164e2f0aa12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e5f54f66-0cb0-46b9-857f-9aca56305c3d");

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79);

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
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

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
                columns: new[] { "Id", "IsDisable", "IsMute", "Type" },
                values: new object[,]
                {
                    { 1, false, false, 1 },
                    { 2, false, true, 1 },
                    { 3, true, true, 0 },
                    { 4, true, true, 0 },
                    { 5, false, true, 1 },
                    { 6, true, false, 0 },
                    { 7, true, true, 1 },
                    { 8, true, true, 1 },
                    { 9, false, true, 1 },
                    { 10, true, true, 1 }
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
                    { 61, "Yellow", "Frutiger", "Theme413" },
                    { 62, "Yellow", "Helvetica", "Theme910" },
                    { 63, "Gray", "Trade", "Theme0" },
                    { 64, "Gray", "Helvetica", "Theme527" },
                    { 65, "Gray", "Univers", "Theme895" },
                    { 66, "Yellow", "Trade", "Theme633" },
                    { 67, "Gray", "Helvetica", "Theme264" },
                    { 68, "White", "Univers", "Theme315" },
                    { 69, "Yellow", "Trade", "Theme936" },
                    { 70, "Gray", "Helvetica", "Theme875" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "ThemeId" },
                values: new object[,]
                {
                    { 79, "Company957", 70 },
                    { 74, "Company874", 69 },
                    { 76, "Company306", 68 },
                    { 73, "Company311", 68 },
                    { 71, "Company460", 68 },
                    { 80, "Company550", 66 },
                    { 77, "Company237", 64 },
                    { 75, "Company106", 62 },
                    { 72, "Company996", 61 },
                    { 78, "Company590", 69 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "NotificationSettingId", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "c716da2b-a608-4e2d-b525-a164e2f0aa12", new DateTime(2018, 8, 7, 10, 9, 45, 917, DateTimeKind.Local), "Katelin85@yahoo.com", "Evans", false, 2, 2, "Weimann" },
                    { "e5f54f66-0cb0-46b9-857f-9aca56305c3d", new DateTime(2018, 8, 6, 15, 2, 30, 954, DateTimeKind.Local), "Davin26@gmail.com", "Nat", true, 8, 2, "Kuhn" },
                    { "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", new DateTime(2018, 8, 7, 10, 17, 11, 816, DateTimeKind.Local), "Chris_Ebert@hotmail.com", "Isidro", false, 10, 2, "Daugherty" },
                    { "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", new DateTime(2018, 8, 6, 14, 21, 50, 88, DateTimeKind.Local), "Josiah.VonRueden@hotmail.com", "Hollis", true, 8, 2, "Howe" },
                    { "65397671-3a9c-437c-97b0-4ea3309c82e8", new DateTime(2018, 8, 7, 8, 5, 28, 829, DateTimeKind.Local), "Violet60@yahoo.com", "Maci", false, 6, 2, "Walker" },
                    { "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", new DateTime(2018, 8, 6, 16, 12, 4, 759, DateTimeKind.Local), "Kali85@hotmail.com", "Chaya", true, 5, 1, "Littel" },
                    { "9dac3529-7462-48ab-99ea-df3e17506402", new DateTime(2018, 8, 7, 6, 5, 17, 127, DateTimeKind.Local), "Kylee1@yahoo.com", "Bernhard", true, 1, 1, "Graham" },
                    { "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", new DateTime(2018, 8, 6, 16, 44, 27, 881, DateTimeKind.Local), "Mandy10@yahoo.com", "Desmond", true, 10, 1, "Paucek" },
                    { "8bd9ceb7-2599-4270-8cb1-4133bf305731", new DateTime(2018, 8, 6, 23, 26, 15, 71, DateTimeKind.Local), "Elody_Gorczany@gmail.com", "Jermain", true, 7, 2, "Marvin" },
                    { "54179531-bb49-4e4f-9c03-48fe4d5c430a", new DateTime(2018, 8, 7, 5, 31, 0, 489, DateTimeKind.Local), "Mose_Terry@yahoo.com", "Velva", false, 2, 1, "Kerluke" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 25, "54179531-bb49-4e4f-9c03-48fe4d5c430a", "earum", null, 0 },
                    { 26, "54179531-bb49-4e4f-9c03-48fe4d5c430a", "ab", null, 0 },
                    { 23, "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", "ut", null, 0 },
                    { 24, "c716da2b-a608-4e2d-b525-a164e2f0aa12", "amet", null, 0 },
                    { 22, "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", "qui", null, 0 },
                    { 27, "65397671-3a9c-437c-97b0-4ea3309c82e8", "voluptatem", null, 0 },
                    { 29, "65397671-3a9c-437c-97b0-4ea3309c82e8", "quam", null, 0 },
                    { 21, "e5f54f66-0cb0-46b9-857f-9aca56305c3d", "est", null, 0 },
                    { 30, "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", "similique", null, 0 },
                    { 28, "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", "est", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 49, new DateTime(2018, 8, 7, 9, 42, 1, 670, DateTimeKind.Local), null, "Eligendi officia eligendi soluta rem.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 47, new DateTime(2018, 8, 6, 18, 36, 20, 29, DateTimeKind.Local), null, "Consequatur voluptatum dolorem nisi natus doloremque quisquam adipisci dolorem necessitatibus.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 42, new DateTime(2018, 8, 7, 4, 28, 59, 172, DateTimeKind.Local), null, "Et possimus odit.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 46, new DateTime(2018, 8, 6, 18, 48, 44, 429, DateTimeKind.Local), null, "Inventore quod quo sit sed accusantium.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 41, new DateTime(2018, 8, 7, 3, 15, 31, 451, DateTimeKind.Local), null, "Animi dolores ab soluta nisi suscipit maiores enim ut.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 48, new DateTime(2018, 8, 7, 3, 9, 17, 767, DateTimeKind.Local), null, "Enim debitis explicabo sunt.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 43, new DateTime(2018, 8, 6, 23, 57, 51, 573, DateTimeKind.Local), null, "Qui tenetur non similique omnis at at qui.", "65397671-3a9c-437c-97b0-4ea3309c82e8" },
                    { 50, new DateTime(2018, 8, 6, 16, 8, 13, 954, DateTimeKind.Local), null, "Cupiditate id molestiae repellendus laudantium magni voluptatem et minus aut.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 45, new DateTime(2018, 8, 7, 12, 49, 58, 220, DateTimeKind.Local), null, "Eum cum ratione.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 44, new DateTime(2018, 8, 7, 2, 36, 28, 416, DateTimeKind.Local), null, "Ut perspiciatis natus.", "9dac3529-7462-48ab-99ea-df3e17506402" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 82, "35:0a:9c:68:71:a3", 75, "Windows" },
                    { 84, "de:b1:ef:09:b5:0f", 78, "Linux" },
                    { 86, "71:71:07:84:bc:2e", 74, "Linux" },
                    { 89, "47:16:45:b7:45:01", 76, "Windows" },
                    { 87, "88:9e:aa:c3:cb:11", 71, "Windows" },
                    { 85, "23:b9:5d:6b:d3:c4", 71, "Linux" },
                    { 88, "95:61:f7:7d:66:cd", 77, "Linux" },
                    { 90, "c7:b1:0c:a9:77:56", 72, "Linux" },
                    { 83, "54:c9:a9:7d:1a:7e", 79, "Windows" },
                    { 81, "29:70:47:d6:2f:56", 79, "Windows" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 119, new DateTime(2018, 8, 7, 4, 54, 48, 807, DateTimeKind.Local), 9, null, "Voluptas sunt est et saepe et deserunt ut dolor.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 115, new DateTime(2018, 8, 7, 0, 42, 48, 217, DateTimeKind.Local), 1, null, "Qui cum fuga.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 112, new DateTime(2018, 8, 7, 6, 26, 11, 599, DateTimeKind.Local), 5, null, "Blanditiis harum non rerum.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 118, new DateTime(2018, 8, 7, 10, 14, 0, 472, DateTimeKind.Local), 5, null, "Sit animi tenetur expedita commodi aut.", "e5f54f66-0cb0-46b9-857f-9aca56305c3d" },
                    { 111, new DateTime(2018, 8, 7, 9, 38, 53, 38, DateTimeKind.Local), 1, null, "Nulla labore eos eius inventore unde praesentium.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c" },
                    { 116, new DateTime(2018, 8, 6, 17, 48, 33, 300, DateTimeKind.Local), 5, null, "Voluptatibus adipisci voluptatem laboriosam non autem dolorem sit.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 120, new DateTime(2018, 8, 6, 20, 30, 57, 572, DateTimeKind.Local), 7, null, "Porro modi et saepe nobis error amet pariatur numquam totam.", "f8a4e5e2-ef65-46d8-adba-9f341e3cd924" },
                    { 114, new DateTime(2018, 8, 6, 13, 31, 36, 481, DateTimeKind.Local), 5, null, "Veniam omnis sed odit eos possimus natus asperiores nesciunt.", "9dac3529-7462-48ab-99ea-df3e17506402" },
                    { 117, new DateTime(2018, 8, 6, 16, 24, 11, 249, DateTimeKind.Local), 8, null, "Sint qui quia officiis qui quo molestiae saepe.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 113, new DateTime(2018, 8, 6, 21, 8, 55, 355, DateTimeKind.Local), 6, null, "Aut odio molestias accusantium quasi illo eaque id et.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f8a4e5e2-ef65-46d8-adba-9f341e3cd924", 77 },
                    { "9dac3529-7462-48ab-99ea-df3e17506402", 77 },
                    { "8bd9ceb7-2599-4270-8cb1-4133bf305731", 77 },
                    { "c716da2b-a608-4e2d-b525-a164e2f0aa12", 75 },
                    { "65397671-3a9c-437c-97b0-4ea3309c82e8", 75 },
                    { "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", 71 },
                    { "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", 76 },
                    { "e5f54f66-0cb0-46b9-857f-9aca56305c3d", 72 },
                    { "54179531-bb49-4e4f-9c03-48fe4d5c430a", 78 },
                    { "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", 78 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 98, new DateTime(2018, 8, 7, 4, 10, 3, 481, DateTimeKind.Local), 83, "Title100" },
                    { 94, new DateTime(2018, 8, 7, 0, 57, 36, 913, DateTimeKind.Local), 86, "Title444" },
                    { 91, new DateTime(2018, 8, 6, 19, 36, 39, 124, DateTimeKind.Local), 86, "Title689" },
                    { 93, new DateTime(2018, 8, 6, 20, 32, 38, 868, DateTimeKind.Local), 89, "Title69" },
                    { 100, new DateTime(2018, 8, 7, 0, 33, 38, 200, DateTimeKind.Local), 88, "Title663" },
                    { 92, new DateTime(2018, 8, 6, 13, 25, 42, 122, DateTimeKind.Local), 88, "Title87" },
                    { 99, new DateTime(2018, 8, 7, 6, 40, 9, 381, DateTimeKind.Local), 82, "Title247" },
                    { 97, new DateTime(2018, 8, 7, 10, 49, 8, 579, DateTimeKind.Local), 90, "Title523" },
                    { 96, new DateTime(2018, 8, 6, 22, 58, 49, 65, DateTimeKind.Local), 90, "Title648" },
                    { 95, new DateTime(2018, 8, 6, 16, 10, 43, 612, DateTimeKind.Local), 83, "Title642" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 35, 24, new DateTime(2018, 8, 7, 4, 41, 8, 677, DateTimeKind.Local), "Ullam saepe eum voluptate animi ut ut saepe.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", true },
                    { 31, 24, new DateTime(2018, 8, 6, 13, 49, 41, 569, DateTimeKind.Local), "Quasi quis qui quisquam odio id.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe", true },
                    { 33, 25, new DateTime(2018, 8, 6, 21, 5, 35, 880, DateTimeKind.Local), "Nihil nostrum quo et consequuntur corrupti quisquam.", "9dac3529-7462-48ab-99ea-df3e17506402", true },
                    { 36, 27, new DateTime(2018, 8, 6, 21, 13, 22, 350, DateTimeKind.Local), "Quisquam nemo ducimus provident.", "9dac3529-7462-48ab-99ea-df3e17506402", false },
                    { 38, 28, new DateTime(2018, 8, 7, 13, 7, 6, 608, DateTimeKind.Local), "Pariatur aperiam quo doloribus nisi vitae nulla.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", true },
                    { 34, 25, new DateTime(2018, 8, 6, 22, 33, 0, 613, DateTimeKind.Local), "Ipsam aut voluptatem et ipsam alias velit laudantium occaecati inventore.", "54179531-bb49-4e4f-9c03-48fe4d5c430a", false },
                    { 37, 29, new DateTime(2018, 8, 7, 11, 26, 51, 125, DateTimeKind.Local), "Error unde voluptatem dolorum voluptas beatae consequatur et explicabo.", "9dac3529-7462-48ab-99ea-df3e17506402", false },
                    { 40, 25, new DateTime(2018, 8, 7, 8, 46, 41, 851, DateTimeKind.Local), "Saepe non maxime voluptatem.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", false },
                    { 39, 23, new DateTime(2018, 8, 7, 6, 37, 11, 73, DateTimeKind.Local), "Non est voluptas qui eum commodi et totam.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc", true },
                    { 32, 29, new DateTime(2018, 8, 7, 9, 40, 43, 473, DateTimeKind.Local), "Qui at numquam.", "1ebcd497-ea1f-4f45-a9c3-b7782bcc027c", false }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 53, new DateTime(2018, 8, 6, 21, 12, 14, 291, DateTimeKind.Local), 45, "Accusamus voluptate sed dolor.", "54179531-bb49-4e4f-9c03-48fe4d5c430a" },
                    { 56, new DateTime(2018, 8, 7, 9, 12, 43, 44, DateTimeKind.Local), 45, "Omnis sit consequatur incidunt nam magni.", "8bd9ceb7-2599-4270-8cb1-4133bf305731" },
                    { 57, new DateTime(2018, 8, 7, 8, 43, 6, 648, DateTimeKind.Local), 42, "Debitis architecto veritatis quaerat.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 54, new DateTime(2018, 8, 7, 6, 53, 3, 856, DateTimeKind.Local), 46, "Nihil aut aut consequatur ea rem ut assumenda dolorem non.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 60, new DateTime(2018, 8, 6, 22, 12, 5, 785, DateTimeKind.Local), 49, "Ut nihil impedit.", "0c24406d-3139-4e89-a48d-53a9ff4c7bfc" },
                    { 58, new DateTime(2018, 8, 6, 18, 5, 12, 418, DateTimeKind.Local), 49, "Officia doloribus architecto voluptas.", "f8a4e5e2-ef65-46d8-adba-9f341e3cd924" },
                    { 51, new DateTime(2018, 8, 7, 10, 19, 44, 734, DateTimeKind.Local), 49, "Deleniti voluptatem magni.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 55, new DateTime(2018, 8, 7, 6, 25, 13, 418, DateTimeKind.Local), 43, "Suscipit commodi reiciendis quis adipisci dolorem omnis aut non pariatur.", "acc88de3-e94d-46f3-a04d-07b0c5bdb0fe" },
                    { 59, new DateTime(2018, 8, 6, 13, 30, 5, 871, DateTimeKind.Local), 45, "Ut voluptatem sit neque occaecati assumenda labore et.", "c716da2b-a608-4e2d-b525-a164e2f0aa12" },
                    { 52, new DateTime(2018, 8, 7, 8, 26, 3, 794, DateTimeKind.Local), 48, "Sapiente ut perspiciatis animi accusantium ea.", "9dac3529-7462-48ab-99ea-df3e17506402" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 109, 96, "MostLoaded1", "Common2", "Source3", 86, 0 },
                    { 102, 99, "MostLoaded1", "Common3", "Source1", 12, 1 },
                    { 103, 99, "MostLoaded2", "Common1", "Source2", 78, 2 },
                    { 101, 92, "MostLoaded1", "Common2", "Source1", 3, 1 },
                    { 108, 92, "MostLoaded2", "Common3", "Source3", 54, 1 },
                    { 106, 93, "MostLoaded1", "Common2", "Source3", 12, 2 },
                    { 104, 91, "MostLoaded1", "Common3", "Source3", 0, 1 },
                    { 110, 91, "MostLoaded3", "Common1", "Source2", 15, 2 },
                    { 107, 94, "MostLoaded2", "Common2", "Source3", 35, 0 },
                    { 105, 95, "MostLoaded2", "Common2", "Source1", 22, 1 }
                });
        }
    }
}
