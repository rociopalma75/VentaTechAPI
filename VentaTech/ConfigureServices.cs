
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.CrudDTO;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;
using VentaTechAPI.Repositories.CrudRepositories;
using VentaTechAPI.Repositories.View;
using VentaTechAPI.Services.Contracts;
using VentaTechAPI.Services.CrudServices;
using VentaTechAPI.Services.ViewServices;

namespace VentaTechAPI
{
    public class ConfigureServices
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IViewRepository<Departamento>, DepartamentoRepository>();
            services.AddScoped<IViewRepository<DetalleRanking>, DetalleRankingRepository>();
            services.AddScoped<IViewRepository<Estado>, EstadoRepository>();
            services.AddScoped<IViewRepository<TipoInteraccion>, TipoInteraccionRepository>();
            services.AddScoped<IViewRepository<TipoRol>, TipoRolRepository>();

            services.AddScoped<ICrudRepository<Cliente>, ClienteRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<ICrudRepository<Interaccione>, InteraccionesRepository>();
            services.AddScoped<ICrudRepository<Proveedor>, ProveedorRepository>();  
            services.AddScoped<ICrudRepository<ProductoServicio>, ProductoServicioRepository>();
            services.AddScoped<ICrudRepository<Registro>, RegistroRepository>();
            services.AddScoped<ICrudRepository<ProductoSoftware>, ProductoSoftwareRepository>();
            services.AddScoped<ICrudRepository<Venta>, VentaRepository>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IViewService<DepartamentoDTO>, DepartamentoService>();
            services.AddScoped<IViewService<EstadoDTO>,  EstadoService>();
            services.AddScoped<IViewService<TipoRolDTO>, TipoRolService>();
            services.AddScoped<IViewService<TipoInteraccionDTO>, TipoInteraccionService>();
            services.AddScoped<IViewService<DetalleRankingDTO>, DetalleRankingService>();

            services.AddScoped<ICrudService<ClienteRequestDTO, ClienteResponseDTO>, ClienteService>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
            services.AddScoped<ICrudService<InteraccionesRequestDTO, InteraccionesResponseDTO>, InteraccionesServices>();
            services.AddScoped<ICrudService<ProveedorRequestDTO, ProveedorResponseDTO>, ProveedorService>();
            services.AddScoped<ICrudService<ProductoServicioRequestDTO, ProductoServicioResponseDTO>, ProductoServicioService>();
            services.AddScoped<ICrudService<RegistroRequestDTO, RegistroResponseDTO>, RegistroService>();
            services.AddScoped<ICrudService<ProductoSoftwareRequestDTO, ProductoSoftwareResponseDTO>, ProductoSoftwareService>();
            services.AddScoped<ICrudService<VentaRequestDTO, VentaResponseDTO>, VentaService>();
        }
    }
}
