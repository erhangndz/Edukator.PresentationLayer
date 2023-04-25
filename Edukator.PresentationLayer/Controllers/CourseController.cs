using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var values = _courseService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(Course p)
        {
            _courseService.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(int id)
        {
            var values = _courseService.TGetByID(id);
            _courseService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            var values = _courseService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course p)
        {
            _courseService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
