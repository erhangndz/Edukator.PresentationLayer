using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardLast5CoursePartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _DashboardLast5CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetLast5Course();

            return View(values);
        }
    }
}
