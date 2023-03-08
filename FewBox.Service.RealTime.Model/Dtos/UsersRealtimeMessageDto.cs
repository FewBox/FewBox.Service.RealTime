using System.Collections.Generic;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class UsersRealtimeMessageDto : RealtimeMessageDto
    {
        public IReadOnlyList<string> UserIds { get; set; }
    }
}