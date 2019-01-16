using AutoMapper;
using HeroClub.Domain;
using HeroClub.WebAPI.Dtos;

namespace HeroClub.WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Batalha, BatalhaDto>();
            CreateMap<Citacao, CitacaoDto>();
            CreateMap<Equipe, EquipeDto>();
            CreateMap<EquipeHeroiBatalha, EquipeHeroiBatalhaDto>();
            CreateMap<EquipeHeroi, EquipeHeroiDto>();
            CreateMap<Foto, FotoDto>();
            CreateMap<Heroi, HeroiDto>();
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForLoginDto>();
            CreateMap<User, UserForRegisterDto>();
        }
    }
}