using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class ProductoServicio
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdProveedor { get; set; }

    public decimal Precio { get; set; }

    public bool EstadoActivo { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
