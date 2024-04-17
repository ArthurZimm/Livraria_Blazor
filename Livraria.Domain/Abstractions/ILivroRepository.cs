using Livraria.Domain.Entities;

namespace Livraria.Domain.Abstractions;

public interface ILivroRepository
{
    Task<IEnumerable<Livro>> ObterLivros();
    Task<Livro?> ObterLivros(int id);
    Task<Livro> AdicionarLivro(Livro livro);
    Task AtualizarLivro(Livro livro);
    Task DeletarLivro(int id);
}
