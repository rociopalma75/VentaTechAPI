namespace VentaTechAPI.Services.Contracts
{
    public interface ICrudService<TRequestDTO, TResponseDTO> : IViewService<TResponseDTO> 
        where TRequestDTO : class 
        where TResponseDTO : class
    {
        Task<TResponseDTO> CreateAsync(TRequestDTO requestDTO);
        Task<bool> DeleteAsync(int id);
        Task<TResponseDTO?> UpdateAsync(int id, TRequestDTO requestDTO);
    }
}
