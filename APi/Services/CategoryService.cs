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
        Category GetCategory(int id);
        void AddCategory(Category category);
        void DeleteCategory(int id);
        void UpdateCategory(Category category);



    }
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);
            _categoryRepository.Save();

        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Remove(_categoryRepository.Get(t => t.Id == id));
            _categoryRepository.Save();

        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = _categoryRepository.GetAll().ToList();
            return categories;
        }

        public Category GetCategory(int id)
        {
            return _categoryRepository.Get(t=>t.Id == id);


        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);

        }

        public void Save()
        {
            _categoryRepository.Save();
        }
        
    }
}
