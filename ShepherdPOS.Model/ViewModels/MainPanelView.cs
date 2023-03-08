namespace ShepherdPOS.Models.ViewModels
{
    public class MainPanelView
    {
        public decimal TotalSales { get; set; }

        public int ReorderStock { get; set; }

        public int ItemsSold { get; set; }

        public decimal TotalAccumulatedProfit { get; set; }

        public int TotalProduct { get; set; }

    }
}
