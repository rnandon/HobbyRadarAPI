using AutoMapper;
using HobbyRadarAPI.DataTransferObjects;
using HobbyRadarAPI.Models;

namespace HobbyRadarAPI.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
