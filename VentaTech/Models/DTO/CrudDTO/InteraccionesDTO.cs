using System.Text.Json.Serialization;
using VentaTechAPI.Models.DTO.ViewsDTO;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record InteraccionesRequestDTO
    {
        public int IdCliente { get; set; }

        public int IdEmpleado { get; set; }

        public int IdTipoInteraccion { get; set; }

        public string Motivo { get; set; } = null!;

        public DateOnly Fecha { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }


    public record InteraccionesResponseDTO
    {
        public int Id { get; set; }
        public string Motivo { get; set; } = null!;
        public DateOnly Fecha { get; set; }

        public bool EstadoActivo { get; set; }
        [JsonPropertyName("cliente")]
        public virtual ClienteViewDTO IdClienteNavigation { get; set; } = null!;
        [JsonPropertyName("empleado")]
        public virtual EmpleadoViewDTO IdEmpleadoNavigation { get; set; } = null!;
        [JsonPropertyName("tipoInteraccion")]
        public virtual TipoInteraccionDTO IdTipoInteraccionNavigation { get; set; } = null!;

    }
}
