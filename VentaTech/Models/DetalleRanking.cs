using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class DetalleRanking
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Calificacion { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
