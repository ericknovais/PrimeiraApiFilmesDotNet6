using FilmesApi.Moldels;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Database;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
}
