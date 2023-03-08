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
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckStockSaleController : ControllerBase
    {
        readonly ApplicationDbContext DBContext;
        readonly IMapper DBmapper;
        readonly ILogger<CheckStockSaleController> AppLogger;

        public CheckStockSaleController(ApplicationDbContext context,IMapper mapper, ILogger<CheckStockSaleController> logger)
        {
            DBContext = context;
            DBmapper = mapper;
            AppLogger = logger;
        }

        [HttpPost]
        public async Task Add(AppendStockDto AppendStockDto)
        {
            await DBContext.AddAsync(DBmapper.Map<Stock>(AppendStockDto));
            await DBContext.SaveChangesAsync();
        }


        [HttpPost]
        [Route("request")]
        public async Task<bool> StockRequest(CartQuantityRequestDto CartQuantityRequestDto)
        {
            var product = await DBContext.Products.FindAsync(CartQuantityRequestDto.ProductId);
            var checkStock = DBContext.Stocks.Where(s => s.ProductId == CartQuantityRequestDto.ProductId).Sum(s => s.Quantity);
            var productSold = DBContext.SaleProducts.Where(s => s.Barcode == product!.Barcode).Count();
            return checkStock - productSold - CartQuantityRequestDto.CartQuantity > 0 ? true : false;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductStockView>> GetAll()
        {
            var checkRecords = await (from p in DBContext.Products
                                      select new ProductStockView
                                      { ProductId = p.Id, ProductName = p.ProductName,ProductStockAdded = (
                                            (from s in DBContext.Stocks where s.ProductId == p.Id select s.Quantity).Sum()
                                          ),
                                          ProductSold = (
                                            (from s in DBContext.SaleProducts where s.Barcode == p.Barcode select s).Count()
                                          ),
                                          RequiredOrderStockValue = p.MinimumStock
                                      }).ToArrayAsync();


            return checkRecords.OrderBy(vm => vm.IsMinimumStock).ThenBy(vm => vm.ProductName);
        }

        

        
    }
}