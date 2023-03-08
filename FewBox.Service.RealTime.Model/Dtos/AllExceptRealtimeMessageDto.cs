using System.Collections.Generic;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class AllExceptRealtimeMessageDto : RealtimeMessageDto
    {
        public IReadOnlyList<string> ExcludedConnectionIds { get; set; }
    }
}