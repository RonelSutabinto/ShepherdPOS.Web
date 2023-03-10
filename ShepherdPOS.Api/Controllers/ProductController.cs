//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//==============================================================================================================================



using AutoMapper;
using AutoMapper.Internal;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.DataTObject;
using ShepherdPOS.Models.ViewModels;


namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        readonly ILogger<ProductController> Applogger;
        readonly ApplicationDbContext DBContext;
        readonly IMapper DBmapper;
        
        public ProductController(ApplicationDbContext context,IMapper mapper,ILogger<ProductController> logger)
        {
            DBContext = context;
            DBmapper = mapper;
            Applogger = logger;
        }

        [HttpPost]
        public async Task Create(UpdateProductDto productDTO)
        {
            await DBContext.AddAsync(DBmapper.Map<Product>(productDTO));
            await DBContext.SaveChangesAsync();
        }


        [HttpGet]
        public async Task<IEnumerable<SelectProductView>> GetAll()
        {
            
            try
            {
                var result = await DBContext.Products.ProjectTo<SelectProductView>(DBmapper.ConfigurationProvider).OrderBy(pc => pc.ProductName).ToArrayAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPut]
        public async Task Update(UpdateProductDto productDTO)
        {
            Product product = await DBContext.Products.FindAsync(productDTO.Id);

            DBmapper.Map(productDTO, product);
            DBContext.Update(product);

            await DBContext.SaveChangesAsync();
        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            Product product = await DBContext.Products.FindAsync(id);

            DBContext.Remove(product);
            await DBContext.SaveChangesAsync();
        }

        [HttpGet("getproductforupdate/{id:int}")]
        public async Task<UpdateProductDto> GetProductforUpdate(int id)
        {
            
            try
            {
                var resutl = await DBContext.Products.Where(pc => pc.Id == id).ProjectTo<UpdateProductDto>(DBmapper.ConfigurationProvider).FirstAsync();
                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet("selecteditemlist")]
        public async Task<IEnumerable<SelectedItemValueDto>> SelectedItemlist()
        {
            try
            {
                var resutl = await DBContext.Products.ProjectTo<SelectedItemValueDto>(DBmapper.ConfigurationProvider).OrderBy(s => s.Text).ToArrayAsync();
                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
             
        }

        
    }
}