using System.ComponentModel.DataAnnotations;

namespace ShepherdPOS.Models.DataTObject
{
    public class AppendStockDto
    {
        public int ProductId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Quantity must be not less than to one.")]
        public int Quantity { get; set; }
    }
}
