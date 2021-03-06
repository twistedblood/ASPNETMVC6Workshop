﻿using Microsoft.Data.Entity;
using System;

namespace DatabaseCodeFirst.Models
{
    public class MoviesDB :DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MoviesDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(options);
        }

    }
}