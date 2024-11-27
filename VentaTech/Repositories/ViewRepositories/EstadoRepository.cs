using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.View
{
    public class EstadoRepository : ViewRepository<Estado>
    {
        public EstadoRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Estados.AnyAsync(e => e.Id == id);
        }
    }
}
