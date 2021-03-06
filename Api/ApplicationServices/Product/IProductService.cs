using Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.ApplicationServices
{
    public interface IProductService
    {
        #region Methods

        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(long id);
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(long id);

        #endregion
    }
}
