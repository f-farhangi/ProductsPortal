using Api.Entities;
using Api.Models;
using AutoMapper;
using System.Linq;

namespace Api.Map
{
    public class ProductProfile : Profile
    {
        #region Constructor

        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.CategoryTitle, opt => opt.MapFrom(src => src.Category.Title))
                .ForMember(x => x.Amount, opt => opt.MapFrom(src => src.ProductPrices.FirstOrDefault(a => !a.EndDate.HasValue).Amount))
                .ForMember(x => x.StartDate, opt => opt.MapFrom(src => src.ProductPrices.FirstOrDefault(a => !a.EndDate.HasValue).StartDate))
                .ReverseMap();

            CreateMap<Product, ProductForInsertDto>().ReverseMap();
            CreateMap<Product, ProductForUpdateDto>().ReverseMap();
        }

        #endregion
    }
}
