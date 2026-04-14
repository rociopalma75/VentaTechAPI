using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("TBL_EMPLEADOS")]
public class Empleado
{
    [Column("ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("ID_TIPO_ROL"), Required]
    public int IdTipoRol { get; set; }
    
    [Column("NOMBRE"), MaxLength(50), Required]
    public string Nombre { get; set; } = null!;
    
    [Column("APELLIDO"), MaxLength(50), Required]
    public string Apellido { get; set; } = null!;
    
    [Column("FECHA_NACIMIENTO"), Required]
    public DateOnly FechaNacimiento { get; set; }
    
    [Column("CUIL"), MaxLength(20), Required]
    public string Cuil { get; set; } = null!;
    
    [Column("DNI"), MaxLength(20), Required]
    public string Dni { get; set; } = null!;
    
    [Column("DIRECCION"), MaxLength(100), Required]
    public string Direccion { get; set; } = null!;
    
    [Column("FECHA_CONTRATACION"), Required]
    public DateOnly FechaContratacion { get; set; }
    
    [Column("ID_DEPTO"), Required]
    public int IdDepto { get; set; }
    
    [Column("ESTADO_ACTIVO"), Required]
    public bool EstadoActivo { get; set; }
    
    [Column("USUARIO"), MaxLength(50), Required]
    public string Usuario { get; set; } = null!;
    
    [Column("CORREO"), MaxLength(100), Required]
    public string Correo { get; set; } = null!;
    
    [Column("HASH_CLAVE"), MaxLength(256), Required]
    public string HashClave { get; set; } = null!;
    
    [ForeignKey("IdDepto")]
    public virtual Departamento Departamento { get; set; } = null!;
    
    [ForeignKey("IdTipoRol")]
    public virtual TipoRol TipoRol { get; set; } = null!;

}
