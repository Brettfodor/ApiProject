using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Image", "Name" },
                values: new object[] { 2, "./images/gucci-mane.jpg", "Blink 182" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: "2:55");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "Link", "Time", "Title" },
                values: new object[,]
                {
                    { 2, 1, "link", "4:53", "Dope Money" },
                    { 3, 1, "link", "2:56", "Extra" },
                    { 4, 1, "link", "3:14", "Put Yourself In The Shoes" },
                    { 5, 1, "link", "3:36", "Go" },
                    { 6, 1, "link", "3:12", "Maybe It's the Juice" },
                    { 7, 1, "link", "2:44", "That Ever Lived" },
                    { 8, 1, "link", "3:02", "Dead People" },
                    { 9, 1, "link", "3:12", "Medication" },
                    { 10, 1, "link", "3:57", "Odd Ball" },
                    { 11, 1, "link", "3:21", "One Min" },
                    { 12, 1, "link", "3:03", "Riding Dirty" },
                    { 13, 1, "link", "2:28", "With My Pistol" },
                    { 14, 1, "link", "3:39", "Trappin Out the Mansion" },
                    { 15, 1, "link", "2:29", "One Day At a Time " }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[] { 2, 2, "./images/blink182.jpg", "label", "Blink 182" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "Link", "Time", "Title" },
                values: new object[,]
                {
                    { 16, 2, "link", "2:53", "Feeling This" },
                    { 17, 2, "link", "2:43", "Obvious" },
                    { 18, 2, "link", "3:47", "I Miss You" },
                    { 19, 2, "link", "5:20", "Violence" },
                    { 20, 2, "link", "2:42", "Stockholm Syndrome" },
                    { 21, 2, "link", "3:03", "Down" },
                    { 22, 2, "link", "2:13", "The Fallen Interlude" },
                    { 23, 2, "link", "1:53", "Go" },
                    { 24, 2, "link", "4:20", "Asthenia" },
                    { 25, 2, "link", "4:12", "Always" },
                    { 26, 2, "link", "2:20", "Easy Target" },
                    { 27, 2, "link", "4:40", "All Of This" },
                    { 28, 2, "link", "4:55", "Here's Your Letter" },
                    { 29, 2, "link", "6:22", "I'm Lost Without You" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: "time");
        }
    }
}
