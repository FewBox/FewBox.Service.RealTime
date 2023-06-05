using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using FewBox.Core.Web.Controller;
using FewBox.Core.Web.Dto;
using FewBox.Service.RealTime.Model.Services;
using FFMpegCore;
using FFMpegCore.Pipes;
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
                using (var inputStream = new MemoryStream())
                {
                    await formFile.CopyToAsync(inputStream);
                    var inputBytes = inputStream.ToArray();
                    bool isUploadSuccessful = await this.WebDavService.UploadFile(formFile.FileName, inputBytes);
                    if (isUploadSuccessful)
                    {
                        byte[] outputBytes;
                        var wavFileName = formFile.FileName.Replace(".weba", ".wav");
                        bool isProcessSuccessful = await FFMpegArguments
                        //.FromPipeInput(new StreamPipeSource(inputStream))
                        //.OutputToPipe(new StreamPipeSink(outputStream), options => options.ForceFormat("wav"))
                        .FromUrlInput(new Uri(this.WebDavService.GetFileUrl(formFile.FileName)))
                        //.OutputToPipe(new StreamPipeSink(outputStream), options => options.ForceFormat("wav"))
                        .OutputToFile(wavFileName)
                        .ProcessAsynchronously(true, new FFOptions { BinaryFolder = @"C:\AI\ffmpeg-N-110992-gb1c3d81e71-win64-gpl\bin", TemporaryFilesFolder = "/tmp" });
                        if (isProcessSuccessful)
                        {
                            outputBytes = System.IO.File.ReadAllBytes(wavFileName);
                        }
                        else
                        {
                            return new MetaResponseDto()
                            {
                                IsSuccessful = false
                            };
                        }
                        await this.WebDavService.UploadFile(wavFileName, outputBytes);
                    }
                    else
                    {
                        return new MetaResponseDto()
                        {
                            IsSuccessful = false
                        };
                    }
                }
            }
            return new MetaResponseDto();
        }
    }
}