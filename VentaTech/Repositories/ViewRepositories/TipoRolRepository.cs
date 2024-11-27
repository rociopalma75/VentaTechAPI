using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.View
{
    public class TipoRolRepository : ViewRepository<TipoRol>
    {
        public TipoRolRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.TipoRols.AnyAsync(r => r.Id == id);
        }
    }
}
