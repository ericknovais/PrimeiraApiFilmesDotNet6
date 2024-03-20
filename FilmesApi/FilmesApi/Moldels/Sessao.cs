using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Moldels
{
    [Table("Sessoes")]
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int FilmeId { get; set; }
        public virtual Filme Filme { get; set; }

        public int? CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }

    }
}
