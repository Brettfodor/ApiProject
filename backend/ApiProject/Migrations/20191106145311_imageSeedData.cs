using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class imageSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/east-atlanta-santa.png");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/blink182.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./css/images/poison.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./css/images/fmc.png");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/blink182.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/gucci-mane.jpg");
        }
    }
}
