using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoSoftwareController : CrudController<ProductoSoftwareRequestDTO, ProductoSoftwareResponseDTO>
    {
        public ProductoSoftwareController(ICrudService<ProductoSoftwareRequestDTO, ProductoSoftwareResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
