using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _approle;

        public RoleController(RoleManager<AppRole> approle)
        {
            _approle = approle;
        }

        public IActionResult Index()
        {
            var values = _approle.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddRole(AppRole p)
        {
            var result= await _approle.CreateAsync(p);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value= _approle.Roles.FirstOrDefault(x => x.Id == id);
            await _approle.DeleteAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values= _approle.Roles.FirstOrDefault(x=>x.Id == id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(AppRole p)
        {
            var values= _approle.Roles.FirstOrDefault(x => x.Id == p.Id);
            values.Name= p.Name;
            await _approle.UpdateAsync(values);
            return RedirectToAction("Index");
        }
    }
}
