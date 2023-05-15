using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardStatisticsPartial: ViewComponent
    {
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.totalcoursecount = c.Courses.Count();
            ViewBag.totalcoursecategory = c.Categories.Count();
            ViewBag.totalmembercount = c.Users.Count();
            ViewBag.messageboxcount = c.Contacts.Count();

            return View();
        }
    }
}
