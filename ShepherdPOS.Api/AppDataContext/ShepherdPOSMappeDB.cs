
//===================================================================================================
//This part of code is used auto mapper llibrary. It will transform one object type into another
//It's a straightforward object-to-object mapper that uses conventions to minimize setup time.
//===========Try this link for more detailshttps://digitaldrummerj.me/aspnet-core-automapper/=========
//=====================================================================================================

using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.ViewModels;
using ShepherdPOS.Models.DataTObject;
using Microsoft.AspNetCore.Routing.Constraints;

using AutoMapper;

namespace ShepherdPOS.Api.Classes
{
    public class ShepherdPOSMappeDB : Profile
    {
        public ShepherdPOSMappeDB()
        {
            CreateMap<ProductCategory, ProductGroupView>();

            CreateMap<ProductCategory, UpdateProductCategoryDto>().ReverseMap();

            CreateMap<ProductCategory, SelectedItemValueDto>().ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.CategoryName)).ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<Product, SelectProductView>();

            CreateMap<Product, UpdateProductDto>().ReverseMap();

            CreateMap<AppendStockDto, Stock>();

            CreateMap<SaleProduct, SaleDetailSelectProductView>();

            CreateMap<PosCartTransaction, SaleDetailTransactionViewModel>();
            CreateMap<Product, SelectedItemValueDto>().ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.ProductName)).ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));
        }
    }
}

