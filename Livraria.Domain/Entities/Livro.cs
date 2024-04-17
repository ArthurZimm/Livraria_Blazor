using Livraria.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.Entities;

public sealed class Livro
{
    public Livro(int livroId, string? titulo, string? autor, DateTime lancamento, string? capa, EEditora editora, ECategoria categoria)
    {
        LivroId = livroId;
        Titulo = titulo;
        Autor = autor;
        Lancamento = lancamento;
        Capa = capa;
        Editora = editora;
        Categoria = categoria;
    }
    public int LivroId { get; set; }

    [Required(ErrorMessage ="Informe o título do livro")]
    [StringLength(150)]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "Informe o Autor do livro")]
    [StringLength(100)]
    public string? Autor { get; set; }

    [Required(ErrorMessage ="Informe a data de lançamento")]
    public DateTime Lancamento { get; set; }

    [Required(ErrorMessage = "Informe a imagem da capa")]
    [StringLength(100)]
    public string? Capa { get; set; }

    [Required]
    [EnumDataType(typeof(EEditora), ErrorMessage ="Selecione a editora")]
    public EEditora Editora { get; set; }

    [Required]
    [EnumDataType(typeof(ECategoria), ErrorMessage ="Selecione a categoria")]
    public ECategoria Categoria { get; set; }
}
