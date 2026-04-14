using System.Text.Json.Serialization;

namespace Application.DTOs.CrudDTO
{
    public record RegistroRequestDTO
    {
        public int IdEmpleado { get; set; }
        public int IdProductoServicio { get; set; }
        public DateTime FechaHora { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record RegistroResponseDTO
    {
        public int Id { get; set; }
        public bool EstadoActivo { get; set; }
        public DateTime FechaHora { get; set; }
        [JsonPropertyName("empleado")]
        public virtual EmpleadoViewDTO Empleado { get; set; } = null!;
        [JsonPropertyName("productoServicio")]
        public virtual ProductoServicioViewDTO ProductoServicio { get; set; } = null!;
    }
}
