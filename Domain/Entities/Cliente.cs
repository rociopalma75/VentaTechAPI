using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_CLIENTES")]
public class Cliente
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(name: "NOMBRE"), MaxLength(50), Required]
    public string Nombre { get; set; } = null!;

    [Column(name: "APELLIDO"), MaxLength(50), Required]
    public string Apellido { get; set; } = null!;

    [Column(name: "DIRECCION"), MaxLength(100), Required]
    public string Direccion { get; set; } = null!;
    
    [Column(name: "EMAIL"), MaxLength(150), Required] 
    public string Email { get; set; } = null!;
    
    [Column(name: "CUIL_CUIT"), MaxLength(50), Required] 
    public string CuilCuit { get; set; } = null!;
    
    [Column(name: "TELEFONO"), MaxLength(50), Required] 
    public string Telefono { get; set; } = null!;

    [Column(name: "ESTADO_ACTIVO")]
    public bool EstadoActivo { get; set; }
}
