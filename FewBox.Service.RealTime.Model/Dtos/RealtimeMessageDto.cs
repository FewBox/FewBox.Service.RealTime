using System.ComponentModel;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public abstract class RealtimeMessageDto
    {
        [DefaultValue("fewbox")]
        public string Method { get; set; }
#nullable enable
        public object? Arg1 { get; set; }
        public object? Arg2 { get; set; }
        public object? Arg3 { get; set; }
        public object? Arg4 { get; set; }
        public object? Arg5 { get; set; }
        public object? Arg6 { get; set; }
        public object? Arg7 { get; set; }
        public object? Arg8 { get; set; }
        public object? Arg9 { get; set; }
        public object? Arg10 { get; set; }
#nullable disable
    }
}