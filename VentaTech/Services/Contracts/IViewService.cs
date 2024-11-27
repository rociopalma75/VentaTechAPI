namespace VentaTechAPI.Services.Contracts
{
    public interface IViewService<TResponseDTO> where TResponseDTO : class
    {
        Task<List<TResponseDTO>> GetAllAsync();
        Task<TResponseDTO?> GetByIdAsync(int id);    
    }
}
