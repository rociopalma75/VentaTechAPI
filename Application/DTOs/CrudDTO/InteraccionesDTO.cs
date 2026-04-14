using System.Text.Json.Serialization;
using Application.DTOs.ViewsDTO;

namespace Application.DTOs.CrudDTO
{
    public record InteraccionesRequestDTO
    {
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTipoInteraccion { get; set; }
        public string Motivo { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }


    public record InteraccionesResponseDTO
    {
        public int Id { get; set; }
        public string Motivo { get; set; } = null!;
        public DateTime FechaHora { get; set; }

        public bool EstadoActivo { get; set; }
        [JsonPropertyName("cliente")]
        public virtual ClienteViewDTO Cliente { get; set; } = null!;
        [JsonPropertyName("empleado")]
        public virtual EmpleadoViewDTO Empleado { get; set; } = null!;
        [JsonPropertyName("tipoInteraccion")]
        public virtual TipoInteraccionDTO TipoInteraccion { get; set; } = null!;
    }
}
