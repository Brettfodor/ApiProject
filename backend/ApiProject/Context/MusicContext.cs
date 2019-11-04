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
            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                    new Album(1, "East Atlanta Santa", "./images/east-atlanta-santa.png", "label", 1));




            modelBuilder.Entity<Song>().HasData(
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
                    new Song(15, "One Day At a Time ", "link", "2:29", 1)
                    );

            modelBuilder.Entity<Artist>().HasData(
                    new Artist(1, "Gucci Mane", "./images/gucci-mane.jpg"));
            base.OnModelCreating(modelBuilder);
        }

            

    }

    }
        
