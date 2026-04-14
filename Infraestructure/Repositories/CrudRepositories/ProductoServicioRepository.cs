using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Domain.Entities;
using Infraestructure.Data;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class ProductoServicioRepository : CrudRepository<ProductoServicio>
    {
        public ProductoServicioRepository(VentaTechContext context) : base(context)
        {
        }
        protected override Expression<Func<ProductoServicio, object>>[] PropertiesNavigations => [ps => ps.Proveedor];

        public override async Task DeleteAsync(ProductoServicio entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.ProductosServicios.AnyAsync(p => p.Id == id);
        }
    }
}
