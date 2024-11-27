using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Registro
{
    public int Id { get; set; }

    public int IdEmpleado { get; set; }

    public int IdProductoServicio { get; set; }

    public bool EstadoActivo { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual ProductoServicio IdProductoServicioNavigation { get; set; } = null!;
}
