using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CursoUdemy.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="Campo deve ser preenchido")]
        [MinLength(5, ErrorMessage = "Nome muito curto")]
        [MaxLength(50 , ErrorMessage = "Nome nao pode exceder 50 caracteres")]
        [Display(Name = "Nome do lanche")]
        public string LancheNome { get; set; }

        [Required(ErrorMessage = "Campo deve ser preenchido")]
        [MaxLength(200, ErrorMessage = "Descrição nao pode exceder 200 caracteres")]
        [Display(Name = "Descrição do lanche")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo deve ser preenchido")]
        [Column(TypeName="decimal(10, 2)")]
        [Range(1,999.99,ErrorMessage ="Valor invalido!")]
        public decimal preco { get; set; }

        [Required(ErrorMessage = "Imagem deve ser colocada")]
        public string ImageUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsFavorito { get; set; }

        [Required(ErrorMessage = "Colocar estoque")]
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }





        //Link entre tabelas(propriedades de navegação)
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
