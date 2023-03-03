using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.Entities;
using ShepherdPOS.Api.Data;

using ShepherdPOS.Models.DataTO;
using ShepherdPOS.Models.ViewModel;

namespace ShepherdPOS.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly ShepherdPosDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<StockController> _logger;

        public StockController(ShepherdPosDbContext context,
            IMapper mapper,
            ILogger<StockController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<StockView>> Get()
        {
            var stockRecords = await (from p in _context.Products
                                      select new StockView
                                      {
                                          ProductId = p.Id,
                                          ProductName = p.Name,
                                          StockAdded = (
                                            (from s in _context.Stocks
                                             where s.ProductId == p.Id
                                             select s.Quantity).Sum()
                                          ),
                                          ItemsSold = (
                                            (from s in _context.SaleProducts
                                             where s.Code == p.Code
                                             select s).Count()
                                          ),
                                          ReorderAtStockLevel = p.ReorderAtStockLevel
                                      })
                              .ToArrayAsync();

            return stockRecords
                .OrderBy(vm => vm.StockRemaining)
                .ThenBy(vm => vm.ProductName);
        }

        [HttpPost]
        public async Task Add(StockDTO addStockDTO)
        {
            await _context.AddAsync(_mapper.Map<Stock>(addStockDTO));
            await _context.SaveChangesAsync();
        }

        [HttpPost]
        [Route("request")]
        public async Task<bool> StockRequest(GetStockDto stockRequestDTO)
        {
            var product = await _context
                .Products
                .FindAsync(stockRequestDTO.ProductId);

            var stock = _context
                .Stocks
                .Where(s => s.ProductId == stockRequestDTO.ProductId)
                .Sum(s => s.Quantity);

            var sold = _context
                .SaleProducts
                .Where(s => s.Code == product!.Code)
                .Count();

            return stock - sold - stockRequestDTO.CartQuantity > 0 ? true : false;
        }
    }
}