using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_PRODUCTOS_SERVICIOS")]
public class ProductoServicio
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("DESCRIPCION"), MaxLength(200), Required]
    public string Descripcion { get; set; } = null!;
    
    [Column("ID_PROVEEDOR"), Required]
    public int IdProveedor { get; set; }
    
    [Column("PRECIO"), Required]
    public decimal Precio { get; set; }
    
    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }

    [ForeignKey("IdProveedor")]
    public virtual Proveedor Proveedor { get; set; } = null!;

}
