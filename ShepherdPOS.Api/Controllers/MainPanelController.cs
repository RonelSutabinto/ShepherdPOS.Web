//================================================================================================================================
//This part of code uses LINQ Query to capture transaction histories from the database tables.====================================
//================================================================================================================================
//Try this link for more detailshttps://www.dotnettricks.com/learn/linq/understanding-linq-standard-query-operators===============
//================================================================================================================================

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

        public MainPanelController(ApplicationDbContext context, ILogger<SaleController> logger)
        {
            appLogger = logger;
            DBContext = context;
        }

        [HttpGet]
        public async Task<MainPanelView> GetAll()
        {
            try
            {
                var totalSales = DBContext.Sales.Sum(s => s.AmountDue);

                var totalItemsSold = DBContext.SaleProducts.Select(p => p.Barcode).Distinct().Count();

                var totalItems = DBContext.Products.Count();

                Decimal AccumulatedProfit = DBContext.Sales.Sum(s => s.AmountDue) * 3;

                var resultPanel = new MainPanelView
                {
                    TotalSales = totalSales,
                    TotalProduct = totalItems,
                    ItemsSold = totalItemsSold,
                    TotalAccumulatedProfit = AccumulatedProfit
                };

                return resultPanel;

            }
            catch (Exception)
            {
                throw;
            }




        }
    }
}