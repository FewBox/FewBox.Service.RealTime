using System;
using FewBox.Core.Utility.Formatter;
using FewBox.SDK.Realtime;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace FewBox.Service.RealTime.Hubs
{
    public class MQAllExceptRealtimeMessageHandler : MQRealtimeMessageHandler, IMQRealtimeHandler<AllExceptRealtimeMessage>
    {
        private IHubContext<FewBoxHub> HubContext { get; set; }
        public MQAllExceptRealtimeMessageHandler(IHubContext<FewBoxHub> hubContext, ILogger<MQAllExceptRealtimeMessageHandler> logger)
        : base(logger)
        {
            this.HubContext = hubContext;
        }

        public Func<AllExceptRealtimeMessage, bool> Handle()
        {
            return (realtimeMessage) =>
            {
                SendMessageWrapper(() =>
                {
                    this.Logger.LogDebug("[AllExcept] {0} {1}", realtimeMessage.Method, JsonUtility.Serialize(realtimeMessage.ExcludedConnectionIds));
                    this.HubContext.Clients.AllExcept(realtimeMessage.ExcludedConnectionIds).SendAsync(realtimeMessage.Method, this.Convert(realtimeMessage.Arg1), this.Convert(realtimeMessage.Arg2), this.Convert(realtimeMessage.Arg3), this.Convert(realtimeMessage.Arg4), this.Convert(realtimeMessage.Arg5), this.Convert(realtimeMessage.Arg6), this.Convert(realtimeMessage.Arg7), this.Convert(realtimeMessage.Arg8), this.Convert(realtimeMessage.Arg9), this.Convert(realtimeMessage.Arg10));
                });
                return true;
            };
        }
    }
}
