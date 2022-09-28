using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoUdemy.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao)" +
                "VALUES ('Normal', 'Lanches padrão da casa')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
