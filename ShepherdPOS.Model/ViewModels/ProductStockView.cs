namespace ShepherdPOS.Models.ViewModels
{
    public class ProductStockView
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = default!;

        public int ProductStockAdded { get; set; }

        public int ProductSold { get; set; }

        public int StockBalance { get { return ProductStockAdded - ProductSold; } }

        public int RequiredOrderStockValue { get; set; }

        public bool IsMinimumStock { get { return StockBalance <= RequiredOrderStockValue ? true : false; } }
    }
}
