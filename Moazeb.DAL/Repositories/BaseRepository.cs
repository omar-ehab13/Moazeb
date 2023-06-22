using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moazeb.DAL.DataContext;
using Moazeb.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        #region Private Properties
        protected readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> dbSet;
        #endregion

        #region Constructor
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            this.dbSet = context.Set<TEntity>();
        }
        #endregion


        #region Methods For Create
        public async Task<bool> CreateAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);

            return true;
        }

        public async Task<bool> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await dbSet.AddRangeAsync(entities);

            return true;
        }
        #endregion

        #region Update and Delete
        public async Task<bool> UpdateAsync(TEntity oldEntity, TEntity newEntity)
        {
            _context.Entry(oldEntity).CurrentValues.SetValues(newEntity);

            return true;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            var entry = _context.Entry(entity);

            if (entry.State == EntityState.Modified)
            {
                // get primary keys values for the entity
                var keyProperties = _context.Model.FindEntityType(typeof(TEntity))!.FindPrimaryKey()!.Properties;
                var keyPropertiesValues = keyProperties.Select(p => p.GetGetter().GetClrValue(entity))
                                                        .ToArray();

                // search for existing entity
                var existingEntity = await _context.Set<TEntity>().FindAsync(keyPropertiesValues);

                // if the entity with primary keys is exist change properties values
                if (existingEntity != null)
                {
                    var existingEntry = _context.Entry(existingEntity);
                    existingEntry.CurrentValues.SetValues(entity);
                }
                // if the entity with primary keys is not exist attach new entity with new values
                else
                {
                    _context.Attach(entity);
                    entry.State = EntityState.Modified;
                }

                return true;
            }

            return false;
        }

        public async Task<bool> RemoveAsync(TEntity entity)
        {
            dbSet.Remove(entity);

            return true;
        }


        public async Task<bool> RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);

            await _context.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Direct Data
        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var query = await Task.FromResult(dbSet);

            return query;
        }

        public async Task<TEntity?> GetByIdAsync(string id)
        {
            var entity = await dbSet.FindAsync(id);

            return entity;
        }
        #endregion

        #region Find with Filter
        public async Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, string[]? includes = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return await query.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IQueryable<TEntity>> FindAllWithIncludes(string[]? includes)
        {
            IQueryable<TEntity> query = dbSet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query;
        }

        public async Task<IQueryable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate, string[]? includes = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query.Where(predicate);
        }

        #endregion

        #region Statistics and Aggregate
        public async Task<int> CountAsync()
        {
            return await dbSet.CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await dbSet.CountAsync(expression);
        }

        public async Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> expression)
        {
            return await dbSet.SumAsync(expression);
        }

        public async Task<decimal> AverageAsync(Expression<Func<TEntity, decimal>> expression)
        {
            return await dbSet.AverageAsync(expression);
        }

        public async Task<decimal> MinAsync(Expression<Func<TEntity, decimal>> expression)
        {
            return await dbSet.MinAsync(expression);
        }

        public async Task<decimal> MaxAsync(Expression<Func<TEntity, decimal>> expression)
        {
            return await dbSet.MaxAsync(expression);
        }
        #endregion
    }
}
