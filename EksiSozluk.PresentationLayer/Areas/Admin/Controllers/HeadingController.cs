using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HeadingController : Controller
    {
        private readonly IHeadingService _headingService;

        public HeadingController(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public IActionResult Index()
        {
            var values = _headingService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddHeading()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHeading(Heading heading)
        {
            _headingService.TInsert(heading);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHeading(int id)
        {
            var value = _headingService.TGetById(id);
            _headingService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
