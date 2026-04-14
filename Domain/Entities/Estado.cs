using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_ESTADOS")]
public class Estado
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("NOMBRE_ESTADO"), MaxLength(50), Required]
    public string NombreEstado { get; set; } = null!;

    [Column("DESCRIPCION"), MaxLength(200), Required]
    public string Descripcion { get; set; } = null!;
}
