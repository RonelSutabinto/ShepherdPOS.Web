
//=====================================================================================================================================================
//This part of code was using the auto mapper llibrary. create a mapper class for mapping entity models to view model classes.=========================
//The entity models should be used to generate this class.=============================================================================================
//=Try this link for more detailshttps://steemit.com/utopian-io/@yissakhar/using-automapper-profiles-to-perform-mapping-between-different-objects======
//=====================================================================================================================================================

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
          
            CreateMap<Product, SelectProductView>();

            CreateMap<Product, UpdateProductDto>().ReverseMap();

            CreateMap<AppendStockDto, Stock>();

            CreateMap<SaleProduct, SaleDetailSelectProductView>();

            CreateMap<PosCartTransaction, SaleDetailTransactionViewModel>();

            CreateMap<ProductCategory, UpdateProductCategoryDto>().ReverseMap();

            CreateMap<Product, SelectedItemValueDto>().ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.ProductName)).ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));
        }
    }
}

