using Microsoft.AspNetCore.Mvc;

namespace CursoUdemy.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
