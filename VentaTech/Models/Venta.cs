using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Venta
{
    public int Id { get; set; }

    public int IdProductoSoftware { get; set; }

    public int IdEmpleadoRealiza { get; set; }

    public int? IdEmpleadoInstala { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public bool EstadoActivo { get; set; }

    public decimal? Total { get; set; }

    public virtual Empleado? IdEmpleadoInstalaNavigation { get; set; }

    public virtual Empleado IdEmpleadoRealizaNavigation { get; set; } = null!;

    public virtual ProductoSoftware IdProductoSoftwareNavigation { get; set; } = null!;
}
