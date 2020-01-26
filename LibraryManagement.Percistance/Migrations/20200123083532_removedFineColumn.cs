using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Percistance.Migrations
{
    public partial class removedFineColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fine",
                table: "BorrowRecords");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fine",
                table: "BorrowRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
