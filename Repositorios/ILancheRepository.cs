using CursoUdemy.Models;

namespace CursoUdemy.Repositorios
{
    public interface ILancheRepository
    {
        public IEnumerable<Lanche> Lanches { get; }
        public IEnumerable<Lanche> LanchesFavoritos { get; }

        Lanche GetLancheById(int lancheId);
    }
}
