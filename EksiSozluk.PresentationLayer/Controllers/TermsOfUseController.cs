using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class TermsOfUseController : Controller
    {
        private readonly ITermsOfUseService _termsOfUseService;

        public TermsOfUseController(ITermsOfUseService termsOfUseService)
        {
            _termsOfUseService = termsOfUseService;
        }

        public IActionResult Index()
        {
            var values = _termsOfUseService.TGetList();
            return View(values);
        }
    }
}
