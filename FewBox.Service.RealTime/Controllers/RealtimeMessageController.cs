using Microsoft.AspNetCore.Mvc;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Core.Web.Dto;
using FewBox.SDK.Realtime;
using FewBox.Core.Web.Controller;
using AutoMapper;

namespace FewBox.Service.RealTime.Controllers
{
    [ApiController]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class RealtimeMessageController : MapperController
    {
        //private IMQRealtimeHandler<AllExceptRealtimeMessage> AllRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<AllRealtimeMessage> AllRealtimeMessageHandler { get; set; }

        public RealtimeMessageController(IMQRealtimeHandler<AllRealtimeMessage> allRealtimeMessageHandler, IMapper mapper) : base(mapper)
        {
            this.AllRealtimeMessageHandler = allRealtimeMessageHandler;
        }

        /*[HttpPost("all-except")]
        public MetaResponseDto AllExcept([FromBody] AllExceptRealtimeMessageDto allExceptRealtimeMessageDto)
        {
            var handler = this.AllRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<AllExceptRealtimeMessageDto, AllExceptRealtimeMessage>(allExceptRealtimeMessageDto));
            return new MetaResponseDto();
        }*/

        [HttpPost("all")]
        public MetaResponseDto All([FromBody] AllRealtimeMessageDto allRealtimeMessageDto)
        {
            var handler = this.AllRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<AllRealtimeMessageDto, AllRealtimeMessage>(allRealtimeMessageDto));
            return new MetaResponseDto();
        }
    }
}
