using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.Contracts
{
    public interface IEmpleadoRepository : ICrudRepository<Empleado>
    {
        Task<bool> ExistsCorreo(string correo);
        Task<Empleado> GetEmpleadoByCorreo(string correo);  
    }
}
