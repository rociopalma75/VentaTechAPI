using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.ViewControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleRankingController : ViewController<DetalleRankingDTO>
    {
        public DetalleRankingController(IViewService<DetalleRankingDTO> viewService) : base(viewService)
        {
        }
    }
}
