using System.Text.Json.Serialization;
using VentaTechAPI.Models.DTO.ViewsDTO;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record ProveedorRequestDTO
    {
        public string RazonSocial { get; set; } = null!;

        public string Cuit { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public int IdRanking { get; set; }

        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record ProveedorResponseDTO
    {
        public int Id { get; set; }

        public string RazonSocial { get; set; } = null!;

        public string Cuit { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public bool EstadoActivo { get; set; }
        [JsonPropertyName("ranking")]
        public virtual DetalleRankingDTO IdRankingNavigation { get; set; } = null!;
    }

    public record ProveedorViewDTO
    {
        public int Id { get; set; }

        public string RazonSocial { get; set; } = null!;

        public string Cuit { get; set; } = null!;
    }
}
