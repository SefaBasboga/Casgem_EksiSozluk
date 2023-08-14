﻿using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddHeading()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }
    }
}
