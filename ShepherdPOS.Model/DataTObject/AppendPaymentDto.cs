//==============================================================================================================================
//Creates AppendPaymentDto dto Model for the ShepherdPO database ===============================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Models.DataTObject
{
    public class AppendPaymentDto
    {
        public AppendPaymentDto(decimal amountDue) { AmountDue = amountDue; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountDue { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LeftToPay { get { return AmountDue - PaymentAmount; } }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Amount cannot be below 0.")]
        public decimal PaymentAmount { get; set; }

        public int SaleId { get; set; }
    }
}

