using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        #region Constructor

        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
