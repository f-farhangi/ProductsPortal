using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess
{
    public class ProductDetailRepository : Repository<ProductDetail>, IProductDetailRepository
    {
        #region Constructor

        public ProductDetailRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
