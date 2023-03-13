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

            try
            {
                var productRequest = await DBContext.Products.FindAsync(CartQuantityRequestDto.ProductId);
                var checkStockRequest = DBContext.Stocks.Where(stock => stock.ProductId == CartQuantityRequestDto.ProductId).Sum(qnty => qnty.Quantity);
                var totalProductSoldRequest = DBContext.SaleProducts.Where(sales => sales.Barcode == product!.Barcode).Count();
                return checkStockRequest - totalProductSoldRequest - CartQuantityRequestDto.CartQuantity > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IEnumerable<ProductStockView>> GetAll()
        {
            try
            {
                var checkRecordsRequest = await (from product in DBContext.Products.OrderBy(mvs => vm.IsMinimumStock).ThenBy(mvs => mvs.ProductName)
                                        select new ProductStockView
                                        { 
                                            ProductId = product.Id, ProductName = product.ProductName,ProductStockAdded = ( (from stock in DBContext.Stocks where stock.ProductId == product.Id select stock.Quantity).Sum()),
                                            totalProductSoldRequest = ( (from sales in DBContext.SaleProducts where sales.Barcode == product.Barcode select sales).Count()),
                                            RequiredOrderStockValue = product.MinimumStock
                                        }).ToArrayAsync();


                return checkRecordsRequest;
            }
            catch (Exception)
            {
                throw;
            }
        }

        

        
    }
}