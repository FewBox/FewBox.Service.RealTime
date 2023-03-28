using System;
using Newtonsoft.Json;

namespace FewBox.Service.RealTime.Hubs
{
    public abstract class MQRealtimeMessageHandler
    {
        protected void SendMessageWrapper(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        
        protected string Convert(object inputObject)
        {
            string jsonString = JsonConvert.SerializeObject(inputObject);
            return jsonString;
        }
    }
}
