using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class TipoInteraccion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Interaccione> Interacciones { get; set; } = new List<Interaccione>();
}
