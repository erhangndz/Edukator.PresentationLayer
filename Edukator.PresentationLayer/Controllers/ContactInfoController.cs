using Edukator.BusinessLayer.Abstract;
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
    }
}
