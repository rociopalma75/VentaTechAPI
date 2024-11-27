using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string NombreDepto { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
