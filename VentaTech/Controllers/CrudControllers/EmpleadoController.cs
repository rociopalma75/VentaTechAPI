using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers.CrudControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }
        
        [HttpGet]
        public async Task<ActionResult<EmpleadoResponseDTO>> GetEmpleado()
        {
            var results = await _empleadoService.GetAllAsync();
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmpleadoResponseDTO>> GetEmpleado(int id)
        {
            var result = await _empleadoService.GetByIdAsync(id);

            if(result == null) return NotFound();
            return result;
        }

        [HttpPost("SignIn")]
        public async Task<ActionResult<EmpleadoResponseDTO>> CreateEmpleado(EmpleadoRequestDTO empleadoRequestDTO)
        {
            try
            {
                EmpleadoResponseDTO empleadoCreated = await _empleadoService.CreateAsync(empleadoRequestDTO);
                return Ok(empleadoCreated);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.InnerException?.Message ?? "Ocurrio un error inesperado");
            }
        }

        [HttpPost("LogIn")]
        public async Task<ActionResult> LoginEmpleado(EmpleadoLoginDTO requestLogin)
        {
            try
            {
                bool verify = await _empleadoService.LoginAsync(requestLogin);

                if (verify)
                {
                    return Ok(new { message = "Se inicio sesión correctamente" });
                }
                else
                {
                    return BadRequest("Ingreso credenciales invalidas");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EmpleadoResponseDTO>> PutEmpleado(int id, EmpleadoEditRequestDTO empleado)
        {
            try
            {
                EmpleadoResponseDTO? empleadoUpdated = await _empleadoService.UpdateAsync(id, empleado);

                if (empleadoUpdated == null) return NotFound();

                return Ok(empleadoUpdated);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException?.Message ?? "Ocurrio un error inesperado");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                bool eliminado = await _empleadoService.DeleteAsync(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException?.Message ?? "Ocurrio un error inesperado");
            }
        }
        
    }
}
