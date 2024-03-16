using AutoMapper;
using FilmesApi.Database.Dtos;
using FilmesApi.Moldels;

namespace FilmesApi.Profile;

public class CinemaProfile : AutoMapper.Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.Endereco,
            opcao => opcao.MapFrom(cinema => cinema.Endereco));
    }
}
