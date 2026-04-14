using System.Text.Json.Serialization;

namespace Application.DTOs.CrudDTO
{
    public record VentaRequestDTO
    {
        public int IdProductoSoftware { get; set; }
        public int IdEmpleadoRealiza { get; set; }
        public int? IdEmpleadoInstala { get; set; } = null;
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraEntrega { get; set; } = null;
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record VentaResponseDTO
    {
        public int Id { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraEntrega { get; set; }
        public bool EstadoActivo { get; set; }
        public decimal? Total { get; set; }

        [JsonPropertyName("empleadoInstala")]
        public virtual EmpleadoViewDTO EmpleadoInstala { get; set; } = null!;
        [JsonPropertyName("empleadoRealizaVenta")]
        public virtual EmpleadoViewDTO EmpleadoRealizaVenta { get; set; } = null!;
        [JsonPropertyName("productoSoftware")]
        public virtual ProductoSoftwareViewDTO ProductoSoftware { get; set; } = null!;
    }
}
