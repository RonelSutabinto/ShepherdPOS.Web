namespace ShepherdPOS.Models.ViewModel
{
    public class StockView
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = default!;

        public int StockAdded { get; set; }

        public int ItemsSold { get; set; }

        public int StockRemaining
        {
            get
            {
                return StockAdded - ItemsSold;
            }
        }

        public int ReorderAtStockLevel { get; set; }

        public bool StockLevelCritical
        {
            get
            {
                return StockRemaining <= ReorderAtStockLevel ? true : false;
            }
        }
    }
}
