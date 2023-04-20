using System;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQUserRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<UserRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQUserRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext, ILogger<MQUserRealtimeMessageHandler> logger)
        : base(logger)
        {
            this.HubContext = hubContext;
        }

        public Func<UserRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.Logger.LogDebug("[User] {0} {1}", realtimeMessage.Method, realtimeMessage.UserId);
                    this.HubContext.Clients.User(realtimeMessage.UserId).SendAsync(realtimeMessage.Method, this.Convert(realtimeMessage.Arg1), this.Convert(realtimeMessage.Arg2), this.Convert(realtimeMessage.Arg3), this.Convert(realtimeMessage.Arg4), this.Convert(realtimeMessage.Arg5), this.Convert(realtimeMessage.Arg6), this.Convert(realtimeMessage.Arg7), this.Convert(realtimeMessage.Arg8), this.Convert(realtimeMessage.Arg9), this.Convert(realtimeMessage.Arg10));
                });
                return true;
            };
        }
    }
}
