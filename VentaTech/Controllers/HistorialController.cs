using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistorialController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Historial
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Historial>>> GetHistorials()
        {
            return await _context.Historials.ToListAsync();
        }

        // GET: api/Historial/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Historial>> GetHistorial(int id)
        {
            var historial = await _context.Historials.FindAsync(id);

            if (historial == null)
            {
                return NotFound();
            }

            return historial;
        }

    }
}
