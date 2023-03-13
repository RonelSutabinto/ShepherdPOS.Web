namespace ShepherdPOS.Api.Entities
{
    public class Stock
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Product? Product { get; set; }
    }
}