using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers
{
    public abstract class CrudController<TRequestDTO, TResponseDTO> : ViewController<TResponseDTO>
        where TResponseDTO : class
        where TRequestDTO : class
    {
        protected readonly ICrudService<TRequestDTO, TResponseDTO> _serviceCrud;

        public CrudController(ICrudService<TRequestDTO, TResponseDTO> serviceCrud) : base(serviceCrud)
        {
            _serviceCrud = serviceCrud;
        }

        [HttpPost]
        public async Task<ActionResult<TResponseDTO>> Post(TRequestDTO request)
        {
            try
            {
                TResponseDTO responseCreated = await _serviceCrud.CreateAsync(request);
                return Ok(responseCreated);
            }
            catch (DbUpdateException ex)
            {
                return BadRequest(ex.InnerException?.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException?.Message ??  "Ocurrio un error inesperado");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<TResponseDTO>> Put(int id, TRequestDTO request)
        {
            try
            {
                TResponseDTO? responseUpdated = await _serviceCrud.UpdateAsync(id, request);
                if (responseUpdated == null) return NotFound();
                return Ok(responseUpdated);
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
                bool eliminado = await _serviceCrud.DeleteAsync(id);
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
