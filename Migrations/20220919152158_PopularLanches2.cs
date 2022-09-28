using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoUdemy.Migrations
{
    public partial class PopularLanches2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (1,'Misto Quente','Lanche com presunto,queijo e ovo', 8.50, 1, 'https://2.bp.blogspot.com/-n0BRuB8rVnM/Wwv2pb63PcI/AAAAAAAAM_E/gYTFlGH39zg95nDYtdwPteKhFc8vocccgCLcBGAs/s1600/misto-quente-receita-1.jpeg', 0)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, LancheNome, Descricao, preco,EmEstoque, ImageUrl, IsFavorito)" +
                "VALUES (1,'Hamburguer','Hamburguer classico com carne,salada e queijo', 15.00, 1, 'https://www.sabornamesa.com.br/media/k2/items/cache/b9ad772005653afce4d4bd46c2efe842_XL.jpg', 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
