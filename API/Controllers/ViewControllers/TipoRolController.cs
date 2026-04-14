using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Services;

namespace VentaTechAPI.Controllers.ViewControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoRolController : ViewController<TipoRolDTO>
    {
        public TipoRolController(IViewService<TipoRolDTO> viewService) : base(viewService)
        {
        }
    }
}
