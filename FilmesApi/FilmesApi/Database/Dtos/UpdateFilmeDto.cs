﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Database.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O títilo do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
