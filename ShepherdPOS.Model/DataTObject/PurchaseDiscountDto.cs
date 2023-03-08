using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTObject
{
    public class PurchaseDiscountDto
    {
        [Required]
        [Range(1, 99)]
        public decimal DiscountAmount { get; set; }
    }
}
