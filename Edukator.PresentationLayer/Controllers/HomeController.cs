using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISubscriberService _subscriberService;

        public HomeController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribePartial(Subscriber p)
        {
            _subscriberService.TInsert(p);

            return RedirectToAction("Index");
        }

    }
}
