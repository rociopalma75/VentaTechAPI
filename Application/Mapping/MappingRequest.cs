using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;

namespace Application.Mapping
{
    public class MappingRequest : Profile
    {
        public MappingRequest() 
        {
            CreateMap<ClienteRequestDTO, Cliente>();
            CreateMap<EmpleadoRequestDTO, Empleado>();
            CreateMap<ProductoServicioRequestDTO, ProductoServicio>();
            CreateMap<ProductoSoftwareRequestDTO, ProductoSoftware>();
            CreateMap<ProveedorRequestDTO, Proveedor>();
            CreateMap<VentaRequestDTO, Venta>();  
            CreateMap<RegistroRequestDTO, Registro>();
            CreateMap<InteraccionesRequestDTO, Interaccion>();
            CreateMap<EmpleadoEditRequestDTO, Empleado>();
        }

    }
}
