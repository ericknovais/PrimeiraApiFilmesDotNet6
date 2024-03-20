using FilmesApi.Database.Dtos;
using FilmesApi.Database.Dtos.Sessao;
using FilmesApi.Moldels;

namespace FilmesApi.Profile;

public class SessaoProfile: AutoMapper.Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDto, Sessao>();
        CreateMap<UpdateSessaoDto, Sessao>();
        CreateMap<Sessao, UpdateSessaoDto>();
        CreateMap<Sessao, ReadSessaoDto>();
    }

}
