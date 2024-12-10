using Microsoft.AspNetCore.Mvc;
using Proyecto_Simplex.Models;
using System.Diagnostics;

namespace Proyecto_Simplex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Cambiado a "Supermercado" para consistencia
        public IActionResult Supermercado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            string validEmail = "simplex@gmail.com";
            string validPassword = "simplex";

            if (model.Email == validEmail && model.Password == validPassword)
            {
                return RedirectToAction("VistaPrincipal");
            }
            else
            {
                ViewBag.ErrorMessage = "Correo electrónico o contraseña incorrectos";
                return View("Index");
            }
        }

        public IActionResult VistaPrincipal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
