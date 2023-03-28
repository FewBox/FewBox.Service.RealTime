using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQUsersRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<UsersRealtimeMessage>
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
                SendMessageWrapper(() =>
                {
                    this.HubContext.Clients.Users(realtimeMessage.UserIds).SendAsync(realtimeMessage.Method, this.Convert(realtimeMessage.Arg1), this.Convert(realtimeMessage.Arg2), this.Convert(realtimeMessage.Arg3), this.Convert(realtimeMessage.Arg4), this.Convert(realtimeMessage.Arg5), this.Convert(realtimeMessage.Arg6), this.Convert(realtimeMessage.Arg7), this.Convert(realtimeMessage.Arg8), this.Convert(realtimeMessage.Arg9), this.Convert(realtimeMessage.Arg10));
                });
                return true;
            };
        }
    }
}
