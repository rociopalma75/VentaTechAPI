using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.View
{
    public class TipoInteraccionRepository : ViewRepository<TipoInteraccion>
    {
        public TipoInteraccionRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.TipoInteraccions.AnyAsync(x => x.Id == id);
        }
    }
}
