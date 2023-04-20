using System;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FewBox.Service.RealTime.Hubs
{
    public abstract class MQRealtimeMessageHandler
    {
        protected ILogger<MQRealtimeMessageHandler> Logger { get; set; }
        protected MQRealtimeMessageHandler(ILogger<MQRealtimeMessageHandler> logger)
        {
            this.Logger = logger;
        }

        protected void SendMessageWrapper(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                this.Logger.LogError(exception.Message);
            }
        }

        protected string Convert(object inputObject)
        {
            string jsonString = JsonConvert.SerializeObject(inputObject);
            return jsonString;
        }
    }
}
