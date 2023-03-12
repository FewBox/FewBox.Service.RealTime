using System;

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

            }
        }
    }
}
