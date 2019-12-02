using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HogwartsRegistry.Data.Migrations
{
    public partial class courseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Courses",
                newName: "DepartmentPrefix");

            migrationBuilder.RenameColumn(
                name: "CRN",
                table: "Courses",
                newName: "CourseNum");

            migrationBuilder.AddColumn<string>(
                name: "CourseTitle",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseTitle",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "DepartmentPrefix",
                table: "Courses",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "CourseNum",
                table: "Courses",
                newName: "CRN");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
