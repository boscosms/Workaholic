using AutoMapper;

namespace Walking.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, DTOs.Region>()
                .ReverseMap();
        }
    }
}
