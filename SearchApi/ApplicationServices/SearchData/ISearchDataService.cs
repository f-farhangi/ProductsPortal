using SearchApi.Entities;
using System.Threading.Tasks;

namespace SearchApi.ApplicationServices
{
    public interface ISearchDataService
    {
        #region Methods

        Task InsertData(SearchData data);

        #endregion
    }
}
