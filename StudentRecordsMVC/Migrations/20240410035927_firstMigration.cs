using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRecordsMVC.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderType",
                table: "Students",
                newName: "Gender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Students",
                newName: "GenderType");
        }
    }
}
