using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : CrudController<RegistroRequestDTO, RegistroResponseDTO>
    {
        public RegistroController(ICrudService<RegistroRequestDTO, RegistroResponseDTO> serviceCrud) : base(serviceCrud)
        {
        }
    }
}
