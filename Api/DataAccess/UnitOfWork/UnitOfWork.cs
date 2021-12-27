using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly AppDbContext _dbContext;
        private readonly Lazy<ICategoryRepository> _CategoryRepository;
        private readonly Lazy<IProductRepository> _ProductRepository;
        private readonly Lazy<IProductDetailRepository> _ProductDetailRepository;

        #endregion

        #region Property

        public ICategoryRepository CategoryRepository => _CategoryRepository.Value;

        public IProductRepository ProductRepository => _ProductRepository.Value;

        public IProductDetailRepository ProductDetailRepository => _ProductDetailRepository.Value;

        #endregion

        #region Constructor

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _CategoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_dbContext));
            _ProductRepository = new Lazy<IProductRepository>(() => new ProductRepository(_dbContext));
            _ProductDetailRepository = new Lazy<IProductDetailRepository>(() => new ProductDetailRepository(_dbContext));
        }

        #endregion

        #region Methods

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
