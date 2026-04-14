using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class ClienteService : CrudService<Cliente, ClienteResponseDTO, ClienteRequestDTO>
    {
        public ClienteService(ICrudRepository<Cliente> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
