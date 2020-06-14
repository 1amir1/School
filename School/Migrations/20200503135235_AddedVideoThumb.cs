using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class AddedVideoThumb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbUrl",
                table: "GalleryVideos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbUrl",
                table: "GalleryVideos");
        }
    }
}
