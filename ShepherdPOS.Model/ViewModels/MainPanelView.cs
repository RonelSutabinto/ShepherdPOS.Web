//==============================================================================================================================
//Creates MainPanelView Model that contain fields that represent to the razor view main page  ==================================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=============
//==============================================================================================================================

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
