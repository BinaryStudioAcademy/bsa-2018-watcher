using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedRelationNotificationToSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_UserId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_UserId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Chats");

            migrationBuilder.AddColumn<int>(
                name: "NotificationSettingId",
                table: "Notifications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationSettingId",
                table: "Notifications",
                column: "NotificationSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications",
                column: "NotificationSettingId",
                principalTable: "NotificationSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_NotificationSettings_NotificationSettingId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_NotificationSettingId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "NotificationSettingId",
                table: "Notifications");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Chats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_UserId",
                table: "Chats",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
