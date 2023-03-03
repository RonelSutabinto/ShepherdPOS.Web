using AutoMapper;
using AutoMapper.QueryableExtensions;
//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.Data;
using ShepherdPOS.Api.Entities;

using ShepherdPOS.Models.DataTO;
using ShepherdPOS.Models.ViewModel;
namespace ShepherdPOS.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ShepherdPosDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<SaleController> _logger;

        public SaleController(ShepherdPosDbContext context,
            IMapper mapper,
            ILogger<SaleController> logger)
        {
            _context = context;
            this._mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<SalesMasterView>> Get()
        {
            return await _context
                .Sales
                .Include(s => s.Transactions)
                .OrderByDescending(s => s.Timestamp)
                .Select(s => new SalesMasterView
                {
                    Id = s.Id,
                    Timestamp = s.Timestamp,
                    Quantity = s.Quantity,
                    Tax = s.Tax,
                    Total = s.Due,
                    Discount = s.Discount,
                    Due = s.Due,
                    Paid = s.Transactions!.Where(st => st.Type == SaleTransactionType.Payment.ToString()).Sum(st => st.Amount)
                })
                .ToArrayAsync();
        }

        [HttpGet("details/{id:int}")]
        public async Task<PurchaseDetailView> GetSaleDetails(int id)
        {
            return await _context
                .Sales
                .Where(s => s.Id == id)
                .Include(s => s.SaleProducts)
                .Include(s => s.Transactions)
                .Select(s => new PurchaseDetailView
                {
                    Timestamp = s.Timestamp,
                    Quantity = s.Quantity,
                    Tax = s.Tax,
                    Total = s.Total,
                    Discount = s.Discount,
                    Due = s.Due,
                    Paid = s.Transactions!.Where(st => st.Type == SaleTransactionType.Payment.ToString()).Sum(st => st.Amount),
                    Products = _mapper.Map<IEnumerable<SaleDetailProductViewModel>>(s.SaleProducts),
                    Transactions = _mapper.Map<IEnumerable<SaleDetailTransactionViewModel>>(s.Transactions)
                })
                .FirstAsync();
        }

        [HttpPost]
        public async Task NewSale(ResetSaleDto newSaleDTO)
        {
            Sale newSale = GetNewSale(newSaleDTO);
            await _context.AddAsync(newSale);
            await _context.SaveChangesAsync();
        }

        private static Sale GetNewSale(ResetSaleDto newSaleDTO)
        {
            DateTime timestamp = DateTime.Now;

            Sale sale = new()
            {
                Timestamp = timestamp,
                Quantity = newSaleDTO.PosCart.Quantity,
                Tax = newSaleDTO.PosCart.Tax,
                Total = newSaleDTO.PosCart.Total,
                Discount = newSaleDTO.PosCart.DiscountAmount,
                Due = newSaleDTO.PosCart.Due,
                SaleProducts = GetNewSaleProducts(newSaleDTO.PosCart.Rows, timestamp),
                Transactions = GetNewSaleTransactions(newSaleDTO.Payment.PaymentAmount, timestamp)
            };

            return sale;
        }

        private static List<SaleProduct> GetNewSaleProducts(List<CartRow> cartLines, DateTime timestamp)
        {
            List<SaleProduct> saleProducts = new();

            foreach (var cartLine in cartLines)
            {
                for (int i = 0; i < cartLine.Quantity; i++)
                {
                    saleProducts.Add(new SaleProduct
                    {
                        Timestamp = timestamp,
                        Code = cartLine.Product.Code,
                        Name = cartLine.Product.Name,
                        Price = cartLine.Product.Price,
                        Tax = cartLine.Product.Tax
                    });
                }
            }

            return saleProducts;
        }

        private static List<Transaction> GetNewSaleTransactions(decimal paymentAmount, DateTime timestamp)
        {
            return new List<Transaction>
            {
                new Transaction
                {
                    Timestamp = timestamp,
                    Type = SaleTransactionType.Payment.ToString(),
                    Amount = paymentAmount
                }
            };
        }

        [HttpPost]
        [Route("addpayment")]
        public async Task AddPaymentToSale(PaymentDto addPaymentDTO)
        {
            Transaction saleTransaction = new Transaction
            {
                SaleId = addPaymentDTO.SaleId,
                Timestamp = DateTime.Now,
                Type = SaleTransactionType.Payment.ToString(),
                Amount = addPaymentDTO.PaymentAmount
            };
            await _context.AddAsync(saleTransaction);
            await _context.SaveChangesAsync();
        }
    }
}