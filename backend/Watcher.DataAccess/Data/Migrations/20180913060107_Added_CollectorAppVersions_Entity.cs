using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Added_CollectorAppVersions_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", 63 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "64f2bf53-0184-44f6-b778-c46ebd040968", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cca3fb1b-6b17-4629-bb52-b06163ed3252", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cfdc2394-bcac-467f-9bd1-b099c449549a", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", 69 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26de10ee-aa98-4b31-b719-b1bb4fb57d8d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "50593a1b-bc00-4fae-8ad9-7077d3fe19ee");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "64f2bf53-0184-44f6-b778-c46ebd040968");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6eaef575-0500-4c20-b59b-03f452842bdf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c7cb6c73-9895-498f-a06b-33597f76d4c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cca3fb1b-6b17-4629-bb52-b06163ed3252");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cfdc2394-bcac-467f-9bd1-b099c449549a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8a2257c-6f5b-420f-b475-716fa7dccd4a");

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
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 81, 95 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 86, 43 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 36, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 89, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 58, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 89, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                column: "Threshold",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 18, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 88, 64, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 34, 3, 52, DateTimeKind.Local), 74, "Title300" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 6, 30, 909, DateTimeKind.Local), 80, "Title301" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 59, 54, 121, DateTimeKind.Local), 78, "Title763" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 43, 28, 478, DateTimeKind.Local), "Title244" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 0, 10, 41, DateTimeKind.Local), 79, "Title203" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 12, 41, 18, 163, DateTimeKind.Local), 79, "Title911" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 54, 58, 836, DateTimeKind.Local), 78, "Title533" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 13, 3, 6, 31, 580, DateTimeKind.Local), 73, "Title768" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 26, 46, 239, DateTimeKind.Local), 78, "Title955" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 34, 29, 486, DateTimeKind.Local), 79, "Title388" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "78:02:26:0c:e4:c8", 63, "Linux", "Instance162" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ba:72:c1:b4:fd:29", 70, "Linux", "Instance783" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "48:dc:0f:5d:77:4d", 69, "Instance36" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a0:e0:a8:b3:42:1c", 66, "Linux", "Instance596" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "16:8c:fe:ea:6a:16", 64, "Windows", "Instance760" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "ad:fd:d2:67:fa:9c", 70, "Linux", "Instance415" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f0:5f:f4:b1:7b:da", 68, "Linux", "Instance582" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "92:e9:6a:32:ab:bc", "Windows", "Instance445" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "f2:1a:7b:0a:69:a2", 61, "Windows", "Instance948" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "29:cd:7e:2b:e7:b7", 66, "Instance719" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "9939ac91-9e2a-4381-bddb-147506b6b5d3", null, new DateTime(2018, 9, 12, 12, 52, 9, 475, DateTimeKind.Local), "Xander", "Hipolito.Armstrong18@yahoo.com", null, "Enos", true, false, "Dicki", null, "https://s3.amazonaws.com/uifaces/faces/twitter/matthewkay_/128.jpg", 2 },
                    { "7db6b06e-1b5a-4cad-836c-1467243ef929", null, new DateTime(2018, 9, 12, 12, 38, 41, 272, DateTimeKind.Local), "Zelma", "Carmine56@hotmail.com", null, "Fausto", true, false, "Shanahan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nsamoylov/128.jpg", 1 },
                    { "1e4e1d3e-8076-43bd-bd3c-5987739a71dc", null, new DateTime(2018, 9, 13, 6, 21, 39, 532, DateTimeKind.Local), "Rigoberto", "Christelle67@hotmail.com", null, "Lorine", true, false, "Bernhard", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mds/128.jpg", 2 },
                    { "fc1af5c2-5260-4979-a30d-6c49759955ba", null, new DateTime(2018, 9, 12, 17, 40, 57, 3, DateTimeKind.Local), "Destiny", "Kelly52@gmail.com", null, "Ofelia", true, false, "Kuhic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jamiebrittain/128.jpg", 1 },
                    { "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31", null, new DateTime(2018, 9, 13, 2, 54, 20, 374, DateTimeKind.Local), "Furman", "Gail.Little@hotmail.com", null, "Brandy", true, false, "Dare", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gaborenton/128.jpg", 1 },
                    { "32d7cde9-73c3-405a-ba2f-fbdda364d9dd", null, new DateTime(2018, 9, 12, 15, 8, 37, 355, DateTimeKind.Local), "Estrella", "Bryon.Kutch@yahoo.com", null, "Candido", true, false, "Heller", null, "https://s3.amazonaws.com/uifaces/faces/twitter/heykenneth/128.jpg", 2 },
                    { "43c24b44-2dab-478d-b5e5-72e951c390ab", null, new DateTime(2018, 9, 12, 15, 27, 34, 77, DateTimeKind.Local), "Johnathon", "Barry24@yahoo.com", null, "Marianne", true, false, "Bednar", null, "https://s3.amazonaws.com/uifaces/faces/twitter/richwild/128.jpg", 1 },
                    { "3c753ffd-420a-4b93-b091-01ac55aaeff3", null, new DateTime(2018, 9, 12, 14, 40, 18, 62, DateTimeKind.Local), "Madilyn", "Gracie.Mante@yahoo.com", null, "Josiah", true, false, "Weissnat", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kaysix_dizzy/128.jpg", 1 },
                    { "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a", null, new DateTime(2018, 9, 13, 0, 6, 19, 978, DateTimeKind.Local), "Sydney", "Vincenzo_Stamm95@hotmail.com", null, "Eleazar", true, false, "Harris", null, "https://s3.amazonaws.com/uifaces/faces/twitter/matt3224/128.jpg", 1 },
                    { "8054cd22-9b52-4575-a04c-ae76707de796", null, new DateTime(2018, 9, 12, 15, 11, 12, 531, DateTimeKind.Local), "Doug", "Imelda9@hotmail.com", null, "Jessika", true, false, "Haley", null, "https://s3.amazonaws.com/uifaces/faces/twitter/illyzoren/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43c24b44-2dab-478d-b5e5-72e951c390ab", "voluptates" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8054cd22-9b52-4575-a04c-ae76707de796", "nisi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43c24b44-2dab-478d-b5e5-72e951c390ab", "repellendus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "3c753ffd-420a-4b93-b091-01ac55aaeff3", "nulla" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedById",
                value: "8054cd22-9b52-4575-a04c-ae76707de796");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43c24b44-2dab-478d-b5e5-72e951c390ab", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8054cd22-9b52-4575-a04c-ae76707de796", "quia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7db6b06e-1b5a-4cad-836c-1467243ef929", "corporis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "43c24b44-2dab-478d-b5e5-72e951c390ab", "quia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9939ac91-9e2a-4381-bddb-147506b6b5d3", "deserunt" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 1, 19, 45, 806, DateTimeKind.Local), "Repudiandae et sit dolor consequuntur error voluptas temporibus molestias quas.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 7, 49, 43, 629, DateTimeKind.Local), "Ut accusamus aut.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 16, 30, 968, DateTimeKind.Local), "Sit qui magnam tempore laborum est.", "1e4e1d3e-8076-43bd-bd3c-5987739a71dc" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 54, 51, 197, DateTimeKind.Local), "Ea est repellat in eligendi quis.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 50, 2, 253, DateTimeKind.Local), "Sed et delectus deserunt est velit expedita soluta quasi.", "8054cd22-9b52-4575-a04c-ae76707de796" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 7, 36, 3, 605, DateTimeKind.Local), "Vel facere suscipit rerum et.", "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 58, 6, 857, DateTimeKind.Local), "Quisquam similique et suscipit ea eum eos quas et qui.", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 8, 2, 160, DateTimeKind.Local), "Ad excepturi molestiae odio quod ipsum ab perferendis non.", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 5, 15, 762, DateTimeKind.Local), "Voluptatem officia eveniet distinctio excepturi.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 21, 36, 54, 759, DateTimeKind.Local), "Quia fugit delectus.", "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 13, 6, 0, 12, 8, DateTimeKind.Local), "Maiores qui hic quas id.", "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 13, 8, 49, 30, 640, DateTimeKind.Local), "Est aut debitis.", "32d7cde9-73c3-405a-ba2f-fbdda364d9dd", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 13, 6, 55, 51, 236, DateTimeKind.Local), "Reprehenderit atque ut possimus est vel et nesciunt et.", "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 15, 44, 53, 746, DateTimeKind.Local), "Perferendis impedit et recusandae reprehenderit praesentium sit.", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 13, 3, 28, 30, 271, DateTimeKind.Local), "Omnis libero voluptas perferendis exercitationem eum dolorum consequatur sed error.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 23, 59, 21, 726, DateTimeKind.Local), "Ducimus rerum consequatur fugiat quis non fugit a ipsum perferendis.", "43c24b44-2dab-478d-b5e5-72e951c390ab", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 12, 13, 6, 29, 485, DateTimeKind.Local), "Voluptas consequatur itaque voluptas quaerat.", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 12, 15, 20, 20, 128, DateTimeKind.Local), "Est nobis voluptas ducimus libero eligendi non magnam.", "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 9, 13, 5, 13, 20, 76, DateTimeKind.Local), "Non et iusto.", "1e4e1d3e-8076-43bd-bd3c-5987739a71dc" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 12, 16, 54, 51, 704, DateTimeKind.Local), "Dolores sed molestiae.", "1e4e1d3e-8076-43bd-bd3c-5987739a71dc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 0, "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 1, "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "8054cd22-9b52-4575-a04c-ae76707de796" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, true, "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 0, "32d7cde9-73c3-405a-ba2f-fbdda364d9dd" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 0, "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "9939ac91-9e2a-4381-bddb-147506b6b5d3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 5, 51, 14, 568, DateTimeKind.Local), 14, "Necessitatibus ex et consequuntur quisquam modi magni blanditiis unde.", "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 36, 11, 724, DateTimeKind.Local), 16, "Nemo quia pariatur corporis minus explicabo id quis.", "1e4e1d3e-8076-43bd-bd3c-5987739a71dc" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 23, 53, 14, 78, DateTimeKind.Local), 14, "Non ipsa debitis fugiat.", "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 53, 28, 313, DateTimeKind.Local), 19, "Odit est totam velit eius est odit est est.", "8054cd22-9b52-4575-a04c-ae76707de796" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 5, 2, 43, 946, DateTimeKind.Local), 13, "Quia porro dolorem alias suscipit ab minima ad corrupti.", "9939ac91-9e2a-4381-bddb-147506b6b5d3" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 17, 18, 44, 252, DateTimeKind.Local), 11, "Consectetur sit magnam fuga dolorem suscipit et iste similique cumque.", "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 6, 43, 50, 500, DateTimeKind.Local), "Maiores dicta est.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 5, 33, 269, DateTimeKind.Local), 15, "Sed quia illo fugiat quae.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 8, 29, 8, 260, DateTimeKind.Local), 17, "Dignissimos eum magni quaerat esse molestiae in.", "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 2, 0, 56, 544, DateTimeKind.Local), 18, "Quaerat facere sit ipsum error magnam molestiae.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-502-709-6765 x0831", "7db6b06e-1b5a-4cad-836c-1467243ef929", "Molestias quibusdam voluptatem itaque eveniet et architecto. Quis ut architecto similique ut.", "Violet.Kihn@yahoo.com", "Company964", "https://reggie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "989-307-9969", "7db6b06e-1b5a-4cad-836c-1467243ef929", "Aut voluptas facilis est non aut voluptas odit repellendus cupiditate. Nostrum est eos aut eum exercitationem. Doloribus aut dolorum soluta.", "Armani34@yahoo.com", "Company790", "https://alysson.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-854-262-2437 x5216", "43c24b44-2dab-478d-b5e5-72e951c390ab", "", "Eleanore47@hotmail.com", "Company459", "http://bobbie.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-215-313-7772 x8428", "43c24b44-2dab-478d-b5e5-72e951c390ab", "Dicta nobis et mollitia voluptate ut ullam iste consequatur.", "Brady.Corwin58@yahoo.com", "Company920", "http://karlee.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "487-466-9834", "3c753ffd-420a-4b93-b091-01ac55aaeff3", "Error non voluptas laboriosam architecto necessitatibus et.", "Ivory_Ondricka32@hotmail.com", "Company370", 2, "https://hayley.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(422) 752-6887 x288", "fc1af5c2-5260-4979-a30d-6c49759955ba", "Id non ut dolore rerum et aperiam excepturi qui molestiae.", "Tod64@yahoo.com", "Company745", 2, "https://jayce.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "878-384-4669 x47220", "3c753ffd-420a-4b93-b091-01ac55aaeff3", "Magni nihil ex dolores reprehenderit. Dignissimos perspiciatis nihil iure quia recusandae dolorem delectus explicabo quis. Iure nihil quasi sit nihil explicabo odio.", "Elnora_Streich15@gmail.com", "Company791", "https://lucienne.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(523) 431-3649 x3368", "3c753ffd-420a-4b93-b091-01ac55aaeff3", "Consequuntur nihil est sint nisi quia eaque. Hic suscipit facere ea facilis quia quia. Dolorem vero repudiandae dicta.", "Ashlee.Nicolas84@yahoo.com", "Company841", "https://tressa.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-732-432-2730 x3901", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a", "Quia dolorem non perspiciatis. Magnam aspernatur laborum nulla modi qui dolor tenetur optio. Sapiente voluptatem itaque est aut eum rerum occaecati et temporibus. Occaecati ad est fugit aspernatur expedita ab corporis architecto in.", "Bobbie_Ryan25@gmail.com", "Company324", "http://paula.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-505-704-2337", "43c24b44-2dab-478d-b5e5-72e951c390ab", "Qui sapiente minus quia id consequuntur et fuga. Aspernatur omnis accusantium ratione sed. Ducimus voluptate porro.", "Mike90@gmail.com", "Company910", "http://richard.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 9, 47, 30, DateTimeKind.Local), 41, "Ut laboriosam voluptatem omnis.", "7db6b06e-1b5a-4cad-836c-1467243ef929" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 42, 16, 818, DateTimeKind.Local), 41, "Ut labore et dignissimos neque rerum laborum.", "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 22, 28, 25, 657, DateTimeKind.Local), 46, "Inventore quia quibusdam delectus nulla voluptate nam.", "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 15, 59, 228, DateTimeKind.Local), 49, "Perspiciatis tenetur consequatur quas.", "3c753ffd-420a-4b93-b091-01ac55aaeff3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 7, 50, 37, 355, DateTimeKind.Local), 48, "Sint nobis consectetur sunt.", "43c24b44-2dab-478d-b5e5-72e951c390ab" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 3, 8, 1, 995, DateTimeKind.Local), 50, "Fuga nihil qui.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 13, 8, 54, 39, 893, DateTimeKind.Local), 47, "Sunt doloremque totam autem nemo aliquid tenetur eligendi modi.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 4, 58, 691, DateTimeKind.Local), 41, "Harum distinctio voluptatibus ut et et fugit non accusamus quidem.", "fc1af5c2-5260-4979-a30d-6c49759955ba" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 22, 0, 822, DateTimeKind.Local), 43, "Eaque perferendis totam sit quo.", "9939ac91-9e2a-4381-bddb-147506b6b5d3" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 43, 45, 606, DateTimeKind.Local), 47, "Iusto suscipit natus qui sapiente asperiores.", "32d7cde9-73c3-405a-ba2f-fbdda364d9dd" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "7db6b06e-1b5a-4cad-836c-1467243ef929", 67, 1 },
                    { "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a", 62, 1 },
                    { "3c753ffd-420a-4b93-b091-01ac55aaeff3", 68, 1 },
                    { "fc1af5c2-5260-4979-a30d-6c49759955ba", 66, 1 },
                    { "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31", 69, 1 },
                    { "32d7cde9-73c3-405a-ba2f-fbdda364d9dd", 68, 1 },
                    { "9939ac91-9e2a-4381-bddb-147506b6b5d3", 61, 1 },
                    { "43c24b44-2dab-478d-b5e5-72e951c390ab", 62, 1 },
                    { "1e4e1d3e-8076-43bd-bd3c-5987739a71dc", 66, 1 },
                    { "8054cd22-9b52-4575-a04c-ae76707de796", 66, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectorAppVersions");

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1e4e1d3e-8076-43bd-bd3c-5987739a71dc", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "32d7cde9-73c3-405a-ba2f-fbdda364d9dd", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3c753ffd-420a-4b93-b091-01ac55aaeff3", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "43c24b44-2dab-478d-b5e5-72e951c390ab", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7db6b06e-1b5a-4cad-836c-1467243ef929", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8054cd22-9b52-4575-a04c-ae76707de796", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9939ac91-9e2a-4381-bddb-147506b6b5d3", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a", 62 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "fc1af5c2-5260-4979-a30d-6c49759955ba", 66 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1e4e1d3e-8076-43bd-bd3c-5987739a71dc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32d7cde9-73c3-405a-ba2f-fbdda364d9dd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3c753ffd-420a-4b93-b091-01ac55aaeff3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43c24b44-2dab-478d-b5e5-72e951c390ab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7ce0aded-8003-4d6b-b4b9-9b2ed32beb31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7db6b06e-1b5a-4cad-836c-1467243ef929");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8054cd22-9b52-4575-a04c-ae76707de796");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9939ac91-9e2a-4381-bddb-147506b6b5d3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bb34cad5-9e7c-48af-a5ee-6e0fd7f5019a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fc1af5c2-5260-4979-a30d-6c49759955ba");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 88, 16 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DashboardId", "Threshold" },
                values: new object[] { 89, 36 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 42, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 90, 55, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 88, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DashboardId", "Type" },
                values: new object[] { 90, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97,
                column: "Threshold",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 84, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Threshold", "Type" },
                values: new object[] { 52, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DashboardId", "Threshold", "Type" },
                values: new object[] { 81, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 34, 2, 582, DateTimeKind.Local), 79, "Title12" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 8, 15, 837, DateTimeKind.Local), 75, "Title152" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 10, 51, 655, DateTimeKind.Local), 77, "Title228" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 19, 24, 710, DateTimeKind.Local), "Title530" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 22, 7, 15, 746, DateTimeKind.Local), 78, "Title932" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 41, 14, 50, DateTimeKind.Local), 72, "Title391" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 6, 51, 911, DateTimeKind.Local), 76, "Title634" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 1, 43, 921, DateTimeKind.Local), 77, "Title541" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 48, 40, 992, DateTimeKind.Local), 76, "Title657" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 12, 22, 29, 43, 414, DateTimeKind.Local), 71, "Title52" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "28:af:d8:73:a1:8d", 66, "Windows", "Instance528" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d9:8d:eb:c0:1c:e2", 67, "Windows", "Instance487" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "8a:5a:d4:d0:c1:ef", 65, "Instance891" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "d2:6f:73:4c:7e:36", 62, "Windows", "Instance408" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "29:c8:77:e7:96:fd", 68, "Linux", "Instance493" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "43:b6:21:fc:4a:ce", 69, "Windows", "Instance425" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "20:70:9e:74:92:69", 62, "Windows", "Instance695" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "b2:08:ff:30:61:c2", "Linux", "Instance256" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "2a:19:b1:39:c5:1b", 64, "Linux", "Instance227" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5a:27:e9:cc:93:b8", 62, "Instance11" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", null, new DateTime(2018, 9, 12, 9, 19, 0, 813, DateTimeKind.Local), "Tessie", "Malinda_Grady@gmail.com", null, "Phoebe", true, false, "O'Connell", null, "https://s3.amazonaws.com/uifaces/faces/twitter/terryxlife/128.jpg", 2 },
                    { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", null, new DateTime(2018, 9, 12, 18, 18, 8, 358, DateTimeKind.Local), "Adolphus", "Arden_Cormier37@hotmail.com", null, "Doris", true, false, "Will", null, "https://s3.amazonaws.com/uifaces/faces/twitter/terpimost/128.jpg", 1 },
                    { "cfdc2394-bcac-467f-9bd1-b099c449549a", null, new DateTime(2018, 9, 12, 6, 44, 34, 502, DateTimeKind.Local), "Federico", "Garrett_Franecki@hotmail.com", null, "Gerhard", true, false, "Keebler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/picard102/128.jpg", 2 },
                    { "6eaef575-0500-4c20-b59b-03f452842bdf", null, new DateTime(2018, 9, 12, 5, 47, 33, 413, DateTimeKind.Local), "Jensen", "Vida_Skiles@hotmail.com", null, "Lamar", true, false, "Hilpert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/elisabethkjaer/128.jpg", 2 },
                    { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", null, new DateTime(2018, 9, 12, 8, 25, 32, 805, DateTimeKind.Local), "Merritt", "Colleen86@hotmail.com", null, "Madonna", true, false, "Ortiz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/polarity/128.jpg", 2 },
                    { "cca3fb1b-6b17-4629-bb52-b06163ed3252", null, new DateTime(2018, 9, 12, 8, 13, 10, 827, DateTimeKind.Local), "Raleigh", "Joanne_Becker78@gmail.com", null, "Estrella", true, false, "Lesch", null, "https://s3.amazonaws.com/uifaces/faces/twitter/8d3k/128.jpg", 1 },
                    { "c7cb6c73-9895-498f-a06b-33597f76d4c5", null, new DateTime(2018, 9, 12, 3, 54, 14, 502, DateTimeKind.Local), "Krystina", "Rosalinda_Schaefer38@gmail.com", null, "Heloise", true, false, "Larkin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/themrdave/128.jpg", 2 },
                    { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", null, new DateTime(2018, 9, 11, 23, 16, 59, 455, DateTimeKind.Local), "Jed", "Merl29@gmail.com", null, "Marina", true, false, "Bergstrom", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BillSKenney/128.jpg", 1 },
                    { "64f2bf53-0184-44f6-b778-c46ebd040968", null, new DateTime(2018, 9, 12, 21, 32, 35, 621, DateTimeKind.Local), "Lurline", "Kathryne92@gmail.com", null, "Vernice", true, false, "Bahringer", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_williamguerra/128.jpg", 1 },
                    { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", null, new DateTime(2018, 9, 12, 5, 16, 17, 701, DateTimeKind.Local), "Lexie", "Jadon_Block@yahoo.com", null, "Edythe", true, false, "Hilpert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/buzzusborne/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "ipsa" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedById",
                value: "f8a2257c-6f5b-420f-b475-716fa7dccd4a");

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6eaef575-0500-4c20-b59b-03f452842bdf", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c7cb6c73-9895-498f-a06b-33597f76d4c5", "maiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", "ipsum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 10, 11, 930, DateTimeKind.Local), "Ea deleniti sunt ab sequi dicta omnis animi libero.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 27, 54, 149, DateTimeKind.Local), "Autem impedit unde.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 20, 47, 457, DateTimeKind.Local), "Accusamus culpa natus.", "c7cb6c73-9895-498f-a06b-33597f76d4c5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 6, 1, 41, 243, DateTimeKind.Local), "At optio et et id modi beatae saepe.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 10, 23, 15, 754, DateTimeKind.Local), "Aliquid saepe quia.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 15, 57, 39, 171, DateTimeKind.Local), "Ut quasi quos commodi aut.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 2, 4, 113, DateTimeKind.Local), "Rerum laudantium nisi dignissimos enim voluptatem nulla accusamus ex.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 26, 43, 287, DateTimeKind.Local), "Quo et dignissimos quia aut eum.", "c7cb6c73-9895-498f-a06b-33597f76d4c5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 54, 21, 959, DateTimeKind.Local), "Distinctio aut non dolores.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 19, 29, 359, DateTimeKind.Local), "Sed quis quae velit sequi veritatis.", "50593a1b-bc00-4fae-8ad9-7077d3fe19ee" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 12, 17, 30, 43, 314, DateTimeKind.Local), "Ut magnam et vitae ullam voluptatibus non.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 12, 9, 59, 0, 410, DateTimeKind.Local), "Culpa corporis velit quo ut enim nam optio.", "c7cb6c73-9895-498f-a06b-33597f76d4c5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 12, 2, 9, 18, 727, DateTimeKind.Local), "Quis aut sed sequi est.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 20, 15, 50, 881, DateTimeKind.Local), "Illum quia sapiente mollitia.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 12, 14, 50, 30, 385, DateTimeKind.Local), "Sunt iste animi quia temporibus reiciendis ut odit est.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 10, 56, 42, 72, DateTimeKind.Local), "Temporibus molestiae officiis sunt.", "cfdc2394-bcac-467f-9bd1-b099c449549a", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 12, 15, 34, 37, 300, DateTimeKind.Local), "Occaecati sequi vel sed nemo porro sit deserunt.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 12, 12, 3, 4, 782, DateTimeKind.Local), "Est repellendus sit dolor qui totam non deserunt.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 1, 19, 21, 784, DateTimeKind.Local), "Libero praesentium perferendis hic.", "64f2bf53-0184-44f6-b778-c46ebd040968" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 12, 13, 25, 50, 989, DateTimeKind.Local), "Ipsum voluptate odio.", "64f2bf53-0184-44f6-b778-c46ebd040968" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 3, "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, false, "50593a1b-bc00-4fae-8ad9-7077d3fe19ee" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 3, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 4, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 4, "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 3, "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 31, 10, 134, DateTimeKind.Local), 17, "Aut consequuntur amet qui.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 45, 18, 155, DateTimeKind.Local), 20, "Ut porro maiores et totam cupiditate amet quibusdam iusto.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 45, 44, 290, DateTimeKind.Local), 19, "Porro architecto id et facere unde reprehenderit.", "f8a2257c-6f5b-420f-b475-716fa7dccd4a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 41, 52, 544, DateTimeKind.Local), 13, "Atque esse cumque at facere.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 21, 32, 53, 964, DateTimeKind.Local), 14, "Quia molestias et voluptas odio.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 18, 34, 30, 371, DateTimeKind.Local), 13, "Cumque consectetur nihil eos qui dicta illo qui modi.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 20, 7, 143, DateTimeKind.Local), "Ut repudiandae distinctio dolores ab dolorem sit ipsa.", "cfdc2394-bcac-467f-9bd1-b099c449549a" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 16, 11, 40, 211, DateTimeKind.Local), 17, "Quam non dignissimos quo deleniti cumque quasi repellat.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 5, 0, 16, 63, DateTimeKind.Local), 15, "Dolorum eum laborum quibusdam ipsum id esse.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 7, 6, 17, 978, DateTimeKind.Local), 19, "Porro odit nemo repellat.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-796-420-5948 x57950", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", "Quibusdam veritatis similique odio commodi. Dolorem recusandae molestiae at blanditiis. Consequatur enim autem. Ipsa rerum illo atque consequatur.", "Juston.Ward@yahoo.com", "Company865", "http://dorthy.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "674.339.8732 x1845", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", "", "Georgiana47@gmail.com", "Company365", "http://sabina.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "553-827-1455 x1666", "64f2bf53-0184-44f6-b778-c46ebd040968", "Est est eum labore vero. Commodi nulla ipsam et maxime quia culpa. Aut asperiores perferendis beatae necessitatibus iure. Praesentium incidunt consequatur delectus ut vel beatae.", "Yasmeen.Schaden99@yahoo.com", "Company641", "http://tressa.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-298-580-5165 x7571", "cfdc2394-bcac-467f-9bd1-b099c449549a", "Ad necessitatibus dolorem.", "Trey.Hudson55@hotmail.com", "Company325", "https://summer.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "938.881.0357 x07341", "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", "Dicta quis debitis id velit.", "Frances30@yahoo.com", "Company593", 1, "https://jacinto.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "952-818-8715 x7294", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", "Aut ipsum et dolore nihil sapiente molestiae aut ducimus est. Consequatur veniam sed vero rem sed dolor amet corrupti. Debitis eos veritatis saepe iusto et itaque velit et. Et explicabo quaerat molestiae aperiam quo unde.", "Destany23@yahoo.com", "Company935", 1, "http://donato.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "332.490.3323 x9631", "cfdc2394-bcac-467f-9bd1-b099c449549a", "", "Jerrell.Abshire@hotmail.com", "Company830", "https://margarete.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(592) 993-3570", "64f2bf53-0184-44f6-b778-c46ebd040968", "Laudantium adipisci nam. Nulla asperiores autem vel asperiores sed blanditiis ut.", "Yadira65@yahoo.com", "Company105", "http://bobby.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-774-259-6817 x1480", "c7cb6c73-9895-498f-a06b-33597f76d4c5", "Veritatis numquam et molestiae quam. Provident illo voluptate aut repudiandae. Et ratione voluptatem aliquid nemo consequuntur magnam ullam.", "Mertie.Cassin31@gmail.com", "Company772", "https://elvera.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-489-724-5605", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", "", "Aleen.Koch65@hotmail.com", "Company655", "https://alexandre.com" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 1, 3, 30, 652, DateTimeKind.Local), 45, "Qui eum facilis velit atque sed molestiae inventore.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 3, 15, 24, 889, DateTimeKind.Local), 50, "Ipsum quaerat quam qui quibusdam distinctio modi blanditiis.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 19, 10, 6, 401, DateTimeKind.Local), 44, "Ex placeat voluptatibus.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 20, 47, 19, 554, DateTimeKind.Local), 46, "Aut nobis officia et repellat et laudantium quo consequuntur.", "26de10ee-aa98-4b31-b719-b1bb4fb57d8d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 38, 39, 152, DateTimeKind.Local), 44, "Qui eos rerum aut fuga sit ea in et corporis.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 11, 26, 46, 596, DateTimeKind.Local), 46, "Nulla id iste omnis aut deserunt rerum.", "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 13, 39, 574, DateTimeKind.Local), 44, "Nihil voluptatem suscipit hic aspernatur autem laboriosam.", "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 13, 34, 44, 680, DateTimeKind.Local), 47, "Et accusamus cupiditate doloremque tenetur autem.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 9, 4, 24, 54, DateTimeKind.Local), 45, "Animi est et reiciendis.", "6eaef575-0500-4c20-b59b-03f452842bdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 14, 4, 46, 919, DateTimeKind.Local), 43, "Ad quaerat et.", "cca3fb1b-6b17-4629-bb52-b06163ed3252" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "f8a2257c-6f5b-420f-b475-716fa7dccd4a", 69, 1 },
                    { "26de10ee-aa98-4b31-b719-b1bb4fb57d8d", 62, 1 },
                    { "cfdc2394-bcac-467f-9bd1-b099c449549a", 69, 1 },
                    { "06b58a0c-8fd7-4176-a2c7-b6cfd371c19c", 63, 1 },
                    { "50593a1b-bc00-4fae-8ad9-7077d3fe19ee", 67, 1 },
                    { "c7cb6c73-9895-498f-a06b-33597f76d4c5", 66, 1 },
                    { "6eaef575-0500-4c20-b59b-03f452842bdf", 62, 1 },
                    { "cca3fb1b-6b17-4629-bb52-b06163ed3252", 68, 1 },
                    { "64f2bf53-0184-44f6-b778-c46ebd040968", 67, 1 },
                    { "6b0096c5-69ef-4d81-93a2-7dbe4abbdf07", 65, 1 }
                });
        }
    }
}
