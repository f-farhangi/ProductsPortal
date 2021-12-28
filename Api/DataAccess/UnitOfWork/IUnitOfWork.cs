using System.Threading.Tasks;

namespace Api.DataAccess
{
    public interface IUnitOfWork
    {
        #region Property

        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductDetailRepository ProductDetailRepository { get; }
        IProductPriceRepository ProductPriceRepository { get; }

        #endregion

        #region Methods

        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();

        #endregion
    }
}
