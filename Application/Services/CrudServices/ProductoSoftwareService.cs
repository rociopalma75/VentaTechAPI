using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class ProductoSoftwareService : CrudService<ProductoSoftware, ProductoSoftwareResponseDTO, ProductoSoftwareRequestDTO>
    {
        public ProductoSoftwareService(ICrudRepository<ProductoSoftware> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
