using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
	public class SweetAlertController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
