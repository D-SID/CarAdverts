using AutoMapper;
using CarAdverts.Core.Models;
using CarAdverts.Repository.Models;

namespace CarAdverts.Core;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CarAdvert, CarAdvertDto>().ReverseMap();
    }
}
