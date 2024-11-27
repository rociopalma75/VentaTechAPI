using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.ViewControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ViewController<EstadoDTO>
    {
        public EstadoController(IViewService<EstadoDTO> viewService) : base(viewService)
        {
        }
    }
}
