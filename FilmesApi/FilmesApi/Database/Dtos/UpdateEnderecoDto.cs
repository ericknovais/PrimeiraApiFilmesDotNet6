using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Database.Dtos
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "Campo logradouro obrigatório. ")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Campo numero obrigatório. ")]
        public int Numero { get; set; }
    }
}
