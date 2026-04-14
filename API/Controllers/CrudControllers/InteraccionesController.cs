using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
