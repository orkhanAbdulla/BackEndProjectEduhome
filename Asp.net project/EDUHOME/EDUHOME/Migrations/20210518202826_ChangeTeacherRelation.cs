using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class ChangeTeacherRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSocial");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Teachers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Socials",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socials_Teachers_TeacherId",
                table: "Socials");

            migrationBuilder.DropIndex(
                name: "IX_Socials_TeacherId",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Socials");

            migrationBuilder.CreateTable(
                name: "TeacherSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
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
    }
}
