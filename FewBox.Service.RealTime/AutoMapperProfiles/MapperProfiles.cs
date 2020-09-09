using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Service.RealTime.Model.Entities;

namespace FewBox.Service.RealTime.AutoMapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<App, AppDto>();
            CreateMap<AppPersistantDto, App>();
        }
    }
}