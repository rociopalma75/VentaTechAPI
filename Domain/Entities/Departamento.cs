using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_DEPARTAMENTOS")]
public class Departamento
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(name: "DESCRIPCION"), MaxLength(100), Required]
    public string Descripcion { get; set; } = null!;

    [Column(name: "NOMBRE_DEPTO"), MaxLength(50), Required]
    public string NombreDepto { get; set; } = null!;
}
