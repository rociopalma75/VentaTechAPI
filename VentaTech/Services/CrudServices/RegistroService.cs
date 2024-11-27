using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class RegistroService : CrudService<Registro, RegistroResponseDTO, RegistroRequestDTO>
    {
        public RegistroService(ICrudRepository<Registro> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
