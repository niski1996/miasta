using AutoMapper;
using MiastaMieścinyMiasteczka.DTOs;
using MiastaMieścinyMiasteczka.DTOs.HelperClass;
using MiastaMieścinyMiasteczka.Entities;

namespace MiastaMieścinyMiasteczka.Profiles
{
    public class CityProfile:Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDTO>().ForMember(dest => dest.Region, opt => opt.MapFrom(src => new Region(src.Country, src)));
            CreateMap<CityDTO, CityCreationDTO>();
            CreateMap<CityCreationDTO, City>();
            CreateMap<City, CityCreationDTO>();

        }
    }
}
