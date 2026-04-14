using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.View
{
    public class DepartamentoRepository : ViewRepository<Departamento>
    {
        public DepartamentoRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Departamentos.AnyAsync(x => x.Id == id);
        }
    }
}
