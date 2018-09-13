using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ImprovedThemeEntity : Migration
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
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

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
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "024f3656-21af-43b6-a989-218f35300913", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0f31f24b-d6b2-454a-9914-581c5fd42469", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "24da036f-3088-4cb6-9e7d-07beb16991c1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a39dd024-76e2-4401-89cf-2e74899e2448", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a7c1dd4b-ca32-4977-aeb8-133be150c795", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f8496351-6630-4b31-8f73-15324b1e9866", 72 });

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
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

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
                keyValue: 76);

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
                keyValue: "24da036f-3088-4cb6-9e7d-07beb16991c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "841fb6c1-cd08-491c-b1e8-72cd41e43ff6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9c91f9de-85da-4ea4-8c5b-181976d6362c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a39dd024-76e2-4401-89cf-2e74899e2448");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a7c1dd4b-ca32-4977-aeb8-133be150c795");

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84);

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
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "024f3656-21af-43b6-a989-218f35300913");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0f31f24b-d6b2-454a-9914-581c5fd42469");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d8693e92-5cf4-4cd9-9eba-db70b2eb013c");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f8496351-6630-4b31-8f73-15324b1e9866");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "FontFamily",
                table: "Themes");

            migrationBuilder.AddColumn<string>(
                name: "BodyColor",
                table: "Themes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ButtonFontSize",
                table: "Themes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ControlsHeight",
                table: "Themes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThemePrimaryColor",
                table: "Themes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThemeSecondaryColor",
                table: "Themes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BodyColor", "ButtonFontSize", "ControlsHeight", "IsDeleted", "Name", "ThemePrimaryColor", "ThemeSecondaryColor" },
                values: new object[,]
                {
                    { 1, "#F8FAFC", "14px !global", "33px", false, "Default", "#007ad9", "#ffffff" },
                    { 2, "#F8FAFC", "14px", "33px", false, "Darkness", "#f58400", "#ffffff" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", null, new DateTime(2018, 9, 11, 4, 3, 30, 315, DateTimeKind.Local), "Art", "Watson.Legros@yahoo.com", null, "Estefania", true, false, "Senger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidbaldie/128.jpg", 1 },
                    { "2819394b-d044-4be1-960d-a60e12a21f7a", null, new DateTime(2018, 9, 11, 14, 41, 27, 196, DateTimeKind.Local), "Rahul", "Garnett_Haag@gmail.com", null, "Zander", true, false, "Swift", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sethlouey/128.jpg", 2 },
                    { "1a663fb2-1a63-4070-a001-ed559a8c4160", null, new DateTime(2018, 9, 11, 12, 19, 32, 5, DateTimeKind.Local), "Dustin", "Rosa.Stokes@gmail.com", null, "Jasper", true, false, "Hudson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/malykhinv/128.jpg", 1 },
                    { "9d3f18be-2903-40c5-954d-1b3718154f55", null, new DateTime(2018, 9, 11, 3, 41, 3, 985, DateTimeKind.Local), "Korbin", "Shaina44@hotmail.com", null, "Joanie", true, false, "Wuckert", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dotgridline/128.jpg", 1 },
                    { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", null, new DateTime(2018, 9, 11, 6, 59, 56, 157, DateTimeKind.Local), "Omer", "Randall_Ondricka@yahoo.com", null, "Delfina", true, false, "Padberg", null, "https://s3.amazonaws.com/uifaces/faces/twitter/overra/128.jpg", 1 },
                    { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", null, new DateTime(2018, 9, 11, 4, 15, 45, 437, DateTimeKind.Local), "Matilde", "Meagan_Paucek@gmail.com", null, "Lionel", true, false, "Hegmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/increase/128.jpg", 1 },
                    { "94719eb2-7b6a-4420-8a6f-264380d3263f", null, new DateTime(2018, 9, 12, 2, 0, 30, 662, DateTimeKind.Local), "Richard", "Kelly.Keebler@yahoo.com", null, "Marietta", true, false, "Hills", null, "https://s3.amazonaws.com/uifaces/faces/twitter/weavermedia/128.jpg", 2 },
                    { "9603312a-f694-4178-9405-0edf297ba8b3", null, new DateTime(2018, 9, 11, 14, 11, 14, 606, DateTimeKind.Local), "Lee", "Daphnee_Beatty43@yahoo.com", null, "Billy", true, false, "Considine", null, "https://s3.amazonaws.com/uifaces/faces/twitter/nepdud/128.jpg", 1 },
                    { "76acb978-b2aa-4340-84d0-02494e5175e4", null, new DateTime(2018, 9, 11, 6, 54, 37, 994, DateTimeKind.Local), "Blaise", "Bruce_Kozey73@yahoo.com", null, "Fernando", true, false, "Feeney", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mtolokonnikov/128.jpg", 2 },
                    { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", null, new DateTime(2018, 9, 11, 5, 37, 49, 807, DateTimeKind.Local), "Davonte", "Clint_Adams@gmail.com", null, "Guiseppe", true, false, "Sawayn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/soffes/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9603312a-f694-4178-9405-0edf297ba8b3", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "76acb978-b2aa-4340-84d0-02494e5175e4", "nam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", "unde" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2819394b-d044-4be1-960d-a60e12a21f7a", "quasi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "94719eb2-7b6a-4420-8a6f-264380d3263f", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", "ut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "ab" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "sint" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9d3f18be-2903-40c5-954d-1b3718154f55", "maiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "officiis" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 50, 7, 285, DateTimeKind.Local), "Dolorem itaque dolorum quis facere occaecati architecto.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 20, 51, 43, 295, DateTimeKind.Local), "Labore veniam minus dolor voluptate iusto consectetur eveniet ab culpa.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 1, 33, 971, DateTimeKind.Local), "Saepe et repellat ratione incidunt.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 29, 12, 877, DateTimeKind.Local), "Eos deleniti velit quisquam facilis et nihil.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 30, 9, 759, DateTimeKind.Local), "Praesentium eligendi officia debitis accusamus vitae laudantium quam tempora.", "1a663fb2-1a63-4070-a001-ed559a8c4160" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 38, 36, 837, DateTimeKind.Local), "Ut veniam maiores dolorum qui.", "9603312a-f694-4178-9405-0edf297ba8b3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 8, 29, 507, DateTimeKind.Local), "Nulla possimus eum iure aspernatur.", "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 7, 53, 12, 348, DateTimeKind.Local), "Omnis consequatur corrupti sequi adipisci quibusdam.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 41, 19, 290, DateTimeKind.Local), "Perferendis illo sint soluta consequatur sed fugiat aliquam.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 34, 13, 425, DateTimeKind.Local), "Id accusantium ut quaerat.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 11, 27, 31, 574, DateTimeKind.Local), "Repellat et voluptates non quisquam corporis.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 2, 32, 326, DateTimeKind.Local), "Perferendis voluptas autem et quo et blanditiis ex pariatur consequatur.", "76acb978-b2aa-4340-84d0-02494e5175e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 11, 4, 40, 4, 955, DateTimeKind.Local), "Laudantium nemo voluptates voluptatem error repellendus blanditiis aspernatur molestiae qui.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 7, 47, 23, 71, DateTimeKind.Local), "Et officiis est deserunt et.", "76acb978-b2aa-4340-84d0-02494e5175e4", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 12, 30, 743, DateTimeKind.Local), "Debitis sint veritatis soluta doloribus.", "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 9, 11, 8, 21, 53, 116, DateTimeKind.Local), "Voluptatum impedit illum ut neque natus maxime commodi est.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 12, 0, 45, 48, 533, DateTimeKind.Local), "Nemo dolores hic aliquid mollitia cumque est.", "94719eb2-7b6a-4420-8a6f-264380d3263f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 2, 7, 58, 12, DateTimeKind.Local), "Qui quam iusto non autem.", "76acb978-b2aa-4340-84d0-02494e5175e4", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 33, 22, 707, DateTimeKind.Local), "Inventore molestiae et nobis laudantium voluptate molestiae rerum qui.", "9d3f18be-2903-40c5-954d-1b3718154f55", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 11, 22, 25, 11, 917, DateTimeKind.Local), "Voluptatibus laborum dolores fugit voluptatem vel facilis eum distinctio.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 2, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "9603312a-f694-4178-9405-0edf297ba8b3" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, true, 4, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 1, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, true, 2, "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, true, "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 2, "76acb978-b2aa-4340-84d0-02494e5175e4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 104, new DateTime(2018, 9, 12, 0, 18, 52, 522, DateTimeKind.Local), false, 15, "Eveniet laudantium et cupiditate.", "76acb978-b2aa-4340-84d0-02494e5175e4", false },
                    { 110, new DateTime(2018, 9, 11, 6, 37, 37, 590, DateTimeKind.Local), false, 20, "Enim necessitatibus porro quisquam nobis velit dolor aliquam vel at.", "76acb978-b2aa-4340-84d0-02494e5175e4", false },
                    { 102, new DateTime(2018, 9, 11, 9, 20, 11, 539, DateTimeKind.Local), false, 13, "Assumenda voluptatem dolore eligendi.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false },
                    { 105, new DateTime(2018, 9, 11, 16, 39, 26, 183, DateTimeKind.Local), false, 17, "Quod voluptates sed voluptate unde sunt error esse.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false },
                    { 108, new DateTime(2018, 9, 11, 12, 4, 58, 400, DateTimeKind.Local), false, 18, "Autem debitis animi fugiat explicabo voluptatem aperiam perferendis consequatur.", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", false },
                    { 109, new DateTime(2018, 9, 12, 1, 16, 10, 800, DateTimeKind.Local), false, 16, "Vero enim harum dolorem dolores iste beatae odit sit ea.", "76acb978-b2aa-4340-84d0-02494e5175e4", false },
                    { 103, new DateTime(2018, 9, 12, 2, 6, 37, 410, DateTimeKind.Local), false, 12, "Et expedita similique iusto.", "c9d3c359-9b33-48fd-95d0-502911a4d3bc", false },
                    { 107, new DateTime(2018, 9, 11, 6, 22, 45, 749, DateTimeKind.Local), false, 20, "Temporibus ab quas enim doloribus praesentium explicabo aut hic.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", false },
                    { 106, new DateTime(2018, 9, 11, 3, 58, 46, 320, DateTimeKind.Local), false, 17, "Voluptatem voluptatem culpa quae aliquam blanditiis et.", "2819394b-d044-4be1-960d-a60e12a21f7a", false },
                    { 101, new DateTime(2018, 9, 11, 15, 29, 11, 981, DateTimeKind.Local), false, 17, "Cum aut illum illum adipisci tempore dolorem.", "9d3f18be-2903-40c5-954d-1b3718154f55", false }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 65, "984.564.9740", "76acb978-b2aa-4340-84d0-02494e5175e4", "Velit animi aperiam. Illo tenetur voluptatem ab occaecati odio ut libero nisi earum. Eligendi necessitatibus repudiandae sequi iusto aut sit explicabo earum. Repellendus autem unde magni ut totam.", "Candelario.Wehner@gmail.com", null, true, false, "Company538", 2, "https://kendall.biz" },
                    { 62, "674-827-6351", "c9d3c359-9b33-48fd-95d0-502911a4d3bc", "Aperiam assumenda nam corporis natus inventore. Aspernatur deserunt earum.", "Felicia.Trantow@gmail.com", null, true, false, "Company652", 1, "http://berneice.name" },
                    { 67, "889.616.0260", "c9d3c359-9b33-48fd-95d0-502911a4d3bc", "Porro saepe a ullam suscipit odio ab vel et consequatur. Et voluptatem at rem modi dolorem. Mollitia quia ducimus. Id sit molestias asperiores numquam at.", "Wilfrid_Wiza9@hotmail.com", null, true, false, "Company158", 1, "http://dorris.net" },
                    { 70, "743-668-4021 x8439", "76acb978-b2aa-4340-84d0-02494e5175e4", "", "Abdiel_Hayes@gmail.com", null, true, false, "Company444", 2, "http://cloyd.net" },
                    { 63, "286.436.6371", "9603312a-f694-4178-9405-0edf297ba8b3", "Culpa tempora modi. Doloribus et atque fuga natus est corrupti aliquam. Velit nisi enim eum fuga. Atque distinctio autem dolorum doloremque.", "Elton55@yahoo.com", null, true, false, "Company156", 1, "http://adrian.info" },
                    { 61, "1-937-869-4789", "76acb978-b2aa-4340-84d0-02494e5175e4", "Vel explicabo fuga nam corrupti corporis aut eaque velit. Qui dolorem aut eveniet sed sequi. Sed qui reprehenderit id veniam mollitia deserunt eveniet qui alias. Voluptatibus nesciunt enim doloribus.", "Jaquan38@yahoo.com", null, true, false, "Company776", 2, "https://araceli.com" },
                    { 69, "459-959-9184", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "Eius accusamus eum. Quis nihil id temporibus quia officia suscipit similique non.", "Ada68@yahoo.com", null, true, false, "Company930", 1, "http://shayne.net" },
                    { 68, "901-586-3180", "2a6ff317-062f-4fa9-982a-b5e85d35db4f", "Fuga dignissimos ut sequi fuga temporibus laboriosam. Adipisci omnis in velit. Ut ut deserunt reprehenderit dolores.", "Aletha72@yahoo.com", null, true, false, "Company612", 1, "https://nina.name" },
                    { 64, "515-678-3754 x13391", "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", "Qui quia est consectetur voluptatibus harum. Ipsa eligendi repellat laboriosam consequatur reiciendis. Amet quaerat iusto aut veritatis magnam.", "Kelley27@hotmail.com", null, true, false, "Company673", 2, "https://adella.com" },
                    { 66, "916-352-8594 x935", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", "", "Stewart58@yahoo.com", null, true, false, "Company248", 1, "https://christina.net" }
                });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 37, 52, 782, DateTimeKind.Local), 46, "Cumque enim velit dolor et omnis consequatur distinctio esse numquam.", "c9d3c359-9b33-48fd-95d0-502911a4d3bc" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 5, 20, 272, DateTimeKind.Local), 42, "Quas necessitatibus quo reprehenderit quo est aperiam.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 34, 11, 789, DateTimeKind.Local), 42, "Libero consectetur quisquam id.", "1a663fb2-1a63-4070-a001-ed559a8c4160" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 49, 2, 933, DateTimeKind.Local), 47, "Eos quasi quia provident ut doloribus sequi cum.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 23, 7, 44, 730, DateTimeKind.Local), 49, "Dolor culpa et ut.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 12, 0, 46, 39, 186, DateTimeKind.Local), "Temporibus ut deleniti omnis.", "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 40, 23, 316, DateTimeKind.Local), 44, "Quis molestiae molestias doloribus tenetur commodi est.", "9d3f18be-2903-40c5-954d-1b3718154f55" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 2, 33, 58, 832, DateTimeKind.Local), 41, "Ea soluta perferendis rerum aspernatur recusandae.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 16, 40, 723, DateTimeKind.Local), 45, "Corrupti animi quisquam ea consequatur molestiae a.", "2a6ff317-062f-4fa9-982a-b5e85d35db4f" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 0, 5, 817, DateTimeKind.Local), 50, "Deserunt officia iure modi laborum et amet quam.", "2819394b-d044-4be1-960d-a60e12a21f7a" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "StatusCheckedAt", "Title" },
                values: new object[,]
                {
                    { 73, "14:75:ba:1f:90:03",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 68, "Linux",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance972" },
                    { 72, "8e:a1:f8:a5:c6:23",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 64, "Windows",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance511" },
                    { 79, "90:f5:f2:2d:11:a5",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance544" },
                    { 78, "45:58:36:21:06:b0",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 70, "Windows",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance379" },
                    { 80, "2a:42:10:0e:c7:1e",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Windows",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance897" },
                    { 74, "9e:a3:88:cf:44:0b",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 69, "Windows",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance191" },
                    { 71, "5f:9b:bb:7b:ac:c5",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Linux",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance663" },
                    { 75, "72:64:8e:8e:94:3f",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Linux",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance718" },
                    { 77, "10:53:e8:e1:11:ea",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Linux",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance917" },
                    { 76, "8f:f9:b3:30:e9:e9",  new Guid("00000000-0000-0000-0000-000000000000"), true, false, 69, "Linux",  new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance140" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "9603312a-f694-4178-9405-0edf297ba8b3", 66, 1 },
                    { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", 66, 1 },
                    { "9d3f18be-2903-40c5-954d-1b3718154f55", 65, 1 },
                    { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", 65, 1 },
                    { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", 65, 1 },
                    { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", 66, 1 },
                    { "76acb978-b2aa-4340-84d0-02494e5175e4", 68, 1 },
                    { "2819394b-d044-4be1-960d-a60e12a21f7a", 68, 1 },
                    { "1a663fb2-1a63-4070-a001-ed559a8c4160", 64, 1 },
                    { "94719eb2-7b6a-4420-8a6f-264380d3263f", 61, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 89, new DateTime(2018, 9, 11, 20, 52, 40, 119, DateTimeKind.Local), 77, false, "Title907" },
                    { 84, new DateTime(2018, 9, 11, 9, 25, 34, 351, DateTimeKind.Local), 71, false, "Title223" },
                    { 86, new DateTime(2018, 9, 11, 16, 10, 57, 224, DateTimeKind.Local), 80, false, "Title728" },
                    { 82, new DateTime(2018, 9, 11, 16, 32, 13, 297, DateTimeKind.Local), 78, false, "Title284" },
                    { 81, new DateTime(2018, 9, 11, 10, 24, 27, 830, DateTimeKind.Local), 72, false, "Title675" },
                    { 83, new DateTime(2018, 9, 11, 12, 40, 57, 508, DateTimeKind.Local), 72, false, "Title218" },
                    { 85, new DateTime(2018, 9, 11, 23, 55, 13, 614, DateTimeKind.Local), 74, false, "Title600" },
                    { 88, new DateTime(2018, 9, 11, 22, 35, 22, 129, DateTimeKind.Local), 74, false, "Title12" },
                    { 87, new DateTime(2018, 9, 12, 1, 45, 57, 536, DateTimeKind.Local), 76, false, "Title753" },
                    { 90, new DateTime(2018, 9, 11, 19, 36, 32, 506, DateTimeKind.Local), 76, false, "Title879" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "HistoryTime", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 96, true, 89, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 34, "", 2, "X Label", "Y Label" },
                    { 99, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 82, "", 3, "X Label", "Y Label" },
                    { 100, true, 86, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 96, "", 2, "X Label", "Y Label" },
                    { 92, true, 82, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 37, "", 2, "X Label", "Y Label" },
                    { 93, true, 82, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 46, "", 1, "X Label", "Y Label" },
                    { 98, true, 81, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 78, "", 0, "X Label", "Y Label" },
                    { 97, true, 83, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 60, "", 1, "X Label", "Y Label" },
                    { 91, true, 85, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 54, "", 3, "X Label", "Y Label" },
                    { 94, true, 88, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 68, "", 3, "X Label", "Y Label" },
                    { 95, true, 87, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 6, "", 1, "X Label", "Y Label" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "1a663fb2-1a63-4070-a001-ed559a8c4160", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2819394b-d044-4be1-960d-a60e12a21f7a", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2a6ff317-062f-4fa9-982a-b5e85d35db4f", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "76acb978-b2aa-4340-84d0-02494e5175e4", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "94719eb2-7b6a-4420-8a6f-264380d3263f", 61 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9603312a-f694-4178-9405-0edf297ba8b3", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9d3f18be-2903-40c5-954d-1b3718154f55", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c9d3c359-9b33-48fd-95d0-502911a4d3bc", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e338b266-bcb3-4a6b-b652-3f6aea7cc02f", 65 });

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1a663fb2-1a63-4070-a001-ed559a8c4160");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2819394b-d044-4be1-960d-a60e12a21f7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "94719eb2-7b6a-4420-8a6f-264380d3263f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9603312a-f694-4178-9405-0edf297ba8b3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9d3f18be-2903-40c5-954d-1b3718154f55");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9d3c359-9b33-48fd-95d0-502911a4d3bc");

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2a6ff317-062f-4fa9-982a-b5e85d35db4f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "844e83a9-5a4d-40c3-b7ce-a5e9a30ee905");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "76acb978-b2aa-4340-84d0-02494e5175e4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e338b266-bcb3-4a6b-b652-3f6aea7cc02f");

            migrationBuilder.DropColumn(
                name: "BodyColor",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "ButtonFontSize",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "ControlsHeight",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "ThemePrimaryColor",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "ThemeSecondaryColor",
                table: "Themes");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "Themes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FontFamily",
                table: "Themes",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 61, "Yellow", "Trade", false, "Theme841" },
                    { 69, "White", "Frutiger", false, "Theme70" },
                    { 68, "Gray", "Helvetica", false, "Theme924" },
                    { 67, "Yellow", "Univers", false, "Theme500" },
                    { 66, "Gray", "Helvetica", false, "Theme288" },
                    { 70, "Gray", "Trade", false, "Theme386" },
                    { 64, "Yellow", "Univers", false, "Theme34" },
                    { 63, "White", "Helvetica", false, "Theme481" },
                    { 62, "Yellow", "Helvetica", false, "Theme887" },
                    { 65, "Yellow", "Helvetica", false, "Theme174" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "24da036f-3088-4cb6-9e7d-07beb16991c1", null, new DateTime(2018, 9, 11, 18, 39, 5, 763, DateTimeKind.Local), "Retta", "Maudie.Brown@gmail.com", null, "Sabrina", true, false, "Rutherford", null, "https://s3.amazonaws.com/uifaces/faces/twitter/xadhix/128.jpg", 1 },
                    { "9c91f9de-85da-4ea4-8c5b-181976d6362c", null, new DateTime(2018, 9, 11, 18, 56, 5, 142, DateTimeKind.Local), "Sierra", "Autumn75@hotmail.com", null, "Alec", true, false, "Block", null, "https://s3.amazonaws.com/uifaces/faces/twitter/daniloc/128.jpg", 1 },
                    { "0f31f24b-d6b2-454a-9914-581c5fd42469", null, new DateTime(2018, 9, 11, 19, 3, 6, 935, DateTimeKind.Local), "Hipolito", "Ricardo71@hotmail.com", null, "Hattie", true, false, "Zemlak", null, "https://s3.amazonaws.com/uifaces/faces/twitter/alessandroribe/128.jpg", 2 },
                    { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", null, new DateTime(2018, 9, 11, 9, 9, 15, 541, DateTimeKind.Local), "Coy", "Kiera.Schmeler42@yahoo.com", null, "Freddie", true, false, "Gerlach", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mrjamesnoble/128.jpg", 2 },
                    { "a7c1dd4b-ca32-4977-aeb8-133be150c795", null, new DateTime(2018, 9, 11, 18, 32, 13, 66, DateTimeKind.Local), "Greyson", "Kendra_Rau@gmail.com", null, "Jane", true, false, "Marvin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ionuss/128.jpg", 1 },
                    { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", null, new DateTime(2018, 9, 11, 20, 27, 2, 500, DateTimeKind.Local), "Emiliano", "Stanford62@yahoo.com", null, "Dewitt", true, false, "Kuhic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/psaikali/128.jpg", 1 },
                    { "024f3656-21af-43b6-a989-218f35300913", null, new DateTime(2018, 9, 11, 2, 26, 44, 376, DateTimeKind.Local), "Jewell", "Akeem6@yahoo.com", null, "Michaela", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sur4dye/128.jpg", 2 },
                    { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", null, new DateTime(2018, 9, 11, 20, 10, 20, 608, DateTimeKind.Local), "Genesis", "Chadrick.Mosciski51@yahoo.com", null, "Aleen", true, false, "Willms", null, "https://s3.amazonaws.com/uifaces/faces/twitter/spedwig/128.jpg", 1 },
                    { "a39dd024-76e2-4401-89cf-2e74899e2448", null, new DateTime(2018, 9, 11, 3, 50, 36, 778, DateTimeKind.Local), "Deshawn", "Rebekah59@gmail.com", null, "Vada", true, false, "Buckridge", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adhiardana/128.jpg", 1 },
                    { "f8496351-6630-4b31-8f73-15324b1e9866", null, new DateTime(2018, 9, 11, 7, 15, 4, 473, DateTimeKind.Local), "Dayne", "Joel_OKon@yahoo.com", null, "Jailyn", true, false, "Hermann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/the_winslet/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "24da036f-3088-4cb6-9e7d-07beb16991c1", "quia" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "024f3656-21af-43b6-a989-218f35300913", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "024f3656-21af-43b6-a989-218f35300913", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a39dd024-76e2-4401-89cf-2e74899e2448", "illo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", "eos" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a7c1dd4b-ca32-4977-aeb8-133be150c795", "magni" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f8496351-6630-4b31-8f73-15324b1e9866", "non" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", "doloremque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c91f9de-85da-4ea4-8c5b-181976d6362c", "ut" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 22, 42, 43, 337, DateTimeKind.Local), "Eligendi commodi et consequatur qui est autem.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 15, 45, 1, 192, DateTimeKind.Local), "Nihil optio quaerat et ea quaerat enim earum et.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 48, 9, 855, DateTimeKind.Local), "In esse eum libero omnis architecto.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 17, 53, 1, 89, DateTimeKind.Local), "Tenetur quas occaecati voluptas eos laboriosam voluptas dolores.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 50, 59, 854, DateTimeKind.Local), "Animi officia aut et doloribus perferendis officiis rerum rem minus.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 16, 38, 52, 138, DateTimeKind.Local), "Corporis sapiente iure dolorum voluptatum eius quisquam.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 15, 59, 700, DateTimeKind.Local), "Totam adipisci quod.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 50, 0, 195, DateTimeKind.Local), "Rerum aut distinctio occaecati delectus temporibus vel provident possimus cum.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 59, 51, 483, DateTimeKind.Local), "Enim repellat qui.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 9, 59, 15, 286, DateTimeKind.Local), "Eveniet tenetur nihil distinctio accusantium explicabo et.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 11, 11, 0, 49, 422, DateTimeKind.Local), "Quis asperiores ducimus quia necessitatibus doloremque doloremque reprehenderit velit.", "a7c1dd4b-ca32-4977-aeb8-133be150c795", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 21, 21, 587, DateTimeKind.Local), "Adipisci laudantium architecto iusto autem eius sapiente quasi.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 2, 57, 48, 148, DateTimeKind.Local), "Sed ad tempore et rem vitae dolore.", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 0, 49, 34, 288, DateTimeKind.Local), "Atque accusantium suscipit nam quae laboriosam aut maxime nobis id.", "024f3656-21af-43b6-a989-218f35300913", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 33, 58, 18, DateTimeKind.Local), "Eveniet corporis nisi necessitatibus adipisci sed odio quos fugit.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 11, 16, 23, 4, 226, DateTimeKind.Local), "Eligendi voluptas ipsum est.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 11, 6, 27, 38, 873, DateTimeKind.Local), "Id eius et itaque voluptates et.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 11, 5, 19, 11, 18, DateTimeKind.Local), "Ut est occaecati ea.", "024f3656-21af-43b6-a989-218f35300913", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 10, 23, 55, 15, 92, DateTimeKind.Local), "Qui sit minima perferendis.", "a7c1dd4b-ca32-4977-aeb8-133be150c795", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 23, new DateTime(2018, 9, 11, 7, 36, 30, 890, DateTimeKind.Local), "Quia dolore libero ad ut.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 4, "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, false, 1, "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "d8693e92-5cf4-4cd9-9eba-db70b2eb013c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 4, "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, false, 1, "841fb6c1-cd08-491c-b1e8-72cd41e43ff6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, false, "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 1, "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 113, new DateTime(2018, 9, 11, 5, 5, 52, 816, DateTimeKind.Local), null, false, 18, "Eum sunt rem aut ut dolorem.", "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", false },
                    { 111, new DateTime(2018, 9, 11, 3, 1, 55, 854, DateTimeKind.Local), null, false, 13, "Non voluptatem et aut fuga ex quia magni.", "0f31f24b-d6b2-454a-9914-581c5fd42469", false },
                    { 119, new DateTime(2018, 9, 11, 1, 51, 57, 116, DateTimeKind.Local), null, false, 18, "Aut iusto et.", "0f31f24b-d6b2-454a-9914-581c5fd42469", false },
                    { 114, new DateTime(2018, 9, 10, 23, 46, 7, 707, DateTimeKind.Local), null, false, 15, "Non nesciunt omnis impedit atque occaecati tenetur aliquid.", "a39dd024-76e2-4401-89cf-2e74899e2448", false },
                    { 116, new DateTime(2018, 9, 11, 18, 25, 34, 916, DateTimeKind.Local), null, false, 12, "Quisquam magni ut harum expedita inventore.", "a7c1dd4b-ca32-4977-aeb8-133be150c795", false },
                    { 118, new DateTime(2018, 9, 11, 7, 31, 20, 779, DateTimeKind.Local), null, false, 20, "Libero repudiandae perspiciatis dignissimos.", "9c91f9de-85da-4ea4-8c5b-181976d6362c", false },
                    { 112, new DateTime(2018, 9, 11, 2, 16, 16, 834, DateTimeKind.Local), null, false, 14, "Consequatur soluta sint et libero quis optio et amet accusamus.", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", false },
                    { 117, new DateTime(2018, 9, 11, 11, 26, 8, 862, DateTimeKind.Local), null, false, 20, "Repudiandae vero ut.", "024f3656-21af-43b6-a989-218f35300913", false },
                    { 115, new DateTime(2018, 9, 11, 11, 26, 49, 957, DateTimeKind.Local), null, false, 15, "Non deserunt consequatur eaque repudiandae nam.", "9c91f9de-85da-4ea4-8c5b-181976d6362c", false },
                    { 120, new DateTime(2018, 9, 11, 20, 36, 23, 816, DateTimeKind.Local), null, false, 16, "Incidunt ab iusto facilis id at et saepe.", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", false }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 73, "(618) 857-0996", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Veda24@gmail.com", null, true, false, "Company318", 64, "https://wilma.biz" },
                    { 76, "(239) 855-1818 x4375", "024f3656-21af-43b6-a989-218f35300913", "Reiciendis repudiandae aliquid. Officia maxime qui labore sed provident sunt minus doloremque inventore. Est dolores temporibus.", "Kendall96@gmail.com", null, true, false, "Company286", 69, "https://ronaldo.com" },
                    { 74, "1-727-638-1843", "024f3656-21af-43b6-a989-218f35300913", "Ducimus ullam vero necessitatibus ex ipsum cum. Neque modi eveniet sapiente saepe labore enim ex.", "Watson_Lang@hotmail.com", null, true, false, "Company991", 65, "https://tyrel.biz" },
                    { 78, "1-942-757-3026 x670", "0f31f24b-d6b2-454a-9914-581c5fd42469", "", "Brisa_Schoen98@hotmail.com", null, true, false, "Company972", 65, "http://ricardo.org" },
                    { 71, "(530) 921-7377 x422", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", "Architecto aut ipsum et beatae iusto dolorem saepe velit aliquam. Optio nemo minima fugiat.", "Rachel26@yahoo.com", null, true, false, "Company14", 63, "http://amelia.info" },
                    { 75, "1-405-254-6654 x425", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Norris52@yahoo.com", null, true, false, "Company409", 67, "http://lelah.com" },
                    { 77, "1-929-204-0033", "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", "", "Modesta23@hotmail.com", null, true, false, "Company162", 61, "https://rupert.info" },
                    { 80, "(999) 691-0484", "24da036f-3088-4cb6-9e7d-07beb16991c1", "Nobis suscipit est totam autem quia mollitia esse perspiciatis ea. Vero repellat quos beatae ipsam quis id. Ex vero dolorum et et est sit ex. Qui vero architecto fugiat possimus dolor cumque consequatur.", "Evangeline16@yahoo.com", null, true, false, "Company636", 66, "https://brody.com" },
                    { 79, "1-692-434-0858", "f8496351-6630-4b31-8f73-15324b1e9866", "Quod autem consequatur consequatur id aperiam et. Perspiciatis ducimus quis eos veniam quo quos dicta debitis. Est voluptate assumenda enim dolores eveniet. In molestiae mollitia voluptatibus laboriosam pariatur accusamus ipsam.", "Alison_Ankunding7@yahoo.com", null, true, false, "Company694", 63, "http://bailey.org" },
                    { 72, "281-637-1398 x30691", "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", "Dolores laudantium odit. Beatae aliquam placeat deserunt provident expedita enim autem velit minus. Vitae alias eum cum et accusantium. Unde dolores ducimus nam et dicta.", "Ellis97@hotmail.com", null, true, false, "Company465", 63, "https://lew.info" }
                });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 1, 27, 16, 802, DateTimeKind.Local), 45, "Iusto dolore sed sit quisquam cupiditate.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 6, 29, 51, 300, DateTimeKind.Local), 49, "Excepturi ratione at et quibusdam soluta occaecati consectetur.", "9c91f9de-85da-4ea4-8c5b-181976d6362c" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 13, 32, 59, 720, DateTimeKind.Local), 43, "Fugiat enim facilis delectus labore qui quidem.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 14, 30, 0, 481, DateTimeKind.Local), 41, "Sed quia et suscipit accusamus.", "a39dd024-76e2-4401-89cf-2e74899e2448" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 12, 34, 33, 574, DateTimeKind.Local), 46, "Nesciunt voluptatem doloremque facere aspernatur voluptas eos nisi in.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 21, 57, 2, 15, DateTimeKind.Local), "Vel velit recusandae est possimus quis repellendus.", "f8496351-6630-4b31-8f73-15324b1e9866" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 8, 9, 35, 152, DateTimeKind.Local), 50, "Rerum minus ut consequatur ut.", "24da036f-3088-4cb6-9e7d-07beb16991c1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 3, 22, 37, 180, DateTimeKind.Local), 48, "Aut praesentium sunt labore necessitatibus et in minima nostrum pariatur.", "a7c1dd4b-ca32-4977-aeb8-133be150c795" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 4, 33, 20, 426, DateTimeKind.Local), 50, "Molestias sit in sit et et quis.", "0f31f24b-d6b2-454a-9914-581c5fd42469" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 11, 10, 22, 52, 422, DateTimeKind.Local), 44, "Et commodi ullam dolores repellat molestiae distinctio et.", "024f3656-21af-43b6-a989-218f35300913" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "AggregationForDay", "AggregationForHour", "AggregationForMonth", "CpuMaxPercent", "DiskMaxPercent", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "RamMaxPercent", "StatusCheckedAt", "Title" },
                values: new object[,]
                {
                    { 90, "46:81:a7:74:e8:29", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance177" },
                    { 84, "ce:3b:57:d0:3b:1a", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance71" },
                    { 85, "dc:9c:15:c4:d3:11", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance481" },
                    { 81, "a0:84:9b:fb:20:f6", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 75, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance361" },
                    { 87, "24:b3:02:46:47:03", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 75, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance273" },
                    { 83, "e7:98:b0:49:b5:19", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance774" },
                    { 82, "3f:c3:86:0c:11:e7", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance737" },
                    { 89, "de:b1:29:f8:4f:19", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance462" },
                    { 86, "27:b4:98:82:a2:07", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 79, "Windows", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance631" },
                    { 88, "14:c5:60:b8:fd:4b", true, true, true, 90f, 90f, new Guid("00000000-0000-0000-0000-000000000000"), true, false, 76, "Linux", 90f, new DateTime(2018, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified), "Instance816" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "f8496351-6630-4b31-8f73-15324b1e9866", 72, 1 },
                    { "a7c1dd4b-ca32-4977-aeb8-133be150c795", 76, 1 },
                    { "b4ae49d7-9ab4-4803-a3db-65c31b0d0bf0", 78, 1 },
                    { "9c91f9de-85da-4ea4-8c5b-181976d6362c", 74, 1 },
                    { "841fb6c1-cd08-491c-b1e8-72cd41e43ff6", 77, 1 },
                    { "a39dd024-76e2-4401-89cf-2e74899e2448", 75, 1 },
                    { "0f31f24b-d6b2-454a-9914-581c5fd42469", 75, 1 },
                    { "24da036f-3088-4cb6-9e7d-07beb16991c1", 78, 1 },
                    { "024f3656-21af-43b6-a989-218f35300913", 74, 1 },
                    { "d8693e92-5cf4-4cd9-9eba-db70b2eb013c", 79, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 99, new DateTime(2018, 9, 11, 6, 51, 1, 310, DateTimeKind.Local), 85, false, "Title828" },
                    { 92, new DateTime(2018, 9, 11, 7, 44, 20, 150, DateTimeKind.Local), 81, false, "Title518" },
                    { 91, new DateTime(2018, 9, 11, 4, 12, 11, 872, DateTimeKind.Local), 87, false, "Title807" },
                    { 97, new DateTime(2018, 9, 11, 9, 0, 58, 904, DateTimeKind.Local), 87, false, "Title589" },
                    { 94, new DateTime(2018, 9, 11, 1, 59, 5, 201, DateTimeKind.Local), 89, false, "Title341" },
                    { 98, new DateTime(2018, 9, 11, 1, 33, 29, 814, DateTimeKind.Local), 89, false, "Title571" },
                    { 96, new DateTime(2018, 9, 11, 19, 24, 54, 624, DateTimeKind.Local), 84, false, "Title38" },
                    { 100, new DateTime(2018, 9, 11, 15, 17, 11, 687, DateTimeKind.Local), 84, false, "Title648" },
                    { 93, new DateTime(2018, 9, 11, 2, 43, 33, 973, DateTimeKind.Local), 86, false, "Title379" },
                    { 95, new DateTime(2018, 9, 11, 12, 53, 13, 807, DateTimeKind.Local), 86, false, "Title633" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "HistoryTime", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 107, true, 91, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 40, "", 2, "X Label", "Y Label" },
                    { 109, true, 91, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 81, "", 0, "X Label", "Y Label" },
                    { 103, true, 97, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 37, "", 0, "X Label", "Y Label" },
                    { 104, true, 97, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 46, "", 2, "X Label", "Y Label" },
                    { 102, true, 94, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 76, "", 3, "X Label", "Y Label" },
                    { 101, true, 100, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 49, "", 3, "X Label", "Y Label" },
                    { 106, true, 100, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 70, "", 1, "X Label", "Y Label" },
                    { 105, true, 95, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 31, "", 0, "X Label", "Y Label" },
                    { 108, true, 95, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 82, "", 0, "X Label", "Y Label" },
                    { 110, true, 95, false, 5, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 3, "", 2, "X Label", "Y Label" }
                });
        }
    }
}
