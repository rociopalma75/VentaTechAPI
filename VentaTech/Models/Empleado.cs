using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public int IdTipoRol { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Cuil { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public DateOnly FechaContratacion { get; set; }

    public int IdDepto { get; set; }

    public bool EstadoActivo { get; set; }

    public string Usuario { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string HashClave { get; set; } = null!;

    public virtual Departamento IdDeptoNavigation { get; set; } = null!;

    public virtual TipoRol IdTipoRolNavigation { get; set; } = null!;

    public virtual ICollection<Interaccione> Interacciones { get; set; } = new List<Interaccione>();

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();

    public virtual ICollection<Venta> VentumIdEmpleadoInstalaNavigations { get; set; } = new List<Venta>();

    public virtual ICollection<Venta> VentumIdEmpleadoRealizaNavigations { get; set; } = new List<Venta>();
}
