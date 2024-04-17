using Livraria.Domain.Abstractions;
using Livraria.Domain.Entities;
using Livraria.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly ApplicationDbContext _context;
    public LivroRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Livro>> ObterLivros()
    {
        return await _context.Livros.ToListAsync();
    }

    public async Task<Livro?> ObterLivros(int id)
    {
        return await _context.Livros.FirstOrDefaultAsync(x=> x.LivroId == id);
    }
    public async Task<Livro> AdicionarLivro(Livro livro)
    {
        await _context.AddAsync(livro);
        await _context.SaveChangesAsync();
        return livro;
    }

    public async Task AtualizarLivro(Livro livro)
    {
        _context.Entry(livro).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeletarLivro(int id)
    {
        var livro = await ObterLivros(id);
        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
    }
}
