using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQGroupExceptRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<GroupExceptRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQGroupExceptRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<GroupExceptRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.HubContext.Clients.GroupExcept(realtimeMessage.GroupName, realtimeMessage.ExcludedConnectionIds).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                });
                return true;
            };
        }
    }
}
