using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : CrudController<ClienteRequestDTO, ClienteResponseDTO>
    {
        public ClienteController(ICrudService<ClienteRequestDTO, ClienteResponseDTO> serviceCrud) : base(serviceCrud )
        {
        }
    }
}
