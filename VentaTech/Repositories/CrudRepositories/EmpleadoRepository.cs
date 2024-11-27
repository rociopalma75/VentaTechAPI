using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Models;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Repositories.CrudRepositories
{
    public class EmpleadoRepository : CrudRepository<Empleado> , IEmpleadoRepository
    {
        public EmpleadoRepository(AppDbContext context) : base(context)
        {
        }
        protected override Expression<Func<Empleado, object>>[] PropertiesNavigations => [e => e.IdTipoRolNavigation, e => e.IdDeptoNavigation];


        public async Task<Empleado> GetEmpleadoByCorreo(string correo)
        {
            return await _context.Empleados.Where(e => e.Correo == correo).FirstOrDefaultAsync();
        }

        public override async Task DeleteAsync(Empleado entity)
        {
            entity.EstadoActivo = false;
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.Empleados.AnyAsync(e => e.Id == id);
        }

        public Task<bool> ExistsCorreo(string correo)
        {
            return _context.Empleados.AnyAsync(e => e.Correo == correo);
        }


    }
}
