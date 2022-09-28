using Microsoft.AspNetCore.Mvc;

namespace CursoUdemy.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "$Testando método Index do Router Admin : {DateTime.Now }";
        }
        public string Demo()
        {
            return "$Testando método Demo do Router Admin : {DateTime.Now }";
        }
    }
}
