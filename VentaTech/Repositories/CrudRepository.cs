using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using VentaTechAPI.Context;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Repositories
{
    public abstract class CrudRepository<TEntity> : ViewRepository<TEntity>, ICrudRepository<TEntity> where TEntity : class
    {
        public CrudRepository(AppDbContext context) : base(context)
        {
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {

            EntityEntry<TEntity> entityInserted = await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            //return entityInserted.Entity;
            IQueryable<TEntity> query = _context.Set<TEntity>();

            foreach(var property in PropertiesNavigations)
            {
                query = query.Include(property);
            }

            int primaryKeyValue = (int)entityInserted.Property("Id").CurrentValue;

            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == primaryKeyValue) ?? throw new InvalidOperationException("La entidad no pudo ser recuperada con las propiedades de navegación.");
        }
    

        public abstract Task DeleteAsync(TEntity entity);

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
