using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Cuit { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int IdRanking { get; set; }

    public bool EstadoActivo { get; set; }

    public virtual DetalleRanking IdRankingNavigation { get; set; } = null!;

    public virtual ICollection<ProductoServicio> ProductoServicios { get; set; } = new List<ProductoServicio>();
}
