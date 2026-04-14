using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_TIPOS_INTERACCION")]
public class TipoInteraccion
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("DESCRIPCION"), MaxLength(100), Required]
    public string Descripcion { get; set; } = null!;
}
