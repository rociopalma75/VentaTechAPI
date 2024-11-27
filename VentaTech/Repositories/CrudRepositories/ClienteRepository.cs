using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class ClienteRepository : CrudRepository<Cliente>
    {
        public ClienteRepository(AppDbContext context) : base(context)
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
