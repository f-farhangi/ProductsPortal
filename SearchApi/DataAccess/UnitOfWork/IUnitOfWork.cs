using System.Threading.Tasks;

namespace SearchApi.DataAccess
{
    public interface IUnitOfWork
    {
        #region Properties

        public ISearchDataRepository SearchDataRepository { get; }

        #endregion

        #region Methods

        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();

        #endregion
    }
}
