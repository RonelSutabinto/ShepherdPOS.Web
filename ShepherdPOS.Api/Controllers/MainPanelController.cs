using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainPanelController : ControllerBase
    {
        readonly ApplicationDbContext DBContext;
        readonly ILogger<SaleController> appLogger;
       
        public MainPanelController(ApplicationDbContext context,ILogger<SaleController> logger)
        {
            appLogger = logger;
            DBContext = context;   
        }

        [HttpGet]
        public async Task<MainPanelView> GetAll()
        {

            var totalSales = DBContext.Sales.Sum(s => s.AmountDue);

            var totalItemsSold = DBContext.SaleProducts.Select(product => product.Barcode).Distinct().Count();

            var totalItems = DBContext.Products.Count();

            Decimal AccumulatedProfit = DBContext.Sales.Sum(sales => sales.AmountDue) * 3 ;


            return new MainPanelView {
                TotalSales = totalSales,
                TotalProduct = totalItems,
                ItemsSold = totalItemsSold,
                TotalAccumulatedProfit = AccumulatedProfit,
            };
        }
    }
}