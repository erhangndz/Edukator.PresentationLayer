using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public IActionResult Index()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }

        public IActionResult DeleteReference(int id)
        {
            var values = _referenceService.TGetByID(id);
            _referenceService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var values = _referenceService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateReference(Reference p)
        {
            _referenceService.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReference(Reference p)
        {
            _referenceService.TInsert(p);
            return RedirectToAction("Index");
        }
    }
}
