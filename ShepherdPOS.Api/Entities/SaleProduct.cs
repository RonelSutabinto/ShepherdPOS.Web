using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Api.Entities
{
    public class SaleProduct
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        public DateTime DateTime { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; }


        public Sale? Sale { get; set; }
    }
}

