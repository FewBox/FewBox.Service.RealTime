using AutoMapper;
using FewBox.Core.Web.Controller;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Service.RealTime.Model.Entities;
using FewBox.Service.RealTime.Model.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.RealTime.Controllers
{
    [Authorize(Policy="JWTRole_ControllerAction")]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class AppsController : ResourcesController<IAppRepository, App, AppDto, AppPersistantDto>
    {
        public AppsController(IAppRepository appRepository, IMapper mapper) : base(appRepository, mapper)
        {
            // SQLite ID must be Upcase.
        }
    }
}
