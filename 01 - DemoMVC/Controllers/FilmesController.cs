using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

    }
}
