using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess
{
    public class ProductPriceRepository : Repository<ProductPrice>, IProductPriceRepository
    {
        #region Constructor

        public ProductPriceRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
