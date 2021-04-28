using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LaPira_a.Controllers
{
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;

        public CuentaController(ILogger<CuentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Usuario()
        {
            return View();
        }
       
    }
}
