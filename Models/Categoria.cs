using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoUdemy.Models
{
    [Table("Categoria")]//Colocado apenas para reforço,pois isso ja foi declarado no appdbcontext com: public DbSet<Categoria> Categoria { get; set; }
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Informe nome da categoria")]
        [StringLength(100,ErrorMessage ="Nome muito longo")]
        [Display(Name ="Nome da Categoria")]
        public string CategoriaNome { get; set; }


        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [StringLength(100, ErrorMessage = "Nome muito longo")]
        [Display(Name = "Descrição da Categoria")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
