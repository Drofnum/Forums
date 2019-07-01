using Microsoft.EntityFrameworkCore.Migrations;

namespace Forums.Data.Migrations
{
    public partial class PostService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImageurl",
                table: "AspNetUsers",
                newName: "ProfileImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "UserDescription",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserDescription",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                newName: "ProfileImageurl");
        }
    }
}
