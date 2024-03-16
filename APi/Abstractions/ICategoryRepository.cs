using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi.Abstractions
{
    public interface ICategoryRepository
    {
        public List<Category> AllCategories();
        public Category GetById(string Id);
        public void Add(Category category);

        
    }
}
