using AutoMapper;
using FilmesApi.Database.Dtos;
using FilmesApi.Moldels;



namespace FilmesApi.Profile;

public class FilmeProfile : AutoMapper.Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
            //ForMember(filmeDto => filmeDto.Sessoes,
            //opcao => opcao.MapFrom(filme => filme.Sessoes));
    }
}
