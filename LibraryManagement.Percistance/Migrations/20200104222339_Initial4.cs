using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Percistance.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowRecord_LibraryUsers_UsersId",
                table: "BorrowRecord");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "BorrowRecord",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowRecord_LibraryUsers_UsersId",
                table: "BorrowRecord",
                column: "UsersId",
                principalTable: "LibraryUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowRecord_LibraryUsers_UsersId",
                table: "BorrowRecord");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "BorrowRecord",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowRecord_LibraryUsers_UsersId",
                table: "BorrowRecord",
                column: "UsersId",
                principalTable: "LibraryUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
