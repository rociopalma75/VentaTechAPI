using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.DTOs.ViewsDTO;

namespace Application.Mapping
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
            CreateMap<Interaccion, InteraccionesResponseDTO>();   
            CreateMap<Proveedor,  ProveedorResponseDTO>();
            CreateMap<ProductoServicio, ProductoServicioResponseDTO>();
            CreateMap<Registro, RegistroResponseDTO>();
            CreateMap<ProductoSoftware, ProductoSoftwareResponseDTO>();
            CreateMap<Venta, VentaResponseDTO>();
        }

    }
}
