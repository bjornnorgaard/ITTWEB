using AutoMapper;
using DotnetCore.Data.Models;

namespace DotnetCore.Api.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pet, PetGet>().ReverseMap();
            CreateMap<Pet, PetPost>().ReverseMap();
        }
    }
}