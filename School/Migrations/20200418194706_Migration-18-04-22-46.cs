using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class Migration18042246 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_UsrId",
                table: "Reviews");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UsrId",
                table: "Reviews",
                column: "UsrId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_UsrId",
                table: "Reviews");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UsrId",
                table: "Reviews",
                column: "UsrId");
        }
    }
}
