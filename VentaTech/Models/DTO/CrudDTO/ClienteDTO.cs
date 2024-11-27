using System.Text.Json.Serialization;

namespace VentaTechAPI.Models.DTO.CrudDTO
{
    public record ClienteRequestDTO
    {
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string CuilCuit { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        [JsonIgnore]
        public bool EstadoActivo { get; set; } = true;
    }

    public record ClienteResponseDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string CuilCuit { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public bool EstadoActivo { get; set; }
    }

    public record ClienteViewDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string CuilCuit { get; set; } = null!;


    }
}
