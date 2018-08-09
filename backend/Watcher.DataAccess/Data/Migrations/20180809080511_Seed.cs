using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NotificationSettings",
                columns: new[] { "Id", "IsDisable", "IsMute", "Type", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, false, false, 1, 0, null },
                    { 2, false, false, 1, 0, null },
                    { 3, true, false, 0, 0, null },
                    { 4, true, false, 0, 0, null },
                    { 5, false, false, 0, 0, null },
                    { 6, false, false, 1, 0, null },
                    { 7, true, false, 1, 0, null },
                    { 8, false, true, 0, 0, null },
                    { 9, false, false, 1, 0, null },
                    { 10, true, false, 1, 0, null }
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
                    { 61, "Gray", "Frutiger", "Theme916" },
                    { 62, "Gray", "Univers", "Theme684" },
                    { 63, "Gray", "Frutiger", "Theme767" },
                    { 64, "Gray", "Frutiger", "Theme941" },
                    { 65, "Gray", "Univers", "Theme318" },
                    { 66, "Yellow", "Trade", "Theme541" },
                    { 67, "Yellow", "Univers", "Theme760" },
                    { 68, "White", "Trade", "Theme406" },
                    { 69, "White", "Frutiger", "Theme174" },
                    { 70, "Yellow", "Helvetica", "Theme174" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name", "ThemeId" },
                values: new object[,]
                {
                    { 80, "Company465", 70 },
                    { 76, "Company958", 68 },
                    { 71, "Company242", 68 },
                    { 73, "Company754", 67 },
                    { 79, "Company149", 66 },
                    { 78, "Company972", 66 },
                    { 75, "Company246", 66 },
                    { 72, "Company918", 64 },
                    { 74, "Company771", 63 },
                    { 77, "Company883", 68 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "ChhosedOrganizationId", "ChoosedOrganizationId", "CreatedAt", "DisplayName", "Email", "FirstName", "IsActive", "NickName", "RoleId", "SecondName" },
                values: new object[,]
                {
                    { "b3f709f1-76e9-4a8a-a907-5872dd61a9aa", null, 0, null, new DateTime(2018, 8, 9, 1, 55, 7, 881, DateTimeKind.Local), "Otilia", "Audie82@gmail.com", "Grant", false, null, 2, "Williamson" },
                    { "47a110d6-9eea-4f04-aaad-8c4702502cf0", null, 0, null, new DateTime(2018, 8, 9, 2, 52, 55, 21, DateTimeKind.Local), "Loyce", "Leif_Volkman75@yahoo.com", "Devin", false, null, 2, "Jenkins" },
                    { "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb", null, 0, null, new DateTime(2018, 8, 8, 21, 5, 41, 202, DateTimeKind.Local), "Letha", "Laverne.Gerhold60@hotmail.com", "Jammie", false, null, 2, "Ruecker" },
                    { "d674f676-006b-45d0-8e4b-fddb165f324d", null, 0, null, new DateTime(2018, 8, 9, 7, 15, 40, 722, DateTimeKind.Local), "Lindsey", "Miller.Considine@hotmail.com", "Jo", true, null, 2, "Senger" },
                    { "db4d1e02-a2ca-4945-9b56-d862b806c76e", null, 0, null, new DateTime(2018, 8, 8, 19, 19, 32, 981, DateTimeKind.Local), "Declan", "Kayleigh_Parisian86@hotmail.com", "Bernardo", true, null, 2, "VonRueden" },
                    { "c5bf65ed-8850-4ce1-87bf-64501cf5fb16", null, 0, null, new DateTime(2018, 8, 9, 3, 47, 54, 395, DateTimeKind.Local), "Katlynn", "Dustin_Medhurst50@yahoo.com", "Stephania", false, null, 1, "Jakubowski" },
                    { "f1b165f2-d721-46a9-a125-123a0ce75ae6", null, 0, null, new DateTime(2018, 8, 8, 17, 38, 51, 604, DateTimeKind.Local), "Catharine", "Finn.Ondricka@hotmail.com", "Mitchell", true, null, 1, "King" },
                    { "2b845974-2152-4b79-8f5f-3c1a14fd1745", null, 0, null, new DateTime(2018, 8, 8, 16, 27, 18, 385, DateTimeKind.Local), "Norene", "Diana6@gmail.com", "Geovany", true, null, 1, "Wisoky" },
                    { "832cfb2b-2267-46a5-9234-bcc04d746cc2", null, 0, null, new DateTime(2018, 8, 8, 13, 0, 13, 657, DateTimeKind.Local), "Santino", "Mitchel4@gmail.com", "Aliyah", false, null, 2, "Weimann" },
                    { "bbb4132c-135f-4732-9cbd-dc1db6f1c273", null, 0, null, new DateTime(2018, 8, 9, 6, 10, 18, 487, DateTimeKind.Local), "Ludwig", "Wade34@hotmail.com", "Mary", true, null, 1, "Barrows" }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "CreatedById", "Name", "OrganizationId", "Type" },
                values: new object[,]
                {
                    { 27, "bbb4132c-135f-4732-9cbd-dc1db6f1c273", "quasi", null, 0 },
                    { 29, "832cfb2b-2267-46a5-9234-bcc04d746cc2", "molestiae", null, 0 },
                    { 26, "832cfb2b-2267-46a5-9234-bcc04d746cc2", "molestias", null, 0 },
                    { 24, "47a110d6-9eea-4f04-aaad-8c4702502cf0", "rerum", null, 0 },
                    { 28, "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb", "praesentium", null, 0 },
                    { 25, "d674f676-006b-45d0-8e4b-fddb165f324d", "quibusdam", null, 0 },
                    { 30, "c5bf65ed-8850-4ce1-87bf-64501cf5fb16", "consequuntur", null, 0 },
                    { 21, "832cfb2b-2267-46a5-9234-bcc04d746cc2", "consequuntur", null, 0 },
                    { 22, "f1b165f2-d721-46a9-a125-123a0ce75ae6", "atque", null, 0 },
                    { 23, "2b845974-2152-4b79-8f5f-3c1a14fd1745", "nam", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreatedAt", "ResponseId", "Text", "UserId" },
                values: new object[,]
                {
                    { 43, new DateTime(2018, 8, 8, 18, 11, 55, 716, DateTimeKind.Local), null, "Consequatur ut ut vero.", "f1b165f2-d721-46a9-a125-123a0ce75ae6" },
                    { 50, new DateTime(2018, 8, 9, 9, 40, 2, 963, DateTimeKind.Local), null, "Accusantium magni nemo vitae molestiae vel omnis fugiat similique.", "47a110d6-9eea-4f04-aaad-8c4702502cf0" },
                    { 47, new DateTime(2018, 8, 8, 13, 34, 3, 822, DateTimeKind.Local), null, "Qui quisquam dolore non ea illum ab.", "47a110d6-9eea-4f04-aaad-8c4702502cf0" },
                    { 45, new DateTime(2018, 8, 8, 19, 25, 55, 756, DateTimeKind.Local), null, "Et error eum facere consequuntur et cum et dolores.", "47a110d6-9eea-4f04-aaad-8c4702502cf0" },
                    { 48, new DateTime(2018, 8, 8, 14, 53, 25, 161, DateTimeKind.Local), null, "Et iusto voluptatem qui ut ut quae ullam.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273" },
                    { 42, new DateTime(2018, 8, 9, 1, 52, 25, 70, DateTimeKind.Local), null, "Officiis ex et repellendus.", "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb" },
                    { 44, new DateTime(2018, 8, 8, 17, 28, 51, 112, DateTimeKind.Local), null, "Iusto quos nobis et nihil officiis a ut repellat dicta.", "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb" },
                    { 49, new DateTime(2018, 8, 8, 12, 11, 30, 744, DateTimeKind.Local), null, "Quia et quia dolor nisi qui excepturi est.", "d674f676-006b-45d0-8e4b-fddb165f324d" },
                    { 46, new DateTime(2018, 8, 8, 18, 9, 11, 218, DateTimeKind.Local), null, "Magnam ut dolor dolorem expedita quidem modi omnis qui odit.", "c5bf65ed-8850-4ce1-87bf-64501cf5fb16" },
                    { 41, new DateTime(2018, 8, 9, 5, 10, 52, 99, DateTimeKind.Local), null, "Omnis ut velit corrupti magnam.", "f1b165f2-d721-46a9-a125-123a0ce75ae6" }
                });

            migrationBuilder.InsertData(
                table: "Instances",
                columns: new[] { "Id", "Address", "OrganizationId", "Platform" },
                values: new object[,]
                {
                    { 86, "80:9a:77:23:1b:23", 73, "Linux" },
                    { 81, "6c:fb:74:2e:2b:3e", 79, "Windows" },
                    { 83, "02:f0:3e:25:6d:02", 78, "Linux" },
                    { 82, "6a:e5:a2:d5:a2:6e", 78, "Windows" },
                    { 90, "92:87:a4:d2:8b:9c", 73, "Windows" },
                    { 88, "3b:0d:e8:aa:0c:16", 72, "Windows" },
                    { 85, "a2:6a:65:4e:ca:fc", 74, "Windows" },
                    { 84, "45:81:32:c4:05:cc", 73, "Windows" },
                    { 89, "9b:81:33:38:09:76", 80, "Linux" },
                    { 87, "61:ef:89:87:d3:d1", 80, "Windows" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "NotificationSettingId", "OrganizationId", "Text", "UserId" },
                values: new object[,]
                {
                    { 117, new DateTime(2018, 8, 8, 16, 35, 25, 932, DateTimeKind.Local), 8, null, "Assumenda ut amet minima aliquam.", "b3f709f1-76e9-4a8a-a907-5872dd61a9aa" },
                    { 112, new DateTime(2018, 8, 8, 12, 32, 22, 632, DateTimeKind.Local), 10, null, "Amet porro sunt eligendi fuga.", "c5bf65ed-8850-4ce1-87bf-64501cf5fb16" },
                    { 120, new DateTime(2018, 8, 9, 7, 48, 50, 68, DateTimeKind.Local), 8, null, "Molestiae libero odit sed autem earum vero ratione.", "d674f676-006b-45d0-8e4b-fddb165f324d" },
                    { 116, new DateTime(2018, 8, 8, 15, 7, 24, 867, DateTimeKind.Local), 1, null, "Accusantium ea corporis id aspernatur.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273" },
                    { 118, new DateTime(2018, 8, 8, 14, 6, 10, 429, DateTimeKind.Local), 4, null, "Omnis perferendis ipsa adipisci.", "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb" },
                    { 114, new DateTime(2018, 8, 8, 16, 39, 1, 626, DateTimeKind.Local), 2, null, "Sint non nostrum iusto at aut neque.", "b3f709f1-76e9-4a8a-a907-5872dd61a9aa" },
                    { 119, new DateTime(2018, 8, 9, 11, 0, 29, 691, DateTimeKind.Local), 5, null, "Omnis numquam quae perspiciatis ut maiores eos.", "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb" },
                    { 115, new DateTime(2018, 8, 9, 3, 33, 11, 111, DateTimeKind.Local), 4, null, "Nostrum fuga esse quia et ab quisquam alias ipsa.", "b3f709f1-76e9-4a8a-a907-5872dd61a9aa" },
                    { 111, new DateTime(2018, 8, 8, 11, 39, 44, 835, DateTimeKind.Local), 10, null, "Incidunt est natus eos excepturi et velit iure exercitationem rerum.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273" },
                    { 113, new DateTime(2018, 8, 8, 12, 36, 36, 270, DateTimeKind.Local), 6, null, "Quia pariatur atque et saepe est adipisci consequatur.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273" }
                });

            migrationBuilder.InsertData(
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" },
                values: new object[,]
                {
                    { "832cfb2b-2267-46a5-9234-bcc04d746cc2", 78 },
                    { "c5bf65ed-8850-4ce1-87bf-64501cf5fb16", 75 },
                    { "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb", 72 },
                    { "bbb4132c-135f-4732-9cbd-dc1db6f1c273", 79 },
                    { "d674f676-006b-45d0-8e4b-fddb165f324d", 72 },
                    { "f1b165f2-d721-46a9-a125-123a0ce75ae6", 74 },
                    { "db4d1e02-a2ca-4945-9b56-d862b806c76e", 73 },
                    { "47a110d6-9eea-4f04-aaad-8c4702502cf0", 73 },
                    { "2b845974-2152-4b79-8f5f-3c1a14fd1745", 71 },
                    { "b3f709f1-76e9-4a8a-a907-5872dd61a9aa", 78 }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreatedAt", "InstanceId", "Title" },
                values: new object[,]
                {
                    { 98, new DateTime(2018, 8, 9, 8, 35, 53, 194, DateTimeKind.Local), 89, "Title297" },
                    { 97, new DateTime(2018, 8, 8, 22, 46, 38, 775, DateTimeKind.Local), 90, "Title919" },
                    { 95, new DateTime(2018, 8, 8, 14, 42, 18, 18, DateTimeKind.Local), 86, "Title415" },
                    { 100, new DateTime(2018, 8, 9, 10, 9, 29, 141, DateTimeKind.Local), 84, "Title938" },
                    { 99, new DateTime(2018, 8, 8, 16, 26, 22, 34, DateTimeKind.Local), 84, "Title624" },
                    { 92, new DateTime(2018, 8, 8, 16, 48, 59, 384, DateTimeKind.Local), 84, "Title85" },
                    { 91, new DateTime(2018, 8, 9, 8, 26, 1, 912, DateTimeKind.Local), 84, "Title133" },
                    { 96, new DateTime(2018, 8, 9, 10, 45, 55, 126, DateTimeKind.Local), 81, "Title602" },
                    { 93, new DateTime(2018, 8, 8, 11, 32, 11, 132, DateTimeKind.Local), 81, "Title815" },
                    { 94, new DateTime(2018, 8, 8, 18, 14, 28, 566, DateTimeKind.Local), 87, "Title736" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "CreatedAt", "Text", "UserId", "WasRead" },
                values: new object[,]
                {
                    { 39, 29, new DateTime(2018, 8, 9, 1, 37, 43, 581, DateTimeKind.Local), "Voluptas ipsam alias.", "832cfb2b-2267-46a5-9234-bcc04d746cc2", true },
                    { 38, 29, new DateTime(2018, 8, 8, 19, 16, 15, 282, DateTimeKind.Local), "Perspiciatis dolor iste.", "f1b165f2-d721-46a9-a125-123a0ce75ae6", false },
                    { 34, 29, new DateTime(2018, 8, 9, 10, 6, 3, 18, DateTimeKind.Local), "Quo voluptatem harum et.", "f1b165f2-d721-46a9-a125-123a0ce75ae6", true },
                    { 35, 26, new DateTime(2018, 8, 9, 5, 5, 57, 549, DateTimeKind.Local), "Reprehenderit neque perferendis praesentium quisquam voluptatem quibusdam excepturi.", "db4d1e02-a2ca-4945-9b56-d862b806c76e", true },
                    { 32, 28, new DateTime(2018, 8, 9, 0, 53, 47, 517, DateTimeKind.Local), "Sit sunt recusandae occaecati.", "832cfb2b-2267-46a5-9234-bcc04d746cc2", false },
                    { 40, 25, new DateTime(2018, 8, 8, 21, 43, 43, 850, DateTimeKind.Local), "Iste ea laboriosam libero nesciunt officia.", "b3f709f1-76e9-4a8a-a907-5872dd61a9aa", true },
                    { 37, 30, new DateTime(2018, 8, 9, 8, 58, 26, 208, DateTimeKind.Local), "Culpa ut incidunt aspernatur praesentium minus molestiae.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273", true },
                    { 36, 30, new DateTime(2018, 8, 9, 6, 2, 58, 461, DateTimeKind.Local), "Et placeat et repudiandae atque.", "db4d1e02-a2ca-4945-9b56-d862b806c76e", true },
                    { 33, 21, new DateTime(2018, 8, 8, 22, 56, 37, 14, DateTimeKind.Local), "Corporis soluta fuga.", "c5bf65ed-8850-4ce1-87bf-64501cf5fb16", true },
                    { 31, 22, new DateTime(2018, 8, 8, 12, 30, 53, 694, DateTimeKind.Local), "Id qui rem.", "bbb4132c-135f-4732-9cbd-dc1db6f1c273", true }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "CreatedAt", "FeedbackId", "Text", "UserId" },
                values: new object[,]
                {
                    { 59, new DateTime(2018, 8, 9, 9, 35, 12, 838, DateTimeKind.Local), 45, "Qui et facilis deleniti consequuntur ut.", "47a110d6-9eea-4f04-aaad-8c4702502cf0" },
                    { 57, new DateTime(2018, 8, 8, 15, 19, 25, 495, DateTimeKind.Local), 44, "Architecto amet odio ut sit.", "d674f676-006b-45d0-8e4b-fddb165f324d" },
                    { 55, new DateTime(2018, 8, 8, 13, 2, 36, 962, DateTimeKind.Local), 42, "Exercitationem sit distinctio ut ex doloremque omnis totam doloremque necessitatibus.", "b3f709f1-76e9-4a8a-a907-5872dd61a9aa" },
                    { 51, new DateTime(2018, 8, 8, 14, 23, 49, 238, DateTimeKind.Local), 49, "Ut minus molestias et voluptatem.", "832cfb2b-2267-46a5-9234-bcc04d746cc2" },
                    { 58, new DateTime(2018, 8, 8, 19, 48, 48, 967, DateTimeKind.Local), 46, "Impedit iure fugit fugiat omnis iste sed.", "832cfb2b-2267-46a5-9234-bcc04d746cc2" },
                    { 56, new DateTime(2018, 8, 9, 4, 12, 8, 106, DateTimeKind.Local), 43, "Corrupti deleniti dolores reprehenderit odit.", "c5bf65ed-8850-4ce1-87bf-64501cf5fb16" },
                    { 60, new DateTime(2018, 8, 8, 14, 38, 46, 6, DateTimeKind.Local), 41, "Corporis eos inventore.", "f1b165f2-d721-46a9-a125-123a0ce75ae6" }
                });

            migrationBuilder.InsertData(
                table: "Charts",
                columns: new[] { "Id", "DashboardId", "MostLoaded", "ShowCommon", "Source", "Threshold", "Type" },
                values: new object[,]
                {
                    { 107, 96, "MostLoaded3", "Common1", "Source2", 53, 2 },
                    { 108, 96, "MostLoaded3", "Common2", "Source1", 76, 0 },
                    { 103, 91, "MostLoaded3", "Common1", "Source3", 19, 0 },
                    { 109, 100, "MostLoaded1", "Common2", "Source1", 88, 0 },
                    { 110, 100, "MostLoaded1", "Common1", "Source2", 75, 1 },
                    { 104, 97, "MostLoaded3", "Common1", "Source2", 81, 0 },
                    { 101, 94, "MostLoaded2", "Common1", "Source3", 73, 0 },
                    { 102, 94, "MostLoaded3", "Common3", "Source1", 87, 0 },
                    { 105, 94, "MostLoaded2", "Common1", "Source2", 98, 0 },
                    { 106, 94, "MostLoaded2", "Common3", "Source3", 50, 2 }
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
                keyValue: 27);

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
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 99);

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
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 85);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NotificationSettings",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 77);

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
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "2b845974-2152-4b79-8f5f-3c1a14fd1745", 71 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "47a110d6-9eea-4f04-aaad-8c4702502cf0", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "832cfb2b-2267-46a5-9234-bcc04d746cc2", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "b3f709f1-76e9-4a8a-a907-5872dd61a9aa", 78 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "bbb4132c-135f-4732-9cbd-dc1db6f1c273", 79 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "c5bf65ed-8850-4ce1-87bf-64501cf5fb16", 75 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "d674f676-006b-45d0-8e4b-fddb165f324d", 72 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "db4d1e02-a2ca-4945-9b56-d862b806c76e", 73 });

            migrationBuilder.DeleteData(
                table: "UserOrganizations",
                keyColumns: new[] { "UserId", "OrganizationId" },
                keyValues: new object[] { "f1b165f2-d721-46a9-a125-123a0ce75ae6", 74 });

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
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 97);

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
                keyValue: 42);

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
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 89);

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
                keyValue: 6);

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
                keyValue: 71);

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
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2b845974-2152-4b79-8f5f-3c1a14fd1745");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b3f709f1-76e9-4a8a-a907-5872dd61a9aa");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bbb4132c-135f-4732-9cbd-dc1db6f1c273");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "db4d1e02-a2ca-4945-9b56-d862b806c76e");

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
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Instances",
                keyColumn: "Id",
                keyValue: 90);

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
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0b93269e-eeac-4099-b0dd-bfa7d3ca1ebb");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "47a110d6-9eea-4f04-aaad-8c4702502cf0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "832cfb2b-2267-46a5-9234-bcc04d746cc2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c5bf65ed-8850-4ce1-87bf-64501cf5fb16");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d674f676-006b-45d0-8e4b-fddb165f324d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f1b165f2-d721-46a9-a125-123a0ce75ae6");

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 79);

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
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 70);
        }
    }
}
