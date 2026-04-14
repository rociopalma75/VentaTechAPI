using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Domain.Entities;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class ProveedorRepository : CrudRepository<Proveedor>
    {
        public ProveedorRepository(VentaTechContext context) : base(context)
        {
        }
        protected override Expression<Func<Proveedor, object>>[] PropertiesNavigations => [prov => prov.DetalleRanking];
        public override async Task DeleteAsync(Proveedor entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Proveedores.AnyAsync(p => p.Id == id);
        }
    }
}
