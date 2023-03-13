namespace ShepherdPOS.Models.DataTObject
{
    public class CartQuantityRequestDto
    {
        public int ProductId { get; set; }
        
        [Required]
        public int CartQuantity { get; set; }
    }
}