using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Percistance.Migrations
{
    public partial class addedCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCategoriesId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoriesId",
                table: "Books",
                column: "BookCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategory_BookCategoriesId",
                table: "Books",
                column: "BookCategoriesId",
                principalTable: "BookCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategory_BookCategoriesId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCategoriesId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookCategoriesId",
                table: "Books");
        }
    }
}
