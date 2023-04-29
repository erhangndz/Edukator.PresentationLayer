using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService _contactinfoservice;

        public ContactInfoController(IContactInfoService contactinfoservice)
        {
            _contactinfoservice = contactinfoservice;
        }

        public IActionResult Index()
        {
            var values= _contactinfoservice.TGetList();
            return View(values);
        }

        public IActionResult DeleteContactInfo(int id)
        {
            var values = _contactinfoservice.TGetByID(id);
            _contactinfoservice.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContactInfo(int id) 
        {
            var values = _contactinfoservice.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfo p)
        {
            
            _contactinfoservice.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddContactInfo(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContactInfo(ContactInfo p)
        {
            _contactinfoservice.TInsert(p);
            return RedirectToAction("Index");
        }

    }
}
