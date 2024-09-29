using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly WebAppContext _context;

        public LoginController(WebAppContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.OcultarNavbar = true;
            return View();
        }

        // Validate User
        public async Task<IActionResult> LogIn(LoginViewModel loginViewModel)
        {
            
            var loginName = _context.Users.FirstOrDefault(l => l.UserName == loginViewModel.UserName && l.UserPassword == loginViewModel.UserPassword);

            if (loginName != null) 
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
