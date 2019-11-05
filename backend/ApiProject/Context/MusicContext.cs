using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Models;

namespace ApiProject.Context
{
    public class MusicContext : DbContext
    {


        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ApiProject;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
                          //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                    new Album(1, "East Atlanta Santa", "/images/east-atlanta-santa.png", "label", 1),
                    new Album(2, "Blink 182", "/images/blink182.jpg", "label",2),
                    new Album(3, "The Poison", "/images/poison.jpg", "label",3),
                    new Album(4, "Full Moon Fever", "/images/fmc.png", "label",4)
                );

            modelBuilder.Entity<Song>().HasData(
                //gucci mane, East Atlanta santa song list
                    new Song(1, "Don't Count Me Out","link", "2:55", 1),
                    new Song(2, "Dope Money", "link", "4:53", 1),
                    new Song(3, "Extra", "link", "2:56", 1),
                    new Song(4, "Put Yourself In The Shoes", "link", "3:14", 1),
                    new Song(5, "Go", "link", "3:36", 1),
                    new Song(6, "Maybe It's the Juice", "link", "3:12", 1),
                    new Song(7, "That Ever Lived", "link", "2:44", 1),
                    new Song(8, "Dead People", "link", "3:02", 1),
                    new Song(9, "Medication", "link", "3:12", 1),
                    new Song(10, "Odd Ball", "link", "3:57", 1),
                    new Song(11, "One Min", "link", "3:21", 1),
                    new Song(12, "Riding Dirty", "link", "3:03", 1),
                    new Song(13, "With My Pistol", "link", "2:28", 1),
                    new Song(14, "Trappin Out the Mansion", "link", "3:39", 1),
                    new Song(15, "One Day At a Time ", "link", "2:29", 1),

                //blink182, blink182 song list
                    new Song(16, "Feeling This", "link", "2:53", 2),
                    new Song(17, "Obvious", "link", "2:43", 2),
                    new Song(18, "I Miss You", "link", "3:47", 2),
                    new Song(19, "Violence", "link", "5:20", 2),
                    new Song(20, "Stockholm Syndrome", "link", "2:42", 2),
                    new Song(21, "Down", "link", "3:03", 2),
                    new Song(22, "The Fallen Interlude", "link", "2:13", 2),
                    new Song(23, "Go", "link", "1:53", 2),
                    new Song(24, "Asthenia", "link", "4:20", 2),
                    new Song(25, "Always", "link", "4:12", 2),
                    new Song(26, "Easy Target", "link", "2:20", 2),
                    new Song(27, "All Of This", "link", "4:40", 2),
                    new Song(28, "Here's Your Letter", "link", "4:55", 2),
                    new Song(29, "I'm Lost Without You", "link", "6:22", 2),

                //Bullet For My Valentine, The Poison song list
                    new Song(30, "Intro", "link", "2:22", 2),
                    new Song(31, "Her Voice Resides", "link", "4:17", 3),
                    new Song(32, "4 Words", "link", "3:43", 3),
                    new Song(33, "Tears Don't Fall", "link", "5:48", 3),
                    new Song(34, "Suffocating Under Words of Sorrow", "link", "3:35", 3),
                    new Song(35, "Hit The Floor", "link", "3:30", 3),
                    new Song(36, "All these Things I Hate", "link", "3:45", 3),
                    new Song(37, "Room 409", "link", "4:01", 3),
                    new Song(38, "The Poison", "link", "3:39", 3),
                    new Song(39, "10 Years Today", "link", "3:55", 3),
                    new Song(40, "Cries in Vain", "link", "3:56", 3),
                    new Song(41, "Spit You Out", "link", "4:08", 3),
                    new Song(42, "The End", "link", "6:48", 3),

                //Tom Petty, Full Moon Fever song list
                    new Song(43, "Free Fallin", "link", "4:14", 4),
                    new Song(44, "I Won't Back Down", "link", "2:56", 4),
                    new Song(45, "Love Is a Long Road", "link", "4:06", 4),
                    new Song(46, "A Face In The Crowd", "link", "3:58", 4),
                    new Song(47, "Runnin' Down a Dream", "link", "4:23", 4),
                    new Song(48, "I'll Feel a Whole Lot Better", "link", "2:47", 4),
                    new Song(49, "Yer So Bad", "link", "3:05", 4),
                    new Song(50, "Depending On You", "link", "2:47", 4),
                    new Song(51, "The Apartment Song", "link", "2:31", 4),
                    new Song(52, "Alright For Now", "link", "2:00", 4),
                    new Song(53, "A Mind with a Heart of Its Own", "link", "3:29", 4),
                    new Song(54, "Zombie Zoo", "link", "2:56", 4)
                    );

            modelBuilder.Entity<Artist>().HasData(
                    new Artist(1, "Gucci Mane", "/images/gucci-mane.jpg"),
                    new Artist(2, "Blink 182", "/images/gucci-mane.jpg"),
                    new Artist(3, "Bullet For My Valentine", "/images/bfmv.jpg"),
                    new Artist(4, "Tom Petty", "/images/Tom.jpg")
                    );
            base.OnModelCreating(modelBuilder);
        }
            
    }

    }
        
