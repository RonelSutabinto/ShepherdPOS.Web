namespace ShepherdPOS.Models.ViewModels
{
    public class MainPanelView
    {
        public decimal TotalSales { get; set; }

        [Reuired]
        public int ReorderStock { get; set; }

        [Reuired]
        public int ItemsSold { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAccumulatedProfit { get; set; }

        [Reuired]
        public int TotalProduct { get; set; }

    }
}
