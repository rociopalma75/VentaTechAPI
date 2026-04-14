using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Domain.Entities;
using Application.Interfaces.Repositories;
using Infraestructure.Data;

namespace Infraestructure.Repositories.CrudRepositories
{
    public class InteraccionesRepository : CrudRepository<Interaccion>
    {
        public InteraccionesRepository(VentaTechContext context) : base(context)
        {
        }

        protected override Expression<Func<Interaccion, object>>[] PropertiesNavigations => [i => i.TipoInteraccion, i => i.Cliente, i => i.Empleado];

        public override async Task DeleteAsync(Interaccion entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Interacciones.AnyAsync(i => i.Id == id);
        }
    }
}
