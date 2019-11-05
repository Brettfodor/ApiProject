using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class changedalbumseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/images/east-atlanta-santa.png");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "/images/blink182.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "/images/poison.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "/images/fmc.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./images/east-atlanta-santa.png");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./images/blink182.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./images/poison.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./images/fmc.png");
        }
    }
}
