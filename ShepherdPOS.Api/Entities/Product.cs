
namespace ShepherdPOS.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public decimal Tax { get; set; }

        public int ReorderAtStockLevel { get; set; }

        public int Qty { get; set; }

        public string ImageURL { get; set; } = string.Empty;

        public ProductCategory? ProductCategory { get; set; }
    }
}
