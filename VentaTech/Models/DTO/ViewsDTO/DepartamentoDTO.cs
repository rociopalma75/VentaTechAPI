namespace VentaTechAPI.Models.DTO.ViewsDTO
{
    public record DepartamentoDTO
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public string NombreDepto { get; set; } = null!;
    }

    public record DepartamentoViewDTO
    {
        public int Id { get; set; }
        public string NombreDepto { get; set; } = null!;
    }
}
