using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTO
{
    public class DiscountDto
    {
        [Required]
        [Range(1, 99)]
        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; }
    }
}
