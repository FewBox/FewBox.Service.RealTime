using System.Collections.Generic;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class GroupsRealtimeMessageDto : RealtimeMessageDto
    {
        public IReadOnlyList<string> GroupNames { get; set; }
    }
}