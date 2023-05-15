using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactInfoPartial:ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;

        public _ContactInfoPartial(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _contactInfoService.TGetList();
            return View(values);
        }
    }
}
