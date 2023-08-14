using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _NavbarPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //public IViewComponentResult Invoke()
        //{
        //    var categories = _categoryService.TGetList(); // Kategorileri almak için ilgili servis metodu kullanılabilir
        //    return View(categories);
        //}


        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetActiveCategories(); // Sadece aktif kategorileri al
            return View(categories);
        }
    }
}
