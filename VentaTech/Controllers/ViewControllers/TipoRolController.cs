using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Services.Contracts;

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
