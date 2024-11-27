using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class ProductoServicioService : CrudService<ProductoServicio, ProductoServicioResponseDTO, ProductoServicioRequestDTO>
    {
        public ProductoServicioService(ICrudRepository<ProductoServicio> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
