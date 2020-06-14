using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class Migration27041431 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Groups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Groups");
        }
    }
}
