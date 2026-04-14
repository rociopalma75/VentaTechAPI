using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class ProductoServicioService : CrudService<ProductoServicio, ProductoServicioResponseDTO, ProductoServicioRequestDTO>
    {
        public ProductoServicioService(ICrudRepository<ProductoServicio> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
