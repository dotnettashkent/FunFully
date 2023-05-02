using AutoMapper;
using FunFully.Domain.Entities.Moneys;
using FunFully.Domain.Entities.Users;
using FunFully.Service.DTOs.Moneys;
using FunFully.Service.DTOs.Users;

namespace FunFully.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserCreationDto>().ReverseMap();
            CreateMap<User, UserResultDto>().ReverseMap();

            CreateMap<Money, AddMoneyCreationDto>().ReverseMap();
            CreateMap<Money, AddMoneyResultDto>().ReverseMap();
            CreateMap<Money, GetMoneyCreationDto>().ReverseMap();
            CreateMap<Money, GetMoneyResultDto>().ReverseMap();
        }
    }
}
