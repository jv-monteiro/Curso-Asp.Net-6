using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoUdemy.Migrations
{
    public partial class CarrinhoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoItems",
                columns: table => new
                {
                    CarrinhoItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LancheId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItems", x => x.CarrinhoItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoItems_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItems_LancheId",
                table: "CarrinhoItems",
                column: "LancheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItems");
        }
    }
}
