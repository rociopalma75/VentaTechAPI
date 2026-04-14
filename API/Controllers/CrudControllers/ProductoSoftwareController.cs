using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
