using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Database.Dtos.Sessao;

public class ReadSessaoDto
{
    public int FilmeId { get; set; }
    public int CinemaId { get; set; }
}
