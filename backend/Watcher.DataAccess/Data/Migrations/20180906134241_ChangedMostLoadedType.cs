using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedMostLoadedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "047c0189-76a6-4446-8294-3d5e0d3e5d9c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2133e14e-a893-4630-9c75-b8f41dce4c1c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2984b34d-5667-4986-8eef-ec4e17658c33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37cdecd7-aaac-4dc2-9c84-7e7289b521c4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "538a13da-2a85-426a-80fb-3388aa78c68a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8948ed9a-bc9b-4fa4-bd76-e196ae717a71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b2afb5d0-3114-42ab-806c-1f127173d81f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8354a9d-9f70-454a-8fb6-bf15ca19cf85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f7a272fa-80ff-48b3-a78a-a800be071761");

            migrationBuilder.AlterColumn<int>(
                name: "MostLoaded",
                table: "Charts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, 1, 87, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 96, 1, 50, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, 1, 47, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, 1, 40, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 98, 1, 34, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 94, 1, 87, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 91, 1, 69 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 93, 1, 99 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, 1, 82, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 93, 1, 81 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 4, 55, 40, 291, DateTimeKind.Local), 81, "Title883" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 21, 51, 7, 105, DateTimeKind.Local), 82, "Title569" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 2, 46, 36, 694, DateTimeKind.Local), "Title244" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 8, 52, 8, 504, DateTimeKind.Local), 86, "Title654" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 14, 12, 27, 381, DateTimeKind.Local), 82, "Title696" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 12, 41, 59, 429, DateTimeKind.Local), 88, "Title987" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 8, 27, 49, 610, DateTimeKind.Local), 85, "Title4" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 22, 43, 16, 602, DateTimeKind.Local), "Title681" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 6, 16, 30, 35, 174, DateTimeKind.Local), 81, "Title199" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 5, 23, 27, 12, 586, DateTimeKind.Local), 90, "Title41" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "5d:80:e7:21:37:15", "Windows", "Instance680" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "84:f9:9f:77:fe:8e", 76, "Linux", "Instance781" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "b9:7b:96:db:5b:65", 79, "Instance783" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "e3:ae:b9:15:00:b7", 80, "Linux", "Instance772" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "62:5d:97:00:53:47", 72, "Instance194" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "7f:8f:9a:7b:03:e1", 80, "Instance64" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "41:c5:0e:b5:7e:d5", 73, "Instance772" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "98:41:1f:06:d0:5b", 79, "Linux", "Instance464" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "49:26:a6:12:92:53", 71, "Linux", "Instance532" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "cd:ea:87:5f:81:9d", 74, "Instance68" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Trade", "Theme173" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme891");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme129" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme111" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme855" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme65" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme625" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme278" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme628" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme519" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", null, new DateTime(2018, 9, 6, 2, 43, 15, 725, DateTimeKind.Local), "Florencio", "Wilfrid5@gmail.com", null, "Linda", true, false, "Morar", null, "https://s3.amazonaws.com/uifaces/faces/twitter/okandungel/128.jpg", 2 },
                    { "336b6819-321b-4ad4-8bb5-035ad64d6554", null, new DateTime(2018, 9, 6, 11, 17, 1, 331, DateTimeKind.Local), "Joan", "Ruben6@yahoo.com", null, "Camilla", true, false, "Hodkiewicz", null, "https://s3.amazonaws.com/uifaces/faces/twitter/itskawsar/128.jpg", 1 },
                    { "bd968176-81d7-4c5d-bd2b-b20285d2d530", null, new DateTime(2018, 9, 6, 3, 13, 15, 990, DateTimeKind.Local), "Jayde", "Caesar.Bauch@hotmail.com", null, "Josephine", true, false, "Senger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/scottiedude/128.jpg", 1 },
                    { "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7", null, new DateTime(2018, 9, 6, 4, 38, 34, 697, DateTimeKind.Local), "Antonia", "Marcelle.Bechtelar83@gmail.com", null, "Deanna", true, false, "Kessler", null, "https://s3.amazonaws.com/uifaces/faces/twitter/wegotvices/128.jpg", 2 },
                    { "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", null, new DateTime(2018, 9, 5, 21, 43, 29, 742, DateTimeKind.Local), "Justen", "Bernhard_Hoeger@gmail.com", null, "Sandrine", true, false, "Kling", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ramanathan_pdy/128.jpg", 1 },
                    { "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", null, new DateTime(2018, 9, 6, 7, 9, 33, 50, DateTimeKind.Local), "Myrtie", "Stan_Brown@hotmail.com", null, "Avery", true, false, "Lemke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/shvelo96/128.jpg", 2 },
                    { "709d2130-1cbc-440b-bcdc-59a22015fb59", null, new DateTime(2018, 9, 6, 16, 10, 58, 572, DateTimeKind.Local), "Donna", "Juanita69@yahoo.com", null, "Bridget", true, false, "Berge", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jpenico/128.jpg", 1 },
                    { "710dd97d-5260-4f63-b41f-fad31ccb362b", null, new DateTime(2018, 9, 6, 3, 44, 55, 798, DateTimeKind.Local), "Karianne", "Aisha.Johnston@yahoo.com", null, "Amani", true, false, "Moore", null, "https://s3.amazonaws.com/uifaces/faces/twitter/trueblood_33/128.jpg", 1 },
                    { "9c25aab1-c9de-4f92-ad92-552cff82c801", null, new DateTime(2018, 9, 6, 7, 39, 27, 741, DateTimeKind.Local), "Michele", "Antoinette.Bechtelar87@hotmail.com", null, "Dusty", true, false, "Wolf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/madebybrenton/128.jpg", 1 },
                    { "6ac0b034-9498-4ce8-bbc1-b627c976d8c5", null, new DateTime(2018, 9, 6, 13, 23, 1, 557, DateTimeKind.Local), "Nelson", "Ruthie.Bogan@yahoo.com", null, "Emmanuel", true, false, "Konopelski", null, "https://s3.amazonaws.com/uifaces/faces/twitter/tbakdesigns/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", "rem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "6ac0b034-9498-4ce8-bbc1-b627c976d8c5", "suscipit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c25aab1-c9de-4f92-ad92-552cff82c801", "quidem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "bd968176-81d7-4c5d-bd2b-b20285d2d530", "est" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "9c25aab1-c9de-4f92-ad92-552cff82c801", "magni" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "336b6819-321b-4ad4-8bb5-035ad64d6554", "sit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "336b6819-321b-4ad4-8bb5-035ad64d6554", "voluptate" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "709d2130-1cbc-440b-bcdc-59a22015fb59", "fugiat" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", "rerum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "710dd97d-5260-4f63-b41f-fad31ccb362b", "expedita" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 14, 25, 45, 719, DateTimeKind.Local), "Ipsum aperiam pariatur deserunt laboriosam soluta facilis tempore.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 21, 56, 58, 642, DateTimeKind.Local), "Voluptatem occaecati officiis accusamus et sed.", "336b6819-321b-4ad4-8bb5-035ad64d6554" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 8, 28, 52, 629, DateTimeKind.Local), "Sunt voluptas itaque commodi.", "710dd97d-5260-4f63-b41f-fad31ccb362b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 19, 57, 46, 172, DateTimeKind.Local), "Quo id est aliquid architecto in eum autem.", "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 0, 41, 27, 757, DateTimeKind.Local), "Eos nulla ipsam maiores iure.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 9, 33, 53, 406, DateTimeKind.Local), "Excepturi quis quis non ut voluptatem.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 10, 44, 39, 56, DateTimeKind.Local), "Sit aspernatur atque.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 17, 53, 25, 316, DateTimeKind.Local), "Aut et voluptate nesciunt commodi eos eos et alias quod.", "6ac0b034-9498-4ce8-bbc1-b627c976d8c5" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 18, 55, 53, 284, DateTimeKind.Local), "Molestiae qui qui enim omnis.", "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 19, 27, 17, 246, DateTimeKind.Local), "Totam cum nisi aperiam omnis.", "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 6, 5, 33, 27, 589, DateTimeKind.Local), "Nostrum et at quia et dolor provident.", "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 6, 6, 37, 0, 265, DateTimeKind.Local), "Quia ut debitis quo ratione aliquam quam.", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 5, 16, 46, 39, 272, DateTimeKind.Local), "Voluptas sed omnis.", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 9, 6, 16, 35, 9, 346, DateTimeKind.Local), "Voluptatum laboriosam sit soluta deleniti qui eos doloremque sed fuga.", "709d2130-1cbc-440b-bcdc-59a22015fb59", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 13, 6, 58, 814, DateTimeKind.Local), "Non tenetur molestiae.", "709d2130-1cbc-440b-bcdc-59a22015fb59" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 6, 16, 35, 32, 858, DateTimeKind.Local), "Et quisquam qui suscipit.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 6, 8, 54, 16, 442, DateTimeKind.Local), "Assumenda laboriosam ab maiores quisquam velit.", "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 6, 10, 55, 57, 0, DateTimeKind.Local), "Quibusdam ut architecto.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 6, 11, 51, 2, 822, DateTimeKind.Local), "Architecto unde eveniet est.", "6ac0b034-9498-4ce8-bbc1-b627c976d8c5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 6, 14, 17, 58, 869, DateTimeKind.Local), "Atque dolor accusantium optio doloremque dolore labore perspiciatis.", "710dd97d-5260-4f63-b41f-fad31ccb362b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 0, "a5115d99-ad29-4ee1-a36c-bf19d9ed9024" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 2, "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "e7c95ed4-eb74-4d7d-8e43-54920f6130f6");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, false, 0, "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { true, 1, "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { false, "6ac0b034-9498-4ce8-bbc1-b627c976d8c5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { false, false, 3, "6ac0b034-9498-4ce8-bbc1-b627c976d8c5" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 19, 22, 10, 338, DateTimeKind.Local), 12, "Non alias minima.", "6ac0b034-9498-4ce8-bbc1-b627c976d8c5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 3, 45, 15, 299, DateTimeKind.Local), 12, "Minus quaerat id nemo perferendis dolorum quasi iste.", "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 15, 58, 55, 868, DateTimeKind.Local), 13, "Odit vel voluptatem tempora recusandae sit.", "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 0, 57, 2, 275, DateTimeKind.Local), 12, "Earum veritatis rem animi eaque.", "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 12, 7, 48, 125, DateTimeKind.Local), 17, "Dolor earum omnis accusamus quisquam excepturi nesciunt rerum.", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 22, 5, 5, 707, DateTimeKind.Local), 18, "Asperiores vitae dolorem quia dolore inventore.", "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 7, 16, 44, 806, DateTimeKind.Local), 15, "Rerum totam iusto ipsam tempore quo esse culpa esse magnam.", "336b6819-321b-4ad4-8bb5-035ad64d6554" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 20, 33, 47, 989, DateTimeKind.Local), 16, "Nisi earum et quo est ut.", "336b6819-321b-4ad4-8bb5-035ad64d6554" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 18, 58, 18, 353, DateTimeKind.Local), 13, "Hic voluptatibus facilis ad autem mollitia provident aut et.", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 5, 58, 39, 80, DateTimeKind.Local), 19, "Ea voluptas quia tempora est soluta.", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-334-416-3124 x30640", "709d2130-1cbc-440b-bcdc-59a22015fb59", "Laboriosam laborum quia aut quia sed laudantium quae odit consequuntur. Ullam aut molestiae consequatur qui dolorum labore dolorem magnam.", "Brittany74@hotmail.com", "Company811", 69, "https://clemens.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "859.789.0940 x5583", "6ac0b034-9498-4ce8-bbc1-b627c976d8c5", "", "Damon_McClure@yahoo.com", "Company643", 70, "http://mona.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "273-245-1772 x8273", "336b6819-321b-4ad4-8bb5-035ad64d6554", "Aspernatur et impedit nulla natus blanditiis alias aliquid omnis.", "Eduardo_Gutmann@gmail.com", "Company983", 66, "http://jovan.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-422-471-9590", "709d2130-1cbc-440b-bcdc-59a22015fb59", "Molestiae vel eos veritatis natus odit quam nulla ut. Rerum culpa dolor. Provident voluptatem magnam dignissimos tenetur.", "Shaylee.Goyette89@yahoo.com", "Company467", 70, "http://dejuan.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "644-784-3183 x936", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", "Qui harum est. Quas sunt perferendis repudiandae sapiente. Error facere ipsam eum ut sed.", "Elmore18@yahoo.com", "Company468", 65, "https://maiya.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(696) 928-5940 x3584", "bd968176-81d7-4c5d-bd2b-b20285d2d530", "", "Scot_Bergnaum@yahoo.com", "Company219", "http://nikki.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "532-524-4611", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", "Non dolorem voluptate necessitatibus blanditiis et vel veritatis. Quia sunt reprehenderit. Iste modi aspernatur sed. Et commodi maiores maxime doloribus et asperiores ipsam error explicabo.", "Avery.Harvey66@yahoo.com", "Company17", 67, "https://josie.name" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-623-390-7130", "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", "", "Tamia48@yahoo.com", "Company538", 66, "https://cory.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "326-906-0762 x4673", "bd968176-81d7-4c5d-bd2b-b20285d2d530", "", "Niko5@gmail.com", "Company696", 69, "http://kacie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(997) 861-9701", "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", "Voluptate qui commodi. Eos iusto velit voluptas. Adipisci quis eum nulla aliquam minus qui inventore aliquam.", "Genevieve.Kiehn41@yahoo.com", "Company911", 69, "https://montana.name" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 9, 45, 43, 63, DateTimeKind.Local), 46, "Assumenda reprehenderit consequatur.", "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 17, 51, 58, 801, DateTimeKind.Local), 46, "Voluptatibus molestias modi in autem accusamus consequatur consectetur qui in.", "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 5, 17, 19, 11, 641, DateTimeKind.Local), 45, "Dolorem nihil laboriosam voluptatem animi laboriosam reprehenderit et consequuntur qui.", "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 6, 42, 43, 945, DateTimeKind.Local), "Ut rerum et blanditiis.", "709d2130-1cbc-440b-bcdc-59a22015fb59" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 9, 38, 4, 70, DateTimeKind.Local), 42, "Omnis sit debitis atque aut atque rerum harum dolorem.", "710dd97d-5260-4f63-b41f-fad31ccb362b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 4, 41, 1, 314, DateTimeKind.Local), 42, "Est nam ut nostrum ipsum non sint eum rerum animi.", "a5115d99-ad29-4ee1-a36c-bf19d9ed9024" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 6, 5, 23, 906, DateTimeKind.Local), 43, "Qui est dolores quia et voluptate et voluptatem aut.", "336b6819-321b-4ad4-8bb5-035ad64d6554" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 12, 43, 57, 851, DateTimeKind.Local), 42, "Sed quos possimus soluta qui quis exercitationem distinctio veniam distinctio.", "bd968176-81d7-4c5d-bd2b-b20285d2d530" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 4, 51, 11, 571, DateTimeKind.Local), 44, "Autem repudiandae minus autem quasi aut facilis.", "9c25aab1-c9de-4f92-ad92-552cff82c801" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 6, 3, 51, 22, 712, DateTimeKind.Local), 46, "Et omnis officiis.", "709d2130-1cbc-440b-bcdc-59a22015fb59" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "9c25aab1-c9de-4f92-ad92-552cff82c801", 71 },
                    { "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", 76 },
                    { "336b6819-321b-4ad4-8bb5-035ad64d6554", 73 },
                    { "709d2130-1cbc-440b-bcdc-59a22015fb59", 76 },
                    { "bd968176-81d7-4c5d-bd2b-b20285d2d530", 79 },
                    { "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", 71 },
                    { "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7", 73 },
                    { "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", 76 },
                    { "710dd97d-5260-4f63-b41f-fad31ccb362b", 72 },
                    { "6ac0b034-9498-4ce8-bbc1-b627c976d8c5", 77 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "336b6819-321b-4ad4-8bb5-035ad64d6554", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "6ac0b034-9498-4ce8-bbc1-b627c976d8c5", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "709d2130-1cbc-440b-bcdc-59a22015fb59", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "710dd97d-5260-4f63-b41f-fad31ccb362b", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9c25aab1-c9de-4f92-ad92-552cff82c801", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "a5115d99-ad29-4ee1-a36c-bf19d9ed9024", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bd968176-81d7-4c5d-bd2b-b20285d2d530", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e7c95ed4-eb74-4d7d-8e43-54920f6130f6", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "336b6819-321b-4ad4-8bb5-035ad64d6554");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6ac0b034-9498-4ce8-bbc1-b627c976d8c5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "709d2130-1cbc-440b-bcdc-59a22015fb59");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "710dd97d-5260-4f63-b41f-fad31ccb362b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9c25aab1-c9de-4f92-ad92-552cff82c801");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a5115d99-ad29-4ee1-a36c-bf19d9ed9024");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ab77a1b0-8a1b-46e8-a340-febd2c1d3ac7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bd968176-81d7-4c5d-bd2b-b20285d2d530");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e7c95ed4-eb74-4d7d-8e43-54920f6130f6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ff9b7cd1-e6d4-4abe-afaa-34f8291ff90b");

            migrationBuilder.AlterColumn<string>(
                name: "MostLoaded",
                table: "Charts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded3", 92, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded3", 35, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 91, "MostLoaded2", 76, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded3", 93, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 100, "MostLoaded1", 21, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", 83, 0 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 96, "MostLoaded1", 26 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 100, "MostLoaded2", 59 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold", "Type" },
                values: new object[] { 99, "MostLoaded2", 30, 3 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "Threshold" },
                values: new object[] { 91, "MostLoaded2", 45 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 13, 46, 552, DateTimeKind.Local), 85, "Title393" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 14, 42, 744, DateTimeKind.Local), 86, "Title649" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 15, 31, 10, 63, DateTimeKind.Local), "Title369" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 22, 10, 28, 226, DateTimeKind.Local), 83, "Title718" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 46, 17, 771, DateTimeKind.Local), 89, "Title472" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 37, 15, 617, DateTimeKind.Local), 89, "Title404" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 4, 35, 12, 8, DateTimeKind.Local), 84, "Title804" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 27, 43, 183, DateTimeKind.Local), "Title641" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 18, 15, 52, 397, DateTimeKind.Local), 87, "Title322" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 34, 41, 251, DateTimeKind.Local), 86, "Title953" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "Platform", "Title" },
                values: new object[] { "b4:19:1b:2e:8a:be", "Linux", "Instance159" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "81:0f:9d:6e:dc:ac", 72, "Windows", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "5f:b5:e2:dd:06:44", 73, "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "92:bb:36:33:cf:da", 72, "Windows", "Instance441" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "83:4f:14:bc:d7:58", 71, "Instance820" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "2b:c0:da:2b:c7:ff", 73, "Instance617" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "89:5b:c4:b0:49:c5", 79, "Instance153" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "89:cc:7b:80:7a:10", 77, "Windows", "Instance619" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "34:92:85:5c:37:d1", 79, "Windows", "Instance22" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a3:e5:3a:8c:fb:27", 76, "Instance418" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme563" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Theme236");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Frutiger", "Theme795" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme315" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Helvetica", "Theme390" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme511" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme406" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme389" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme938" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FontFamily", "Name" },
                values: new object[] { "Univers", "Theme741" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", null, new DateTime(2018, 9, 1, 0, 28, 48, 302, DateTimeKind.Local), "Laney", "Destany.Walker@yahoo.com", null, "Kareem", true, false, "Predovic", null, "https://s3.amazonaws.com/uifaces/faces/twitter/BrianPurkiss/128.jpg", 1 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", null, new DateTime(2018, 9, 1, 12, 8, 4, 251, DateTimeKind.Local), "Deshaun", "Kiera_Gusikowski@hotmail.com", null, "Dangelo", true, false, "Upton", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidsasda/128.jpg", 2 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", null, new DateTime(2018, 9, 1, 10, 27, 25, 47, DateTimeKind.Local), "Shayna", "Hayden.Buckridge62@yahoo.com", null, "Vernice", true, false, "Hettinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/Talbi_ConSept/128.jpg", 1 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", null, new DateTime(2018, 9, 1, 22, 15, 38, 588, DateTimeKind.Local), "Madelynn", "Bailee.Hudson47@hotmail.com", null, "Gabrielle", true, false, "Romaguera", null, "https://s3.amazonaws.com/uifaces/faces/twitter/drewbyreese/128.jpg", 2 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", null, new DateTime(2018, 9, 1, 6, 8, 46, 241, DateTimeKind.Local), "Ettie", "Ora_Ferry42@yahoo.com", null, "Jewel", true, false, "Heathcote", null, "https://s3.amazonaws.com/uifaces/faces/twitter/geobikas/128.jpg", 1 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", null, new DateTime(2018, 9, 1, 10, 42, 5, 898, DateTimeKind.Local), "Jodie", "Helene_Pfannerstill@yahoo.com", null, "Lemuel", true, false, "Olson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/al_li/128.jpg", 2 },
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", null, new DateTime(2018, 9, 1, 16, 45, 38, 815, DateTimeKind.Local), "Eudora", "Lavinia32@yahoo.com", null, "Tessie", true, false, "VonRueden", null, "https://s3.amazonaws.com/uifaces/faces/twitter/psdesignuk/128.jpg", 1 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", null, new DateTime(2018, 9, 1, 23, 31, 24, 903, DateTimeKind.Local), "Orion", "Leatha.Hoeger92@yahoo.com", null, "Austin", true, false, "Bernier", null, "https://s3.amazonaws.com/uifaces/faces/twitter/r_garcia/128.jpg", 1 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", null, new DateTime(2018, 9, 1, 1, 1, 26, 128, DateTimeKind.Local), "Shawna", "Sophia.Schiller@gmail.com", null, "Flo", true, false, "Kertzmann", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kohette/128.jpg", 1 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", null, new DateTime(2018, 9, 1, 1, 31, 45, 433, DateTimeKind.Local), "Hyman", "Bernard40@hotmail.com", null, "Haylie", true, false, "Kulas", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kostaspt/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "voluptatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "facilis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "2984b34d-5667-4986-8eef-ec4e17658c33", "cum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "perferendis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "b2afb5d0-3114-42ab-806c-1f127173d81f", "asperiores" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "odit" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 53, 14, 78, DateTimeKind.Local), "Numquam eveniet quo sed.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 49, 17, 251, DateTimeKind.Local), "Consequatur libero et ut facere ullam quibusdam natus id sunt.", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 14, 56, 746, DateTimeKind.Local), "Mollitia recusandae ut ab facere earum sed dolores.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 27, 52, 8, DateTimeKind.Local), "Officia cum consequuntur similique dolorem eos et eaque maiores eos.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 28, 21, 616, DateTimeKind.Local), "Rem voluptate minus libero.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 8, 46, 42, 91, DateTimeKind.Local), "Laboriosam ea velit error veniam.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 5, 24, 16, 360, DateTimeKind.Local), "Sit quibusdam quos vel corrupti.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 31, 32, 496, DateTimeKind.Local), "Ipsum tempora id.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 23, 36, 19, 108, DateTimeKind.Local), "Magnam officiis blanditiis voluptatem odit in ut non accusamus at.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 19, 30, 190, DateTimeKind.Local), "Amet voluptatem error quis adipisci voluptatum ut.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 9, 1, 6, 41, 58, 762, DateTimeKind.Local), "Qui eum laudantium ratione suscipit consequatur qui nulla voluptates.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 1, 0, 19, 48, 931, DateTimeKind.Local), "Consequatur et minus quia qui fuga quia omnis.", "538a13da-2a85-426a-80fb-3388aa78c68a", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 43, 41, 791, DateTimeKind.Local), "Sed sed consequatur ad id magni.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 1, 5, 14, 7, 727, DateTimeKind.Local), "Nisi laborum molestiae unde consectetur non cumque.", "f7a272fa-80ff-48b3-a78a-a800be071761", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 11, 44, 0, 426, DateTimeKind.Local), "Voluptatem inventore et rerum minus et eaque.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 21, new DateTime(2018, 9, 1, 23, 9, 29, 927, DateTimeKind.Local), "Qui et et reiciendis.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { new DateTime(2018, 9, 1, 16, 15, 49, 192, DateTimeKind.Local), "Fugit omnis voluptas velit sunt qui in veniam.", "2133e14e-a893-4630-9c75-b8f41dce4c1c", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 21, 12, 29, 577, DateTimeKind.Local), "Maxime numquam vitae corrupti repudiandae aut repellat.", "b2afb5d0-3114-42ab-806c-1f127173d81f", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 9, 1, 5, 57, 18, 812, DateTimeKind.Local), "Qui quis dolor quisquam.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 1, 16, 37, 59, 517, DateTimeKind.Local), "Ratione veniam vel odio nesciunt doloremque laudantium sed sint.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 1, "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 3, "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, true, 4, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsMute", "Type", "UserId" },
                values: new object[] { false, 4, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "UserId" },
                values: new object[] { true, "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "Type", "UserId" },
                values: new object[] { true, true, 2, "8948ed9a-bc9b-4fa4-bd76-e196ae717a71" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 2, "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 6, 57, 34, 661, DateTimeKind.Local), 16, "Omnis corrupti ut aliquid tempore sint ab non.", "37cdecd7-aaac-4dc2-9c84-7e7289b521c4" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 21, 20, 774, DateTimeKind.Local), 14, "Consectetur velit laudantium delectus et.", "2133e14e-a893-4630-9c75-b8f41dce4c1c" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 24, 55, 38, DateTimeKind.Local), 20, "Illum labore ex.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 55, 23, 113, DateTimeKind.Local), 16, "Aut voluptas consequatur qui dolorem expedita corrupti et laborum illo.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 2, 41, 46, 334, DateTimeKind.Local), 19, "Et rem quibusdam quae laborum iste ex corrupti.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 45, 16, 740, DateTimeKind.Local), 13, "Expedita sapiente dolore.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 20, 26, 742, DateTimeKind.Local), 19, "Architecto voluptas autem laborum soluta corrupti sed et distinctio aliquid.", "b2afb5d0-3114-42ab-806c-1f127173d81f" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 14, 27, 21, 972, DateTimeKind.Local), 18, "Aliquid neque voluptas natus aut qui vel fuga.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 13, 10, 179, DateTimeKind.Local), 12, "Vel repellat non omnis et iste consequatur nobis dolores vel.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 17, 7, 26, 469, DateTimeKind.Local), 18, "Beatae harum eligendi eos voluptatem blanditiis itaque.", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(577) 691-9767", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Aut consequatur quos. Eos omnis labore sint tenetur sunt voluptas dolorem blanditiis.", "Amina36@hotmail.com", "Company845", 66, "https://malcolm.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(867) 873-0725 x4204", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "Molestiae nulla est. Modi cum eveniet culpa dolores. Voluptatibus explicabo et ut aspernatur harum cumque debitis iure optio. Est consequatur at ducimus et.", "Mozelle_Lockman57@gmail.com", "Company24", 65, "http://caroline.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(313) 973-9204 x851", "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", "", "Brad_Bashirian@hotmail.com", "Company728", 69, "https://katlynn.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(255) 205-4271 x42556", "b2afb5d0-3114-42ab-806c-1f127173d81f", "Sint iusto occaecati dicta illum harum dolores impedit autem voluptas.", "Riley.Gutkowski@hotmail.com", "Company153", 68, "https://justus.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-866-552-3615 x9077", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Dicta voluptas veniam non enim dignissimos.", "Jaclyn.Krajcik42@hotmail.com", "Company450", 70, "https://moshe.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "915.804.6936", "047c0189-76a6-4446-8294-3d5e0d3e5d9c", "Dolorum saepe laboriosam aut ducimus omnis rem vel. Assumenda asperiores illum. Et voluptas ipsam unde.", "Margarete_Hegmann18@gmail.com", "Company691", "http://omer.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "230.244.8763 x821", "2133e14e-a893-4630-9c75-b8f41dce4c1c", "Ex in ratione nemo commodi. Aperiam expedita velit omnis qui veritatis quis. Deserunt cum natus cumque ipsum voluptatibus cumque eos. Officiis dolorem libero perferendis ut quo fuga.", "Ignacio_Gorczany18@hotmail.com", "Company14", 63, "https://reid.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-445-200-6350", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", "Quos qui ad atque optio iste veritatis. In neque amet animi recusandae nisi aut accusantium ipsa est. Consequatur et est quis. Qui nesciunt asperiores necessitatibus sunt exercitationem aperiam voluptatem harum.", "Ozella.OConner@yahoo.com", "Company464", 69, "http://wilford.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "752.498.8375 x405", "b2afb5d0-3114-42ab-806c-1f127173d81f", "At minima magni et. Sunt laudantium voluptas est aut exercitationem nam sunt quisquam neque.", "Fidel_Krajcik56@gmail.com", "Company965", 61, "http://rebeca.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-598-997-6208", "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", "Numquam iusto hic enim dolorum adipisci. Et est quis ex sint tenetur et natus. Voluptatem aut occaecati sequi animi. Voluptate soluta veritatis deleniti facere.", "Lesly11@gmail.com", "Company568", 61, "http://raina.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 10, 26, 11, 135, DateTimeKind.Local), 50, "Sit consequuntur reprehenderit explicabo sit.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 21, 50, 23, 857, DateTimeKind.Local), 50, "Velit quam voluptatem sed aut sapiente cupiditate.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 7, 43, 44, 409, DateTimeKind.Local), 41, "Rerum et expedita tempora adipisci consequatur est earum ut quia.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 1, 9, 30, 814, DateTimeKind.Local), "Quia consectetur porro atque perferendis est molestiae.", "2984b34d-5667-4986-8eef-ec4e17658c33" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 16, 8, 33, 965, DateTimeKind.Local), 44, "Aperiam qui blanditiis.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 19, 56, 4, 316, DateTimeKind.Local), 46, "Rerum quaerat qui provident rem.", "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 9, 28, 59, 3, DateTimeKind.Local), 44, "Dolores commodi praesentium id aliquid dicta aperiam maiores est aut.", "538a13da-2a85-426a-80fb-3388aa78c68a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 20, 8, 35, 688, DateTimeKind.Local), 49, "Eligendi quis ut aut nesciunt vitae.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 12, 3, 22, 131, DateTimeKind.Local), 50, "Nihil sit aut omnis deserunt quisquam omnis qui.", "f7a272fa-80ff-48b3-a78a-a800be071761" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 1, 3, 6, 3, 911, DateTimeKind.Local), 43, "Delectus soluta assumenda rerum eligendi totam unde.", "047c0189-76a6-4446-8294-3d5e0d3e5d9c" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f7a272fa-80ff-48b3-a78a-a800be071761", 79 },
                    { "047c0189-76a6-4446-8294-3d5e0d3e5d9c", 79 },
                    { "8948ed9a-bc9b-4fa4-bd76-e196ae717a71", 77 },
                    { "e8354a9d-9f70-454a-8fb6-bf15ca19cf85", 74 },
                    { "ef5a2a7b-5dee-4d0e-b815-0cac1135cf71", 78 },
                    { "538a13da-2a85-426a-80fb-3388aa78c68a", 75 },
                    { "2133e14e-a893-4630-9c75-b8f41dce4c1c", 75 },
                    { "2984b34d-5667-4986-8eef-ec4e17658c33", 76 },
                    { "b2afb5d0-3114-42ab-806c-1f127173d81f", 79 },
                    { "37cdecd7-aaac-4dc2-9c84-7e7289b521c4", 77 }
                });
        }
    }
}
