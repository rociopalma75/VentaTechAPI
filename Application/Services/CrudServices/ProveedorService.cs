using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class ProveedorService : CrudService<Proveedor, ProveedorResponseDTO, ProveedorRequestDTO>
    {
        public ProveedorService(ICrudRepository<Proveedor> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
