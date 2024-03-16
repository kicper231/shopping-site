using APi.Abstractions;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
      //  Category GetCategory(int id);
        void AddCategory(Category category);

        

    }
    public class CategoryService: ICategoryService
    {
      public ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

      
        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);

        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories = _categoryRepository.AllCategories();
            return categories;
        }


    }
}
