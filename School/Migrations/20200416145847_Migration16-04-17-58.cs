using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class Migration16041758 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GroupTeachers_TeachId",
                table: "GroupTeachers");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_GroupTeachers_TeachId",
                table: "GroupTeachers",
                column: "TeachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GroupTeachers_TeachId",
                table: "GroupTeachers");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[] { 3, "Преподаватель" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupTeachers_TeachId",
                table: "GroupTeachers",
                column: "TeachId",
                unique: true);
        }
    }
}
