using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class InteraccionesRepository : CrudRepository<Interaccione>
    {
        public InteraccionesRepository(AppDbContext context) : base(context)
        {
        }

        protected override Expression<Func<Interaccione, object>>[] PropertiesNavigations => [i => i.IdTipoInteraccionNavigation, i => i.IdClienteNavigation, i => i.IdEmpleadoNavigation];

        public override async Task DeleteAsync(Interaccione entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Interacciones.AnyAsync(i => i.Id == id);
        }
    }
}
