using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EDUHOME.Migrations
{
    public partial class ChangesTableDetailCourseColumnStarts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Starts",
                table: "DetailCourses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 155);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Starts",
                table: "DetailCourses",
                type: "datetime2",
                maxLength: 155,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
