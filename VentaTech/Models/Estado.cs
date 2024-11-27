using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string NombreEstado { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ProductoSoftware> ProductoSoftwares { get; set; } = new List<ProductoSoftware>();
}
