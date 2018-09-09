using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class ExtendedThemeEntity : Migration
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
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99);

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
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87);

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
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "104e789a-998a-478b-8240-46925d8eb289", 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "17303a7b-f861-4993-b650-202b9805a826", 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c317a221-686e-4211-8402-be5800f50db3", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72 });

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
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 98);

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
                keyValue: 89);

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
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "72c4d158-c9f9-4bb1-8279-86c127637cfa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c317a221-686e-4211-8402-be5800f50db3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e9afaf96-7110-42c2-abf6-2c900a02badb");

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
                keyValue: 90);

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
                keyValue: "77ac325e-dfe7-4b14-835d-b20f271c9150");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "cd91ae36-8dd0-484f-b488-0eec3b81dbe5");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "104e789a-998a-478b-8240-46925d8eb289");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17303a7b-f861-4993-b650-202b9805a826");

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
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "361b7f86-2f9f-4278-af42-a49bc5187139");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d65d8522-a0e6-41ed-af72-52b85ea1e523");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f07d7131-08d8-4381-96af-7fcd543c9f41");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "FontFamily",
                table: "Themes");

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Users",
                nullable: true);

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
                values: new object[] { 1, "#F8FAFC !global", "14px !global", "33px", false, "Default", "none", "none" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BodyColor", "ButtonFontSize", "ControlsHeight", "IsDeleted", "Name", "ThemePrimaryColor", "ThemeSecondaryColor" },
                values: new object[] { 2, "#F8FAFC !global", "16px !global", "38px", false, "Pink", "#ff5a5f", "#ffffff" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId", "ThemeId" },
                values: new object[,]
                {
                    { "ef405225-ec6a-41a1-bcda-793467d67aa6", null, new DateTime(2018, 9, 9, 19, 11, 5, 723, DateTimeKind.Local), "Marcelino", "Trey.Hegmann@gmail.com", null, "Loyal", true, false, "Stracke", null, "https://s3.amazonaws.com/uifaces/faces/twitter/vytautas_a/128.jpg", 2, 1 },
                    { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", null, new DateTime(2018, 9, 10, 0, 34, 45, 992, DateTimeKind.Local), "Brock", "Nicklaus.Lubowitz10@yahoo.com", null, "Jess", true, false, "Monahan", null, "https://s3.amazonaws.com/uifaces/faces/twitter/themadray/128.jpg", 2, 1 },
                    { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", null, new DateTime(2018, 9, 9, 11, 14, 32, 754, DateTimeKind.Local), "Patsy", "Dejah_Schroeder@hotmail.com", null, "Dion", true, false, "Wiza", null, "https://s3.amazonaws.com/uifaces/faces/twitter/leeiio/128.jpg", 1, 1 },
                    { "080a477e-414e-409c-8ae6-60935915d212", null, new DateTime(2018, 9, 9, 12, 36, 29, 445, DateTimeKind.Local), "Anibal", "Cristian.Fahey49@yahoo.com", null, "Arianna", true, false, "Jast", null, "https://s3.amazonaws.com/uifaces/faces/twitter/thekevinjones/128.jpg", 1, 1 },
                    { "82f7755a-c076-486d-9ec3-8c8482c04551", null, new DateTime(2018, 9, 9, 11, 51, 31, 810, DateTimeKind.Local), "Katarina", "Caesar.Hoeger@gmail.com", null, "Sadye", true, false, "Hermiston", null, "https://s3.amazonaws.com/uifaces/faces/twitter/agromov/128.jpg", 1, 1 },
                    { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", null, new DateTime(2018, 9, 9, 22, 28, 57, 291, DateTimeKind.Local), "Cheyenne", "Theodore72@hotmail.com", null, "Tristian", true, false, "Hessel", null, "https://s3.amazonaws.com/uifaces/faces/twitter/silvanmuhlemann/128.jpg", 1, 1 },
                    { "56c50529-8f61-4811-ad6b-014632e81bc3", null, new DateTime(2018, 9, 9, 23, 55, 20, 77, DateTimeKind.Local), "Robbie", "Mina18@gmail.com", null, "Sydnee", true, false, "Crooks", null, "https://s3.amazonaws.com/uifaces/faces/twitter/mandalareopens/128.jpg", 1, 2 },
                    { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", null, new DateTime(2018, 9, 9, 4, 23, 40, 199, DateTimeKind.Local), "Judson", "Amiya.Baumbach@gmail.com", null, "Adrienne", true, false, "Williamson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/alek_djuric/128.jpg", 2, 2 },
                    { "25163190-bc6d-4a00-9bef-9daa1f48c357", null, new DateTime(2018, 9, 9, 9, 33, 52, 683, DateTimeKind.Local), "Abigale", "Hal.Vandervort94@yahoo.com", null, "Willy", true, false, "Kihn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ostirbu/128.jpg", 1, 2 },
                    { "c93d5042-5283-4883-bc08-0b707273edbb", null, new DateTime(2018, 9, 10, 1, 19, 27, 352, DateTimeKind.Local), "Hal", "Adolphus.Kuhlman21@yahoo.com", null, "Alia", true, false, "Toy", null, "https://s3.amazonaws.com/uifaces/faces/twitter/cemshid/128.jpg", 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c93d5042-5283-4883-bc08-0b707273edbb", "temporibus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "ex" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "blanditiis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", "esse" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", "ducimus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", "voluptas" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", "velit" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "25163190-bc6d-4a00-9bef-9daa1f48c357", "eum" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "ef405225-ec6a-41a1-bcda-793467d67aa6", "nihil" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", "nisi" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 16, 1, 17, 90, DateTimeKind.Local), "Voluptate sequi laboriosam dolor quaerat.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 9, 41, 515, DateTimeKind.Local), "Fugiat vero non dolorem.", "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 6, 6, 27, 567, DateTimeKind.Local), "Impedit hic et eum eveniet sunt praesentium quia nihil.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 35, 48, 191, DateTimeKind.Local), "Molestiae enim minus voluptatem et blanditiis illum.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 44, 24, 387, DateTimeKind.Local), "Iure consequuntur error tempore quo dolore tenetur aut tenetur hic.", "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 35, 5, 31, DateTimeKind.Local), "Provident sed quod eos.", "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 19, 48, 19, 429, DateTimeKind.Local), "Repudiandae non tenetur accusamus et ut aut sed velit impedit.", "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 23, 53, 951, DateTimeKind.Local), "Porro error itaque ut modi aliquam.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 42, 30, 157, DateTimeKind.Local), "Eveniet ex accusamus vel aut.", "82f7755a-c076-486d-9ec3-8c8482c04551" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 25, 17, 968, DateTimeKind.Local), "Voluptatem sunt ipsum.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 11, 8, 54, 341, DateTimeKind.Local), "Eos voluptas corrupti ea quidem.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 8, 25, 19, 392, DateTimeKind.Local), "Quo id dolores ut voluptatibus a vel.", "25163190-bc6d-4a00-9bef-9daa1f48c357", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 28, new DateTime(2018, 9, 9, 10, 51, 1, 556, DateTimeKind.Local), "Nihil aut ducimus aperiam qui ut doloribus nihil tempore.", "080a477e-414e-409c-8ae6-60935915d212", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 25, new DateTime(2018, 9, 9, 11, 45, 39, 693, DateTimeKind.Local), "Et veritatis qui aut omnis non officia.", "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 1, 33, 335, DateTimeKind.Local), "In deserunt voluptas dolores officia et dolor ullam dolorum id.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 10, 0, 17, 45, 692, DateTimeKind.Local), "Iusto hic eos dicta placeat laborum.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 10, 0, 8, 36, 460, DateTimeKind.Local), "Qui distinctio magnam tempora ut eaque sed qui fugiat.", "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 26, new DateTime(2018, 9, 9, 22, 46, 57, 563, DateTimeKind.Local), "Ut aliquid sapiente voluptatem ratione eius et quis.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 24, new DateTime(2018, 9, 9, 7, 0, 56, 632, DateTimeKind.Local), "Dolorem iure alias quas consequatur.", "56c50529-8f61-4811-ad6b-014632e81bc3", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 2, 59, 136, DateTimeKind.Local), "Qui laboriosam debitis.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 2, "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { true, 1, "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 0, "25163190-bc6d-4a00-9bef-9daa1f48c357" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "080a477e-414e-409c-8ae6-60935915d212");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 4, "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, false, 0, "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { false, false, "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, false, 1, "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { false, true, 2, "080a477e-414e-409c-8ae6-60935915d212" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 0, "c93d5042-5283-4883-bc08-0b707273edbb" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 107, new DateTime(2018, 9, 9, 17, 20, 49, 231, DateTimeKind.Local), false, 11, "Quasi laboriosam consequatur explicabo beatae dolores dignissimos sunt.", "080a477e-414e-409c-8ae6-60935915d212", false },
                    { 110, new DateTime(2018, 9, 9, 5, 17, 34, 98, DateTimeKind.Local), false, 19, "Voluptate labore nihil dicta totam fugit est quia molestiae et.", "c93d5042-5283-4883-bc08-0b707273edbb", false },
                    { 105, new DateTime(2018, 9, 9, 9, 58, 11, 317, DateTimeKind.Local), false, 19, "Non modi eius suscipit repellendus culpa repudiandae.", "ef405225-ec6a-41a1-bcda-793467d67aa6", false },
                    { 101, new DateTime(2018, 9, 10, 0, 34, 5, 12, DateTimeKind.Local), false, 11, "Aut recusandae distinctio dolores dolorem est consectetur delectus vel.", "56c50529-8f61-4811-ad6b-014632e81bc3", false },
                    { 106, new DateTime(2018, 9, 9, 14, 26, 3, 428, DateTimeKind.Local), false, 15, "Et incidunt a est autem quia.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a", false },
                    { 103, new DateTime(2018, 9, 9, 2, 49, 21, 140, DateTimeKind.Local), false, 11, "Quas saepe et facilis excepturi vero hic accusantium cupiditate.", "25163190-bc6d-4a00-9bef-9daa1f48c357", false },
                    { 108, new DateTime(2018, 9, 9, 13, 4, 23, 23, DateTimeKind.Local), false, 17, "Ut sit aut corporis et autem molestiae repellat earum qui.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a", false },
                    { 102, new DateTime(2018, 9, 9, 18, 38, 25, 28, DateTimeKind.Local), false, 13, "Porro ut adipisci beatae velit ipsam corporis et temporibus porro.", "82f7755a-c076-486d-9ec3-8c8482c04551", false },
                    { 109, new DateTime(2018, 9, 9, 23, 38, 27, 204, DateTimeKind.Local), false, 19, "Temporibus est omnis corporis id ut.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b", false },
                    { 104, new DateTime(2018, 9, 9, 20, 47, 23, 394, DateTimeKind.Local), false, 16, "Harum quibusdam ducimus et incidunt harum placeat velit non excepturi.", "080a477e-414e-409c-8ae6-60935915d212", false }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 69, "820-782-2216 x9978", "25163190-bc6d-4a00-9bef-9daa1f48c357", "", "Karianne94@yahoo.com", null, true, false, "Company597", 1, "https://sandrine.com" },
                    { 62, "320-369-8202 x276", "25163190-bc6d-4a00-9bef-9daa1f48c357", "Sint voluptas placeat qui blanditiis incidunt. Optio ad necessitatibus quas. Dolorum provident in rerum excepturi vitae fuga veritatis enim.", "Amber96@gmail.com", null, true, false, "Company295", 2, "https://mackenzie.name" },
                    { 70, "933-272-7844 x0843", "312c4307-f729-4d41-888b-e8e4a5b3cd9a", "Dolorum aut illum nihil nihil. Itaque laudantium aliquam voluptatem non consequatur magnam maxime.", "Maurice.Kertzmann@hotmail.com", null, true, false, "Company392", 2, "https://annette.org" },
                    { 61, "(251) 958-8736 x160", "3a411cc8-95ea-4496-8528-a6ea6e6d596b", "Nulla quo minus qui velit eius.", "Marie_Weimann60@yahoo.com", null, true, false, "Company847", 1, "http://alice.name" },
                    { 65, "752.672.7201", "82f7755a-c076-486d-9ec3-8c8482c04551", "", "Moshe.Braun@hotmail.com", null, true, false, "Company638", 2, "https://gustave.biz" },
                    { 67, "600.727.1898 x8739", "56c50529-8f61-4811-ad6b-014632e81bc3", "Consequatur et perspiciatis similique voluptas sit.", "Gunnar.Klocko@hotmail.com", null, true, false, "Company908", 1, "http://ottilie.info" },
                    { 66, "878.966.8501 x81429", "56c50529-8f61-4811-ad6b-014632e81bc3", "Necessitatibus possimus quos beatae. Dolorem deleniti earum aliquid magnam odio et laudantium dolorum sit.", "Axel_Gleichner91@hotmail.com", null, true, false, "Company566", 1, "http://kayli.info" },
                    { 63, "491-301-9491 x11276", "56c50529-8f61-4811-ad6b-014632e81bc3", "Facilis perferendis et aspernatur voluptas a nobis et.", "Tom8@gmail.com", null, true, false, "Company63", 1, "http://isabella.info" },
                    { 68, "742.364.2240", "82f7755a-c076-486d-9ec3-8c8482c04551", "Deleniti velit architecto ut dolorem labore vel molestiae. Unde est quam illum veritatis impedit occaecati.", "Hobart84@hotmail.com", null, true, false, "Company597", 1, "http://pansy.net" },
                    { 64, "1-908-566-8501", "c93d5042-5283-4883-bc08-0b707273edbb", "Reprehenderit voluptas et qui quo delectus labore magnam in.", "Gustave_Beier@gmail.com", null, true, false, "Company360", 2, "http://connor.com" }
                });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 39, 25, 392, DateTimeKind.Local), 47, "Ipsum optio assumenda itaque ratione quam.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 8, 5, 399, DateTimeKind.Local), 50, "Quasi ducimus delectus.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 6, 47, 308, DateTimeKind.Local), 48, "Id voluptas animi aperiam animi repellat cupiditate quibusdam ut facere.", "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 18, 51, 46, 694, DateTimeKind.Local), 48, "Eos facilis aut assumenda similique blanditiis.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 12, 25, 5, 598, DateTimeKind.Local), 46, "Et nobis placeat enim et incidunt amet.", "312c4307-f729-4d41-888b-e8e4a5b3cd9a" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 23, 9, 57, 915, DateTimeKind.Local), "Sunt rem quam similique cumque et.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 5, 55, 50, 732, DateTimeKind.Local), 50, "At delectus porro recusandae aut.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 20, 29, 35, 933, DateTimeKind.Local), 42, "Tempore libero delectus doloribus eum sint.", "15b2e656-c73d-4f52-9de5-4da521a7c5f7" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 21, 42, 18, 675, DateTimeKind.Local), "Similique omnis doloribus consequuntur aut similique ipsum est.", "3a411cc8-95ea-4496-8528-a6ea6e6d596b" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 9, 9, 16, 10, 129, DateTimeKind.Local), 44, "Dolorem magni quaerat quibusdam.", "ef405225-ec6a-41a1-bcda-793467d67aa6" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "Title" },
                values: new object[,]
                {
                    { 77, "bb:a2:63:9f:18:47", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Windows", "Instance849" },
                    { 73, "43:17:d9:1d:67:5d", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 64, "Windows", "Instance232" },
                    { 80, "75:85:e8:33:de:85", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 62, "Windows", "Instance955" },
                    { 76, "d4:7b:12:65:0c:11", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 66, "Linux", "Instance180" },
                    { 72, "cb:4a:62:d9:11:e1", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 66, "Windows", "Instance604" },
                    { 71, "28:5e:9b:40:7d:1a", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 63, "Windows", "Instance603" },
                    { 75, "28:8a:54:15:75:07", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 66, "Linux", "Instance326" },
                    { 74, "48:84:df:00:6d:fa", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 61, "Linux", "Instance703" },
                    { 78, "de:d5:ec:a1:0c:b8", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 68, "Windows", "Instance420" },
                    { 79, "d1:d9:72:d6:26:cd", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 65, "Linux", "Instance657" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "82f7755a-c076-486d-9ec3-8c8482c04551", 68, 1 },
                    { "080a477e-414e-409c-8ae6-60935915d212", 64, 1 },
                    { "56c50529-8f61-4811-ad6b-014632e81bc3", 66, 1 },
                    { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", 67, 1 },
                    { "25163190-bc6d-4a00-9bef-9daa1f48c357", 67, 1 },
                    { "c93d5042-5283-4883-bc08-0b707273edbb", 65, 1 },
                    { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", 69, 1 },
                    { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", 64, 1 },
                    { "ef405225-ec6a-41a1-bcda-793467d67aa6", 61, 1 },
                    { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", 64, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 81, new DateTime(2018, 9, 9, 22, 6, 57, 584, DateTimeKind.Local), 77, false, "Title709" },
                    { 87, new DateTime(2018, 9, 10, 1, 2, 49, 366, DateTimeKind.Local), 77, false, "Title941" },
                    { 84, new DateTime(2018, 9, 9, 8, 17, 19, 813, DateTimeKind.Local), 79, false, "Title328" },
                    { 86, new DateTime(2018, 9, 9, 19, 25, 23, 612, DateTimeKind.Local), 79, false, "Title550" },
                    { 88, new DateTime(2018, 9, 9, 9, 9, 8, 451, DateTimeKind.Local), 78, false, "Title348" },
                    { 89, new DateTime(2018, 9, 10, 1, 17, 52, 944, DateTimeKind.Local), 78, false, "Title526" },
                    { 90, new DateTime(2018, 9, 9, 10, 52, 20, 762, DateTimeKind.Local), 78, false, "Title474" },
                    { 83, new DateTime(2018, 9, 9, 15, 50, 2, 286, DateTimeKind.Local), 74, false, "Title998" },
                    { 85, new DateTime(2018, 9, 9, 5, 18, 40, 524, DateTimeKind.Local), 72, false, "Title477" },
                    { 82, new DateTime(2018, 9, 10, 0, 18, 55, 587, DateTimeKind.Local), 80, false, "Title168" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 100, true, 81, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 32, "", 3, "X Label", "Y Label" },
                    { 93, true, 87, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 70, "", 1, "X Label", "Y Label" },
                    { 97, true, 87, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 84, "", 3, "X Label", "Y Label" },
                    { 94, true, 84, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 99, "", 2, "X Label", "Y Label" },
                    { 95, true, 84, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 70, "", 2, "X Label", "Y Label" },
                    { 91, true, 89, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 36, "", 0, "X Label", "Y Label" },
                    { 98, true, 90, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 26, "", 1, "X Label", "Y Label" },
                    { 96, true, 85, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 3, "", 2, "X Label", "Y Label" },
                    { 92, true, 82, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 100, "", 2, "X Label", "Y Label" },
                    { 99, true, 82, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 66, "", 3, "X Label", "Y Label" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ThemeId",
                table: "Users",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Themes_ThemeId",
                table: "Users",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Themes_ThemeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ThemeId",
                table: "Users");

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
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 71);

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
                keyValue: 76);

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
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "080a477e-414e-409c-8ae6-60935915d212", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "15b2e656-c73d-4f52-9de5-4da521a7c5f7", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "25163190-bc6d-4a00-9bef-9daa1f48c357", 67 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "312c4307-f729-4d41-888b-e8e4a5b3cd9a", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "3a411cc8-95ea-4496-8528-a6ea6e6d596b", 64 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "56c50529-8f61-4811-ad6b-014632e81bc3", 66 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "82f7755a-c076-486d-9ec3-8c8482c04551", 68 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad", 69 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c93d5042-5283-4883-bc08-0b707273edbb", 65 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "ef405225-ec6a-41a1-bcda-793467d67aa6", 61 });

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
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "080a477e-414e-409c-8ae6-60935915d212");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15b2e656-c73d-4f52-9de5-4da521a7c5f7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "312c4307-f729-4d41-888b-e8e4a5b3cd9a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ac52a4d8-01e7-4d0b-8537-19fe1b95b8ad");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ef405225-ec6a-41a1-bcda-793467d67aa6");

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 72);

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
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c93d5042-5283-4883-bc08-0b707273edbb");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 65);

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
                keyValue: "3a411cc8-95ea-4496-8528-a6ea6e6d596b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25163190-bc6d-4a00-9bef-9daa1f48c357");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "56c50529-8f61-4811-ad6b-014632e81bc3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "82f7755a-c076-486d-9ec3-8c8482c04551");

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Users");

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
                    { 61, "White", "Helvetica", false, "Theme109" },
                    { 69, "White", "Frutiger", false, "Theme717" },
                    { 68, "Yellow", "Frutiger", false, "Theme67" },
                    { 67, "White", "Trade", false, "Theme837" },
                    { 66, "Yellow", "Trade", false, "Theme749" },
                    { 70, "White", "Frutiger", false, "Theme335" },
                    { 64, "White", "Univers", false, "Theme427" },
                    { 63, "Yellow", "Univers", false, "Theme491" },
                    { 62, "White", "Helvetica", false, "Theme432" },
                    { 65, "Yellow", "Frutiger", false, "Theme647" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "DisplayName", "Email", "EmailForNotifications", "FirstName", "IsActive", "IsDeleted", "LastName", "LastPickedOrganizationId", "PhotoURL", "RoleId" },
                values: new object[,]
                {
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", null, new DateTime(2018, 9, 8, 12, 23, 25, 863, DateTimeKind.Local), "Karen", "Carlo_Wunsch@hotmail.com", null, "Pat", true, false, "Larson", null, "https://s3.amazonaws.com/uifaces/faces/twitter/dactrtr/128.jpg", 1 },
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", null, new DateTime(2018, 9, 8, 6, 59, 40, 90, DateTimeKind.Local), "Alfredo", "Raina_Bergnaum33@yahoo.com", null, "Jody", true, false, "Greenholt", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ivanfilipovbg/128.jpg", 2 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", null, new DateTime(2018, 9, 7, 21, 17, 52, 743, DateTimeKind.Local), "Bruce", "Delpha.Donnelly50@yahoo.com", null, "Murphy", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/ryankirkman/128.jpg", 2 },
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", null, new DateTime(2018, 9, 7, 21, 19, 14, 495, DateTimeKind.Local), "Kaci", "Xzavier.Jenkins@hotmail.com", null, "Elmer", true, false, "Hahn", null, "https://s3.amazonaws.com/uifaces/faces/twitter/bertboerland/128.jpg", 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", null, new DateTime(2018, 9, 8, 4, 24, 34, 420, DateTimeKind.Local), "Rebecca", "Amari.Kiehn48@gmail.com", null, "Stone", true, false, "Satterfield", null, "https://s3.amazonaws.com/uifaces/faces/twitter/juaumlol/128.jpg", 2 },
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", null, new DateTime(2018, 9, 8, 1, 2, 26, 556, DateTimeKind.Local), "Peggie", "Oma_Waters@gmail.com", null, "Brooks", true, false, "Kshlerin", null, "https://s3.amazonaws.com/uifaces/faces/twitter/kylefrost/128.jpg", 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", null, new DateTime(2018, 9, 8, 14, 26, 21, 99, DateTimeKind.Local), "Juston", "Troy.VonRueden@hotmail.com", null, "Doug", true, false, "Kunze", null, "https://s3.amazonaws.com/uifaces/faces/twitter/d_kobelyatsky/128.jpg", 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", null, new DateTime(2018, 9, 7, 17, 39, 36, 959, DateTimeKind.Local), "Hipolito", "Stephanie_Romaguera24@hotmail.com", null, "David", true, false, "Roob", null, "https://s3.amazonaws.com/uifaces/faces/twitter/calebogden/128.jpg", 2 },
                    { "c317a221-686e-4211-8402-be5800f50db3", null, new DateTime(2018, 9, 8, 1, 20, 52, 332, DateTimeKind.Local), "Clementina", "Savion.Frami56@yahoo.com", null, "Giuseppe", true, false, "Jones", null, "https://s3.amazonaws.com/uifaces/faces/twitter/faisalabid/128.jpg", 2 },
                    { "17303a7b-f861-4993-b650-202b9805a826", null, new DateTime(2018, 9, 8, 5, 6, 39, 950, DateTimeKind.Local), "Sabrina", "Nona32@gmail.com", null, "Alice", true, false, "Murazik", null, "https://s3.amazonaws.com/uifaces/faces/twitter/AM_Kn2/128.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "et" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "f07d7131-08d8-4381-96af-7fcd543c9f41", "accusamus" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "sed" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "104e789a-998a-478b-8240-46925d8eb289", "ullam" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "quo" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "c317a221-686e-4211-8402-be5800f50db3", "nobis" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "361b7f86-2f9f-4278-af42-a49bc5187139", "laudantium" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "e9afaf96-7110-42c2-abf6-2c900a02badb", "eveniet" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "d65d8522-a0e6-41ed-af72-52b85ea1e523", "maxime" });

            migrationBuilder.UpdateData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedById", "Name" },
                values: new object[] { "72c4d158-c9f9-4bb1-8279-86c127637cfa", "alias" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 19, 46, 29, 445, DateTimeKind.Local), "Nulla et facere architecto non placeat voluptatem tenetur qui.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 47, 10, 241, DateTimeKind.Local), "Maxime cupiditate tempora numquam veritatis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 36, 9, 856, DateTimeKind.Local), "Nam facere corporis.", "c317a221-686e-4211-8402-be5800f50db3" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 24, 59, 250, DateTimeKind.Local), "Dicta earum in.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 20, 7, 14, 365, DateTimeKind.Local), "Dolorum eveniet consequatur ipsum dolor.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 6, 28, 44, 938, DateTimeKind.Local), "Velit dolorem error qui illum eum.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 3, 20, 589, DateTimeKind.Local), "Quaerat architecto sed possimus non dolor explicabo animi autem.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 18, 39, 445, DateTimeKind.Local), "Beatae autem numquam qui eos quo pariatur sint.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 16, 52, 21, 34, DateTimeKind.Local), "Praesentium laboriosam qui voluptas amet.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 1, 2, 39, 319, DateTimeKind.Local), "Distinctio occaecati dicta voluptatem at dicta dolores eligendi porro repudiandae.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 27, new DateTime(2018, 9, 8, 2, 22, 30, 156, DateTimeKind.Local), "Aut et culpa.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 7, 16, 11, 49, 696, DateTimeKind.Local), "Doloribus ad similique qui soluta.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 25, new DateTime(2018, 9, 8, 5, 41, 14, 398, DateTimeKind.Local), "Sed voluptas quam possimus minus vitae molestias.", "17303a7b-f861-4993-b650-202b9805a826", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 29, new DateTime(2018, 9, 8, 8, 9, 8, 710, DateTimeKind.Local), "Distinctio facilis ea tempore fugit neque quis voluptas accusantium neque.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 5, 20, 28, 618, DateTimeKind.Local), "Ut repellendus sint.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 20, 11, 194, DateTimeKind.Local), "Eum dolorum ab quia et adipisci.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 30, new DateTime(2018, 9, 8, 11, 11, 30, 395, DateTimeKind.Local), "Et molestiae quae consequatur quia omnis sit voluptates atque autem.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId" },
                values: new object[] { 28, new DateTime(2018, 9, 7, 14, 59, 38, 323, DateTimeKind.Local), "Et dignissimos praesentium corrupti officia et sunt dolor voluptatem illo.", "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[] { 23, new DateTime(2018, 9, 8, 10, 18, 36, 796, DateTimeKind.Local), "At architecto non pariatur qui amet modi omnis.", "72c4d158-c9f9-4bb1-8279-86c127637cfa", false });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 19, 54, 9, 787, DateTimeKind.Local), "Sunt vitae voluptatum.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 3, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsEmailable", "Type", "UserId" },
                values: new object[] { false, 4, "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { true, 1, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "77ac325e-dfe7-4b14-835d-b20f271c9150");

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { 3, "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, true, 1, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsDisable", "IsEmailable", "UserId" },
                values: new object[] { true, true, "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, true, 3, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsDisable", "IsMute", "Type", "UserId" },
                values: new object[] { true, false, 4, "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsDisable", "Type", "UserId" },
                values: new object[] { false, 3, "104e789a-998a-478b-8240-46925d8eb289" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "NotificationSettingId", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 117, new DateTime(2018, 9, 8, 2, 26, 21, 475, DateTimeKind.Local), false, 18, "Qui blanditiis voluptatem at.", "c317a221-686e-4211-8402-be5800f50db3", false },
                    { 118, new DateTime(2018, 9, 8, 12, 52, 27, 167, DateTimeKind.Local), false, 19, "Ex aut delectus.", "c317a221-686e-4211-8402-be5800f50db3", false },
                    { 120, new DateTime(2018, 9, 8, 6, 24, 32, 255, DateTimeKind.Local), false, 19, "Et quisquam adipisci doloremque ducimus ut magni ut laboriosam.", "c317a221-686e-4211-8402-be5800f50db3", false },
                    { 113, new DateTime(2018, 9, 7, 22, 1, 43, 796, DateTimeKind.Local), false, 12, "Eos non atque recusandae accusantium sed sed.", "f07d7131-08d8-4381-96af-7fcd543c9f41", false },
                    { 112, new DateTime(2018, 9, 7, 15, 45, 15, 614, DateTimeKind.Local), false, 12, "Doloribus optio consequatur saepe quae a sapiente optio.", "f07d7131-08d8-4381-96af-7fcd543c9f41", false },
                    { 116, new DateTime(2018, 9, 8, 8, 18, 9, 328, DateTimeKind.Local), false, 19, "Dolores magni minus sed aut.", "104e789a-998a-478b-8240-46925d8eb289", false },
                    { 119, new DateTime(2018, 9, 7, 22, 9, 37, 150, DateTimeKind.Local), false, 14, "Et suscipit et qui ea nisi ut debitis vitae eos.", "104e789a-998a-478b-8240-46925d8eb289", false },
                    { 111, new DateTime(2018, 9, 7, 20, 17, 3, 643, DateTimeKind.Local), false, 12, "Laboriosam et placeat voluptatum debitis.", "17303a7b-f861-4993-b650-202b9805a826", false },
                    { 115, new DateTime(2018, 9, 8, 8, 14, 35, 670, DateTimeKind.Local), false, 14, "Consequatur officia ut consectetur vero atque fuga adipisci.", "e9afaf96-7110-42c2-abf6-2c900a02badb", false },
                    { 114, new DateTime(2018, 9, 7, 14, 58, 38, 961, DateTimeKind.Local), false, 19, "Expedita aut eaque animi.", "c317a221-686e-4211-8402-be5800f50db3", false }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "ImageURL", "IsActive", "IsDeleted", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 78, "448-875-3606 x3885", "17303a7b-f861-4993-b650-202b9805a826", "Autem in ab. Molestias est officia quo.", "Dante_Purdy45@hotmail.com", null, true, false, "Company15", 64, "http://cassie.org" },
                    { 77, "1-436-414-0109 x2636", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Repudiandae porro id enim. Ut cum voluptatibus inventore sit eos libero laboriosam sed. Cumque animi doloribus odit porro eaque.", "Renee.Schmidt53@yahoo.com", null, true, false, "Company696", 61, "https://gisselle.net" },
                    { 72, "680-498-9816 x664", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", "", "Garnet68@hotmail.com", null, true, false, "Company48", 69, "https://mckayla.info" },
                    { 71, "(323) 396-2347", "104e789a-998a-478b-8240-46925d8eb289", "Rerum eius corporis. Similique quas quo eos autem nostrum adipisci quis.", "Rupert57@gmail.com", null, true, false, "Company325", 70, "http://kathryn.info" },
                    { 75, "923-623-5034", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Iusto laudantium nam eius facere delectus odit mollitia iste rerum. Eligendi vel ut aut quas distinctio expedita quasi est error. Sed sequi laborum nam id.", "Ike70@yahoo.com", null, true, false, "Company397", 64, "https://jaunita.net" },
                    { 74, "924-373-3710 x372", "f07d7131-08d8-4381-96af-7fcd543c9f41", "Quibusdam quo veniam voluptas sit aut natus autem magni minus. Voluptates natus occaecati nostrum praesentium sunt nihil maiores esse veniam. Commodi aut consequuntur consequatur ut explicabo impedit voluptates voluptatibus. Aut delectus delectus.", "Dorris_Morissette12@hotmail.com", null, true, false, "Company720", 66, "https://carolina.org" },
                    { 76, "460.366.5740 x3649", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Voluptatem molestias est.", "Noble97@gmail.com", null, true, false, "Company964", 63, "http://terrill.org" },
                    { 79, "316.470.3214", "77ac325e-dfe7-4b14-835d-b20f271c9150", "", "Morgan.Rodriguez@gmail.com", null, true, false, "Company970", 70, "https://brionna.org" },
                    { 80, "428-684-2468 x2295", "d65d8522-a0e6-41ed-af72-52b85ea1e523", "Quia blanditiis voluptas rerum quo libero ratione. Quia iure quo totam quas porro qui ut. Quos quia modi est et nihil optio quia cumque cumque.", "Mekhi.Bruen@gmail.com", null, true, false, "Company77", 69, "https://sigmund.info" },
                    { 73, "(385) 482-0280 x4425", "361b7f86-2f9f-4278-af42-a49bc5187139", "Velit enim magnam consequatur ea. Iusto quasi aut cupiditate sint qui.", "Walter.Von59@hotmail.com", null, true, false, "Company246", 63, "http://lucio.com" }
                });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 29, 31, 950, DateTimeKind.Local), 45, "Cum omnis sed ducimus aliquid consequatur.", "72c4d158-c9f9-4bb1-8279-86c127637cfa" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 22, 53, 14, 827, DateTimeKind.Local), 42, "Quibusdam modi temporibus.", "f07d7131-08d8-4381-96af-7fcd543c9f41" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 11, 17, 25, 563, DateTimeKind.Local), 41, "Et eligendi consequatur iure et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 2, 57, 49, 818, DateTimeKind.Local), 49, "Et rerum voluptatem magni id.", "361b7f86-2f9f-4278-af42-a49bc5187139" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 7, 42, 29, 907, DateTimeKind.Local), 41, "Natus cumque reprehenderit quo aspernatur necessitatibus vel dolorem totam.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 13, 6, 29, 70, DateTimeKind.Local), "Vitae culpa vel consequatur debitis asperiores.", "e9afaf96-7110-42c2-abf6-2c900a02badb" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 12, 31, 23, 226, DateTimeKind.Local), 45, "Reprehenderit maiores enim aperiam.", "77ac325e-dfe7-4b14-835d-b20f271c9150" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 7, 15, 57, 42, 951, DateTimeKind.Local), 46, "Doloribus tenetur officiis vero velit.", "d65d8522-a0e6-41ed-af72-52b85ea1e523" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 0, 21, 40, 347, DateTimeKind.Local), "In optio cum cumque sapiente exercitationem architecto natus dignissimos facere.", "cd91ae36-8dd0-484f-b488-0eec3b81dbe5" });

            migrationBuilder.UpdateData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[] { new DateTime(2018, 9, 8, 14, 17, 51, 573, DateTimeKind.Local), 42, "Ut et sunt alias pariatur temporibus vero est et.", "17303a7b-f861-4993-b650-202b9805a826" });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "GuidId", "IsActive", "IsDeleted", "OrganizationId", "Platform", "Title" },
                values: new object[,]
                {
                    { 82, "ad:72:b0:c0:ed:f3", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 75, "Linux", "Instance400" },
                    { 89, "22:38:5e:38:5f:e3", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 80, "Linux", "Instance883" },
                    { 90, "40:70:f5:50:72:0c", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 80, "Windows", "Instance619" },
                    { 86, "ae:e8:fc:bd:ef:db", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Windows", "Instance770" },
                    { 87, "e3:a6:b3:57:d5:c9", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 73, "Windows", "Instance230" },
                    { 84, "cb:e4:34:8e:18:77", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Windows", "Instance971" },
                    { 81, "5f:09:fd:43:0c:90", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 78, "Windows", "Instance182" },
                    { 85, "b3:a6:d2:25:d2:f9", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 71, "Windows", "Instance218" },
                    { 83, "39:84:d2:b4:08:24", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Linux", "Instance328" },
                    { 88, "39:37:bb:fe:be:93", new Guid("00000000-0000-0000-0000-000000000000"), true, false, 77, "Windows", "Instance658" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId", "OrganizationRoleId" },
                values: new object[,]
                {
                    { "f07d7131-08d8-4381-96af-7fcd543c9f41", 72, 1 },
                    { "d65d8522-a0e6-41ed-af72-52b85ea1e523", 72, 1 },
                    { "17303a7b-f861-4993-b650-202b9805a826", 76, 1 },
                    { "361b7f86-2f9f-4278-af42-a49bc5187139", 78, 1 },
                    { "77ac325e-dfe7-4b14-835d-b20f271c9150", 74, 1 },
                    { "72c4d158-c9f9-4bb1-8279-86c127637cfa", 79, 1 },
                    { "e9afaf96-7110-42c2-abf6-2c900a02badb", 73, 1 },
                    { "cd91ae36-8dd0-484f-b488-0eec3b81dbe5", 73, 1 },
                    { "104e789a-998a-478b-8240-46925d8eb289", 77, 1 },
                    { "c317a221-686e-4211-8402-be5800f50db3", 78, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 96, new DateTime(2018, 9, 7, 16, 1, 11, 279, DateTimeKind.Local), 89, false, "Title477" },
                    { 93, new DateTime(2018, 9, 7, 14, 53, 23, 647, DateTimeKind.Local), 90, false, "Title467" },
                    { 92, new DateTime(2018, 9, 8, 7, 15, 55, 197, DateTimeKind.Local), 86, false, "Title876" },
                    { 98, new DateTime(2018, 9, 8, 4, 39, 20, 468, DateTimeKind.Local), 86, false, "Title785" },
                    { 95, new DateTime(2018, 9, 7, 22, 40, 58, 709, DateTimeKind.Local), 83, false, "Title173" },
                    { 97, new DateTime(2018, 9, 8, 4, 37, 43, 331, DateTimeKind.Local), 83, false, "Title774" },
                    { 91, new DateTime(2018, 9, 8, 13, 53, 16, 363, DateTimeKind.Local), 88, false, "Title478" },
                    { 94, new DateTime(2018, 9, 8, 1, 40, 37, 983, DateTimeKind.Local), 85, false, "Title360" },
                    { 100, new DateTime(2018, 9, 8, 8, 32, 24, 330, DateTimeKind.Local), 85, false, "Title849" },
                    { 99, new DateTime(2018, 9, 8, 9, 28, 13, 134, DateTimeKind.Local), 84, false, "Title696" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "AutoScale", "DashboardId", "Gradient", "IsDeleted", "IsLightTheme", "IsShowSeriesOnHover", "IsTooltipDisabled", "LegendTitle", "MostLoaded", "RangeFillOpacity", "RoundDomains", "SchemeType", "ShowCommon", "ShowGridLines", "ShowLegend", "ShowXAxis", "ShowXAxisLabel", "ShowYAxis", "ShowYAxisLabel", "Sources", "Threshold", "Title", "Type", "XAxisLabel", "YAxisLabel" },
                values: new object[,]
                {
                    { 109, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 52, "", 0, "X Label", "Y Label" },
                    { 110, true, 93, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 6, "", 3, "X Label", "Y Label" },
                    { 105, true, 92, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 37, "", 3, "X Label", "Y Label" },
                    { 106, true, 92, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 38, "", 2, "X Label", "Y Label" },
                    { 108, true, 92, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 95, "", 2, "X Label", "Y Label" },
                    { 104, true, 98, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 78, "", 1, "X Label", "Y Label" },
                    { 102, true, 95, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 92, "", 1, "X Label", "Y Label" },
                    { 107, true, 95, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 76, "", 1, "X Label", "Y Label" },
                    { 101, true, 97, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 5, "", 3, "X Label", "Y Label" },
                    { 103, true, 91, false, false, true, true, false, "Legend", 1, 0.5, false, "ordinal", false, true, true, true, true, true, true, "0,1", 71, "", 3, "X Label", "Y Label" }
                });
        }
    }
}
