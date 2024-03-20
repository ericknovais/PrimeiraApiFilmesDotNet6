using FilmesApi.Database.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Moldels;

[Table("Filmes")]
public class Filme
{
    public Filme()
    {
        Titulo = string.Empty;
        Genero = string.Empty;
        Duracao = 0;
    }

    public Filme(CreateFilmeDto filmeDto)
    {
        Titulo = filmeDto.Titulo;
        Genero = filmeDto.Genero;
        Duracao = filmeDto.Duracao;
    }

    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O títilo do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
    public virtual ICollection<Sessao> Sessaos { get; set; }
}

