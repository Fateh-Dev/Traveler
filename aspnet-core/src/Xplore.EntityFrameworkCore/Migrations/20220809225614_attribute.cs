using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xplore.Migrations
{
    public partial class attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailPic",
                table: "Xplore.Trip",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailPic",
                table: "Xplore.Trip");
        }
    }
}
