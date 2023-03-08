using System.Collections.Generic;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class GroupExceptRealtimeMessageDto : RealtimeMessageDto
    {
        public string GroupName { get; set; }
        public IReadOnlyList<string> ExcludedConnectionIds { get; set; }
    }
}