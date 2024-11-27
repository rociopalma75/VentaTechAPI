namespace VentaTechAPI.Repositories.Contracts
{
    public interface ICrudRepository<TEntity> : IViewRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
