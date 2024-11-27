using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class InteraccionesServices : CrudService<Interaccione, InteraccionesResponseDTO, InteraccionesRequestDTO>
    {
        public InteraccionesServices(ICrudRepository<Interaccione> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
