using EksiSozluk.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class UserController : Controller
    {
       Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }
    }
}
