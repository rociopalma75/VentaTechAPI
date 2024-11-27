using System.Text.Json.Serialization;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record ProductoServicioRequestDTO
    {
        public string Descripcion { get; set; } = null!;

        public int IdProveedor { get; set; }

        public decimal Precio { get; set; }
        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record ProductoServicioResponseDTO
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public decimal Precio { get; set; }

        public bool EstadoActivo { get; set; }
        [JsonPropertyName("proveedor")]
        public virtual ProveedorViewDTO IdProveedorNavigation { get; set; } = null!;
    }

    public record ProductoServicioViewDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
