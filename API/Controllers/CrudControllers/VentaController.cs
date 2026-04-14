using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;  

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
