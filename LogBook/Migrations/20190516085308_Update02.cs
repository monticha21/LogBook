using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBook.Migrations
{
    public partial class Update02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeWardArruve",
                table: "DivisionVisits",
                newName: "TimeWardArrive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeWardArrive",
                table: "DivisionVisits",
                newName: "TimeWardArruve");
        }
    }
}
