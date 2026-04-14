using Application.DTOs.CrudDTO;

namespace Application.Interfaces.Services
{
    public interface IEmpleadoService : ICrudService<EmpleadoRequestDTO, EmpleadoResponseDTO>
    {
        Task<bool> LoginAsync(EmpleadoLoginDTO request);

        Task<EmpleadoResponseDTO> UpdateAsync(int id, EmpleadoEditRequestDTO request);
    }
}
