using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using FewBox.Core.Web.Controller;
using FewBox.Core.Web.Dto;
using FewBox.Service.RealTime.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.RealTime.Controllers
{
    [ApiController]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class StorageController : MapperController
    {
        private IWebDavService WebDavService { get; set; }
        public StorageController(IWebDavService webDavService, IMapper mapper) : base(mapper)
        {
            this.WebDavService = webDavService;
        }

        [HttpPost]
        public async Task<MetaResponseDto> UploadFile(IFormFile formFile)
        {
            if (formFile.Length > 0)
            {
                byte[] fileData;
                using (var inputStream = new MemoryStream())
                {
                    await formFile.CopyToAsync(inputStream);
                    fileData = inputStream.ToArray(); // Original
                }
                await this.WebDavService.UploadFile(formFile.FileName, fileData);
            }
            return new MetaResponseDto();
        }
    }
}