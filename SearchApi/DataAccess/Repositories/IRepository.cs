using SearchApi.Entities;
using System.Threading.Tasks;

namespace SearchApi.DataAccess
{
    public interface IRepository<T> where T : class, IEntity
    {
        #region Methods

        Task Insert(T entity);

        #endregion
    }
}
