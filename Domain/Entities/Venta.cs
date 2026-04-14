using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_VENTAS")]
public class Venta
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ID_PRODUCTO_SOFTWARE"),Required]
    public int IdProductoSoftware { get; set; }

    [Column("ID_EMPLEADO_REALIZA"), Required]
    public int IdEmpleadoRealiza { get; set; }

    [Column("ID_EMPLEADO_INSTALA")]
    public int? IdEmpleadoInstala { get; set; }

    [Column("FECHA_HORA_INICIO"), Required]
    public DateTime FechaHoraInicio { get; set; }

    [Column("FECHA_HORA_ENTREGA")]
    public DateTime? FechaHoraEntrega { get; set; }

    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }

    [Column("TOTAL")]
    public decimal? Total { get; set; }
    
    [ForeignKey("IdEmpleadoInstala")]
    public virtual Empleado? EmpleadoInstala { get; set; }

    [ForeignKey("IdEmpleadoRealiza")]
    public virtual Empleado EmpleadoRealizaVenta { get; set; } = null!;

    [ForeignKey("IdProductoSoftware")]
    public virtual ProductoSoftware ProductoSoftware { get; set; } = null!;
}
