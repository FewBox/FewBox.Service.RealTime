using Microsoft.AspNetCore.Http;

namespace FewBox.Service.RealTime.Model.Dtos
{
    public class FileDto
    {
        public IFormFile Data { get; set; }
    }
}