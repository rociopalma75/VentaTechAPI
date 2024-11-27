using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CuilCuit { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public bool EstadoActivo { get; set; }

    public virtual ICollection<Interaccione> Interacciones { get; set; } = new List<Interaccione>();

    public virtual ICollection<ProductoSoftware> ProductoSoftwares { get; set; } = new List<ProductoSoftware>();
}
