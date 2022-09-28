
using CursoUdemy.Models;
using CursoUdemy.Repositorios;
using CursoUdemy.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursoUdemy.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        
        public IActionResult List(string categoria)
        {

            ViewData["Hora"] = DateTime.Now;

            //--Filtrando por categorias
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                //if(string.Equals("normal", categoria, StringComparison.OrdinalIgnoreCase))
                //{
                //    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.Equals("normal")).OrderBy(l => l.LancheId);
                //}
                //else
                //{
                //    lanches = _lancheRepository.Lanches.Where(l => l.Categoria.Equals("vegetariano")).OrderBy(l => l.LancheId);
                //}
                lanches = _lancheRepository.Lanches.Where(l => l.Categoria.CategoriaNome.Equals(categoria)).OrderBy(c => c.LancheNome);

                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel()
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };



            var lanchesCount = lancheListViewModel.Lanches.Count();
            ViewBag.TotalLanches = lanchesCount;


            return View(lancheListViewModel);


        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return View (lanche);
        }


    }

}

