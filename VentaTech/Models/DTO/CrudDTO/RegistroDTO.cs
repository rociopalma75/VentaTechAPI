using System.Text.Json.Serialization;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record RegistroRequestDTO
    {
        public int IdEmpleado { get; set; }

        public int IdProductoServicio { get; set; }

        public DateOnly Fecha { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record RegistroResponseDTO
    {
        public int Id { get; set; }
        public bool EstadoActivo { get; set; }

        public DateOnly Fecha { get; set; }
        [JsonPropertyName("empleado")]
        public virtual EmpleadoViewDTO IdEmpleadoNavigation { get; set; } = null!;
        [JsonPropertyName("productoServicio")]
        public virtual ProductoServicioViewDTO IdProductoServicioNavigation { get; set; } = null!;
    }
}
