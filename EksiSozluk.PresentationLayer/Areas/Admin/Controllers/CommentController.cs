using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly IContentService _contentService;

        public CommentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        public IActionResult Index()
        {
            var values = _contentService.TGetList();
            return View(values);
        }
    }
}
