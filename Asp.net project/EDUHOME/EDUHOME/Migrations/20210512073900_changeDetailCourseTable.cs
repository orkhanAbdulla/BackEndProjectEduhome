using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class changeDetailCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseFee",
                table: "DetailCourses");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "DetailCourses");

            migrationBuilder.AddColumn<string>(
                name: "CourseFee",
                table: "DetailCourses",
                type: "nvarchar(155)",
                maxLength: 155,
                nullable: false,
                defaultValue: "");
        }
    }
}
