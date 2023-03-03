using AutoMapper;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Data.SqlClient;
using ShepherdPOS.Api.Entities;
//using ShepherdPOS.Api;
using ShepherdPOS.Models.DataTO;
using ShepherdPOS.Models.ViewModel;

namespace ShepherdPOS.Api.Data
{
    public class ShepherdPOSMapperProfile : Profile
    {
        public ShepherdPOSMapperProfile()
        {
            CreateMap<ProductCategory, ProductGroupView>();
            CreateMap<ProductCategory, ExecuteUpdateCategoryDto>().ReverseMap();
            CreateMap<ProductCategory, ItemsDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<Product, ProductView>();
            CreateMap<Product, ExecuteUpdateProductDto>().ReverseMap();
            CreateMap<Product, ItemsDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<StockDTO, Stock>();

            CreateMap<SaleProduct, SaleDetailProductViewModel>();
            CreateMap<Transaction, SaleDetailTransactionViewModel>();
        }
    }
}
