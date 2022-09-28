using CursoUdemy.Models;

namespace CursoUdemy.Repositorios
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
        //Define Categorias como um obj que retorna toda a tabela Categoria
    }
}
