using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class AddColumnIsDeletedToTableCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Courses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Courses");
        }
    }
}
