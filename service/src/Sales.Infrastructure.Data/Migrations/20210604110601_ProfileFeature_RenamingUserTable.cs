using Microsoft.EntityFrameworkCore.Migrations;

namespace Sales.Infrastructure.Data.Migrations
{
    public partial class ProfileFeature_RenamingUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_UserBase_Id",
                table: "Administrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_UserBase_Id",
                table: "Supervisor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBase",
                table: "UserBase");

            migrationBuilder.RenameTable(
                name: "UserBase",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_User_Id",
                table: "Administrator",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_User_Id",
                table: "Supervisor",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_User_Id",
                table: "Administrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_User_Id",
                table: "Supervisor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserBase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBase",
                table: "UserBase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_UserBase_Id",
                table: "Administrator",
                column: "Id",
                principalTable: "UserBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_UserBase_Id",
                table: "Supervisor",
                column: "Id",
                principalTable: "UserBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
