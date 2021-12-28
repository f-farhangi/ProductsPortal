using System;
using System.Threading.Tasks;

namespace Api.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly AppDbContext _dbContext;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IProductDetailRepository> _productDetailRepository;
        private readonly Lazy<IProductPriceRepository> _productPriceRepository;

        #endregion

        #region Property

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public IProductDetailRepository ProductDetailRepository => _productDetailRepository.Value;
        public IProductPriceRepository ProductPriceRepository => _productPriceRepository.Value;

        #endregion

        #region Constructor

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_dbContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_dbContext));
            _productDetailRepository = new Lazy<IProductDetailRepository>(() => new ProductDetailRepository(_dbContext));
            _productPriceRepository = new Lazy<IProductPriceRepository>(() => new ProductPriceRepository(_dbContext));
        }

        #endregion

        #region Methods

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }

        #endregion
    }
}
