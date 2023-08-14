using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        public IActionResult Index()
        {
            var values =  _policyService.TGetList();
            return View(values);
        }
    }
}
