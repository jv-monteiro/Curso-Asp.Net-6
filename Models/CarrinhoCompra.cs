using CursoUdemy.Context;
using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.Models
{
    public class CarrinhoCompra
    {
        //Construtor
        private readonly AppDbContext _context;
        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoItem> CarrinhoItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //Define um sessão
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            // ?. verifica se o session não é nulo


            //Obtem um serviço do tipo do contexto
            var contexto = services.GetService<AppDbContext>();

            //Obtem ou gera um Id para o carrinho
            string carrinhoId= session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //Atribui o Id do carrinho na Sessão
            session.SetString("CarrinhoId", carrinhoId);

            //Retorna o valor com context e ID
            return new CarrinhoCompra(contexto)
            {
                CarrinhoCompraId = carrinhoId
            };
        }




        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && s.CarrinhoId == CarrinhoCompraId);

            if(carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoItem
                {
                    CarrinhoId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoItems.Add(carrinhoCompraItem);
            
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }


        public int RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && s.CarrinhoId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if(carrinhoCompraItem != null)
            {
                if(carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoItems.Remove(carrinhoCompraItem);
                }
            }

            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoItem> GetCarrinhoItems()
        {
            return CarrinhoItems ?? (CarrinhoItems = _context.CarrinhoItems
                .Where(c => c.CarrinhoId == CarrinhoCompraId)
                    .Include(s => s.Lanche)
                    .ToList());
        }


        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoItems.Where(ca => ca.CarrinhoId == CarrinhoCompraId);
            _context.CarrinhoItems.RemoveRange(carrinhoItens);
            _context.SaveChanges();
        }

        public decimal GetCarrinhoTotal()
        {
            var total = _context.CarrinhoItems.Where(c=>c.CarrinhoId == CarrinhoCompraId).Select(c=>c.Lanche.preco*c.Quantidade).Sum();
            return total;
        }
    }
}
