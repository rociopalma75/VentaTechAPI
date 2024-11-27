using Microsoft.EntityFrameworkCore;
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
