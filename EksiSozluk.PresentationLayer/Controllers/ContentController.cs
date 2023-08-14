using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Concrete;
using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentService _contentService;
        Context context = new Context();
        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        public IActionResult Index()
        {
            var values = _contentService.TGetList();
            return View(values);
        }

        [HttpGet]
        public PartialViewResult AddContent(int id)
        {
            ViewBag.d = id;
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddContent(Content content)
        {
            content.ContentDate = DateTime.Parse( DateTime.Now.ToShortDateString());
            context.Contents.Add(content);
            context.SaveChanges();
            //var values = JsonConvert.SerializeObject(content);
            //return Json(values);

            //_contentService.TInsert(content);
           return RedirectToAction("Index");
        }

        public IActionResult DeleteContent(int id)
        {
            var value = _contentService.TGetById(id);
            _contentService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContent(int id)
        {
            var value = _contentService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContent(Content content)
        {
            _contentService.TUpdate(content);
            return RedirectToAction("Index");

        }

        
        public IActionResult ContentByHeading(int id = 1)
        {
            ViewBag.destID = id;
            var values = _contentService.GetListByHeadingID(id);
            return View(values);
        }
        public IActionResult ContentByHeadingWriter(int id = 0)
        {
            var values = _contentService.GetListByHeadingID(id);
            return View(values);
        }

     

    }
}
