using Microsoft.EntityFrameworkCore;
using SearchApi.Entities;
using System;
using System.Threading.Tasks;

namespace SearchApi.DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
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

        public async Task Insert(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        #endregion
    }
}
