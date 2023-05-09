using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Home
{
    public class _ReferencePartial: ViewComponent
    {
        private readonly IReferenceService _referenceService;

        public _ReferencePartial(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }
    }
}
