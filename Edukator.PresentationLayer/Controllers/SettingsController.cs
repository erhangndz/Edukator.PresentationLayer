using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values= await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name= values.Name;
            userEditViewModel.Surname= values.Surname;
            userEditViewModel.ImageURL= values.ImageURL;
            userEditViewModel.Email= values.Email;
            userEditViewModel.Username = values.UserName;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user= await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource= Directory.GetCurrentDirectory();
                var extension= Path.GetExtension(p.Image.FileName); 
                var imagename= Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageURL ="/userimages/" + imagename;
            }
            user.Name = p.Name;
            user.Surname= p.Surname;
            user.Email= p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Dashboard");
            }
           return View();

        }
    }
}
