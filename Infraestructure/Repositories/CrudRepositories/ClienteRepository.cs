using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class ClienteRepository : CrudRepository<Cliente>
    {
        public ClienteRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task DeleteAsync(Cliente entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Clientes.AnyAsync(c => c.Id == id);
        }
    }
}
