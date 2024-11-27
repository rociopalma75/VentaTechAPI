using System.Text.Json.Serialization;
using VentaTechAPI.Models.DTO.ViewsDTO;

namespace VentaTechAPI.Models.DTO.CrudDTO
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
        public virtual ClienteViewDTO IdClienteNavigation { get; set; } = null!;
        [JsonPropertyName("estado")]
        public virtual EstadoDTO IdEstadoNavigation { get; set; } = null!;
    }

    public record ProductoSoftwareViewDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NombreProducto { get; set; } = null!;
    }
}
