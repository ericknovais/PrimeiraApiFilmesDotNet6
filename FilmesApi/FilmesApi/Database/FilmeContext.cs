﻿using FilmesApi.Moldels;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Database;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sessao>().HasKey(sessao => new { sessao.FilmeId, sessao.CinemaId });
        modelBuilder.Entity<Sessao>().HasOne(sessao => sessao.Cinema).WithMany(cinema => cinema.Sessoes).HasForeignKey(sessao => sessao.CinemaId);
        modelBuilder.Entity<Sessao>().HasOne(sessao => sessao.Filme).WithMany(filme => filme.Sessoes).HasForeignKey(sessao => sessao.FilmeId);
        modelBuilder.Entity<Endereco>().HasOne(endereco => endereco.Cinema).WithOne(cinema => cinema.Endereco).OnDelete(DeleteBehavior.Restrict);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
