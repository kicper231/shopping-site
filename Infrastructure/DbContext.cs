﻿
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetmastery8net.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<Category>().HasData(
               new Category { Id = 1,Name="Polish",DisplayOrder=3},
               new Category { Id = 2, Name = "History", DisplayOrder = 2 },
               new Category { Id = 3, Name = "Math", DisplayOrder = 1 }
               );

        }
    }
}
