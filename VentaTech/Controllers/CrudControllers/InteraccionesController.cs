using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteraccionesController : CrudController<InteraccionesRequestDTO, InteraccionesResponseDTO>
    {
        public InteraccionesController(ICrudService<InteraccionesRequestDTO, InteraccionesResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
