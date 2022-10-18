using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
namespace LapShop.Controllers
{
    public class Users : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(UsersModel user)
        {
            return View("Register");
        }
    }
}
