using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class VentaService : CrudService<Venta, VentaResponseDTO, VentaRequestDTO>
    {
        public VentaService(ICrudRepository<Venta> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
