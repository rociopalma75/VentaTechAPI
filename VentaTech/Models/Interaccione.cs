using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Interaccione
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public int IdTipoInteraccion { get; set; }

    public string Motivo { get; set; } = null!;

    public bool EstadoActivo { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual TipoInteraccion IdTipoInteraccionNavigation { get; set; } = null!;
}
