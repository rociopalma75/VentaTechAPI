using System;
using System.Collections.Generic;

namespace VentaTechAPI.Models;

public partial class Historial
{
    public int Id { get; set; }

    public string Accion { get; set; } = null!;

    public DateTime FechaHora { get; set; }
}
