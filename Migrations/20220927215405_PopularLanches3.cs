using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoUdemy.Migrations
{
    public partial class PopularLanches3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (1,'Lanche de Javali','Lanche com carne de Javali', 13.00, 1, 'https://www.guiadasemana.com.br/contentFiles/system/pictures/2012/10/60197/cropped/javali-2.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (1,'Carne louca','Lanche de carne louca', 11.00, 1, 'https://img.itdg.com.br/tdg/images/recipes/000/071/309/335748/335748_original.jpg?mode=crop&width=710&height=400', 0)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (2,'X-Salada','Lanche com salada e ovos', 16.00, 1, 'https://img.freepik.com/fotos-premium/delicioso-hamburguer-tradicional-brasileiro-x-todo-o-queijo-de-tomate-de-ovo-de-salsicha-e-salada-na-placa-de-madeira_579344-2529.jpg', 0)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (2,'Bauru','Lanche comn presunto queijo e tomate', 6.00, 1, 'https://www.montarumnegocio.com/wp-content/uploads/2018/10/como-fazer-bauru-na-chapa.jpg', 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
