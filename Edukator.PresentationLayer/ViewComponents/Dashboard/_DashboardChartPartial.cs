using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardChartPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
