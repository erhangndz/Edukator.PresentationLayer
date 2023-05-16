using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _MapPartial:ViewComponent
    {
        private readonly IMapService _mapService;

        public _MapPartial(IMapService mapService)
        {
            _mapService = mapService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _mapService.TGetList();
            return View(values);
        }
    }
}
