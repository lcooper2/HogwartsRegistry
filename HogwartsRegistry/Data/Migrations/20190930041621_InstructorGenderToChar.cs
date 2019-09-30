using Microsoft.EntityFrameworkCore.Migrations;

namespace HogwartsRegistry.Data.Migrations
{
    public partial class InstructorGenderToChar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Instructors",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Instructors",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
