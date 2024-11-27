using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.View
{
    public class DepartamentoRepository : ViewRepository<Departamento>
    {
        public DepartamentoRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Departamentos.AnyAsync(x => x.Id == id);
        }
    }
}
