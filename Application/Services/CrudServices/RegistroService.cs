using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class RegistroService : CrudService<Registro, RegistroResponseDTO, RegistroRequestDTO>
    {
        public RegistroService(ICrudRepository<Registro> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
