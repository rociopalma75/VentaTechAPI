using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class RegistroRepository : CrudRepository<Registro>
    {
        public RegistroRepository(VentaTechContext context) : base(context)
        {
        }

        protected override Expression<Func<Registro, object>>[] PropertiesNavigations => [r => r.ProductoServicio, r => r.Empleado];

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
