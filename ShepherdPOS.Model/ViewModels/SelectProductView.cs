//==============================================================================================================================
//Creates SelectProductView Model that contain fields that represent to the razor view of sales history=========================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=============
//==============================================================================================================================

using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.ViewModels
{
    public class SelectProductView
    {
        public int Id { get; set; }

        public int ProductCategoryId { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TaxAmount { get; set; }

        public int MinimumStock { get; set; }

        public string ProductBand { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;
    }
}