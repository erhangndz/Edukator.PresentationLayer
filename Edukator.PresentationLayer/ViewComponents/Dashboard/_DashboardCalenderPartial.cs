using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardCalenderPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
