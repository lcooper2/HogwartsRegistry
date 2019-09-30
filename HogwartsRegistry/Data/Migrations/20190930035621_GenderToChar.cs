using Microsoft.EntityFrameworkCore.Migrations;

namespace HogwartsRegistry.Data.Migrations
{
    public partial class GenderToChar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Students",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
