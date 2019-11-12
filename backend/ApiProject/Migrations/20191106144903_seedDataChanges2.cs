using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class seedDataChanges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./css/images/gucci-mane.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./css/images/gucci-mane.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./css/images/bfmv.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./css/images/Tom.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "/images/gucci-mane.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "/images/gucci-mane.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "/images/bfmv.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "/images/Tom.jpg");
        }
    }
}
