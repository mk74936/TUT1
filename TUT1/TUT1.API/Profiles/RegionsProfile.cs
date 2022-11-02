using AutoMapper;

namespace TUT1.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>().ReverseMap();
            //If Both Domain Model and DTO Model doesn't have same column names , then Map it using below code
            //.ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId));
            //Use .ReverseMap() for vise versa action
        }
    }
}
