using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IEmpleadoRepository : ICrudRepository<Empleado>
    {
        Task<bool> ExistsCorreo(string correo);
        Task<Empleado> GetEmpleadoByCorreo(string correo);  
    }
}
