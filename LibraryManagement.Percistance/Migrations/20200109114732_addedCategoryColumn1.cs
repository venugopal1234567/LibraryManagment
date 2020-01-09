using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Percistance.Migrations
{
    public partial class addedCategoryColumn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategory_BookCategoriesId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory");

            migrationBuilder.RenameTable(
                name: "BookCategory",
                newName: "BookCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategories_BookCategoriesId",
                table: "Books",
                column: "BookCategoriesId",
                principalTable: "BookCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_BookCategoriesId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "BookCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategory_BookCategoriesId",
                table: "Books",
                column: "BookCategoriesId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
