using Microsoft.AspNetCore.Mvc;
using UserAuthentication.Models;
using UserAuthentication.Services;

namespace UserAuthentication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginView()
        {
            //return View(LoginService.GetNamePassword);
            return View();
        }


        [HttpPost]
        public IActionResult LoginView(LoginModel model)
        {
           LoginService.SetNamePassword(model);
            //return View(LoginService.GetNamePassword());
            return View(model);
        }
    }
}
