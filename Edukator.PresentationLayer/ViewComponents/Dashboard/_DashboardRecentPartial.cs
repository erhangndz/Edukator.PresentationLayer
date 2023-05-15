using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardRecentPartial: ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public _DashboardRecentPartial(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseRegisterService.TCourseRegistersListwithCoursesandUsers();
            return View(values);
        }
    }
}
