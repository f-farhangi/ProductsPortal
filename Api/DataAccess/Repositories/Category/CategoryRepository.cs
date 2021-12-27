using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        #region Constructor

        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
