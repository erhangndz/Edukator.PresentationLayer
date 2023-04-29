using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Edukator.DataAccessLayer.Concrete;
using Edukator.EntityLayer.Concrete;
using Edukator.BusinessLayer.Abstract;

namespace Edukator.PresentationLayer.Controllers
{
    public class MapsController : Controller
    {
       private readonly IMapService _mapService;

        public MapsController(IMapService mapService)
        {
            _mapService = mapService;
        }

        public IActionResult Index()
        {
           var values= _mapService.TGetList();
            return View(values);
        }
        
        public IActionResult DeleteMap(int id)
        {
            var values= _mapService.TGetByID(id);
            _mapService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMap(int id) 
        {
            var values = _mapService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateMap(Map p)
        {
            _mapService.TUpdate(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddMap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMap(Map p)
        {
            _mapService.TInsert(p); 
            return RedirectToAction("Index");
        }
    }
}
