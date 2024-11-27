using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Models;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Controllers
{
    public abstract class ViewController<TResponseDTO> : ControllerBase where TResponseDTO : class
    {
        protected readonly IViewService<TResponseDTO> _viewService;

        public ViewController(IViewService<TResponseDTO> viewService)
        {
            _viewService = viewService;
        }

        // GET: api/Entity
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TResponseDTO>>> GetAllAsync()
        {
            var results = await _viewService.GetAllAsync();

            return Ok(results);
        }

        // GET: api/Entity/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TResponseDTO>> GetByIdAsync(int id)
        {
            var result = await _viewService.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
