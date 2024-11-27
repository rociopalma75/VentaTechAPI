using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Models.DTO.ViewsDTO;

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
