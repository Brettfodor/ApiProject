﻿using Microsoft.EntityFrameworkCore;
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
                    new Album(1, "East Atlanta Santa", "./images/east-atlanta-santa.png", "label", 1),
                    new Album(2, "Blink 182", "./images/blink182.jpg", "label",2)
                );




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
                    new Song(15, "One Day At a Time ", "link", "2:29", 1),

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
                    new Song(29, "I'm Lost Without You", "link", "6:22", 2)
                    );

            modelBuilder.Entity<Artist>().HasData(
                    new Artist(1, "Gucci Mane", "./images/gucci-mane.jpg"),
                    new Artist(2, "Blink 182", "./images/gucci-mane.jpg")
                    );
            base.OnModelCreating(modelBuilder);
        }

            

    }

    }
        
