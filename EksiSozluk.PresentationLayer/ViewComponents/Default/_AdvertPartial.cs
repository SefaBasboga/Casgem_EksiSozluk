using Microsoft.AspNetCore.Mvc;

namespace EksiSozluk.PresentationLayer.ViewComponents.Default
{
    public class _AdvertPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
