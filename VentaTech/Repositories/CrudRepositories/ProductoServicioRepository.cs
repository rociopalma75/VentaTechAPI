using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class ProductoServicioRepository : CrudRepository<ProductoServicio>
    {
        public ProductoServicioRepository(AppDbContext context) : base(context)
        {
        }
        protected override Expression<Func<ProductoServicio, object>>[] PropertiesNavigations => [ps => ps.IdProveedorNavigation];

        public override async Task DeleteAsync(ProductoServicio entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.ProductoServicios.AnyAsync(p => p.Id == id);
        }
    }
}
