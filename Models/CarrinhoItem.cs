using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoUdemy.Models
{
    
    public class CarrinhoItem
    {
        [StringLength(200)]
        public string CarrinhoId { get; set; }
        public int CarrinhoItemId { get; set; }
        public Lanche Lanche { get; set; }
        //Vai entender que desejamos definir uma chave estrangeira,e vai adicionar o LancheId na tabela de Carrinho.

        public int Quantidade { get; set; }
        
    }
}
