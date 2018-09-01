using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ChangedChart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8486e755-b481-4eff-be21-9d95556987d1", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "97778277-833d-4bba-bc08-96216119b974", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11d76c7c-c316-4694-80a0-8bc2810e1224");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3c66a652-9d95-41f8-b4e5-431382d4ac14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "48fd27a3-127f-4da8-a8e7-8f46e1d41bba");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5504b109-e452-447b-97d1-a4812ac6e83e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8486e755-b481-4eff-be21-9d95556987d1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "97778277-833d-4bba-bc08-96216119b974");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b09e040a-1384-4abb-bcb5-e32a9e812f40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c92ca16a-d03a-4f48-857d-4ded5fe4735e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d274933f-0df6-4ce1-860f-29ba557430f5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d7c68027-7a0a-4b78-aef9-02781e94182c");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Charts");

            migrationBuilder.AlterColumn<bool>(
                name: "ShowCommon",
                table: "Charts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AutoScale",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Gradient",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLightTheme",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShowSeriesOnHover",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTooltipDisabled",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LegendTitle",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RangeFillOpacity",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "RoundDomains",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SchemeType",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ShowGridLines",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowLegend",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowXAxis",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowXAxisLabel",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowYAxis",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowYAxisLabel",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Sources",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XAxisLabel",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YAxisLabel",
                table: "Charts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 96, true, true, "Legend", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 76, "", 1, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 97, true, true, "Legend", "MostLoaded1", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 43, "", 3, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 99, true, true, "Legend", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 71, "", 3, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 100, true, true, "Legend", "MostLoaded3", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 15, "", 2, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 93, true, true, "Legend", "MostLoaded3", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 36, "", 2, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 93, true, true, "Legend", "MostLoaded1", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 12, "", "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 92, true, true, "Legend", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 57, "", 2, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 99, true, true, "Legend", "MostLoaded2", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 68, "", 2, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 93, true, true, "Legend", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 71, "", 3, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AutoScale", "DashboardId", "IsLightTheme", "IsShowSeriesOnHover", "LegendTitle", "MostLoaded", "RangeFillOpacity", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[] { true, 94, true, true, "Legend", "MostLoaded3", 0.5, "ordinal", true, true, true, true, true, true, true, "0,1", 72, "", 3, "X Label", "Y Label" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 29, 21, 278, DateTimeKind.Local), 86, "Title150" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 53, 8, 623, DateTimeKind.Local), 90, "Title277" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 29, 33, 969, DateTimeKind.Local), "Title629" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 54, 43, 857, DateTimeKind.Local), 85, "Title750" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 22, 30, 557, DateTimeKind.Local), "Title536" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 40, 53, 305, DateTimeKind.Local), 82, "Title286" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 27, 30, 216, DateTimeKind.Local), 82, "Title975" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 44, 51, 22, DateTimeKind.Local), 88, "Title696" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 17, 43, 42, 651, DateTimeKind.Local), "Title106" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 30, 16, 48, 35, 540, DateTimeKind.Local), 89, "Title912" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "73:ec:19:cd:61:fe", 73, "Windows", "Instance582" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "11:45:22:0c:0f:e4", 71, "Linux", "Instance224" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0f:96:40:a1:31:b6", 77, "Linux", "Instance74" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "86:7f:ad:1e:2a:c6", 79, "Windows", "Instance648" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "a5:b7:54:b8:a5:1f", 73, "Instance262" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "dd:f3:15:0f:17:dc", 77, "Instance428" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "60:e0:e2:2d:b9:91", 76, "Instance607" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "0f:3c:a8:37:e0:57", 73, "Windows", "Instance880" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6c:cc:e5:99:2e:93", 75, "Instance987" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "1a:5d:3d:98:7a:c4", 79, "Instance27" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme482" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Helvetica", "Theme897" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Frutiger", "Theme558" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme998" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme189" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme516" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme394");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Frutiger", "Theme150" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme615" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Trade", "Theme637" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "0cc0334a-a604-4fef-89b6-677392e535c1", null, new DateTime(2018, 8, 30, 0, 49, 14, 925, DateTimeKind.Local), "Dessie", "Louvenia.Dietrich@gmail.com", null, "Ford", true, "Kassulke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/davidhemphill/128.jpg", 2 },
                    { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", null, new DateTime(2018, 8, 29, 21, 12, 30, 563, DateTimeKind.Local), "Amani", "Yolanda.Ruecker27@yahoo.com", null, "Yesenia", true, "Labadie", null, "https://s3.amazonaws.com/uifaces/faces/twitter/antonyryndya/128.jpg", 1 },
                    { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", null, new DateTime(2018, 8, 30, 14, 5, 13, 34, DateTimeKind.Local), "Billy", "Godfrey_Douglas86@yahoo.com", null, "Gwen", true, "McCullough", null, "https://s3.amazonaws.com/uifaces/faces/twitter/svenlen/128.jpg", 1 },
                    { "f851c462-8fe4-48e6-bb81-4d9cfb740521", null, new DateTime(2018, 8, 29, 22, 41, 9, 135, DateTimeKind.Local), "Christa", "Kitty.Schiller3@yahoo.com", null, "Elena", true, "Stamm", null, "https://s3.amazonaws.com/uifaces/faces/twitter/eddiechen/128.jpg", 2 },
                    { "9022ac94-1cd8-46cc-a0a8-b24258800d30", null, new DateTime(2018, 8, 30, 15, 24, 23, 341, DateTimeKind.Local), "Dusty", "Orrin65@yahoo.com", null, "Jadyn", true, "Bogan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/sethlouey/128.jpg", 2 },
                    { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", null, new DateTime(2018, 8, 30, 14, 19, 48, 547, DateTimeKind.Local), "Nona", "Sean83@hotmail.com", null, "Jamison", true, "Leannon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/joki4/128.jpg", 2 },
                    { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", null, new DateTime(2018, 8, 30, 9, 34, 26, 103, DateTimeKind.Local), "Kolby", "Kailyn86@yahoo.com", null, "Eldred", true, "Conroy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/chacky14/128.jpg", 2 },
                    { "f0a5b62a-da54-4712-9452-6440ef65945d", null, new DateTime(2018, 8, 30, 3, 26, 41, 214, DateTimeKind.Local), "Elsie", "Candace.Sporer@hotmail.com", null, "Lexie", true, "Wiza", null, "https://s3.amazonaws.com/uifaces/faces/twitter/gseguin/128.jpg", 1 },
                    { "8a65aa2c-1690-4985-b55a-52cad5015049", null, new DateTime(2018, 8, 30, 14, 25, 52, 791, DateTimeKind.Local), "Willow", "Quincy_Weber@hotmail.com", null, "Zion", true, "Rau", null, "https://s3.amazonaws.com/uifaces/faces/twitter/smaczny/128.jpg", 1 },
                    { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", null, new DateTime(2018, 8, 30, 10, 34, 39, 193, DateTimeKind.Local), "Brielle", "Elvie_Wiegand53@gmail.com", null, "Johnathan", true, "Schiller", null, "https://s3.amazonaws.com/uifaces/faces/twitter/adellecharles/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", "quis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", "nisi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", "dolorem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", "qui" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "beatae" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "omnis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", "ea" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 46, 13, 987, DateTimeKind.Local), "Qui consequuntur corrupti cumque minus minus soluta fugit.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 9, 21, 5, 834, DateTimeKind.Local), "Nihil aut aut animi odit nobis expedita voluptatum molestiae est.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 13, 21, 30, 794, DateTimeKind.Local), "Eos praesentium minima sequi.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 55, 39, 779, DateTimeKind.Local), "Sit illo inventore beatae.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 1, 53, 17, 853, DateTimeKind.Local), "Et molestias quis neque quis ut rerum sint.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 12, 20, 12, 949, DateTimeKind.Local), "Omnis ut ipsam enim sed quae ad sit.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 21, 36, 7, 217, DateTimeKind.Local), "Qui cupiditate dolorem aliquid enim.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 17, 14, 36, DateTimeKind.Local), "Est perspiciatis omnis ut consequatur ut qui atque.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 10, 24, 38, 797, DateTimeKind.Local), "Ut eligendi deserunt molestias id.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 2, 36, 399, DateTimeKind.Local), "Sint aut aut eaque repellat officiis vel illo.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 8, 30, 1, 13, 15, 226, DateTimeKind.Local), "Consectetur architecto vel expedita vel possimus velit.", "f0a5b62a-da54-4712-9452-6440ef65945d" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 6, 7, 14, 616, DateTimeKind.Local), "Vitae soluta non eum.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 7, 29, 34, 528, DateTimeKind.Local), "Vel earum impedit et incidunt aut amet laudantium iusto ut.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 8, 30, 14, 41, 42, 17, DateTimeKind.Local), "Debitis molestiae non dolor.", "f851c462-8fe4-48e6-bb81-4d9cfb740521", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 30, 2, 22, 49, 985, DateTimeKind.Local), "Nulla enim repudiandae.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 30, 11, 43, 20, 406, DateTimeKind.Local), "Repellat qui vel dolores odit doloremque culpa placeat perferendis.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 30, 9, 43, 41, 380, DateTimeKind.Local), "Quos et voluptas quas beatae veritatis omnis sunt.", "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 19, 30, 35, 606, DateTimeKind.Local), "Et explicabo eaque porro reprehenderit molestiae iste sed consequatur.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 8, 29, 21, 7, 12, 67, DateTimeKind.Local), "Doloremque fugit assumenda sit possimus consequatur sit illum velit eum.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 8, 29, 20, 55, 59, 223, DateTimeKind.Local), "Pariatur itaque sunt quos dolore expedita.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 1, "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "45c5b61c-04f3-410b-a4bb-70c0b3d71dab" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "f851c462-8fe4-48e6-bb81-4d9cfb740521");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 3, "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 0, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 0, "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { false, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { false, false, false, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 0, "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 10, 12, 42, 808, DateTimeKind.Local), 11, "Asperiores doloribus at dolores quibusdam ipsam repudiandae illo.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 15, 58, 3, 482, DateTimeKind.Local), 19, "Ea quia quo magnam.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 7, 55, 46, 613, DateTimeKind.Local), "Reiciendis enim perferendis qui atque quod atque ut.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 14, 56, 13, 279, DateTimeKind.Local), 14, "Perspiciatis repudiandae sunt alias dolore.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 27, 9, 834, DateTimeKind.Local), 17, "Vel consectetur sit tempore cum vero corrupti.", "9022ac94-1cd8-46cc-a0a8-b24258800d30" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 40, 20, 724, DateTimeKind.Local), 12, "Explicabo magnam quo nobis reiciendis ut aut illo fugiat.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 17, 5, 15, 812, DateTimeKind.Local), 12, "Possimus expedita ducimus placeat impedit alias a.", "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 7, 42, 543, DateTimeKind.Local), 18, "Sed fugiat repudiandae consequatur.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 13, 16, 34, 10, DateTimeKind.Local), 19, "Et alias amet.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 7, 38, 13, 219, DateTimeKind.Local), 13, "Voluptatibus non autem.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-975-536-0633", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Perspiciatis veritatis ullam tenetur maxime voluptates nam molestias error non.", "Bernadine39@yahoo.com", "Company506", 69, "https://keara.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "474.995.9541", "f0a5b62a-da54-4712-9452-6440ef65945d", "Quae nostrum autem facilis earum saepe ipsam possimus ipsa. Officiis est officia nobis excepturi et. Ut sunt est pariatur eveniet. Beatae consequatur velit.", "Kathlyn78@hotmail.com", "Company741", 70, "http://enrique.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "1-218-909-9203", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Dicta voluptatem accusantium ratione nostrum ullam rerum provident ratione vel.", "Maryse_Weissnat25@yahoo.com", "Company631", "https://javonte.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "910-805-5830 x5678", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Iure quo enim sed et vel laudantium dolorem illum magni. Corrupti consequatur ea excepturi. Nisi molestias fugit consequatur.", "Moises94@hotmail.com", "Company995", 63, "https://maurice.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "493.650.0332 x93009", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Voluptatem veniam est nihil at neque. Quis sunt sed perferendis.", "Joelle.Schmeler@yahoo.com", "Company598", 65, "https://allene.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(867) 964-8993", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Provident iusto reprehenderit optio. Sapiente eveniet vitae. Molestiae perferendis qui doloremque quos perspiciatis.", "Kaci_Leannon81@gmail.com", "Company242", 61, "https://jensen.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(349) 931-0048 x7859", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", "Tenetur et tempore fugit eveniet tempore sapiente voluptate eos. Blanditiis neque nisi velit ratione molestias repellat modi eveniet atque. Dicta quos eveniet quos laudantium placeat.", "Melany19@hotmail.com", "Company590", 69, "https://kylie.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-903-268-7272 x830", "f851c462-8fe4-48e6-bb81-4d9cfb740521", "Mohammad68@hotmail.com", "Company608", 69, "https://ross.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(951) 543-5401", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Quisquam provident ea nam omnis dolorem minus error.", "Houston_Walsh25@yahoo.com", "Company376", 64, "https://marjorie.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "726.469.6688", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", "Aut quo reprehenderit nihil accusamus quos rerum.", "Evie48@gmail.com", "Company308", 69, "https://laurel.org" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 19, 47, 54, 169, DateTimeKind.Local), 42, "Expedita earum ratione.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 6, 24, 58, 385, DateTimeKind.Local), 41, "Repellat enim corporis qui error consectetur aut veritatis quos.", "8a65aa2c-1690-4985-b55a-52cad5015049" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 23, 51, 24, 388, DateTimeKind.Local), 50, "Itaque corrupti adipisci.", "f0a5b62a-da54-4712-9452-6440ef65945d" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 8, 46, 23, 207, DateTimeKind.Local), 42, "Dolor explicabo et repudiandae eum ratione veritatis.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 33, 59, 556, DateTimeKind.Local), 50, "Harum voluptate delectus velit sint ducimus quia ducimus.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 2, 25, 55, 312, DateTimeKind.Local), 43, "Et adipisci quod dolore vitae ipsum.", "7221ab73-0b1e-474a-912b-9aa7ace94fdf" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 3, 52, 42, 102, DateTimeKind.Local), 41, "Mollitia doloribus ut.", "f851c462-8fe4-48e6-bb81-4d9cfb740521" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 5, 38, 8, 581, DateTimeKind.Local), 46, "Magni in qui exercitationem et tempora.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 29, 22, 42, 18, 681, DateTimeKind.Local), 44, "Placeat qui quis nemo nisi nulla quo dolorem quisquam rerum.", "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 30, 18, 52, 29, 591, DateTimeKind.Local), 41, "Ut iure officia consequatur aut excepturi fugiat.", "cf19e2fd-f01a-4d18-bf12-fd1be10a4299" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "f851c462-8fe4-48e6-bb81-4d9cfb740521", 71 },
                    { "f0a5b62a-da54-4712-9452-6440ef65945d", 75 },
                    { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", 78 },
                    { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", 77 },
                    { "9022ac94-1cd8-46cc-a0a8-b24258800d30", 74 },
                    { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", 79 },
                    { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", 76 },
                    { "0cc0334a-a604-4fef-89b6-677392e535c1", 71 },
                    { "8a65aa2c-1690-4985-b55a-52cad5015049", 77 },
                    { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", 76 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0cc0334a-a604-4fef-89b6-677392e535c1", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "45c5b61c-04f3-410b-a4bb-70c0b3d71dab", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "7221ab73-0b1e-474a-912b-9aa7ace94fdf", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "8a65aa2c-1690-4985-b55a-52cad5015049", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "9022ac94-1cd8-46cc-a0a8-b24258800d30", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cf19e2fd-f01a-4d18-bf12-fd1be10a4299", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f0a5b62a-da54-4712-9452-6440ef65945d", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f851c462-8fe4-48e6-bb81-4d9cfb740521", 71 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0cc0334a-a604-4fef-89b6-677392e535c1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30a6915f-cdcd-4b0c-8e2a-c5dc980d73e2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "45c5b61c-04f3-410b-a4bb-70c0b3d71dab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7221ab73-0b1e-474a-912b-9aa7ace94fdf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8a65aa2c-1690-4985-b55a-52cad5015049");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9022ac94-1cd8-46cc-a0a8-b24258800d30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cf19e2fd-f01a-4d18-bf12-fd1be10a4299");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e70eb5f2-9f73-4b6f-a9d3-bdd0c9413788");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f0a5b62a-da54-4712-9452-6440ef65945d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f851c462-8fe4-48e6-bb81-4d9cfb740521");

            migrationBuilder.DropColumn(
                name: "AutoScale",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Gradient",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "IsLightTheme",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "IsShowSeriesOnHover",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "IsTooltipDisabled",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "LegendTitle",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "RangeFillOpacity",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "RoundDomains",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "SchemeType",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowGridLines",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowLegend",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowXAxis",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowXAxisLabel",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowYAxis",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "ShowYAxisLabel",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Sources",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "XAxisLabel",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "YAxisLabel",
                table: "Charts");

            migrationBuilder.AlterColumn<string>(
                name: "ShowCommon",
                table: "Charts",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Charts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "Common2", "Source2", 16, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", "Common3", "Source2", 61, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 96, "Common1", "Source2", 38, 2 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 98, "MostLoaded2", "Common1", "Source3", 79, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 92, "MostLoaded2", "Common1", "Source3", 91, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold" },
                values: new object[] { 97, "MostLoaded3", "Common2", "Source1", 99 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 91, "Common1", "Source1", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 94, "MostLoaded3", "Common2", "Source3", 70, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DashboardId", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 99, "Common3", "Source1", 92, 1 });

            migrationBuilder.UpdateData(
                table: "Charts",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[] { 95, "MostLoaded1", "Common3", "Source1", 65, 1 });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 11, 37, 38, 527, DateTimeKind.Local), 83, "Title116" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 31, 18, 371, DateTimeKind.Local), 85, "Title186" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 2, 5, 15, 337, DateTimeKind.Local), "Title644" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 29, 52, 955, DateTimeKind.Local), 86, "Title555" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 50, 791, DateTimeKind.Local), "Title29" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 1, 7, 847, DateTimeKind.Local), 86, "Title2" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 33, 40, 566, DateTimeKind.Local), 87, "Title446" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 12, 0, 45, 355, DateTimeKind.Local), 82, "Title98" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 54, 13, 125, DateTimeKind.Local), "Title611" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "InstanceId", "Title" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 46, 47, 434, DateTimeKind.Local), 88, "Title443" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "8b:73:29:8f:db:a4", 74, "Linux", "Instance830" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "c8:9e:b5:4e:36:5a", 74, "Windows", "Instance333" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "a4:4a:17:28:e7:6e", 78, "Windows", "Instance856" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "29:25:96:ce:e7:f9", 72, "Linux", "Instance504" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "02:69:f0:71:ad:46", 71, "Instance828" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "6c:36:05:00:c9:41", 74, "Instance660" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "dc:cd:d5:d2:4e:a3", 71, "Instance658" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "OrganizationId", "Platform", "Title" },
                values: new object[] { "39:c7:6d:95:d1:3a", 74, "Linux", "Instance402" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "58:15:e2:d5:16:f3", 72, "Instance483" });

            migrationBuilder.UpdateData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "OrganizationId", "Title" },
                values: new object[] { "9c:20:ed:67:68:35", 76, "Instance21" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme519" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Univers", "Theme419" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Univers", "Theme141" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Yellow", "Theme712" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Gray", "Helvetica", "Theme236" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "Gray", "Theme102" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Theme35");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "Yellow", "Helvetica", "Theme23" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BackgroundColor", "Name" },
                values: new object[] { "White", "Theme796" });

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BackgroundColor", "FontFamily", "Name" },
                values: new object[] { "White", "Univers", "Theme878" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", null, new DateTime(2018, 8, 27, 7, 45, 59, 423, DateTimeKind.Local), "Talon", "Einar11@gmail.com", null, "Lily", true, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/_scottburgess/128.jpg", 2 },
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", null, new DateTime(2018, 8, 27, 7, 34, 13, 456, DateTimeKind.Local), "Tiara", "Bret.Trantow46@hotmail.com", null, "Bessie", true, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/jarsen/128.jpg", 2 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", null, new DateTime(2018, 8, 27, 2, 37, 12, 614, DateTimeKind.Local), "Rowan", "Ellie.Kerluke@yahoo.com", null, "Cody", true, "Reinger", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cyril_gaillard/128.jpg", 1 },
                    { "97778277-833d-4bba-bc08-96216119b974", null, new DateTime(2018, 8, 26, 18, 16, 47, 561, DateTimeKind.Local), "Zula", "Jensen_Schmidt@hotmail.com", null, "Alexane", true, "Rosenbaum", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vicivadeline/128.jpg", 2 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", null, new DateTime(2018, 8, 27, 2, 59, 19, 669, DateTimeKind.Local), "Kian", "Mazie.Kassulke@yahoo.com", null, "Mikel", true, "Zulauf", null, "https://s3.amazonaws.com/uifaces/faces/twitter/danro/128.jpg", 1 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", null, new DateTime(2018, 8, 26, 19, 49, 5, 288, DateTimeKind.Local), "Kamren", "Christy_Abshire3@yahoo.com", null, "Baby", true, "Quitzon", null, "https://s3.amazonaws.com/uifaces/faces/twitter/a_brixen/128.jpg", 1 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", null, new DateTime(2018, 8, 27, 0, 34, 6, 531, DateTimeKind.Local), "Bret", "Gerry_Hermiston84@hotmail.com", null, "Sister", true, "Abernathy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ruzinav/128.jpg", 1 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", null, new DateTime(2018, 8, 26, 21, 43, 8, 409, DateTimeKind.Local), "Rachael", "Arvilla.Prosacco@hotmail.com", null, "Roxane", true, "Becker", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cbracco/128.jpg", 2 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", null, new DateTime(2018, 8, 27, 12, 7, 6, 946, DateTimeKind.Local), "Amelia", "Koby_Fritsch@yahoo.com", null, "Edyth", true, "Johnston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/petrangr/128.jpg", 2 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", null, new DateTime(2018, 8, 27, 10, 15, 54, 80, DateTimeKind.Local), "Kevin", "Arlo_Paucek@yahoo.com", null, "Marie", true, "Kunde", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mhesslow/128.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "aut" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "ratione" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "5504b109-e452-447b-97d1-a4812ac6e83e", "eaque" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "eligendi" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "necessitatibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "11d76c7c-c316-4694-80a0-8bc2810e1224", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "dolor" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d274933f-0df6-4ce1-860f-29ba557430f5", "fuga" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 12, 55, 32, 550, DateTimeKind.Local), "Non laudantium et ipsum labore.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 51, 3, 229, DateTimeKind.Local), "Rerum reiciendis veritatis ut eum itaque.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 8, 56, 8, 443, DateTimeKind.Local), "Inventore dolorum error vel.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 59, 31, 499, DateTimeKind.Local), "Voluptatem est ut sunt laborum.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 1, 12, 34, 73, DateTimeKind.Local), "Cupiditate et quasi.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 49, 9, 397, DateTimeKind.Local), "Culpa magnam voluptatem qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 55, 49, 922, DateTimeKind.Local), "Nam nostrum nam pariatur sit libero incidunt architecto maiores odio.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 46, 21, 73, DateTimeKind.Local), "Sit deserunt dignissimos similique aut et rem ipsa maxime molestiae.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 0, 52, 10, 701, DateTimeKind.Local), "Sit voluptatum consequatur velit libero voluptas assumenda qui.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 7, 32, 41, 421, DateTimeKind.Local), "Et deserunt voluptatem ad earum sed laudantium nostrum et tempore.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 8, 26, 14, 45, 18, 135, DateTimeKind.Local), "Sint doloremque vero et est.", "d7c68027-7a0a-4b78-aef9-02781e94182c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 27, 11, 36, 52, 472, DateTimeKind.Local), "Laborum debitis consequatur laborum autem ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 24, new DateTime(2018, 8, 26, 13, 32, 31, 447, DateTimeKind.Local), "Corrupti cupiditate ullam cumque modi est veniam sit.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 4, 16, 1, 104, DateTimeKind.Local), "Consectetur dignissimos quis sapiente ut consequatur repellendus temporibus.", "d274933f-0df6-4ce1-860f-29ba557430f5", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 8, 27, 10, 4, 45, 818, DateTimeKind.Local), "Incidunt voluptates quia quae est.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 21, new DateTime(2018, 8, 27, 6, 29, 49, 943, DateTimeKind.Local), "Natus neque omnis non fuga temporibus temporibus.", "d7c68027-7a0a-4b78-aef9-02781e94182c" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 22, new DateTime(2018, 8, 26, 18, 19, 57, 836, DateTimeKind.Local), "Aliquid laborum omnis est nisi maiores.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 19, 4, 26, 492, DateTimeKind.Local), "Vero autem quis eos voluptas ut vitae assumenda qui omnis.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 29, new DateTime(2018, 8, 27, 2, 59, 46, 17, DateTimeKind.Local), "Nesciunt repellat itaque.", "11d76c7c-c316-4694-80a0-8bc2810e1224", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 8, 27, 5, 39, 15, 577, DateTimeKind.Local), "Natus impedit ut hic non sed animi libero voluptas.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 4, "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 4, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 1, "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "48fd27a3-127f-4da8-a8e7-8f46e1d41bba");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 1, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 3, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsEmailable", "UserId" },
                values: new object[] { true, "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "UserId" },
                values: new object[] { true, true, true, "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 10, 12, 34, 962, DateTimeKind.Local), 18, "Error dicta cumque provident aliquam ea facilis nulla a.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 17, 4, 22, 374, DateTimeKind.Local), 12, "Saepe ut veritatis vero voluptas veritatis porro magnam dolorem.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 39, 19, 508, DateTimeKind.Local), "Quasi id assumenda.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 26, 37, 346, DateTimeKind.Local), 15, "Non pariatur repudiandae accusantium a optio.", "d274933f-0df6-4ce1-860f-29ba557430f5" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 27, 5, 60, DateTimeKind.Local), 18, "Facere ratione numquam.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 53, 44, 582, DateTimeKind.Local), 13, "Dolor consequatur nisi impedit culpa id enim.", "97778277-833d-4bba-bc08-96216119b974" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 17, 31, 229, DateTimeKind.Local), 11, "Voluptates architecto vel laudantium et.", "5504b109-e452-447b-97d1-a4812ac6e83e" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 57, 36, 277, DateTimeKind.Local), 13, "Aperiam ut ratione voluptas illum dolor nihil veritatis.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 16, 42, 0, 62, DateTimeKind.Local), 17, "Accusantium sequi ea.", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba" });

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "NotificationSettingId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 45, 40, 294, DateTimeKind.Local), 14, "Aut rerum temporibus qui dolores delectus maiores qui.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "886-531-6165", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "", "Frankie_Cronin@hotmail.com", "Company911", 67, "https://donavon.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "1-728-358-7494", "b09e040a-1384-4abb-bcb5-e32a9e812f40", "Repudiandae quibusdam voluptas ducimus et saepe expedita officiis. Rerum enim harum eveniet voluptas facilis iure sit id. Alias et culpa ut ipsum vero maxime qui pariatur. Dolorum praesentium nesciunt autem omnis qui quas corrupti aut.", "Elissa30@yahoo.com", "Company729", 64, "http://reuben.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "WebSite" },
                values: new object[] { "(392) 738-6543 x801", "d274933f-0df6-4ce1-860f-29ba557430f5", "Voluptas ut fugit eos. Non cum et fugiat laboriosam architecto eos minima modi placeat.", "Norwood_Toy@yahoo.com", "Company170", "https://cathryn.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "203.427.7650 x425", "d7c68027-7a0a-4b78-aef9-02781e94182c", "", "Jeramy39@gmail.com", "Company477", 70, "https://reba.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "(975) 209-1443 x7854", "11d76c7c-c316-4694-80a0-8bc2810e1224", "", "Frederick.Rohan@yahoo.com", "Company259", 67, "https://alfredo.biz" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "642-390-8585 x32466", "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", "Saepe nulla recusandae est voluptatem voluptatum ut. Facilis sit eius facere. Libero et qui corporis repudiandae incidunt necessitatibus.", "Erling13@yahoo.com", "Company50", 69, "https://hildegard.org" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "991-647-8137 x5828", "5504b109-e452-447b-97d1-a4812ac6e83e", "Sequi omnis in id. Doloremque eum voluptatem. Placeat voluptas fugiat.", "Gregorio_Corkery17@yahoo.com", "Company462", 65, "https://braxton.net" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "470.671.3040 x87959", "5504b109-e452-447b-97d1-a4812ac6e83e", "Vinnie22@gmail.com", "Company676", 61, "http://jedediah.info" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "929-277-5624 x6081", "3c66a652-9d95-41f8-b4e5-431382d4ac14", "Ea vitae nihil assumenda accusamus harum aut vel eaque. Possimus quidem facilis excepturi earum assumenda amet reprehenderit natus alias.", "Keagan50@gmail.com", "Company675", 68, "https://estevan.com" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ContactNumber", "CreatedByUserId", "Description", "Email", "Name", "ThemeId", "WebSite" },
                values: new object[] { "469-337-2948 x708", "c92ca16a-d03a-4f48-857d-4ded5fe4735e", "", "Justine.Gulgowski@yahoo.com", "Company227", 65, "http://darrion.info" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 27, 5, 941, DateTimeKind.Local), 48, "Qui laboriosam possimus illum pariatur sint commodi quibusdam et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 4, 50, 46, 373, DateTimeKind.Local), 50, "Sunt assumenda ducimus quidem natus provident incidunt similique.", "11d76c7c-c316-4694-80a0-8bc2810e1224" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 5, 50, 33, 228, DateTimeKind.Local), 49, "Aspernatur quia praesentium in.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 22, 54, 51, 426, DateTimeKind.Local), 41, "Error eum sit sunt tenetur unde.", "8486e755-b481-4eff-be21-9d95556987d1" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 54, 7, 142, DateTimeKind.Local), 48, "Aliquam et occaecati ut delectus optio nulla et.", "3c66a652-9d95-41f8-b4e5-431382d4ac14" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 36, 38, 14, DateTimeKind.Local), 50, "Voluptatem magni quo dolorum.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 9, 7, 49, 234, DateTimeKind.Local), 45, "Eius sit voluptas ut.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 27, 6, 44, 53, 482, DateTimeKind.Local), 48, "Nobis perferendis sapiente labore corrupti in a quam cum eos.", "c92ca16a-d03a-4f48-857d-4ded5fe4735e" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 15, 58, 34, 722, DateTimeKind.Local), 49, "Saepe magni qui quia error sed id sit quibusdam.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 8, 26, 18, 41, 33, 429, DateTimeKind.Local), 48, "Et distinctio magnam explicabo eius quaerat ut.", "b09e040a-1384-4abb-bcb5-e32a9e812f40" });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "d7c68027-7a0a-4b78-aef9-02781e94182c", 73 },
                    { "5504b109-e452-447b-97d1-a4812ac6e83e", 73 },
                    { "b09e040a-1384-4abb-bcb5-e32a9e812f40", 79 },
                    { "11d76c7c-c316-4694-80a0-8bc2810e1224", 79 },
                    { "d274933f-0df6-4ce1-860f-29ba557430f5", 79 },
                    { "97778277-833d-4bba-bc08-96216119b974", 71 },
                    { "48fd27a3-127f-4da8-a8e7-8f46e1d41bba", 76 },
                    { "3c66a652-9d95-41f8-b4e5-431382d4ac14", 76 },
                    { "c92ca16a-d03a-4f48-857d-4ded5fe4735e", 76 },
                    { "8486e755-b481-4eff-be21-9d95556987d1", 78 }
                });
        }
    }
}
