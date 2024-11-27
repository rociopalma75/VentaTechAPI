using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : CrudController<ProveedorRequestDTO, ProveedorResponseDTO>
    {
        public ProveedorController(ICrudService<ProveedorRequestDTO, ProveedorResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
