using Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.DataAccess
{
    public interface IRepository<T> where T : class, IEntity
    {
        #region Methods

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T entity);
        void Update(T entity);
        Task Delete(int id);

        #endregion
    }
}
