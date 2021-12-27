using Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        #region Fields

        private readonly DbContext _dbContext;

        #endregion

        #region Constructor

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion

        #region Methods

        public async Task Add(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await Get(id);

            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
            }
        }

        public async Task<TEntity> Get(int id)
        {
            return await _dbContext.Set<TEntity>().SingleAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public void Update(TEntity entity)
        {
             _dbContext.Set<TEntity>().Update(entity);
        }

        #endregion
    }
}
