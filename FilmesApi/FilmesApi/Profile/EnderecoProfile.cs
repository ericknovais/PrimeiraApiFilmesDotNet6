using AutoMapper;
using FilmesApi.Database.Dtos;
using FilmesApi.Moldels;



namespace FilmesApi.Profile;

public class EnderecoProfile : AutoMapper.Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<UpdateEnderecoDto, Endereco>();
        CreateMap<Endereco, UpdateEnderecoDto>();
        CreateMap<Endereco, ReadEnderecoDto>();
    }
}
