using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.ViewControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ViewController<DepartamentoDTO>
    {
        public DepartamentoController(IViewService<DepartamentoDTO> viewService) : base(viewService)
        {
        }
    }
}
