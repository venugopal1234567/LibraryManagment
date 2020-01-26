using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Percistance.Migrations
{
    public partial class addedFineColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fine",
                table: "BorrowRecords",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fine",
                table: "BorrowRecords");
        }
    }
}
