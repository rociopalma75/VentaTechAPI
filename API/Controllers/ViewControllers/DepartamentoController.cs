using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Services;

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
