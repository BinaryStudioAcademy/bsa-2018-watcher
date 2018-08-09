using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedSeedsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "BackgroundColor", "FontFamily", "Name" },
                values: new object[,]
                {
                    { 61, "White", "Frutiger", "Theme609" },
                    { 62, "White", "Trade", "Theme87" },
                    { 63, "Yellow", "Univers", "Theme888" },
                    { 64, "Gray", "Trade", "Theme364" },
                    { 65, "White", "Univers", "Theme352" },
                    { 66, "White", "Helvetica", "Theme395" },
                    { 67, "Gray", "Frutiger", "Theme894" },
                    { 68, "Yellow", "Univers", "Theme493" },
                    { 69, "Yellow", "Trade", "Theme245" },
                    { 70, "Yellow", "Helvetica", "Theme594" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { 3, new DateTime(2018, 8, 9, 2, 21, 13, 78, DateTimeKind.Local), "Isabel", "Carole_Sauer58@yahoo.com", "Eleanore", true, 1, "Hilpert" },
                    { 5, new DateTime(2018, 8, 8, 16, 42, 36, 241, DateTimeKind.Local), "Katlynn", "Isaac.Harvey47@yahoo.com", "Burley", true, 1, "Botsford" },
                    { 6, new DateTime(2018, 8, 9, 5, 52, 29, 466, DateTimeKind.Local), "Edna", "Velva3@yahoo.com", "Maribel", true, 1, "Kovacek" },
                    { 8, new DateTime(2018, 8, 8, 20, 48, 28, 902, DateTimeKind.Local), "Dannie", "Sheldon.Metz@yahoo.com", "Camilla", true, 1, "Hegmann" },
                    { 1, new DateTime(2018, 8, 9, 1, 4, 28, 760, DateTimeKind.Local), "Ova", "Weldon_Steuber92@yahoo.com", "Novella", true, 2, "Okuneva" },
                    { 2, new DateTime(2018, 8, 9, 3, 1, 46, 140, DateTimeKind.Local), "Josiah", "Sharon.Ondricka@hotmail.com", "Breanna", true, 2, "Powlowski" },
                    { 4, new DateTime(2018, 8, 8, 22, 42, 32, 977, DateTimeKind.Local), "Emilia", "Boris_Cruickshank57@yahoo.com", "Tierra", true, 2, "Ledner" },
                    { 7, new DateTime(2018, 8, 8, 23, 23, 47, 940, DateTimeKind.Local), "Connie", "Colten.Crona66@gmail.com", "Amir", true, 2, "O'Kon" },
                    { 9, new DateTime(2018, 8, 8, 22, 53, 59, 855, DateTimeKind.Local), "Lia", "Roscoe.Hegmann1@hotmail.com", "Teagan", true, 2, "Kirlin" },
                    { 10, new DateTime(2018, 8, 9, 7, 20, 5, 871, DateTimeKind.Local), "Audreanne", "Fanny18@yahoo.com", "Elias", true, 2, "Monahan" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 22, 3, "quis", null, 0 },
                    { 24, 3, "ullam", null, 0 },
                    { 23, 2, "deleniti", null, 0 },
                    { 28, 5, "facilis", null, 0 },
                    { 29, 5, "sit", null, 0 },
                    { 30, 1, "doloremque", null, 0 },
                    { 27, 1, "non", null, 0 },
                    { 26, 1, "molestiae", null, 0 },
                    { 21, 9, "veritatis", null, 0 },
                    { 25, 4, "cum", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 41, new DateTime(2018, 8, 9, 0, 10, 45, 480, DateTimeKind.Local), null, "Atque rerum aliquam est.", 7 },
                    { 50, new DateTime(2018, 8, 9, 10, 37, 36, 44, DateTimeKind.Local), null, "Labore eos ratione voluptas ut nulla et et accusantium architecto.", 2 },
                    { 47, new DateTime(2018, 8, 8, 21, 4, 40, 430, DateTimeKind.Local), null, "Rem odit dolores et.", 7 },
                    { 44, new DateTime(2018, 8, 9, 4, 3, 26, 721, DateTimeKind.Local), null, "Et rerum consequatur est fugit.", 9 },
                    { 49, new DateTime(2018, 8, 8, 15, 9, 5, 244, DateTimeKind.Local), null, "Corporis ea facilis vitae ut et sed consequatur corporis ipsa.", 9 },
                    { 45, new DateTime(2018, 8, 9, 10, 33, 0, 332, DateTimeKind.Local), null, "Laudantium animi sequi ut.", 8 },
                    { 48, new DateTime(2018, 8, 8, 17, 24, 59, 639, DateTimeKind.Local), null, "Veritatis velit voluptate commodi corrupti in eos est dicta.", 6 },
                    { 43, new DateTime(2018, 8, 9, 2, 1, 40, 711, DateTimeKind.Local), null, "Ratione sit nihil rem pariatur.", 10 },
                    { 46, new DateTime(2018, 8, 9, 0, 53, 25, 205, DateTimeKind.Local), null, "Vel est alias.", 8 },
                    { 42, new DateTime(2018, 8, 9, 8, 49, 3, 956, DateTimeKind.Local), null, "Tempore blanditiis esse facilis tempora velit ut odit soluta.", 4 }
                });

            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsEmailable", "IsMute", "Type", "UserId" },
                values: new object[,]
                {
                    { 18, true, true, true, 0, 8 },
                    { 14, false, true, true, 1, 9 },
                    { 19, false, false, true, 1, 9 },
                    { 17, true, true, true, 0, 6 },
                    { 16, false, false, true, 0, 6 },
                    { 11, false, false, true, 0, 6 },
                    { 20, false, false, false, 1, 3 },
                    { 15, true, false, false, 1, 3 },
                    { 13, false, true, false, 0, 2 },
                    { 12, true, true, false, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "ContactNumber", "CreatedByUserId", "Description", "Email", "IsActive", "Name", "ThemeId", "WebSite" },
                values: new object[,]
                {
                    { 79, "995-488-4241 x4482", 8, "Qui culpa aut. Culpa natus ut.", "Consuelo.McKenzie99@hotmail.com", true, "Company546", 69, "https://stacey.org" },
                    { 72, "306-667-0280 x65595", 1, "Voluptatem optio voluptatibus distinctio dignissimos vel sit molestiae. Quia exercitationem iusto ut fugit sed beatae ea. Qui est porro laboriosam. Asperiores culpa ea in.", "Bell.Rice37@gmail.com", true, "Company435", 65, "https://eliezer.info" },
                    { 73, "896.777.9915 x1703", 10, "", "Barton_Murray@gmail.com", true, "Company524", 66, "http://buster.net" },
                    { 77, "726.980.6083 x936", 8, "Accusamus dolorem non aut enim. Voluptatem laboriosam quia itaque consequuntur consequatur est odio nihil tenetur.", "Dangelo18@yahoo.com", true, "Company724", 69, "https://elvis.com" },
                    { 71, "(972) 589-7915 x2885", 8, "Amet est quis a sapiente alias.", "Jaydon.Cassin78@hotmail.com", true, "Company717", 63, "https://beverly.biz" },
                    { 78, "573.833.6286 x5517", 6, "Voluptatibus facilis voluptatem vel nesciunt unde ducimus aut. Molestias excepturi amet doloribus suscipit velit aut consequuntur suscipit. Voluptas sunt aliquam et nisi laboriosam.", "Flossie.Hahn97@yahoo.com", true, "Company158", 70, "https://amalia.biz" },
                    { 74, "(662) 947-7935", 6, "Dignissimos voluptatum et voluptates aliquid consequatur sed qui id.", "Hardy.Dach@gmail.com", true, "Company988", 61, "http://arnoldo.biz" },
                    { 80, "624.793.4354 x33532", 5, "Autem ab autem.", "Justice.Harvey@gmail.com", true, "Company303", 63, "http://meaghan.name" },
                    { 75, "(499) 322-6059 x7259", 2, "Quibusdam quam aut id nam perferendis pariatur.", "Gene79@hotmail.com", true, "Company483", 62, "http://lloyd.info" },
                    { 76, "1-279-515-0177 x1446", 10, "Placeat eum accusantium enim quia omnis quisquam quas et. Quaerat et similique illo necessitatibus nulla dolor. Deserunt commodi cum saepe dolores sunt hic. Ut in quidem aut harum voluptatem est dolorum.", "Ollie_Mitchell@gmail.com", true, "Company758", 66, "http://newell.com" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 89, "a0:ed:2d:06:ba:bd", 75, "Windows" },
                    { 84, "29:11:35:1c:7f:a7", 72, "Linux" },
                    { 90, "bb:e3:dd:13:a3:0c", 76, "Linux" },
                    { 88, "51:8c:85:15:78:28", 77, "Linux" },
                    { 83, "36:11:8d:2c:69:ea", 77, "Windows" },
                    { 81, "8f:ec:37:ae:27:ad", 73, "Linux" },
                    { 86, "4e:55:46:8e:16:da", 73, "Linux" },
                    { 82, "1c:c2:74:83:0a:5f", 74, "Windows" },
                    { 85, "56:04:a5:91:b3:ae", 74, "Linux" },
                    { 87, "c7:ab:d6:4e:e5:11", 73, "Linux" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 31, 22, new DateTime(2018, 8, 9, 2, 30, 2, 912, DateTimeKind.Local), "Aut harum cupiditate dolor voluptatem nulla.", 2, true },
                    { 37, 25, new DateTime(2018, 8, 9, 5, 37, 30, 115, DateTimeKind.Local), "Sit asperiores nobis.", 5, true },
                    { 36, 25, new DateTime(2018, 8, 9, 7, 59, 2, 363, DateTimeKind.Local), "Dolorem harum consequatur.", 6, true },
                    { 35, 30, new DateTime(2018, 8, 8, 20, 4, 11, 374, DateTimeKind.Local), "Quod vel facere et.", 5, true },
                    { 33, 30, new DateTime(2018, 8, 9, 9, 7, 23, 654, DateTimeKind.Local), "Pariatur rerum suscipit commodi qui est autem nesciunt qui.", 2, true },
                    { 32, 21, new DateTime(2018, 8, 9, 6, 21, 22, 679, DateTimeKind.Local), "Est omnis qui quia.", 10, false },
                    { 34, 29, new DateTime(2018, 8, 9, 8, 54, 35, 476, DateTimeKind.Local), "Illo aliquam nulla doloremque voluptas.", 6, true },
                    { 38, 28, new DateTime(2018, 8, 8, 20, 41, 55, 817, DateTimeKind.Local), "Tenetur aut velit.", 10, false },
                    { 39, 28, new DateTime(2018, 8, 8, 18, 33, 38, 768, DateTimeKind.Local), "Aspernatur dolorum ut vero.", 6, false },
                    { 40, 29, new DateTime(2018, 8, 9, 9, 23, 16, 857, DateTimeKind.Local), "Quo accusantium est nobis tenetur est culpa temporibus.", 9, true }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 113, new DateTime(2018, 8, 8, 21, 46, 18, 27, DateTimeKind.Local), 20, null, "Esse at et animi ab.", 2 },
                    { 119, new DateTime(2018, 8, 8, 17, 13, 31, 896, DateTimeKind.Local), 14, null, "Et adipisci quo expedita aliquid illum ea nihil praesentium sunt.", 6 },
                    { 111, new DateTime(2018, 8, 8, 12, 8, 54, 488, DateTimeKind.Local), 19, null, "Sunt quam totam optio iure perspiciatis rerum.", 6 },
                    { 116, new DateTime(2018, 8, 9, 10, 32, 51, 702, DateTimeKind.Local), 19, null, "Omnis reprehenderit ea ut saepe molestiae cum laudantium.", 1 },
                    { 120, new DateTime(2018, 8, 8, 16, 56, 46, 724, DateTimeKind.Local), 17, null, "Omnis harum dolor velit quo inventore recusandae corrupti eos libero.", 4 },
                    { 115, new DateTime(2018, 8, 8, 14, 40, 55, 137, DateTimeKind.Local), 18, null, "Perspiciatis neque asperiores quisquam.", 6 },
                    { 114, new DateTime(2018, 8, 8, 20, 47, 36, 51, DateTimeKind.Local), 11, null, "Quod eaque rerum sint.", 7 },
                    { 117, new DateTime(2018, 8, 8, 18, 40, 50, 277, DateTimeKind.Local), 11, null, "Earum deserunt in ea itaque totam voluptas.", 8 },
                    { 118, new DateTime(2018, 8, 8, 23, 0, 24, 608, DateTimeKind.Local), 11, null, "Eligendi deleniti unde voluptatem libero quidem facilis.", 4 },
                    { 112, new DateTime(2018, 8, 8, 16, 25, 20, 147, DateTimeKind.Local), 17, null, "Qui facere animi in sequi enim culpa autem.", 9 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 8, 8, 16, 24, 49, 691, DateTimeKind.Local), 50, "Sit aut praesentium et cum quasi repellendus.", 10 },
                    { 58, new DateTime(2018, 8, 8, 21, 58, 40, 531, DateTimeKind.Local), 43, "Qui voluptatibus esse eos.", 6 },
                    { 55, new DateTime(2018, 8, 9, 2, 19, 37, 678, DateTimeKind.Local), 49, "Autem in temporibus.", 4 },
                    { 60, new DateTime(2018, 8, 9, 9, 31, 19, 655, DateTimeKind.Local), 41, "Enim explicabo dolore aut qui sequi vitae sunt enim.", 10 },
                    { 52, new DateTime(2018, 8, 9, 11, 24, 18, 965, DateTimeKind.Local), 46, "Id velit corporis similique.", 6 },
                    { 54, new DateTime(2018, 8, 8, 18, 21, 35, 968, DateTimeKind.Local), 48, "Deserunt rerum sit voluptatem unde.", 10 },
                    { 57, new DateTime(2018, 8, 9, 4, 37, 10, 117, DateTimeKind.Local), 45, "Autem et reprehenderit facilis nihil odio et odio.", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { 7, 79 },
                    { 5, 75 },
                    { 4, 75 },
                    { 9, 72 },
                    { 8, 71 },
                    { 1, 71 },
                    { 2, 78 },
                    { 3, 74 },
                    { 10, 75 },
                    { 6, 76 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 94, new DateTime(2018, 8, 9, 5, 47, 20, 907, DateTimeKind.Local), 82, "Title150" },
                    { 93, new DateTime(2018, 8, 9, 11, 49, 17, 190, DateTimeKind.Local), 83, "Title267" },
                    { 96, new DateTime(2018, 8, 9, 7, 3, 48, 805, DateTimeKind.Local), 83, "Title158" },
                    { 99, new DateTime(2018, 8, 9, 6, 43, 21, 234, DateTimeKind.Local), 83, "Title269" },
                    { 91, new DateTime(2018, 8, 9, 5, 21, 1, 110, DateTimeKind.Local), 84, "Title307" },
                    { 98, new DateTime(2018, 8, 9, 7, 29, 47, 213, DateTimeKind.Local), 81, "Title7" },
                    { 97, new DateTime(2018, 8, 9, 4, 30, 40, 157, DateTimeKind.Local), 86, "Title36" },
                    { 92, new DateTime(2018, 8, 8, 15, 58, 18, 476, DateTimeKind.Local), 87, "Title825" },
                    { 100, new DateTime(2018, 8, 8, 15, 55, 58, 640, DateTimeKind.Local), 87, "Title201" },
                    { 95, new DateTime(2018, 8, 8, 16, 11, 23, 708, DateTimeKind.Local), 90, "Title150" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 102, 94, "MostLoaded2", "Common2", "Source1", 69, 2 },
                    { 109, 93, "MostLoaded2", "Common2", "Source2", 14, 1 },
                    { 106, 99, "MostLoaded3", "Common1", "Source3", 17, 0 },
                    { 103, 91, "MostLoaded2", "Common1", "Source3", 63, 1 },
                    { 104, 91, "MostLoaded2", "Common2", "Source1", 25, 1 },
                    { 105, 91, "MostLoaded3", "Common3", "Source2", 18, 2 },
                    { 110, 98, "MostLoaded3", "Common2", "Source1", 85, 2 },
                    { 108, 92, "MostLoaded2", "Common1", "Source1", 79, 0 },
                    { 107, 100, "MostLoaded2", "Common3", "Source3", 55, 2 },
                    { 101, 95, "MostLoaded3", "Common1", "Source3", 26, 2 }
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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 88);

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
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 16);

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
                keyValue: 64);

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
                keyValues: new object[] { 1, 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 2, 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 3, 74 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 4, 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 5, 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 6, 76 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 7, 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 8, 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 9, 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { 10, 75 });

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
                keyValue: 25);

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
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 71);

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
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
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
        }
    }
}
