using Microsoft.AspNetCore.Mvc;
namespace LaPira_a.Controllers
{
    public class CompraController : Controller
    {
        public IActionResult ResumenCompra()
        {
            return View();
        }
        public IActionResult PagarCompra()
        {
            return View();
        }
        public IActionResult ProductosDestacados()
        {
            return View();
        }
    }
}