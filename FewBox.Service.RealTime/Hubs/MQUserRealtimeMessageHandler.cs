using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQUserRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<UserRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQUserRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<UserRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.HubContext.Clients.User(realtimeMessage.UserId).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                });
                return true;
            };
        }
    }
}
