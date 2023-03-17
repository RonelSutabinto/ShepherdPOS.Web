//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//========Linq codinghttps://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx=====================
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

        public ProductController(ApplicationDbContext context, IMapper mapper, ILogger<ProductController> logger)
        {
            DBContext = context;
            DBmapper = mapper;
            Applogger = logger;
        }

        [HttpPost]
        public async Task Create(UpdateProductDto productDto)
        {
            await DBContext.AddAsync(DBmapper.Map<Product>(productDto));
            await DBContext.SaveChangesAsync();
        }


        [HttpGet]
        public async Task<IEnumerable<SelectProductView>> GetAll()
        {
            try
            {
                return await DBContext.Products.ProjectTo<SelectProductView>(DBmapper.ConfigurationProvider).OrderBy(pc => pc.Barcode)
                .Select(product => new SelectProductView
                {
                    Id = product.Id,
                    Barcode = product.Barcode,
                    ProductName = product.ProductName,
                    SalePrice = product.SalePrice,
                    ImageURL = product.ImageURL,
                    //ProductBand = product.ProductBand,
                    ProductCategoryId = product.ProductCategoryId,
                    TaxAmount = product.TaxAmount,
                    MinimumStock = product.MinimumStock
                }).ToArrayAsync();
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpPut]
        public async Task Update(UpdateProductDto productDTO)
        {
            try
            {
                Product product = await DBContext.Products.FindAsync(productDTO.Id);

                DBmapper.Map(productDTO, product);
                DBContext.Update(product);

                await DBContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

           
        }

        [HttpGet("getproductforupdate/{id:int}")]
        public async Task<UpdateProductDto> GetProductforUpdate(int id)
        {
            try
            {
                var result =  await DBContext.Products.Where(product => product.Id == id).ProjectTo<UpdateProductDto>(DBmapper.ConfigurationProvider).Select(product => new UpdateProductDto
                {
                    Id = product.Id,
                    ProductCategoryId = product.ProductCategoryId,
                    Barcode = product.Barcode,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    SalePrice = product.SalePrice,
                    TaxAmount = product.TaxAmount,
                    //ProductBand = product.ProductBand,
                    ImageURL = product.ImageURL,
                    MinimumStock = product.MinimumStock
                }).FirstAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                Product product = await DBContext.Products.FindAsync(id);

                DBContext.Remove(product);
                await DBContext.SaveChangesAsync();
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
                var result = await DBContext.Products.ProjectTo<SelectedItemValueDto>(DBmapper.ConfigurationProvider).OrderBy(sItem => sItem.Text).ToArrayAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }




    }
}