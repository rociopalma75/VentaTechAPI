using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Models;

namespace VentaTechAPI.Context;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DetalleRanking> DetalleRankings { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Historial> Historials { get; set; }

    public virtual DbSet<Interaccione> Interacciones { get; set; }

    public virtual DbSet<ProductoServicio> ProductoServicios { get; set; }

    public virtual DbSet<ProductoSoftware> ProductoSoftwares { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<TipoInteraccion> TipoInteraccions { get; set; }

    public virtual DbSet<TipoRol> TipoRols { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cliente__3213E83F2BCE04DA");

            entity.ToTable("cliente", tb =>
                {
                    tb.HasTrigger("ClienteAfterInsert");
                    tb.HasTrigger("ClienteAfterUpdate");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CuilCuit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cuil_cuit");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departam__3213E83F4CCEFB43");

            entity.ToTable("departamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreDepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreDepto");
        });

        modelBuilder.Entity<DetalleRanking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__detalleR__3213E83F615EBCE8");

            entity.ToTable("detalleRanking");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calificacion).HasColumnName("calificacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__empleado__3213E83FC006B4A6");

            entity.ToTable("empleado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Correo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Cuil)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cuil");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.FechaContratacion).HasColumnName("fecha_contratacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.HashClave).HasColumnName("hashClave");
            entity.Property(e => e.IdDepto).HasColumnName("id_Depto");
            entity.Property(e => e.IdTipoRol).HasColumnName("id_tipoRol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdDeptoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdDepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__empleado__id_Dep__5165187F");

            entity.HasOne(d => d.IdTipoRolNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdTipoRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__empleado__id_tip__5070F446");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__estado__3213E83F38B898CF");

            entity.ToTable("estado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreEstado");
        });

        modelBuilder.Entity<Historial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__historia__3213E83F042805D1");

            entity.ToTable("historial");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("accion");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fechaHora");
        });

        modelBuilder.Entity<Interaccione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__interacc__3213E83F5849E957");

            entity.ToTable("interacciones");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdCliente).HasColumnName("id_Cliente");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_Empleado");
            entity.Property(e => e.IdTipoInteraccion).HasColumnName("id_TipoInteraccion");
            entity.Property(e => e.Motivo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("motivo");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Interacciones)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__interacci__id_Cl__5812160E");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Interacciones)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__interacci__id_Em__59063A47");

            entity.HasOne(d => d.IdTipoInteraccionNavigation).WithMany(p => p.Interacciones)
                .HasForeignKey(d => d.IdTipoInteraccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__interacci__id_Ti__59FA5E80");
        });

        modelBuilder.Entity<ProductoServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F54306B65");

            entity.ToTable("producto_servicio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_Proveedor");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProductoServicios)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__producto___id_Pr__6C190EBB");
        });

        modelBuilder.Entity<ProductoSoftware>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83FD40445EA");

            entity.ToTable("productoSoftware");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.IdCliente).HasColumnName("id_Cliente");
            entity.Property(e => e.IdEstado).HasColumnName("id_Estado");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreProducto");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ProductoSoftwares)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__productoS__id_Cl__5EBF139D");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.ProductoSoftwares)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__productoS__id_Es__5FB337D6");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__proveedo__3213E83F6167FF2E");

            entity.ToTable("proveedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cuit");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.IdRanking).HasColumnName("id_ranking");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("razonSocial");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdRankingNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdRanking)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__proveedor__id_ra__693CA210");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__registro__3213E83F23A66701");

            entity.ToTable("registro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdEmpleado).HasColumnName("id_Empleado");
            entity.Property(e => e.IdProductoServicio).HasColumnName("id_ProductoServicio");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registro__id_Emp__6EF57B66");

            entity.HasOne(d => d.IdProductoServicioNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdProductoServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registro__id_Pro__6FE99F9F");
        });

        modelBuilder.Entity<TipoInteraccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoInte__3213E83FB6B495FA");

            entity.ToTable("tipoInteraccion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoRol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tipoRol__3213E83F6B452804");

            entity.ToTable("tipoRol");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreRol");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__venta__3213E83FEF0FFC04");

            entity.ToTable("venta");

            entity.HasIndex(e => e.IdProductoSoftware, "UQ__venta__C97780707CF9C4E0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EstadoActivo)
                .HasDefaultValue(true)
                .HasColumnName("estadoActivo");
            entity.Property(e => e.FechaEntrega).HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.IdEmpleadoInstala).HasColumnName("id_empleado_instala");
            entity.Property(e => e.IdEmpleadoRealiza).HasColumnName("id_empleado_realiza");
            entity.Property(e => e.IdProductoSoftware).HasColumnName("id_productoSoftware");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdEmpleadoInstalaNavigation).WithMany(p => p.VentumIdEmpleadoInstalaNavigations)
                .HasForeignKey(d => d.IdEmpleadoInstala)
                .HasConstraintName("FK__venta__id_emplea__6477ECF3");

            entity.HasOne(d => d.IdEmpleadoRealizaNavigation).WithMany(p => p.VentumIdEmpleadoRealizaNavigations)
                .HasForeignKey(d => d.IdEmpleadoRealiza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__venta__id_emplea__6383C8BA");

            entity.HasOne(d => d.IdProductoSoftwareNavigation).WithOne(p => p.Ventum)
                .HasForeignKey<Venta>(d => d.IdProductoSoftware)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__venta__id_produc__628FA481");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
