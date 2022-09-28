using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoUdemy.Migrations
{
    public partial class PopularCategorias2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(CategoriaNome, Descricao)" +
                "VALUES ('Vegetariano', 'Lanches sem carne!')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}

