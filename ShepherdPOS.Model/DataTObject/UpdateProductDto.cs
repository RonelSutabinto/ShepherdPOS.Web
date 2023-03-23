//==============================================================================================================================
//Creates UpdateProductDto dto Model for the ShepherdPO database ===============================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.DataTObject
{
    public class UpdateProductDto
    {
        public int Id { get; set; }

        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(15)]
        public string Barcode { get; set; }

        [Required]
        [StringLength(60)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        private decimal tprice;

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Negative tax value is invalid.")]
        public decimal TaxAmount { get; set; }

        //public string ProductBand { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Negative sale price is invalid.")]
        public decimal SalePrice
        {
            get { return tprice; }
            set
            {
                tprice = value;
                if (Id == 0)
                    TaxAmount = tprice * (decimal)0.25;
            }
        }

        [Range(0, int.MaxValue, ErrorMessage = "Reorder product stock must be less than or equal to minimm stock value.")]
        public int MinimumStock { get; set; }
    }
}


