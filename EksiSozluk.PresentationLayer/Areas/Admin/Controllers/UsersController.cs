using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        

        public IActionResult Index()
        { 
            return View();
        }

     
        //public IActionResult UserProfile(int id)
        //{
        //    var value = _writerService.TGetById(id);
        //    return View(value);
        //}
    }
}
