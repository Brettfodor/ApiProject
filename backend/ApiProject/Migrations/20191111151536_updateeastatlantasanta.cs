using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class updateeastatlantasanta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/east-atlanta-santa.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/east-atlanta-santa.png");
        }
    }
}
