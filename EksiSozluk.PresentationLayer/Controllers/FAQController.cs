using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class FAQController : Controller
    {
        private readonly IFAQService _FAQService;

        public FAQController(IFAQService fAQService)
        {
            _FAQService = fAQService;
        }

        public IActionResult Index()
        {
            var values = _FAQService.TGetList();
            return View(values);
        }
    }
}
