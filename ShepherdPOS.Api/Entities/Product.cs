using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public int ProductCategoryId { get; set; }

        public string Barcode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TaxAmount { get; set; }

        public int MinimumStock { get; set; }

        public string ProductBand { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;


        public ProductCategory? ProductCategory { get; set; }
    }
}

