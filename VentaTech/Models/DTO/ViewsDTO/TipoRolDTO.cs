namespace VentaTechAPI.Models.DTO.ViewsDTO
{
    public record TipoRolDTO
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string NombreRol { get; set; } = null!;
    }

    public record TipoRolViewDTO
    {
        public int Id { get; set; }
        public string NombreRol { get; set; } = null!;
    }
}
