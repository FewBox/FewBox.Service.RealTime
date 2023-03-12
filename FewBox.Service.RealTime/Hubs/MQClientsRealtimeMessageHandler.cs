using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQClientsRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<ClientsRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQClientsRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<ClientsRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.HubContext.Clients.Clients(realtimeMessage.ConnectionIds).SendAsync(realtimeMessage.Method, realtimeMessage.Arg1, realtimeMessage.Arg2, realtimeMessage.Arg3, realtimeMessage.Arg4, realtimeMessage.Arg5, realtimeMessage.Arg6, realtimeMessage.Arg7, realtimeMessage.Arg8, realtimeMessage.Arg9, realtimeMessage.Arg10);
                });
                return true;
            };
        }
    }
}
