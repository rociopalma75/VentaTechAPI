using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.View
{
    public class TipoRolRepository : ViewRepository<TipoRol>
    {
        public TipoRolRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.TiposRol.AnyAsync(r => r.Id == id);
        }
    }
}
