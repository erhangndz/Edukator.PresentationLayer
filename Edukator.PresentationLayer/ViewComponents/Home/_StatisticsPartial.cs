using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Home
{
    public class _StatisticsPartial:ViewComponent
    {
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Categories.Count();
            ViewBag.v2 = c.Courses.Count();
            ViewBag.v3 = 684;

            return View();
        }
    }
}
