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
        private IMQRealtimeHandler<AllExceptRealtimeMessage> AllExceptRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<AllRealtimeMessage> AllRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<ClientRealtimeMessage> ClientRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<ClientsRealtimeMessage> ClientsRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<GroupExceptRealtimeMessage> GroupExceptRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<GroupRealtimeMessage> GroupRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<GroupsRealtimeMessage> GroupsRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<UserRealtimeMessage> UserRealtimeMessageHandler { get; set; }
        private IMQRealtimeHandler<UsersRealtimeMessage> UsersRealtimeMessageHandler { get; set; }

        public RealtimeMessageController(IMQRealtimeHandler<AllRealtimeMessage> allRealtimeMessageHandler, IMapper mapper) : base(mapper)
        {
            this.AllRealtimeMessageHandler = allRealtimeMessageHandler;
        }

        [HttpPost("all-except")]
        public MetaResponseDto SendAllExcept([FromBody] AllExceptRealtimeMessageDto allExceptRealtimeMessageDto)
        {
            var handler = this.AllExceptRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<AllExceptRealtimeMessageDto, AllExceptRealtimeMessage>(allExceptRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("all")]
        public MetaResponseDto SendAll([FromBody] AllRealtimeMessageDto allRealtimeMessageDto)
        {
            var handler = this.AllRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<AllRealtimeMessageDto, AllRealtimeMessage>(allRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("client")]
        public MetaResponseDto SendClient([FromBody] ClientRealtimeMessageDto clientRealtimeMessageDto)
        {
            var handler = this.ClientRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<ClientRealtimeMessageDto, ClientRealtimeMessage>(clientRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("clients")]
        public MetaResponseDto SendClients([FromBody] ClientsRealtimeMessageDto clientsRealtimeMessageDto)
        {
            var handler = this.ClientsRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<ClientsRealtimeMessageDto, ClientsRealtimeMessage>(clientsRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("group-except")]
        public MetaResponseDto SendGroupExcept([FromBody] GroupExceptRealtimeMessageDto groupExceptRealtimeMessageDto)
        {
            var handler = this.GroupExceptRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<GroupExceptRealtimeMessageDto, GroupExceptRealtimeMessage>(groupExceptRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("group")]
        public MetaResponseDto SendGroup([FromBody] GroupRealtimeMessageDto groupRealtimeMessageDto)
        {
            var handler = this.GroupRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<GroupRealtimeMessageDto, GroupRealtimeMessage>(groupRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("groups")]
        public MetaResponseDto SendGroups([FromBody] GroupsRealtimeMessageDto groupsRealtimeMessageDto)
        {
            var handler = this.GroupsRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<GroupsRealtimeMessageDto, GroupsRealtimeMessage>(groupsRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("user")]
        public MetaResponseDto SendUser([FromBody] UserRealtimeMessageDto userRealtimeMessageDto)
        {
            var handler = this.UserRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<UserRealtimeMessageDto, UserRealtimeMessage>(userRealtimeMessageDto));
            return new MetaResponseDto();
        }

        [HttpPost("users")]
        public MetaResponseDto SendUsers([FromBody] UsersRealtimeMessageDto usersRealtimeMessageDto)
        {
            var handler = this.UsersRealtimeMessageHandler.Handle();
            handler.Invoke(this.Mapper.Map<UsersRealtimeMessageDto, UsersRealtimeMessage>(usersRealtimeMessageDto));
            return new MetaResponseDto();
        }
    }
}
