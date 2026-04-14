using AutoMapper;
using Domain.Entities;
using Application.DTOs.CrudDTO;
using Application.DTOs.ViewsDTO;

namespace VentaTechAPI.Mapping
{
    public class MappingView : Profile
    {
        public MappingView() 
        {
            CreateMap<TipoRol, TipoRolViewDTO>();
            CreateMap<Departamento, DepartamentoViewDTO>();
            CreateMap<Empleado, EmpleadoViewDTO>();
            CreateMap<Cliente, ClienteViewDTO>();
            CreateMap<Proveedor, ProveedorViewDTO>();
            CreateMap<ProductoServicio, ProductoServicioViewDTO>();
            CreateMap<ProductoSoftware, ProductoSoftwareViewDTO>();
        }
    }
}
