using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace  Application.Services.CrudServices
{
    public class InteraccionesServices : CrudService<Interaccion, InteraccionesResponseDTO, InteraccionesRequestDTO>
    {
        public InteraccionesServices(ICrudRepository<Interaccion> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
