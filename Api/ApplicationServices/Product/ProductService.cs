using Api.DataAccess;
using Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.ApplicationServices
{
    public class ProductService : IProductService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        #endregion

        #region Methods

        public async Task DeleteProduct(long id)
        {
            await _unitOfWork.ProductRepository.Delete(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Product> GetProduct(long id)
        {
            return await _unitOfWork.ProductRepository.GetAsync(p => p.Id == id, new List<string>() { nameof(Product.Category), nameof(Product.ProductPrices) });
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _unitOfWork.ProductRepository.GetAllAsync(null, new List<string>() { nameof(Product.Category), nameof(Product.ProductPrices) });
        }

        public async Task InsertProduct(Product product)
        {
            await _unitOfWork.ProductRepository.Insert(product);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.CommitAsync();
        }

        #endregion
    }
}
