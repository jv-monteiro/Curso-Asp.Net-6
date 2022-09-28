using CursoUdemy.Context;
using CursoUdemy.Models;

namespace CursoUdemy.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
        _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categoria;
    }
}
