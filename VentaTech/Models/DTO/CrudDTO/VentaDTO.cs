using System.Text.Json.Serialization;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record VentaRequestDTO
    {
        public int IdProductoSoftware { get; set; }

        public int IdEmpleadoRealiza { get; set; }

        public int? IdEmpleadoInstala { get; set; } = null;

        public DateOnly FechaInicio { get; set; }

        public DateOnly? FechaEntrega { get; set; } = null;
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record VentaResponseDTO
    {
        public int Id { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly? FechaEntrega { get; set; }
        public bool EstadoActivo { get; set; }
        [JsonPropertyName("empleadoInstala")]
        public virtual EmpleadoViewDTO IdEmpleadoInstalaNavigation { get; set; } = null!;
        [JsonPropertyName("empleadoRealizaVenta")]
        public virtual EmpleadoViewDTO IdEmpleadoRealizaNavigation { get; set; } = null!;
        [JsonPropertyName("productoSoftware")]
        public virtual ProductoSoftwareViewDTO IdProductoSoftwareNavigation { get; set; } = null!;
    }
}
