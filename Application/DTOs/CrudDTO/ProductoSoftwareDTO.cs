using System.Text.Json.Serialization;
using Application.DTOs.ViewsDTO;

namespace Application.DTOs.CrudDTO
{
    public record ProductoSoftwareRequestDTO
    {
        public int IdCliente { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public string NombreProducto { get; set; } = null!;
        public int IdEstado { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record ProductoSoftwareResponseDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public string NombreProducto { get; set; } = null!;
        public bool EstadoActivo { get; set; }
        [JsonPropertyName("cliente")]
        public virtual ClienteViewDTO Cliente { get; set; } = null!;
        [JsonPropertyName("estado")]
        public virtual EstadoDTO Estado { get; set; } = null!;
    }

    public record ProductoSoftwareViewDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NombreProducto { get; set; } = null!;
    }
}
