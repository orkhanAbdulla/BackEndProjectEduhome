using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class CreateDetailCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutCourse = table.Column<string>(nullable: true),
                    HowToApply = table.Column<string>(nullable: true),
                    Starts = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ClassDuration = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Students = table.Column<int>(nullable: false),
                    Assesments = table.Column<string>(nullable: true),
                    CourseFee = table.Column<string>(maxLength: 155, nullable: false),
                    Certification = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailCourses_CourseId",
                table: "DetailCourses",
                column: "CourseId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailCourses");
        }
    }
}
