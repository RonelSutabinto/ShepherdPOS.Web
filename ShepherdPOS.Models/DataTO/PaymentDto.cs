using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTO{
    public class PaymentDto
    {
        public PaymentDto(decimal amountDue)
        {
            AmountDue = amountDue;
        }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount cannot be negative value.")]
        [Display(Name = "Payment Amount")]
        public decimal PaymentAmount { get; set; }

        public decimal AmountDue { get; set; }

        public decimal LeftToPay
        {
            get
            {
                return AmountDue - PaymentAmount;
            }
        }

        public int SaleId { get; set; }
    }
}
