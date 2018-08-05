using Microsoft.EntityFrameworkCore.Migrations;

namespace Watcher.DataAccess.Data.Migrations
{
    public partial class AddedNavigationPropertiesToUserAndOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganization_Organizations_OrganizationId",
                table: "UserOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganization_Users_UserId",
                table: "UserOrganization");

            migrationBuilder.DropIndex(
                name: "IX_Chats_OrganizationId",
                table: "Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganization",
                table: "UserOrganization");

            migrationBuilder.RenameTable(
                name: "UserOrganization",
                newName: "UserOrganizations");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganization_OrganizationId",
                table: "UserOrganizations",
                newName: "IX_UserOrganizations_OrganizationId");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "Chats",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganizations",
                table: "UserOrganizations",
                columns: new[] { "UserId", "OrganizationId" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_OrganizationId",
                table: "Chats",
                column: "OrganizationId",
                unique: true,
                filter: "[OrganizationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_UserId",
                table: "Chats",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_Organizations_OrganizationId",
                table: "UserOrganizations",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganizations_Users_UserId",
                table: "UserOrganizations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_UserId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganizations_Organizations_OrganizationId",
                table: "UserOrganizations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrganizations_Users_UserId",
                table: "UserOrganizations");

            migrationBuilder.DropIndex(
                name: "IX_Chats_OrganizationId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_UserId",
                table: "Chats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganizations",
                table: "UserOrganizations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Chats");

            migrationBuilder.RenameTable(
                name: "UserOrganizations",
                newName: "UserOrganization");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizations_OrganizationId",
                table: "UserOrganization",
                newName: "IX_UserOrganization_OrganizationId");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "Chats",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganization",
                table: "UserOrganization",
                columns: new[] { "UserId", "OrganizationId" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_OrganizationId",
                table: "Chats",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_CreatedById",
                table: "Chats",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganization_Organizations_OrganizationId",
                table: "UserOrganization",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrganization_Users_UserId",
                table: "UserOrganization",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
