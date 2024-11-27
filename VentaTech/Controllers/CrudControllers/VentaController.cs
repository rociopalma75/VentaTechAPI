using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : CrudController<VentaRequestDTO, VentaResponseDTO>
    {
        public VentaController(ICrudService<VentaRequestDTO, VentaResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
