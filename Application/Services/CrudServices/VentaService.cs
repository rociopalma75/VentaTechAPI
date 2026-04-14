using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.CrudServices
{
    public class VentaService : CrudService<Venta, VentaResponseDTO, VentaRequestDTO>
    {
        public VentaService(ICrudRepository<Venta> crudRepository, IMapper mapper) : base(crudRepository, mapper)
        {
        }
    }
}
