using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class SupportController : Controller
    {
        // GET
        public IActionResult Enterprise()
        {
            return View();
        }
    }
}