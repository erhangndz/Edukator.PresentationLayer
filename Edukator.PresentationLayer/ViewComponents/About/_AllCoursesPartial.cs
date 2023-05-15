using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AllCoursesPartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _AllCoursesPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _courseService.TGetCoursesWithCategories();
            return View(values);
        }
    }
}
