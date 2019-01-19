﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SportContext : DbContext
    {
        public SportContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Team team = new Team
            {
                Id = 1,
                Name = "Московские чародеи"
            };

            var player = new Player
            {
                Id = 1,
                FullName = "Михаил Лушенков",
                Number = "5",
                TeamId = team.Id
            };

            modelBuilder.Entity<Team>().HasData(team);
            modelBuilder.Entity<Player>().HasData(player);
            base.OnModelCreating(modelBuilder);
        }
    }
}
