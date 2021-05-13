using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class ChangeCreateTableTeacherDetailAndSicialCreateTableTeacherSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_Teachers_TeacherId",
                table: "Socials");

            migrationBuilder.DropIndex(
                name: "IX_Socials_TeacherId",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Socials");

            migrationBuilder.CreateTable(
                name: "TeacherSocial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    SocialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSocial_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSocial_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSocial_SocialId",
                table: "TeacherSocial",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSocial_TeacherId",
                table: "TeacherSocial",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSocial");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Socials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Socials_TeacherId",
                table: "Socials",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_Teachers_TeacherId",
                table: "Socials",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
