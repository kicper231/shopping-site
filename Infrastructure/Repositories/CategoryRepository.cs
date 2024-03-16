using APi.Abstractions;
using Domain.Models;
using dotnetmastery8net.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public List<Category> AllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetById(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
