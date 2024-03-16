using Api.Abstractions;
using APi.Abstractions;
using Domain.Models;
using dotnetmastery8net.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }

}