using FewBox.Core.Web.Dto;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Service.RealTime.Model.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.RealTime.Controllers
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [Authorize(Policy = "JWTRole_ControllerAction")]
    public class FewBoxController : ControllerBase
    {
        private  IFewBoxService FewBoxService { get; set; }

        public FewBoxController(IFewBoxService fewBoxService)
        {
            this.FewBoxService = fewBoxService;
        }

        [HttpGet]
        public PayloadResponseDto<AuthorDto> Get()
        {
            return new PayloadResponseDto<AuthorDto>
            {
                Payload =this.FewBoxService.GetAuthor()
            };
        }
    }
}
