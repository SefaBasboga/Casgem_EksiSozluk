using EksiSozluk.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace EksiSozluk.PresentationLayer.ViewComponents.Default
{
    public class _SidebarPartial : ViewComponent
    {
        private readonly IHeadingService _headingService;
        public _SidebarPartial(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public IViewComponentResult Invoke(int categoryId=1)
        {
            var headings = _headingService.GetListByCategory(categoryId);
            return View(headings);
        }
    }
}
