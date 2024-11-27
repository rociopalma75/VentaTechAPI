using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class ProveedorRepository : CrudRepository<Proveedor>
    {
        public ProveedorRepository(AppDbContext context) : base(context)
        {
        }
        protected override Expression<Func<Proveedor, object>>[] PropertiesNavigations => [prov => prov.IdRankingNavigation];
        public override async Task DeleteAsync(Proveedor entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Proveedors.AnyAsync(p => p.Id == id);
        }
    }
}
