using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LaPira_a.Controllers
{
    public class QuienesSomosController : Controller
    {
        private readonly ILogger<QuienesSomosController> _logger;

        public QuienesSomosController(ILogger<QuienesSomosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Quien()
        {
            return View();
        }
        public IActionResult Presentacion()
        {
            return View();
        }
          public IActionResult Contacto()
        {
            ViewData["Mensaje"] = "Mensaje enviado";
            return View();
        }
    }
}
