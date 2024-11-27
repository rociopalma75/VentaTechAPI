using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Models.DTO.ViewsDTO;

namespace VentaTechAPI.Mapping
{
    public class MappingResponse : Profile
    {
        public MappingResponse()
        { 
            //Read
            CreateMap<Departamento, DepartamentoDTO>();
            CreateMap<DetalleRanking, DetalleRankingDTO>();
            CreateMap<Estado, EstadoDTO>();
            CreateMap<TipoInteraccion, TipoInteraccionDTO>();
            CreateMap<TipoRol, TipoRolDTO>();

            //Crud
            CreateMap<Cliente, ClienteResponseDTO>();
            CreateMap<Empleado, EmpleadoResponseDTO>();
            CreateMap<Interaccione, InteraccionesResponseDTO>();   
            CreateMap<Proveedor,  ProveedorResponseDTO>();
            CreateMap<ProductoServicio, ProductoServicioResponseDTO>();
            CreateMap<Registro, RegistroResponseDTO>();
            CreateMap<ProductoSoftware, ProductoSoftwareResponseDTO>();
            CreateMap<Venta, VentaResponseDTO>();
        }

    }
}
