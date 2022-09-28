using CursoUdemy.Models;
using CursoUdemy.Repositorios;
using CursoUdemy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CursoUdemy.Controllers
{
    public class HomeController : Controller
    {
        


        public readonly ILancheRepository _lancheRepository;
        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesFavoritos
            };

            return View(homeViewModel);
        }

        public IActionResult Demo()
        {
            return View();
        }

        public IActionResult Privacy()
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