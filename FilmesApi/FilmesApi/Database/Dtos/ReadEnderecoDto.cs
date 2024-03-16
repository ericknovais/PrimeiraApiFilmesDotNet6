using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Database.Dtos;

public class ReadEnderecoDto
{
    public int Id { get; set; }
    public string Logradouro { get; set; } = string.Empty;
    public int Numero { get; set; }
}
