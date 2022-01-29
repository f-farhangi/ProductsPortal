using AutoMapper;
using SearchApi.Entities;
using SearchApi.Models;

namespace SearchApi.Map
{
    public class SearchDataProfile : Profile
    {
        #region Constructor

        public SearchDataProfile()
        {
            CreateMap<SearchData, SearchDataForInsertDto>().ReverseMap();
        }

        #endregion
    }
}
