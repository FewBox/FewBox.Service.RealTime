using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQClientRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<ClientRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQClientRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext, ILogger<MQClientRealtimeMessageHandler> logger)
        : base(logger)
        {
            this.HubContext = hubContext;
        }

        public Func<ClientRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.Logger.LogDebug("[Client] {0} {1}", realtimeMessage.Method, realtimeMessage.ConnectionId);
                    this.HubContext.Clients.Client(realtimeMessage.ConnectionId).SendAsync(realtimeMessage.Method, this.Convert(realtimeMessage.Arg1), this.Convert(realtimeMessage.Arg2), this.Convert(realtimeMessage.Arg3), this.Convert(realtimeMessage.Arg4), this.Convert(realtimeMessage.Arg5), this.Convert(realtimeMessage.Arg6), this.Convert(realtimeMessage.Arg7), this.Convert(realtimeMessage.Arg8), this.Convert(realtimeMessage.Arg9), this.Convert(realtimeMessage.Arg10));
                });
                return true;
            };
        }
    }
}
