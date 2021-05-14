using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class ChangeTableCourseDetailColumnStarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Starts",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillLevel",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClassDuration",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Assesments",
                table: "DetailCourses",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Starts",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "SkillLevel",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "ClassDuration",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "Assesments",
                table: "DetailCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 155);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
