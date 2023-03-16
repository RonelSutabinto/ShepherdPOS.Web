//==============================================================================================================================
//Creates SalesTransDetailsView Model that contain fields that represent to the razor view of transacgtion details =============
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=============
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.ViewModels
{
    public class SalesTransDetailsView
    {
        [Required(ErrorMessage = "Required the date and time.")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        public int Qnty { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TaxAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountDue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        public decimal Balance { get { return AmountDue - AmountPaid; } }

        public IEnumerable<SaleDetailSelectProductView>? Products { get; set; }
        public IEnumerable<SaleDetailTransactionViewModel>? Transactions { get; set; }
    }

    public class SaleDetailSelectProductView
    {
        public string Barcode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal TaxAmount { get; set; }
    }

    public class SaleDetailTransactionViewModel
    {
        public string Type { get; set; }

        public decimal Amount { get; set; }
    }
}


