using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_TIPOS_ROL")]
public class TipoRol
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("DESCRIPCION"), MaxLength(100), Required]
    public string Descripcion { get; set; } = null!;

    [Column("NOMBRE_ROL"), MaxLength(50), Required]
    public string NombreRol { get; set; } = null!;
}
