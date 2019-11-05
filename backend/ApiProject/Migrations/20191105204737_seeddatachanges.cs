using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProject.Migrations
{
    public partial class seeddatachanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Image", "Name" },
                values: new object[,]
                {
                    { 3, "/images/bfmv.jpg", "Bullet For My Valentine" },
                    { 4, "/images/Tom.jpg", "Tom Petty" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "Link", "Time", "Title" },
                values: new object[] { 30, 2, "link", "2:22", "Intro" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[] { 3, 3, "./images/poison.jpg", "label", "The Poison" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[] { 4, 4, "./images/fmc.png", "label", "Full Moon Fever" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "Link", "Time", "Title" },
                values: new object[,]
                {
                    { 31, 3, "link", "4:17", "Her Voice Resides" },
                    { 52, 4, "link", "2:00", "Alright For Now" },
                    { 51, 4, "link", "2:31", "The Apartment Song" },
                    { 50, 4, "link", "2:47", "Depending On You" },
                    { 49, 4, "link", "3:05", "Yer So Bad" },
                    { 48, 4, "link", "2:47", "I'll Feel a Whole Lot Better" },
                    { 47, 4, "link", "4:23", "Runnin' Down a Dream" },
                    { 46, 4, "link", "3:58", "A Face In The Crowd" },
                    { 45, 4, "link", "4:06", "Love Is a Long Road" },
                    { 44, 4, "link", "2:56", "I Won't Back Down" },
                    { 43, 4, "link", "4:14", "Free Fallin" },
                    { 42, 3, "link", "6:48", "The End" },
                    { 41, 3, "link", "4:08", "Spit You Out" },
                    { 40, 3, "link", "3:56", "Cries in Vain" },
                    { 39, 3, "link", "3:55", "10 Years Today" },
                    { 38, 3, "link", "3:39", "The Poison" },
                    { 37, 3, "link", "4:01", "Room 409" },
                    { 36, 3, "link", "3:45", "All these Things I Hate" },
                    { 35, 3, "link", "3:30", "Hit The Floor" },
                    { 34, 3, "link", "3:35", "Suffocating Under Words of Sorrow" },
                    { 33, 3, "link", "5:48", "Tears Don't Fall" },
                    { 32, 3, "link", "3:43", "4 Words" },
                    { 53, 4, "link", "3:29", "A Mind with a Heart of Its Own" },
                    { 54, 4, "link", "2:56", "Zombie Zoo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./images/gucci-mane.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./images/gucci-mane.jpg");
        }
    }
}
