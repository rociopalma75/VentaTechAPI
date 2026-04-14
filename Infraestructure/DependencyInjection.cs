using Application.Interfaces.Repositories;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Repositories.CrudRepositories;
using Infraestructure.Repositories.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
                this IServiceCollection services,
                 IConfiguration configuration)
        {
            services.AddDbContext<VentaTechContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("VentaTechContext") ?? throw new InvalidOperationException("Connection string 'VentaTechContext' not found.")));


            services.AddScoped<IViewRepository<Departamento>, DepartamentoRepository>();
            services.AddScoped<IViewRepository<DetalleRanking>, DetalleRankingRepository>();
            services.AddScoped<IViewRepository<Estado>, EstadoRepository>();
            services.AddScoped<IViewRepository<TipoInteraccion>, TipoInteraccionRepository>();
            services.AddScoped<IViewRepository<TipoRol>, TipoRolRepository>();

            services.AddScoped<ICrudRepository<Cliente>, ClienteRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<ICrudRepository<Interaccion>, InteraccionesRepository>();
            services.AddScoped<ICrudRepository<Proveedor>, ProveedorRepository>();
            services.AddScoped<ICrudRepository<ProductoServicio>, ProductoServicioRepository>();
            services.AddScoped<ICrudRepository<Registro>, RegistroRepository>();
            services.AddScoped<ICrudRepository<ProductoSoftware>, ProductoSoftwareRepository>();
            services.AddScoped<ICrudRepository<Venta>, VentaRepository>();

            return services;
        }

        

    }
}
