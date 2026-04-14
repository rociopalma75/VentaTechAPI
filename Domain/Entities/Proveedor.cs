using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_PROVEEDORES")]
public class Proveedor
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("RAZON_SOCIAL"), MaxLength(100), Required]
    public string RazonSocial { get; set; } = null!;

    [Column("CUIT"), MaxLength(20), Required]
    public string Cuit { get; set; } = null!;

    [Column("EMAIL"), MaxLength(100), Required]
    public string Email { get; set; } = null!;

    [Column("TELEFONO"), MaxLength(20), Required]
    public string Telefono { get; set; } = null!;

    [Column("DIRECCION"), MaxLength(200), Required]
    public string Direccion { get; set; } = null!;

    [Column("ID_RANKING"), Required]
    public int IdRanking { get; set; }

    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }

    [ForeignKey("IdRanking")]
    public virtual DetalleRanking DetalleRanking { get; set; } = null!;
}

