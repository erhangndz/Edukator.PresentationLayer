using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
