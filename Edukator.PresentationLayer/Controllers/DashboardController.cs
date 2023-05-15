using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
