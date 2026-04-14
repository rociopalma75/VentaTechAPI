using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.View
{
    public class TipoInteraccionRepository : ViewRepository<TipoInteraccion>
    {
        public TipoInteraccionRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.TiposInteraccion.AnyAsync(x => x.Id == id);
        }
    }
}
