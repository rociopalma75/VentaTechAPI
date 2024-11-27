namespace VentaTechAPI.Repositories.Contracts
{
    public interface IViewRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id); 

        Task<bool> ExistsAsync(int id);
    }
}
