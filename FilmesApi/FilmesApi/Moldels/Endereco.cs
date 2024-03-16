using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Moldels;

[Table("Enderecos")]
public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="Campo logradouro obrigatório. ")]
    public string Logradouro { get; set; }
    [Required(ErrorMessage = "Campo numero obrigatório. ")]
    public int Numero { get; set; }

    public virtual Cinema Cinema { get; set; }
}
