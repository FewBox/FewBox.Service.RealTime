using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using FewBox.Service.RealTime.Hubs;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Core.Web.Dto;

namespace FewBox.Service.RealTime.Controllers
{
    [ApiController]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class HubController : ControllerBase
    {
        private IHubContext<NotificationHub> HubContext { get; set; }
        private const string Method = "notify";

        public HubController(IHubContext<NotificationHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        [HttpPost]
        public MetaResponseDto NotifyAll([FromBody] NotificationAllDto notificationDto)
        {
            this.HubContext.Clients.All.SendAsync(Method, notificationDto.Message, notificationDto.Description);
            return new MetaResponseDto();
        }        
    }
}
