//==============================================================================================================================
//This part of code was used auto mapper llibrary. It will transform one object type into another================================
//Reduce complexity of queries with AutoMapper==================================================================================
//By employing AutoMapper and directly querying DTOs rather than entities, you can greatly reduce===============================
//the complexity of your database searches======================================================================================
//==Try this link for more detailshttps://dev.to/cloudx/entity-framework-core-simplify-your-queries-with-automapper-3m8k========
//=============Another link Tutorialhttps://tech.playgokids.com/auto-mapper-net6/===============================================
//==============================================================================================================================


using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.AppDataContext;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Models.Classes;
using ShepherdPOS.Models.DataTObject;
using ShepherdPOS.Models.ViewModels;
using ShepherdPOS.Web.Pages.PosPage;

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
        public async Task<IEnumerable<SalesMasterView>> GetAll()
        {
            try
            {

                var result = await this.DBContext.Sales.Include(_sale => _sale.PosCartTransactions).OrderByDescending(_sale => _sale.Id)
                            .Select(_sale => new SalesMasterView
                            {
                                Id = _sale.Id,
                                DateTime = _sale.DateTime,
                                Qnty = _sale.Qnty,
                                TaxAmount = _sale.Tax,
                                TotalAmount = _sale.TotalAmount,
                                Discount = _sale.Discount,
                                AmountDue = _sale.AmountDue,
                                AmountPaid = _sale.PosCartTransactions!.Where(pct => pct.PaymentType == PosCartTransactionType.PurchasePayment.ToString()).Sum(pct => pct.Amount)
                            }).ToArrayAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }


        }
        
        [HttpGet("details/{id:int}")]
        public async Task<SalesTransDetailsView> GetSaleDetails(int id)
        {
            try
            {
                return await DBContext
                .Sales
                .Where(_sale => _sale.Id == id).Include(_sale => _sale.SaleProducts).Include(_sale => _sale.PosCartTransactions)
                .Select(_sale => new SalesTransDetailsView
                {
                    DateTime = _sale.DateTime,
                    Qnty = _sale.Qnty,
                    TaxAmount = _sale.Tax,
                    TotalAmount = _sale.TotalAmount,
                    Discount = _sale.Discount,
                    AmountDue = _sale.AmountDue,
                    AmountPaid = _sale.PosCartTransactions!.Where(pct => pct.PaymentType == PosCartTransactionType.PurchasePayment.ToString()).Sum(pct => pct.Amount),
                    Products = DBmapper.Map<IEnumerable<SaleDetailSelectProductView>>(_sale.SaleProducts),
                    Transactions = DBmapper.Map<IEnumerable<SaleDetailTransactionViewModel>>(_sale.PosCartTransactions)
                }).FirstAsync();
            }
            catch (Exception)
            {
                throw;
            }

            
        }

        private static List<SaleProduct> GetLatestPosProducts(List<CartRow> cartRows, DateTime timestamp)
        {

            try
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
            catch (Exception)
            {
                throw;
            }

            
        }

        private static List<PosCartTransaction> GetNewPosCartTransactions(decimal pAmount, DateTime datetime)
        {
            try
            {
                var result = new List<PosCartTransaction>
            {
                new PosCartTransaction
                {
                    DateTime = datetime,
                    PaymentType = PosCartTransactionType.PurchasePayment.ToString(),
                    Amount = pAmount
                }
            };

                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPost]
        [Route("addpayment")]
        public async Task AddPaymentToSale(AppendPaymentDto AppendPaymentDto)
        {
            PosCartTransaction PosCartTransaction = new PosCartTransaction
            {
                SaleId = AppendPaymentDto.SaleId,
                DateTime = DateTime.Now,
                PaymentType = PosCartTransactionType.PurchasePayment.ToString(),
                Amount = AppendPaymentDto.PaymentAmount
            };
            await DBContext.AddAsync(PosCartTransaction);
            await DBContext.SaveChangesAsync();
        }
    }
}