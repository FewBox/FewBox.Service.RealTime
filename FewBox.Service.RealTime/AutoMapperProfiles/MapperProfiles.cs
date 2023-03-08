using AutoMapper;
using FewBox.SDK.Realtime;
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
            CreateMap<AllRealtimeMessageDto, AllRealtimeMessage>();
        }
    }
}