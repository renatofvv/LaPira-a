using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LaPira_a.Controllers
{
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        public CompraController(ILogger<CompraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Comprar()
        {
            return View();
        }
       
    }
}
