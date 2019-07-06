using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursery.Data.Migrations
{
    public partial class ChangingDueDatetoGeneratedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Eggs",
                newName: "GeneratedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GeneratedDate",
                table: "Eggs",
                newName: "DueDate");
        }
    }
}
