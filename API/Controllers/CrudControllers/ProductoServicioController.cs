using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
