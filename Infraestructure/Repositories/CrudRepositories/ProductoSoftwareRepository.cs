using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using Domain.Entities;
using Infraestructure.Data;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class ProductoSoftwareRepository : CrudRepository<ProductoSoftware>
    {
        public ProductoSoftwareRepository(VentaTechContext context) : base(context)
        {
        }

        protected override Expression<Func<ProductoSoftware, object>>[] PropertiesNavigations => [ps => ps.Cliente, ps => ps.Estado];

        public override async Task DeleteAsync(ProductoSoftware entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.ProductosSoftware.AnyAsync(p => p.Id == id);  
        }
    }
}
