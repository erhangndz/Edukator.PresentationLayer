using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ICategoryService _categoryService;
        private readonly IAboutService _aboutService;

        public CourseController(ICourseService courseService, ICategoryService categoryService, IAboutService aboutService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _courseService.TGetCoursesWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()

                                           }).ToList();
            ViewBag.v = values;                           
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
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()

                                           }).ToList();
            ViewBag.v = values;
            var value = _courseService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course p)
        {
            _courseService.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult Courses()
        {
             return View();
        }

        
    }
}
