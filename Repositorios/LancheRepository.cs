using CursoUdemy.Context;
using CursoUdemy.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoUdemy.Repositorios
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesFavoritos => _context.Lanches.Where(f => f.IsFavorito).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(i => i.LancheId == lancheId);
        }
        
    }
}
