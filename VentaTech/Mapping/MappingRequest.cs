using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;

namespace VentaTechAPI.Mapping
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
            CreateMap<InteraccionesRequestDTO, Interaccione>();
            CreateMap<EmpleadoEditRequestDTO, Empleado>();
        }

    }
}
