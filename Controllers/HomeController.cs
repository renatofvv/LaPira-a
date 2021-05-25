using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaPira_a.Models;

namespace LaPira_a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //quienes somos
        public IActionResult Index()
        {
            return View();
        }
        //servicios y productos
        public IActionResult Servicios()
        {
            return View();
        }
        //contacto
        public IActionResult Contacto()
        {
            return View();
        }

        //pagina que recibe al contacto
        [HttpPost]
        public IActionResult Contacto(string datos)
        {
            return View();
        }
        //contancto de confirmacion
        public IActionResult ContactoConfirmacion()
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
