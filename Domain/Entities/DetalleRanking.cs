using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_DETALLES_RANKINGS")]
public class DetalleRanking
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(name: "DESCRIPCION"), MaxLength(200), Required]
    public string Descripcion { get; set; } = null!;
    
    [Column(name: "CALIFICACION"), Required]
    public int Calificacion { get; set; }

}
