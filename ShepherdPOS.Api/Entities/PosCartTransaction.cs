using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Api.Entities
{
    public class PosCartTransaction
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int SaleId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string PaymentType { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public Sale? Sale { get; set; }
    }
}
