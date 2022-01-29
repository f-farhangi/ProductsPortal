using SearchApi.DataAccess;
using SearchApi.Entities;
using System;
using System.Threading.Tasks;

namespace SearchApi.ApplicationServices
{
    public class SearchDataService : ISearchDataService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        public SearchDataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        #endregion

        #region Methods

        public async Task InsertData(SearchData data)
        {
            await _unitOfWork.SearchDataRepository.Insert(data);
            await _unitOfWork.CommitAsync();
        }

        #endregion
    }
}
