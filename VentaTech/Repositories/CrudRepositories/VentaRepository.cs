using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class VentaRepository : CrudRepository<Venta>
    {
        public VentaRepository(AppDbContext context) : base(context)
        {
        }

        protected override Expression<Func<Venta, object>>[] PropertiesNavigations => [v => v.IdProductoSoftwareNavigation, v => v.IdEmpleadoInstalaNavigation, v => v.IdEmpleadoRealizaNavigation];

        public override async Task<Venta> CreateAsync(Venta venta)
        {
            ProductoSoftware ps = await _context.ProductoSoftwares.Where(p => p.Id == venta.IdProductoSoftware).FirstOrDefaultAsync();

            venta.Total = ps.Precio;

            EntityEntry<Venta> entityInserted = await _context.Set<Venta>().AddAsync(venta);
            await _context.SaveChangesAsync();
            //return entityInserted.Entity;
            IQueryable<Venta> query = _context.Set<Venta>();

            foreach (var property in PropertiesNavigations)
            {
                query = query.Include(property);
            }

            int primaryKeyValue = (int)entityInserted.Property("Id").CurrentValue;

            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == primaryKeyValue) ?? throw new InvalidOperationException("La entidad no pudo ser recuperada con las propiedades de navegación.");
        }

        public async override Task DeleteAsync(Venta entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Venta.AnyAsync(v => v.Id == id);
        }
    }
}
