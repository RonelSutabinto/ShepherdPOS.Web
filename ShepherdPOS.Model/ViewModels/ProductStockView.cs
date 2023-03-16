//==============================================================================================================================
//Creates ProductStockView Model that contain fields that represent to the razor view of product stocks ========================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=============
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.ViewModels
{
    public class ProductStockView
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty!;

        [Required]
        public int ProductStockAdded { get; set; }

        [Required]
        public int ProductSold { get; set; }

        public int StockBalance { get { return ProductStockAdded - ProductSold; } }

        [Required]
        public int RequiredOrderStockValue { get; set; }

        public bool IsMinimumStock { get { return StockBalance <= RequiredOrderStockValue ? true : false; } }
    }
}


