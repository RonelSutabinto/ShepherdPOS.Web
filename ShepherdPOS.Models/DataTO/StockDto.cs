using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTO
{
    public class StockDTO
    {
        public int ProductId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}
