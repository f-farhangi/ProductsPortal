using System;
using System.Threading.Tasks;

namespace SearchApi.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly SearchDbContext _searchDbContext;
        private readonly Lazy<ISearchDataRepository> _searchDataRepository;

        #endregion

        #region Properties

        public ISearchDataRepository SearchDataRepository => _searchDataRepository.Value;

        #endregion

        #region Constructor

        public UnitOfWork(SearchDbContext searchDbContext)
        {
            _searchDbContext = searchDbContext ?? throw new ArgumentNullException(nameof(searchDbContext));
            _searchDataRepository = new Lazy<ISearchDataRepository>(() => new SearchDataRepository(_searchDbContext));
        }

        #endregion

        #region Methods

        public void Commit()
        {
            _searchDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _searchDbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _searchDbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _searchDbContext.DisposeAsync();
        }

        #endregion
    }
}
