//==============================================================================================================================
//Creates SalesMasterView Model that contain fields that represent to the razor view of sales page =============================
//===Try this link for more detailshttps://www.dotnettricks.com/learn/mvc/understanding-viewmodel-in-aspnet-mvc=================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.ViewModels
{
    public class SalesMasterView
    {
        public int Id { get; set; }

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
    }
}


