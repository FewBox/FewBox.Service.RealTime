using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQAllRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<AllRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQAllRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext)
        {
            this.HubContext = hubContext;
        }

        public Func<AllRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.HubContext.Clients.All.SendAsync(realtimeMessage.Method, this.Convert(realtimeMessage.Arg1), this.Convert(realtimeMessage.Arg2), this.Convert(realtimeMessage.Arg3), this.Convert(realtimeMessage.Arg4), this.Convert(realtimeMessage.Arg5), this.Convert(realtimeMessage.Arg6), this.Convert(realtimeMessage.Arg7), this.Convert(realtimeMessage.Arg8), this.Convert(realtimeMessage.Arg9), this.Convert(realtimeMessage.Arg10));
                });
                return true;
            };
        }
    }
}
