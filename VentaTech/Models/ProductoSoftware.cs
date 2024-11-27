using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class ProductoSoftware
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string NombreProducto { get; set; } = null!;

    public int IdEstado { get; set; }

    public bool EstadoActivo { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual Venta? Ventum { get; set; }
}
