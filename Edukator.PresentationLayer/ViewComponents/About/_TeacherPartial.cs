using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _TeacherPartial:ViewComponent
    {
        private readonly ITeacherService _teacherservice;

        public _TeacherPartial(ITeacherService teacherservice)
        {
            _teacherservice = teacherservice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teacherservice.TGetList();
            return View(values);
        }
    }
}
