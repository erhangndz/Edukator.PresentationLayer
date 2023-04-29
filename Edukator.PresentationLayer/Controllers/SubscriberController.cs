using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly ISubscriberService _subscriberService;

        public SubscriberController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }

        public IActionResult Index()
        {
            var values = _subscriberService.TGetList();
            return View(values);
        }
        public IActionResult DeleteSubscriber(int id)
        {
            var values = _subscriberService.TGetByID(id);
            _subscriberService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSubscriber(int id)
        {
            var values = _subscriberService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSubscriber(Subscriber p)
        {
            _subscriberService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
