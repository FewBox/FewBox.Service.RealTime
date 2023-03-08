using System.Collections.Generic;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class ClientsRealtimeMessageDto : RealtimeMessageDto
    {
        public IReadOnlyList<string> ConnectionIds { get; set; }
    }
}