using System.Text.Json.Serialization;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record EmpleadoRequestDTO
    {
        [JsonIgnore]
        public int IdTipoRol { get; set; } = 2;

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public DateOnly FechaNacimiento { get; set; }

        public string Cuil { get; set; } = null!;

        public string Dni { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public DateOnly FechaContratacion { get; set; }
        
        public int IdDepto { get; set; } 

        public string Usuario { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string HashClave { get; set; } = null!;

        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;

    }

    public record EmpleadoEditRequestDTO
    {
        public int IdTipoRol { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public DateOnly FechaNacimiento { get; set; }

        public string Cuil { get; set; } = null!;

        public string Dni { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public DateOnly FechaContratacion { get; set; }

        public int IdDepto { get; set; }

        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;

    }


    public record EmpleadoResponseDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public DateOnly FechaNacimiento { get; set; }

        public string Cuil { get; set; } = null!;

        public string Dni { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public DateOnly FechaContratacion { get; set; }
        public string Usuario { get; set; } = null!;

        public string Correo { get; set; } = null!;

        [JsonPropertyName("rol")]
        public virtual TipoRolViewDTO IdTipoRolNavigation { get; set; } = null!;
       
        [JsonPropertyName("departamento")]
        public virtual DepartamentoViewDTO IdDeptoNavigation { get; set; } = null!;

        public bool EstadoActivo { get; set; }
    }

    public record EmpleadoViewDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public string Usuario { get; set; } = null!;
    }

    public record EmpleadoLoginDTO
    {
        public string Correo { get; set; } = null!;
        public string Clave { get; set; } = null!;
    }
}