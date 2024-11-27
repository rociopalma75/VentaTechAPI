using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class ProductoSoftwareRepository : CrudRepository<ProductoSoftware>
    {
        public ProductoSoftwareRepository(AppDbContext context) : base(context)
        {
        }

        protected override Expression<Func<ProductoSoftware, object>>[] PropertiesNavigations => [ps => ps.IdClienteNavigation, ps => ps.IdEstadoNavigation];

        public override async Task DeleteAsync(ProductoSoftware entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.ProductoSoftwares.AnyAsync(p => p.Id == id);  
        }
    }
}
