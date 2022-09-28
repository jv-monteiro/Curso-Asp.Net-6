using CursoUdemy.Models;
using CursoUdemy.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursoUdemy.Components
{
    public class CarrinhoResumo : ViewComponent
    {
        public readonly CarrinhoCompra _carrinhoCompra;
        public CarrinhoResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinhoCompra.GetCarrinhoItems();

            //Teste para ver se carrinho funciona
            //var itens = new List<CarrinhoItem>()
            //{
            //    new CarrinhoItem(), new CarrinhoItem()
            //};
            //_carrinhoCompra.CarrinhoItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoTotal(),
            };

            return View(carrinhoCompraVM);
        }
    }
}
