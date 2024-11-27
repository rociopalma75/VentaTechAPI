using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Services.Contracts
{
    public interface IEmpleadoService : ICrudService<EmpleadoRequestDTO, EmpleadoResponseDTO>
    {
        Task<bool> LoginAsync(EmpleadoLoginDTO request);

        Task<EmpleadoResponseDTO> UpdateAsync(int id, EmpleadoEditRequestDTO request);
    }
}
