using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_PRODUCTOS_SOFTWARE")]
public class ProductoSoftware
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ID_CLIENTE"), Required]
    public int IdCliente { get; set; }
    
    [Column("DESCRIPCION"), MaxLength(255), Required]
    public string Descripcion { get; set; } = null!;

    [Column("PRECIO"), Required]
    public decimal Precio { get; set; }

    [Column("NOMBRE_PRODUCTO"), MaxLength(100), Required]
    public string NombreProducto { get; set; } = null!;

    [Column("ID_ESTADO"), Required]
    public int IdEstado { get; set; }

    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }

    [ForeignKey("IdCliente")]
    public virtual Cliente Cliente { get; set; } = null!;
    
    [ForeignKey("IdEstado")]
    public virtual Estado Estado { get; set; } = null!;
}
