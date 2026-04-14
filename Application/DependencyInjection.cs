using Application.DTOs.CrudDTO;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Services;
using Application.Services.CrudServices;
using Application.Services.ViewServices;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // FluentValidation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


            services.AddScoped<IViewService<DepartamentoDTO>, DepartamentoService>();
            services.AddScoped<IViewService<EstadoDTO>, EstadoService>();
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

            return services;
        }
    }
}
