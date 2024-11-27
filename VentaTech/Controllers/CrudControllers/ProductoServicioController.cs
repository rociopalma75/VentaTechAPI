using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoServicioController : CrudController<ProductoServicioRequestDTO, ProductoServicioResponseDTO>
    {
        public ProductoServicioController(ICrudService<ProductoServicioRequestDTO, ProductoServicioResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
