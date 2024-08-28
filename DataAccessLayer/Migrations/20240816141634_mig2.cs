using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Abouts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_BlogID",
                table: "Abouts",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Blogs_BlogID",
                table: "Abouts",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Blogs_BlogID",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_BlogID",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Abouts");
        }
    }
}
