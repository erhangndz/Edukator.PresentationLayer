using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Home
{
    
    public class _FooterPartial:ViewComponent 
    {
        ISocialMediaService _socialMediaService;

        public _FooterPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values= _socialMediaService.TGetList();
            return View(values);
        }
    }
}
