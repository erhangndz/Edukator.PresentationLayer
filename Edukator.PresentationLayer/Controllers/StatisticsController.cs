using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class StatisticsController : Controller
    {

        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.totalCategory = context.Categories.Count();
            ViewBag.totalCourse=context.Courses.Count();
            ViewBag.totalCoursePrice=context.Courses.Sum(x=>x.Price);
            ViewBag.getAlgoritmaCoursePrice= context.Courses.Where(x=>x.Title== "C# ile Algoritma ve Programlama").Select(x=>x.Price).FirstOrDefault();

            ViewBag.avgCourseReview = context.Courses.Average(x => x.Review);
            ViewBag.getOver30Price=context.Courses.Where(x=>x.Price>30).Count();
            ViewBag.lastCoursePrice=context.Courses.Where(x=>x.CourseID==8).Select(x=>x.Price).FirstOrDefault();
            ViewBag.getTitleByCourseID2=context.Courses.Where(x=>x.CategoryID==2).Select(y=>y.Title).FirstOrDefault();
            ViewBag.softwareCourseCount=context.Courses.Where(x=>x.CategoryID==(context.Categories.Where(y=>y.CategoryName=="Yazılım").Select(z=>z.CategoryID)).FirstOrDefault()).Count();

            ViewBag.maxCoursePrice = context.Courses.Max(x => x.Price);
            ViewBag.minCoursePrice=context.Courses.Min(x => x.Price);
            ViewBag.mostExpensiveCourse=context.Courses.Where(x=>x.Price==(context.Courses.Max(x=>x.Price))).Select(z=>z.Title).FirstOrDefault();
            ViewBag.lastCourseTitle=context.Courses.Where(x=>x.CourseID==(context.Courses.Max(x=>x.CourseID))).Select(x=>x.Title).FirstOrDefault();
            ViewBag.avgpriceforsoftware = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(x => x.CategoryName == "Yazılım")).Select(x => x.CategoryID).FirstOrDefault()).Average(x=>x.Price);

            ViewBag.last3coursetotalprice = context.Courses.OrderByDescending(x => x.CourseID).Take(3).Sum(x => x.Price);

            ViewBag.getCourseCategorySoftwareAndReviewOver9 = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(x => x.CategoryName == "Yazılım")).Select(x => x.CategoryID).FirstOrDefault() && x.Review >= 9).Select(x => x.Title).FirstOrDefault(); 
         
            return View();
        }
    }
}
