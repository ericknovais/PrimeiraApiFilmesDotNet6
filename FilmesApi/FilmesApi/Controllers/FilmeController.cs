using AutoMapper;
using FilmesApi.Database;
using FilmesApi.Database.Dtos;
using FilmesApi.Moldels;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _ctx;
    private IMapper _mapper;
    public FilmeController(FilmeContext filmeContext, IMapper mapper)
    {
        _ctx = filmeContext;
        _mapper = mapper;
    }

    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);

        _ctx.Filmes.Add(filme);
        _ctx.SaveChanges();
        return CreatedAtAction(nameof(ObterFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> ObterFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadFilmeDto>>(_ctx.Filmes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public ActionResult ObterFilmePorId(int id)
    {
        var filme = _ctx.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null)
            return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        return Ok(filme);
    }

    [HttpPut("{id}")]
    public ActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto) 
    {
        var filme = _ctx.Filmes.FirstOrDefault(filme => filme.Id.Equals(id));
        if (filme == null)
            return NotFound();
        _mapper.Map(filmeDto, filme);
        _ctx.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public ActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        var filme = _ctx.Filmes.FirstOrDefault(filme => filme.Id.Equals(id));
        if (filme == null)
            return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);

        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if (!TryValidateModel(filmeParaAtualizar))
            return ValidationProblem();

        _mapper.Map(filmeParaAtualizar, filme);
        _ctx.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeletaFilme(int id) 
    {
        var filme = _ctx.Filmes.FirstOrDefault(filme => filme.Id.Equals(id));
        if (filme == null)
            return NotFound();
        _ctx.Filmes.Remove(filme);
        _ctx.SaveChanges();
        return NoContent();
    }
}
