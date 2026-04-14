using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
