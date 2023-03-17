
//=====================================================================================================================================================
//This part of code was using the auto mapper llibrary. create a mapper class for mapping entity models to view model classes.=========================
//The entity models should be used to generate this class.=============================================================================================
//=Try this link for more detailshttps://steemit.com/utopian-io/@yissakhar/using-automapper-profiles-to-perform-mapping-between-different-objects======
//try this link for mapper distation settingshttps://docs.automapper.org/en/stable/Custom-value-resolvers.html=========================================
//=====================================================================================================================================================

using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.ViewModels;
using ShepherdPOS.Models.DataTObject;
using Microsoft.AspNetCore.Routing.Constraints;

using AutoMapper;
using Duende.IdentityServer.Models;

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

            CreateMap<Product, SelectedItemValueDto>().ForMember(Destination => Destination.Text, opt => opt.MapFrom(source => source.ProductName)).ForMember(v => v.Value, opt => opt.MapFrom(source => source.Id));

            CreateMap<ProductCategory, ProductGroupView>();
            CreateMap<ProductCategory, SelectedItemValueDto>().ForMember(Destination => Destination.Text, opt => opt.MapFrom(source => source.CategoryName)).ForMember(v => v.Value, opt => opt.MapFrom(source => source.Id));
        }
    }
}

