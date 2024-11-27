using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class RegistroRepository : CrudRepository<Registro>
    {
        public RegistroRepository(AppDbContext context) : base(context)
        {
        }

        protected override Expression<Func<Registro, object>>[] PropertiesNavigations => [r => r.IdProductoServicioNavigation, r => r.IdEmpleadoNavigation];

        public override async Task DeleteAsync(Registro entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Registros.AnyAsync(r => r.Id == id);
        }
    }
}
