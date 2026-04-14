using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class VentaTechContext : DbContext
    {
        public VentaTechContext(DbContextOptions<VentaTechContext> options) : base(options)
        {
        }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DetalleRanking> DetallesRanking { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Historial> Historial { get; set; }
        public DbSet<Interaccion> Interacciones { get; set; }
        public DbSet<ProductoServicio> ProductosServicios { get; set; }
        public DbSet<ProductoSoftware> ProductosSoftware { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<TipoRol> TiposRol { get; set; }
        public DbSet<TipoInteraccion> TiposInteraccion { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuraciones adicionales de entidades y relaciones
        }
    }
}
