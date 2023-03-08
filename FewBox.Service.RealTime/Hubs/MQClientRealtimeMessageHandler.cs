using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQClientRealtimeMessageHandler : IMQRealtimeHandler<ClientRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQClientRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<ClientRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                this.HubContext.Clients.Client(realtimeMessage.ConnectionId).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                return true;
            };
        }
    }
}
