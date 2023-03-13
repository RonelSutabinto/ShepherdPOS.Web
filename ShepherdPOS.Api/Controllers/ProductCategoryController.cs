//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//==============================================================================================================================

using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.DataTObject;
using ShepherdPOS.Models.ViewModels;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCategoryController : ControllerBase
    {
        readonly ApplicationDbContext DBContext;
        readonly IMapper DBmapper;
        readonly ILogger<ProductCategoryController> Applogger;

        public ProductCategoryController(ApplicationDbContext context,IMapper mapper,ILogger<ProductCategoryController> logger)
        {
            DBContext = context;
            DBmapper = mapper;
            Applogger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductGroupView>> GetAll()
        {
            try
            {
                var resutl = await DBContext.ProductCategories.ProjectTo<ProductGroupView>(DBmapper.ConfigurationProvider).OrderBy(pcategory => pcategory.CategoryName).ToArrayAsync();
                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpGet("getproductforupdate/{id:int}")]
        public async Task<UpdateProductCategoryDto> getproductforupdate(int id)
        {
            try
            {
                var resutl = await DBContext.ProductCategories.Where(pcategory => pcategory.Id == id).ProjectTo<UpdateProductCategoryDto>(DBmapper.ConfigurationProvider).FirstAsync();
                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("selecteditemlist")]
        public async Task<IEnumerable<SelectedItemValueDto>> selecteditemlist()
        {
            try
            {
                var resutl = await DBContext.ProductCategories.ProjectTo<SelectedItemValueDto>(DBmapper.ConfigurationProvider).ToArrayAsync();
                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}