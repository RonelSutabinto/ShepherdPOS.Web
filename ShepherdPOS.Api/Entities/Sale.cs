using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShepherdPOS.Api.Entities
{
    [Table("Sales", Schema = "dbo")]
    public class Sale
    {
     
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public int Qnty { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountDue { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

      
        public List<SaleProduct>? SaleProducts { get; set; }

        public List<PosCartTransaction>? PosCartTransactions { get; set; }
    }
}
