﻿using Microsoft.EntityFrameworkCore;
using RazorDotnetMastery.Models;

namespace RazorDotnetMastery.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Polish", DisplayOrder = 3 },
                new Category { Id = 2, Name = "History", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Math", DisplayOrder = 1 }
                );

        }
    }
}
