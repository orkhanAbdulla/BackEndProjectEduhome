using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class ChangeTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(155)",
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<int>(
                name: "TeamLeader",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Language",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Innovation",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Development",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Design",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Communication",
                table: "TeacherDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Teachers",
                type: "nvarchar(155)",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeamLeader",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Innovation",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Development",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Design",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Communication",
                table: "TeacherDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
