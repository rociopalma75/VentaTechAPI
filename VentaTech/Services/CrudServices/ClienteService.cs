using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class ClienteService : CrudService<Cliente, ClienteResponseDTO, ClienteRequestDTO>
    {
        public ClienteService(ICrudRepository<Cliente> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
