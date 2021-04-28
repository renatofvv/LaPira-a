using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LaPira_a.Controllers
{
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Ventas()
        {
            return View();
        }
       
    }
}
