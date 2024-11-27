using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.CrudServices
{
    public class ProductoSoftwareService : CrudService<ProductoSoftware, ProductoSoftwareResponseDTO, ProductoSoftwareRequestDTO>
    {
        public ProductoSoftwareService(ICrudRepository<ProductoSoftware> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
