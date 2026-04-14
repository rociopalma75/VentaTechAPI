using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_HISTORIAL")]
public class Historial
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("ACCION"), MaxLength(200), Required]
    public string Accion { get; set; } = null!;
    
    [Column("FECHA_HORA"), Required]
    public DateTime FechaHora { get; set; }
}
