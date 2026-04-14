using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.View
{
    public class EstadoRepository : ViewRepository<Estado>
    {
        public EstadoRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Estados.AnyAsync(e => e.Id == id);
        }
    }
}
