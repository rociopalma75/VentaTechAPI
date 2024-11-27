using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;
using VentaTechAPI.Services.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadorRepository;
        private readonly IMapper _mapper;
    
        public EmpleadoService(IEmpleadoRepository empleadorRepository, IMapper mapper)
        {
            _mapper = mapper;
            _empleadorRepository = empleadorRepository;
        }
        //Registrar empleado
        public async Task<EmpleadoResponseDTO> CreateAsync(EmpleadoRequestDTO requestDTO)
        {
            bool exitsCorreo = await _empleadorRepository.ExistsCorreo(requestDTO.Correo);

            if (exitsCorreo) throw new ArgumentException("Error, ingreso un correo ya existente");

            Empleado empleado = _mapper.Map<Empleado>(requestDTO);
            empleado.HashClave = BCrypt.Net.BCrypt.HashPassword(empleado.HashClave);
            empleado = await _empleadorRepository.CreateAsync(empleado);
            EmpleadoResponseDTO empleadoDTO = _mapper.Map<EmpleadoResponseDTO>(empleado);

            return empleadoDTO;
        }


        public async Task<bool> LoginAsync(EmpleadoLoginDTO loginDTO)
        {
            Empleado empleado = await _empleadorRepository.GetEmpleadoByCorreo(loginDTO.Correo) ?? throw new Exception("Error, no se encuentra el correo");

            bool verify = BCrypt.Net.BCrypt.Verify(loginDTO.Clave, empleado.HashClave);

            return verify;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            bool empleadoExist = await _empleadorRepository.ExistsAsync(id);

            if (!empleadoExist) throw new ArgumentException($"El id {id} no se encuentra");
        
            Empleado empleado = await _empleadorRepository.GetByIdAsync(id);
            await _empleadorRepository.DeleteAsync(empleado);
            return true;
        }

        public async Task<List<EmpleadoResponseDTO>> GetAllAsync()
        {
            var results = await _empleadorRepository.GetAllAsync();
            return _mapper.Map<List<EmpleadoResponseDTO>>(results);
        }

        public async Task<EmpleadoResponseDTO?> GetByIdAsync(int id)
        {
            Empleado? result = await _empleadorRepository.GetByIdAsync(id);

            if (result == null) return null;

            return _mapper.Map<EmpleadoResponseDTO>(result);
        }

        public async Task<EmpleadoResponseDTO?> UpdateAsync(int id, EmpleadoRequestDTO requestDTO)
        {
            Empleado? empleado = await _empleadorRepository.GetByIdAsync(id);

            if (empleado == null) return null;

            _mapper.Map(requestDTO, empleado);

            empleado = await _empleadorRepository.UpdateAsync(empleado);

            return _mapper.Map<EmpleadoResponseDTO>(empleado); 
        }

        public async Task<EmpleadoResponseDTO?> UpdateAsync(int id, EmpleadoEditRequestDTO requestDTO)
        {
            Empleado? empleado = await _empleadorRepository.GetByIdAsync(id);

            if (empleado == null) return null;

            _mapper.Map(requestDTO, empleado);

            empleado = await _empleadorRepository.UpdateAsync(empleado);

            return _mapper.Map<EmpleadoResponseDTO>(empleado);
        }
    }
}
