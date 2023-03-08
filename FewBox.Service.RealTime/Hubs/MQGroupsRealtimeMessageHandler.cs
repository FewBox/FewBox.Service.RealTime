using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQGroupsRealtimeMessageHandler : IMQRealtimeHandler<GroupsRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQGroupsRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<GroupsRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                this.HubContext.Clients.Groups(realtimeMessage.GroupNames).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                return true;
            };
        }
    }
}