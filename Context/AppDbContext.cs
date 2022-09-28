using CursoUdemy.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItems { get; set; }
    }
}
