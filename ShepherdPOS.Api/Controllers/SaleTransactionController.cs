//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//==============================================================================================================================



using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.Classes;
using ShepherdPOS.Models.DataTObject;
using ShepherdPOS.Models.ViewModels;

namespace ShepherdPOS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ControllerBase
    {
        readonly ApplicationDbContext DBContext;
        readonly IMapper DBmapper;
        readonly ILogger<SaleController> Applogger;

        public SaleController(ApplicationDbContext context,IMapper mapper,ILogger<SaleController> logger)
        {
            DBContext = context;
            this.DBmapper = mapper;
            Applogger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<SalesMasterView>> Get()
        {
            return await DBContext
                .Sales.Include(s => s.PosCartTransactions).OrderByDescending(s => s.DateTime)
                .Select(s => new SalesMasterView
                {
                    Id = s.Id,
                    DateTime = s.DateTime,
                    Qnty = s.Qnty,
                    TaxAmount = s.Tax,
                    TotalAmount = s.TotalAmount,
                    Discount = s.Discount,
                    AmountDue = s.AmountDue,
                    AmountPaid = s.PosCartTransactions!.Where(st => st.PaymentType == PosCartTransactionType.Payment.ToString()).Sum(st => st.Amount)
                }).ToArrayAsync();
        }
        
        [HttpGet("details/{id:int}")]
        public async Task<SalesTransDetailsView> GetSaleDetails(int id)
        {
            return await DBContext
                .Sales
                .Where(s => s.Id == id).Include(s => s.SaleProducts).Include(s => s.PosCartTransactions)
                .Select(s => new SalesTransDetailsView
                {
                    DateTime = s.DateTime,
                    Qnty = s.Qnty,
                    TaxAmount = s.Tax,
                    TotalAmount = s.TotalAmount,
                    Discount = s.Discount,
                    AmountDue = s.AmountDue,
                    AmountPaid = s.PosCartTransactions!.Where(st => st.PaymentType == PosCartTransactionType.Payment.ToString()).Sum(st => st.Amount),
                    Products = DBmapper.Map<IEnumerable<SaleDetailSelectProductView>>(s.SaleProducts),
                    Transactions = DBmapper.Map<IEnumerable<SaleDetailTransactionViewModel>>(s.PosCartTransactions)
                }).FirstAsync();
        }

        [HttpPost]
        public async Task PosStart(StartPosDto StartPosDto)
        {
            Sale newSale = GetPosStart(StartPosDto);
            await DBContext.AddAsync(newSale);
            await DBContext.SaveChangesAsync();
        }

        private static Sale GetPosStart(StartPosDto StartPosDto)
        {
            DateTime timestamp = DateTime.Now;

            Sale sale = new()
            {
                DateTime = timestamp,
                Qnty = StartPosDto.Cart.Quantity,
                Tax = StartPosDto.Cart.TaxAmount,
                TotalAmount = StartPosDto.Cart.TotalAmount,
                Discount = StartPosDto.Cart.DiscountAmount,
                AmountDue = StartPosDto.Cart.AmountDue,
                SaleProducts = GetLatestPosProducts(StartPosDto.Cart.Rows, timestamp),
                PosCartTransactions = GetNewPosCartTransactions(StartPosDto.Payment.PaymentAmount, timestamp)
            };

            return sale;
        }

        private static List<SaleProduct> GetLatestPosProducts(List<CartRow> cartRows, DateTime timestamp)
        {
            List<SaleProduct> saleProducts = new();
            foreach (var cartRow in cartRows)
            {
                for (int i = 0; i < cartRow.Quantity; i++)
                {
                    saleProducts.Add(new SaleProduct
                    {
                        DateTime = timestamp,
                        Barcode = cartRow.Product.Barcode,
                        ProductName = cartRow.Product.ProductName,
                        SalePrice = cartRow.Product.SalePrice,
                        TaxAmount = cartRow.Product.TaxAmount
                    });
                }
            }

            return saleProducts;
        }

        private static List<PosCartTransaction> GetNewPosCartTransactions(decimal pAmount, DateTime datetime)
        {
            return new List<PosCartTransaction>
            {
                new PosCartTransaction
                {
                    DateTime = datetime,
                    PaymentType = PosCartTransactionType.Payment.ToString(),
                    Amount = pAmount
                }
            };
        }

        [HttpPost]
        [Route("addpayment")]
        public async Task AddPaymentToSale(AppendPaymentDto AppendPaymentDto)
        {
            PosCartTransaction PosCartTransaction = new PosCartTransaction
            {
                SaleId = AppendPaymentDto.SaleId,
                DateTime = DateTime.Now,
                PaymentType = PosCartTransactionType.Payment.ToString(),
                Amount = AppendPaymentDto.PaymentAmount
            };
            await DBContext.AddAsync(PosCartTransaction);
            await DBContext.SaveChangesAsync();
        }
    }
}