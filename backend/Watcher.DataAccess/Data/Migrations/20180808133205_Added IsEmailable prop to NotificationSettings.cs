using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedIsEmailableproptoNotificationSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailable",
                table: "NotificationSettings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsEmailable", "IsMute", "Type" },
                values: new object[,]
                {
                    { 1, false, true, true, 0 },
                    { 2, true, true, false, 0 },
                    { 3, false, true, true, 1 },
                    { 4, false, false, false, 1 },
                    { 5, true, false, true, 0 },
                    { 6, true, true, false, 0 },
                    { 7, false, false, false, 0 },
                    { 8, true, true, false, 1 },
                    { 9, true, false, true, 1 },
                    { 10, true, false, true, 1 }
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
                    { 61, "Yellow", "Univers", "Theme211" },
                    { 62, "White", "Univers", "Theme836" },
                    { 63, "Gray", "Trade", "Theme192" },
                    { 64, "Gray", "Frutiger", "Theme802" },
                    { 65, "White", "Trade", "Theme490" },
                    { 66, "Yellow", "Trade", "Theme269" },
                    { 67, "Gray", "Frutiger", "Theme166" },
                    { 68, "Gray", "Univers", "Theme237" },
                    { 69, "Yellow", "Helvetica", "Theme135" },
                    { 70, "Yellow", "Trade", "Theme442" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "NotificationSettingId", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { 11, new DateTime(2018, 8, 8, 2, 57, 32, 292, DateTimeKind.Local), "Lisandro32@gmail.com", "Asia", true, 3, 1, "Altenwerth" },
                    { 12, new DateTime(2018, 8, 8, 1, 7, 2, 657, DateTimeKind.Local), "Coty_Larkin31@gmail.com", "Sigurd", true, 2, 1, "Ritchie" },
                    { 13, new DateTime(2018, 8, 7, 21, 12, 16, 772, DateTimeKind.Local), "Rasheed_Kohler2@yahoo.com", "Sim", true, 8, 1, "Cronin" },
                    { 14, new DateTime(2018, 8, 8, 7, 48, 2, 920, DateTimeKind.Local), "Eulalia.Pacocha71@gmail.com", "Laurel", true, 2, 1, "Raynor" },
                    { 15, new DateTime(2018, 8, 8, 14, 59, 49, 510, DateTimeKind.Local), "Emelie_Schuppe@yahoo.com", "Angelica", true, 8, 1, "Purdy" },
                    { 19, new DateTime(2018, 8, 8, 16, 25, 26, 927, DateTimeKind.Local), "Jamar.Balistreri91@gmail.com", "Naomi", true, 4, 1, "Hessel" },
                    { 20, new DateTime(2018, 8, 7, 21, 22, 58, 82, DateTimeKind.Local), "Diamond_McLaughlin@hotmail.com", "Kathleen", true, 7, 1, "Lang" },
                    { 16, new DateTime(2018, 8, 7, 21, 0, 9, 53, DateTimeKind.Local), "Roslyn.Romaguera31@gmail.com", "Braulio", true, 3, 2, "Pollich" },
                    { 17, new DateTime(2018, 8, 8, 13, 57, 45, 976, DateTimeKind.Local), "Letitia13@gmail.com", "Phyllis", true, 10, 2, "Bruen" },
                    { 18, new DateTime(2018, 8, 7, 19, 0, 12, 48, DateTimeKind.Local), "Ayla15@hotmail.com", "Arthur", true, 3, 2, "Cole" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 22, 11, "voluptas", null, 0 },
                    { 30, 17, "doloremque", null, 0 },
                    { 29, 16, "soluta", null, 0 },
                    { 23, 16, "natus", null, 0 },
                    { 27, 15, "corporis", null, 0 },
                    { 28, 12, "iusto", null, 0 },
                    { 26, 19, "quam", null, 0 },
                    { 24, 11, "facere", null, 0 },
                    { 25, 11, "distinctio", null, 0 },
                    { 21, 12, "a", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 41, new DateTime(2018, 8, 7, 17, 59, 45, 467, DateTimeKind.Local), null, "Vel consequuntur omnis iusto nihil ut ut.", 16 },
                    { 46, new DateTime(2018, 8, 7, 17, 43, 12, 263, DateTimeKind.Local), null, "Quis alias at necessitatibus vero quas.", 11 },
                    { 45, new DateTime(2018, 8, 8, 2, 34, 59, 854, DateTimeKind.Local), null, "Laudantium tempora qui esse sunt quas distinctio nihil vero rem.", 20 },
                    { 50, new DateTime(2018, 8, 7, 20, 58, 55, 3, DateTimeKind.Local), null, "Saepe voluptatum beatae.", 19 },
                    { 42, new DateTime(2018, 8, 7, 20, 32, 48, 294, DateTimeKind.Local), null, "Ipsa modi ex aut corporis vitae.", 16 },
                    { 44, new DateTime(2018, 8, 7, 19, 8, 51, 591, DateTimeKind.Local), null, "Quos nam voluptate.", 20 },
                    { 43, new DateTime(2018, 8, 7, 18, 35, 35, 106, DateTimeKind.Local), null, "Sed aut et.", 15 },
                    { 49, new DateTime(2018, 8, 8, 3, 17, 11, 443, DateTimeKind.Local), null, "Nostrum odio ipsa aspernatur quidem omnis.", 14 },
                    { 48, new DateTime(2018, 8, 8, 10, 41, 20, 717, DateTimeKind.Local), null, "Repellat a nobis qui culpa ipsum aut.", 18 },
                    { 47, new DateTime(2018, 8, 8, 2, 48, 43, 485, DateTimeKind.Local), null, "Ratione culpa sunt numquam dolores laboriosam non ut dolorem quae.", 15 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 111, new DateTime(2018, 8, 8, 3, 29, 55, 936, DateTimeKind.Local), 7, null, "Debitis molestias quasi a.", 15 },
                    { 120, new DateTime(2018, 8, 7, 19, 54, 21, 164, DateTimeKind.Local), 5, null, "Est occaecati necessitatibus est.", 11 },
                    { 116, new DateTime(2018, 8, 8, 4, 41, 54, 204, DateTimeKind.Local), 9, null, "Fugit nobis et voluptas ducimus tempora id.", 19 },
                    { 119, new DateTime(2018, 8, 8, 10, 17, 58, 619, DateTimeKind.Local), 7, null, "Est debitis delectus est sunt quibusdam quidem soluta animi.", 17 },
                    { 112, new DateTime(2018, 8, 8, 0, 31, 13, 499, DateTimeKind.Local), 5, null, "Maxime delectus omnis repellendus rerum aperiam blanditiis adipisci sunt voluptates.", 14 },
                    { 118, new DateTime(2018, 8, 8, 0, 48, 48, 379, DateTimeKind.Local), 6, null, "Sint et vel nihil omnis velit rerum.", 17 },
                    { 117, new DateTime(2018, 8, 8, 8, 34, 20, 865, DateTimeKind.Local), 9, null, "Sit maxime natus magni vel dolores quia.", 17 },
                    { 113, new DateTime(2018, 8, 7, 23, 2, 59, 101, DateTimeKind.Local), 10, null, "Inventore nulla modi ab est et veniam.", 13 },
                    { 114, new DateTime(2018, 8, 8, 10, 52, 4, 968, DateTimeKind.Local), 4, null, "Quaerat ut dolore eos esse explicabo odit blanditiis.", 12 },
                    { 115, new DateTime(2018, 8, 8, 10, 13, 45, 942, DateTimeKind.Local), 10, null, "Voluptatem odit asperiores.", 18 }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "IsActive", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 78, "(836) 542-4631", 17, "Repellendus magnam soluta optio sapiente a et a dolores. Labore eos sunt quo quidem eligendi sed sit ipsam non. Non quaerat quis consectetur excepturi animi.", "Danyka.Tromp@gmail.com", true, "Company688", 65, "http://jamey.biz" },
                    { 74, "1-957-959-3654", 17, "Aspernatur ipsum ipsam rerum est non et tempora sit.", "Kennedi_Daugherty27@hotmail.com", true, "Company60", 66, "https://paula.org" },
                    { 76, "1-630-270-6472 x12159", 11, "Nihil autem aut voluptatem quam accusamus quidem velit qui.", "Mittie37@hotmail.com", true, "Company625", 64, "https://isadore.org" },
                    { 71, "371.369.1097", 20, "", "Kale.Kulas18@gmail.com", true, "Company926", 69, "http://evans.name" },
                    { 73, "581-612-6251", 19, "Quibusdam harum deleniti ad ut et est aut.", "Sonya.Schmitt91@yahoo.com", true, "Company543", 69, "http://lyric.info" },
                    { 80, "1-349-797-9764", 15, "Voluptatibus et voluptas id qui quaerat. Voluptate est quas perspiciatis voluptas beatae tenetur quaerat sed. Est accusamus nisi architecto expedita ipsum voluptas consequatur qui enim. Voluptas velit beatae voluptatum voluptatem dolores cum sunt ipsa.", "Jarvis13@yahoo.com", true, "Company225", 64, "https://aurore.net" },
                    { 75, "(864) 677-7126 x594", 15, "", "Alexandrine.Tillman@yahoo.com", true, "Company10", 68, "http://jacinto.net" },
                    { 77, "1-874-646-7218 x51088", 12, "", "Alexander.Rolfson13@gmail.com", true, "Company519", 67, "https://kathryne.net" },
                    { 72, "923.534.4861", 20, "", "Leif46@hotmail.com", true, "Company156", 62, "https://kiel.org" },
                    { 79, "619.424.0667", 18, "Eos occaecati odio. Asperiores enim quas qui ea corporis quos quod ratione.", "Vena97@yahoo.com", true, "Company392", 70, "http://rico.biz" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 86, "83:45:4b:0e:96:27", 80, "Windows" },
                    { 81, "41:5e:90:a3:31:99", 79, "Windows" },
                    { 87, "c7:59:d6:79:ae:e3", 75, "Linux" },
                    { 89, "b3:52:82:15:79:a5", 73, "Linux" },
                    { 88, "cc:33:36:1f:13:f0", 78, "Windows" },
                    { 90, "fe:52:e9:ad:c7:82", 78, "Windows" },
                    { 82, "77:c8:d3:ec:90:90", 74, "Windows" },
                    { 85, "69:7a:16:b4:17:88", 76, "Linux" },
                    { 83, "bb:90:ba:6c:f2:13", 76, "Windows" },
                    { 84, "6c:11:86:f1:46:b0", 71, "Windows" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 38, 28, new DateTime(2018, 8, 8, 11, 2, 9, 415, DateTimeKind.Local), "Quia optio expedita similique voluptatum maxime sunt unde in.", 11, false },
                    { 36, 28, new DateTime(2018, 8, 8, 2, 21, 43, 707, DateTimeKind.Local), "Possimus ea iste et esse minima.", 14, true },
                    { 32, 28, new DateTime(2018, 8, 8, 4, 46, 25, 944, DateTimeKind.Local), "Qui aspernatur expedita in repellendus sit dolorem quam.", 19, true },
                    { 40, 21, new DateTime(2018, 8, 8, 2, 5, 17, 249, DateTimeKind.Local), "Quia doloribus nesciunt officia.", 14, false },
                    { 39, 30, new DateTime(2018, 8, 8, 4, 54, 12, 364, DateTimeKind.Local), "Consequuntur possimus impedit.", 15, false },
                    { 33, 29, new DateTime(2018, 8, 8, 4, 49, 41, 98, DateTimeKind.Local), "Magnam reiciendis minus sed praesentium.", 12, false },
                    { 34, 26, new DateTime(2018, 8, 8, 15, 57, 45, 98, DateTimeKind.Local), "Et odio at non enim molestias itaque voluptas sint.", 14, true },
                    { 35, 26, new DateTime(2018, 8, 8, 13, 37, 1, 803, DateTimeKind.Local), "Qui quo aliquam itaque.", 20, true },
                    { 31, 29, new DateTime(2018, 8, 7, 22, 48, 50, 935, DateTimeKind.Local), "Aut et provident sed.", 11, false },
                    { 37, 28, new DateTime(2018, 8, 8, 3, 48, 54, 692, DateTimeKind.Local), "Alias eos non et at.", 19, false }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 8, 7, 21, 46, 40, 990, DateTimeKind.Local), 48, "Rerum pariatur adipisci voluptas est consequatur aliquam atque minima.", 20 },
                    { 58, new DateTime(2018, 8, 8, 8, 17, 57, 667, DateTimeKind.Local), 42, "Sit quaerat quis.", 19 },
                    { 57, new DateTime(2018, 8, 7, 23, 24, 20, 916, DateTimeKind.Local), 41, "Facere ea omnis.", 20 },
                    { 53, new DateTime(2018, 8, 8, 9, 58, 4, 745, DateTimeKind.Local), 46, "Et in praesentium.", 17 },
                    { 60, new DateTime(2018, 8, 8, 3, 7, 2, 651, DateTimeKind.Local), 50, "Praesentium impedit voluptatem explicabo maiores.", 11 },
                    { 56, new DateTime(2018, 8, 7, 20, 53, 7, 831, DateTimeKind.Local), 47, "Officia minima vitae quidem neque quis officiis.", 15 }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { 20, 75 },
                    { 19, 75 },
                    { 18, 75 },
                    { 13, 75 },
                    { 15, 74 },
                    { 17, 77 },
                    { 14, 77 },
                    { 12, 77 },
                    { 11, 73 },
                    { 16, 79 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 96, new DateTime(2018, 8, 7, 20, 40, 51, 325, DateTimeKind.Local), 83, "Title264" },
                    { 97, new DateTime(2018, 8, 8, 1, 13, 42, 954, DateTimeKind.Local), 85, "Title133" },
                    { 92, new DateTime(2018, 8, 8, 2, 1, 56, 408, DateTimeKind.Local), 89, "Title926" },
                    { 94, new DateTime(2018, 8, 8, 5, 49, 59, 229, DateTimeKind.Local), 84, "Title891" },
                    { 95, new DateTime(2018, 8, 8, 4, 9, 26, 423, DateTimeKind.Local), 84, "Title572" },
                    { 98, new DateTime(2018, 8, 7, 22, 7, 10, 268, DateTimeKind.Local), 84, "Title359" },
                    { 91, new DateTime(2018, 8, 7, 22, 0, 22, 592, DateTimeKind.Local), 82, "Title270" },
                    { 93, new DateTime(2018, 8, 7, 18, 43, 21, 69, DateTimeKind.Local), 90, "Title523" },
                    { 99, new DateTime(2018, 8, 7, 17, 54, 17, 990, DateTimeKind.Local), 90, "Title289" },
                    { 100, new DateTime(2018, 8, 7, 20, 29, 4, 246, DateTimeKind.Local), 90, "Title302" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 104, 96, "MostLoaded1", "Common3", "Source1", 12, 1 },
                    { 102, 92, "MostLoaded2", "Common3", "Source2", 99, 1 },
                    { 108, 92, "MostLoaded2", "Common2", "Source3", 60, 0 },
                    { 103, 95, "MostLoaded2", "Common1", "Source1", 63, 0 },
                    { 105, 95, "MostLoaded2", "Common2", "Source1", 46, 1 },
                    { 101, 98, "MostLoaded3", "Common2", "Source1", 5, 1 },
                    { 106, 98, "MostLoaded3", "Common3", "Source1", 59, 0 },
                    { 107, 98, "MostLoaded3", "Common3", "Source2", 39, 2 },
                    { 109, 91, "MostLoaded2", "Common1", "Source3", 81, 2 },
                    { 110, 91, "MostLoaded1", "Common3", "Source3", 44, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 97);

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
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 81);

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
                keyValue: 72);

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
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 11, 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 12, 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 13, 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 14, 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 15, 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 16, 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 17, 77 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 18, 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 19, 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 20, 75 });

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26);

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
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 92);

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
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 41);

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
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

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
                keyValue: 9);

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
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

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
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "IsEmailable",
                table: "NotificationSettings");
        }
    }
}
