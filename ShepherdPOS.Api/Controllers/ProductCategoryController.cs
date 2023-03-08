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
        public async Task<IEnumerable<ProductGroupView>> Get()
        {
            return await DBContext.ProductCategories.ProjectTo<ProductGroupView>(DBmapper.ConfigurationProvider)
                .OrderBy(pc => pc.CategoryName).ToArrayAsync();
        }

        [HttpGet("getproductforupdate/{id:int}")]
        public async Task<UpdateProductCategoryDto> getproductforupdate(int id)
        {
            return await DBContext.ProductCategories.Where(pc => pc.Id == id)
                .ProjectTo<UpdateProductCategoryDto>(DBmapper.ConfigurationProvider).FirstAsync();
        }

        [HttpGet("selecteditemlist")]
        public async Task<IEnumerable<SelectedItemValueDto>> selecteditemlist()
        {
            return await DBContext
                .ProductCategories
                .ProjectTo<SelectedItemValueDto>(DBmapper.ConfigurationProvider).ToArrayAsync();
        }

        [HttpPost]
        public async Task Create(UpdateProductCategoryDto productCategoryDTO)
        {
            await DBContext.AddAsync(DBmapper.Map<ProductCategory>(productCategoryDTO));
            await DBContext.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Update(UpdateProductCategoryDto productCategoryDTO)
        {
            ProductCategory productCategory = await DBContext.ProductCategories.FindAsync(productCategoryDTO.Id);

            DBmapper.Map(productCategoryDTO, productCategory);
            DBContext.Update(productCategory);
            await DBContext.SaveChangesAsync();
        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            ProductCategory productCategory = await DBContext.ProductCategories.FindAsync(id);

            DBContext.Remove(productCategory);
            await DBContext.SaveChangesAsync();
        }
    }
}