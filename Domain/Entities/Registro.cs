using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_REGISTROS")]
public class Registro
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ID_EMPLEADO"),Required]
    public int IdEmpleado { get; set; }

    [Column("ID_PRODUCTO_SERVICIO"), Required]
    public int IdProductoServicio { get; set; }

    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }

    [Column("FECHA_HORA"), Required]
    public DateTime FechaHora { get; set; }

    [ForeignKey("IdEmpleado")]
    public virtual Empleado Empleado { get; set; } = null!;

    [ForeignKey("IdProductoServicio")]
    public virtual ProductoServicio ProductoServicio { get; set; } = null!;
}
