using System;
using FewBox.SDK.Mail;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQUsersRealtimeMessageHandler : IMQRealtimeHandler<UsersRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQUsersRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<UsersRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                this.HubContext.Clients.Users(realtimeMessage.UserIds).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                return true;
            };
        }
    }
}
