﻿// <auto-generated />
using ApiProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProject.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20191104182459_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiProject.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID");

                    b.Property<string>("Image");

                    b.Property<string>("Label");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");

                    b.HasData(
                        new { ID = 1, ArtistID = 1, Image = "./images/east-atlanta-santa.png", Label = "label", Title = "East Atlanta Santa" },
                        new { ID = 2, ArtistID = 2, Image = "./images/blink182.jpg", Label = "label", Title = "Blink 182" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new { ID = 1, Image = "./images/gucci-mane.jpg", Name = "Gucci Mane" },
                        new { ID = 2, Image = "./images/gucci-mane.jpg", Name = "Blink 182" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID");

                    b.Property<string>("Link");

                    b.Property<string>("Time");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Songs");

                    b.HasData(
                        new { ID = 1, AlbumID = 1, Link = "link", Time = "2:55", Title = "Don't Count Me Out" },
                        new { ID = 2, AlbumID = 1, Link = "link", Time = "4:53", Title = "Dope Money" },
                        new { ID = 3, AlbumID = 1, Link = "link", Time = "2:56", Title = "Extra" },
                        new { ID = 4, AlbumID = 1, Link = "link", Time = "3:14", Title = "Put Yourself In The Shoes" },
                        new { ID = 5, AlbumID = 1, Link = "link", Time = "3:36", Title = "Go" },
                        new { ID = 6, AlbumID = 1, Link = "link", Time = "3:12", Title = "Maybe It's the Juice" },
                        new { ID = 7, AlbumID = 1, Link = "link", Time = "2:44", Title = "That Ever Lived" },
                        new { ID = 8, AlbumID = 1, Link = "link", Time = "3:02", Title = "Dead People" },
                        new { ID = 9, AlbumID = 1, Link = "link", Time = "3:12", Title = "Medication" },
                        new { ID = 10, AlbumID = 1, Link = "link", Time = "3:57", Title = "Odd Ball" },
                        new { ID = 11, AlbumID = 1, Link = "link", Time = "3:21", Title = "One Min" },
                        new { ID = 12, AlbumID = 1, Link = "link", Time = "3:03", Title = "Riding Dirty" },
                        new { ID = 13, AlbumID = 1, Link = "link", Time = "2:28", Title = "With My Pistol" },
                        new { ID = 14, AlbumID = 1, Link = "link", Time = "3:39", Title = "Trappin Out the Mansion" },
                        new { ID = 15, AlbumID = 1, Link = "link", Time = "2:29", Title = "One Day At a Time " },
                        new { ID = 16, AlbumID = 2, Link = "link", Time = "2:53", Title = "Feeling This" },
                        new { ID = 17, AlbumID = 2, Link = "link", Time = "2:43", Title = "Obvious" },
                        new { ID = 18, AlbumID = 2, Link = "link", Time = "3:47", Title = "I Miss You" },
                        new { ID = 19, AlbumID = 2, Link = "link", Time = "5:20", Title = "Violence" },
                        new { ID = 20, AlbumID = 2, Link = "link", Time = "2:42", Title = "Stockholm Syndrome" },
                        new { ID = 21, AlbumID = 2, Link = "link", Time = "3:03", Title = "Down" },
                        new { ID = 22, AlbumID = 2, Link = "link", Time = "2:13", Title = "The Fallen Interlude" },
                        new { ID = 23, AlbumID = 2, Link = "link", Time = "1:53", Title = "Go" },
                        new { ID = 24, AlbumID = 2, Link = "link", Time = "4:20", Title = "Asthenia" },
                        new { ID = 25, AlbumID = 2, Link = "link", Time = "4:12", Title = "Always" },
                        new { ID = 26, AlbumID = 2, Link = "link", Time = "2:20", Title = "Easy Target" },
                        new { ID = 27, AlbumID = 2, Link = "link", Time = "4:40", Title = "All Of This" },
                        new { ID = 28, AlbumID = 2, Link = "link", Time = "4:55", Title = "Here's Your Letter" },
                        new { ID = 29, AlbumID = 2, Link = "link", Time = "6:22", Title = "I'm Lost Without You" }
                    );
                });

            modelBuilder.Entity("ApiProject.Models.Album", b =>
                {
                    b.HasOne("ApiProject.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApiProject.Models.Song", b =>
                {
                    b.HasOne("ApiProject.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
