﻿
using APi.Abstractions;
using APi.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace App.Controllers
{
    
    public class CategoryController : Controller
    {

        public CategoryService _CategoryService;

        public CategoryController(CategoryService categoryService)
        {
            _CategoryService = categoryService;
        }

        public IActionResult Index()
        {
            List<Category> allcategories = _CategoryService.GetAllCategories();
            return View(allcategories);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {

            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Name cant be the same as DisplayOrder");
            }
            if (ModelState.IsValid)
            {
                
                TempData["succes"] = "Category Created!";
                _CategoryService.AddCategory(obj);
              
                return RedirectToAction("Index", "Category");
            }

            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id==null&&id==0)
            {
                return NotFound();
            }
            Category? category = _context.Categories.Find(id);

            if (category==null)
            {
                return NotFound();
            }    
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {

            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Name cant be the same as DisplayOrder");
            }
            if (ModelState.IsValid)
            {
                TempData["succes"] = "Category Edited!";
                _context.Categories.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index", "Category");
            }

            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            Category? category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost,ActionName("Delete")]

        public IActionResult DeletePost(int? id)
        {
            Category finded = _context.Categories.Find(id);
            if (finded == null)
            {
                return NotFound();
            }



            TempData["succes"] = "Category Deleted!";

            _context.Categories.Remove(finded);
                _context.SaveChanges();
                return RedirectToAction("Index", "Category");
            

          
        }
    }
}
