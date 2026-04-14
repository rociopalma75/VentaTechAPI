using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
