using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Concrete;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IHeadingService _headingService;
        private readonly Context _context;

        public CategoryController(ICategoryService categoryService, IHeadingService headingService, Context context)
        {
            _categoryService = categoryService;
            _headingService = headingService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");

        }



        public IActionResult HeadingsByCategory(int categoryId)
        {            
            return ViewComponent("_SidebarPartial" , new {categoryId});
        }
    }
}


