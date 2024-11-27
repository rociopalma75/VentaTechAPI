using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Repositories.Contracts;
using VentaTechAPI.Context;
using System.Linq.Expressions;
using NuGet.Versioning;

namespace VentaTechAPI.Repositories
{
    public abstract class ViewRepository<TEntity> : IViewRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _context;

        public ViewRepository(AppDbContext context) 
        {
            _context = context;
        }
        protected virtual Expression<Func<TEntity, object>>[] PropertiesNavigations => [];

        public abstract Task<bool> ExistsAsync(int id);

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query =  _context.Set<TEntity>().AsQueryable();

            if (PropertiesNavigations.Any())
            {
                foreach (var property in PropertiesNavigations)
                {
                    query = query.Include(property);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            //var entity = await _context.Set<TEntity>().FindAsync(id);
            //return entity;
            IQueryable<TEntity> query = _context.Set<TEntity>();

            foreach (var include in PropertiesNavigations)
            {
                query = query.Include(include);
            }
            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e,"Id") == id);
        }
    }
}
