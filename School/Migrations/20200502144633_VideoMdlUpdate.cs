using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class VideoMdlUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DbName",
                table: "GalleryVideos",
                newName: "VideoUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoUrl",
                table: "GalleryVideos",
                newName: "DbName");
        }
    }
}
