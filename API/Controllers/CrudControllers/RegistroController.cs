using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Services;

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
