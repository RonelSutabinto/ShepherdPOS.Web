using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTObject
{
    public class AppendPaymentDto
    {
        public AppendPaymentDto(decimal amountDue) { AmountDue = amountDue; }

        public decimal AmountDue { get; set; }

        public decimal LeftToPay { get { return AmountDue - PaymentAmount; } }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount cannot be below 0.")]
        public decimal PaymentAmount { get; set; }

        public int SaleId { get; set; }
    }
}

