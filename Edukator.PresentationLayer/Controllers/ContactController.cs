using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
           var values= _contactService.TGetByID(id);
            _contactService.TDelete(values);
            return RedirectToAction("Index");
        }
        
        public IActionResult GetMessage(int id)
        {
            var values = _contactService.TGetByID(id);
            return View(values);
        }

        public IActionResult Contacts() 
        {
        return View();
        }

        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessagePartial(Contact p)
        {
            _contactService.TInsert(p);
            return RedirectToAction("Contacts");
        }
    }
}

