using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class ProveedorService : CrudService<Proveedor, ProveedorResponseDTO, ProveedorRequestDTO>
    {
        public ProveedorService(ICrudRepository<Proveedor> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
