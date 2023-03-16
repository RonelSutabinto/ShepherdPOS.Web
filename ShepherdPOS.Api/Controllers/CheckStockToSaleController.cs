//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//========Linq codinghttps://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx=====================
//==============================================================================================================================


using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.DataTObject;
using ShepherdPOS.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckStockSaleController : ControllerBase
    {
        readonly ApplicationDbContext DBContext;
        readonly IMapper DBmapper;
        readonly ILogger<CheckStockSaleController> AppLogger;

        public CheckStockSaleController(ApplicationDbContext context, IMapper mapper, ILogger<CheckStockSaleController> logger)
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
                var product = await DBContext.Products.FindAsync(CartQuantityRequestDto.ProductId);
                var checkStock = DBContext.Stocks.Where(stock => stock.ProductId == CartQuantityRequestDto.ProductId).Sum(stock => stock.Quantity);
                var productSold = DBContext.SaleProducts.Where(sale => sale.Barcode == product!.Barcode).Count();
                var result = checkStock - productSold - CartQuantityRequestDto.CartQuantity > 0 ? true : false;

                return result;
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
                var result = await (from product in DBContext.Products select new ProductStockView
                                          {
                                              ProductId = product.Id,
                                              ProductName = product.ProductName,
                                              ProductStockAdded = ((from stock in DBContext.Stocks where stock.ProductId == product.Id select stock.Quantity).Sum()),
                                              ProductSold = ((from sold in DBContext.SaleProducts where sold.Barcode == product.Barcode select sold).Count()),
                                              RequiredOrderStockValue = product.MinimumStock
                                          }).OrderBy(pstock => pstock.IsMinimumStock).ThenBy(pstock => pstock.ProductName).ToArrayAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }

        }




    }
}