using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _ProgressPartial:ViewComponent
    {
      private readonly ICourseService _courseService;

        public _ProgressPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _courseService.TGetList().Where(x => x.CourseID == 13).Sum(x =>  x.Price).ToString();
            ViewBag.v2 = _courseService.TGetList().Where(x => x.CourseID == 11).Sum(x => x.Price).ToString();
            ViewBag.v3 = _courseService.TGetList().Where(x => x.CourseID == 10).Sum(x => x.Price).ToString();
            ViewBag.v4 = _courseService.TGetList().Where(x => x.CourseID == 8).Sum(x => x.Price).ToString();
            ViewBag.v5 = _courseService.TGetList().Where(x => x.CourseID == 7).Sum(x => x.Price).ToString();
            var values = _courseService.TGetLast5Course();
            return View(values);
        }
    }
}
