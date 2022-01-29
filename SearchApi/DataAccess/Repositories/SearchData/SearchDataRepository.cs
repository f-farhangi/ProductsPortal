using Microsoft.EntityFrameworkCore;
using SearchApi.Entities;

namespace SearchApi.DataAccess
{
    public class SearchDataRepository : Repository<SearchData>, ISearchDataRepository
    {
        #region Constructor

        public SearchDataRepository(DbContext dbContext) : base(dbContext)
        {
        }

        #endregion

        #region Methods
        #endregion
    }
}
