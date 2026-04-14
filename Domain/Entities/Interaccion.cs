using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_INTERACCIONES")]
public class Interaccion
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ID_CLIENTE"), Required]
    public int IdCliente { get; set; }

    [Column("ID_EMPLEADO"), Required]
    public int IdEmpleado { get; set; }

    [Column("ID_TIPO_INTERACCION"), Required]
    public int IdTipoInteraccion { get; set; }

    [Column("MOTIVO"), MaxLength(200), Required]
    public string Motivo { get; set; } = null!;

    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }
    
    [Column("FECHA_HORA"), Required]
    public DateTime FechaHora { get; set; }

    [ForeignKey("IdCliente")]
    public virtual Cliente Cliente { get; set; } = null!;

    [ForeignKey("IdEmpleado")]
    public virtual Empleado Empleado { get; set; } = null!;

    [ForeignKey("IdTipoInteraccion")]
    public virtual TipoInteraccion TipoInteraccion { get; set; } = null!;
}
